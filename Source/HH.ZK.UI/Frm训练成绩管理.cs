using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using HH.ZK.Model;
using HH.ZK.Model.SearchCondition;
using HH.ZK.Model.CRM;
using HH.ZK.CommonUI;
using HH.ZK.WebAPIClient;
using LJH.GeneralLibrary;
using LJH.GeneralLibrary.WinForm;

namespace HH.ZK.UI
{
    public partial class Frm训练成绩管理 : FrmReportBaseWithPaging<string, StudentWithTotal>
    {
        public Frm训练成绩管理()
        {
            InitializeComponent();
        }

        #region 私有变量
        private Project _Project = null;
        private List<DataGridViewColumn> _ScoreCols = new List<DataGridViewColumn>();
        private List<DataGridViewColumn> _ResultCols = new List<DataGridViewColumn>();
        #endregion

        #region 私有方法
        private void AddScoreColumn(PhysicalItem pi)
        {
            if (!_ScoreCols.Exists(col => (col.Tag as PhysicalItem).ID == pi.ID))
            {
                DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
                col.Name = string.Format("col_{0}", pi.ID);
                col.Tag = pi;
                col.MinimumWidth = 60;
                col.Width = 60;
                col.ReadOnly = true;
                col.SortMode = DataGridViewColumnSortMode.Automatic;
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
                col.HeaderText = string.Format("{0}", pi.Name);
                dataGridView1.Columns.Add(col);
                _ScoreCols.Add(col);
            }
        }

        private void AddResultColumn(PhysicalItem pi)
        {
            if (!_ResultCols.Exists(col => (col.Tag as PhysicalItem).ID == pi.ID))
            {
                DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
                col.Name = string.Format("col_{0}_Result", pi.ID);
                col.Tag = pi;
                col.MinimumWidth = 60;
                col.Width = 60;
                col.ReadOnly = true;
                col.SortMode = DataGridViewColumnSortMode.Automatic;
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                col.HeaderText = string.Format("{0}得分", pi.Name);
                dataGridView1.Columns.Add(col);
                _ResultCols.Add(col);
            }
        }

        private List<StudentPhysicalPair> GetSelectedScores()
        {
            List<StudentPhysicalPair> items = new List<StudentPhysicalPair>();
            foreach (DataGridViewCell cell in GridView.SelectedCells)
            {
                if (dataGridView1.Columns[cell.ColumnIndex].Tag == null) continue;
                var s = dataGridView1.Rows[cell.RowIndex].Tag as StudentWithTotal;
                var pi = dataGridView1.Columns[cell.ColumnIndex].Tag as PhysicalItem;
                if (s != null && pi != null) items.Add(new StudentPhysicalPair() { StudentID = s.ID, TestID = pi.ID });
            }
            return items;
        }

