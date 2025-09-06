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
    public partial class FrmSerialRange : Form
    {
        public FrmSerialRange()
        {
            InitializeComponent();
        }

        public short BeginSer
        {
            get
            {
                return (short)(ushort.Parse(txtBeginSid.Text.Trim()));
            }
        }

        public short EndSer
        {
            get
            {
                return (short)(ushort.Parse(txtEndSid.Text.Trim()));
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            ushort temp = 0;
            if (string.IsNullOrEmpty(txtBeginSid.Text) || !ushort.TryParse(txtBeginSid.Text, out temp))
            {
                MessageBox.Show("开始序列号不能转化成整数或超出范围(0-65535)");
                return;
            }
            if (!string.IsNullOrEmpty(txtEndSid.Text) && !ushort.TryParse(txtEndSid.Text, out temp))
            {
                MessageBox.Show("结束序列号不能转化成整数或超出范围(0-65535)");
                return;
            }
            if (string.IsNullOrEmpty(txtEndSid.Text)) txtEndSid.Text = "65535";
            this.DialogResult = DialogResult.OK;
        }
    }
}
