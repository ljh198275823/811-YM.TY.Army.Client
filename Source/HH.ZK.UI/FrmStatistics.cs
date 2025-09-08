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
    public partial class FrmStatistics : FrmReportBaseWithPaging<Guid,ScoreStatistic>
    {
        public FrmStatistics()
        {
            InitializeComponent();
        }

        #region 私有方法
        private void ShowScoreCell(DataGridViewCell cell, string score)
        {
            //这么做主要是为了列的排序
            decimal temp;
            if (!string.IsNullOrEmpty(score) && decimal.TryParse(score, out temp)) cell.Value = temp; //能转化成实数，显示实数
            else cell.Value = score; //否则显示格式化成绩
        }
        #endregion

        #region 重写基类方法
        protected override void Init()
        {
            base.Init();
            ucStatiticsSearch1.Init();
            cmbPhysicalItem.Init(AppSettings.Current.PhysicalProject);
        }

        public override void ShowOperatorRights()
        {
            base.ShowOperatorRights();
            btnSaveAs.Enabled = AppSettings.Current.Operator.PermitAll(Permission.总分, PermissionActions.Read);
            btnSearch.Enabled = AppSettings.Current.Operator.PermitAll(Permission.总分, PermissionActions.Read);
        }

        protected override QueryResultList<ScoreStatistic> GetDataSource(int pageSize, int pageIndex)
        {
            var con = ucStatiticsSearch1.GetSearchCondition();
            if (!string.IsNullOrEmpty(cmbPhysicalItem.Text)) con.PhysicalItemIDs = new List<int>() { cmbPhysicalItem.SelectedPhysicalItem };
            con.SortMode = LJH.GeneralLibrary.SortMode.Asc;
            con.PageIndex = pageIndex;
            con.PageSize = pageSize;
            var ret = new APIClient(AppSettings.Current.ConnStr).GetList<Guid, ScoreStatistic>(con, AppSettings.Current.PhysicalProject.ID);
            dataGridView1.Columns["colDivision"].Visible = con.ByDivision;
            dataGridView1.Columns["colFacility"].Visible = con.ByFacility;
            dataGridView1.Columns["colClassName"].Visible = con.ByClass;
            dataGridView1.Columns["colSex"].Visible = con.BySex;
            return ret;
        }

        protected override void ShowItemInGridViewRow(DataGridViewRow row, ScoreStatistic item)
        {
            row.Cells["colDivision"].Value = item.Key.Division;
            row.Cells["colFacility"].Value = item.Key.Facility;
            row.Cells["colClassName"].Value = item.Key.ClassName;
            row.Cells["colSex"].Value = item.Key.Sex;
            row.Cells["colPhysicalItem"].Value = item.PhysicalItem;
            row.Cells["col总人数"].Value = item.Total;
            row.Cells["col完成人数"].Value = item.Completed;
            row.Cells["col未测试人数"].Value = item.NoneTest;
            if (item.Completed > 0)
            {
                row.Cells["col总成绩"].Value = item.TotalScore;
                ShowScoreCell(row.Cells["colAverage"], item.Average);
                row.Cells["col标准差"].Value = item.StandardDeviation;
                ShowScoreCell ( row.Cells["col最高成绩"], item.MaxScore);
                ShowScoreCell(row.Cells["col最低成绩"], item.MinScore);
                row.Cells["col平均得分"].Value = item.AverageResult;
                row.Cells["colManFen"].Value = item.ManFen;
                row.Cells["colManFenRate"].Value = item.ManFenRate;
                row.Cells["colYouxiu"].Value = item.YouXiu;
                row.Cells["colYouxiuRate"].Value = item.YouXiuRate;
                row.Cells["colLianghao"].Value = item.LiangHao;
                row.Cells["colLianghaoRate"].Value = item.LiangHaoRate;
                row.Cells["col优良人数"].Value = item.YouXiu + item.LiangHao;
                row.Cells["col优良率"].Value = item.YouXiuRate + item.LiangHaoRate;
                row.Cells["col中等人数"].Value = item.ZhongDeng;
                row.Cells["col中等率"].Value = item.ZhongDengRate;
                row.Cells["colJige"].Value = item.JiGe;
                row.Cells["colJigeRate"].Value = item.JiGeRate;
                row.Cells["col合格人数"].Value = item.YouXiu + item.LiangHao + item.ZhongDeng + item.JiGe;
                row.Cells["col合格率"].Value = item.YouXiuRate + item.LiangHaoRate + item.ZhongDengRate + item.JiGeRate;
                row.Cells["colBujige"].Value = item.BuJiGe;
                row.Cells["colBujigeRate"].Value = item.BuJiGeRate;
            }
        }
        #endregion

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            var column = dataGridView1.Columns[e.ColumnIndex];
            if (column is DataGridViewLinkColumn)
            {
                var item = dataGridView1.Rows[e.RowIndex].Tag as ScoreStatistic;
                var con = new StudentWithDXCJSearchCondition();
                var con1 = ucStatiticsSearch1.GetSearchCondition();
                con.DivisionID = con1.DivisionID;
                con.FacilityID = con1.FacilityID;
                con.ClassName = con1.ClassName;
                con.Sex = con1.Sex;
                con.PhysicalItem = item.PhysicalItemID;
                if (!string.IsNullOrEmpty(item.Key.ClassName)) con.ClassName = item.Key.ClassName;
                if (!string.IsNullOrEmpty(item.Key.Sex)) con.Sex = item.Key.Sex == "男" ? Gender.Male : Gender.Female;
                if (!string.IsNullOrEmpty(item.Key.FacilityID)) con.FacilityID = item.Key.FacilityID;
                if (!string.IsNullOrEmpty(item.Key.DivisionID)) con.DivisionID = Guid.Parse(item.Key.DivisionID);

                if (column.Name == "col总人数") con.HasScore = null;
                else if (column.Name == "col未测试人数") con.HasScore = false;
                else con.HasScore = true;

                if (column.Name == "colManFen") con.ScoreRank = ScoreRank.满分;
                else if (column.Name == "colYouxiu") con.ScoreRank = ScoreRank.优秀;
                else if (column.Name == "colLianghao") con.ScoreRank = ScoreRank.良好;
                else if (column.Name == "col优良人数") con.ScoreRank = ScoreRank.优良;
                else if (column.Name == "col中等人数") con.ScoreRank = ScoreRank.中等;
                else if (column.Name == "colJige") con.ScoreRank = ScoreRank.及格;
                else if (column.Name == "colBujige") con.ScoreRank = ScoreRank.不及格;
                else if (column.Name == "col合格人数") con.ScoreRank = ScoreRank.合格;
                var ss = new APIClient(AppSettings.Current.ConnStr).GetList<string, StudentWithDXCJ>(con, AppSettings.Current.PhysicalProject.ID).QueryObjects;
                if (ss != null && ss.Count > 0)
                {
                    var frm = new Frm学生单项成绩查看();
                    frm.StartPosition = FormStartPosition.CenterParent;
                    frm.Students = ss;
                    frm.ShowDialog();
                }
            }
        }
    }
}
