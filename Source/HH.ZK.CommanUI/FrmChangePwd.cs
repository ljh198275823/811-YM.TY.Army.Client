using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using HH.ZK.Model;
using HH.ZK.Model.CRM;
using HH.ZK.WebAPIClient;
using LJH.GeneralLibrary;

namespace HH.ZK.CommonUI
{
    public partial class FrmChangePwd : Form
    {
        public FrmChangePwd()
        {
            InitializeComponent();
        }

        public  User Operator{get;set;}

        private void FrmChangePwd_Load(object sender, EventArgs e)
        {
            lblMsg.Text = "密码最少为8位，最多20位。至少包括数字和字母";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                var patch = new UpdateItem<string>() { ID = Operator.ID, Key = "Password", Value = txtNewPwd.Text };
                CommandResult result = CRMAPIClient.Patch<string, User>(Operator.ID, new List<UpdateItem<string>>() { patch });
                if (result.Result == ResultCode.Successful)
                {
                    if (Operator.ID == AppSettings.Current.Operator.ID) WebAPIClient.CRMAPIClient._Password = txtNewPwd.Text; //如果是修改当前用户密码，则要更新CLIENT里面保存的密码
                    this.Close();
                }
                else
                {
                    MessageBox.Show(result.Message);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool CheckInput()
        {
            if (string.IsNullOrEmpty(txtNewPwd.Text))
            {
                MessageBox.Show("新密码不能为空!");
                txtNewPwd.SelectAll();
                return false;
            }
            if (txtNewPwd.Text != txtConfirmPwd.Text)
            {
                MessageBox.Show("新密码与确认密码不一致!");
                txtConfirmPwd.SelectAll();
                return false;
            }
            string pattern = @"(?=.*[0-9])(?=.*[a-zA-Z]).{8,20}";
            if (Regex.IsMatch(txtNewPwd.Text, pattern) == false)
            {
                MessageBox.Show("密码设置得太简单,至少要为6位");
                return false;
            }
            return true;
        }
    }
}
