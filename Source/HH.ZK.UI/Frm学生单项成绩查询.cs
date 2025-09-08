using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;
using HH.ZK.Model;
using HH.ZK.Model.CRM;
using HH.ZK.Model.SearchCondition;
using HH.ZK.WebAPIClient;
using LJH.GeneralLibrary;
using LJH.GeneralLibrary.WinForm;

namespace HH.ZK.UI
{
    public partial class Frm学生单项成绩查询 : FrmReportBaseWithPaging<string,StudentWithDXCJ>
    {
        public Frm学生单项成绩查询()
        {
            InitializeComponent();
        }

        #region 私有变量
        private StudentGroupSummary _Group = null;
        private List<StudentWithDXCJ> _Students = null;
        #endregion

        #region 私有方法
        private void ShowScoreCell(DataGridViewCell cell, StudentScore score)
        {
            //这么做主要是为了列的排序
            decimal temp;
            if (!string.IsNullOrEmpty(score.FormatScore) && decimal.TryParse(score.FormatScore, out temp)) cell.Value = temp; //能转化成实数，显示实数
            else cell.Value = score.FormatScore; //否则显示格式化成绩
        }
        #endregion

        #region 重写基类方法
        protected override void Init()
        {
            base.Init();
            cmbPhysicalItem.Init(AppSettings.Current.PhysicalProject);
            ucStudentSearch1.Init();
        }

        protected override QueryResultList<StudentWithDXCJ> GetDataSource(int pageSize, int pageIndex)
        {
            _Group = null;
            dataGridView1.Rows.Clear();
            var con = new StudentWithDXCJSearchCondition() { PageSize = pageSize, PageIndex = pageIndex, SortMode = SortMode.Asc };
            ucStudentSearch1.GetSearchCondition(con);
            if (!string.IsNullOrEmpty(cmbPhysicalItem.Text)) con.PhysicalItem = cmbPhysicalItem.SelectedPhysicalItem;
            if (chkOnlyScore.Checked) con.HasScore = true;
            if (con.GroupID.HasValue) _Group = new APIClient(AppSettings.Current.ConnStr).GetByID<Guid, StudentGroupSummary>(con.GroupID.Value, AppSettings.Current.PhysicalProject.ID).QueryObject;
            var ret= new APIClient(AppSettings.Current.ConnStr).GetList<string, StudentWithDXCJ>(con, AppSettings.Current.PhysicalProject.ID);
            _Students = ret.QueryObjects;
            return ret;
        }

        protected override void ShowItemInGridViewRow(DataGridViewRow row, StudentWithDXCJ s)
        {
            row.Tag = s;
            row.Cells["colID"].Value = s.ID;
            row.Cells["colName"].Value = s.Name;
            row.Cells["colSex"].Value = s.Gender == Gender.Male ? "男" : "女";
            row.Cells["colFacility"].Value = s.DivisionName;
            row.Cells["colPhysicalItem"].Value = AppSettings.Current.PhysicalProject.PhysicalItems?.GetName(s.PhysicalItemID);
            var pi = AppSettings.Current.PhysicalProject.PhysicalItems?.GetPhysicalItem(s.PhysicalItemID);
            var score = s.GetScoreByIndex(0);
            if (score != null)
            {
                row.Cells["colScore1"].Value = score.FormatScore;
                row.Cells["colTestTime1"].Value = score.TestTime.ToString("yyyy-MM-dd HH:mm:ss");
            }
            if (pi != null && pi.TestCount >= 2)
            {
                score = s.GetScoreByIndex(1);
                if (score != null)
                {
                    row.Cells["colScore2"].Value = score.FormatScore;
                    row.Cells["colTestTime2"].Value = score.TestTime.ToString("yyyy-MM-dd HH:mm:ss");
                }
            }
            if (pi != null && pi.TestCount >= 3)
            {
                score = s.GetScoreByIndex(2);
                if (score != null)
                {
                    row.Cells["colScore3"].Value = score.FormatScore;
                    row.Cells["colTestTime3"].Value = score.TestTime.ToString("yyyy-MM-dd HH:mm:ss");
                }
            }
            if (pi != null && pi.TestCount >= 4)
            {
                score = s.GetScoreByIndex(3);
                if (score != null)
                {
                    row.Cells["colScore4"].Value = score.FormatScore;
                    row.Cells["colTestTime4"].Value = score.TestTime.ToString("yyyy-MM-dd HH:mm:ss");
                }
            }
            if (s.BestScoreID != null)
            {
                var best = s.BestScore;
                ShowScoreCell(row.Cells["colScore"], best);
                if (AppSettings.Current.Operator.PermitAny(Permission.总分, PermissionActions.Read))
                {
                    if (best.Result != null) row.Cells["colResult"].Value = best.Result.Value.Trim();
                    else row.Cells["colResult"].Value = null;
                }
            }
            row.DefaultCellStyle.ForeColor = s.BestScore != null ? Color.Black : Color.Red;
        }
        #endregion

        #region 事件处理程序
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            var row = dataGridView1.Rows[e.RowIndex];
            var student = row.Tag as StudentWithDXCJ;
            PhysicalItem pi = AppSettings.Current.PhysicalProject.PhysicalItems?.GetPhysicalItem(student.PhysicalItemID);
            if (pi == null) return;
            FrmStudentScoreDetailView frm = new FrmStudentScoreDetailView();
            frm.Student = student;
            frm.PhysicalItem = pi;
            frm.ShowDialog();
            var con = new StudentWithDXCJSearchCondition() { StudentID = student.ID, PhysicalItem = pi.ID };
            var ss = new APIClient(AppSettings.Current.ConnStr).GetList<string, StudentWithDXCJ>(con, AppSettings.Current.PhysicalProject.ID).QueryObjects;
            if (ss != null && ss.Count == 1) ShowItemInGridViewRow(row, ss[0]);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (_Group == null)
            {
                MessageBox.Show("没有选择要打印的组别");
                return;
            }
            if (_Students == null || _Students.Count == 0)
            {
                MessageBox.Show("没有要打印的数据");
                return;
            }
            if (string.IsNullOrEmpty(cmbPhysicalItem.Text))
            {
                MessageBox.Show("没有选择要打印的考试科目");
                return;
            }
            string modelFile = AppSettings.Current.GetConfigContent("StudentGroupScoresModel");
            if (string.IsNullOrEmpty(modelFile)) modelFile = Path.Combine(Application.StartupPath, "模板", "测试成绩模板.xls");
            if (!File.Exists(modelFile))
            {
                MessageBox.Show("没有找到成绩单模板,不能打印");
                return;
            }
            try
            {
                var pi = cmbPhysicalItem.SelectedItem as PhysicalItem;
                string dir = LJH.GeneralLibrary.TempFolderManager.GetCurrentFolder();
                string desFile = System.IO.Path.Combine(dir, Guid.NewGuid() + ".xls");
                var exporter = new StudentWithDXCJExporter(modelFile);
                var title = AppSettings.Current.GetConfigContent("StudentGroupScoresTitle");
                if (string.IsNullOrEmpty(title)) title = string.Format("{0}年中考体育考试成绩单", DateTime.Now.Year);
                exporter.Export(_Group, pi, _Students, desFile, title);
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        
    }
}
