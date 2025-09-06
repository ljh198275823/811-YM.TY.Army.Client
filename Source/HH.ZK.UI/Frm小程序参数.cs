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
using HH.ZK.CommonUI;
using HH.ZK.WebAPIClient;

namespace HH.ZK.UI
{
    public partial class Frm小程序参数 : Form
    {
        public Frm小程序参数()
        {
            InitializeComponent();
        }

        PhysicalItemSettings 考试科目 = null;

        private void Frm小程序参数_Load(object sender, EventArgs e)
        {
            考试科目 = SysParaSettingsClient.GetOrCreateSetting<PhysicalItemSettings>(AppSettings.Current.ConnStr, AppSettings.Current.PhysicalProject.ID);
            if (考试科目 == null) return;
            if (考试科目 != null && 考试科目.Items != null)
            {
                var bk = (from it in 考试科目.Items
                          where it.IsMust == true
                          select it.ID.ToString()).ToList();
                if (bk != null && bk.Count > 0)
                {
                    txt考试科目0.Text = 考试科目.GetNames(string.Join(",", bk));
                    txt考试科目0.Tag = string.Join(",", bk);
                }
            }
            var para = SysParaSettingsClient.GetOrCreateSetting<MiniWXSettings>(AppSettings.Current.ConnStr, AppSettings.Current.PhysicalProject.ID);
            if (para != null)
            {
                chk启用报名.Checked = para.ReservableBeginDate.HasValue;
                if (chk启用报名.Checked)
                {
                    dt报名开始日期.Value = para.ReservableBeginDate.Value;
                    dt报名结束日期.Value = para.ReservableEndDate.Value;
                }
                if (para.PhysicalGroups != null && para.PhysicalGroups.Count > 0)
                {
                    var group = para.PhysicalGroups[0];
                    txtName1.Text = group.Name;
                    txt选择数量1.IntergerValue = group.ReserveCount;
                    if (!string.IsNullOrEmpty(group.Items))
                    {
                        txt考试科目1.Text = 考试科目?.GetNames(group.Items);
                        txt考试科目1.Tag = group.Items;
                    }
                }
                if (para.PhysicalGroups != null && para.PhysicalGroups.Count > 1)
                {
                    var group = para.PhysicalGroups[1];
                    txtName2.Text = group.Name;
                    txt选择数量2.IntergerValue = group.ReserveCount;
                    if (!string.IsNullOrEmpty(group.Items))
                    {
                        txt考试科目2.Text = 考试科目?.GetNames(group.Items);
                        txt考试科目2.Tag = group.Items;
                    }
                }
                if (para.PhysicalGroups != null && para.PhysicalGroups.Count > 2)
                {
                    var group = para.PhysicalGroups[2];
                    txtName3.Text = group.Name;
                    txt选择数量3.IntergerValue = group.ReserveCount;
                    if (!string.IsNullOrEmpty(group.Items))
                    {
                        txt考试科目3.Text = 考试科目?.GetNames(group.Items);
                        txt考试科目3.Tag = group.Items;
                    }
                }
                chk启用成绩查询.Checked = para.QueryTotalBeginDate.HasValue;
                if (chk启用成绩查询.Checked)
                {
                    dt成绩查询开始日期.Value = para.QueryTotalBeginDate.Value;
                    dt成绩查询结束日期.Value = para.QueryTotalEndDate.Value;
                }
            }
        }

