using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HH.ZK.Model;
using HH.ZK.Model.CRM;
using HH.ZK.WebAPIClient;
using HH.ZK.CommonUI;

namespace HH.ZK.UI
{
    public partial class FrmOption_检录 : Form
    {
        public FrmOption_检录()
        {
            InitializeComponent();
        }

        private void FrmOption_Load(object sender, EventArgs e)
        {
            cmbICCardReader.Init();
            cmbICCardReader.ComPort = AppSettings.Current.CardReaderCommport;

            cmbBarcodeReader.Init();
            cmbBarcodeReader.ComPort = AppSettings.Current.BarcodeReaderCommport;

            int idr210Port = 0;
            string temp = AppSettings.Current.GetConfigContent("IDR210Port");
            if (!string.IsNullOrEmpty(temp) && int.TryParse(temp, out idr210Port))
            {
                if (idr210Port == 1001)
                {
                    chk启用二代身份证阅读器.Checked = true;
                }
                else
                {
                    chk启用二代身份证阅读器.Checked = false;
                }
            }
            temp = AppSettings.Current.GetConfigContent("AutoWriteCard");
            bool autoWriteCard = false;
            if (!string.IsNullOrEmpty(temp) && bool.TryParse(temp, out autoWriteCard)) chkAutoWriteCard.Checked = autoWriteCard;
            else chkAutoWriteCard.Checked = false;
            chkEnableTTS.Checked = AppSettings.Current.EnableTTS;
            rd按分组进行检录.Checked = AppSettings.Current.PhysicalProject.CheckOptions.CheckMode == CheckMode.按分组进行检录;
            rd现场分组检录.Checked = AppSettings.Current.PhysicalProject.CheckOptions.CheckMode == CheckMode.现场分组检录;
            rd随机检录.Checked = AppSettings.Current.PhysicalProject.CheckOptions.CheckMode == CheckMode.随机检录;
            chk扫码后自动通过检录.Checked = AppSettings.Current.GetConfigContent("AutoChecked") == "1";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            AppSettings.Current.CardReaderCommport = cmbICCardReader.ComPort;
            AppSettings.Current.BarcodeReaderCommport = cmbBarcodeReader.ComPort;
            int idr210Port = chk启用二代身份证阅读器.Checked ? 1001 : 0;
            AppSettings.Current.SaveConfig("IDR210Port", idr210Port.ToString());
            AppSettings.Current.EnableTTS = chkEnableTTS.Checked;
            AppSettings.Current.SaveConfig("AutoWriteCard", chkAutoWriteCard.Checked.ToString());
            AppSettings.Current.SaveConfig("AutoChecked", chk扫码后自动通过检录.Checked ? "1" : "0");
            var option = new CheckOptions();
            if (rd按分组进行检录.Checked) option.CheckMode = CheckMode.按分组进行检录;
            else if (rd现场分组检录.Checked) option.CheckMode = CheckMode.现场分组检录;
            else if (rd随机检录.Checked) option.CheckMode = CheckMode.随机检录;
            var ret = SysParaSettingsClient.SaveSetting<CheckOptions>(option, AppSettings.Current.ConnStr, AppSettings.Current.PhysicalProject.ID);
            if (ret.Result == LJH.GeneralLibrary.ResultCode.Successful) AppSettings.Current.PhysicalProject.CheckOptions = option;
            this.DialogResult = DialogResult.OK;
        }
    }
}
