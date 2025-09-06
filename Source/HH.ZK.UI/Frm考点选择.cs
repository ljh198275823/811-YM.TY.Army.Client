using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HH.ZK.Model;
using HH.ZK.Model.SearchCondition;
using HH.ZK.WebAPIClient;
using LJH.GeneralLibrary;
using HH.ZK.CommonUI;

namespace HH.ZK.UI
{
    public partial class Frm考点选择 : Form
    {
        public Frm考点选择()
        {
            InitializeComponent();
        }

        #region 私有方法
        private void SetCurrentProject(string projectID)
        {
            PhysicalProject p = new APIClient(AppSettings.Current.ConnStr).GetByID<string, PhysicalProject>(projectID, null).QueryObject;
            if (p != null)
            {
                AppSettings.Current.PhysicalProject = p;
                p.PhysicalItems = SysParaSettingsClient.GetOrCreateSetting<PhysicalItemSettings>(AppSettings.Current.ConnStr, p.TemplateProjectID);
                p.Options = SysParaSettingsClient.GetOrCreateSetting<PhysicalProjectOptions>(AppSettings.Current.ConnStr, p.TemplateProjectID);
                p.StateSettings = SysParaSettingsClient.GetOrCreateSetting<StudentStateSettings>(AppSettings.Current.ConnStr, p.TemplateProjectID);
                p.CheckOptions = SysParaSettingsClient.GetOrCreateSetting<CheckOptions>(AppSettings.Current.ConnStr, p.ID);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("获取测试计划失败,请重新登录软件");
                this.DialogResult = DialogResult.Cancel;
            }
        }
        #endregion

        private void FrmPhysicalProjectSelector_Load(object sender, EventArgs e)
        {
            if (AppSettings.Current.PhysicalProject != null) txtProject.SelectedProject = AppSettings.Current.PhysicalProject;
            if (txtProject.Items == null || txtProject.Items.Count == 0)
            {
                MessageBox.Show("还没有创建考点，请先在中考后台软件中创建考点信息");
                this.DialogResult = DialogResult.Cancel;
            }
            else if (txtProject.Items != null && txtProject.Items.Count == 1)
            {
                var project = txtProject.Items[0] as PhysicalProject;
                if (AppSettings.Current.PhysicalProject == null || AppSettings.Current.PhysicalProject.ID != project.ID) SetCurrentProject(project.ID);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtProject.Text))
            {
                if (txtProject.SelectedProjectID == AppSettings.Current.PhysicalProject?.ID)
                {
                    this.DialogResult = DialogResult.Cancel;
                }
                else
                {
                    SetCurrentProject(txtProject.SelectedProjectID);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