        private void lnk考试科目1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var frm = new Frm考试科目选择_后台();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.SelectedPhysicalIDs = txt考试科目1.Tag != null ? txt考试科目1.Tag.ToString() : null;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                var sp = frm.SelectedPhysicalIDs;
                if (string.IsNullOrEmpty(sp))
                {
                    txt考试科目1.Text = string.Empty;
                    txt考试科目1.Tag = null;
                }
                else
                {
                    txt考试科目1.Text = 考试科目?.GetNames(frm.SelectedPhysicalIDs);
                    txt考试科目1.Tag = frm.SelectedPhysicalIDs;
                }
            }
        }

        private void lnk考试科目2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var frm = new Frm考试科目选择_后台();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.SelectedPhysicalIDs = txt考试科目2.Tag != null ? txt考试科目2.Tag.ToString() : null;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                var sp = frm.SelectedPhysicalIDs;
                if (string.IsNullOrEmpty(sp))
                {
                    txt考试科目2.Text = string.Empty;
                    txt考试科目2.Tag = null;
                }
                else
                {
                    txt考试科目2.Text = 考试科目?.GetNames(frm.SelectedPhysicalIDs);
                    txt考试科目2.Tag = frm.SelectedPhysicalIDs;
                }
            }
        }

        private void lnk考试科目3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var frm = new Frm考试科目选择_后台();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.SelectedPhysicalIDs = txt考试科目3.Tag != null ? txt考试科目3.Tag.ToString() : null;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                var sp = frm.SelectedPhysicalIDs;
                if (string.IsNullOrEmpty(sp))
                {
                    txt考试科目3.Text = string.Empty;
                    txt考试科目3.Tag = null;
                }
                else
                {
                    txt考试科目3.Text = 考试科目?.GetNames(frm.SelectedPhysicalIDs);
                    txt考试科目3.Tag = frm.SelectedPhysicalIDs;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool CheckInput()
        {
            if (chk启用报名.Checked && dt报名开始日期.Value.Date > dt报名结束日期.Value.Date)
            {
                MessageBox.Show("报名开始时间不能大于结束时间");
                return false;
            }
            if (txt考试科目1.Tag != null)
            {
                if (string.IsNullOrEmpty(txtName1.Text))
                {
                    MessageBox.Show("选考组一名称不能为空");
                    return false;
                }
                if (txt选择数量1.IntergerValue <= 0)
                {
                    MessageBox.Show("选择数量不正确");
                    return false;
                }
            }
            if (txt考试科目2.Tag != null)
            {
                if (string.IsNullOrEmpty(txtName2.Text))
                {
                    MessageBox.Show("选考组一名称不能为空");
                    return false;
                }
                if (txt选择数量2.IntergerValue <= 0)
                {
                    MessageBox.Show("选择数量不正确");
                    return false;
                }
            }
            if (txt考试科目3.Tag != null)
            {
                if (string.IsNullOrEmpty(txtName3.Text))
                {
                    MessageBox.Show("选考组一名称不能为空");
                    return false;
                }
                if (txt选择数量3.IntergerValue <= 0)
                {
                    MessageBox.Show("选择数量不正确");
                    return false;
                }
            }
            if (chk启用成绩查询.Checked && dt成绩查询开始日期.Value.Date > dt成绩查询结束日期.Value.Date)
            {
                MessageBox.Show("成绩查询开始日期不能大于结束日期");
                return false;
            }
            return true;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (CheckInput() == false) return;
            MiniWXSettings para = new MiniWXSettings();
            if (chk启用报名.Checked)
            {
                para.ReservableBeginDate = dt报名开始日期.Value.Date;
                para.ReservableEndDate = dt报名结束日期.Value.Date;
            }
            else
            {
                para.ReservableBeginDate = null;
                para.ReservableEndDate = null;
            }
            para.PhysicalGroups = new List<PhysicalGroup>();
            if (txt考试科目1.Tag != null)
            {
                var group = new PhysicalGroup() { Name = txtName1.Text, ReserveCount = txt选择数量1.IntergerValue, Items = txt考试科目1.Tag.ToString() };
                para.PhysicalGroups.Add(group);
            }
            if (txt考试科目2.Tag != null)
            {
                var group = new PhysicalGroup() { Name = txtName2.Text, ReserveCount = txt选择数量2.IntergerValue, Items = txt考试科目2.Tag.ToString() };
                para.PhysicalGroups.Add(group);
            }
            if (txt考试科目3.Tag != null)
            {
                var group = new PhysicalGroup() { Name = txtName3.Text, ReserveCount = txt选择数量3.IntergerValue, Items = txt考试科目3.Tag.ToString() };
                para.PhysicalGroups.Add(group);
            }
            if (chk启用成绩查询.Checked)
            {
                para.QueryTotalBeginDate = dt成绩查询开始日期.Value.Date;
                para.QueryTotalEndDate = dt成绩查询结束日期.Value.Date;
            }
            else
            {
                para.QueryTotalBeginDate = null;
                para.QueryTotalEndDate = null;
            }
            var ret = SysParaSettingsClient.SaveSetting<MiniWXSettings>(para, AppSettings.Current.ConnStr, AppSettings.Current.PhysicalProject.ID);
            if (ret.Result == LJH.GeneralLibrary.ResultCode.Successful)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show(ret.Message);
            }
        }
    }
}
