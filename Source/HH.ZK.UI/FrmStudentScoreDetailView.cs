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
using HH.ZK.Model.CRM;
using HH.ZK.WebAPIClient;
using LJH.GeneralLibrary;

namespace HH.ZK.UI
{
    public partial class FrmStudentScoreDetailView : Form
    {
        public FrmStudentScoreDetailView()
        {
            InitializeComponent();
        }

        #region 公共属性
        public StudentInProject  Student { get; set; }

        public PhysicalItem PhysicalItem { get; set; }
        #endregion

        private void FrmStudentScoreDetailView_Load(object sender, EventArgs e)
        {
            this.Text += "_" + PhysicalItem?.Name;
            this.mnu_Add.Enabled = AppSettings.Current.Operator.PermitAny(Permission.StudentScore, PermissionActions.Edit);
            this.mnu_Update.Visible = AppSettings.Current.PhysicalProject.Options.CannotModifyScore == false;
            this.mnu_Update.Enabled = AppSettings.Current.Operator.PermitAny(Permission.StudentScore, PermissionActions.Edit);
            this.mnu_DelScore.Enabled = AppSettings.Current.Operator.PermitAny(Permission.StudentScore, PermissionActions.Delete);
            this.mnu伤病.Enabled = AppSettings.Current.Operator.PermitAny(Permission.StudentScore, PermissionActions.Edit);
            this.mnu残疾.Enabled = AppSettings.Current.Operator.PermitAny(Permission.StudentScore, PermissionActions.Edit);
            this.mnu未完成.Enabled = AppSettings.Current.Operator.PermitAny(Permission.StudentScore, PermissionActions.Edit);
            this.mnu作废.Enabled = AppSettings.Current.Operator.PermitAny(Permission.StudentScore, PermissionActions.Edit);
            this.mnu弃考.Enabled = AppSettings.Current.Operator.PermitAny(Permission.StudentScore, PermissionActions.Edit);
            this.mnu犯规.Enabled = AppSettings.Current.Operator.PermitAny(Permission.StudentScore, PermissionActions.Edit);
            this.mnu成绩仲裁.Enabled = AppSettings.Current.Operator.PermitAny(Permission.Discussion, PermissionActions.Edit);
            ShowScores();
        }

        #region 重写基类方法
        private void ShowScores()
        {
            dataGridView1.Rows.Clear();
            var con = new StudentWithDXCJSearchCondition()
            {
                StudentID = Student.StudentID,
                ProjectID = Student.ProjectID,
                DateRange = new DateTimeRange(Student.TestDate, Student.TestDate),
                TestID = PhysicalItem.ID
            };
            var items = new APIClient(AppSettings.Current.ConnStr).GetList<string, StudentWithDXCJ>(con, null).QueryObjects;
            if (items != null && items.Count == 1)
            {
                var dxcj = items[0];
                if (dxcj.Scores != null && dxcj.Scores.Count > 0)
                {
                    for (int i = 0; i < dxcj.Scores.Count; i++)
                    {
                        var item = dxcj.Scores[i];
                        var row = dataGridView1.Rows.Add();
                        dataGridView1.Rows[row].Tag = item;
                        dataGridView1.Rows[row].Cells["colIndex"].Value = dataGridView1.Rows.Count;
                        dataGridView1.Rows[row].Cells["colScore"].Value = item.FormatScore;
                        if (AppSettings.Current.Operator.PermitAny(Permission.总分, PermissionActions.Read))
                        {
                            if (item.Result.HasValue) dataGridView1.Rows[row].Cells["colResult"].Value = item.Result.Value.Trim();
                        }
                        dataGridView1.Rows[row].Cells["colRecordDate"].Value = item.TestTime.ToString("yyyy-MM-dd HH:mm:ss");
                        dataGridView1.Rows[row].Cells["colDevice"].Value = item.DeviceSn;
                        dataGridView1.Rows[row].Cells["colHost"].Value = item.HostID;
                        dataGridView1.Rows[row].Cells["colScoreSer"].Value = item.ScoreSer;
                        dataGridView1.Rows[row].Cells["colScoreFrom"].Value = item.ScoreFrom.ToString();
                        dataGridView1.Rows[row].Cells["col备注"].Value = item.Memo;
                        if (item.ID == dxcj.BestScoreID)
                        {
                            dataGridView1.Rows[row].Cells["colCurrent"].Value = "当前成绩";
                            dataGridView1.Rows[row].DefaultCellStyle.ForeColor = Color.Blue;
                        }
                        else
                        {
                            if (PhysicalItem.TestCount > 0 && item.SpecialType != SpecialScoreType.作废 && dxcj.Scores.Take(i + 1).Count(it => it.SpecialType != SpecialScoreType.作废) > PhysicalItem.TestCount)
                            {
                                dataGridView1.Rows[row].Cells["colCurrent"].Value = "重复测试";
                                dataGridView1.Rows[row].DefaultCellStyle.ForeColor = Color.Red;
                            }
                            else if (item.SpecialType == SpecialScoreType.作废)
                            {
                                dataGridView1.Rows[row].DefaultCellStyle.ForeColor = Color.Red;
                            }
                            else
                            {
                                dataGridView1.Rows[row].DefaultCellStyle.ForeColor = Color.Black;
                            }
                        }
                        dataGridView1.Rows[row].Selected = false;
                    }
                }
            }
        }

