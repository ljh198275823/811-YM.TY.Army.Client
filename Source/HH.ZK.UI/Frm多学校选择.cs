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
    public partial class Frm多学校选择 : Form
    {
        public Frm多学校选择()
        {
            InitializeComponent();
        }

        public string ProjectID { get; set; }

        public string SelectedFacilityIDs { get; set; }

        public bool SingleSelect { get; set; }

        #region 私有方法
        private void InitFacilities()
        {
            this.pnlProjects.Controls.Clear();
            var fs = new APIClient(AppSettings.Current.ConnStr).GetList<string, Facility>(null, ProjectID).QueryObjects;
            if (fs != null && fs.Count > 0)
            {
                foreach (var pi in fs)
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
                    if (c.Tag != null && c.Tag is Facility && c is CheckBox)
                    {
                        var tag = c.Tag as Facility;
                        (c as CheckBox).Checked = pis.Contains(tag.ID.ToString());
                    }
                }
            }
        }

        private CheckBox GetControl(Panel pnl, string pid)
        {
            foreach (Control c in pnl.Controls)
            {
                if (c.Tag != null && c.Tag is Facility && c is CheckBox)
                {
                    var tag = c.Tag as Facility;
                    if (tag.ID == pid) return c as CheckBox;
                }
            }
            return null;
        }
        #endregion

        #region 事件处理程序
        private void FrmPhysicalItemSelection_Load(object sender, EventArgs e)
        {
            InitFacilities();
            ShowSelectedItems(SelectedFacilityIDs);
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
            SelectedFacilityIDs = string.Empty;
            foreach (Control ctrl in pnlProjects.Controls)
            {
                CheckBox chk = ctrl as CheckBox;
                if (chk != null && chk.Checked)
                {
                    var pi = chk.Tag as Facility;
                    SelectedFacilityIDs += pi.ID.ToString() + ",";
                }
            }
            if (!string.IsNullOrEmpty(SelectedFacilityIDs)) SelectedFacilityIDs = SelectedFacilityIDs.TrimEnd(',');
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
