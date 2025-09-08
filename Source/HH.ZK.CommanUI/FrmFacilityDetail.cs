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
    public partial class FrmFacilityDetail : FrmDetailBase<string,Facility>
    {
        public FrmFacilityDetail()
        {
            InitializeComponent();
        }

        #region 公共属性
        /// <summary>
        /// 获取或设置父类别
        /// </summary>
        public Division Division { get; set; }
        #endregion

        #region 重写基类方法
        protected override void InitControls()
        {
            base.InitControls();
            txtDivision.Init();
            if (Division != null) txtDivision.SelectedDivisionID = Division.ID;
        }

        public override void ShowOperatorRights()
        {
            base.ShowOperatorRights();
            btnOk.Enabled = AppSettings.Current.Operator.PermitAll(Permission.Facility, PermissionActions.Edit);
        }

        protected override bool CheckInput()
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("名称不能为空");
                txtName.Focus();
                return false;
            }
            return true;
        }

        protected override void ItemShowing(Facility item)
        {
            txtName.Text = item.Name;
            txtDivision.SelectedDivisionID = item.DivisionID;
        }

        protected override Facility GetItemFromInput()
        {
            Facility ct = UpdatingItem as Facility;
            if (IsAdding)
            {
                ct = new Facility();
            }
            ct.Name = txtName.Text;
            ct.DivisionID = txtDivision.SelectedDivisionID;
            return ct;
        }

        protected override CommandResult<Facility> AddItem(Facility addingItem)
        {
            var ret = (new APIClient(AppSettings.Current.ConnStr)).Add<string, Facility>(addingItem, AppSettings.Current.PhysicalProject.ID);
            return ret;
        }

        protected override CommandResult<Facility> UpdateItem(Facility updatingItem)
        {
            var ret = (new APIClient(AppSettings.Current.ConnStr)).Add<string, Facility>(updatingItem, AppSettings.Current.PhysicalProject.ID);
            return ret;
        }

        protected override void ClearInput()
        {
            txtName.Text = string.Empty;
        }
        #endregion
    }
}
