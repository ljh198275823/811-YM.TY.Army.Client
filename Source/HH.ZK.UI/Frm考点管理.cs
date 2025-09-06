using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HH.ZK.Model;
using HH.ZK.Model.SearchCondition;
using HH.ZK.CommonUI;
using HH.ZK.WebAPIClient;
using LJH.GeneralLibrary;
using LJH.GeneralLibrary.WinForm;

namespace HH.ZK.UI
{
    public partial class Frm考点管理 : FrmMasterBase<string, PhysicalProject>
    {
        public Frm考点管理()
        {
            InitializeComponent();
        }

        #region 重写基类方法
        protected override FrmDetailBase<string, PhysicalProject> GetDetailForm()
        {
            var frm = new Frm考点Detail();
            return frm;
        }

        protected override QueryResultList<PhysicalProject> GetDataSource()
        {
            return new APIClient(AppSettings.Current.ConnStr).GetList<string, PhysicalProject>(SearchCondition, null);
        }

        protected override List<PhysicalProject> FilterData(List<PhysicalProject> items)
        {
            items = FullTextSearch(items, txtKeyword.Text);
            return (from item in items
                    orderby item.ID ascending
                    select item).ToList();
        }

        protected override object GetCellValue(PhysicalProject item, string colName)
        {
            if (colName == "colID") return item.ID;
            if (colName == "colName") return item.Name;
            if (colName == "col开始日期") return item.StartDate.ToString("yyyy年MM月dd日");
            if (colName == "col结束日期") return item.EndDate.ToString("yyyy年MM月dd日");
            if (colName == "colState") return item.State.ToString();
            if (colName == "col创建时间") return item.CreateDate.ToString("yyyy-MM-dd HH:mm:ss");
            return base.GetCellValue(item, colName);
        }

        protected override void PerformDeleteData()
        {
            try
            {
                if (GridView == null) return;
                if (this.GridView.SelectedRows.Count == 1)
                {
                    var item = GetRowTag(this.GridView.SelectedRows[0]);
                    var frm = new Frm考点名称确认();
                    frm.StartPosition = FormStartPosition.CenterParent;
                    frm.ProjectName = (item as PhysicalProject).Name;
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        CommandResult ret = new APIClient(AppSettings.Current.ConnStr).Delete<string, PhysicalProject>(item, null);
                        if (ret.Result == ResultCode.Successful)
                        {
                            _ShowingItems.Remove(item);
                            _Items.Remove(item);
                            GridView.RowCount = _ShowingItems.Count;
                            GridView.Invalidate();
                            FreshStatusBar();
                        }
                        else
                        {
                            MessageBox.Show(ret.Message);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("一次只能选择一项进行删除", "Warning");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        #endregion

        #region 事件处理程序
        private void txtKeyword_TextChanged(object sender, EventArgs e)
        {
            FreshView();
        }

        private void mnu删除考点学生成绩_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                var frm = new Frm删除学生成绩();
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.Project = GetRowTag(dataGridView1.SelectedRows[0]);
                frm.ShowDialog();
            }
        }
        #endregion
    }
}
