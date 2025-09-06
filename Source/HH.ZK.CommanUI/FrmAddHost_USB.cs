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
    public partial class FrmAddHost_USB : Form
    {
        public FrmAddHost_USB()
        {
            InitializeComponent();
        }

        public byte Commport
        {
            get { return this.cmbCommport.ComPort; }
        }

        public byte HostID
        {
            get { return (byte)txtHost.IntergerValue; }
        }

        private void FrmAddHost_USB_Load(object sender, EventArgs e)
        {
            this.cmbCommport.Init();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (this.cmbCommport.ComPort <= 0)
            {
                MessageBox.Show("请设置主机串口号");
                return;
            }
            if (txtHost.IntergerValue <= 0)
            {
                MessageBox.Show("请设置主机号");
                return;
            }
            this.DialogResult = DialogResult.OK;
        }

        private void cmbCommport_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCommport.SelectedIndex > 0)
            {
                using (var host = HH.Zhongkao.Device.Wifi.WifiHost.CreateInstance(0, cmbCommport.ComPort.ToString(), null))
                {
                    host.Log = true;
                    var hostID = host.GetHostID();
                    if (hostID > 0)
                    {
                        txtHost.IntergerValue = hostID;
                    }
                    else
                    {
                        MessageBox.Show("没有获取到主机信息，请确认主机是否连接");
                    }
                }
            }
        }
    }
}
