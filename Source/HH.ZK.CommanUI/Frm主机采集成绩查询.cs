using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Threading;
using System.Diagnostics;
using System.Windows.Forms;
using HH.ZK.Model;
using HH.ZK.Model.CRM;
using HH.ZK.Model.SearchCondition;
using HH.ZK.WebAPIClient;
using HH.ZK.SQLite;
using LJH.GeneralLibrary;
using LJH.GeneralLibrary.WinForm;

namespace HH.ZK.CommonUI
{
    public partial class Frm主机采集成绩查询 : FrmReportBaseWithPaging<Guid, StudentLocalRawScore>
    {
        public Frm主机采集成绩查询()
        {
            InitializeComponent();
        }

        #region 重写基类方法
        protected override void Init()
        {
            base.Init();
            cmbPhysicalItem.Init(AppSettings.Current.PhysicalProject);
            ucDateTimeInterval1.Init();
            ucDateTimeInterval1.SelectToday();
            if (AppSettings.Current.PhysicalProject == null) btnSearch.Enabled = false;
        }

        public override void ShowOperatorRights()
        {
            base.ShowOperatorRights();
            btnSearch.Enabled = AppSettings.Current.Operator.PermitAll(Permission.StudentScore, PermissionActions.Read);
            btnSaveAs.Enabled = AppSettings.Current.Operator.PermitAll(Permission.StudentScore, PermissionActions.Read);
            mnu重新上传所选成绩.Enabled = AppSettings.Current.Operator.PermitAll(Permission.StudentScore, PermissionActions.CollectScore);
        }

        protected override QueryResultList<StudentLocalRawScore> GetDataSource(int pageSize, int pageIndex)
        {
            var con = new StudentRawScoreSearchCondition() { PageIndex = pageIndex, PageSize = pageSize, SortMode = SortMode.Asc };
            con.ProjectID = AppSettings.Current.PhysicalProject.ID;
            con.Name = txtName.Text;
            con.StudentIDLike = txtStudentID1.Text;
            con.DateTimeRange = new DateTimeRange(ucDateTimeInterval1.StartDateTime, ucDateTimeInterval1.EndDateTime);
            con.HostSN = txtHostSN.Text;
            if (rd未上传.Checked) con.SyncState = 0;
            else if (rd同步成功.Checked) con.SyncState = 1;
            else if (rd同步失败.Checked) con.SyncState = 2;
            if (!string.IsNullOrEmpty(cmbPhysicalItem.Text)) con.TestID = cmbPhysicalItem.SelectedPhysicalItem;
            return ProviderFactory.Create<StudentRawScoreProvider>(AppSettings.Current.LocalDB).GetItems(con);
        }

        protected override void ShowItemInGridViewRow(DataGridViewRow row, StudentLocalRawScore score)
        {
            row.Tag = score;
            row.Cells["colHostSN"].Value = score.HostSn;
            row.Cells["colHostID"].Value = score.HostID;
            row.Cells["colScoreSer"].Value = score.ScoreSer;
            row.Cells["colID"].Value = score.StudentID;
            row.Cells["colName"].Value = score.StudentName;
            row.Cells["colSex"].Value = score.Sex;
            var pi = AppSettings.Current.PhysicalProject.PhysicalItems.GetPhysicalItem(score.TestID);
            row.Cells["colPhysicalItem"].Value = pi != null ? pi.Name : score.TestID.ToString();
            row.Cells["colScore"].Value = score.SpecialType == null ? score.Score.ToString() : score.SpecialType.ToString();
            row.Cells["col犯规次数"].Value = score.FGCount;
            row.Cells["colDate"].Value = score.CreateTime.ToString("yyyy-MM-dd HH:mm:ss");
            row.Cells["col成绩来源"].Value = score.ScoreFrom.ToString();
            row.Cells["colSyncTime"].Value = score.SyncTime?.ToString("yyyy-MM-dd HH:mm:ss");
            row.Cells["colSyncError"].Value = score.SyncError;
            if (score.SyncTime == null) row.DefaultCellStyle.ForeColor = Color.Blue;
            else row.DefaultCellStyle.ForeColor = !string.IsNullOrEmpty(score.SyncError) ? Color.Red : Color.Black;
        }
        #endregion

        private List<StudentLocalRawScore> GetSelectedScores()
        {
            List<StudentLocalRawScore> students = new List<StudentLocalRawScore>();
            foreach (DataGridViewCell cell in GridView.SelectedCells)
            {
                var student = GridView.Rows[cell.RowIndex].Tag as StudentLocalRawScore;
                if (!students.Contains(student)) students.Add(student);
            }
            return students;
        }

        private void mnu重新上传所选成绩_Click(object sender, EventArgs e)
        {
            var scores = GetSelectedScores();
            if (scores != null && scores.Count > 0)
            {
                if (MessageBox.Show("是否重新上传所选成绩?", "询问", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                {
                    ClearStates(scores);
                }
            }
        }

        private void ClearStates(List<StudentLocalRawScore> scores)
        {
            FrmProcessing frmP = new FrmProcessing();
            Action action = delegate ()
            {
                try
                {
                    List<StudentLocalRawScore> temp = new List<StudentLocalRawScore>();
                    for (int i = 0; i < scores.Count; i++)
                    {
                        temp.Add(scores[i]);
                        if (i == scores.Count - 1 || temp.Count == 100)
                        {
                            List<UpdateItem<Guid>> patches = new List<UpdateItem<Guid>>();
                            patches.AddRange(from it in temp select new UpdateItem<Guid>() { ID = it.ID, Key = "SyncTime", Value = null });
                            patches.AddRange(from it in temp select new UpdateItem<Guid>() { ID = it.ID, Key = "SyncError", Value = null });
                            var ret = ProviderFactory.Create<StudentRawScoreProvider>(AppSettings.Current.LocalDB).BatchPatch(patches);
                            temp.Clear();
                            frmP.ShowProgress(string.Empty, (decimal)(i + 1) / scores.Count);
                        }
                    }
                }
                catch (ThreadAbortException)
                {
                }
                catch (Exception)
                {
                }
                frmP.ShowProgress(string.Empty, 1);
            };
            Thread t = new Thread(new ThreadStart(action));
            t.IsBackground = true;
            t.Start();
            if (frmP.ShowDialog() != DialogResult.OK)
            {
                t.Abort();
            }
            btnSearch.PerformClick();
        }
    }
}
