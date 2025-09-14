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
    public partial class Frm考点Detail : FrmDetailBase<string, Project>
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

        protected override void ItemShowing(Project ct)
        {
            txtName.Text = ct.Name;
            txt简称.Text = ct.ShortName;
            rd考核.Checked = ct.ProjectClass == ProjectClass.考核;
            rd训练.Checked = ct.ProjectClass == ProjectClass.训练;
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

        protected override Project GetItemFromInput()
        {
            Project ct = UpdatingItem as Project;
            if (ct == null) ct = new Project() { ID = string.Empty };
            ct.Name = txtName.Text;
            ct.ShortName = txt简称.Text;
            if (rd考核.Checked) ct.ProjectClass = ProjectClass.考核;
            if (rd训练.Checked) ct.ProjectClass = ProjectClass.训练;
            ct.CreateDate = DateTime.Now;
            return ct;
        }

        protected override CommandResult<Project> AddItem(Project addingItem)
        {
            return new APIClient(AppSettings.Current.ConnStr).Add<string, Project>(addingItem, null);
        }

        protected override CommandResult<Project> UpdateItem(Project updatingItem)
        {
            return new APIClient(AppSettings.Current.ConnStr).Add<string, Project>(updatingItem, null);
        }

        protected override void ClearInput()
        {
            txtName.Text = string.Empty;
        }
        #endregion
    }
}
