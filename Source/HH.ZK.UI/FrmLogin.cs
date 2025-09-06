using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using HH.ZK.Model;
using LJH.GeneralLibrary;
using HH.ZK.Model.CRM;
using HH.ZK.CommonUI;
using HH.ZK.WebAPIClient;

namespace HH.ZK.UI
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        #region 私有方法
        private void DoLogin(string logName, string pwd)
        {
            var ret1 = HH.ZK.WebAPIClient.CRMAPIClient.GetToken(logName, pwd);
            if (ret1.Result == LJH.GeneralLibrary.ResultCode.Successful)
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
                if (ret.Result == ResultCode.Successful && ret.Value != null)
                {
                    if (ret.Value.ExpireDate.HasValue && ret.Value.ExpireDate?.Date < DateTime.Today)
                    {
                        MessageBox.Show($"软件授权使用日期已过，请联系我们销售或客服人员进行延期，公司热线:400-882-8657");
                        return;
                    }
                    if (ret.Value.ExpireDate.HasValue && ret.Value.ExpireDate > DateTime.Today && ret.Value.ExpireDate <= DateTime.Today.AddDays(15)) //已经过期
                    {
                        TimeSpan ts = new TimeSpan(ret.Value.ExpireDate.Value.Date.Ticks - DateTime.Today.Ticks);
                        MessageBox.Show(string.Format("软件还有 {0} 天就过期了，请尽快与供应商联系延长您的软件使用期!", (int)(ts.TotalDays + 1)), "注意");
                    }
                    AppSettings.Current.Operator = ret.Value;
                    if ((AppSettings.Current.Operator.States & OperatorState.密码过期) > 0)
                    {
                        FrmChangePwd frm = new FrmChangePwd();
                        frm.Operator = AppSettings.Current.Operator;
                        frm.ShowDialog();
                    }
                    AppSettings.Current.Operator = ret.Value;
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show(ret.Message);
                }
                if (chk记住登录名.Checked)
                {
                    AppSettings.Current.LastLogin = logName;
                    SaveHistoryOperators();
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(ret1.Message);
            }
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

        private void SaveHistoryOperators()
        {
            List<string> items = new List<string>();
            if (txtLogName.AutoCompleteCustomSource != null && txtLogName.AutoCompleteCustomSource.Count > 0)
            {
                string[] history = new string[txtLogName.AutoCompleteCustomSource.Count];
                txtLogName.AutoCompleteCustomSource.CopyTo(history, 0);
                items.AddRange(history);
            }
            if (!items.Contains(txtLogName.Text)) items.Insert(0, txtLogName.Text);
            try
            {
                string file = Path.Combine(Application.StartupPath, "HistoryOperators.txt");
                using (FileStream stream = new FileStream(file, FileMode.Create, FileAccess.Write))
                {
                    using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8))
                    {
                        foreach (string item in items)
                        {
                            writer.WriteLine(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LJH.GeneralLibrary.ExceptionPolicy.HandleException(ex);
            }
        }
        #endregion

        #region 事件处理程序
        private void Login_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(AppSettings.Current.LastLogin))
            {
                txtLogName.TabIndex = 10;
                txtPassword.TabIndex = 0;
            }
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
            if (!string.IsNullOrEmpty(AppSettings.Current.LastLogin))
            {
                txtPassword.Focus();
                txtLogName.Text = AppSettings.Current.LastLogin;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string logName = this.txtLogName.Text.Trim();
            string pwd = this.txtPassword.Text.Trim();

            if (logName.Length == 0)
            {
                MessageBox.Show("登录名不能为空!");
                return;
            }

            if (pwd.Length == 0)
            {
                MessageBox.Show("密码不能为空!");
                return;
            }
            DoLogin(logName, pwd);
        }

        private void btnResetPwd_Click(object sender, EventArgs e)
        {
            var frm = new Frm重置密码();
            frm.StartPosition = FormStartPosition.CenterParent;
            var dig = frm.ShowDialog();
            if (dig == DialogResult.OK)
            {
                txtLogName.Text = frm.Mobile;
                txtPassword.Text = "123";
                DoLogin(txtLogName.Text, txtPassword.Text);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        #endregion
    }
}
