using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HH.ZK.UI
{
    public partial class Frm软件更新日志 : Form
    {
        public Frm软件更新日志()
        {
            InitializeComponent();
        }

        public string Url = "http://120.77.11.122/support/update/zk/v3/changeLog.txt";

        private void FrmChangeLogViewer_Load(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(Url))
            {
                this.webBrowser1.Navigate(Url);
            }
        }
    }
}
