using System;
using System.Collections.Generic;
using System.Windows.Forms;
using HH.ZK.WebAPIClient;
using HH.ZK.Model;
using HH.ZK.CommonUI;
using LJH.GeneralLibrary;

namespace HH.ZK.UI
{
    public partial class Frm考试科目设置查看 : Form
    {
        public Frm考试科目设置查看()
        {
            InitializeComponent();
        }

        #region 事件处理程序
        private void Frm考试科目设置_Load(object sender, EventArgs e)
        {
            if (AppSettings.Current.PhysicalProject != null)
            {
                var 考试科目 = SysParaSettingsClient.GetOrCreateSetting<PhysicalItemSettings>(AppSettings.Current.ConnStr, AppSettings.Current.PhysicalProject.ID);
                var items = 考试科目.Items != null ? 考试科目.Items : new List<PhysicalItem>();
                this.dataGridView1.Rows.Clear();
                foreach (var pi in items)
                {
                    var row = this.dataGridView1.Rows.Add();
                    ShowItemInGridViewRow(this.dataGridView1.Rows[row], pi);
                }
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
        #endregion
    }
}
