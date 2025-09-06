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
    public partial class FrmScoreCollectStatitics : Form
    {
        public FrmScoreCollectStatitics()
        {
            InitializeComponent();
        }

        public string Host { get; set; }
        public int startSN { get; set; }
        public int endSN { get; set; }
        public int valid { get; set; }
        public int invalid { get; set; }
        public int total { get; set; }
        public int missed { get; set; }
        public string StrMissed { get; set; }
        public decimal min { get; set; }
        public decimal max { get; set; }

        private void FrmStatitics_Load(object sender, EventArgs e)
        {
            txtHost.Text = Host;
            txtStartSN.Text = startSN.ToString();
            txtEndSN.Text = endSN.ToString();
            txtTotal.Text = total.ToString();
            txtMissed.Text = missed.ToString();
            txtMissedDetail.Text = StrMissed;
            txtMin.Text = min.ToString();
            txtMax.Text = max.ToString();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
