using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HH.ZK.UI
{
    public partial class Frm考点名称确认 : Form
    {
        public Frm考点名称确认()
        {
            InitializeComponent();
        }

        public string ProjectName { get; set; }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if(txtName.Text !=ProjectName)
            {
                MessageBox.Show("考点名称输入不正确");
                return;
            }
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        
    }
}
