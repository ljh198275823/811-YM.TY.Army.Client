using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Data;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using HH.ZK.Model;
using HH.ZK.Model.SearchCondition;
using HH.ZK.CommonUI;
using HH.ZK.WebAPIClient;
using HH.ZK.UI.Controls;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace HH.ZK.UI
{
    public partial class Frm学生准考证导出 : Form
    {
        public Frm学生准考证导出()
        {
            InitializeComponent();
        }

        #region 私有变量
        private List<StudentGroupSummary> _Groups = new List<StudentGroupSummary>();
        #endregion

        #region 私有方法
        private void InitStudentGroups()
        {
            _Groups.Clear();
            var items = new APIClient(AppSettings.Current.ConnStr).GetList<Guid, StudentGroupSummary>(null, AppSettings.Current.PhysicalProject.ID).QueryObjects;
            if (items != null && items.Count > 0) _Groups.AddRange(items);
        }

        private List<StudentGroupSummary> FilterGroup()
        {
            if (_Groups == null || _Groups.Count == 0) return null;
            var ret = _Groups.ToList();
            var sp = cmbPhysicalItem.SelectedPhysicalItem;
            if (sp > 0)
            {
                if (ret != null && ret.Count > 0) ret = ret.Where(it => it.包函考试科目(sp.ToString())).ToList();
            }
            if (!string.IsNullOrEmpty(txt考试时间.Text))
            {
                if (ret != null && ret.Count > 0) ret = ret.Where(it => !string.IsNullOrEmpty(it.PlanDate) && it.PlanDate.Contains(txt考试时间.Text)).ToList();
            }
            if (rdMale.Checked)
            {
                if (ret != null && ret.Count > 0) ret = ret.Where(it => it.Sex == Sex.Male).ToList();
            }
            if (rdFemale.Checked)
            {
                if (ret != null && ret.Count > 0) ret = ret.Where(it => it.Sex == Sex.Female).ToList();
            }
            if (!string.IsNullOrEmpty(cmbFacility.Text))
            {
                if (ret != null && ret.Count > 0) ret = ret.Where(it => it.FacilityID == cmbFacility.SelectedFacilityID).ToList();
            }
            if (ret != null && ret.Count > 0)
            {
                return (from it in ret
                        orderby it.PlanDate ascending, it.FacilityName ascending, it.Sex ascending, it.Number ascending
                        select it).ToList();
            }
            return null;
        }

        private void InitPlanDate(List<StudentGroupSummary> gps)
        {
            var txt = txt考试时间.Text;
            txt考试时间.Items.Clear();
            if (gps != null && gps.Count > 0)
            {
                txt考试时间.Items.Add(string.Empty);
                var items = (from it in gps
                             where !string.IsNullOrEmpty(it.PlanDate)
                             orderby it.PlanDate ascending
                             select it.PlanDate).Distinct().ToList();
                foreach (var it in items)
                {
                    txt考试时间.Items.Add(it);
                }
            }
            txt考试时间.Text = txt;
        }

        private void ShowGroupsOnGrid(List<StudentGroupSummary> gps)
        {
            this.dataGridview1.Rows.Clear();
            if (gps != null && gps.Count > 0)
            {
                foreach (var gp in gps)
                {
                    int row = dataGridview1.Rows.Add();
                    dataGridview1.Rows[row].Selected = false;
                    ShowGroupOnRow(dataGridview1.Rows[row], gp);
                }
            }
            lblGroupCount.Text = string.Format("共 {0} 项", dataGridview1.Rows.Count);
        }

        private void ShowGroupOnRow(DataGridViewRow row, StudentGroupSummary sg)
        {
            row.Tag = sg;
            row.Cells["col考试时间"].Value = sg.PlanDate;
            row.Cells["colPhysicalItem"].Value = AppSettings.Current.PhysicalProject.PhysicalItems?.GetNames(sg.PhysicalItems);
            row.Cells["colFacility"].Value = sg.FacilityName;
            row.Cells["col性别"].Value = sg.Sex == null ? null : (sg.Sex == Sex.Male ? "男子" : "女子");
            row.Cells["colNumber"].Value = sg.Number;
            row.Cells["colCount"].Value = sg.ItemsCount;
        }

        private void PerformRefresh()
        {
            InitStudentGroups();
            var ret = FilterGroup();
            ShowGroupsOnGrid(ret);
            InitPlanDate(ret);
        }
        #endregion

        #region 事件处理程序
        private void FrmMain_Load(object sender, EventArgs e)
        {
            cmbPhysicalItem.Init(AppSettings.Current.PhysicalProject);
            cmbFacility.Init(AppSettings.Current.PhysicalProject.ID);
            PerformRefresh();
        }

        private void mnuFresh_Click(object sender, EventArgs e)
        {
            PerformRefresh();
        }

        private void FreshData_Clicked(object sender, EventArgs e)
        {
            var ret = FilterGroup();
            ShowGroupsOnGrid(ret);
        }

        private List<StudentGroupSummary> GetSelectedItems()
        {
            List<StudentGroupSummary> items = new List<StudentGroupSummary>();
            foreach (DataGridViewRow r in dataGridview1.Rows)
            {
                if (!r.Selected) continue;
                items.Add(r.Tag as StudentGroupSummary);
            }
            return items;
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (DataGridViewRow row in dataGridview1.Rows)
            {
                row.Selected = true;
                count++;
            }
            lbl选择数量.Text = count.ToString();
        }

        private void btnNone_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridview1.Rows)
            {
                row.Selected = false;
            }
            lbl选择数量.Text = "0";
        }

        private void dataGridview1_SelectionChanged(object sender, EventArgs e)
        {
            lbl选择数量.Text = dataGridview1.SelectedRows.Count.ToString();
        }

        private void btn导出所选分组准考证_Click(object sender, EventArgs e)
        {
            if (dataGridview1.SelectedRows.Count == 0) return;
            List<StudentGroupSummary> items = new List<StudentGroupSummary>();
            foreach (DataGridViewRow r in dataGridview1.Rows)
            {
                if (!r.Selected) continue;
                items.Add(r.Tag as StudentGroupSummary);
            }
            var frm = new Frm按组导出准考证();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.PrintingGroups = items;
            frm.ShowDialog();
        }
        #endregion
    }
}
