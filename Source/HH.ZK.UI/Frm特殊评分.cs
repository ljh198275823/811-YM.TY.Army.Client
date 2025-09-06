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
using LJH.GeneralLibrary;

namespace HH.ZK.UI
{
    public partial class Frm特殊评分 : Form
    {
        public Frm特殊评分()
        {
            InitializeComponent();
        }

        #region 私有变量
        private object _BeginValue = 0;
        #endregion

        #region 私有方法

        #endregion

        private void FrmSpecialScore_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns["col免考"].Tag = SpecialScoreType.免考;
            dataGridView1.Columns["col伤病"].Tag = SpecialScoreType.伤病;
            dataGridView1.Columns["col残疾"].Tag = SpecialScoreType.残疾;
            dataGridView1.Columns["col犯规"].Tag = SpecialScoreType.犯规;
            dataGridView1.Columns["col未完成"].Tag = SpecialScoreType.未完成;
            dataGridView1.Columns["col弃考"].Tag = SpecialScoreType.弃考;

            var 考试科目 = SysParaSettingsClient.GetOrCreateSetting<PhysicalItemSettings>(AppSettings.Current.ConnStr, AppSettings.Current.PhysicalProject.ID);
            List<PhysicalItem> pis = 考试科目.Items;
            if (pis != null && pis.Count > 0)
            {
                var sps = SysParaSettingsClient.GetSetting<SpecialScoreSetting>(AppSettings.Current.ConnStr, AppSettings.Current.PhysicalProject.ID);
                foreach (PhysicalItem pi in pis)
                {
                    int row = dataGridView1.Rows.Add();
                    dataGridView1.Rows[row].Tag = pi;
                    dataGridView1.Rows[row].Cells["colPhysicalItem"].Value = pi.Name;
                    dataGridView1.Rows[row].Cells["col免考"].Value = sps?.GetValue(pi.ID, SpecialScoreType.免考);
                    dataGridView1.Rows[row].Cells["col伤病"].Value = sps?.GetValue(pi.ID, SpecialScoreType.伤病);
                    dataGridView1.Rows[row].Cells["col残疾"].Value = sps?.GetValue(pi.ID, SpecialScoreType.残疾);
                    dataGridView1.Rows[row].Cells["col犯规"].Value = sps?.GetValue(pi.ID, SpecialScoreType.犯规);
                    dataGridView1.Rows[row].Cells["col未完成"].Value = sps?.GetValue(pi.ID, SpecialScoreType.未完成);
                    dataGridView1.Rows[row].Cells["col弃考"].Value = sps?.GetValue(pi.ID, SpecialScoreType.弃考);
                }
            }
        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            _BeginValue = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string temp = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null ? dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() : null;
            decimal d = 0;
            if (!string.IsNullOrEmpty(temp) && !decimal.TryParse(temp, out d))
            {
                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = _BeginValue;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            var sps = new SpecialScoreSetting();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Tag != null)
                {
                    PhysicalItem pi = row.Tag as PhysicalItem;
                    foreach (DataGridViewColumn col in dataGridView1.Columns)
                    {
                        if (col.Tag != null)
                        {
                            SpecialScoreType sst = (SpecialScoreType)col.Tag;
                            string temp = row.Cells[col.Index].Value != null ? row.Cells[col.Index].Value.ToString() : null;
                            decimal d = 0;
                            if (!string.IsNullOrEmpty(temp) && decimal.TryParse(temp, out d))
                            {
                                sps.AddItem(pi.ID, sst, d);
                            }
                        }
                    }
                }
            }
            CommandResult ret = SysParaSettingsClient.SaveSetting<SpecialScoreSetting>(sps, AppSettings.Current.ConnStr, AppSettings.Current.PhysicalProject.ID);
            if (ret.Result != ResultCode.Successful)
            {
                MessageBox.Show(ret.Message);
            }
            else
            {
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
