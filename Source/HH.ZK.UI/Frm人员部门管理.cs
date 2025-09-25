using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using HH.ZK.Model;
using HH.ZK.Model.SearchCondition;
using HH.ZK.Model.CRM;
using HH.ZK.CommonUI;
using HH.ZK.WebAPIClient;
using HH.Zhongkao.Device.Reader;
using LJH.GeneralLibrary;
using LJH.GeneralLibrary.WinForm;
using LJH.GeneralLibrary.SoftDog;
using LJH.GeneralLibrary.CardReader;

namespace HH.ZK.UI
{
    public partial class Frm人员部门管理 : FrmMasterBase<string,Student>
    {
        public Frm人员部门管理()
        {
            InitializeComponent();
        }

        #region 私有变量
        private string _PageSizeConfig = System.IO.Path.Combine(Application.StartupPath, "PageSize.xml");
        private StudentSearchCondition _Search = null;
        private object _Locker = new object();
        private bool _FreshNeeded = false;
        private Thread _FreshDataThread = null;
        #endregion

        #region 私有方法
        private void SetState(List<Student> students, StudentState state)
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
                            var patchs = temp.Select(it => new UpdateItem<string>() { ID = it.ID, Key = "State", Value = ((int)state).ToString()}).ToList();
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

        private void DeleteStudents(List<Student> students)
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
            FreshView(ucPaging1.GetPageSize(), 1);
        }

