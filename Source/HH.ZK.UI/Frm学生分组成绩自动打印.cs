using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Diagnostics;
using System.IO;
using System.Data;
using System.Threading;
using System.Windows.Forms;
using HH.ZK.Model;
using HH.ZK.Model.SearchCondition;
using HH.ZK.Model.CRM;
using HH.ZK.CommonUI;
using HH.ZK.WebAPIClient;
using LJH.GeneralLibrary;
using LJH.GeneralLibrary;

namespace HH.ZK.UI
{
    public partial class Frm学生分组成绩自动打印 : Form
    {
        private static Dictionary<string, StudentGroupWithTestState> __PrintedGroups = new Dictionary<string, StudentGroupWithTestState>();

        public Frm学生分组成绩自动打印()
        {
            InitializeComponent();
        }

        #region 私有变量
        private Thread _GetScoreThread = null;
        private bool _AutoPrint = false;
        private bool _EnableVoice = false;
        private string _ModelFile = null;
        private StudentGroupWithTestState _CurrentGroup = null;
        #endregion

        #region 私有方法
        private void GetScoreThread()
        {
            try
            {
                Thread.Sleep(2000);
                while (true)
                {
                    var con = new StudentGroupSearchCondition { };
                    var groups = new APIClient(AppSettings.Current.ConnStr).GetList<Guid, StudentGroupWithTestState>(con, AppSettings.Current.PhysicalProject.ID).QueryObjects;
                    if (groups != null && groups.Count > 0)
                    {
                        foreach (var gp in groups)
                        {
                            Action action = delegate ()
                            {
                                HandleGroup(gp);
                            };
                            this.Invoke(action);
                        }
                    }
                    Thread.Sleep(5000);
                }
            }
            catch (ThreadAbortException)
            {
            }
            catch (Exception)
            {
            }
        }

        private void HandleGroup(StudentGroupWithTestState gp)
        {
            int index = FindItemAt(gp, printedView);  //先在已打印的表格里面查询
            if (index == -1) //如果没有找到，当前记录就增加到待打印表格里面
            {
                index = FindItemAt(gp, printingView);
                if (index == -1)
                {
                    printingView.Rows.Insert(0, 1);
                    index = 0;
                }
                ShowGroupOnRow(printingView.Rows[index], gp);
                if (_AutoPrint && gp.Completed == gp.ItemsCount && __PrintedGroups.ContainsKey($"{gp.ID}_{gp.PhysicalItems}") == false) //自动打印分组
                {
                    try
                    {
                        var ret = PrintStudentGroup(gp);
                        if (ret)
                        {
                            printingView.Rows.RemoveAt(index);
                            printedView.Rows.Insert(0, 1);
                            ShowGroupOnRow(printedView.Rows[0], gp);
                        }
                        if (_EnableVoice) LJH.GeneralLibrary.Speech.TTSSpeech.Instance.Speek(gp.FullName + "测试完成，正在打印", false);
                    }
                    catch (Exception)
                    {

                    }
                }
            }
            else
            {
                ShowGroupOnRow(printedView.Rows[index], gp);
            }
        }

        private int FindItemAt(StudentGroupWithTestState item, DataGridView view)
        {
            var ret = -1;
            foreach (DataGridViewRow row in view.Rows)
            {
                var gp = row.Tag as StudentGroupWithTestState;
                if (gp.ID == item.ID && gp.PhysicalItems == item.PhysicalItems) return row.Index;
            }
            return ret;
        }

        private void ShowGroupOnRow(DataGridViewRow row, StudentGroupWithTestState sg)
        {
            row.Cells[0].Value = sg.FullName;
            row.Cells[1].Value = AppSettings.Current.PhysicalProject.PhysicalItems.GetNames(sg.PhysicalItems);
            row.Cells[2].Value = sg.ItemsCount;
            row.Cells[3].Value = sg.Tested;
            row.Cells[4].Value = sg.Completed;
            row.Cells[5].Value = "打印";
            row.Tag = sg;
        }

        private void ShowCurrentGroup(StudentGroupWithTestState sg)
        {
            studentView.Rows.Clear();
            var con = new StudentWithDXCJSearchCondition() { GroupID = sg.ID, PhysicalItem = int.Parse(sg.PhysicalItems) };
            var ss = new APIClient(AppSettings.Current.ConnStr).GetList<string, StudentWithDXCJ>(con, AppSettings.Current.PhysicalProject.ID).QueryObjects;
            if (ss != null && ss.Count > 0)
            {
                foreach (var student in ss)
                {
                    int row = studentView.Rows.Add();
                    ShowGroupPairOnRow(studentView.Rows[row],student);
                }
            }
            lblCount.Text = string.Format("共 {0} 项", studentView.Rows.Count);
            _CurrentGroup = sg;
        }

        private void ShowGroupPairOnRow(DataGridViewRow row, StudentWithDXCJ s)
        {
            row.Cells["colID"].Value = s.ID;
            row.Cells["colName"].Value = s.Name;
            row.Cells["colSex"].Value = s.Sex == Sex.Male ? "男" : "女";
            row.Cells["colChannel"].Value = s.Channel;
            row.Cells["colFacility"].Value = s.FacilityName;
            row.Cells["colPhysicalItem1"].Value = AppSettings.Current.PhysicalProject.PhysicalItems?.GetName(s.PhysicalItemID);
            var pi = AppSettings.Current.PhysicalProject.PhysicalItems?.GetPhysicalItem(s.PhysicalItemID);
            var score = s.GetScoreByIndex(0);
            if (score != null) row.Cells["colFirstScore"].Value = score.FormatScore;
            if (pi != null && pi.TestCount >= 2)
            {
                score = s.GetScoreByIndex(1);
                if (score != null) row.Cells["colSecondScore"].Value = score.FormatScore;
            }
            if (pi != null && pi.TestCount >= 3)
            {
                score = s.GetScoreByIndex(2);
                if (score != null) row.Cells["colThirdScore"].Value = score.FormatScore;
            }
            if (s.BestScoreID != null)
            {
                var best = s.BestScore;
                row.Cells["colScore"].Value = best.FormatScore;
                if (AppSettings.Current.Operator.PermitAny(Permission.总分, PermissionActions.Read))
                {
                    row.Cells["colResult"].Value = best.Result?.Trim();
                }
            }
            row.DefaultCellStyle.ForeColor = s.BestScoreID != null ? Color.Black : Color.Red;
        }

