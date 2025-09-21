using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using HH.ZK.Model;
using HH.ZK.Model.CRM;
using HH.ZK.WebAPIClient;
using LJH.GeneralLibrary;
using LJH.GeneralLibrary;

namespace HH.ZK.UI
{
    public partial class Frm学生成绩速录 : Form
    {
        public Frm学生成绩速录()
        {
            InitializeComponent();
        }

        private StudentWithTotal _SeletectedStudent = null;

        #region 私有方法
        public void ShowSelectedStudent(string sid)
        {
            var s = new APIClient(AppSettings.Current.ConnStr).GetByID<string, StudentWithTotal>(sid, AppSettings.Current.PhysicalProject.ID).QueryObject;
            if (s != null)
            {
                _txtID.Text = s.ID;
                ShowStudentScores(s);
            }
            else ClearStudent();
        }

        private void ShowStudentScores(StudentWithTotal s)
        {
            _SeletectedStudent = s;
            _txtName.Text = s.Name;
            _rdMale.Checked = s.Gender == Gender.Male;
            _rdFemale.Checked = s.Gender == Gender.Female;
            this.scoreView.Rows.Clear();
            //foreach (var pid in s.获取所有考试科目())
            //{
            //    var pi = AppSettings.Current.PhysicalProject.PhysicalItems?.GetPhysicalItem(pid);
            //    if (pi == null) continue;
            //    int row = scoreView.Rows.Add();
            //    scoreView.Rows[row].Cells["colPhysicalItem"].Value = $"{pi.Name}({pi.Unit})";
            //    scoreView.Rows[row].Cells["colPhysicalItem"].Tag = pi;
            //    var ps = s.Scores.SingleOrDefault(it => it.PhysicalItemID == pid);
            //    if (ps != null)
            //    {
            //        scoreView.Rows[row].Cells["colScore"].Tag = ps;
            //        scoreView.Rows[row].Cells["colScore"].Value = ps.FormatScore;
            //        if (AppSettings.Current.Operator.PermitAny(Permission.总分, PermissionActions.Read))
            //        {
            //            scoreView.Rows[row].Cells["colResult"].Value = ps.Result != null ? ps.Result.Value.Trim().ToString() : null;
            //        }
            //    }
            //    scoreView.Rows[row].Cells["colAddScore"].Value = null;
            //    scoreView.Rows[row].Cells["colAddScore"].ReadOnly = !AppSettings.Current.Operator.PermitAny(Permission.StudentScore, PermissionActions.Edit);
            //    scoreView.Rows[row].DefaultCellStyle.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            //    scoreView.Rows[row].Height = 50;
            //}
            if (AppSettings.Current.Operator.PermitAny(Permission.总分, PermissionActions.Read))
            {
                int total = scoreView.Rows.Add();
                scoreView.Rows[total].Cells["colPhysicalItem"].Value = "总分";
                scoreView.Rows[total].Cells["colResult"].Value = s.Total > 0 ? s.Total : 0;
                scoreView.Rows[total].Cells["colAddScore"].ReadOnly = true;
                scoreView.Rows[total].DefaultCellStyle.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                scoreView.Rows[total].Height = 50;
            }
        }

        private void ClearStudent()
        {
            _SeletectedStudent = null;
            _txtName.Text = null;
            _rdMale.Checked = false;
            _rdFemale.Checked = false;
            this.scoreView.Rows.Clear();
        }
        #endregion

        #region 事件处理程序
        private void Frm学生成绩速录_Load(object sender, EventArgs e)
        {
            btnSave.Enabled = AppSettings.Current.Operator.PermitAll(Permission.StudentScore, PermissionActions.Edit);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_txtID.Text.Trim()))
            {
                var s = new APIClient(AppSettings.Current.ConnStr).GetByID<string, StudentWithTotal>(_txtID.Text.Trim(), AppSettings.Current.PhysicalProject.ID).QueryObject;
                if (s != null) ShowStudentScores(s);
                else ClearStudent();
            }
        }

        private void scoreView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (_SeletectedStudent == null || AppSettings.Current.PhysicalProject == null)
            {
                e.Cancel = true;
                return;
            }
            if (!AppSettings.Current.Operator.PermitAll(Permission.StudentScore, PermissionActions.Edit))
            {
                e.Cancel = true;
                return;
            }
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                e.Cancel = true;
                return;
            }
            if (_SeletectedStudent == null)
            {
                e.Cancel = true;
                return;
            }
        }

        private void scoreView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (_SeletectedStudent == null) return;
            DataGridViewRow row = scoreView.Rows[e.RowIndex];
            if (row.Cells["colPhysicalItem"].Tag == null) return;
            PhysicalItem pi = row.Cells["colPhysicalItem"].Tag as PhysicalItem;
            var value = row.Cells[e.ColumnIndex].Value;
            if (value != null && !string.IsNullOrEmpty(value.ToString()))
            {
                decimal score = 0;
                if (!pi.TryParse(value.ToString(), out score))
                {
                    MessageBox.Show("不能识别的成绩格式");
                    row.Cells[e.ColumnIndex].Value = string.Empty;
                    return;
                }
                if ((pi.Min != null && score < pi.Min.Value) || (pi.Max != null && score > pi.Max.Value))
                {
                    MessageBox.Show("成绩不在范围内");
                    row.Cells[e.ColumnIndex].Value = string.Empty;
                    return;
                }
                var raw = new StudentRawScore()
                {
                    ID = Guid.NewGuid(),
                    TestID = pi.ID,
                    StudentID = _SeletectedStudent.ID,
                    ScoreFrom = ScoreSource.手工录入,
                    Score = score.ToString (),
                    CreateTime = DateTime.Now,
                };
                row.Cells[e.ColumnIndex].Tag = raw;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<StudentRawScore> scores = new List<StudentRawScore>();
            foreach (DataGridViewRow row in scoreView.Rows)
            {
                if (row.Cells["colAddScore"].Tag != null) scores.Add(row.Cells["colAddScore"].Tag as StudentRawScore);
            }
            if (scores.Count > 0)
            {
                var ret = new APIClient(AppSettings.Current.ConnStr).BatchAddScores(scores, ImportOption.Append, AppSettings.Current.PhysicalProject.ID);
                if (ret.Result == ResultCode.Successful && ret.Value.Successes != null && ret.Value.Successes.Count > 0)
                {
                    _SeletectedStudent = new APIClient(AppSettings.Current.ConnStr).GetByID<string, StudentWithTotal>(_SeletectedStudent.ID, AppSettings.Current.PhysicalProject.ID).QueryObject;
                    if (_SeletectedStudent != null) ShowStudentScores(_SeletectedStudent);
                    _txtID.Focus();
                    _txtID.SelectAll();
                }
                else
                {
                    MessageBox.Show(ret.Message);
                }
            }
        }
        #endregion
    }
}
