using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Windows.Forms;
using HH.ZK.Model;
using HH.ZK.Model.SearchCondition;
using HH.ZK.Model.CRM;
using HH.ZK.WebAPIClient;
using HH.ZK.CommonUI;
using LJH.GeneralLibrary;

namespace HH.ZK.UI
{
    public partial class Frm切换账号 : Form
    {
        public Frm切换账号()
        {
            InitializeComponent();
        }

        private List<string> GetHistoryOperators()
        {
            List<string> items = null;
            string file = Path.Combine(Application.StartupPath, "HistoryOperators.txt");
            if (File.Exists(file))
            {
                try
                {
                    using (FileStream stream = new FileStream(file, FileMode.Open, FileAccess.Read))
                    {
                        using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
                        {
                            items = new List<string>();
                            while (!reader.EndOfStream)
                            {
                                items.Add(reader.ReadLine());
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    LJH.GeneralLibrary.ExceptionPolicy.HandleException(ex);
                }
            }
            return items;
        }

        private void Frm切换账号_Load(object sender, EventArgs e)
        {
            List<string> history = GetHistoryOperators();
            if (history != null && history.Count > 0)
            {
                this.txtLogName.AutoCompleteCustomSource = new AutoCompleteStringCollection();
                foreach (string item in history)
                {
                    this.txtLogName.AutoCompleteCustomSource.Add(item);
                    this.txtLogName.Items.Add(item);
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string curOpt = AppSettings.Current.Operator.Mobile;
            string pwd = CRMAPIClient._Password;
            var ret1 = CRMAPIClient.GetToken(txtLogName.Text, txtPassword.Text);
            if (ret1.Result != ResultCode.Successful)
            {
                CRMAPIClient.GetToken(curOpt, pwd);
                MessageBox.Show(ret1.Message);
                return;
            }
            var ret = LogInCurentSchool();
            if (ret.Result == ResultCode.Successful && ret.Value != null)
            {
                AppSettings.Current.Operator = ret.Value;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                CRMAPIClient.GetToken(curOpt, pwd);
                if (ret != null) MessageBox.Show(ret.Message);
            }
        }

        private CommandResult<User> LogInCurentSchool()
        {
            var log = new LogInInfo()
            {
                Client = AppSettings.Current.AppName,
                LocalIP = LJH.GeneralLibrary.Net.NetTool.GetLocalIP()?.ToString(),
                MAC = LJH.GeneralLibrary.Net.NetTool.GetLocalMAC(),
                PCName = LJH.GeneralLibrary.Net.NetTool.GetHostName(),
            };
            if (string.IsNullOrEmpty(log.MAC)) log.MAC = log.PCName;
            var ret = CRMAPIClient.LogIn(log);
            return ret;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
