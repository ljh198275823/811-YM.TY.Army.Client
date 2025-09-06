using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Data;
using System.Threading;
using System.Windows.Forms;
using HH.ZK.Model;
using HH.ZK.Model.CRM;
using HH.ZK.Model.SearchCondition;
using HH.ZK.CommonUI;
using HH.ZK.WebAPIClient;
using LJH.GeneralLibrary;

namespace HH.ZK.UI
{
    public partial class FrmStudentGroup : Form, LJH.GeneralLibrary.WinForm.IFormMaster
    {
        public FrmStudentGroup()
        {
            InitializeComponent();
        }

        #region 私有变量
        private List<StudentGroupSummary> _Groups = new List<StudentGroupSummary>();
        #endregion

        #region 私有方法
        public void ShowOperatorRights()
        {
            var cur = AppSettings.Current.Operator;
            btn导入分组.Enabled = cur.PermitAny(Permission.StudentGroup, PermissionActions.Edit);
            btn自动分组.Enabled = cur.PermitAny(Permission.StudentGroup, PermissionActions.Edit);

            mnu增加分组.Enabled = cur.PermitAny(Permission.StudentGroup, PermissionActions.Edit);
            mnu修改分组.Enabled = cur.PermitAny(Permission.StudentGroup, PermissionActions.Edit);
            mnu导入分组.Enabled = cur.PermitAny(Permission.StudentGroup, PermissionActions.Edit);
            mnu删除所选分组.Enabled = cur.PermitAny(Permission.StudentGroup, PermissionActions.Delete);
            mnu设置考试时间.Enabled = cur.PermitAny(Permission.StudentGroup, PermissionActions.Edit);

            mnu_导出秩序册.Enabled = cur.PermitAny(Permission.StudentGroup, PermissionActions.Read);
            mnu导出准考证.Enabled = cur.PermitAny(Permission.StudentGroup, PermissionActions.Read);
        }

        private void InitStudentGroups()
        {
            _Groups.Clear();
            var con = new StudentGroupSearchCondition() { SortMode = SortMode.Asc };
            var items = new APIClient(AppSettings.Current.ConnStr).GetList<Guid, StudentGroupSummary>(con, AppSettings.Current.PhysicalProject.ID).QueryObjects;
            if (items != null && items.Count > 0) _Groups.AddRange(items);
        }

        private List<StudentGroupSummary> FilterGroup()
        {
            if (_Groups == null || _Groups.Count == 0) return null;
            var ret = _Groups.ToList();
            PhysicalItem sp = cmbPhysicalItem.SelectedItem as PhysicalItem;
            if (sp != null && sp.ID > 0)
            {
                if (ret != null && ret.Count > 0) ret = ret.Where(it => it.包函考试科目(sp.ID.ToString())).ToList();
            }
            if (!string.IsNullOrEmpty(txt考试时间.Text))
            {
                if (ret != null && ret.Count > 0) ret = ret.Where(it => !string.IsNullOrEmpty(it.PlanDate) && it.PlanDate.Contains(txt考试时间.Text)).ToList();
            }
            if (rdMale.Checked)
            {
                if (ret != null && ret.Count > 0) ret = ret.Where(it => it.Sex == Sex.Male).ToList();
            }
            if (rdFemale.Checked)
            {
                if (ret != null && ret.Count > 0) ret = ret.Where(it => it.Sex == Sex.Female).ToList();
            }
            if (!string.IsNullOrEmpty(cmbFacility.Text))
            {
                if (ret != null && ret.Count > 0) ret = ret.Where(it => it.FacilityID == cmbFacility.SelectedFacilityID).ToList();
            }
            else if (!string.IsNullOrEmpty(cmbDivision.Text))
            {
                List<Facility> fs = cmbFacility.DataSource as List<Facility>;
                if (fs != null)
                {
                    ret = ret.Where(it => fs.Exists(f => f.ID == it.FacilityID)).ToList();
                }
            }
            return ret;
        }