        private void DeleteScores(List<StudentPhysicalPair> items)
        {
            FrmProcessing frm = new FrmProcessing();
            Action action = delegate ()
            {
                try
                {
                    List<StudentPhysicalPair> temp = new List<StudentPhysicalPair>();
                    for (int i = 0; i < items.Count; i++)
                    {
                        temp.Add(items[i]);
                        if (temp.Count >= 100 || i == items.Count - 1)
                        {
                            CommandResult ret = new APIClient(AppSettings.Current.ConnStr).BatchDeleteScores(temp, AppSettings.Current.PhysicalProject.ID);
                            frm.ShowProgress(string.Empty, (decimal)(i + 1) / items.Count);
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

        private List<StudentWithTotal> GetSelectedStudents()
        {
            var students = new Dictionary<string, StudentWithTotal>();
            foreach (DataGridViewCell cell in GridView.SelectedCells)
            {
                var student = GridView.Rows[cell.RowIndex].Tag as StudentWithTotal;
                if (!students.ContainsKey(student.ID)) students.Add(student.ID, student);
            }
            return students.Values.ToList();
        }

        private void DeleteStudents(List<StudentWithTotal> students)
        {
            FrmProcessing frm = new FrmProcessing();
            Action action = delegate ()
            {
                try
                {
                    List<Student> temp = new List<Student>();
                    for (int i = 0; i < students.Count; i++)
                    {
                        temp.Add(students[i]);
                        if (temp.Count >= 50 || i == students.Count - 1)
                        {
                            CommandResult ret = new APIClient(AppSettings.Current.ConnStr).BatchDelete<string, Student>(temp, AppSettings.Current.PhysicalProject.ID);
                            frm.ShowProgress(string.Empty, (decimal)(i + 1) / students.Count);
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

        private void SetState(List<StudentWithTotal> students, StudentState state)
        {
            int fail = 0;
            FrmProcessing frmP = new FrmProcessing();
            Action action = delegate ()
            {
                try
                {
                    List<Student> temp = new List<Student>();
                    for (int i = 0; i < students.Count; i++)
                    {
                        temp.Add(students[i]);
                        if (i == students.Count - 1 || temp.Count == 100)
                        {
                            var patchs = temp.Select(it => new UpdateItem<string>() { ID = it.ID, Key = "State", Value = ((int)state).ToString() }).ToList();
                            var ret = new WebAPIClient.APIClient(AppSettings.Current.ConnStr).BatchPatch<string, Student>(patchs, AppSettings.Current.PhysicalProject.ID);
                            if (ret.Result == ResultCode.Successful && ret.Value != null && ret.Value.Successes != null)
                            {
                                foreach (var s in temp)
                                {
                                    if (ret.Value.Successes.ContainsKey(s.ID))
                                    {
                                        var newVal = ret.Value.Successes[s.ID];
                                        s.State = newVal.State;
                                        //s.UpdateDate = newVal.UpdateDate;
                                    }
                                }
                            }
                            if (ret.Result == ResultCode.Successful && ret.Value != null && ret.Value.Errors != null) fail += ret.Value.Errors.Count;
                            else if (ret.Result == ResultCode.Fail) fail += temp.Count;
                            temp.Clear();
                            if (fail == 0) frmP.ShowProgress(string.Empty, (decimal)(i + 1) / students.Count);
                            else frmP.ShowProgressEX($"失败 {fail} 条", (decimal)(i + 1) / students.Count);
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
        }
        #endregion

        #region 重写基类方法
        protected override DataGridView GridView => this.dataGridView1;

        protected override void Init()
        {
            base.Init();
            ucStudentSearch1.Init();
            txtProject.Init();
        }

        public override void ShowOperatorRights()
        {
            base.ShowOperatorRights();
            btnSearch.Enabled = AppSettings.Current.Operator.PermitAny(Permission.StudentScore, PermissionActions.Read);
            btnSaveAs.Enabled = AppSettings.Current.Operator.PermitAny(Permission.StudentScore, PermissionActions.Read);
            mnu删除所选成绩.Enabled = AppSettings.Current.Operator.PermitAny(Permission.StudentScore, PermissionActions.Delete);
            mnu设置学生类别.Enabled = AppSettings.Current.Operator.PermitAny(Permission.Student, PermissionActions.Edit);
        }

        protected override QueryResultList<StudentWithTotal> GetDataSource(int pageSize, int pageIndex)
        {
            if(txtProject.SelectedProject == null)
            {
                MessageBox.Show("没有选择大纲");
                return null;
            }
            var con = new StudentWithTotalSearchCondition();
            ucStudentSearch1.GetSearchCondition(con);
            con.ProjectID = txtProject.SelectedProjectID;
            con.DateRange = new DateTimeRange(dt开始训练日期.Value.Date, dt结束训练日期.Value.Date);
            con.PageIndex = pageIndex;
            con.PageSize = pageSize;

            if (!rd全部.Checked)
            {
                con.TestStates = new List<TestCompleteState>();
                if (rd测试完成.Checked) con.TestStates.Add(TestCompleteState.全部完成);
                if (rd未测试.Checked) con.TestStates.Add(TestCompleteState.未测试);
                if (rd没有完成测试.Checked) con.TestStates.Add(TestCompleteState.部分科目完成);
            }
            var ret = new APIClient(AppSettings.Current.ConnStr).GetList<string, StudentWithTotal>(con, null);
            return ret;
        }

        protected override void ShowItemInGridViewRow(DataGridViewRow row, StudentWithTotal s)
        {
            row.Tag = s;
            row.Cells["colID"].Value = s.ID;
            row.Cells["colName"].Value = s.Name;
            row.Cells["colSex"].Value = s.Gender == Gender.Male ? "男" : "女";
            row.Cells["colFacility"].Value = s.DivisionName;
            row.Cells["col训练日期"].Value = s.TestDate.ToString("yyyy-MM-dd");
            row.Cells["col训练大纲"].Value = s.ProjectName;
            if (s.State != StudentState.正常) row.Cells["col状态"].Value = s.State.ToString();
            if (AppSettings.Current.Operator.PermitAll(Permission.总分, PermissionActions.Read)) row.Cells["col总分"].Value = s.Total;
            foreach (DataGridViewColumn col in _ScoreCols)
            {
                row.Cells[col.Index].ReadOnly = true;
                var pi = col.Tag as PhysicalItem;
                if (pi.Gender == 1 && s.Gender == Gender.Female) continue;
                if (pi.Gender == 2 && s.Gender == Gender.Male) continue;
                var score = s.Scores != null ? s.Scores.SingleOrDefault(it => it.TestID == pi.ID) : null;
                if (score == null) row.Cells[col.Index].Style.BackColor = Color.Moccasin;
                else
                {
                    row.Cells[col.Index].Tag = score;
                    ShowScoreCell(row.Cells[col.Index], score);
                    row.Cells[col.Index].Style.BackColor = Color.White;
                    foreach (var rcol in _ResultCols)
                    {
                        if ((rcol.Tag as PhysicalItem).ID == pi.ID && score.Result.HasValue) row.Cells[rcol.Index].Value = score.Result.Value.Trim();
                    }
                }
            }
        }

        private void ShowScoreCell(DataGridViewCell cell, StudentScoreExpress score)
        {
            //这么做主要是为了列的排序
            decimal temp;
            if (!string.IsNullOrEmpty(score.FormatScore) && decimal.TryParse(score.FormatScore, out temp)) cell.Value = temp; //能转化成实数，显示实数
            else cell.Value = score.FormatScore; //否则显示格式化成绩
        }
        #endregion

        #region 事件处理程序
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!AppSettings.Current.Operator.PermitAll(Permission.StudentScore, PermissionActions.Read)) return;
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (this.dataGridView1.Rows[e.RowIndex].Tag == null) return;
            var col = dataGridView1.Columns[e.ColumnIndex];
            if (_ScoreCols.Contains(col) == false) return;
            if (col.Tag is PhysicalItem)
            {
                var student = this.dataGridView1.Rows[e.RowIndex].Tag as StudentWithTotal;
                PhysicalItem pi = col.Tag as PhysicalItem;
                if (pi.Gender == 1 && student.Gender == Gender.Female) return;
                if (pi.Gender == 2 && student.Gender == Gender.Male) return;
                FrmStudentScoreDetailView frm = new FrmStudentScoreDetailView();
                frm.Student = new StudentInProject() { StudentID = student.ID, ProjectID = student.ProjectID, TestDate = student.TestDate };
                frm.PhysicalItem = pi;
                frm.ShowDialog();
                var temp = new APIClient(AppSettings.Current.ConnStr).GetByID<string, StudentWithTotal>(student.ID, AppSettings.Current.PhysicalProject.ID).QueryObject;
                if (temp != null) ShowItemInGridViewRow(this.dataGridView1.Rows[e.RowIndex], temp);
            }
        }

        private void mnu删除所选成绩_Click(object sender, EventArgs e)
        {
            var items = GetSelectedScores();
            if (items.Count == 0) return;
            if (MessageBox.Show("是否删除所选的学生成绩?", "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            DeleteScores(items);
        }
        #endregion

        private void txtProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_ScoreCols != null && _ScoreCols.Count > 0)
            {
                _ScoreCols.ForEach(it => dataGridView1.Columns.Remove(it));
                _ScoreCols.Clear();
            }
            if (_ResultCols != null && _ResultCols.Count > 0)
            {
                _ResultCols.ForEach(it => dataGridView1.Columns.Remove(it));
                _ResultCols.Clear();
            }
            var sp = SysParaSettingsClient.GetOrCreateSetting<PhysicalItemSettings>(AppSettings.Current.ConnStr, txtProject.SelectedProjectID);
            if (sp != null && sp.Items != null && sp.Items.Count > 0)
            {
                foreach (var pi in sp.Items)
                {
                    AddScoreColumn(pi);
                    AddResultColumn(pi);
                }
            }
        }
    }
}
