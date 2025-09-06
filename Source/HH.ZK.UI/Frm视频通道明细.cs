using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HH.ZK.WebAPIClient;
using HH.ZK.Model;
using HH.Zhongkao.Device;
using HH.Zhongkao.Device.Wifi;
using HH.ZK.CommonUI;
using LJH.GeneralLibrary;

namespace HH.ZK.UI
{
    public partial class Frm视频通道明细 : Form
    {
        public Frm视频通道明细()
        {
            InitializeComponent();
        }

        public string DeviceSN { get; set; }

        public string Channels { get; set; }

        public string Memo { get; set; }

        private void Frm视频通道明细_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(DeviceSN))
            {
                txtSN.Text = DeviceSN;
                txtSN.Enabled = false;
            }
            txtChannels.Text = Channels;
        }

        private void lnk视频通道_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var dig = new Frm设置视频通道();
            if (dig.ShowDialog() != DialogResult.OK) return;
            txtChannels.Text  = dig.VideoChannels;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty (txtSN.Text))
            {
                MessageBox.Show("设备编号没有填写");
                return;
            }
            if(string.IsNullOrEmpty(txtChannels .Text))
            {
                MessageBox.Show("没有填写对应的视频通道");
                return;
            }
            DeviceSN = txtSN.Text.Trim();
            Channels = txtChannels.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
