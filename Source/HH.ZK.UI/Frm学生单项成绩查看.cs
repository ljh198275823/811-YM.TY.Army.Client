using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;
using HH.ZK.Model;
using HH.ZK.Model.SearchCondition;
using HH.ZK.WebAPIClient;
using HH.ZK.Model.CRM;
using LJH.GeneralLibrary;
using LJH.GeneralLibrary.WinForm;

namespace HH.ZK.UI
{
    public partial class Frm学生单项成绩查看 : Form
    {
        public Frm学生单项成绩查看()
        {
            InitializeComponent();
        }

        public List<StudentWithDXCJ> Students { get; set; }

        #region 重写基类方法
        private void ShowItemInGridViewRow(DataGridViewRow row, StudentWithDXCJ s)
        {
            row.Tag = s;
            row.Cells["colFacility"].Value = s.DivisionName;
            row.Cells["colID"].Value = s.ID;
            row.Cells["colName"].Value = s.Name;
            row.Cells["colSex"].Value = s.Gender == Gender.Male ? "男" : "女";
            row.Cells["colClassName"].Value = s.ClassName;
            row.Cells["colPhysicalItem"].Value = AppSettings.Current.PhysicalProject.PhysicalItems?.GetName(s.TestID);
            var pi = AppSettings.Current.PhysicalProject.PhysicalItems?.GetPhysicalItem(s.TestID);
            row.DefaultCellStyle.ForeColor = s.OverCountHandled ? Color.Blue : Color.Black;
            var score = s.GetScoreByIndex(0, true);
            if (score != null)
            {
                row.Cells["colScore1"].Value = score.FormatScore;
            }
            score = s.GetScoreByIndex(1, true);
            if (score != null)
            {
                row.Cells["colScore2"].Value = score.FormatScore;
            }
            score = s.GetScoreByIndex(2, true);
            if (score != null)
            {
                row.Cells["colScore3"].Value = score.FormatScore;
            }
            score = s.GetScoreByIndex(3, true);
            if (score != null)
            {
                row.Cells["colScore4"].Value = score.FormatScore;
            }
            score = s.GetScoreByIndex(4, true);
            if (score != null)
            {
                row.Cells["colScore5"].Value = score.FormatScore;
            }
            score = s.GetScoreByIndex(5, true);
            if (score != null)
            {
                row.Cells["colScore6"].Value = score.FormatScore;
            }
            var ps = s.BestScore;
            if (ps != null)
            {
                row.Cells["colCurrentScore"].Value = ps.FormatScore;
                row.Cells["colCurrentScore"].Tag = ps;
                if (ps.Result.HasValue && AppSettings.Current.Operator.PermitAny(Permission.总分, PermissionActions.Read)) row.Cells["colCurrentResult"].Value = ps.Result.Value.Trim();
            }
        }
        #endregion

        #region 事件处理程序
        private void Frm学生单项成绩查看_Load(object sender, EventArgs e)
        {
            if (Students != null && Students.Count > 0)
            {
                foreach (var s in Students)
                {
                    int row = dataGridView1.Rows.Add();
                    ShowItemInGridViewRow(dataGridView1.Rows[row], s);
                }
            }
            this.toolStripStatusLabel1.Text = string.Format("总共 {0} 项", dataGridView1.Rows.Count);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            var row = dataGridView1.Rows[e.RowIndex];
            var student = row.Tag as StudentWithDXCJ;
            PhysicalItem pi = AppSettings.Current.PhysicalProject.PhysicalItems?.GetPhysicalItem(student.TestID);
            if (pi == null) return;
            FrmStudentScoreDetailView frm = new FrmStudentScoreDetailView();
            frm.Student = new StudentInProject() { StudentID = student.ID, ProjectID = student.ProjectID, TestDate = student.TestDate };
            frm.PhysicalItem = pi;
            frm.ShowDialog();
            var con = new StudentWithDXCJSearchCondition() { StudentID = student.ID, TestID = pi.ID };
            var ss = new APIClient(AppSettings.Current.ConnStr).GetList<string, StudentWithDXCJ>(con, AppSettings.Current.PhysicalProject.ID).QueryObjects;
            if (ss != null && ss.Count == 1) ShowItemInGridViewRow(row, ss[0]);
        }

        private void mnu导出_Click(object sender, EventArgs e)
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
