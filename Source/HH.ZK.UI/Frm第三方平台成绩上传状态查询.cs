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
using HH.ZK.CommonUI;
using LJH.GeneralLibrary;

namespace HH.ZK.UI
{
    public partial class Frm第三方平台成绩上传状态查询 : LJH.GeneralLibrary.WinForm.FrmReportBaseWithPaging<Guid, StudentScoreFull>
    {
        public Frm第三方平台成绩上传状态查询()
        {
            InitializeComponent();
        }

        #region 私有变量
        private List<StudentScoreFull> GetSelectedScores()
        {
            List<StudentScoreFull> scores = new List<StudentScoreFull>();
            foreach (DataGridViewCell cell in GridView.SelectedCells)
            {
                var score = GridView.Rows[cell.RowIndex].Tag as StudentScoreFull;
                if (!scores.Contains(score)) scores.Add(score);
            }
            return scores;
        }
        #endregion

        #region 重写基类方法
        protected override void Init()
        {
            base.Init();
            cmbPhysicalItem.Init(AppSettings.Current.PhysicalProject);
            ucStudentSearch1.Init(AppSettings.Current.PhysicalProject.ID);
        }

        public override void ShowOperatorRights()
        {
            base.ShowOperatorRights();
            btnSearch.Enabled = AppSettings.Current.Operator.PermitAll(Permission.StudentScore, PermissionActions.Read);
            btnSaveAs.Enabled = AppSettings.Current.Operator.PermitAll(Permission.StudentScore, PermissionActions.Read);
            mnu重新上传.Enabled = AppSettings.Current.Operator.PermitAny(Permission.StudentScore, PermissionActions.Read);
        }

        protected override QueryResultList<StudentScoreFull> GetDataSource(int pageSize, int pageIndex)
        {
            var con = new StudentScoreSearchCondition() { PageIndex = pageIndex, PageSize = pageSize, SortMode = SortMode.Desc };
            ucStudentSearch1.GetSearchCondition(con);
            con.SortMode = SortMode.Desc;
            if (!string.IsNullOrEmpty(cmbPhysicalItem.Text)) con.PhysicalItem = cmbPhysicalItem.SelectedPhysicalItem;
            if (rd未上传.Checked) con.Uploaded = false;
            else if (rd成功上传.Checked) con.UploadedSuccess = true;
            else if (rd上传失败.Checked) con.UploadedSuccess = false;
            var ret = new APIClient(AppSettings.Current.ConnStr).GetList<Guid, StudentScoreFull>(con, AppSettings.Current.PhysicalProject.ID);
            return ret;
        }

        protected override void ShowItemInGridViewRow(DataGridViewRow row, StudentScoreFull score)
        {
            row.Tag = score;
            row.Cells["colID"].Value = score.StudentID;
            row.Cells["colName"].Value = score.StudentName;
            row.Cells["colSex"].Value = score.Sex == Sex.Male ? "男" : "女";
            row.Cells["colFacility"].Value = score.FacilityName;
            row.Cells["col项目名称"].Value = score.PhysicalItemName;
            row.Cells["col项目编号"].Value = score.PhysicalItemID;
            row.Cells["col测试时间"].Value = score.TestTime.ToString("yyyy-MM-dd HH:mm:ss");
            row.Cells["col上传成绩"].Value = score.FormatScore;
            row.Cells["colUploadTime"].Value = score.UploadTime?.ToString("yyyy-MM-dd HH:mm:ss");
            if (score.UploadTime != null)
            {
                if (string.IsNullOrEmpty(score.UploadMsg))
                {
                    row.Cells["col上传状态"].Value = "上传成功";
                    row.DefaultCellStyle.ForeColor = Color.Blue;
                }
                else
                {
                    row.Cells["col上传状态"].Value = score.UploadMsg;
                    row.DefaultCellStyle.ForeColor = Color.Red;
                }
            }
            else
            {
                if (string.IsNullOrEmpty(score.UploadMsg))
                {
                    row.Cells["col上传状态"].Value = "未上传";
                    row.DefaultCellStyle.ForeColor = Color.Black;
                }
                else
                {
                    row.Cells["col上传状态"].Value = score.UploadMsg;
                    row.DefaultCellStyle.ForeColor = Color.Red;
                }
            }
        }
        #endregion

        #region 事件处理程序 
        private void mnu重新上传_Click(object sender, EventArgs e)
        {
            List<StudentScoreFull> scores = GetSelectedScores();
            if (scores != null && scores.Count > 0) ResetUploadState(scores);
        }

        private void ResetUploadState(List<StudentScoreFull> ss)
        {
            FrmProcessing frm = new FrmProcessing();
            Action action = delegate ()
            {
                try
                {
                    List<StudentScoreFull> temp = new List<StudentScoreFull>();
                    for (int i = 0; i < ss.Count; i++)
                    {
                        temp.Add(ss[i]);
                        if (temp.Count >= 100 || i == ss.Count - 1)
                        {
                            var patches = new List<UpdateItem<Guid>>();
                            foreach (var score in temp)
                            {
                                patches.Add(new UpdateItem<Guid>() { ID = score.ID, Key = "UploadTime", Value = null });
                                patches.Add(new UpdateItem<Guid>() { ID = score.ID, Key = "UploadMsg", Value = null });
                            }
                            var ret = new APIClient(AppSettings.Current.ConnStr).BatchPatch<Guid, StudentScore>(patches, AppSettings.Current.PhysicalProject.ID);
                            if (ret.Result == ResultCode.Successful && ret.Value != null && ret.Value.Successes != null)
                            {
                                foreach (var score in temp)
                                {
                                    if (ret.Value.Successes.ContainsKey(score.ID))
                                    {
                                        score.UploadTime = ret.Value.Successes[score.ID].UploadTime;
                                        score.UploadMsg = ret.Value.Successes[score.ID].UploadMsg;
                                    }
                                }
                            }
                            frm.ShowProgress(string.Empty, (decimal)(i + 1) / ss.Count);
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
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                ShowItemInGridViewRow(row, row.Tag as StudentScoreFull);
            }
        }
        #endregion
    }
}
