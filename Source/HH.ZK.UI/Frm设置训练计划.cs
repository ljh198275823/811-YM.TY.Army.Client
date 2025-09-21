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
    public partial class Frm设置训练计划 : Form
    {
        public Frm设置训练计划()
        {
            InitializeComponent();
        }

        public List<Student> Students { get; set; }

        private void FrmPhysicalProjectSelector_Load(object sender, EventArgs e)
        {
            txtProject.Init();
            if (AppSettings.Current.PhysicalProject != null) txtProject.SelectedProject = AppSettings.Current.PhysicalProject;
            if (txtProject.Items == null || txtProject.Items.Count == 0)
            {
                MessageBox.Show("还没有创建训练大纲");
                this.DialogResult = DialogResult.Cancel;
            }
            else if (txtProject.Items != null && txtProject.Items.Count == 1)
            {
                txtProject.SelectedIndex = 0;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtProject.Text))
            {
                List<StudentInProject> sps = new List<StudentInProject>();
                foreach (var s in Students)
                {
                    var sp = new StudentInProject()
                    {
                        ID = Guid.NewGuid(),
                        StudentID = s.ID,
                        ProjectID = txtProject.SelectedProjectID,
                        TestDate = dt训练日期.Value.Date,
                        AddTime = DateTime.Now,
                        Operator = AppSettings.Current.Operator.Name,
                        Teacher = "A",
                    };
                    sps.Add(sp);
                }
                var ret = new APIClient(AppSettings.Current.ConnStr).BatchAdd<Guid, StudentInProject>(sps, ImportOption.Ignore);
                if(ret.Result ==ResultCode.Successful && (ret.Value.Errors ==null || ret.Value.Errors.Count == 0))
                {
                    this.DialogResult = DialogResult.OK;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
