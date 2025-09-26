using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;
using HH.ZK.Model;
using HH.ZK.Model.CRM;
using HH.ZK.Model.SearchCondition;
using LJH.GeneralLibrary;
using LJH.GeneralLibrary.WinForm;
using HH.ZK.CommonUI;
using HH.ZK.WebAPIClient;

namespace HH.ZK.UI
{
    public partial class Frm原始成绩查询报表 : FrmReportBaseWithPaging<Guid, StudentScore>
    {
        public Frm原始成绩查询报表()
        {
            InitializeComponent();
        }

        #region 私有方法
        private void Init成绩来源()
        {
            this.cmb成绩来源.Items.Clear();
            this.cmb成绩来源.Items.Add(string.Empty);
            for (int i = 0; i < 100; i++)
            {
                if (Enum.IsDefined(typeof(ScoreSource), i)) this.cmb成绩来源.Items.Add(((ScoreSource)i).ToString());

            }
        }

        private List<StudentScore> GetSelectedScores()
        {
            List<StudentScore> scores = new List<StudentScore>();
            foreach (DataGridViewCell cell in GridView.SelectedCells)
            {
                var score = GridView.Rows[cell.RowIndex].Tag as StudentScore;
                if (!scores.Contains(score)) scores.Add(score);
            }
            return scores;
        }

        private void DeleteScores(List<StudentScore> scores)
        {
            FrmProcessing frm = new FrmProcessing();
            Action action = delegate ()
            {
                try
                {
                    List<StudentScore> temp = new List<StudentScore>();
                    for (int i = 0; i < scores.Count; i++)
                    {
                        temp.Add(scores[i]);
                        if (temp.Count >= 50 || i == scores.Count - 1)
                        {
                            CommandResult ret = new APIClient(AppSettings.Current.ConnStr).BatchDelete<Guid, StudentScore>(temp);
                            frm.ShowProgress(string.Empty, (decimal)(i + 1) / scores.Count);
                            temp.Clear();
                        }
                    }
                }
                catch (ThreadAbortException)
                {
                }
                catch (Exception)
                {
                }
                frm.ShowProgress(string.Empty, 1);
            };
            Thread t = new Thread(new ThreadStart(action));
            t.IsBackground = true;
            t.Start();
            if (frm.ShowDialog() != DialogResult.OK)
            {
                t.Abort();
            }
            btnSearch.PerformClick();
        }

