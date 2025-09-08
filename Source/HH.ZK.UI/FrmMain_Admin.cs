using System;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Reflection;
using System.Linq;
using HH.ZK.Model;
using HH.ZK.Model.SearchCondition;
using HH.ZK.Model.CRM;
using HH.ZK.CommonUI;
using HH.ZK.WebAPIClient;
using LJH.GeneralLibrary.SoftDog;
using LJH.GeneralLibrary.WinForm;
using AutoUpdaterDotNET;

namespace HH.ZK.UI
{
    public partial class FrmMain_Admin : Form
    {
        public FrmMain_Admin()
        {
            InitializeComponent();
        }

        #region 私有变量
        private Dictionary<Form, string> _openedForms = new Dictionary<Form, string>();
        #endregion

        #region 私有方法
        private void StartPingInternet()
        {
            InternetPingService.Current = new InternetPingService();
            InternetPingService.Current.InternetConnected += delegate (object obj, EventArgs args)
            {
                Action action = delegate ()
                {
                    lblState.Text = "在线";
                    lblState.ForeColor = Color.Blue;
                    ShowOperatorRights();
                };
                this.Invoke(action);
            };
            InternetPingService.Current.InternetDisconnected += delegate (object obj, EventArgs args)
            {
                Action action = delegate ()
                {
                    lblState.Text = "离线";
                    lblState.ForeColor = Color.Red;
                    ShowOperatorRights();
                };
                this.Invoke(action);
            };
            InternetPingService.Current.Start();
        }

        private void DoLogIn()
        {
            DialogResult ret = (new FrmLogin()).ShowDialog();
            if (ret == DialogResult.OK)
            {
                SetCurrentSchool(); //设置当前学校
            }
            else
            {
                Environment.Exit(0);
            }
        }

        private void SetCurrentSchool()
        {
            this.lblOperator.Text = AppSettings.Current.Operator.Name;
            foreach (var f in _openedForms.Keys.ToList())
            {
                f.Close();
                ucFormViewMain.RemoveForm(f);
            }
            //初始化模板信息
            ShowOperatorRights();
        }

        public void ShowOperatorRights()
        {
            btn_PhysicalItemSelect.Enabled = true;
            btn_Standard.Enabled = true;
            btn特殊评分标准.Enabled = true;
            btn考点管理.Enabled = true;
            btn账号管理.Enabled = true;
            mnu特殊情况设置.Enabled = true;
            btn系统参数.Enabled = true;
            btn小程序参数.Enabled = true;
        }
        #endregion

        #region 子窗体相关方法
        /// <summary>
        /// 显示窗口的单个实例，如果之前已经打开过，则只是激活打开过的窗体
        /// </summary>
        /// <param name="formType">要打开的窗体类型</param>
        /// <param name="mainPanel">是否在主面板中打开,否则在从面板中打开</param>
        public T ShowSingleForm<T>(object menu = null) where T : Form
        {
            string cmd = null;
            if (menu is ToolStripMenuItem) cmd = (menu as ToolStripMenuItem).Name;

            T instance = null;
            foreach (Form frm in _openedForms.Keys)
            {
                if (frm.GetType() == typeof(T))
                {
                    ucFormViewMain.ActiveForm(frm);
                    instance = frm as T;
                    break;
                }
            }
            if (instance == null)
            {
                instance = Activator.CreateInstance(typeof(T)) as T;
                instance.Tag = this;
                _openedForms.Add(instance, cmd);
                this.ucFormViewMain.AddAForm(instance);
                instance.FormClosed += delegate (object sender, FormClosedEventArgs e)
                {
                    _openedForms.Remove(instance);
                };
            }
            return instance;
        }

        private void SaveOpenedForms()
        {
            string temp = string.Empty;
            foreach (var pair in _openedForms)
            {
                if (!string.IsNullOrEmpty(pair.Value))
                {
                    temp += pair.Value + ";";
                }
            }
            AppSettings.Current.SaveConfig("OpenedForms", temp);
        }
        #endregion

