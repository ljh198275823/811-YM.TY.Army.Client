using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HH.ZK.Model;
using HH.ZK.CommonUI;
using HH.ZK.Model.CRM;

namespace HH.ZK.UI
{
    public partial class Frm同步相像本地保存路径设置 : Form
    {
        public Frm同步相像本地保存路径设置()
        {
            InitializeComponent();
        }

        private void FrmOption_Load(object sender, EventArgs e)
        {
            txtVideoPath.Text = AppSettings.Current.VideoPath;
            btnOk.Enabled = AppSettings.Current.Operator.PermitAny(Permission.SystemOptions, PermissionActions.Edit);
        }

        private bool CheckInput()
        {
            return true;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!CheckInput()) return;
            if (!string.IsNullOrEmpty(txtVideoPath.Text)) AppSettings.Current.VideoPath = txtVideoPath.Text.Trim();
            this.DialogResult = DialogResult.OK;
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog frm = new FolderBrowserDialog();
            if (!string.IsNullOrEmpty(txtVideoPath.Text)) frm.SelectedPath = txtVideoPath.Text;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtVideoPath.Text = frm.SelectedPath;
            }
        }
    }
}
