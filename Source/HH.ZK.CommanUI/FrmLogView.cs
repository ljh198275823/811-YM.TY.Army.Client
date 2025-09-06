using System;
using System.Collections.Generic;
using System.Windows.Forms;
using HH.ZK.WebAPIClient;
using HH.ZK.Model;
using HH.ZK.Model.CRM;
using HH.ZK.Model.SearchCondition;
using LJH.GeneralLibrary;
using LJH.GeneralLibrary.WinForm;

namespace HH.ZK.CommonUI
{
    public partial class FrmLogView : FrmReportBaseWithPaging<Guid,Alarm>
    {
        public FrmLogView()
        {
            InitializeComponent();
        }

        #region 重写基类方法
        protected override void Init()
        {
            this.ucDateTimeInterval1.Init();
            this.ucDateTimeInterval1.SelectToday();
            if (AppSettings.Current.PhysicalProject == null) btnSearch.Enabled = false;
        }

        public override void ShowOperatorRights()
        {
            base.ShowOperatorRights();
            btnSearch.Enabled = AppSettings.Current.Operator.PermitAll(Permission.StudentScore, PermissionActions.Read);
            btnSaveAs.Enabled = AppSettings.Current.Operator.PermitAll(Permission.StudentScore, PermissionActions.Read);
        }

        protected override QueryResultList<Alarm> GetDataSource(int pageSize, int pageIndex)
        {
            AlarmSearchCondition con = new AlarmSearchCondition() { PageIndex = pageIndex, PageSize = pageSize, SortMode = SortMode.Desc };
            con.AlarmDateTime = new DateTimeRange(this.ucDateTimeInterval1.StartDateTime, this.ucDateTimeInterval1.EndDateTime);
            return new APIClient(AppSettings.Current.ConnStr).GetList<Guid, Alarm>(con, AppSettings.Current.PhysicalProject.ID);
        }

        protected override void ShowItemInGridViewRow(DataGridViewRow row, Alarm log)
        {
            row.Tag = log;
            row.Cells["colAlarmDateTime"].Value = log.AlarmDateTime;
            row.Cells["colAlarmDescr"].Value = log.AlarmDescr;
            row.Cells["colOperator"].Value = log.OperatorID;
        }
        #endregion
    }
}