        private void InitPlanDate(List<StudentGroupSummary> gps)
        {
            var txt = txt考试时间.Text;
            txt考试时间.Items.Clear();
            if (gps != null && gps.Count > 0)
            {
                txt考试时间.Items.Add(string.Empty);
                var items = (from it in gps
                             where !string.IsNullOrEmpty(it.PlanDate)
                             orderby it.PlanDate ascending
                             select it.PlanDate).Distinct().ToList();
                foreach (var it in items)
                {
                    txt考试时间.Items.Add(it);
                }
            }
            txt考试时间.Text = txt;
        }

        private void ShowGroupsOnGrid(List<StudentGroupSummary> gps)
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

        private void ShowGroupOnRow(DataGridViewRow row, StudentGroupSummary sg)
        {
            row.Cells["col考试时间"].Value = sg.PlanDate;
            row.Cells["colPhysicalItem"].Value = AppSettings.Current.PhysicalProject.PhysicalItems?.GetNames(sg.PhysicalItems);
            row.Cells["colFacility"].Value = sg.FacilityName;
            row.Cells["col性别"].Value = sg.Sex == null ? null : (sg.Sex == Sex.Male ? "男子" : "女子");
            row.Cells["colNumber"].Value = sg.Number;
            row.Cells["colCount"].Value = sg.ItemsCount;
            row.Tag = sg;
        }

        private void ShowCurrentGroup(StudentGroupSummary sg)
        {
            studentView.Rows.Clear();
            if (sg.ItemsCount > 0)
            {
                var con = new StudentSearchCondition() { GroupID = sg.ID };
                var ss = new APIClient(AppSettings.Current.ConnStr).GetList<string, Student>(con, AppSettings.Current.PhysicalProject.ID).QueryObjects;
                if (ss != null && ss.Count > 0)
                {
                    foreach (var student in ss)
                    {
                        //将信息显示在网格中
                        if (student != null)
                        {
                            int row = studentView.Rows.Add();
                            ShowGroupPairOnRow(studentView.Rows[row], student);
                        }
                    }
                }
            }
            lblCount.Text = string.Format("共 {0} 项", studentView.Rows.Count);
        }

        private void ShowGroupPairOnRow(DataGridViewRow row, Student s)
        {
            row.Tag = s;
            row.Cells["colID"].Value = s.ID;
            row.Cells["colName"].Value = s.Name;
            row.Cells["colSex"].Value = s.Sex == Sex.Male ? "男" : "女";
            row.Cells["colClassName"].Value = s.ClassName;
            row.Cells["colChannel"].Value = s.Channel;
            row.Cells["col考试科目"].Value = AppSettings.Current.PhysicalProject.PhysicalItems?.GetNames(s.PhysicalItems);
            row.Cells["colCheckTime"].Value = s.CheckTime?.ToString("yyyy-MM-dd HH:mm:ss");
        }

        public void ReFreshData()
        {
            InitStudentGroups();
            var ret = FilterGroup();
            ShowGroupsOnGrid(ret);
            InitPlanDate(ret);
        }
        #endregion

        #region 菜单事件处理
        private void mnuFresh_Click(object sender, EventArgs e)
        {
            ReFreshData();
        }

        private void mnu导入分组_Click(object sender, EventArgs e)
        {
            btn导入分组.PerformClick();
        }

        private void mnu增加分组_Click(object sender, EventArgs e)
        {
            FrmStudentGroupDetail frm = new FrmStudentGroupDetail();
            frm.UpdatingItem = new StudentGroup() { ID = Guid.NewGuid() };
            frm.IsAdding = true;
            frm.ItemAdded += delegate (object o, LJH.GeneralLibrary.WinForm.ItemAddedEventArgs args)
            {
                foreach (DataGridViewRow r in groupView.SelectedRows)
                {
                    r.Selected = false;
                }
                int row = groupView.Rows.Add();
                ShowGroupOnRow(groupView.Rows[row], args.AddedItem as StudentGroup);
                groupView.Rows[row].Selected = true;
                ShowCurrentGroup(args.AddedItem as StudentGroupSummary);
                _Groups.Add(args.AddedItem as StudentGroupSummary);
                lblGroupCount.Text = string.Format("共 {0} 项", groupView.Rows.Count);
            };
            frm.ShowDialog();
        }

