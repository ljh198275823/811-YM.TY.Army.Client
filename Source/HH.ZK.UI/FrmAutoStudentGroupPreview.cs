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
using HH.ZK.CommonUI;
using HH.ZK.WebAPIClient;
using LJH.GeneralLibrary;
using HH.Zhongkao.Device.Reader;
using LJH.GeneralLibrary.CardReader;
using LJH.GeneralLibrary.Speech;

namespace HH.ZK.UI
{
    public partial class FrmAutoStudentGroupPreview : Form
    {
        public FrmAutoStudentGroupPreview()
        {
            InitializeComponent();
        }

        #region 私有变量
        private StudentGroup _CurrentGroup = null;
        #endregion

        #region 公共属性
        public List<StudentGroup> StudentGroups { get; set; }
        public Dictionary<string,Student> Students { get; set; }
        #endregion

        #region 私有方法
        private List<StudentGroup> FilterGroup()
        {
            var ret = (from it in StudentGroups
                       orderby it.PlanDate ascending, it.FacilityName ascending, it.Sex ascending, it.PhysicalItems ascending, it.Number ascending
                       select it).ToList();
            var pid = cmbPhysicalItem.SelectedPhysicalItem; ;
            if (pid > 0)
            {
                if (ret != null && ret.Count > 0) ret = ret.Where(it => it.包函考试科目(pid.ToString())).ToList();
            }
            if (!string.IsNullOrEmpty(txtGroupID.Text))
            {
                if (ret != null && ret.Count > 0) ret = ret.Where(it => it.FullName.Contains(txtGroupID.Text)).ToList();
            }
            return ret;
        }

        private void ShowGroupsOnGrid(List<StudentGroup> gps)
        {
            this.groupView.Rows.Clear();
            if (gps != null && gps.Count > 0)
            {
                foreach (var gp in gps)
                {
                    int row = groupView.Rows.Add();
                    groupView.Rows[row].Selected = false;
                    ShowGroupOnRow(groupView.Rows[row], gp);
                }
            }
            lblGroupCount.Text = string.Format("共 {0} 项", groupView.Rows.Count);
        }

        private void UpdateGroupRow(StudentGroup sg)
        {
            foreach (DataGridViewRow row in groupView.Rows)
            {
                if (object.ReferenceEquals(row.Tag, sg)) ShowGroupOnRow(row, sg);
            }
        }

        private void ShowGroupOnRow(DataGridViewRow row, StudentGroup sg)
        {
            row.Cells["col考试时间"].Value = sg.PlanDate;
            row.Cells["colPhysicalItem"].Value = AppSettings.Current.PhysicalProject.PhysicalItems?.GetNames(sg.PhysicalItems);
            row.Cells["colFacilityName"].Value = sg.FacilityName;
            row.Cells["col性别"].Value = sg.Sex == null ? null : (sg.Sex == Sex.Male ? "男子" : "女子");
            row.Cells["colNumber"].Value = sg.Number;
            row.Cells["colCount"].Value = sg.ItemsCount;
            row.Tag = sg;
        }

        private void ShowCurrentGroup(StudentGroup sg)
        {
            _CurrentGroup = sg;
            studentView.Rows.Clear();
            if (sg.Items != null && sg.ItemsCount > 0)
            {
                foreach (var it in sg.Items.OrderBy(it => it.Channel))
                {
                    var student = this.Students.ContainsKey(it.StudentID) ? this.Students[it.StudentID] : null;
                    //将信息显示在网格中
                    if (student != null)
                    {
                        int row = studentView.Rows.Add();
                        ShowGroupPairOnRow(studentView.Rows[row], student, it);
                    }
                }
            }
            lblCount.Text = string.Format("共 {0} 项", studentView.Rows.Count);
        }

        private void ShowGroupPairOnRow(DataGridViewRow row,Student s, StudentGroupPair gp)
        {
            row.Tag = gp;
            row.Cells["colChannel"].Value = gp.Channel;
            row.Cells["colID"].Value = s.ID;
            row.Cells["colFacility"].Value = s.FacilityName;
            row.Cells["colName"].Value = s.Name;
            row.Cells["colSex"].Value = s.Sex == Sex.Male ? "男" : "女";
            row.Cells["colIDNumber"].Value = s.IDNumber;
            row.Cells ["col考试科目"].Value = AppSettings.Current.PhysicalProject.PhysicalItems?.GetNames(s.PhysicalItems);
            row.Cells["colClassName"].Value = s.ClassName;
        }
        #endregion

        #region 事件处理程序
        private void FrmMain_Load(object sender, EventArgs e)
        {
            ShowGroupsOnGrid(FilterGroup());
            cmbPhysicalItem.Init(AppSettings.Current.PhysicalProject);
        }

        private void FreshData_Clicked(object sender, EventArgs e)
        {
            ShowGroupsOnGrid(FilterGroup());
        }

        private void groupView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                StudentGroup sg = groupView.Rows[e.RowIndex].Tag as StudentGroup;
                ShowCurrentGroup(sg);
            }
        }

        private void studentView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (studentView.Columns[e.ColumnIndex].Name == "colChannel")
                {
                    var pair = studentView.Rows[e.RowIndex].Tag as StudentGroupPair;
                    int ch = 0;
                    if (studentView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null && int.TryParse(studentView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), out ch))
                    {
                        pair.Channel = ch;
                    }
                    else
                    {
                        studentView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = pair.Channel;
                    }
                }
            }
        }

        private void 删除所选分组ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (groupView.SelectedRows == null || groupView.SelectedRows.Count == 0) return;
            if (MessageBox.Show("是否删除所选的分组?", "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                List<DataGridViewRow> delingRows = new List<DataGridViewRow>();
                foreach (DataGridViewRow row in groupView.SelectedRows)
                {
                    StudentGroup group = row.Tag as StudentGroup;
                    StudentGroups.Remove(group);
                }
                if (delingRows.Count > 0) delingRows.ForEach(it => groupView.Rows.Remove(it));
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (StudentGroups == null || StudentGroups.Count == 0) return;
            int count = 0;
            int success = 0;
            int fail = 0;
            FrmProcessing frm = new FrmProcessing();
            Action action = delegate()
            {
                List<StudentGroup> temp = new List<StudentGroup>();
                foreach (var g in StudentGroups)
                {
                    count++;
                    temp.Add(g);
                    if (temp.Count >= 50 || count == StudentGroups.Count)
                    {
                        CommandResult ret = new APIClient(AppSettings.Current.ConnStr).BatchAdd<Guid, StudentGroup>(temp, ImportOption.Override, AppSettings.Current.PhysicalProject.ID);
                        if (ret.Result == ResultCode.Successful)
                        {
                            success += temp.Count;
                        }
                        else
                        {
                            fail += temp.Count;
                        }
                        temp.Clear();
                        frm.ShowProgress(string.Empty, (decimal)count / StudentGroups.Count);
                    }
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
            if (fail > 0)
            {
                MessageBox.Show(string.Format("共导入成功{0}条数据 失败{1}条数据", success, fail), "结果");
            }
            else
            {
                MessageBox.Show(string.Format("共导入成功{0}条数据", success), "结果");
            }
        }
        #endregion
    }
}
