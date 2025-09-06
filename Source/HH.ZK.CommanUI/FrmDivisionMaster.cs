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
using HH.ZK.WebAPIClient;
using LJH.GeneralLibrary;
using LJH.GeneralLibrary.WinForm;

namespace HH.ZK.CommonUI
{
    public partial class FrmDivisionMaster : FrmMasterBase<Guid, Division>
    {
        public FrmDivisionMaster()
        {
            InitializeComponent();
        }

        #region 重写基类方法
        public override void ShowOperatorRights()
        {
            base.ShowOperatorRights();
            btn新建.Enabled = AppSettings.Current.Operator.PermitAll(Permission.Division, PermissionActions.Edit) && AppSettings.Current.Operator.SelectionItems == null;
            cMnu_Add.Enabled = AppSettings.Current.Operator.PermitAll(Permission.Division, PermissionActions.Edit) && AppSettings.Current.Operator.SelectionItems == null;
            cMnu_Delete.Enabled = AppSettings.Current.Operator.PermitAll(Permission.Division, PermissionActions.Delete) && AppSettings.Current.Operator.SelectionItems == null;
            cMnu_Edit.Enabled = AppSettings.Current.Operator.PermitAll(Permission.Division, PermissionActions.Edit);
        }

        protected override FrmDetailBase<Guid, Division> GetDetailForm()
        {
            return new FrmDivisionDetail();
        }

        protected override QueryResultList<Division> GetDataSource()
        {
            return (new APIClient(AppSettings.Current.ConnStr)).GetList<Guid, Division>(SearchCondition);
        }

        protected override List<Division> FilterData(List<Division> items)
        {
            items = FullTextSearch(items, txtKey.Text);
            return (from it in items
                    orderby it.FullPath ascending, it.Number ascending, it.Name ascending
                    select it).ToList();
        }

        protected override object GetCellValue(Division item, string colName)
        {
            if (colName == "colName") return item.Name;
            if (colName == "colParent")
            {
                var p = _Items.SingleOrDefault(it => it.ID == item.ParentID);
                return p?.Name;
            }
            return base.GetCellValue(item, colName);
        }

        protected override CommandResult DeletingItem(Division item)
        {
            return (new APIClient(AppSettings.Current.ConnStr)).Delete<Guid, Division>(item);
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
        #endregion
    }
}
