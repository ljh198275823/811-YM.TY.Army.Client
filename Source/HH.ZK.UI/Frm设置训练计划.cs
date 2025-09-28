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

        public DateTimeRange DateRange { get; set; }

        public List<Student> Students { get; set; }

        public List<StudentInProject > CreatedItems { get; set; }

        private void FrmPhysicalProjectSelector_Load(object sender, EventArgs e)
        {
            txtProject.Init();
            if (txtProject.Items == null || txtProject.Items.Count == 0)
            {
                MessageBox.Show("还没有创建训练大纲");
                this.DialogResult = DialogResult.Cancel;
            }
            else if (txtProject.Items != null && txtProject.Items.Count == 1)
            {
                txtProject.SelectedIndex = 0;
            }
            if (DateRange != null)
            {
                dt开始训练日期.Value = DateRange.Begin;
                dt结束训练日期.Value = DateRange.End;
            }
        }

        private List<StudentInProject> CreatePlans(DateTime dtBegin, DateTime dtEnd)
        {
            List<StudentInProject> sps = new List<StudentInProject>();
            foreach (var s in Students)
            {
                var dt = dtBegin;
                while (dt <= dtEnd)
                {
                    var sp = new StudentInProject()
                    {
                        StudentID = s.ID,
                        ProjectID = txtProject.SelectedProjectID,
                        TestDate = dt,
                        AddTime = DateTime.Now,
                        Operator = AppSettings.Current.Operator.Name,
                        Teacher = "A",
                    };
                    sps.Add(sp);
                    dt = dt.AddDays(1);
                }
            }
            return sps;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtProject.Text))
            {
                CreatedItems = CreatePlans(dt开始训练日期.Value.Date, dt结束训练日期.Value.Date);
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
