using System;
using System.Collections.Generic;
using System.Windows.Forms;
using HH.ZK.WebAPIClient;
using HH.ZK.Model;
using HH.ZK.CommonUI;
using LJH.GeneralLibrary;

namespace HH.ZK.UI
{
    public partial class Frm学生特殊情况设置 : Form
    {
        public Frm学生特殊情况设置()
        {
            InitializeComponent();
        }

        #region 事件处理程序
        private void Frm考试科目设置_Load(object sender, EventArgs e)
        {
            var para = SysParaSettingsClient.GetOrCreateSetting<StudentStateSettings>(AppSettings.Current.ConnStr, AppSettings.Current.PhysicalProject.ID);
            var items = para.Items != null ? para.Items : new List<StudentStatePara>();
            this.dataGridView1.Rows.Clear();
            foreach (var item in items)
            {
                var row = this.dataGridView1.Rows.Add();
                ShowItemInGridViewRow(this.dataGridView1.Rows[row], item);
            }
        }

        private void ShowItemInGridViewRow(DataGridViewRow row, StudentStatePara pi)
        {
            row.Tag = pi;
            row.Cells["colID"].Value = (int)pi.State;
            row.Cells["colName"].Value = pi.State.ToString();
            row.Cells["col固定总分"].Value = pi.Total.HasValue;
            row.Cells["col总分"].Value = pi.Total;
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count == 1 && this.dataGridView1.SelectedRows[0].Index > 0)
            {
                var curRow = this.dataGridView1.SelectedRows[0].Index;
                var preObj = this.dataGridView1.Rows[curRow - 1].Tag as StudentStatePara;
                ShowItemInGridViewRow(this.dataGridView1.Rows[curRow - 1], this.dataGridView1.Rows[curRow].Tag as StudentStatePara);
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
                var preObj = this.dataGridView1.Rows[curRow + 1].Tag as StudentStatePara;
                ShowItemInGridViewRow(this.dataGridView1.Rows[curRow + 1], this.dataGridView1.Rows[curRow].Tag as StudentStatePara);
                ShowItemInGridViewRow(this.dataGridView1.Rows[curRow], preObj);
                this.dataGridView1.Rows[curRow].Selected = false;
                this.dataGridView1.Rows[curRow + 1].Selected = true;
            }
        }

        private void mnu增加项_Click(object sender, EventArgs e)
        {
            var frm = new Frm学生特殊情况设置Detail();
            frm.StartPosition = FormStartPosition.CenterParent;
            var dig = frm.ShowDialog();
            if (dig == DialogResult.OK)
            {
                var pi = frm.Item as StudentStatePara;
                bool exists = false;
                foreach (DataGridViewRow row in this.dataGridView1.Rows)
                {
                    if ((row.Tag as StudentStatePara).State == pi.State)
                    {
                        ShowItemInGridViewRow(row, pi);
                        break;
                    }
                }
                if (!exists)
                {
                    int row = dataGridView1.Rows.Add();
                    ShowItemInGridViewRow(dataGridView1.Rows[row], pi);
                }
            }
        }

        private void mnu删除项_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否删除所选的项?", "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                List<DataGridViewRow> rows = new List<DataGridViewRow>();
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    rows.Add(row);
                }
                rows.ForEach(it => dataGridView1.Rows.Remove(it));
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0) return;
            var pi = dataGridView1.Rows[e.RowIndex].Tag as StudentStatePara;
            var frm = new Frm学生特殊情况设置Detail();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.Item = pi;
            var dig = frm.ShowDialog();
            if (dig == DialogResult.OK) ShowItemInGridViewRow(dataGridView1.Rows[e.RowIndex], pi);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            var items = new List<StudentStatePara>();
            foreach (DataGridViewRow row in this.dataGridView1.Rows)
            {
                items.Add(row.Tag as StudentStatePara);
            }
            var para = new StudentStateSettings() { Items = items };
            var ret = SysParaSettingsClient.SaveSetting<StudentStateSettings>(para, AppSettings.Current.ConnStr, AppSettings.Current.PhysicalProject.ID);
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
