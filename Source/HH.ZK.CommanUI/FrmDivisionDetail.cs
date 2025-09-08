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
using HH.ZK.CommonUI;
using LJH.GeneralLibrary;
using LJH.GeneralLibrary.WinForm;

namespace HH.ZK.CommonUI
{
    public partial class FrmDivisionDetail : FrmDetailBase<Guid, Division>
    {
        public FrmDivisionDetail()
        {
            InitializeComponent();
        }

        public Division ParentDivision { get; set; }

        #region 重写基类方法
        protected override void InitControls()
        {
            base.InitControls();
            txtDivision.Init();
            if (ParentDivision != null) txtDivision.SelectedDivisionID = ParentDivision.ID;
        }

        public override void ShowOperatorRights()
        {
            base.ShowOperatorRights();
            btnOk.Enabled = AppSettings.Current.Operator.PermitAll(Permission.Division, PermissionActions.Edit);
        }

        protected override bool CheckInput()
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("名称不能为空");
                txtName.Focus();
                return false;
            }
            if (UpdatingItem != null && txtDivision.SelectedDivisionID == (UpdatingItem as Division).ID)
            {
                MessageBox.Show("区域的上级区域不能是本区域");
                return false;
            }
            return true;
        }

        protected override void ItemShowing(Division item)
        {
            txtName.Text = item.Name;
            txtDivision.SelectedDivisionID = item.ParentID;
            txtMemo.Text = item.Number;
        }

        protected override Division GetItemFromInput()
        {
            Division ct = UpdatingItem as Division;
            if (IsAdding)
            {
                ct = new Division() { ID = Guid.NewGuid() };
            }
            ct.Name = txtName.Text;
            ct.ParentID = txtDivision.SelectedDivisionID;
            ct.Number = txtMemo.Text;
            return ct;
        }

        protected override CommandResult<Division> AddItem(Division addingItem)
        {
            var ret = (new APIClient(AppSettings.Current.ConnStr)).Add<Guid, Division>(addingItem, null);
            return ret;
        }

        protected override CommandResult<Division> UpdateItem(Division updatingItem)
        {
            return (new APIClient(AppSettings.Current.ConnStr)).Add<Guid, Division>(updatingItem, null);
        }

        protected override void ClearInput()
        {
            txtName.Text = string.Empty;
        }
        #endregion
    }
}