        private void FreshDataThread()
        {
            try
            {
                while (true)
                {
                    try
                    {
                        if (_FreshNeeded)
                        {
                            lock (_Locker)
                            {
                                _FreshNeeded = false;
                            }
                            QueryResultList<Student> ret = null;
                            if (_Search != null) ret = new APIClient(AppSettings.Current.ConnStr).GetList<string, Student>(_Search);
                            Action action = delegate ()
                            {
                                if (ret.Result ==ResultCode.Successful)
                                {
                                    _Items = ret.QueryObjects;
                                    FreshView();
                                    this.ucPaging1.ShowState(ret.PageSize, ret.PageIndex, (_Items != null ? _Items.Count : 0), ret.TotalCount);
                                }
                                else
                                {
                                    MessageBox.Show(ret.Message);
                                }
                            };
                            if (this.InvokeRequired) this.Invoke(action);
                            else action();
                        }
                        Thread.Sleep(1000);
                    }
                    catch (ThreadAbortException)
                    {
                        _FreshDataThread = null;
                        break;
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private void FreshView(int pageSize, int pageIndex)
        {
            if (pageSize > 0) SaveConfig(_PageSizeConfig, "PageSize", pageSize.ToString());
            if (this.divisionTree.SelectedNode != null && this.divisionTree.SelectedNode.Tag != null)
            {
                if (this.divisionTree.SelectedNode.Tag is Division)
                {
                }
            }
            _Search = new StudentSearchCondition() { PageSize = pageSize, PageIndex = pageIndex, SortMode = SortMode.Asc };
            if (!string.IsNullOrEmpty(txtStudentID1.Text)) _Search.StudentIDLike = txtStudentID1.Text;
            if (!string.IsNullOrEmpty(txtName.Text)) _Search.Name = txtName.Text;
            if (rdMale.Checked) _Search.Sex = Gender.Male;
            if (rdFemale.Checked) _Search.Sex = Gender.Female;
            if (rdHasPhoto.Checked) _Search.HasPhoto = true;
            if (rdNonePhoto.Checked) _Search.HasPhoto = false;
            if (rd有人脸特征.Checked) _Search.HasFaceFeature = true;
            if (rd无人脸特征.Checked) _Search.HasFaceFeature = false;
            if (this.divisionTree.SelectedNode != null && this.divisionTree.SelectedNode.Tag != null)
            {
                if (this.divisionTree.SelectedNode.Tag is Division)
                {
                    _Search.DivisionID = (this.divisionTree.SelectedNode.Tag as Division).ID;
                }
            }
            lock (_Locker)
            {
                _FreshNeeded = true;
            }
        }
        #endregion

        #region 重写基类方法
        protected override void Init()
        {
            base.Init();
            this.divisionTree.Init();
            //txt考试状态.Init(AppSettings.Current.PhysicalProject.StateSettings, true);
            this.ucPaging1.Init();
            this.ucPaging1.GetPageData += UcPaging1_GetPageData;
            var temp = GetConfig(_PageSizeConfig, "PageSize");
            int pageSize = 0;
            if (string.IsNullOrEmpty(temp) || !int.TryParse(temp, out pageSize) || pageSize == 0) pageSize = 30;
            this.ucPaging1.SetPageSize(pageSize);
            if (_FreshDataThread == null)
            {
                _FreshDataThread = new Thread(new ThreadStart(FreshDataThread));
                _FreshDataThread.IsBackground = true;
                _FreshDataThread.Start();
            }
        }

        public override void ShowOperatorRights()
        {
            base.ShowOperatorRights();
            //学生
            cMnu_Add.Enabled = AppSettings.Current.Operator.PermitAny(Permission.Student, PermissionActions.Edit);
            Mnu_DeleteStudents.Enabled = AppSettings.Current.Operator.PermitAny(Permission.Student, PermissionActions.Delete);
            mnu导入学生信息.Enabled = AppSettings.Current.Operator.PermitAny(Permission.Student, PermissionActions.Edit);
            cMnu_Export.Enabled = AppSettings.Current.Operator.PermitAny(Permission.Student, PermissionActions.Read);
            //区域
            mnu_AddDivision.Enabled = AppSettings.Current.Operator.PermitAny(Permission.Division, PermissionActions.Edit);
            mnu_DeleteDivision.Enabled = AppSettings.Current.Operator.PermitAny(Permission.Division, PermissionActions.Delete);
            mnu_DepartmentProperty.Enabled = AppSettings.Current.Operator.PermitAny(Permission.Division, PermissionActions.Read);
        }

        public override void ReFreshData()
        {
            if (AppSettings.Current.PhysicalProject != null)
            {
                this.divisionTree.Init();
                FreshView(ucPaging1.GetPageSize(), 1);
            }
        }

        protected override object GetCellValue(Student item, string colName)
        {
            if (colName == "col序号") return _ShowingItems.IndexOf(item) + 1;
            if (colName == "colID") return item.ID;
            if (colName == "colCardID") return item.CardID;
            if (colName == "colName") return item.Name;
            if (colName == "colSex") return item.Gender == Gender.Male ? "男" : "女";
            if (colName == "colClassName") return item.ClassName;
            if (colName == "colIDNumber") return item.IDNumber;
            if (colName == "colFacility") return item.DivisionName;
            if (colName == "col照片") return item.HasPhoto;
            //if (colName == "col平时成绩")
            //{
            //    if (AppSettings.Current.Operator.PermitAll(Permission.总分, PermissionActions.Read)) return item.JiaFen.Trim();
            //    return null;
            //}
            if (colName == "colState") return item.State != StudentState.正常 ? item.State.ToString() : null;
            //if (colName == "col学校代码") return item.SchoolCode;
            //if (colName == "col考试科目") return AppSettings.Current.PhysicalProject.PhysicalItems?.GetNames(item.PhysicalItems);
            //if (colName == "colGroupID") return item.Groups;
            return base.GetCellValue(item, colName);
        }

        protected override void SetRowStyle(DataGridViewRow row)
        {
            var item = GetRowTag(row);
            row.DefaultCellStyle.ForeColor = item.State != StudentState.正常 ? Color.Red : Color.Black;
        }

        protected override FrmDetailBase<string,Student> GetDetailForm()
        {
            return new FrmStudentDetail();
        }
        #endregion

        #region 类别树右键菜单
        private void facilityTree_MouseDown(object sender, TreeNodeMouseClickEventArgs e)
        {
            FreshView(ucPaging1.GetPageSize(), 1);
        }

        private void facilityTree_NodeMouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                TreeNode node = divisionTree.HitTest(e.X, e.Y).Node;
                if (node != null && node.Tag != null && node.Tag is Division)
                {
                    divisionTree.ContextMenuStrip = DivisionMenu;
                }
            }
        }

        private void mnu_AddDivision_Click(object sender, EventArgs e)
        {
            Division pc = divisionTree.SelectedNode.Tag as Division;
            FrmDivisionDetail frm = new FrmDivisionDetail();
            frm.IsAdding = true;
            frm.ParentDivision = pc;
            frm.ItemAdded += delegate (object obj, ItemAddedEventArgs args)
            {
                Division item = args.AddedItem as Division;
                divisionTree.AddDivisionNode(item, divisionTree.SelectedNode);
                divisionTree.SelectedNode.Expand();
            };
            frm.ShowDialog();
        }

        private void mnu_DeleteDivision_Click(object sender, EventArgs e)
        {
            var node = divisionTree.SelectedNode;
            Division pc = divisionTree.SelectedNode.Tag as Division;
            if (MessageBox.Show("是否删除此区域及其子节点?", "询问", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                DelNode(node);
            }
        }

        private void DelNode(TreeNode node)
        {
            if (node.Nodes != null && node.Nodes.Count > 0)
            {
                var nodes = new List<TreeNode>(); //这里将子节点放到列表中是消除nodes collection里面的循环删除问题
                foreach (TreeNode n in node.Nodes)
                {
                    nodes.Add(n);
                }
                foreach (var n in nodes)
                {
                    DelNode(n);
                }
            }
            if (node.Nodes == null || node.Nodes.Count == 0)
            {
                Division pc = node.Tag as Division;
                if (pc != null)
                {
                    var ret = (new APIClient(AppSettings.Current.ConnStr)).Delete<Guid, Division>(pc, AppSettings.Current.PhysicalProject.ID);
                    if (ret.Result == ResultCode.Successful)
                    {
                        this.divisionTree.RemoveNode(node);
                    }
                }
                Facility f = node.Tag as Facility;
                if (f != null)
                {
                    var ret = new APIClient(AppSettings.Current.ConnStr).Delete<string, Facility>(f, AppSettings.Current.PhysicalProject.ID);
                    if (ret.Result == ResultCode.Successful)
                    {
                        this.divisionTree.RemoveNode(node);
                    }
                }
            }
        }

        private void mnu_DivisionProperty_Click(object sender, EventArgs e)
        {
            Division pc = divisionTree.SelectedNode.Tag as Division;
            if (pc != null)
            {
                FrmDivisionDetail frm = new FrmDivisionDetail();
                frm.IsAdding = false;
                frm.UpdatingItem = pc;
                frm.ItemUpdated += delegate (object obj, ItemUpdatedEventArgs args)
                {
                    this.divisionTree.Init();
                    divisionTree.SelectDivisionNode(pc.ID);
                };
                frm.ShowDialog();
            }
        }
        #endregion

        #region 主网格右键菜单
        private void mnu导入学生信息_Click(object sender, EventArgs e)
        {
            var frm = new Frm学生信息导入();
            frm.MinimizeBox = false;
            frm.ShowDialog();
            ReFreshData();
        }

        private void Mnu_DeleteStudents_Click(object sender, EventArgs e)
        {
            List<Student> students = GetSelectedItems();
            if (students.Count == 0) return;
            if (MessageBox.Show("是否删除所选的学生?", "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            DeleteStudents(students);
        }

        private void mnu导入学生照片_Click(object sender, EventArgs e)
        {
            var frm = new Frm导入人员照片();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
            ReFreshData();
        }

        private void mnu导出人员照片_Click(object sender, EventArgs e)
        {
            var frm = new Frm导出人员照片();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
        }
        #endregion

        #region 事件处理程序
        private void txField_Click(object sender, EventArgs e)
        {
            FreshView(ucPaging1.GetPageSize(), 1);
        }

        private void UcPaging1_GetPageData(int pageInex, int pageSize)
        {
            FreshView(pageSize, pageInex);
        }

        private void mn刷新学校_Click(object sender, EventArgs e)
        {
            divisionTree.Init();
        }
        #endregion

    }
}