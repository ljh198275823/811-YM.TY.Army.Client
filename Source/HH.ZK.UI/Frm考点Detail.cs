using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HH.ZK.Model;
using HH.ZK.CommonUI;
using HH.ZK.WebAPIClient;
using LJH.GeneralLibrary;
using LJH.GeneralLibrary.WinForm;

namespace HH.ZK.UI
{
    public partial class Frm考点Detail : FrmDetailBase<string, PhysicalProject>
    {
        public Frm考点Detail()
        {
            InitializeComponent();
        }

        #region 重写基类方法
        protected override void InitControls()
        {
            base.InitControls();
        }

        protected override void ItemShowing(PhysicalProject ct)
        {
            txtName.Text = ct.Name;
            txt简称.Text = ct.ShortName;
            rd考核.Checked = ct.ProjectClass == PhysicalProjectClass.考核;
            rd训练.Checked = ct.ProjectClass == PhysicalProjectClass.训练;
        }

        protected override bool CheckInput()
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("名称不能为空");
                txtName.Focus();
                return false;
            }
            if (rd训练.Checked == false && rd考核.Checked == false)
            {
                MessageBox.Show("请选择类型");
                return false;
            }
            return true;
        }

        protected override PhysicalProject GetItemFromInput()
        {
            PhysicalProject ct = UpdatingItem as PhysicalProject;
            if (ct == null) ct = new PhysicalProject() { ID = string.Empty };
            ct.Name = txtName.Text;
            ct.ShortName = txt简称.Text;
            if (rd考核.Checked) ct.ProjectClass = PhysicalProjectClass.考核;
            if (rd训练.Checked) ct.ProjectClass = PhysicalProjectClass.训练;
            ct.CreateDate = DateTime.Now;
            return ct;
        }

        protected override CommandResult<PhysicalProject> AddItem(PhysicalProject addingItem)
        {
            return new APIClient(AppSettings.Current.ConnStr).Add<string, PhysicalProject>(addingItem, null);
        }

        protected override CommandResult<PhysicalProject> UpdateItem(PhysicalProject updatingItem)
        {
            return new APIClient(AppSettings.Current.ConnStr).Add<string, PhysicalProject>(updatingItem, null);
        }

        protected override void ClearInput()
        {
            txtName.Text = string.Empty;
        }
        #endregion
    }
}
