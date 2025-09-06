using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using HH.ZK.Model;
using HH.ZK.WebAPIClient;
using HH.ZK.CommonUI;

namespace HH.ZK.UI
{
    public partial class Frm考试科目选择_后台 : Form
    {
        public Frm考试科目选择_后台()
        {
            InitializeComponent();
        }

        public string SelectedPhysicalIDs { get; set; }

        public Sex? SexFlag { get; set; }

        public bool SingleSelect { get; set; }

        #region 私有方法
        private void InitPnlPhysicalItem(Panel pnl)
        {
            pnl.Controls.Clear();
            var 考试科目 = SysParaSettingsClient.GetOrCreateSetting<PhysicalItemSettings>(AppSettings.Current.ConnStr, AppSettings.Current.PhysicalProject.ID);
            var pis = 考试科目.Items != null ? 考试科目.Items : new List<PhysicalItem>();
            if (pis != null && pis.Count > 0)
            {
                foreach (PhysicalItem pi in pis)
                {
                    if (pi.IsMust) continue;
                    if (SexFlag.HasValue && pi.Sex != 0 && pi.Sex != (int)SexFlag) continue;
                    CheckBox chk = GetControl(pnl, pi.ID);
                    if (chk == null)
                    {
                        chk = new CheckBox();
                        pnl.Controls.Add(chk);
                    }
                    chk.Name = pnl.Name + "_Name_" + pi.ID.ToString();
                    chk.AutoSize = false;
                    chk.MinimumSize = new Size(120, chk.Height);
                    chk.Text = pi.Name;
                    chk.Tag = pi;
                    chk.CheckedChanged += new EventHandler(chk_CheckedChanged);
                }
            }
        }

        private void ShowSelectedItems(string items)
        {
            if (!string.IsNullOrEmpty(items))
            {
                var pis = items.Split(',');
                foreach (Control c in pnlPhysicalItem1.Controls)
                {
                    if (c.Tag != null && c.Tag is PhysicalItem && c is CheckBox)
                    {
                        PhysicalItem tag = c.Tag as PhysicalItem;
                        (c as CheckBox).Checked = pis.Contains(tag.ID.ToString());
                    }
                }
            }
        }

        private CheckBox GetControl(Panel pnl, int pi)
        {
            foreach (Control c in pnl.Controls)
            {
                if (c.Tag != null && c.Tag is PhysicalItem && c is CheckBox)
                {
                    PhysicalItem tag = c.Tag as PhysicalItem;
                    if (tag.ID == pi) return c as CheckBox;
                }
            }
            return null;
        }
        #endregion

        #region 事件处理程序
        private void FrmPhysicalItemSelection_Load(object sender, EventArgs e)
        {
            InitPnlPhysicalItem(this.pnlPhysicalItem1);
            ShowSelectedItems(SelectedPhysicalIDs);
        }

        private void chk_CheckedChanged(object sender, EventArgs e)
        {
            var chk = sender as CheckBox;
            chk.BackColor = chk.Checked ? Color.Red : Color.White;
            chk.ForeColor = chk.Checked ? Color.White : Color.Black;
            if (chk.Checked && SingleSelect)
            {
                foreach (Control c in this.pnlPhysicalItem1.Controls)
                {
                    if (object.ReferenceEquals(chk, c) == false && c is CheckBox)
                    {
                        (c as CheckBox).Checked = false;
                    }
                }
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            SelectedPhysicalIDs = string.Empty;
            foreach (Control ctrl in pnlPhysicalItem1.Controls)
            {
                CheckBox chk = ctrl as CheckBox;
                if (chk != null && chk.Checked)
                {
                    PhysicalItem pi = chk.Tag as PhysicalItem;
                    SelectedPhysicalIDs += pi.ID.ToString() + ",";
                }
            }
            if (!string.IsNullOrEmpty(SelectedPhysicalIDs)) SelectedPhysicalIDs = SelectedPhysicalIDs.TrimEnd(',');
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
