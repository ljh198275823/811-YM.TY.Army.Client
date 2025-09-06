using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HH.ZK.Model;
using HH.ZK.Model.CRM;
using HH.ZK.Model.SearchCondition;
using HH.ZK.WebAPIClient;
using HH.ZK.CommonUI;
using LJH.GeneralLibrary;
using LJH.GeneralLibrary.WinForm;

namespace HH.ZK.CommonUI
{
    public partial class FrmFacilityMaster : FrmMasterBase<string, Facility>
    {
        public FrmFacilityMaster()
        {
            InitializeComponent();
        }

        #region 重写基类方法

        public override void ShowOperatorRights()
        {
            base.ShowOperatorRights();
            cMnu_Edit.Enabled = AppSettings.Current.Operator.PermitAll(Permission.Facility, PermissionActions.Edit);
            cMnu_Add.Enabled = AppSettings.Current.Operator.PermitAll(Permission.Facility, PermissionActions.Edit);
            cMnu_Delete.Enabled = AppSettings.Current.Operator.PermitAll(Permission.Facility, PermissionActions.Delete);
            btn导入学校.Enabled = AppSettings.Current.Operator.PermitAny(Permission.Facility, PermissionActions.Edit);
            btn新建.Enabled = AppSettings.Current.Operator.PermitAny(Permission.Facility, PermissionActions.Edit);
        }

        protected override FrmDetailBase<string, Facility> GetDetailForm()
        {
            return new FrmFacilityDetail();
        }

        protected override QueryResultList<Facility> GetDataSource()
        {
            return new APIClient(AppSettings.Current.ConnStr).GetList<string, Facility>(SearchCondition, AppSettings.Current.PhysicalProject.ID);
        }

        protected override List<Facility> FilterData(List<Facility> items)
        {
            items = FullTextSearch(items, txtKey.Text);
            return (from it in items
                    orderby it.DivisionName ascending, it.Name ascending
                    select it).ToList();
        }

        protected override object GetCellValue(Facility ct, string colName)
        {
            if (colName == "colName") return ct.Name;
            if (colName == "colParent") return ct.DivisionName;
            return base.GetCellValue(ct, colName);
        }

        protected override CommandResult DeletingItem(Facility item)
        {
            return (new APIClient(AppSettings.Current.ConnStr)).Delete<string, Facility>(item, AppSettings.Current.PhysicalProject.ID);
        }
        #endregion

        #region 事件处理程序
        private void txtKey_TextChanged(object sender, EventArgs e)
        {
            FreshView();
        }

        private void btn新建_Click(object sender, EventArgs e)
        {
            cMnu_Add.PerformClick();
        }

        private void btn刷新_Click(object sender, EventArgs e)
        {
            cMnu_Fresh.PerformClick();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frm = new FrmFacilityImport();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
            cMnu_Fresh.PerformClick();
        }
        #endregion
    }
}
