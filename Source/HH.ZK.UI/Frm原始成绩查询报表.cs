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
    public partial class Frm原始成绩查询报表 : FrmReportBaseWithPaging<Guid, StudentScoreFull>
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

        private void Init测试日期()
        {
            txt测试日期.Items.Clear();
            txt测试日期.Items.Add(string.Empty);
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
                            CommandResult ret = new APIClient(AppSettings.Current.ConnStr).BatchDelete<Guid, StudentScore>(temp, AppSettings.Current.PhysicalProject.ID);
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

        private void 视频回放(StudentScore score)
        {
        }
        #endregion

        #region 重写基类方法
        protected override void Init()
        {
            base.Init();
            cmbPhysicalItem.Init(AppSettings.Current.PhysicalProject);
            ucStudentSearch1.Init();
            Init成绩来源();
            Init测试日期();
            if (AppSettings.Current.PhysicalProject == null) btnSearch.Enabled = false;
        }

        public override void ShowOperatorRights()
        {
            base.ShowOperatorRights();
            btnSearch.Enabled = AppSettings.Current.Operator.PermitAll(Permission.StudentScore, PermissionActions.Read);
            btnSaveAs.Enabled = AppSettings.Current.Operator.PermitAll(Permission.StudentScore, PermissionActions.Read);
            mnu删除所选成绩.Enabled = AppSettings.Current.Operator.PermitAny(Permission.StudentScore, PermissionActions.Delete);
            this.mnu伤病.Enabled = AppSettings.Current.Operator.PermitAny(Permission.StudentScore, PermissionActions.Edit);
            this.mnu残疾.Enabled = AppSettings.Current.Operator.PermitAny(Permission.StudentScore, PermissionActions.Edit);
            this.mnu未完成.Enabled = AppSettings.Current.Operator.PermitAny(Permission.StudentScore, PermissionActions.Edit);
            this.mnu作废所选成绩.Enabled = AppSettings.Current.Operator.PermitAny(Permission.StudentScore, PermissionActions.Edit);
            this.mnu弃考.Enabled = AppSettings.Current.Operator.PermitAny(Permission.StudentScore, PermissionActions.Edit);
            this.mnu犯规.Enabled = AppSettings.Current.Operator.PermitAny(Permission.StudentScore, PermissionActions.Edit);
            this.mnu成绩仲裁.Enabled = AppSettings.Current.Operator.PermitAny(Permission.Discussion, PermissionActions.Edit);
        }

        protected override QueryResultList<StudentScoreFull> GetDataSource(int pageSize, int pageIndex)
        {
            var para = SysParaSettingsClient.GetSetting<NVRClientSettings>(AppSettings.Current.ConnStr, AppSettings.Current.PhysicalProject.ID);
            if (para != null) NVRClientSettings.Current = para;
            mnu视频回放.Visible = NVRClientSettings.Current != null;

            var con = new StudentScoreSearchCondition() { PageIndex = pageIndex, PageSize = pageSize };
            ucStudentSearch1.GetSearchCondition(con);
            if (!string.IsNullOrEmpty(txt测试日期.Text))
            {
                var dt = DateTime.Parse(txt测试日期.Text);
                con.DateTimeRange = new DateTimeRange() { Begin = dt.Date, End = dt.Date.AddDays(1).AddSeconds(-1) };
            }
            con.SortMode = SortMode.Desc;
            if (!string.IsNullOrEmpty(cmbPhysicalItem.Text)) con.PhysicalItem = cmbPhysicalItem.SelectedPhysicalItem;
            if (!string.IsNullOrEmpty(cmb成绩来源.Text))
            {
                ScoreSource temp;
                if (Enum.TryParse<ScoreSource>(cmb成绩来源.Text, out temp)) con.ScoreFrom = temp;
            }
            if (!string.IsNullOrEmpty(txtHostSN.Text)) con.DeviceSN = txtHostSN.Text.ToUpper();
            if (!string.IsNullOrEmpty(txtHostID.Text)) con.HostID = txtHostID.Text.ToUpper();
            if (rd正常成绩.Checked) con.SpecialScore = false;
            else if (rd特殊成绩.Checked) con.SpecialScore = true;
            return new APIClient(AppSettings.Current.ConnStr).GetList<Guid, StudentScoreFull>(con, AppSettings.Current.PhysicalProject.ID);
        }

        protected override void ShowItemInGridViewRow(DataGridViewRow row, StudentScoreFull score)
        {
            row.Tag = score;
            row.Cells["colID"].Value = score.StudentID;
            row.Cells["colName"].Value = score.StudentName;
            row.Cells["colSex"].Value = score.Sex == Gender.Male ? "男" : "女";
            row.Cells["colFacility"].Value = score.FacilityName;
            row.Cells["colPhysicalItem"].Value = score.PhysicalItemName;
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
            row.Cells["col开始时间"].Value = score.StartTime?.ToString("yyyy-MM-dd HH:mm:ss");
            row.Cells["colVideoChannels"].Value = score.VideoChannels;
            row.Cells["col视频回放"].Value = (NVRClientSettings.Current != null && !string.IsNullOrEmpty(score.VideoChannels)) ? "视频回放" : null;
            row.Cells["colMemo"].Value = score.Memo;
            row.DefaultCellStyle.ForeColor = score.SpecialType == null ? Color.Black : Color.Red;
        }

        private void mnu删除所选成绩_Click(object sender, EventArgs e)
        {
            var items = GetSelectedScores();
            if (items.Count == 0) return;
            if (MessageBox.Show("是否删除所选的学生成绩?", "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            DeleteScores(items);
        }

        private void mnu犯规_Click(object sender, EventArgs e)
        {
            DoSpecialScore(SpecialScoreType.犯规);
        }

        private void mnu未完成_Click(object sender, EventArgs e)
        {
            DoSpecialScore(SpecialScoreType.未完成);
        }

        private void mnu弃权_Click(object sender, EventArgs e)
        {
            DoSpecialScore(SpecialScoreType.弃考);
        }

        private void mnu伤病_Click(object sender, EventArgs e)
        {
            DoSpecialScore(SpecialScoreType.伤病);
        }

        private void mnu残疾_Click(object sender, EventArgs e)
        {
            DoSpecialScore(SpecialScoreType.残疾);
        }

        private void mnu作废所选成绩_Click(object sender, EventArgs e)
        {
            DoSpecialScore(SpecialScoreType.作废);
        }

        private void mnu成绩仲裁_Click(object sender, EventArgs e)
        {
            var items = GetSelectedScores();
            if (items != null && items.Count == 1)
            {
                var frm = new FrmDiscussionDetail();
                frm.IsAdding = true;
                frm.Score = items[0];
                frm.StartPosition = FormStartPosition.CenterParent;
                var dig = frm.ShowDialog();
                if (dig == DialogResult.OK)
                {
                    btnSearch.PerformClick();
                }
            }
        }

        private void mnu设置视频通道_Click(object sender, EventArgs e)
        {
            var items = GetSelectedScores();
            if (items.Count == 0) return;
            var dig = new Frm设置视频通道();
            if (dig.ShowDialog() != DialogResult.OK) return;
            var vc = dig.VideoChannels;
            var patches = new List<UpdateItem<Guid>>();
            foreach (var score in items)
            {
                patches.Add(new UpdateItem<Guid>() { ID = score.ID, Key = "VideoChannels", Value = vc });
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

        private void mnu视频回放_Click(object sender, EventArgs e)
        {
            if (NVRClientSettings.Current == null) return;
            var items = GetSelectedScores();
            if (items != null && items.Count == 1)
            {
                if (string.IsNullOrEmpty(items[0].VideoChannels))
                {
                    MessageBox.Show("没有设置视频通道，不能回放视频");
                    return;
                }
                视频回放(items[0]);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (dataGridView1.Columns[e.ColumnIndex].Name == "col视频回放")
            {
                var score = dataGridView1.Rows[e.RowIndex].Tag as StudentScoreFull;
                if (NVRClientSettings.Current != null) 视频回放(score);
            }
        }
        #endregion

        
    }
}
