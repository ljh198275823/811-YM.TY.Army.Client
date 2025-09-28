using System;
using System.Drawing;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;
using System.Reflection;
using System.Linq;
using HH.Zhongkao.Device.Reader;
using HH.ZK.Model;
using HH.ZK.Model.SearchCondition;
using HH.ZK.Model.CRM;
using HH.ZK.CommonUI;
using HH.ZK.WebAPIClient;
using LJH.GeneralLibrary.SoftDog;
using LJH.GeneralLibrary.WinForm;
using LJH.GeneralLibrary.CardReader;
using AutoUpdaterDotNET;

namespace HH.ZK.UI
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        #region 私有变量
        private Dictionary<Form, string> _openedForms = new Dictionary<Form, string>();
        private Random _MyRandom = new Random();

        private ICCardReader _Reader = null;
        private BarcodeReader _BarcodeReader = null;
        private IDR210Reader _ID210 = null;
        private Thread _tmrID210 = null;
        private Student _CurStudent = null;
        private DateTime _ShowTime = DateTime.Now;
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

                this.lblOperator.Text = AppSettings.Current.Operator.Name;
                foreach (var f in _openedForms.Keys.ToList())
                {
                    f.Close();
                    ucFormViewMain.RemoveForm(f);
                }
                //初始化模板信息
                ShowOperatorRights();
            }
            else
            {
                Environment.Exit(0);
            }
        }

        public void ShowOperatorRights()
        {
            Main_报表.Enabled = AppSettings.Current.Operator != null;
            mnu切换用户.Enabled = AppSettings.Current.Operator != null;
            if (AppSettings.Current.Operator != null)
            {
                var cur = AppSettings.Current.Operator;
                //报表
                mnu原始成绩查询.Enabled = cur.PermitAny(Permission.StudentScore, PermissionActions.Read);
                mnu单项成绩统计报表.Enabled = cur.PermitAny(Permission.总分, PermissionActions.Read);
                mnu总成绩统计报表.Enabled = cur.PermitAny(Permission.总分, PermissionActions.Read);
                mnu_Log.Enabled = cur.PermitAny(Permission.StudentScore, PermissionActions.Read);
                //工具栏
            }
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

        private void OpenLastForms()
        {
            string temp = AppSettings.Current.GetConfigContent("OpenedForms");
            if (!string.IsNullOrEmpty(temp))
            {
                string[] ms = temp.Split(';');
                foreach (var str in ms)
                {
                    if (!string.IsNullOrEmpty(str))
                    {
                        var c = this.mainMenu.Items.Find(str, true);
                        if (c != null && c.Length == 1 && c[0].Enabled) c[0].PerformClick();
                    }
                }
            }
        } 
        #endregion

        #region 主菜单
        private void mnu_ChangPwd_Click(object sender, EventArgs e)
        {
            FrmChangePwd frm = new FrmChangePwd();
            frm.Operator = AppSettings.Current.Operator;
            frm.ShowDialog();
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
            if (PhysicalScoresSavingService.Current != null)
            {
                PhysicalScoresSavingService.Current.Stop();
                PhysicalScoresSavingService.Current = null;
            }
            lblOperator.Text = null;
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

        private void mnu_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnu人员部门管理_Click(object sender, EventArgs e)
        {
            ShowSingleForm<Frm人员部门管理>(sender);
        }

        private void mnu训练考核大纲管理_Click(object sender, EventArgs e)
        {
            var frm = new Frm训练大纲管理();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
        }

        private void mnu总成绩统计报表_Click(object sender, EventArgs e)
        {
            ShowSingleForm<FrmStatisticsTotal>();
        }

        private void mnu单项成绩统计报表_Click(object sender, EventArgs e)
        {
            ShowSingleForm<FrmStatistics>(null);
        }

        private void mnu重复成绩_Click(object sender, EventArgs e)
        {
            ShowSingleForm<Frm违规考试查询报表>();
        }

        private void mnu系统日志_Click(object sender, EventArgs e)
        {
            ShowSingleForm<FrmLogView>();
        }
        #endregion

        #region 工具栏菜单
        private void mnu_Statistics_Click(object sender, EventArgs e)
        {
            mnu单项成绩统计报表.PerformClick();
        }

        private void 总分统计toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            mnu总成绩统计报表.PerformClick();
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

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show("是否要退出平台?", "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    e.Cancel = true;
                    return;
                }
            }
            if (AppSettings.Current.Operator != null)
            {
                var log = new LogInInfo()
                {
                    Client = AppSettings.Current.AppName,
                    LocalIP = LJH.GeneralLibrary.Net.NetTool.GetLocalIP()?.ToString(),
                    MAC = LJH.GeneralLibrary.Net.NetTool.GetLocalMAC(),
                    PCName = LJH.GeneralLibrary.Net.NetTool.GetHostName(),
                };
                var ret = CRMAPIClient.LogOut(log);
            }
            SaveOpenedForms();
            AppSettings.Current.Operator = null;
            Application.Exit();
        }
        #endregion

        private void mnu学生原始成绩查询_Click(object sender, EventArgs e)
        {
            ShowSingleForm<Frm原始成绩查询报表>(null);
        }

        private void mnu软件更新日志_Click(object sender, EventArgs e)
        {
            ShowSingleForm<Frm软件更新日志>();
        }

        private void mnu学生成绩管理_Click(object sender, EventArgs e)
        {
            ShowSingleForm<Frm训练成绩管理>(sender);
        }

        private void mnu切换用户_Click(object sender, EventArgs e)
        {
            if (AppSettings.Current.PhysicalProject == null) return;
            var frm = new Frm切换账号();
            frm.StartPosition = FormStartPosition.CenterParent;
            var dig = frm.ShowDialog();
            if (dig == DialogResult.OK)
            {
                this.lblOperator.Text = AppSettings.Current.Operator.Name;
                ShowOperatorRights();
                foreach (var f in _openedForms.Keys)
                {
                    if (f is IFormMaster) (f as IFormMaster).ShowOperatorRights();
                }
            }
        }

        private void mnu人工修改成绩查询报表_Click(object sender, EventArgs e)
        {
            ShowSingleForm<Frm人工修改成绩查询报表>();
        }

        private void mnu导入成绩_Click(object sender, EventArgs e)
        {
            var frm = new FrmScoreImport_SingleCol();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
        }

        private void mmu训练成绩管理_Click(object sender, EventArgs e)
        {
            ShowSingleForm<Frm训练成绩管理>();
        }

        private void mnu账号管理_Click(object sender, EventArgs e)
        {
            ShowSingleForm<Frm账号管理>();
        }

        private void mnu训练考核计划管理_Click(object sender, EventArgs e)
        {
            ShowSingleForm<Frm训练计划管理>();
        }
    }
}
