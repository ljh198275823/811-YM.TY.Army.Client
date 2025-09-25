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
    public partial class Frm训练计划管理 : FrmReportBaseWithPaging<string, Student>
    {
        public Frm训练计划管理()
        {
            InitializeComponent();
        }

        #region 私有变量
        private List<DataGridViewColumn> _DateCols = new List<DataGridViewColumn>();

        private Dictionary<string, List<StudentInProject>> _DicStudentInProject = new Dictionary<string, List<StudentInProject>>();
        #endregion

        #region 私有方法
        private void InitDateColumns(DateTime begin, DateTime end)
        {
            foreach (var col in _DateCols)
            {
                dataGridView1.Columns.Remove(col);
            }
            _DateCols.Clear();
            var dt = begin;
            while (dt <= end)
            {
                AddScoreColumn(dt);
                dt = dt.AddDays(1);
            }
        }

        private void AddScoreColumn(DateTime dt)
        {
            DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
            col.Name = string.Format("col_{0}", dt.ToString("yyyyMMdd"));
            col.Tag = dt;
            col.MinimumWidth = 60;
            col.Width = 60;
            col.ReadOnly = true;
            col.SortMode = DataGridViewColumnSortMode.NotSortable;
            col.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            col.HeaderText = $"{dt.ToString("MM月dd日")} {获取星期(dt)}";
  
            col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            if(dt.DayOfWeek == DayOfWeek.Saturday || dt.DayOfWeek == DayOfWeek.Sunday)
            {
                col.DefaultCellStyle.BackColor = Color.Orange;
            }
            dataGridView1.Columns.Add(col);
            _DateCols.Add(col);
        }

        private string 获取星期(DateTime dt)
        {
            if (dt.DayOfWeek == DayOfWeek.Sunday) return "日";
            if (dt.DayOfWeek == DayOfWeek.Saturday) return "六";
            if (dt.DayOfWeek == DayOfWeek.Friday) return "五";
            if (dt.DayOfWeek == DayOfWeek.Thursday) return "四";
            if (dt.DayOfWeek == DayOfWeek.Wednesday) return "三";
            if (dt.DayOfWeek == DayOfWeek.Tuesday) return "二";
            if (dt.DayOfWeek == DayOfWeek.Monday) return "一";
            return null;
        }

        private List<Student> GetSelectedItems()
        {
            var dic = new Dictionary<int, Student>();
            if (GridView.SelectionMode == DataGridViewSelectionMode.FullRowSelect)
            {
                foreach (DataGridViewRow row in GridView.SelectedRows)
                {
                    if (dic.ContainsKey(row.Index) == false) dic.Add(row.Index, row.Tag as Student);
                }
            }
            else
            {
                foreach (DataGridViewCell cell in GridView.SelectedCells)
                {
                    if (dic.ContainsKey(cell.RowIndex) == false) dic.Add(cell.RowIndex, GridView.Rows[cell.RowIndex].Tag as Student);
                }
            }
            return dic.Values.ToList();
        }

        private void AddPlans(List<StudentInProject> items)
        {
            FrmProcessing frm = new FrmProcessing();
            Action action = delegate ()
            {
                try
                {
                    var temp = new List<StudentInProject>();
                    for (int i = 0; i < items.Count; i++)
                    {
                        temp.Add(items[i]);
                        if (temp.Count >= 100 || i == items.Count - 1)
                        {
                            CommandResult ret = new APIClient(AppSettings.Current.ConnStr).BatchAdd<Guid, StudentInProject>(temp, ImportOption.Ignore);
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

        private List<StudentInProject> GetSelectedPlans()
        {
            List<StudentInProject> items = new List<StudentInProject>();
            foreach (DataGridViewCell cell in GridView.SelectedCells)
            {
                if (cell.Tag is List<StudentInProject> temp)
                {
                    items.AddRange(temp);
                }
            }
            return items;
        }

        private void DeletePlans(List<StudentInProject> items)
        {
            FrmProcessing frm = new FrmProcessing();
            Action action = delegate ()
            {
                try
                {
                    var temp = new List<StudentInProject>();
                    for (int i = 0; i < items.Count; i++)
                    {
                        temp.Add(items[i]);
                        if (temp.Count >= 100 || i == items.Count - 1)
                        {
                            CommandResult ret = new APIClient(AppSettings.Current.ConnStr).BatchDelete<Guid, StudentInProject>(temp);
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
        #endregion

        #region 重写基类方法
        protected override DataGridView GridView => this.dataGridView1;

        protected override void Init()
        {
            base.Init();
            dt结束训练日期.Value = dt开始训练日期.Value.AddDays(6);
        }

        public override void ShowOperatorRights()
        {
            base.ShowOperatorRights();
            btnSearch.Enabled = AppSettings.Current.Operator.PermitAny(Permission.StudentScore, PermissionActions.Read);
            btnSaveAs.Enabled = AppSettings.Current.Operator.PermitAny(Permission.StudentScore, PermissionActions.Read);
            mnu删除所选计划.Enabled = AppSettings.Current.Operator.PermitAny(Permission.StudentScore, PermissionActions.Delete);
        }

        protected override QueryResultList<Student> GetDataSource(int pageSize, int pageIndex)
        {
            _DicStudentInProject.Clear();
            InitDateColumns(dt开始训练日期.Value.Date, dt结束训练日期.Value.Date);
            var con = new StudentSearchCondition();
            ucStudentSearch1.GetSearchCondition(con);
            con.PageIndex = pageIndex;
            con.PageSize = pageSize;
            var ret = new APIClient(AppSettings.Current.ConnStr).GetList<string, Student>(con, null);
            var ss = ret.QueryObjects;
            if (ss != null && ss.Count > 0)
            {
                FrmProcessing frm = new FrmProcessing();
                Action action = delegate ()
                {
                    try
                    {
                        for (int i = 0; i < ss.Count; i += 50)
                        {
                            frm.ShowProgress("数据查询", (decimal)(i) / ss.Count);
                            var rids = ss.Skip(i).Take(50).Select(it => it.ID).ToList();
                            var con1 = new StudentSearchCondition();
                            con1.StudentIDS = rids;
                            con1.DateRange = new DateTimeRange(dt开始训练日期.Value.Date, dt结束训练日期.Value.Date);
                            var tempSteps = new APIClient(AppSettings.Current.ConnStr).GetList<Guid, StudentInProject>(con1).QueryObjects;
                            if (tempSteps != null && tempSteps.Count > 0)
                            {
                                var gps = (from it in tempSteps group it by it.StudentID);
                                foreach (var gp in gps)
                                {
                                    _DicStudentInProject.Add(gp.Key, gp.ToList());
                                }
                            }
                        }
                        frm.ShowProgress(string.Empty, 1);
                    }
                    catch (ThreadAbortException)
                    {
                    }
                };

                Thread t = new Thread(new ThreadStart(action));
                t.IsBackground = true;
                t.Start();
                if (frm.ShowDialog() != DialogResult.OK)
                {
                    t.Abort();
                }
            }
            return ret;
        }

        protected override void ShowItemInGridViewRow(DataGridViewRow row, Student s)
        {
            row.Tag = s;
            row.Cells["colID"].Value = s.ID;
            row.Cells["colName"].Value = s.Name;
            row.Cells["colSex"].Value = s.Gender == Gender.Male ? "男" : "女";
            row.Cells["colFacility"].Value = s.DivisionName;
            foreach (DataGridViewColumn col in _DateCols)
            {
                if (_DicStudentInProject.ContainsKey(s.ID))
                {
                    var date = Convert.ToDateTime(col.Tag);
                    var items = _DicStudentInProject[s.ID].Where(it => it.TestDate == date).ToList();
                    string str = null;
                    if (items != null && items.Count > 0) str = string.Join(",", items.Select(it => (!string.IsNullOrEmpty(it.ProjectShortName) ? it.ProjectShortName : it.ProjectName)));
                    row.Cells[col.Name].Value = str;
                    row.Cells[col.Name].Tag = items;
                }
            }
        }
        #endregion

        #region 事件处理程序
        private void btn设置训练计划_Click(object sender, EventArgs e)
        {
            List<Student> students = GetSelectedItems();
            if (students.Count == 0) return;
            var frm = new Frm设置训练计划();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.Students = students;
            frm.DateRange = new DateTimeRange(dt开始训练日期.Value.Date, dt结束训练日期.Value.Date);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                AddPlans(frm.CreatedItems);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void mnu删除所选成绩_Click(object sender, EventArgs e)
        {
            var items = GetSelectedPlans();
            if (items.Count == 0) return;
            if (MessageBox.Show("是否删除所人员测试计划?", "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            DeletePlans(items);
        }
        #endregion
    }
}
