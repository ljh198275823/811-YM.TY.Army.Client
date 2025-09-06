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
using HH.ZK.Model.SearchCondition;
using HH.ZK.CommonUI;
using HH.ZK.WebAPIClient;
using LJH.GeneralLibrary;

namespace HH.ZK.UI
{
    public partial class FrmOperatorParaDetail : LJH.GeneralLibrary.WinForm.FrmDetailBase<string, UserInSchool>
    {
        public FrmOperatorParaDetail()
        {
            InitializeComponent();
        }

        #region 私有方法
        private List<PhysicalProject> _Projects = null;

        private string GetProjectNames(string pids)
        {
            if (string.IsNullOrEmpty(pids)) return null;
            if (_Projects == null || _Projects.Count == 0) return null;
            string ret = string.Empty;
            var strTemps = pids.Split(',');
            foreach (var str in strTemps)
            {
                if (!string.IsNullOrEmpty(str.Trim()))
                {
                    var p = _Projects.SingleOrDefault(it => it.ID == str.Trim());
                    if (p != null) ret += p.Name + ",";
                }
            }
            if (!string.IsNullOrEmpty(ret)) return ret.TrimEnd(',');
            return null;
        }

        private string GetFacilityNames(string fids, string projectID)
        {
            if (string.IsNullOrEmpty(fids)) return null;

            var fs = new APIClient(AppSettings.Current.ConnStr).GetList<string, Facility>(null, projectID).QueryObjects;
            if (fs == null || fs.Count == 0) return null;
            string ret = string.Empty;
            var strTemps = fids.Split(',');
            foreach (var str in strTemps)
            {
                if (!string.IsNullOrEmpty(str.Trim()))
                {
                    var p = fs.SingleOrDefault(it => it.ID == str.Trim());
                    if (p != null) ret += p.Name + ",";
                }
            }
            if (!string.IsNullOrEmpty(ret)) return ret.TrimEnd(',');
            return null;
        }
        #endregion

        #region 重写基类方法
        protected override void InitControls()
        {
            base.InitControls();
            dtExpireDate.Value = new DateTime(DateTime.Now.Year, 12, 31);
            this.txtRole.Items.Clear();
            this.txtRole.Items.AddRange(new string[] {
                string.Empty,
                nameof(Roles.资料录入员),
                nameof(Roles.照片采集员),
                nameof(Roles.成绩采集员),
                nameof(Roles.成绩复议员),
                nameof(Roles.报表查看员),
                nameof(Roles.系统管理员)
            });
            _Projects = new APIClient(AppSettings.Current.ConnStr).GetList<string, PhysicalProject>(null, null).QueryObjects;
        }

        protected override void ItemShowing(UserInSchool info)
        {
            txtOperator.Text = info.User.Mobile;
            txtOperator.Enabled = false;
            txtName.Text = info.User.Name;
            txtName.Enabled = false;
            dtExpireDate.Value = info.ExpireDate;
            chk使用加密狗验证.Checked = info.Ukey == true;
            txtRole.Text = info.Role;
            txt考点.Text = GetProjectNames(info.Projects);
            txt考点.Tag = info.Projects;
            if (info.SelectionType == 1)
            {
                txtFacilities.Text = GetFacilityNames(info.SelectionItems, info.Projects);
                txtFacilities.Tag = info.SelectionItems;
            }
        }

        protected override bool CheckInput()
        {
            if (txtOperator.Text.Trim().Length == 0)
            {
                MessageBox.Show("手机号不能为空!");
                return false;
            }
            if (txtName.Text.Trim().Length == 0)
            {
                MessageBox.Show("操作员姓名不能为空!");
                return false;
            }
            if (dtExpireDate.Value > AppSettings.Current.Operator.ExpireDate)
            {
                MessageBox.Show("账号的有效期不能超过管理员的有效期");
                return false;
            }
            return true;
        }

