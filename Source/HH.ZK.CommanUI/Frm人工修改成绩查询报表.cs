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

namespace HH.ZK.CommonUI
{
    public partial class Frm人工修改成绩查询报表 : FrmReportBaseWithPaging<Guid, StudentScoreLog>
    {
        public Frm人工修改成绩查询报表()
        {
            InitializeComponent();
        }

        #region 私有方法
        private List<StudentScoreLog> GetSelectedScores()
        {
            List<StudentScoreLog> scores = new List<StudentScoreLog>();
            foreach (DataGridViewCell cell in GridView.SelectedCells)
            {
                var score = GridView.Rows[cell.RowIndex].Tag as StudentScoreLog;
                if (!scores.Contains(score)) scores.Add(score);
            }
            return scores;
        }
        #endregion

        #region 重写基类方法
        protected override void Init()
        {
            base.Init();
            cmbPhysicalItem.Init(AppSettings.Current.PhysicalProject);
            ucStudentSearch1.Init();
            if (AppSettings.Current.PhysicalProject == null) btnSearch.Enabled = false;
        }

        public override void ShowOperatorRights()
        {
            base.ShowOperatorRights();
            btnSearch.Enabled = AppSettings.Current.Operator.PermitAll(Permission.StudentScore, PermissionActions.Read);
            btnSaveAs.Enabled = AppSettings.Current.Operator.PermitAll(Permission.StudentScore, PermissionActions.Read);
        }

        protected override QueryResultList<StudentScoreLog> GetDataSource(int pageSize, int pageIndex)
        {
            var con = new StudentScoreSearchCondition() { PageIndex = pageIndex, PageSize = pageSize };
            ucStudentSearch1.GetSearchCondition(con);
            con.SortMode = SortMode.Desc;
            if (!string.IsNullOrEmpty(cmbPhysicalItem.Text)) con.TestID = cmbPhysicalItem.SelectedPhysicalItem;
            return new APIClient(AppSettings.Current.ConnStr).GetList<Guid, StudentScoreLog>(con, AppSettings.Current.PhysicalProject.ID);
        }

        protected override void ShowItemInGridViewRow(DataGridViewRow row, StudentScoreLog log)
        {
            row.Tag = log;
            row.Cells["colOptTime"].Value = log.OptTime.ToString("yyyy-MM-dd HH:mm:ss");
            row.Cells["colOptType"].Value = log.OptType;
            row.Cells["colOperator"].Value = log.Operator;
            row.Cells["colID"].Value = log.StudentID;
            row.Cells["colName"].Value = log.StudentName;
            row.Cells["colSex"].Value = log.Sex == Gender.Male ? "男" : "女";
            row.Cells["colFacility"].Value = log.FacilityName;
            row.Cells["colPhysicalItem"].Value = AppSettings.Current.PhysicalProject.PhysicalItems?.GetName(log.PhysicalItemID);
            row.Cells["colScore"].Value = log.Score;
            row.Cells["colDate"].Value = log.TestTime.ToString("yyyy-MM-dd HH:mm:ss");
            row.Cells["colDeviceSn"].Value = log.DeviceSn;
            row.Cells["colScoreSer"].Value = log.ScoreSer;
            row.Cells["colHostID"].Value = log.HostID;
            row.Cells["colScoreFrom"].Value = log.ScoreFrom.ToString();
            row.Cells["colNewScore"].Value = log.NewScore;
            row.Cells["colMemo"].Value = log.Memo;
            row.DefaultCellStyle.ForeColor = log != null ? Color.Black : Color.Red;
        }
        #endregion
    }
}
