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
    public partial class Frm设置考试时间 : Form
    {
        public Frm设置考试时间()
        {
            InitializeComponent();
        }

        public string 考试时间 { get; set; }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt考试时间.Text.Trim())) 考试时间 = null;
            else 考试时间 = txt考试时间.Text.Trim();
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
