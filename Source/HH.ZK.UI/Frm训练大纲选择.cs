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
    public partial class Frm训练大纲选择 : Form
    {
        public Frm训练大纲选择()
        {
            InitializeComponent();
        }

        public string ProjectID { get; set; }

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
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtProject.Text))
            {
                ProjectID = txtProject.SelectedProjectID;
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