        private void mnu_DelScore_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否删除所选的成绩?", "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                List<StudentScore> deling = new List<StudentScore>();
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    deling.Add(row.Tag as StudentScore);
                }
                if (deling.Count > 0)
                {
                    CommandResult ret = new APIClient(AppSettings.Current.ConnStr).BatchDelete<long, StudentScore>(deling, AppSettings.Current.PhysicalProject.ID);
                    if (ret.Result == ResultCode.Successful)
                    {
                        ShowScores();
                    }
                    else
                    {
                        MessageBox.Show(ret.Message, "出错", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void mnu_Add_Click(object sender, EventArgs e)
        {
            //var frm = new Frm增加成绩();
            //frm.Student = Student;
            //frm.PhysicalItem = PhysicalItem;
            //frm.StartPosition = FormStartPosition.CenterParent;
            //if (frm.ShowDialog() == DialogResult.OK)
            //{
            //    ShowScores();
            //}
        }

        private void mnu_Update_Click(object sender, EventArgs e)
        {
            //if (dataGridView1.SelectedRows.Count == 1)
            //{
            //    var frm = new Frm修改成绩();
            //    frm.StartPosition = FormStartPosition.CenterParent;
            //    frm.Student = Student;
            //    frm.PhysicalItem = PhysicalItem;
            //    frm.StudentScore = dataGridView1.SelectedRows[0].Tag as StudentScore;
            //    if (frm.ShowDialog() == DialogResult.OK)
            //    {
            //        ShowScores();
            //    }
            //}
        }

        private void mnu犯规_Click(object sender, EventArgs e)
        {
            DoSpecialScore(SpecialScoreType.犯规);
        }

        private void mnu未完成_Click(object sender, EventArgs e)
        {
            DoSpecialScore(SpecialScoreType.未完成);
        }

        private void mnu作废_Click(object sender, EventArgs e)
        {
            DoSpecialScore(SpecialScoreType.作废);
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

        private void DoSpecialScore(SpecialScoreType spt)
        {
            if (MessageBox.Show("是否要将成绩设置为 " + spt.ToString() + " ?", "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var patches = new List<UpdateItem<long>>();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Selected)
                    {
                        var score = row.Tag as StudentScore;
                        if (score.SpecialType == null || score.SpecialType != spt)
                        {
                            patches.Add(new UpdateItem<long>() { ID = score.ID, Key = "State", Value = ((int)spt).ToString() });
                        }
                    }
                }
                if (patches.Count > 0)
                {
                    CommandResult ret = new APIClient(AppSettings.Current.ConnStr).BatchPatch<long, StudentScore>(patches, AppSettings.Current.PhysicalProject.ID);
                    if (ret.Result == ResultCode.Successful)
                    {
                        ShowScores();
                    }
                    else
                    {
                        MessageBox.Show(ret.Message, "出错", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void mnu成绩仲裁_Click(object sender, EventArgs e)
        {
            //if (dataGridView1.SelectedRows.Count == 1)
            //{
            //    var frm = new FrmDiscussionDetail();
            //    frm.IsAdding = true;
            //    frm.Student = Student;
            //    frm.Score = dataGridView1.SelectedRows[0].Tag as StudentScore;
            //    frm.StartPosition = FormStartPosition.CenterParent;
            //    var dig = frm.ShowDialog();
            //    ShowScores();
            //}
        }
        #endregion


    }
}
