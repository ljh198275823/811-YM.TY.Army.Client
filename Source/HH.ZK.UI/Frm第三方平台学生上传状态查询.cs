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
using LJH.GeneralLibrary.WinForm;

namespace HH.ZK.UI
{
    public partial class Frm第三方平台学生上传状态查询 : FrmReportBaseWithPaging<string,Student>
    {
        public Frm第三方平台学生上传状态查询()
        {
            InitializeComponent();
        }

        #region 私有变量
        private List<Student> GetSelectedStudents()
        {
            List<Student> ss = new List<Student>();
            foreach (DataGridViewCell cell in GridView.SelectedCells)
            {
                var s = GridView.Rows[cell.RowIndex].Tag as Student;
                if (!ss.Contains(s)) ss.Add(s);
            }
            return ss;
        }
        #endregion

        #region 重写基类方法
        protected override void Init()
        {
            base.Init();
            ucStudentSearch1.Init(AppSettings.Current.PhysicalProject.ID);
        }

        public override void ShowOperatorRights()
        {
            base.ShowOperatorRights();
            btnSearch.Enabled = AppSettings.Current.Operator.PermitAll(Permission.Student, PermissionActions.Read);
            btnSaveAs.Enabled = AppSettings.Current.Operator.PermitAll(Permission.Student, PermissionActions.Read);
            mnu重新上传.Enabled = AppSettings.Current.Operator.PermitAny(Permission.Student, PermissionActions.Read);
        }

        protected override QueryResultList<Student> GetDataSource(int pageSize, int pageIndex)
        {
            var con = new StudentSearchCondition() { PageIndex = pageIndex, PageSize = pageSize, SortMode = SortMode.Desc };
            ucStudentSearch1.GetSearchCondition(con);
            con.Checked = true;
            con.SortMode = SortMode.Desc;
            return new APIClient(AppSettings.Current.ConnStr).GetList<string, Student>(con, AppSettings.Current.PhysicalProject.ID);
        }

        protected override void ShowItemInGridViewRow(DataGridViewRow row, Student s)
        {
            row.Tag = s;
            row.Cells["colID"].Value = s.ID;
            row.Cells["colName"].Value = s.Name;
            row.Cells["colSex"].Value = s.Sex == Sex.Male ? "男" : "女";
            row.Cells["colFacility"].Value = s.FacilityName;
            row.Cells["colClassName"].Value = s.ClassName;
            row.Cells["colCheckTime"].Value = s.CheckTime?.ToString("yyyy-MM-dd HH:mm:ss");
            row.Cells["colUploadTime"].Value = s.UploadTime?.ToString("yyyy-MM-dd HH:mm:ss");
            if (s.UploadTime != null)
            {
                if (string.IsNullOrEmpty(s.UploadMsg))
                {
                    row.Cells["col上传状态"].Value = "上传成功";
                    row.DefaultCellStyle.ForeColor = Color.Blue;
                }
                else
                {
                    row.Cells["col上传状态"].Value = s.UploadMsg;
                    row.DefaultCellStyle.ForeColor = Color.Red;
                }
            }
            else
            {
                if (string.IsNullOrEmpty(s.UploadMsg))
                {
                    row.Cells["col上传状态"].Value = "未上传";
                    row.DefaultCellStyle.ForeColor = Color.Black;
                }
                else
                {
                    row.Cells["col上传状态"].Value = s.UploadMsg;
                    row.DefaultCellStyle.ForeColor = Color.Red;
                }
            }
        }
        #endregion

        #region 事件处理程序 
        private void mnu重新上传_Click(object sender, EventArgs e)
        {
            List<Student> ss = GetSelectedStudents();
            if (ss != null && ss.Count > 0) ResetUploadState(ss);
        }

        private void ResetUploadState(List<Student> ss)
        {
            FrmProcessing frm = new FrmProcessing();
            Action action = delegate ()
            {
                try
                {
                    List<Student> temp = new List<Student>();
                    for (int i = 0; i < ss.Count; i++)
                    {
                        temp.Add(ss[i]);
                        if (temp.Count >= 100 || i == ss.Count - 1)
                        {
                            var patches = new List<UpdateItem<string>>();
                            foreach (var s in temp)
                            {
                                patches.Add(new UpdateItem<string>() { ID = s.ID, Key = "UploadTime", Value = null });
                                patches.Add(new UpdateItem<string>() { ID = s.ID, Key = "UploadMsg", Value = null });
                            }
                            var ret = new APIClient(AppSettings.Current.ConnStr).BatchPatch<string, Student>(patches, AppSettings.Current.PhysicalProject.ID);
                            if (ret.Result == ResultCode.Successful && ret.Value != null && ret.Value.Successes != null)
                            {
                                foreach (var s in temp)
                                {
                                    if (ret.Value.Successes.ContainsKey(s.ID))
                                    {
                                        s.UploadTime = ret.Value.Successes[s.ID].UploadTime;
                                        s.UploadMsg = ret.Value.Successes[s.ID].UploadMsg;
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
                ShowItemInGridViewRow(row, row.Tag as Student);
            }
        }
        #endregion
    }
}
