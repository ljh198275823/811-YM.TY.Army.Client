using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace HH.ZK.CommonUI
{
    public partial class FrmAddHost : Form
    {
        public FrmAddHost()
        {
            InitializeComponent();
        }

        public string IP
        {
            get { return GetIP(); }
        }

        public byte HostID
        {
            get { return (byte)txtHost.IntergerValue; }
        }

        public string SerialNumber
        {
            get { return txtSer.Text.Trim(); }
        }

        public byte PhysicalID
        {
            get { return (byte)txtPid.IntergerValue; }
        }

        private string GetIP()
        {
            return string.Format("{0}{1}", txtIP.Text.Trim(), txtIP1.IntergerValue);
        }

        private void FrmAddHost_Load(object sender, EventArgs e)
        {
            txtIP.Items.Clear();
            var ips = LJH.GeneralLibrary.Net.NetTool.GetLocalIPS();
            if (ips != null && ips.Length > 0)
            {
                foreach (var ip in ips)
                {
                    var strIP = ip.ToString();
                    if (!string.IsNullOrEmpty(strIP))
                    {
                        string[] temp = strIP.Split('.');
                        if (temp.Length == 4) this.txtIP.Items.Add(string.Format("{0}.{1}.{2}.", temp[0], temp[1], temp[2]));
                    }
                }
                if (txtIP.Items.Count > 0) this.txtIP.SelectedIndex = 0;
                txtIP1.SelectAll();
            }
        }

        private bool CheckInput()
        {
            string ip = GetIP();
            IPAddress ipAddr;
            if (!IPAddress.TryParse(ip, out ipAddr))
            {
                MessageBox.Show("请设置正确的IP地址");
                return false;
            }
            if (txtHost.IntergerValue == 0)
            {
                MessageBox.Show("请设置主机号");
                return false;
            }
            if (string.IsNullOrEmpty(txtSer.Text))
            {
                MessageBox.Show("请设置序列号");
                return false;
            }
            return true;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void txtIP_Leave(object sender, EventArgs e)
        {
            IPAddress ipAddr;
            if (IPAddress.TryParse(GetIP(), out ipAddr))
            {
                Ping ping = new Ping();
                PingReply reply = new Ping().Send(ipAddr, 1000);
                if (reply.Status != IPStatus.Success)
                {
                    MessageBox.Show("不能PING通此IP地址，请确定IP地址输入是否正确");
                    return;
                }
                var host = HH.Zhongkao.Device.Wifi.WifiSearcher.Search(GetIP(), 5000);
                while (host == null)
                {
                    if (MessageBox.Show("没有收到此设备的回复，是否继续尝试一次?", "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        host = HH.Zhongkao.Device.Wifi.WifiSearcher.Search(GetIP(), 5000);
                    }
                    else break;
                }
                txtSer.Text = host != null ? host.SerialNumber : string.Empty;
                txtHost.IntergerValue = host != null ? host.HostID : 0;
                txtPid.IntergerValue = host != null ? host.PhysicalID : 0;
            }
        }
    }
}
