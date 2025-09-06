using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Data;
using System.Threading;
using System.Windows.Forms;
using HH.ZK.Model;
using HH.ZK.Model.SearchCondition;
using HH.ZK.CommonUI;
using HH.ZK.WebAPIClient;
using HH.ZK.UI.Controls;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace HH.ZK.UI
{
    public partial class Frm学生秩序册导出 : Form
    {
        public Frm学生秩序册导出()
        {
            InitializeComponent();
        }

        public List<StudentGroupSummary> PrintingGroups { get; set; }

        #region 私有变量
        private string _ExportTo = null;
        private int _Printed = 0;
        private int _秩序册模板 = 0;
        private bool _GroupBySex = false;
        private bool _CreateFacilityFolder = false;
        private Thread _exportThread = null;
        #endregion

        #region 私有方法
        private DataTable CreateTable(int 秩序册模板)
        {
            if (秩序册模板 == 1)
            {
                var db = new DataTable();
                db.Columns.Add("准考证号");
                db.Columns.Add("姓名");
                db.Columns.Add("性别");
                db.Columns.Add("身份证号");
                db.Columns.Add("班级名称");
                db.Columns.Add("考点");
                db.Columns.Add("考试时间");
                db.Columns.Add("考试科目");
                db.Columns.Add("组别");
                db.Columns.Add("道次");
                db.Columns.Add("学校");
                return db;
            }
            else if (秩序册模板 == 2)
            {
                var db = new DataTable();
                db.Columns.Add("学校");
                db.Columns.Add("组别");
                db.Columns.Add("性别");
                db.Columns.Add("考点");
                db.Columns.Add("考试时间");
                db.Columns.Add("考试科目");
                db.Columns.Add("第1道");
                db.Columns.Add("第2道");
                db.Columns.Add("第3道");
                db.Columns.Add("第4道");
                db.Columns.Add("第5道");
                db.Columns.Add("第6道");
                db.Columns.Add("第7道");
                db.Columns.Add("第8道");
                db.Columns.Add("第9道");
                db.Columns.Add("第10道");
                db.Columns.Add("第11道");
                db.Columns.Add("第12道");
                db.Columns.Add("第13道");
                db.Columns.Add("第14道");
                db.Columns.Add("第15道");
                db.Columns.Add("第16道");
                db.Columns.Add("第17道");
                db.Columns.Add("第18道");
                db.Columns.Add("第19道");
                db.Columns.Add("第20道");
                db.Columns.Add("备注");
                return db;
            }
            else if (秩序册模板 == 3)
            {
                var db = new DataTable();
                db.Columns.Add("准考证号");
                db.Columns.Add("考生姓名");
                db.Columns.Add("项目代码");
                db.Columns.Add("考点代码");
                db.Columns.Add("考试时间");
                db.Columns.Add("考试组别");
                db.Columns.Add("考试道次");
                return db;
            }
            return null;
        }

        private void 导出到文件_Thread()
        {
            try
            {
                _Printed = 0;
                var ret = 导出秩序册(_ExportTo, PrintingGroups, PrintingGroups.Count);
                _exportThread = null;
                this.Invoke((Action)(() =>
                {
                    this.lblMsg.Text = "导出完成";
                    this.progressBar1.Value = 100;
                    btn导出.Text = "开始导出";
                    if (ret && File.Exists(_ExportTo)) OpenFile(_ExportTo);
                }));
            }
            catch (ThreadAbortException)
            {
            }
            catch (Exception)
            {
            }
        }

        private void 导出到文件夹_Thread()
        {
            try
            {
                _Printed = 0;
                var groups = from it in PrintingGroups
                             group it by new { FacilityName = string.IsNullOrEmpty(it.FacilityName) ? "秩序册" : it.FacilityName, Sex = _GroupBySex ? it.Sex : null };
                foreach (var group in groups)
                {
                    string pdfFile = null;
                    pdfFile = _ExportTo;
                    if (_CreateFacilityFolder)
                    {
                        pdfFile = Path.Combine(pdfFile, group.Key.FacilityName);
                        if (!Directory.Exists(pdfFile)) Directory.CreateDirectory(pdfFile);
                    }
                    if (group.Key.Sex.HasValue) pdfFile = Path.Combine(pdfFile, $"{group.Key.FacilityName}({SexStr(group.Key.Sex.Value)}).xls");
                    else pdfFile = Path.Combine(pdfFile, $"{group.Key.FacilityName}.xls");
                    导出秩序册(pdfFile, group.ToList(), PrintingGroups.Count);
                }
                _exportThread = null;
                this.Invoke((Action)(() =>
                {
                    this.lblMsg.Text = "导出完成";
                    this.progressBar1.Value = 100;
                    btn导出.Text = "开始导出";
                }));
            }
            catch (ThreadAbortException)
            {
            }
            catch (Exception)
            {
            }
        }

        private string SexStr(Sex sex)
        {
            return sex == Sex.Male ? "男" : "女";
        }

        private void OpenFile(string pdfFile)
        {
            if (System.IO.File.Exists(pdfFile))
            {
                try
                {
                    System.Diagnostics.Process.Start(pdfFile);
                }
                catch (Exception ex)
                {
                    LJH.GeneralLibrary.ExceptionPolicy.HandleException(ex);
                }
            }
        }

        private void DeleteFile(string pdfFile)
        {
            if (System.IO.File.Exists(pdfFile))
            {
                try
                {
                    File.Delete(pdfFile);
                }
                catch (Exception ex)
                {
                    LJH.GeneralLibrary.ExceptionPolicy.HandleException(ex);
                }
            }
        }

        private void AppendError(string error)
        {
            Action action = delegate ()
            {
                txtError.AppendText(error);
                txtError.AppendText(System.Environment.NewLine);
            };
            if (this.InvokeRequired) this.Invoke(action);
            else action();
        }

        private bool 导出秩序册(string file, List<StudentGroupSummary> items, int totalCount)
        {
            try
            {
                var db = CreateTable(_秩序册模板);
                foreach (var gp in items)
                {
                    _Printed++;
                    Action action = delegate ()
                    {
                        this.lblMsg.Text = string.Format("共 {0} 组 正在导出第 {1} 组 {2} ...", totalCount, _Printed, gp.FullName);
                        this.progressBar1.Value = (int)((decimal)_Printed / totalCount * 100);
                    };
                    this.Invoke(action);
                    导出组别秩序册(gp, db, _秩序册模板);
                }
                LJH.GeneralLibrary.WinForm.NPOIExcelHelper.Export(db, file);
                return true;
            }
            catch (ThreadAbortException)
            {
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void 导出组别秩序册(StudentGroupSummary gp, DataTable db, int 模板样式)
        {
            try
            {
                var con = new StudentSearchCondition() { GroupID = gp.ID };
                var cr = new APIClient(AppSettings.Current.ConnStr).GetList<string, Student>(con, AppSettings.Current.PhysicalProject.ID);
                if (cr.Result != LJH.GeneralLibrary.ResultCode.Successful)
                {
                    AppendError($"{gp.FullName} 获取学生信息失败，未导到秩序册");
                }
                else
                {
                    var ss = cr.QueryObjects;
                    if (ss == null || ss.Count == 0) return;
                    if (模板样式 == 1) 导出模板1(gp, db, ss);
                    else if (模板样式 == 2) 导出模板2(gp, db, ss);
                    else if (模板样式 == 3) 导出模板3(gp, db, ss);
                }
            }
            catch (Exception ex)
            {
                LJH.GeneralLibrary.ExceptionPolicy.HandleException(ex);
            }
        }

        private void 导出模板1(StudentGroupSummary gp, DataTable db, List<Student> ss)
        {
            foreach (var s in ss)
            {
                db.Rows.Add(
                            s.ID,
                            s.Name,
                            s.Sex == Sex.Male ? "男" : "女",
                            s.IDNumber,
                            s.ClassName,
                            AppSettings.Current.PhysicalProject.Name,
                            gp.PlanDate,
                            AppSettings.Current.PhysicalProject.PhysicalItems?.GetNames(!string.IsNullOrEmpty(gp.PhysicalItems) ? gp.PhysicalItems : s.PhysicalItems),
                            gp.Number,
                            s.Channel,
                            s.FacilityName
                           );
            }
        }

        private void 导出模板2(StudentGroupSummary gp, DataTable db, List<Student> ss)
        {
            db.Rows.Add(
            gp.FacilityName,
            gp.Number.ToString(),
            gp.Sex == Sex.Male ? "男" : "女",
            AppSettings.Current.PhysicalProject.Name,
            gp.PlanDate,
            AppSettings.Current.PhysicalProject.PhysicalItems?.GetNames(!string.IsNullOrEmpty(gp.PhysicalItems) ? gp.PhysicalItems : ss[0].PhysicalItems),
            ss.Count >= 1 ? string.Format("{0}{1}{2}", ss[0].ID, System.Environment.NewLine, ss[0].Name) : string.Empty,
            ss.Count >= 2 ? string.Format("{0}{1}{2}", ss[1].ID, System.Environment.NewLine, ss[1].Name) : string.Empty,
            ss.Count >= 3 ? string.Format("{0}{1}{2}", ss[2].ID, System.Environment.NewLine, ss[2].Name) : string.Empty,
            ss.Count >= 4 ? string.Format("{0}{1}{2}", ss[3].ID, System.Environment.NewLine, ss[3].Name) : string.Empty,
            ss.Count >= 5 ? string.Format("{0}{1}{2}", ss[4].ID, System.Environment.NewLine, ss[4].Name) : string.Empty,
            ss.Count >= 6 ? string.Format("{0}{1}{2}", ss[5].ID, System.Environment.NewLine, ss[5].Name) : string.Empty,
            ss.Count >= 7 ? string.Format("{0}{1}{2}", ss[6].ID, System.Environment.NewLine, ss[6].Name) : string.Empty,
            ss.Count >= 8 ? string.Format("{0}{1}{2}", ss[7].ID, System.Environment.NewLine, ss[7].Name) : string.Empty,
            ss.Count >= 9 ? string.Format("{0}{1}{2}", ss[8].ID, System.Environment.NewLine, ss[8].Name) : string.Empty,
            ss.Count >= 10 ? string.Format("{0}{1}{2}", ss[9].ID, System.Environment.NewLine, ss[9].Name) : string.Empty,
            ss.Count >= 11 ? string.Format("{0}{1}{2}", ss[10].ID, System.Environment.NewLine, ss[10].Name) : string.Empty,
            ss.Count >= 12 ? string.Format("{0}{1}{2}", ss[11].ID, System.Environment.NewLine, ss[11].Name) : string.Empty,
            ss.Count >= 13 ? string.Format("{0}{1}{2}", ss[12].ID, System.Environment.NewLine, ss[12].Name) : string.Empty,
            ss.Count >= 14 ? string.Format("{0}{1}{2}", ss[13].ID, System.Environment.NewLine, ss[13].Name) : string.Empty,
            ss.Count >= 15 ? string.Format("{0}{1}{2}", ss[14].ID, System.Environment.NewLine, ss[14].Name) : string.Empty,
            ss.Count >= 16 ? string.Format("{0}{1}{2}", ss[15].ID, System.Environment.NewLine, ss[15].Name) : string.Empty,
            ss.Count >= 17 ? string.Format("{0}{1}{2}", ss[16].ID, System.Environment.NewLine, ss[16].Name) : string.Empty,
            ss.Count >= 18 ? string.Format("{0}{1}{2}", ss[17].ID, System.Environment.NewLine, ss[17].Name) : string.Empty,
            ss.Count >= 19 ? string.Format("{0}{1}{2}", ss[18].ID, System.Environment.NewLine, ss[18].Name) : string.Empty,
            ss.Count >= 20 ? string.Format("{0}{1}{2}", ss[19].ID, System.Environment.NewLine, ss[19].Name) : string.Empty
            );
        }

        private void 导出模板3(StudentGroupSummary gp, DataTable db, List<Student> ss)
        {
            List<int> pids = null;
            foreach (var s in ss)
            {
                pids = s.获取所有考试科目();
                if (pids == null || pids.Count == 0) continue;
                foreach (var pid in pids)
                {
                    var temp = s.GetProperty("ZSXM" + pid.ToString());
                    db.Rows.Add(
                                s.ID,
                                s.Name,
                                !string.IsNullOrEmpty(temp) ? temp : AppSettings.Current.PhysicalProject.PhysicalItems?.GetNames(pid.ToString()),
                                null,  //考点代码
                                gp.PlanDate, //考试时间
                                gp.Number, //组别
                                s.Channel  //道次
                               );
                }
            }
        }
        #endregion

        #region 事件处理程序
        private void Frm按组导出准考证_Load(object sender, EventArgs e)
        {
        }

        private void rd导成一个文件_CheckedChanged(object sender, EventArgs e)
        {
            btnFileBrowser.Enabled = rd导成一个文件.Checked;
        }

        private void btnFileBrowser_Click(object sender, EventArgs e)
        {
            var dig = new SaveFileDialog();
            dig.Filter = "Excel文档|*.xls;*.xlsx|所有文件(*.*)|*.*";
            dig.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (dig.ShowDialog() == DialogResult.OK)
            {
                txtFile.Text = dig.FileName;
            }
        }

        private void rd导出到多个文件_CheckedChanged(object sender, EventArgs e)
        {
            chk分学校.Enabled = rd导出到多个文件.Checked;
            chk分性别.Enabled = rd导出到多个文件.Checked;
            btnOpenDir.Enabled = rd导出到多个文件.Checked;
        }

        private void btnOpenDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dig = new FolderBrowserDialog();
            if (dig.ShowDialog() == DialogResult.OK)
            {
                txtFolder.Text = dig.SelectedPath;
            }
        }

        private void btn导出_Click(object sender, EventArgs e)
        {
            if (btn导出.Text == "取消")
            {
                if (_exportThread != null)
                {
                    _exportThread.Abort();
                    _exportThread = null;
                }
                btn导出.Text = "开始导出";
            }
            else
            {
                if (CheckInput() == false) return;
                _秩序册模板 = 0;
                if (rd秩序册1.Checked) _秩序册模板 = 1;
                else if (rd秩序册2.Checked) _秩序册模板 = 2;
                else if (rd秩序册3.Checked) _秩序册模板 = 3;
                txtError.Text = string.Empty;
                if (rd导成一个文件.Checked)
                {
                    _ExportTo = txtFile.Text;
                    _exportThread = new Thread(new ThreadStart(导出到文件_Thread));
                    _exportThread.Start();
                }
                else if (rd导出到多个文件.Checked)
                {
                    _ExportTo = txtFolder.Text;
                    _GroupBySex = chk分性别.Checked;
                    _CreateFacilityFolder = chk分学校.Checked;
                    _exportThread = new Thread(new ThreadStart(导出到文件夹_Thread));
                    _exportThread.Start();
                }
                btn导出.Text = "取消";
            }
        }

        private bool CheckInput()
        {
            if (rd秩序册1.Checked == false && rd秩序册2.Checked == false && rd秩序册3.Checked == false)
            {
                MessageBox.Show("请选择一种秩序册模板");
                return false;
            }
            if (rd导成一个文件.Checked == false && rd导出到多个文件.Checked == false)
            {
                MessageBox.Show("请选择一种文件导出方式");
                return false;
            }
            if (rd导成一个文件.Checked && string.IsNullOrEmpty(txtFile.Text))
            {
                MessageBox.Show("请选择要导出到哪个文件");
                return false;
            }
            if (rd导出到多个文件.Checked && string.IsNullOrEmpty(txtFolder.Text))
            {
                MessageBox.Show("请选择要导出到哪个文件夹");
                return false;
            }
            return true;
        }

        private void Frm按组导出准考证_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_exportThread != null)
            {
                _exportThread.Abort();
                _exportThread = null;
            }
        }
        #endregion

    }
}
