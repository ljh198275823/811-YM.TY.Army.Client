using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading;
using System.Diagnostics;
using System.Windows.Forms;
using HH.ZK.Model;
using System.Drawing;
using HH.ZK.Model.SearchCondition;
using HH.ZK.Model.CRM;
using HH.ZK.CommonUI;
using HH.ZK.WebAPIClient;
using LJH.GeneralLibrary;
using LJH.GeneralLibrary;

namespace HH.ZK.UI
{
    public partial class Frm学生成绩单导出 : Form
    {
        public Frm学生成绩单导出()
        {
            InitializeComponent();
        }

        #region 私有变量
        private List<DataGridViewColumn> _ScoreCols = new List<DataGridViewColumn>();
        private List<DataGridViewColumn> _ResultCols = new List<DataGridViewColumn>();
        private Printer.StudentScoreSheetPrinter _Exporter = null;
        #endregion

        #region 私有方法
        private void InitGridViewColumns()
        {
            if (_ScoreCols != null && _ScoreCols.Count > 0)
            {
                _ScoreCols.ForEach(it => dataGridView1.Columns.Remove(it));
                _ScoreCols.Clear();
            }
            if (_ResultCols != null && _ResultCols.Count > 0)
            {
                _ResultCols.ForEach(it => dataGridView1.Columns.Remove(it));
                _ResultCols.Clear();
            }
            if (AppSettings.Current.PhysicalProject.PhysicalItems != null && AppSettings.Current.PhysicalProject.PhysicalItems.Items != null)
            {
                foreach (var pi in AppSettings.Current.PhysicalProject.PhysicalItems.Items)
                {
                    AddScoreColumn(pi);
                    if (AppSettings.Current.Operator.PermitAny(Permission.总分, PermissionActions.Read)) AddResultColumn(pi);
                }
            }
        }

        private void AddScoreColumn(PhysicalItem pi)
        {
            if (!_ScoreCols.Exists(col => (col.Tag as PhysicalItem).ID == pi.ID))
            {
                DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
                col.Name = string.Format("col_{0}", pi.ID);
                col.Tag = pi;
                col.MinimumWidth = 60;
                col.Width = 60;
                col.ReadOnly = true;
                col.SortMode = DataGridViewColumnSortMode.Automatic;
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
                col.HeaderText = string.Format("{0}", pi.Name);
                dataGridView1.Columns.Add(col);
                _ScoreCols.Add(col);
            }
        }

        private void AddResultColumn(PhysicalItem pi)
        {
            if (!_ResultCols.Exists(col => (col.Tag as PhysicalItem).ID == pi.ID))
            {
                DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
                col.Name = string.Format("col_{0}_Result", pi.ID);
                col.Tag = pi;
                col.MinimumWidth = 60;
                col.Width = 60;
                col.ReadOnly = true;
                col.SortMode = DataGridViewColumnSortMode.Automatic;
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                col.HeaderText = string.Format("{0}得分", pi.Name);
                dataGridView1.Columns.Add(col);
                _ResultCols.Add(col);
            }
        }

