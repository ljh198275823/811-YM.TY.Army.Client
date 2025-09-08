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
using HH.ZK.WebAPIClient;
using LJH.GeneralLibrary.WinForm;

namespace HH.ZK.CommonUI
{
    public partial class Frm删除学生成绩 : FrmReportBaseWithPaging<Guid,StudentScoreFull>
    {
        public Frm删除学生成绩()
        {
            InitializeComponent();
        }

        public PhysicalProject Project { get; set; }

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
                            CommandResult ret = new APIClient(AppSettings.Current.ConnStr).BatchDelete<Guid, StudentScore>(temp, Project.ID);
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
        #endregion

        #region 重写基类方法
        protected override void Init()
        {
            base.Init();
            Project.PhysicalItems = SysParaSettingsClient.GetOrCreateSetting<PhysicalItemSettings>(AppSettings.Current.ConnStr, Project.ID);
            cmbPhysicalItem.Init(Project);
            ucFacilitySearch1.Init();
            Init成绩来源();
            if (Project == null) btnSearch.Enabled = false;
        }

        protected override QueryResultList<StudentScoreFull> GetDataSource(int pageSize, int pageIndex)
        {
            var con = new StudentScoreSearchCondition() { PageIndex = pageIndex, PageSize = pageSize, SortMode = SortMode.Desc };
            var con1 = ucFacilitySearch1.GetSearchCondition();
            con.ClassName = con1.ClassName;
            con.FacilityID = con1.FacilityID;
            con.DivisionID = con1.DivisionID;
            if (rdMale.Checked) con.Sex = Gender.Male;
            if (rdFemale.Checked) con.Sex = Gender.Female;
            con.Name = txtName.Text;
            con.StudentIDLike = txtStudentID1.Text;
            if (!string.IsNullOrEmpty(cmbPhysicalItem.Text)) con.PhysicalItem = cmbPhysicalItem.SelectedPhysicalItem;
            if (!string.IsNullOrEmpty(cmb成绩来源.Text))
            {
                ScoreSource temp;
                if (Enum.TryParse<ScoreSource>(cmb成绩来源.Text, out temp)) con.ScoreFrom = temp;
            }
            if (!string.IsNullOrEmpty(txtHostSN.Text)) con.DeviceSN = txtHostSN.Text.ToUpper();
            if (rd正常成绩.Checked) con.SpecialScore = false;
            else if (rd特殊成绩.Checked) con.SpecialScore = true;
            return new APIClient(AppSettings.Current.ConnStr).GetList<Guid, StudentScoreFull>(con, Project.ID);
        }

        protected override void ShowItemInGridViewRow(DataGridViewRow row, StudentScoreFull score)
        {
            row.Tag = score;
            row.Cells["colID"].Value = score.StudentID;
            row.Cells["colName"].Value = score.StudentName;
            row.Cells["colSex"].Value = score.Sex == Gender.Male ? "男" : "女";
            row.Cells["colFacility"].Value = score.FacilityName;
            row.Cells["colGrade"].Value = GradeHelper.Instance.GetName(score.Grade);
            row.Cells["colPhysicalItem"].Value = score.PhysicalItemName;
            if (score.SpecialType.HasValue) row.Cells["colScore"].Value = score.SpecialType.ToString();
            else
            {
                decimal temp;
                if (!string.IsNullOrEmpty(score.FormatScore) && decimal.TryParse(score.FormatScore, out temp)) row.Cells["colScore"].Value = temp;
                else row.Cells["colScore"].Value = score.FormatScore;
            }
            if (score.Result != null && AppSettings.Current.Operator.PermitAny(Permission.总分, PermissionActions.Read)) row.Cells["colResult"].Value = score.Result.Value.Trim();
            row.Cells["colDate"].Value = score.TestTime.ToString("yyyy-MM-dd HH:mm:ss");
            row.Cells["col成绩来源"].Value = score.ScoreFrom.ToString();
            row.Cells["colMemo"].Value = score.Memo;
            row.DefaultCellStyle.ForeColor = score != null ? Color.Black : Color.Red;
        }

        private void mnu删除所选成绩_Click(object sender, EventArgs e)
        {
            var items = GetSelectedScores();
            if (items.Count == 0) return;
            if (MessageBox.Show("是否删除所选的学生成绩?", "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            DeleteScores(items);
        }
        #endregion
    }
}
