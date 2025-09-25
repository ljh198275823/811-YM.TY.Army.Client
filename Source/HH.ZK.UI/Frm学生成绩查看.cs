using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using HH.ZK.Model;
using System.Drawing;
using HH.ZK.Model.CRM;
using HH.ZK.CommonUI;
using LJH.GeneralLibrary;
using LJH.GeneralLibrary.WinForm;

namespace HH.ZK.UI
{
    public partial class Frm学生成绩查看 : Form
    {
        public Frm学生成绩查看()
        {
            InitializeComponent();
        }

        public List<StudentWithTotal> Students { get; set; }

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
            row.Cells["colFacility"].Value = s.DivisionName;
            row.Cells["colState"].Value = s.State == StudentState.正常 ? null : s.State.ToString();
            if (AppSettings.Current.Operator.PermitAll(Permission.总分, PermissionActions.Read)) row.Cells["col总分"].Value = s.Total;
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
        #endregion

        #region 事件处理程序
        private void Frm学生成绩查看_Load(object sender, EventArgs e)
        {
            InitGridViewColumns();
            dataGridView1.Columns["col总分"].Visible = AppSettings.Current.Operator.PermitAny(Permission.总分, PermissionActions.Read);
            if (Students != null && Students.Count > 0)
            {
                foreach (var s in Students)
                {
                    int row = dataGridView1.Rows.Add();
                    ShowStudentInfo(dataGridView1.Rows[row], s);
                }
            }
            this.toolStripStatusLabel1.Text = string.Format("总共 {0} 项", dataGridView1.Rows.Count);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog dig = new SaveFileDialog();
                dig.Filter = "Excel文档|*.xls;*.xlsx|所有文件(*.*)|*.*";
                dig.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                if (dig.ShowDialog() == DialogResult.OK)
                {
                    string path = dig.FileName;
                    NPOIExcelHelper.Export(dataGridView1, path, true);
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
    }
}
