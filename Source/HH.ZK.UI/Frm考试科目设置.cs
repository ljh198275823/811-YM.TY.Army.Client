using System;
using System.Collections.Generic;
using System.Windows.Forms;
using HH.ZK.WebAPIClient;
using HH.ZK.Model;
using HH.ZK.CommonUI;
using LJH.GeneralLibrary;

namespace HH.ZK.UI
{
    public partial class Frm考试科目设置 : Form
    {
        public Frm考试科目设置()
        {
            InitializeComponent();
        }

        public Project Project { get; set; }

        #region 事件处理程序
        private void Frm考试科目设置_Load(object sender, EventArgs e)
        {
            var 考试科目 = SysParaSettingsClient.GetOrCreateSetting<PhysicalItemSettings>(AppSettings.Current.ConnStr, Project.ID);
            var items = 考试科目.Items != null ? 考试科目.Items : new List<PhysicalItem>();
            this.dataGridView1.Rows.Clear();
            foreach (var pi in items)
            {
                var row = this.dataGridView1.Rows.Add();
                ShowItemInGridViewRow(this.dataGridView1.Rows[row], pi);
            }
        }

        private void ShowItemInGridViewRow(DataGridViewRow row, PhysicalItem pi)
        {
            row.Tag = pi;
            row.Cells["colID"].Value = pi.ID;
            row.Cells["colName"].Value = pi.Name;
            row.Cells["colShortName"].Value = pi.ShortName;
            row.Cells["colUnit"].Value = pi.Unit;
            row.Cells["colPointCount"].Value = pi.PointCount;
            row.Cells["colMin"].Value = pi.Min != null ? pi.ConvertToStr(pi.Min.Value) : null;
            row.Cells["colMax"].Value = pi.Max != null ? pi.ConvertToStr(pi.Max.Value) : null;
            row.Cells["colTestCount"].Value = pi.TestCount;
            if (pi.PrecisionMode == 0) row.Cells["col舍入类型"].Value = "非零进一";
            else if (pi.PrecisionMode == 1) row.Cells["col舍入类型"].Value = "四舍五入";
            else if (pi.PrecisionMode == 2) row.Cells["col舍入类型"].Value = "截取";
            row.Cells["col必考"].Value = pi.IsMust;
            if (pi.Sex == 0) row.Cells["col性别"].Value = "男女不限";
            else if (pi.Sex == 1) row.Cells["col性别"].Value = "只限男生";
            else if (pi.Sex == 2) row.Cells["col性别"].Value = "只限女生";
            if (pi.SortMode == 0) row.Cells["colSortMode"].Value = "无";
            else if (pi.SortMode == 1) row.Cells["colSortMode"].Value = "越低越好";
            else if (pi.SortMode == 2) row.Cells["colSortMode"].Value = "越高越好";
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count == 1 && this.dataGridView1.SelectedRows[0].Index > 0)
            {
                var curRow = this.dataGridView1.SelectedRows[0].Index;
                var preObj = this.dataGridView1.Rows[curRow - 1].Tag as PhysicalItem;
                ShowItemInGridViewRow(this.dataGridView1.Rows[curRow - 1], this.dataGridView1.Rows[curRow].Tag as PhysicalItem);
                ShowItemInGridViewRow(this.dataGridView1.Rows[curRow], preObj);
                this.dataGridView1.Rows[curRow].Selected = false;
                this.dataGridView1.Rows[curRow - 1].Selected = true;
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count == 1 && this.dataGridView1.SelectedRows[0].Index < this.dataGridView1.Rows.Count - 1)
            {
                var curRow = this.dataGridView1.SelectedRows[0].Index;
                var preObj = this.dataGridView1.Rows[curRow + 1].Tag as PhysicalItem;
                ShowItemInGridViewRow(this.dataGridView1.Rows[curRow + 1], this.dataGridView1.Rows[curRow].Tag as PhysicalItem);
                ShowItemInGridViewRow(this.dataGridView1.Rows[curRow], preObj);
                this.dataGridView1.Rows[curRow].Selected = false;
                this.dataGridView1.Rows[curRow + 1].Selected = true;
            }
        }

        private void mnu增加考试科目_Click(object sender, EventArgs e)
        {
            var frm = new FrmPhysicalItemMaster();
            frm.ForSelect = true;
            var dig = frm.ShowDialog();
            if (dig == DialogResult.OK)
            {
                var pi = frm.SelectedItem as PhysicalItem;
                bool exists = false;
                foreach (DataGridViewRow row in this.dataGridView1.Rows)
                {
                    if ((row.Tag as PhysicalItem).ID == pi.ID)
                    {
                        exists = true;
                        break;
                    }
                }
                if (!exists)
                {
                    var frmp = new Frm考试科目Detail();
                    frmp.IsAdding = false;
                    frmp.PhysicalItem = pi;
                    frmp.StartPosition = FormStartPosition.CenterParent;
                    dig = frmp.ShowDialog();
                    if (dig == DialogResult.OK)
                    {
                        int row = dataGridView1.Rows.Add();
                        ShowItemInGridViewRow(dataGridView1.Rows[row], pi);
                    }
                }
            }
        }

        private void mnu增加自定义科目_Click(object sender, EventArgs e)
        {
            var frm = new Frm考试科目Detail();
            frm.IsAdding = true;
            frm.StartPosition = FormStartPosition.CenterParent;
            var dig = frm.ShowDialog();
            if (dig == DialogResult.OK)
            {
                bool exists = false;
                foreach (DataGridViewRow row in this.dataGridView1.Rows)
                {
                    if ((row.Tag as PhysicalItem).ID == frm.PhysicalItem.ID)
                    {
                        exists = true;
                        break;
                    }
                }
                if (!exists)
                {
                    int row = dataGridView1.Rows.Add();
                    ShowItemInGridViewRow(dataGridView1.Rows[row], frm.PhysicalItem);
                }
            }
        }

        private void mnu删除考试科目_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否删除所选的考试科目?", "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;
            List<DataGridViewRow> rows = new List<DataGridViewRow>();
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                rows.Add(row);
            }
            rows.ForEach(it => dataGridView1.Rows.Remove(it));
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0) return;
            var pi = dataGridView1.Rows[e.RowIndex].Tag as PhysicalItem;
            var frm = new Frm考试科目Detail();
            frm.PhysicalItem = pi;
            frm.StartPosition = FormStartPosition.CenterParent;
            var dig = frm.ShowDialog();
            if (dig == DialogResult.OK) ShowItemInGridViewRow(dataGridView1.Rows[e.RowIndex], pi);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            var items = new List<PhysicalItem>();
            foreach (DataGridViewRow row in this.dataGridView1.Rows)
            {
                items.Add(row.Tag as PhysicalItem);
            }
            var para = new PhysicalItemSettings() { Items = items };
            var ret = SysParaSettingsClient.SaveSetting<PhysicalItemSettings>(para, AppSettings.Current.ConnStr, Project.ID);
            if (ret.Result == LJH.GeneralLibrary.ResultCode.Successful)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show(ret.Message);
            }
        }
        #endregion
    }
}