        private bool PrintStudentGroup(StudentGroupWithTestState gp)
        {
            try
            {
                if (!File.Exists(_ModelFile)) return false;
                string dir = LJH.GeneralLibrary.TempFolderManager.GetCurrentFolder();
                string desFile = System.IO.Path.Combine(dir, Guid.NewGuid() + ".xls");
                var exporter = new StudentWithDXCJExporter(_ModelFile);
                var pi = AppSettings.Current.PhysicalProject.PhysicalItems?.GetPhysicalItem(int.Parse(gp.PhysicalItems));
                var con = new StudentWithDXCJSearchCondition() { GroupID = gp.ID, PhysicalItem = int.Parse(gp.PhysicalItems) };
                var ss = new APIClient(AppSettings.Current.ConnStr).GetList<string, StudentWithDXCJ>(con, AppSettings.Current.PhysicalProject.ID).QueryObjects;
                exporter.Export(gp, pi, ss, desFile, txtTitle.Text);
                if (System.IO.File.Exists(desFile))
                {
                    ProcessStartInfo psi = new ProcessStartInfo(desFile);
                    psi.Verb = "Print";
                    psi.CreateNoWindow = true;
                    psi.WindowStyle = ProcessWindowStyle.Hidden;
                    psi.UseShellExecute = true;
                    Process prs = new Process();
                    prs.StartInfo = psi;
                    prs.Start();
                    prs.WaitForExit();
                    if (!__PrintedGroups.ContainsKey($"{gp.ID}_{gp.PhysicalItems}")) __PrintedGroups.Add($"{gp.ID}_{gp.PhysicalItems}", gp);
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }
        #endregion

        #region 事件处理程序
        private void Frm学生分组成绩自动打印_Load(object sender, EventArgs e)
        {
            chkAutoPrint.Checked = AppSettings.Current.GetConfigContent("AutoPrintCompletedGroup") != "0";
            _ModelFile = AppSettings.Current.GetConfigContent("StudentGroupScoresModel");
            if (string.IsNullOrEmpty(_ModelFile)) _ModelFile = Path.Combine(Application.StartupPath, "模板", "测试成绩模板.xls");
            var title = AppSettings.Current.GetConfigContent("StudentGroupScoresTitle");
            if (!string.IsNullOrEmpty(title)) txtTitle.Text = title;
            else txtTitle.Text = string.Format("{0}年中考体育考试成绩单", DateTime.Now.Year);
            txtModelFile.Text = _ModelFile;
            _AutoPrint = chkAutoPrint.Checked;
            _GetScoreThread = new Thread(new ThreadStart(GetScoreThread));
            _GetScoreThread.IsBackground = true;
            _GetScoreThread.Start();
        }

        private void groupView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var view = sender as DataGridView;
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var sg = view.Rows[e.RowIndex].Tag as StudentGroupWithTestState;
                ShowCurrentGroup(sg);
            }
        }

        private void groupView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var view = sender as DataGridView;
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var sg = view.Rows[e.RowIndex].Tag as StudentGroupWithTestState;
                if (view.Columns[e.ColumnIndex].Name == "colPrint" || view.Columns[e.ColumnIndex].Name == "colPrint1")
                {
                    if (!File.Exists(_ModelFile))
                    {
                        MessageBox.Show("没有找到成绩单模板,不能打印");
                        return;
                    }
                    var ret = PrintStudentGroup(sg);
                    if (ret && object.ReferenceEquals(view, printingView))
                    {
                        printingView.Rows.RemoveAt(e.RowIndex);
                        printedView.Rows.Insert(0, 1);
                        ShowGroupOnRow(printedView.Rows[0], sg);
                    }
                }
            }
        }

        private void chkAutoPrint_CheckedChanged(object sender, EventArgs e)
        {
            _AutoPrint = chkAutoPrint.Checked;
            AppSettings.Current.SaveConfig("AutoPrintCompletedGroup", _AutoPrint ? "1" : "0");
        }

        private void chk语音提示打印完成的组_CheckedChanged(object sender, EventArgs e)
        {
            _EnableVoice = chk语音提示打印完成的组.Checked;
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
            AppSettings.Current.SaveConfig("StudentGroupScoresTitle", txtTitle.Text.Trim());
        }

        private void btnModalBrowser_Click(object sender, EventArgs e)
        {
            OpenFileDialog dig = new OpenFileDialog();
            dig.Title = "选择模板";
            dig.Filter = "Excel文档|*.xls;*.xlsx|所有文件(*.*)|*.*";
            dig.InitialDirectory = System.IO.Path.Combine(Application.StartupPath, "模板");
            dig.RestoreDirectory = true;
            if (dig.ShowDialog() != DialogResult.OK) return;
            AppSettings.Current.SaveConfig("StudentGroupScoresModel", dig.FileName);
            _ModelFile = dig.FileName;
            txtModelFile.Text = dig.FileName;
        }

        private void Frm学生分组成绩自动打印_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_GetScoreThread != null) _GetScoreThread.Abort();
            _GetScoreThread = null;
        }
        #endregion


    }
}
