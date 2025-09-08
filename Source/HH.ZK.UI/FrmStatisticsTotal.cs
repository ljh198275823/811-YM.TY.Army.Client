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
using HH.ZK.Model.SearchCondition;
using HH.ZK.WebAPIClient;
using HH.ZK.CommonUI;
using LJH.GeneralLibrary;
using LJH.GeneralLibrary.WinForm;

namespace HH.ZK.UI
{
    public partial class FrmStatisticsTotal : FrmReportBaseWithPaging<Guid,TotalStatistic>
    {
        public FrmStatisticsTotal()
        {
            InitializeComponent();
        }

        #region 重写基类方法
        protected override void Init()
        {
            base.Init();
            ucStatiticsSearch1.Init();
        }

        public override void ShowOperatorRights()
        {
            base.ShowOperatorRights();
            btnSaveAs.Enabled = AppSettings.Current.Operator.PermitAll(Permission.总分, PermissionActions.Read);
            btnSearch.Enabled = AppSettings.Current.Operator.PermitAll(Permission.总分, PermissionActions.Read);
        }

        protected override QueryResultList<TotalStatistic> GetDataSource(int pageSize, int pageIndex)
        {
            var con = ucStatiticsSearch1.GetSearchCondition();
            con.SortMode = LJH.GeneralLibrary.SortMode.Asc;
            con.PageIndex = pageIndex;
            con.PageSize = pageSize;
            var ret = new APIClient(AppSettings.Current.ConnStr).GetList<Guid, TotalStatistic>(con, AppSettings.Current.PhysicalProject.ID);
            dataGridView1.Columns["colDivision"].Visible = con.ByDivision;
            dataGridView1.Columns["colFacility"].Visible = con.ByFacility;
            dataGridView1.Columns["colClassName"].Visible = con.ByClass;
            dataGridView1.Columns["colSex"].Visible = con.BySex;
            return ret;
        }

        protected override void ShowItemInGridViewRow(DataGridViewRow row, TotalStatistic item)
        {
            row.Tag = item;
            row.Cells["colDivision"].Value = item.Key.Division;
            row.Cells["colFacility"].Value = item.Key.Facility;
            row.Cells["colClassName"].Value = item.Key.ClassName;
            row.Cells["colSex"].Value = item.Key.Sex;
            row.Cells["col总人数"].Value = item.Total;
            row.Cells["col完成人数"].Value = item.Completed;
            row.Cells["col未完成人数"].Value = item.NotCompleted;
            row.Cells["col未测试人数"].Value = item.NoneTest;
            if (item.Completed > 0)
            {
                row.Cells["colAverage"].Value = item.Average;
                row.Cells["col平均分等级"].Value = item.AverageRank != ScoreRank.None ? item.AverageRank.ToString() : null;
                row.Cells["col标准差"].Value = item.StandardDeviation;
                row.Cells["colManFen"].Value = item.ManFen;
                row.Cells["colManFenRate"].Value = item.ManFenRate;
                row.Cells["colYuxiu"].Value = item.YouXiu;
                row.Cells["colYuxiuRate"].Value = item.YouXiuRate;
                row.Cells["colLianghao"].Value = item.LiangHao;
                row.Cells["colLiangHaoRate"].Value = item.LiangHaoRate;
                row.Cells["col优良人数"].Value = item.YouXiu + item.LiangHao;
                row.Cells["col优良率"].Value = item.YouXiuRate + item.LiangHaoRate;
                row.Cells["col中等人数"].Value = item.ZhongDeng;
                row.Cells["col中等率"].Value = item.ZhongDengRate;
                row.Cells["colJige"].Value = item.JiGe;
                row.Cells["colJigeRate"].Value = item.JiGeRate;
                row.Cells["colBujige"].Value = item.BuJiGe;
                row.Cells["colBujigeRate"].Value = item.BuJiGeRate;
                row.Cells["col合格人数"].Value = item.YouXiu + item.LiangHao + item.ZhongDeng + item.JiGe;
                row.Cells["col合格率"].Value = item.YouXiuRate + item.LiangHaoRate + item.ZhongDengRate + item.JiGeRate;
            }
        }
        #endregion

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            var column = dataGridView1.Columns[e.ColumnIndex];
            if (column is DataGridViewLinkColumn)
            {
                var item = dataGridView1.Rows[e.RowIndex].Tag as TotalStatistic;
                var con = new StudentWithTotalSearchCondition();
                var con1 = ucStatiticsSearch1.GetSearchCondition();
                con.DivisionID = con1.DivisionID;
                con.FacilityID = con1.FacilityID;
                con.ClassName = con1.ClassName;
                con.Sex = con1.Sex;
                if (!string.IsNullOrEmpty(item.Key.ClassName)) con.ClassName = item.Key.ClassName;
                if (!string.IsNullOrEmpty(item.Key.Sex)) con.Sex = item.Key.Sex == "男" ? Gender.Male : Gender.Female;
                if (!string.IsNullOrEmpty(item.Key.FacilityID)) con.FacilityID = item.Key.FacilityID;
                if (!string.IsNullOrEmpty(item.Key.DivisionID)) con.DivisionID =Guid.Parse ( item.Key.DivisionID);

                if (column.Name == "col总人数") con.TestStates = null;
                else if (column.Name == "col未测试人数") con.TestStates = new List<TestCompleteState>() { TestCompleteState.未测试 };
                else if (column.Name == "col未完成人数") con.TestStates = new List<TestCompleteState>() { TestCompleteState.部分科目完成 };
                else con.TestStates = new List<TestCompleteState>() { TestCompleteState.全部完成 };
                if (column.Name == "colManFen") con.TotalRank = ScoreRank.满分;
                else if (column.Name == "colYuxiu") con.TotalRank = ScoreRank.优秀;
                else if (column.Name == "colLianghao") con.TotalRank = ScoreRank.良好;
                else if (column.Name == "col优良人数") con.TotalRank = ScoreRank.优良;
                else if (column.Name == "col中等人数") con.TotalRank = ScoreRank.中等;
                else if (column.Name == "colJige") con.TotalRank = ScoreRank.及格;
                else if (column.Name == "colBujige") con.TotalRank = ScoreRank.不及格;
                else if (column.Name == "col合格人数") con.TotalRank = ScoreRank.合格;
                var ss = new APIClient(AppSettings.Current.ConnStr).GetList<string, StudentWithTotal>(con, AppSettings.Current.PhysicalProject.ID).QueryObjects;
                if(ss!=null && ss.Count > 0)
                {
                    var frm = new Frm学生成绩查看();
                    frm.StartPosition = FormStartPosition.CenterParent;
                    frm.Students = ss;
                    frm.ShowDialog();
                }
            }
        }
    }
}
