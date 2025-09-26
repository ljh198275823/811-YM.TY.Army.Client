using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;
using HH.ZK.Model;
using System.Drawing;
using HH.ZK.Model.SearchCondition;
using HH.ZK.Model.CRM;
using HH.ZK.CommonUI;
using HH.ZK.WebAPIClient;
using LJH.GeneralLibrary;

namespace HH.ZK.UI
{
    public partial class Frm学生成绩导出 : Form
    {
        public Frm学生成绩导出()
        {
            InitializeComponent();
        }

        #region 私有变量
        private List<DataGridViewColumn> _ScoreCols = new List<DataGridViewColumn>();
        private List<DataGridViewColumn> _ResultCols = new List<DataGridViewColumn>();
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
            var stds = new APIClient(AppSettings.Current.ConnStr).GetList<Guid, Standard>(null, AppSettings.Current.PhysicalProject.ID).QueryObjects;
            if (AppSettings.Current.PhysicalProject.PhysicalItems != null && AppSettings.Current.PhysicalProject.PhysicalItems.Items != null)
            {
                foreach (var pi in AppSettings.Current.PhysicalProject.PhysicalItems.Items)
                {
                    if (pi.ID == PhysicalItem._BMI) continue;
                    AddScoreColumn(pi);
                    if (stds != null && stds.Count > 0 && stds.Exists(it => it.TestID == pi.ID))
                    {
                        if (AppSettings.Current.Operator.PermitAny(Permission.总分, PermissionActions.Read)) AddResultColumn(pi);
                    }
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
            //if (AppSettings.Current.Operator.PermitAll(Permission.总分, PermissionActions.Read)) row.Cells["col加分"].Value = s.JiaFen.Trim();
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

        private List<StudentWithTotal> GetSelectedStudents()
        {
            var students = new List<StudentWithTotal>();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                var row = dataGridView1.Rows[i];
                students.Add(row.Tag as StudentWithTotal);
            }
            return students;
        }

        private bool CheckExportPara()
        {
            var ret = true;
            string model = AppSettings.Current.GetConfigContent("ExportScoreModel");
            if (string.IsNullOrEmpty(model) || !File.Exists(model))
            {
                ret = false;
            }
            string temp = AppSettings.Current.GetConfigContent("ExportScoreModelTemplateRow");
            int template = 0;
            if (string.IsNullOrEmpty(temp) || !int.TryParse(temp, out template) || template <= 0)
            {
                ret = false;
            }
            if (!ret)
            {
                var frm = new Frm学生成绩导出模板设置();
                frm.StartPosition = FormStartPosition.CenterParent;
                var dig = frm.ShowDialog();
                ret = dig == DialogResult.OK;
            }
            return ret;
        }
        #endregion

        #region 事件处理程序
        private void FrmExportScores_Load(object sender, EventArgs e)
        {
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
            if (rd已检录.Checked) con.Checked = true;
            if (rd未检录.Checked) con.Checked = false;
            var ret = new APIClient(AppSettings.Current.ConnStr).GetList<string, StudentWithTotal>(con, AppSettings.Current.PhysicalProject.ID);
            if (ret.Result != LJH.GeneralLibrary.ResultCode.Successful)
            {
                MessageBox.Show(ret.Message);
                return;
            }
            var students = ret.QueryObjects;
            if (students != null && students.Count > 0)
            {
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

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (CheckExportPara() == false) return;
            var students = GetSelectedStudents();
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
                string school = ucStudentSearch1.GetFacilityName();
                var group = ucStudentSearch1.GetGroup();
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "Excel文档|*.xls;*.xlsx|所有文件(*.*)|*.*";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string path = saveFileDialog1.FileName;
                    bool ret = new StudentWithTotalExporter(model).ExportToFile(students, path, templateRow, school, null);
                    MessageBox.Show(ret ? "导出成功" : "导出失败");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("保存到电子表格时出现错误!");
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (CheckExportPara() == false) return;
            var students = GetSelectedStudents();
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
                string school = ucStudentSearch1.GetFacilityName();
                var group = ucStudentSearch1.GetGroup();
                string dir = LJH.GeneralLibrary.TempFolderManager.GetCurrentFolder();
                string path = System.IO.Path.Combine(dir, Guid.NewGuid() + ".xls");
                bool ret = new StudentWithTotalExporter(model).ExportToFile(students, path, templateRow, school, null);
                if (ret)
                {
                    ProcessStartInfo psi = new ProcessStartInfo(path);
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
            catch (Exception ex)
            {
                MessageBox.Show("保存到电子表格时出现错误!");
            }
        }

        private void btn模板设置_Click(object sender, EventArgs e)
        {
            var frm = new Frm学生成绩导出模板设置();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
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
        #endregion

        private void btn分学校导出_Click(object sender, EventArgs e)
        {
            if (CheckExportPara() == false) return;
            var students = GetSelectedStudents();
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
                var group = ucStudentSearch1.GetGroup();
                FolderBrowserDialog dig = new FolderBrowserDialog();
                if (dig.ShowDialog() != DialogResult.OK) return;
                var folder = dig.SelectedPath;
                var groups = from s in students
                             orderby s.DivisionName ascending, s.ID ascending
                             group s by s.DivisionName;
                foreach (var gp in groups)
                {
                    string path = System.IO.Path.Combine(folder, gp.Key + ".xls");
                    bool ret = new StudentWithTotalExporter(model).ExportToFile(gp.ToList (), path, templateRow, gp.Key, null);
                }
                MessageBox.Show("导出完成");
            }
            catch (Exception ex)
            {
                MessageBox.Show("保存到电子表格时出现错误!");
            }
        }
    }
}