        protected override UserInSchool GetItemFromInput()
        {
            var info = UpdatingItem as UserInSchool;
            if (info == null)
            {
                if (txtOperator.Tag == null)
                {
                    var opt = new User()
                    {
                        ID = Guid.NewGuid().ToString(),
                        Mobile = txtOperator.Text.Trim(),
                        Name = txtName.Text.Trim(),
                        Password = "123",
                        States = OperatorState.未验证,
                    };
                    var ret1 = CRMAPIClient.Add<string, User>(opt);
                    if (ret1.Result == ResultCode.Successful && ret1.Value != null)
                    {
                        txtOperator.Tag = opt;
                    }
                    else
                    {
                        MessageBox.Show("保存操作员失败");
                        return null;
                    }
                }
                info = new UserInSchool();
                info.User = txtOperator.Tag as User;
                info.UserID = (txtOperator.Tag as User).ID;
            }
            info.ExpireDate = dtExpireDate.Value;
            info.Ukey = chk使用加密狗验证.Checked;
            if (txtRole.Text == nameof(Roles.系统管理员))
            {
                info.Projects = null;
                info.SelectionType = null;
                info.SelectionItems = null;
            }
            else
            {
                info.Projects = txt考点.Tag?.ToString();
                if (!string.IsNullOrEmpty(txtFacilities.Tag?.ToString()))
                {
                    info.SelectionType = 1;
                    info.SelectionItems = txtFacilities.Tag?.ToString();
                }
                else
                {
                    info.SelectionType = null;
                    info.SelectionItems = null;
                }
            }
            info.Role = txtRole.Text;
            return info;
        }

        protected override CommandResult<UserInSchool> AddItem(UserInSchool addingItem)
        {
            return new APIClient(AppSettings.Current.ConnStr).Add<string, UserInSchool>(addingItem, null);
        }

        protected override CommandResult<UserInSchool> UpdateItem(UserInSchool updatingItem)
        {
            return new APIClient(AppSettings.Current.ConnStr).Add<string, UserInSchool>(updatingItem, null);
        }
        #endregion

        #region 事件处理程序
        private void txtMobile_Leave(object sender, EventArgs e)
        {
            var con = new UserSearchCondition() { NameOrMobile = txtOperator.Text };
            var opts = CRMAPIClient.GetList<string, User>(con).QueryObjects;
            if (opts != null && opts.Count == 1)
            {
                var opt = opts[0];
                if (opt.ID == AppSettings.Current.Operator.ID)
                {
                    MessageBox.Show("不能修改当前操作员");
                    txtOperator.Text = string.Empty;
                    txtOperator.Focus();
                    return;
                }
                txtOperator.Text = opt.Mobile;
                txtOperator.Tag = opt;
                txtName.Text = opt.Name;
                txtName.Enabled = false;
            }
            else
            {
                txtName.Enabled = true;
            }
        }

        private void txtRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            lnk考点.Enabled = true;
            lnkFacilities.Enabled = true;
            if (txtRole.Text == nameof(Roles.系统管理员))
            {
                lnk考点.Enabled = false;
                lnkFacilities.Enabled = false;
            }
        }

        private void lnk考点_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var frm = new Frm多考点选择();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.SelectedProjectIDs = txt考点.Tag?.ToString();
            var dig = frm.ShowDialog();
            if (dig == DialogResult.OK)
            {
                txt考点.Text = GetProjectNames(frm.SelectedProjectIDs);
                txt考点.Tag = frm.SelectedProjectIDs;
            }
        }

        private void lnkFacilities_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var projectID = txt考点.Tag?.ToString();
            if (string.IsNullOrEmpty(projectID)) return;
            var frm = new Frm多学校选择();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ProjectID = projectID;
            frm.SelectedFacilityIDs = txtFacilities.Tag?.ToString();
            var dig = frm.ShowDialog();
            if (dig == DialogResult.OK)
            {
                txtFacilities.Text = GetFacilityNames(frm.SelectedFacilityIDs, projectID);
                txtFacilities.Tag = frm.SelectedFacilityIDs;
            }
        }
        #endregion
    }
}