        private void ShowStudentInfo(DataGridViewRow row, StudentWithTotal s)
        {
            row.Tag = s;
            row.Cells["colID"].Value = s.ID;
            row.Cells["colName"].Value = s.Name;
            row.Cells["colSex"].Value = s.Gender == Gender.Male ? "男" : "女";
            //row.Cells["colGroup"].Value = s.Groups;
            row.Cells["colClassName"].Value = s.ClassName;
            //row.Cells["col考试科目"].Value = AppSettings.Current.PhysicalProject.PhysicalItems?.GetNames(s.PhysicalItems);
            row.Cells["colFacility"].Value = s.DivisionName;
            row.Cells["colState"].Value = s.State == StudentState.正常 ? null : s.State.ToString();
            if (AppSettings.Current.Operator.PermitAll(Permission.总分, PermissionActions.Read)) row.Cells["col总分"].Value = s.Total;
            //row.Cells["col检录"].Value = s.CheckTime?.ToString("yyyy-MM-dd HH:mm:ss");
            //row.Cells["col加分"].Value = s.JiaFen.Trim();
            row.Cells["colPrinted"].Value = s.GetProperty("打印成绩单") == "1";
            foreach (DataGridViewColumn col in _ScoreCols)
            {
                row.Cells[col.Index].ReadOnly = true;
                var pi = col.Tag as PhysicalItem;
                //if (s.包函考试科目(pi.ID))
                //{
                //    var score = s.Scores != null ? s.Scores.SingleOrDefault(it => it.PhysicalItemID == pi.ID) : null;
                //    if (score == null) row.Cells[col.Index].Style.BackColor = Color.Moccasin;
                //    else
                //    {
                //        row.Cells[col.Index].Tag = score;
                //        ShowScoreCell(row.Cells[col.Index], score);
                //        row.Cells[col.Index].Style.BackColor = Color.White;
                //        foreach (var rcol in _ResultCols)
                //        {
                //            if ((rcol.Tag as PhysicalItem).ID == pi.ID && score.Result.HasValue) row.Cells[rcol.Index].Value = score.Result.Value.Trim();
                //        }
                //    }
                //}
            }
        }

        private void ShowScoreCell(DataGridViewCell cell, StudentScore score)
        {
            //这么做主要是为了列的排序
            decimal temp;
            if (!string.IsNullOrEmpty(score.FormatScore) && decimal.TryParse(score.FormatScore, out temp)) cell.Value = temp; //能转化成实数，显示实数
            else cell.Value = score.FormatScore; //否则显示格式化成绩
        }

        private List<StudentWithTotal> GetCheckedStudents()
        {
            var students = new List<StudentWithTotal>();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                var row = dataGridView1.Rows[i];
                if (row.Cells["colSelect"].Value != null && (bool)(row.Cells["colSelect"].Value))
                {
                    students.Add(row.Tag as StudentWithTotal);
                }
            }
            return students;
        }

        private bool CheckExportPara()
        {
            var ret = true;
            string model = AppSettings.Current.ScorebillModal;
            if (string.IsNullOrEmpty(model) || !File.Exists(model))
            {
                ret = false;
            }
            if (!ret)
            {
                MessageBox.Show("还没有设置成绩单模板");
            }
            return ret;
        }

        private DataGridViewRow GetPrintingRow()
        {
            for (int row = 0; row < dataGridView1.Rows.Count; row++)
            {
                if (dataGridView1.Rows[row].Cells["colSelect"].Value != null && (bool)(dataGridView1.Rows[row].Cells["colSelect"].Value))
                {
                    dataGridView1.Rows[row].Selected = true;
                    if ((dataGridView1.FirstDisplayedScrollingRowIndex + dataGridView1.DisplayedRowCount(false)) <= row)
                    {
                        dataGridView1.FirstDisplayedScrollingRowIndex = (row - 5) > 0 ? (row - 5) : 0;
                    }
                    return dataGridView1.Rows[row];
                }
            }
            return null;
        }

        private void PrintStudentScoreBill(StudentWithTotal s)
        {
            string dir = LJH.GeneralLibrary.TempFolderManager.GetCurrentFolder();
            if (!System.IO.Directory.Exists(dir)) System.IO.Directory.CreateDirectory(dir);
            string file = System.IO.Path.Combine(dir, Guid.NewGuid() + ".xls");
            _Exporter.ExportToFile(s, file);
            if (System.IO.File.Exists(file))
            {
                ProcessStartInfo psi = new ProcessStartInfo(file);
                psi.Verb = "Print";
                psi.CreateNoWindow = true;
                psi.WindowStyle = ProcessWindowStyle.Hidden;
                psi.UseShellExecute = true;

                Process prs = new Process();
                prs.StartInfo = psi;
                prs.Start();
                prs.WaitForExit();
            }
        }

