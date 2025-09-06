using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HH.ZK.CommonUI
{
    public partial class FrmStudentIDRange : Form
    {
        public FrmStudentIDRange()
        {
            InitializeComponent();
        }

        public string BeginSid
        {
            get
            {
                return txtBeginSid.Text.Trim();
            }
        }

        public string EndSid
        {
            get
            {
                return txtEndSid.Text.Trim();
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            var beginSid = txtBeginSid.Text.Trim();
            if (string.IsNullOrEmpty(beginSid))
            {
                MessageBox.Show("没有指定开始学号");
                return;
            }
            if (string.IsNullOrEmpty(txtEndSid.Text.Trim())) txtEndSid.Text = beginSid;
            this.DialogResult = DialogResult.OK;
        }
    }
}