        #region 主菜单
        private void mnu_ChangPwd_Click(object sender, EventArgs e)
        {
            FrmChangePwd frm = new FrmChangePwd();
            frm.Operator = AppSettings.Current.Operator;
            frm.ShowDialog();
        }
        #endregion

        #region 事件处理程序
        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.Text += string.Format(" [{0}]", Assembly.GetExecutingAssembly().GetName().Version);
            AppSettings.Current.AppName = this.Text;
            StartPingInternet();
            DoLogIn();
            ShowOperatorRights();
        }

        private void btn_PhysicalItemSelect_Click(object sender, EventArgs e)
        {
            var frm = new Frm考试科目设置();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
        }

        private void btn_Standard_Click(object sender, EventArgs e)
        {
            ShowSingleForm<Frm评分标准>();
        }

        private void btn特殊评分标准_Click(object sender, EventArgs e)
        {
            var frm = new Frm特殊评分();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
        }

        private void mnu特殊情况设置_Click(object sender, EventArgs e)
        {
            var frm = new Frm学生特殊情况设置();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
        }

        private void btn考点管理_Click(object sender, EventArgs e)
        {
            ShowSingleForm<Frm训练大纲管理>();
        }

        private void btn账号管理_Click(object sender, EventArgs e)
        {
            ShowSingleForm<Frm账号管理>();
        }

        private void btn系统参数_Click(object sender, EventArgs e)
        {
            var frm = new FrmOption_后台();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.MinimizeBox = false;
            frm.ShowDialog();
        }

        private void btn小程序参数_Click(object sender, EventArgs e)
        {
            var frm = new Frm小程序参数();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.MinimizeBox = false;
            frm.ShowDialog();
        }

        private void lnk当前学校_Click(object sender, EventArgs e)
        {
            SetCurrentSchool();
        }

        private void mnu_Logout_Click(object sender, EventArgs e)
        {
            var log = new LogInInfo()
            {
                Client = AppSettings.Current.AppName,
                LocalIP = LJH.GeneralLibrary.Net.NetTool.GetLocalIP()?.ToString(),
                MAC = LJH.GeneralLibrary.Net.NetTool.GetLocalMAC(),
                PCName = LJH.GeneralLibrary.Net.NetTool.GetHostName(),
            };
            var ret = CRMAPIClient.LogOut(log);
            var lastProjectID = AppSettings.Current.PhysicalProject?.ID;
            AppSettings.Current.Operator = null;
            AppSettings.Current.PhysicalProject = null;
            lblOperator.Text = null;
            lblShool.Text = null;
            DoLogIn();
            if (AppSettings.Current.PhysicalProject?.ID != lastProjectID) //如果登录的用户与之前的计划不一样，关闭所有已打开的子窗体
            {
                foreach (var f in _openedForms.Keys.ToList())
                {
                    f.Close();
                    ucFormViewMain.RemoveForm(f);
                }
            }
            foreach (var f in _openedForms.Keys.ToList())
            {
                if (f is IFormMaster) (f as IFormMaster).ShowOperatorRights();
            }
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show("是否要退出软件?", "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    e.Cancel = true;
                    return;
                }
            }
            SaveOpenedForms();
            Application.Exit();
        }

        private void FrmMain_Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            var log = new LogInInfo()
            {
                Client = AppSettings.Current.AppName,
                LocalIP = LJH.GeneralLibrary.Net.NetTool.GetLocalIP()?.ToString(),
                MAC = LJH.GeneralLibrary.Net.NetTool.GetLocalMAC(),
                PCName = LJH.GeneralLibrary.Net.NetTool.GetHostName(),
            };
            var ret = CRMAPIClient.LogOut(log);
            AppSettings.Current.Operator = null;
        }
        #endregion
    }
}
