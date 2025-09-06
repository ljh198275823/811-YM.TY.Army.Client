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
            dtStartDate.Value = AppSettings.Current.PhysicalProject.StartDate.Date;
            dtEndDate.Value = AppSettings.Current.PhysicalProject.EndDate.Date;
        }

        protected override void ItemShowing(PhysicalProject ct)
        {
            txtName.Text = ct.Name;
            dtStartDate.Value = ct.StartDate;
            dtEndDate.Value = ct.EndDate;
            rd正式考试.Checked = ct.State == PhysicalProjectState.正式考试;
            rd模拟考试.Checked = ct.State == PhysicalProjectState.模拟考试;
        }

        protected override bool CheckInput()
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("名称不能为空");
                txtName.Focus();
                return false;
            }
            if (dtStartDate.Value > dtEndDate.Value)
            {
                MessageBox.Show("开考日期大于结束日期");
                return false;
            }
            if (rd模拟考试.Checked == false && rd正式考试.Checked == false)
            {
                MessageBox.Show("请选择考试状态");
                return false;
            }
            return true;
        }

        protected override PhysicalProject GetItemFromInput()
        {
            PhysicalProject ct = UpdatingItem as PhysicalProject;
            if (ct == null)
            {
                ct = new PhysicalProject();
                ct.ProjectClass = PhysicalProjectClass.汇海中考;
                ct.Year = AppSettings.Current.PhysicalProject.Year;
                ct.TemplateProjectID = AppSettings.Current.PhysicalProject.ID;
            }
            ct.Name = txtName.Text;
            ct.StartDate = dtStartDate.Value.Date;
            ct.EndDate = dtEndDate.Value.Date.AddDays(1).AddSeconds(-1);
            ct.State = rd模拟考试.Checked ? PhysicalProjectState.模拟考试 : PhysicalProjectState.正式考试;
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
