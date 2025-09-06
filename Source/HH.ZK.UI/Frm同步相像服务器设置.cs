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
    public partial class Frm同步相像服务器设置 : Form
    {
        public Frm同步相像服务器设置()
        {
            InitializeComponent();
        }

        private void FrmOption_Load(object sender, EventArgs e)
        {
            //var para = LocalSysParaSettingsBll.GetSetting<VideoServerSetting>(AppSettings.Current.PhysicalProject.ID);
            //if (para != null)
            //{
            //    txtVideoServer.Text = AppSettings.Current.PhysicalProject.VideoServer.ServerUrl;
            //}
            btnOk.Enabled = AppSettings.Current.Operator.PermitAny(Permission.SystemOptions, PermissionActions.Edit);
        }

        private bool CheckInput()
        {
            if (string.IsNullOrEmpty(txtVideoServer.Text))
            {
                MessageBox.Show("请输入服务器地址");
                return false;
            }
            return true;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!CheckInput()) return;
            //var para = new VideoServerSetting();
            //para.ServerUrl = txtVideoServer.Text;
            //var ret = LocalSysParaSettingsBll.SaveSetting<VideoServerSetting>(para, AppSettings.Current.PhysicalProject.ID);
            //if (ret.Result == LJH.GeneralLibrary.ResultCode.Successful)
            //{
            //    AppSettings.Current.PhysicalProject.VideoServer = para;
            //    this.DialogResult = DialogResult.OK;
            //}
            //else
            //{
            //    MessageBox.Show(ret.Message);
            //}
        }
    }
}
