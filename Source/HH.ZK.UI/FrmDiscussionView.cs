using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using HH.ZK.Model;
using HH.ZK.Model.SearchCondition;
using HH.ZK.Model.CRM;
using HH.ZK.CommonUI;
using HH.ZK.WebAPIClient;
using LJH.GeneralLibrary;

namespace HH.ZK.UI
{
    public partial class FrmDiscussionView : LJH.GeneralLibrary.WinForm.FrmReportBaseWithPaging<Guid,Discussion>
    {
        public FrmDiscussionView()
        {
            InitializeComponent();
        }

        public override void ShowOperatorRights()
        {
            base.ShowOperatorRights();
            btnSaveAs.Enabled = AppSettings.Current.Operator.PermitAny(Permission.StudentScore, PermissionActions.Read);
        }

        protected override void Init()
        {
            base.Init();
            this.ucDateTimeInterval1.SelectToday();
        }

        protected override QueryResultList<Discussion> GetDataSource(int pageSize, int pageIndex)
        {
            var con = new DiscussionSearchCondition()
            {
                PageIndex = pageIndex,
                PageSize = pageSize,
                SortMode = SortMode.Desc,
            };
            con.CreateTime = new DateTimeRange(this.ucDateTimeInterval1.StartDateTime, this.ucDateTimeInterval1.EndDateTime);
            con.StudentID = txtStudentID1.Text;
            con.Name = txtName.Text;
            return new APIClient(AppSettings.Current.ConnStr).GetList<Guid, Discussion>(con, AppSettings.Current.PhysicalProject.ID);
        }

        protected override void ShowItemInGridViewRow(DataGridViewRow row, Discussion log)
        {
            row.Tag = log;
            row.Cells["colID"].Value = log.Number;
            row.Cells["colCreateTime"].Value = log.CreateTime.ToString ("yyyy-MM-dd HH:mm:ss");
            row.Cells["colStudentID"].Value = log.StudentID;
            row.Cells["colName"].Value = log.Name;
            row.Cells["colFacilityName"].Value = log.FacilityName;
            row.Cells["colScore"].Value = log.Score;
            row.Cells["colScoreTime"].Value = log.ScoreTime.ToString ("yyyy-MM-dd HH:mm:ss");
            row.Cells["colDescription"].Value = log.Description;
            row.Cells["colResolveType"].Value = log.ResolveType;
            row.Cells["colNewScore"].Value = log.NewScore;
            row.Cells["colApprover"].Value = log.Approver;
            var pi =AppSettings.Current.PhysicalProject.PhysicalItems?.GetPhysicalItem(log.PhysicalItem);
            row.Cells["colPhysicalItem"].Value = pi != null ? pi.Name : null;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            var item = dataGridView1.Rows[e.RowIndex].Tag as Discussion;
            var frm = new FrmDiscussionDetail();
            frm.UpdatingItem = item;
            frm.IsForView = true;
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
        }
    }
}