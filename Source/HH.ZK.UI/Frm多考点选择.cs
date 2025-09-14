using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using HH.ZK.Model;
using HH.ZK.Model.SearchCondition;
using HH.ZK.WebAPIClient;
using HH.ZK.CommonUI;

namespace HH.ZK.UI
{
    public partial class Frm多考点选择 : Form
    {
        public Frm多考点选择()
        {
            InitializeComponent();
        }

        public string SelectedProjectIDs { get; set; }

        public bool SingleSelect { get; set; }

        #region 私有方法
        private void InitProjects()
        {
            this.pnlProjects.Controls.Clear();
            var projects = new APIClient(AppSettings.Current.ConnStr).GetList<string, Project>(null, null).QueryObjects;
            if (projects != null && projects.Count > 0)
            {
                //projects = (from it in projects orderby it.Name ascending select it).ToList();
                foreach (var pi in projects)
                {
                    CheckBox chk = GetControl(this.pnlProjects, pi.ID);
                    if (chk == null)
                    {
                        chk = new CheckBox();
                        this.pnlProjects.Controls.Add(chk);
                    }
                    chk.Name = "chk" + pi.ID.ToString();
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
                foreach (Control c in pnlProjects.Controls)
                {
                    if (c.Tag != null && c.Tag is Project && c is CheckBox)
                    {
                        var tag = c.Tag as Project;
                        (c as CheckBox).Checked = pis.Contains(tag.ID.ToString());
                    }
                }
            }
        }

        private CheckBox GetControl(Panel pnl, string pid)
        {
            foreach (Control c in pnl.Controls)
            {
                if (c.Tag != null && c.Tag is Project && c is CheckBox)
                {
                    var tag = c.Tag as Project;
                    if (tag.ID == pid) return c as CheckBox;
                }
            }
            return null;
        }
        #endregion

        #region 事件处理程序
        private void FrmPhysicalItemSelection_Load(object sender, EventArgs e)
        {
            InitProjects();
            ShowSelectedItems(SelectedProjectIDs);
        }

        private void chk_CheckedChanged(object sender, EventArgs e)
        {
            var chk = sender as CheckBox;
            chk.BackColor = chk.Checked ? Color.Red : Color.White;
            chk.ForeColor = chk.Checked ? Color.White : Color.Black;
            if (chk.Checked && SingleSelect)
            {
                foreach (Control c in this.pnlProjects.Controls)
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
            SelectedProjectIDs = string.Empty;
            foreach (Control ctrl in pnlProjects.Controls)
            {
                CheckBox chk = ctrl as CheckBox;
                if (chk != null && chk.Checked)
                {
                    var pi = chk.Tag as Project;
                    SelectedProjectIDs += pi.ID.ToString() + ",";
                }
            }
            if (!string.IsNullOrEmpty(SelectedProjectIDs)) SelectedProjectIDs = SelectedProjectIDs.TrimEnd(',');
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