        private void mnu修改分组_Click(object sender, EventArgs e)
        {
            if (groupView.SelectedRows.Count != 1) return;
            var gps = groupView.SelectedRows[0].Tag as StudentGroupSummary;
            var gp = new APIClient(AppSettings.Current.ConnStr).GetByID<Guid, StudentGroup>(gps.ID, AppSettings.Current.PhysicalProject.ID).QueryObject;
            if (gp != null)
            {
                FrmStudentGroupDetail frm = new FrmStudentGroupDetail();
                frm.UpdatingItem = gp;
                frm.ItemUpdated += delegate (object o, LJH.GeneralLibrary.WinForm.ItemUpdatedEventArgs args)
                {
                    ShowGroupOnRow(groupView.SelectedRows[0], args.UpdatedItem as StudentGroupSummary);
                    ShowCurrentGroup(args.UpdatedItem as StudentGroupSummary);
                };
                frm.ShowDialog();
            }
        }

        private void mnu设置考试时间_Click(object sender, EventArgs e)
        {
            if (groupView.SelectedRows.Count == 0) return;
            List<StudentGroupSummary> sgs = new List<StudentGroupSummary>();
            foreach (DataGridViewRow r in groupView.Rows)
            {
                if (!r.Selected) continue;
                sgs.Add(r.Tag as StudentGroupSummary);
            }
            var dig = new Frm设置考试时间();
            dig.StartPosition = FormStartPosition.CenterParent;
            if (dig.ShowDialog() != DialogResult.OK) return;
            var 考试时间 = dig.考试时间;
            FrmProcessing frmP = new FrmProcessing();
            Action action = delegate ()
            {
                try
                {
                    List<StudentGroupSummary> temp = new List<StudentGroupSummary>();
                    for (int i = 0; i < sgs.Count; i++)
                    {
                        temp.Add(sgs[i]);
                        if (i == sgs.Count - 1 || temp.Count == 100)
                        {
                            var patchs = temp.Select(it => new UpdateItem<Guid>() { ID = it.ID, Key = "PlanDate", Value = 考试时间 }).ToList();
                            var ret = new APIClient(AppSettings.Current.ConnStr).BatchPatch<Guid, StudentGroup>(patchs, AppSettings.Current.PhysicalProject.ID);
                            if (ret.Result == ResultCode.Successful && ret.Value != null && ret.Value.Successes != null)
                            {
                                foreach (var s in temp)
                                {
                                    if (ret.Value.Successes.ContainsKey(s.ID))
                                    {
                                        var newVal = ret.Value.Successes[s.ID];
                                        s.PlanDate = newVal.PlanDate;
                                    }
                                }
                            }
                            temp.Clear();
                            frmP.ShowProgress(string.Empty, (decimal)(i + 1) / sgs.Count);
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
            foreach (DataGridViewRow r in groupView.Rows)
            {
                if (!r.Selected) continue;
                var sg = r.Tag as StudentGroupSummary;
                r.Cells["col考试时间"].Value = sg.PlanDate;
            }
        }

        private void 删除所选分组ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (groupView.SelectedRows == null || groupView.SelectedRows.Count == 0) return;
            if (MessageBox.Show("是否删除所选的分组?", "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                List<Guid> groups = new List<Guid>();
                foreach (DataGridViewRow row in groupView.SelectedRows)
                {
                    groups.Add((row.Tag as StudentGroupSummary).ID);
                }
                if (groups != null && groups.Count > 0) DeleteGroups(groups);
                mnuFresh.PerformClick();
            }
        }

        private void DeleteGroups(List<Guid> gps)
        {
            int fail = 0;
            FrmProcessing frmP = new FrmProcessing();
            Action action = delegate ()
            {
                try
                {
                    List<Guid> temp = new List<Guid>();
                    for (int i = 0; i < gps.Count; i++)
                    {
                        temp.Add(gps[i]);
                        if (i == gps.Count - 1 || temp.Count == 100)
                        {
                            var ret = new APIClient(AppSettings.Current.ConnStr).BatchDelete<Guid, StudentGroup>(temp, AppSettings.Current.PhysicalProject.ID);
                            if (ret.Result != ResultCode.Successful)
                            {
                                fail += temp.Count;
                            }
                            temp.Clear();
                            if (fail == 0) frmP.ShowProgress(string.Empty, (decimal)(i + 1) / gps.Count);
                            else frmP.ShowProgressEX($"失败 {fail} 条", (decimal)(i + 1) / gps.Count);
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

        #region 事件处理程序
        private void FrmMain_Load(object sender, EventArgs e)
        {
            cmbDivision.Init(AppSettings.Current.PhysicalProject.ID);
            cmbPhysicalItem.Init(AppSettings.Current.PhysicalProject);
            cmbFacility.Init(AppSettings.Current.PhysicalProject.ID);
            ReFreshData();
            ShowOperatorRights();
        }

        private void cmbDivision_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbFacility.SelectedIndexChanged -= new System.EventHandler(this.cmbFacility_SelectedIndexChanged);
            cmbFacility.Init(AppSettings.Current.PhysicalProject.ID, cmbDivision.SelectedDivisionID);
            cmbFacility.SelectedIndexChanged += new System.EventHandler(this.cmbFacility_SelectedIndexChanged);
            FreshData_Clicked(cmbDivision, EventArgs.Empty);
        }

        private void cmbFacility_SelectedIndexChanged(object sender, EventArgs e)
        {
            FreshData_Clicked(cmbFacility, EventArgs.Empty);
        }

        private void btnFresh_Click(object sender, EventArgs e)
        {
            mnuFresh.PerformClick();
        }

        private void FreshData_Clicked(object sender, EventArgs e)
        {
            var ret = FilterGroup();
            ShowGroupsOnGrid(ret);
        }

        private void groupView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var sg = groupView.Rows[e.RowIndex].Tag as StudentGroupSummary;
                ShowCurrentGroup(sg);
            }
        }

        private void btn导入分组_Click(object sender, EventArgs e)
        {
            FrmStudentGroupImport frm = new FrmStudentGroupImport();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowInTaskbar = true;
            frm.ShowDialog();
            btnFresh.PerformClick();
        }

        private void btn自动分组_Click(object sender, EventArgs e)
        {
            FrmAutoStudentGrouping frm = new FrmAutoStudentGrouping();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            btnFresh.PerformClick();
        }

        private void mnu导出准考证_Click(object sender, EventArgs e)
        {
            if (groupView.SelectedRows.Count == 0) return;
            List<StudentGroupSummary> items = new List<StudentGroupSummary>();
            foreach (DataGridViewRow r in groupView.Rows)
            {
                if (!r.Selected) continue;
                items.Add(r.Tag as StudentGroupSummary);
            }
            var frm = new Frm按组导出准考证();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.PrintingGroups = items;
            frm.ShowDialog();
        }

        private void mnu_导出秩序册_Click(object sender, EventArgs e)
        {
            if (groupView.SelectedRows.Count == 0) return;
            List<StudentGroupSummary> items = new List<StudentGroupSummary>();
            foreach (DataGridViewRow r in groupView.Rows)
            {
                if (!r.Selected) continue;
                items.Add(r.Tag as StudentGroupSummary);
            }
            var frm = new Frm学生秩序册导出();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.PrintingGroups = items;
            frm.ShowDialog();
        }

        #endregion

        
    }
}
