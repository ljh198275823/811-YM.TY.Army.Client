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
    public partial class FrmOption_联机 : Form
    {
        public FrmOption_联机()
        {
            InitializeComponent();
        }

        private void FrmOption_Load(object sender, EventArgs e)
        {
            cmbBarCodeReader.Init();
            cmbBarCodeReader.ComPort = AppSettings.Current.BarcodeReaderCommport;
            cmbICCardReader.Init();
            cmbICCardReader.ComPort = AppSettings.Current.CardReaderCommport;
            int idr210Port = 0;
            string temp = AppSettings.Current.GetConfigContent("IDR210Port");
            if (!string.IsNullOrEmpty(temp) && int.TryParse(temp, out idr210Port))
            {
                chk启用二代身份证阅读器.Checked = idr210Port == 1001;
            }
            chkEnableTTS.Checked = AppSettings.Current.EnableTTS;
            btnOk.Enabled = AppSettings.Current.Operator.PermitAny(Permission.SystemOptions, PermissionActions.Edit);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            AppSettings.Current.BarcodeReaderCommport = cmbBarCodeReader.ComPort;
            AppSettings.Current.CardReaderCommport = cmbICCardReader.ComPort;
            int idr210Port = chk启用二代身份证阅读器.Checked ? 1001 : 0;
            AppSettings.Current.SaveConfig("IDR210Port", idr210Port.ToString());
            AppSettings.Current.EnableTTS = chkEnableTTS.Checked;
            this.DialogResult = DialogResult.OK;
        }
    }
}
