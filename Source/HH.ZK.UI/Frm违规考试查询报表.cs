using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;
using HH.ZK.Model;
using HH.ZK.Model.CRM;
using HH.ZK.Model.SearchCondition;
using LJH.GeneralLibrary;
using HH.ZK.WebAPIClient;
using LJH.GeneralLibrary.WinForm;
using HH.ZK.CommonUI;

namespace HH.ZK.UI
{
    public partial class Frm违规考试查询报表 : FrmReportBaseWithPaging<string, StudentWithDXCJ>
    {
        public Frm违规考试查询报表()
        {
            InitializeComponent();
        }

        #region 重写基类方法
        protected override void Init()
        {
            base.Init();
            ucStudentSearch1.Init(AppSettings.Current.PhysicalProject.ID);
            cmbPhysicalItem.Init(AppSettings.Current.PhysicalProject);
            if (AppSettings.Current.PhysicalProject == null) btnSearch.Enabled = false;
        }

        public override void ShowOperatorRights()
        {
            base.ShowOperatorRights();
            btnSearch.Enabled = AppSettings.Current.Operator.PermitAll(Permission.StudentScore, PermissionActions.Read);
            btnSaveAs.Enabled = AppSettings.Current.Operator.PermitAll(Permission.StudentScore, PermissionActions.Read);
        }

        protected override QueryResultList<StudentWithDXCJ> GetDataSource(int pageSize, int pageIndex)
        {
            var con = new StudentWithDXCJSearchCondition() { PageIndex = pageIndex, PageSize = pageSize, SortMode = SortMode.Desc };
            ucStudentSearch1.GetSearchCondition(con);
            if (!string.IsNullOrEmpty(cmbPhysicalItem.Text)) con.PhysicalItem = cmbPhysicalItem.SelectedPhysicalItem;
            con.HasScore = true;
            con.OverCount = true;
            if (rdHandled.Checked) con.OverCountHandled = true;
            else if (rdNotHandled.Checked) con.OverCountHandled = false;
            return new APIClient(AppSettings.Current.ConnStr).GetList<string, StudentWithDXCJ>(con, AppSettings.Current.PhysicalProject.ID);
        }

        protected override void ShowItemInGridViewRow(DataGridViewRow row, StudentWithDXCJ s)
        {
            row.Tag = s;
            row.Cells["colFacility"].Value = s.FacilityName;
            row.Cells["colID"].Value = s.ID;
            row.Cells["colName"].Value = s.Name;
            row.Cells["colSex"].Value = s.Sex == Sex.Male ? "男" : "女";
            row.Cells["colClassName"].Value = s.ClassName;
            row.Cells["colPhysicalItem"].Value = AppSettings.Current.PhysicalProject.PhysicalItems?.GetName(s.PhysicalItemID);
            var pi = AppSettings.Current.PhysicalProject.PhysicalItems?.GetPhysicalItem(s.PhysicalItemID);
            row.Cells["col重考次数"].Value = s.OverCount;
            row.Cells["colHandled"].Value = s.OverCountHandled ? "已处理" : "未处理";
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
        #endregion
    }
}
