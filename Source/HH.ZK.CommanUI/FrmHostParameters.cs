using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using HH.Zhongkao.Device.Wifi;

namespace HH.ZK.CommonUI
{
    public partial class FrmHostParameters : Form
    {
        public FrmHostParameters()
        {
            InitializeComponent();
        }

        private HostParameters p { get; set; }
        private Thread _ReadPara = null;

        public WifiHost Host { get; set; }

        private void ShowParameters(HostParameters p)
        {
            txt按键学号输入_学号最大长度.IntergerValue = p.按键学号输入_学号最大长度;
            txt按键学号输入_递增间隔.IntergerValue = p.按键学号输入_递增间隔;
            chk按键学号输入_人工确认.Checked = p.按键学号输入_人工确认 == 1;
            cmb输入设备_扫描枪或身份证.SelectedIndex = p.输入设备_扫描枪或身份证;
            cmb输入设备_IC卡物理号.SelectedIndex = p.输入设备_IC卡物理号;
            cmb测试结果_确认方式.SelectedIndex = p.测试结果_确认方式;
            chk测试结果_写入IC卡.Checked = p.测试结果_写入IC卡 != 0;
            chk测试结果_LED屏上显示.Checked = p.测试结果_LED屏上显示 != 0;
            cmb辅助设备_无线音箱.SelectedIndex = p.辅助设备_无线音箱;
            chk辅助设备_红外防枪跑器.Checked = p.辅助设备_红外防枪跑器 != 0;
            txt测试限制_测试次数.IntergerValue = p.测试限制_测试次数;
            txt测试限制_总时间.IntergerValue = p.测试限制_总时间;
            cmb测试限制_进行方式.SelectedIndex = p.测试限制_进行方式;
            txt引体向上_难度系数.IntergerValue = p.引体向上_难度系数;
            cmb仰卧起坐_躺平模式.SelectedIndex = p.仰卧起坐_躺平模式;
            cmb短跑系列_项目选择.SelectedIndex = p.短跑系列_项目选择;
            txt地毯式中长跑_跑道长度.IntergerValue = p.地毯式中长跑_跑道长度;
            txt地毯式中长跑_男生测试长度.IntergerValue = p.地毯式中长跑_男生测试长度;
            txt地毯式中长跑_女生测试长度.IntergerValue = p.地毯式中长跑_女生测试长度;
            chk地毯式中长跑_分组测试.Checked = p.地毯式中长跑_测试模式 != 0;
            txt标签式中长跑_圈数设定.IntergerValue = p.标签式中长跑_圈数设定;
            chk标签式中长跑_分组测试.Checked = p.标签式中长跑_测试模式 != 0;
            lblMsg.Text = "参数读取成功！";
            btnOk.Enabled = true;
        }

        private void FrmHostParameters_Load(object sender, EventArgs e)
        {
            btnOk.Enabled = false;
            Action action = delegate()
             {
                 try
                 {
                     p = Host.GetParameters();
                     if (p != null)
                     {
                         this.Invoke((Action)(() => ShowParameters(p)));
                     }
                     else
                     {
                         this.Invoke((Action)(() => { this.lblMsg.Text = "获取主机参数失败!"; this.lblMsg.Visible = true; }));
                     }
                     _ReadPara = null;
                 }
                 catch (Exception)
                 {
                 }
             };
            _ReadPara = new Thread(new ThreadStart(action));
            _ReadPara.IsBackground = true;
            _ReadPara.Start();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (p == null) p = new HostParameters();
            p.按键学号输入_学号最大长度 = (byte)txt按键学号输入_学号最大长度.IntergerValue;
            p.按键学号输入_递增间隔 = (byte)txt按键学号输入_递增间隔.IntergerValue;
            p.按键学号输入_人工确认 = (byte)(chk按键学号输入_人工确认.Checked ? 1 : 0);
            p.输入设备_扫描枪或身份证 = (byte)cmb输入设备_扫描枪或身份证.SelectedIndex;
            p.输入设备_IC卡物理号 = (byte)cmb输入设备_IC卡物理号.SelectedIndex;
            p.测试结果_确认方式 = (byte)cmb测试结果_确认方式.SelectedIndex;
            p.测试结果_写入IC卡 = (byte)(chk测试结果_写入IC卡.Checked ? 1 : 0);
            p.测试结果_LED屏上显示 = (byte)(chk测试结果_LED屏上显示.Checked ? 1 : 0);
            p.辅助设备_无线音箱 = (byte)cmb辅助设备_无线音箱.SelectedIndex;
            p.辅助设备_红外防枪跑器 = (byte)(chk辅助设备_红外防枪跑器.Checked ? 1 : 0);
            p.测试限制_测试次数 = (byte)txt测试限制_测试次数.IntergerValue;
            p.测试限制_总时间 = txt测试限制_总时间.IntergerValue;
            p.测试限制_进行方式 = (byte)cmb测试限制_进行方式.SelectedIndex;
            p.引体向上_难度系数 = (byte)txt引体向上_难度系数.IntergerValue;
            p.仰卧起坐_躺平模式 = (byte)cmb仰卧起坐_躺平模式.SelectedIndex;
            p.短跑系列_项目选择 = (byte)cmb短跑系列_项目选择.SelectedIndex;
            p.地毯式中长跑_跑道长度 = txt地毯式中长跑_跑道长度.IntergerValue;
            p.地毯式中长跑_男生测试长度 = txt地毯式中长跑_男生测试长度.IntergerValue;
            p.地毯式中长跑_女生测试长度 = txt地毯式中长跑_女生测试长度.IntergerValue;
            p.地毯式中长跑_测试模式 = (byte)(chk地毯式中长跑_分组测试.Checked ? 1 : 0);
            p.标签式中长跑_圈数设定 = (byte)txt标签式中长跑_圈数设定.IntergerValue;
            p.标签式中长跑_测试模式 = (byte)(chk标签式中长跑_分组测试.Checked ? 1 : 0);
            lblMsg.Text = "参数设置中。。。";
            var ret = Host.SetParameters(p, false);
            if (ret) this.Close();
            else lblMsg.Text = "参数设置失败！";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmHostParameters_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_ReadPara != null) _ReadPara.Abort();
        }
    }
}
