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
    public partial class FrmDateRange : Form
    {
        public FrmDateRange()
        {
            InitializeComponent();
        }

        public DateTime  BeginDt
        {
            get
            {
                return dtBegin.Value;
            }
        }

        public DateTime EndDt
        {
            get
            {
                return dtEnd.Value;
            }
        }

        private void FrmDateRange_Load(object sender, EventArgs e)
        {
            dtBegin.Value = DateTime.Today;
            dtEnd.Value = DateTime.Today.AddDays(1).AddSeconds(-1);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (dtBegin.Value > dtEnd.Value)
            {
                MessageBox.Show("开始时间不能大于结束时间");
                return;
            }
            this.DialogResult = DialogResult.OK;
        }
    }
}
