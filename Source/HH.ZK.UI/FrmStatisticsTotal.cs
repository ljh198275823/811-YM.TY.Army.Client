using System;
using System.Collections.Generic;
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
    public partial class FrmStatisticsTotal : FrmReportBaseWithPaging<long, TotalStatistic>
    {
        public FrmStatisticsTotal()
        {
            InitializeComponent();
        }

        #region 重写基类方法
        protected override void Init()
        {
            base.Init();
            txtProject.Init();
            ucStudentSearch1.Init();
        }

        public override void ShowOperatorRights()
        {
            base.ShowOperatorRights();
            btnSaveAs.Enabled = AppSettings.Current.Operator.PermitAll(Permission.总分, PermissionActions.Read);
            btnSearch.Enabled = AppSettings.Current.Operator.PermitAll(Permission.总分, PermissionActions.Read);
        }

        protected override QueryResultList<TotalStatistic> GetDataSource(int pageSize, int pageIndex)
        {
            var con = new StatisticSearchCondition();
            ucStudentSearch1.GetSearchCondition(con);
            con.ProjectID = txtProject.SelectedProjectID;
            con.DateRange = new DateTimeRange(dt开始训练日期.Value.Date, dt结束训练日期.Value.Date);
            con.ByDivision = chkByDivision.Checked;
            con.ByGender = chkByGender.Checked;
            con.SortMode = LJH.GeneralLibrary.SortMode.Asc;
            con.PageIndex = pageIndex;
            con.PageSize = pageSize;
            var ret = new APIClient(AppSettings.Current.ConnStr).GetList<long, TotalStatistic>(con);
            dataGridView1.Columns["colDivision"].Visible = con.ByDivision;
            dataGridView1.Columns["col性别"].Visible = con.ByGender;
            return ret;
        }

        protected override void ShowItemInGridViewRow(DataGridViewRow row, TotalStatistic item)
        {
            row.Tag = item;
            row.Cells["colDivision"].Value = item.Key.Division;
            row.Cells["col性别"].Value = item.Key.Gender;
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
                con.ProjectID = txtProject.SelectedProjectID;
                con.DateRange = new DateTimeRange(dt开始训练日期.Value.Date, dt结束训练日期.Value.Date);
                con.DivisionID = item.Key.DivisionID;
                if (item.Key.Gender == "男") con.Gender = Gender.Male;
                if (item.Key.Gender == "女") con.Gender = Gender.Female;
                if (column.Name == "col总人数") con.TestStates = null;
                else if (column.Name == "col未测试人数") con.TestStates = new List<TestCompleteState>() { TestCompleteState.未测试 };
                else if (column.Name == "col未完成人数") con.TestStates = new List<TestCompleteState>() { TestCompleteState.部分科目完成 };
                else con.TestStates = new List<TestCompleteState>() { TestCompleteState.全部完成 };
                if (column.Name == "colYuxiu") con.Ranks = new List<string>() { "优秀" };
                else if (column.Name == "colLianghao") con.Ranks = new List<string>() { "良好" };
                else if (column.Name == "col优良人数") con.Ranks = new List<string>() { "优秀", "良好" };
                else if (column.Name == "col中等人数") con.Ranks = new List<string>() { "中等" };
                else if (column.Name == "colJige") con.Ranks = new List<string>() { "及格" };
                else if (column.Name == "colBujige") con.Ranks = new List<string>() { "不及格" };
                else if (column.Name == "col合格人数") con.Ranks = new List<string>() { "优秀", "良好", "中等", "及格" };
                var ss = new APIClient(AppSettings.Current.ConnStr).GetList<string, StudentWithTotal>(con).QueryObjects;
                if (ss != null && ss.Count > 0)
                {
                    var frm = new Frm人员成绩查看();
                    frm.ProjectID = txtProject.SelectedProjectID;
                    frm.StartPosition = FormStartPosition.CenterParent;
                    frm.Students = ss;
                    frm.ShowDialog();
                }
            }
        }
    }
}