        private void DoSpecialScore(SpecialScoreType spt)
        {
            if (MessageBox.Show("是否要将成绩设置为 " + spt.ToString() + " ?", "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            var patches = new List<UpdateItem<Guid>>();
            var items = GetSelectedScores();
            foreach (var score in items)
            {
                if (score.SpecialType == null || score.SpecialType != spt)
                {
                    patches.Add(new UpdateItem<Guid>() { ID = score.ID, Key = "State", Value = ((int)spt).ToString() });
                }
            }
            if (patches.Count == 0) return;
            FrmProcessing frm = new FrmProcessing();
            Action action = delegate ()
            {
                try
                {
                    List<UpdateItem<Guid>> temp = new List<UpdateItem<Guid>>();
                    for (int i = 0; i < patches.Count; i++)
                    {
                        temp.Add(patches[i]);
                        if (temp.Count >= 50 || i == patches.Count - 1)
                        {
                            var ret = new APIClient(AppSettings.Current.ConnStr).BatchPatch<Guid, StudentScore>(temp, AppSettings.Current.PhysicalProject.ID);
                            frm.ShowProgress(string.Empty, (decimal)(i + 1) / patches.Count);
                            temp.Clear();
                        }
                    }
                }
                catch (ThreadAbortException)
                {
                }
                catch (Exception)
                {
                }
                frm.ShowProgress(string.Empty, 1);
            };
            Thread t = new Thread(new ThreadStart(action));
            t.IsBackground = true;
            t.Start();
            if (frm.ShowDialog() != DialogResult.OK)
            {
                t.Abort();
            }
            btnSearch.PerformClick();
        }
        #endregion

        #region 重写基类方法
        protected override void Init()
        {
            base.Init();
            ucStudentSearch1.Init();
            Init成绩来源();
        }

        public override void ShowOperatorRights()
        {
            base.ShowOperatorRights();
            btnSearch.Enabled = AppSettings.Current.Operator.PermitAll(Permission.StudentScore, PermissionActions.Read);
            btnSaveAs.Enabled = AppSettings.Current.Operator.PermitAll(Permission.StudentScore, PermissionActions.Read);
            mnu删除所选成绩.Enabled = AppSettings.Current.Operator.PermitAny(Permission.StudentScore, PermissionActions.Delete);
        }

        protected override QueryResultList<StudentScore> GetDataSource(int pageSize, int pageIndex)
        {
            var con = new StudentScoreSearchCondition() { PageIndex = pageIndex, PageSize = pageSize, SortMode = SortMode.Desc };
            ucStudentSearch1.GetSearchCondition(con);
            con.DateRange = new DateTimeRange() { Begin = dt开始训练日期.Value.Date, End = dt结束训练日期.Value.Date };
            if (!string.IsNullOrEmpty(txt科目.Text)) con.TestID = int.Parse(txt科目.Text);
            if (!string.IsNullOrEmpty(cmb成绩来源.Text))
            {
                ScoreSource temp;
                if (Enum.TryParse<ScoreSource>(cmb成绩来源.Text, out temp)) con.ScoreFrom = temp;
            }
            if (!string.IsNullOrEmpty(txtHostSN.Text)) con.DeviceSN = txtHostSN.Text.ToUpper();
            if (!string.IsNullOrEmpty(txtHostID.Text)) con.HostID = txtHostID.Text.ToUpper();
            return new APIClient(AppSettings.Current.ConnStr).GetList<Guid, StudentScore>(con);
        }

        protected override void ShowItemInGridViewRow(DataGridViewRow row, StudentScore score)
        {
            row.Tag = score;
            row.Cells["colID"].Value = score.StudentID;
            row.Cells["colName"].Value = score.StudentName;
            row.Cells["colSex"].Value = score.Gender == Gender.Male ? "男" : "女";
            row.Cells["colFacility"].Value = score.DivisionName;
            row.Cells["colPhysicalItem"].Value = score.TestName;
            row.Cells["colProject"].Value = score.ProjectName;
            if (score.SpecialType == SpecialScoreType.作废)
            {
                row.Cells["colScore"].Value = score.RawScore;
            }
            else if (score.SpecialType.HasValue) row.Cells["colScore"].Value = score.SpecialType.ToString();
            else
            {
                decimal temp;
                if (!string.IsNullOrEmpty(score.FormatScore) && decimal.TryParse(score.FormatScore, out temp)) row.Cells["colScore"].Value = temp;
                else row.Cells["colScore"].Value = score.FormatScore;
            }
            if (score.Result != null && AppSettings.Current.Operator.PermitAny(Permission.总分, PermissionActions.Read)) row.Cells["colResult"].Value = score.Result.Value.Trim();
            row.Cells["colDate"].Value = score.TestTime.ToString("yyyy-MM-dd HH:mm:ss");
            row.Cells["col成绩来源"].Value = score.ScoreFrom.ToString();
            row.Cells["colDevice"].Value = score.DeviceSn;
            row.Cells["colScoreSer"].Value = score.ScoreSer;
            row.Cells["colHost"].Value = score.HostID;
            row.Cells["colMemo"].Value = score.Memo;
            row.DefaultCellStyle.ForeColor = score.SpecialType == null ? Color.Black : Color.Red;
        }

        private void mnu删除所选成绩_Click(object sender, EventArgs e)
        {
            var items = GetSelectedScores();
            if (items.Count == 0) return;
            if (MessageBox.Show("是否删除所选的成绩?", "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            DeleteScores(items);
        }
        #endregion

        
    }
}
