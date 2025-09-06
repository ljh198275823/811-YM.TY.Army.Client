using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HH.ZK.WebAPIClient;
using Newtonsoft.Json;
using HH.ZK.Model;
using LJH.GeneralLibrary;

namespace HH.ZK.CommonUI
{
    public partial class Frm账号验证 : Form
    {
        public Frm账号验证()
        {
            InitializeComponent();
        }

        private int Ticks = 0;

        public string Mobile { get; set; }

        private bool CheckInput()
        {
            if (string.IsNullOrEmpty(txtMobile.Text))
            {
                MessageBox.Show("手机号不能为空");
                return false;
            }
            if (txtMobile.Text.Length != 11)
            {
                MessageBox.Show("手机号位数不正确");
                return false ;
            }
            if (string.IsNullOrEmpty(txt验证码.Text))
            {
                MessageBox.Show("验证码不能为空");
                return false;
            }
            return true;
        }

        private void Frm账号验证_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Mobile) && Mobile.Length == 11) txtMobile.Text = $"{Mobile.Substring(0, 3)}****{Mobile.Substring(7)}";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!CheckInput()) return;
            var ret = CRMAPIClient.VerifyCode(Mobile, txt验证码.Text.Trim());
            if (ret.Result == LJH.GeneralLibrary.ResultCode.Successful)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show(ret.Message);
            }
        }

        private void btn获取验证码_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMobile.Text))
            {
                MessageBox.Show("手机号不能为空");
                return;
            }
            if (txtMobile.Text.Length != 11)
            {
                MessageBox.Show("手机号位数不正确");
                return;
            }
            var ret = CRMAPIClient.SendMobileVerifyCode(Mobile);
            if (ret.Result == ResultCode.Successful)
            {
                btn获取验证码.Enabled = false;
                btn获取验证码.ForeColor = Color.Red;
                timer1.Interval = 1000;
                timer1.Enabled = true;
                Ticks = 60;
                btn获取验证码.Text = string.Format("({0})秒后重新获取", Ticks);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Ticks > 1)
            {
                Ticks--;
                btn获取验证码.Text = string.Format("({0})秒后重新获取", Ticks);
            }
            else
            {
                timer1.Enabled = false;
                btn获取验证码.Enabled = true;
                btn获取验证码.ForeColor = Color.Black;
                btn获取验证码.Text = "获取验证码";
            }
        }

        private void Frm会员登录_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Enabled = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close ();
        }

        
    }
}