        private void ShowSelectedCount()
        {
            int count = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                var cell = row.Cells["colSelect"] as DataGridViewCheckBoxCell;
                if (Convert.ToBoolean(cell.Value)) count++;
            }
            lbl选择数量.Text = count.ToString();
        }

        private List<StudentWithTotal> GetSelectedStudents()
        {
            var students = new Dictionary<string, StudentWithTotal>();
            foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
            {
                var student = dataGridView1.Rows[cell.RowIndex].Tag as StudentWithTotal;
                if (!students.ContainsKey(student.ID)) students.Add(student.ID, student);
            }
            return students.Values.ToList();
        }
        #endregion

        #region 事件处理程序
        private void FrmExportScores_Load(object sender, EventArgs e)
        {
            txtModelFile.Text = AppSettings.Current.ScorebillModal;
            var temp = AppSettings.Current.GetConfigContent("PrintInterval");
            if (!string.IsNullOrEmpty(temp)) txtInterval.Text = temp;
            ucStudentSearch1.Init();
            InitGridViewColumns();
            txt考试状态.Init(AppSettings.Current.PhysicalProject.StateSettings, true);
            dataGridView1.Columns["col总分"].Visible = AppSettings.Current.Operator.PermitAny(Permission.总分, PermissionActions.Read);
        }

        private void rd指定状态_CheckedChanged(object sender, EventArgs e)
        {
            txt考试状态.Enabled = rd指定状态.Checked;
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            var con = new StudentWithTotalSearchCondition();
            ucStudentSearch1.GetSearchCondition(con);
            con.ClassName = txtClassName.Text;
            if (!rd全部.Checked)
            {
                con.TestStates = new List<TestCompleteState>();
                if (rd测试完成.Checked) con.TestStates.Add(TestCompleteState.全部完成);
                if (rd未测试.Checked) con.TestStates.Add(TestCompleteState.未测试);
                if (rd没有完成测试.Checked) con.TestStates.Add(TestCompleteState.部分科目完成);
            }
            if (rd所有特殊状态.Checked)
            {
                con.States = new List<StudentState>();
                foreach (var item in Enum.GetValues(typeof(StudentState)))
                {
                    if ((StudentState)item == StudentState.正常) continue;

                    con.States.Add((StudentState)item);
                }
            }
            if (rd指定状态.Checked && !string.IsNullOrEmpty(txt考试状态.Text))
            {
                con.States = new List<StudentState>();
                con.States.Add(txt考试状态.SelectedStudentState);
            }
            var ret = new APIClient(AppSettings.Current.ConnStr).GetList<string, StudentWithTotal>(con, AppSettings.Current.PhysicalProject.ID);
            if (ret.Result != LJH.GeneralLibrary.ResultCode.Successful)
            {
                MessageBox.Show(ret.Message);
                return;
            }
            var students = ret.QueryObjects;
            if (students != null && students.Count > 0)
            {
                if (rd已打印.Checked) students.RemoveAll(it => string.IsNullOrEmpty(it.GetProperty("打印成绩单")) || it.GetProperty("打印成绩单") != "1");
                if (rd未打印.Checked) students.RemoveAll(it => it.GetProperty("打印成绩单") == "1");
                foreach (var s in students)
                {
                    int row = dataGridView1.Rows.Add();
                    ShowStudentInfo(dataGridView1.Rows[row], s);
                }
                btnPrint.Enabled = true;
                btnExport.Enabled = true;
            }
            this.toolStripStatusLabel1.Text = string.Format("总共 {0} 项", dataGridView1.Rows.Count);
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells["colSelect"].Value = true;
                count++;
            }
            lbl选择数量.Text = count.ToString();
        }

        private void btnNone_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells["colSelect"].Value = false;
            }
            lbl选择数量.Text = "0";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "colSelect")
            {
                int count = 0;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    var cell = row.Cells[e.ColumnIndex] as DataGridViewCheckBoxCell;
                    if (row.Index == e.RowIndex)
                    {
                        if (Convert.ToBoolean(cell.EditingCellFormattedValue)) count++;
                    }
                    else if (Convert.ToBoolean(cell.Value)) count++;
                }
                lbl选择数量.Text = count.ToString();
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (CheckExportPara() == false) return;
            var students = GetCheckedStudents();
            if (students == null || students.Count == 0)
            {
                MessageBox.Show("没有选择要导出的学生");
                return;
            }
            var _Exporter = new Printer.StudentScoreSheetPrinter(AppSettings.Current.ScorebillModal);
            FolderBrowserDialog dig = new FolderBrowserDialog();
            if (dig.ShowDialog() != DialogResult.OK) return;
            var folder = dig.SelectedPath;
            FrmProcessing frm = new FrmProcessing();
            int count = 0;
            int success = 0;
            Thread t = null;
            Action action = delegate ()
            {
                try
                {
                    for (int i = 0; i < students.Count; i++)
                    {
                        var s = students[i];
                        string file = Path.Combine(folder, string.Format("{0}_{1}.xls", s.ID, s.Name));
                        _Exporter.ExportToFile(s, file);
                        count++;
                        if (System.IO.File.Exists(file)) success++;
                        frm.ShowProgress(string.Format("正在导出第 {0} 个学生，成功导出 {1} 个学生", i + 1, success), (decimal)i / students.Count);
                    }
                }
                catch (ThreadAbortException)
                {
                }
                catch (Exception)
                {
                }
                frm.ShowProgress(string.Empty, 1);
                t = null;
            };
            t = new Thread(new ThreadStart(action));
            t.Start();
            frm.ShowDialog();
            if (t != null) t.Abort();
            MessageBox.Show(string.Format("总共导出 {0} 个学生，其中成功导出 {1} 个学生", count, success));
        }

        private void mnu数据另存为_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog dig = new SaveFileDialog();
                dig.Filter = "Excel文档|*.xls;*.xlsx|所有文件(*.*)|*.*";
                dig.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                if (dig.ShowDialog() == DialogResult.OK)
                {
                    string path = dig.FileName;
                    LJH.GeneralLibrary.WinForm.NPOIExcelHelper.Export(dataGridView1, path, true);
                    MessageBox.Show("导出成功");
                }
            }
            catch (Exception ex)
            {
                LJH.GeneralLibrary.ExceptionPolicy.HandleException(ex);
                MessageBox.Show("保存到电子表格时出现错误!");
            }
        }

        private void btn分学校导出_Click(object sender, EventArgs e)
        {
            if (CheckExportPara() == false) return;
            var students = GetCheckedStudents();
            if (students == null || students.Count == 0)
            {
                MessageBox.Show("没有选择要导出的学生");
                return;
            }
            try
            {
                var model = AppSettings.Current.GetConfigContent("ExportScoreModel");
                string temp = AppSettings.Current.GetConfigContent("ExportScoreModelTemplateRow");
                int templateRow = 0;
                if (!string.IsNullOrEmpty(temp)) int.TryParse(temp, out templateRow);
                FolderBrowserDialog dig = new FolderBrowserDialog();
                if (dig.ShowDialog() != DialogResult.OK) return;
                var folder = dig.SelectedPath;
                var groups = from s in students
                             orderby s.DivisionName ascending, s.ID ascending
                             group s by s.DivisionName;
                foreach (var gp in groups)
                {
                    string path = System.IO.Path.Combine(folder, gp.Key + ".xls");
                    bool ret = new StudentWithTotalExporter(model).ExportToFile(gp.ToList(), path, templateRow, null, null);
                }
                MessageBox.Show("导出完成");
            }
            catch (Exception ex)
            {
                MessageBox.Show("保存到电子表格时出现错误!");
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                if (txtInterval.IntergerValue <= 0)
                {
                    MessageBox.Show("打印间隔不正确");
                    return;
                }
                if (CheckExportPara() == false) return;
                var students = GetCheckedStudents();
                if (students == null || students.Count == 0)
                {
                    MessageBox.Show("没有选择要导出的学生");
                    return;
                }
                _Exporter = new Printer.StudentScoreSheetPrinter(AppSettings.Current.ScorebillModal);
                AppSettings.Current.SaveConfig("PrintInterval", txtInterval.IntergerValue.ToString());
                timer1.Interval = 1000;  //第一次运行在一秒之后
                timer1.Enabled = true;
                dataGridView1.Enabled = false;
                btnQuery.Enabled = false;
                btnPrint.Text = "停止打印";
                btnExport.Enabled = false;
            }
            else
            {
                timer1.Enabled = false;
                dataGridView1.Enabled = true;
                btnQuery.Enabled = true;
                btnPrint.Text = "开始打印(&P)";
                btnExport.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer1.Interval = txtInterval.IntergerValue * 1000;
            DataGridViewRow row = GetPrintingRow();
            if (row == null)
            {
                dataGridView1.Enabled = true;
                btnQuery.Enabled = true;
                btnPrint.Text = "开始打印(&P)";
                btnExport.Enabled = true;
            }
            else
            {
                try
                {
                    var s = row.Tag as StudentWithTotal;
                    PrintStudentScoreBill(s);
                    s.SetProperty("打印成绩单", "1");
                    var patch = new UpdateItem<string>() { ID = s.ID, Key = "Note", Value = s.Note };
                    new APIClient(AppSettings.Current.ConnStr).Patch<string, Student>(s.ID, new List<UpdateItem<string>>() { patch }, AppSettings.Current.PhysicalProject.ID);
                    row.Cells["colSelect"].Value = false;
                    row.Selected = false;
                    ShowSelectedCount();
                    timer1.Enabled = true;
                }
                catch (Exception ex)
                {
                    LJH.GeneralLibrary.ExceptionPolicy.HandleException(ex);
                }
            }
            
        }

        private void btnModalBrowser_Click(object sender, EventArgs e)
        {
            OpenFileDialog dig = new OpenFileDialog();
            dig.Title = "选择模板";
            dig.Filter = "Excel文档|*.xls;*.xlsx|所有文件(*.*)|*.*";
            dig.InitialDirectory = System.IO.Path.Combine(Application.StartupPath, "模板");
            dig.RestoreDirectory = true;
            if (dig.ShowDialog() != DialogResult.OK) return;
            txtModelFile.Text = dig.FileName;
            AppSettings.Current.ScorebillModal = dig.FileName;
        }

        private void mnu取消打印状态_Click(object sender, EventArgs e)
        {
            var students = GetSelectedStudents();
            if (students == null || students.Count == 0)
            {
                MessageBox.Show("没有选择学生");
                return;
            }
            int fail = 0;
            FrmProcessing frmP = new FrmProcessing();
            Action action = delegate ()
            {
                try
                {
                    List<Student> temp = new List<Student>();
                    for (int i = 0; i < students.Count; i++)
                    {
                        temp.Add(students[i]);
                        if (i == students.Count - 1 || temp.Count == 100)
                        {
                            temp.ForEach(it => it.SetProperty("打印成绩单", null));
                            var patchs = temp.Select(it => new UpdateItem<string>() { ID = it.ID, Key = "Note", Value = it.Note }).ToList();
                            var ret = new WebAPIClient.APIClient(AppSettings.Current.ConnStr).BatchPatch<string, Student>(patchs, AppSettings.Current.PhysicalProject.ID);
                            if (ret.Result == ResultCode.Successful && ret.Value != null && ret.Value.Errors != null) fail += ret.Value.Errors.Count;
                            else if (ret.Result == ResultCode.Fail) fail += temp.Count;
                            temp.Clear();
                            if (fail == 0) frmP.ShowProgress(string.Empty, (decimal)(i + 1) / students.Count);
                            else frmP.ShowProgressEX($"失败 {fail} 条", (decimal)(i + 1) / students.Count);
                        }
                    }
                }
                catch (ThreadAbortException)
                {
                }
                catch (Exception)
                {
                }
                frmP.ShowProgress(string.Empty, 1);
            };
            Thread t = new Thread(new ThreadStart(action));
            t.IsBackground = true;
            t.Start();
            if (frmP.ShowDialog() != DialogResult.OK)
            {
                t.Abort();
            }
            btnQuery.PerformClick();
        }
        #endregion
    }
}
