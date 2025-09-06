using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using HH.ZK.Model;
using HH.ZK.Model.SearchCondition;
using HH.ZK.CommonUI;
using HH.ZK.WebAPIClient;

namespace HH.ZK.UI
{
    public partial class FrmAutoStudentGrouping : Form
    {
        public FrmAutoStudentGrouping()
        {
            InitializeComponent();
        }

        #region 私有变量
        #endregion

        #region 私有方法
        private void ShowStudentInfo(DataGridViewRow row, Student s)
        {
            row.Tag = s;
            row.Cells["colFacility"].Value = s.FacilityName;
            row.Cells["colID"].Value = s.ID;
            row.Cells["col考试科目"].Value = AppSettings.Current.PhysicalProject.PhysicalItems?.GetNames(s.PhysicalItems);
            row.Cells["colName"].Value = s.Name;
            row.Cells["colClassName"].Value = s.ClassName;
            row.Cells["colSex"].Value = s.Sex == Sex.Male ? "男" : "女";
        }

        private List<Student> GetSeletedStudents()
        {
            List<Student> ret = null;
            for (int row = 0; row < dataGridview1.Rows.Count; row++)
            {
                if (dataGridview1.Rows[row].Selected)
                {
                    if (ret == null) ret = new List<Student>();
                    var pair = dataGridview1.Rows[row].Tag as Student;
                    ret.Add(pair);
                }
            }
            return ret;
        }

        private int? 班级编号(Student s)
        {
            int ret = 0;
            if (!string.IsNullOrEmpty(s.ClassName) && int.TryParse(s.ClassName, out ret)) return ret;
            return null;
        }

        private List<StudentGroup> 分组(List<Student> students, bool 分学校, bool 分性别, bool 分考试科目, bool 分班级, int 每组最大人数, string pis, string planDate, bool 最后两组平均)
        {
            List<StudentGroup> ret = new List<StudentGroup>();
            var groups = from st in students
                         group st by new { Facility = 分学校 ? st.FacilityID : null, FacilityName = 分学校 ? st.FacilityName : null, Sex = 分性别 ? (Sex?)st.Sex : null };
            foreach (var gp in groups)
            {
                int 女子组号 = 1;
                int 男子组号 = 1;
                int 组号 = 1;
                var fgps = from it in gp
                           let kskm = !string.IsNullOrEmpty(pis) ? pis : (分考试科目 ? it.PhysicalItems : null)
                           //学生按班级编号，班级名称，考试科目顺序和准考证这几个进行排序
                           orderby 班级编号(it) ascending, it.ClassName ascending, AppSettings.Current.PhysicalProject.PhysicalItems.GetSortNumbers(it.PhysicalItems) ascending, it.ID ascending
                           group it by new
                           {
                               KSKM = AppSettings.Current.PhysicalProject.PhysicalItems.GetNames(kskm), //这里由于每个学生的考试科目里面的项目顺序可能不一样，所以用获取项目名称的方式统一调整顺序
                               ClassName = 分班级 ? it.ClassName : null
                           };  //如果项目为空 按学校和性别分组后再按科目分组
                foreach (var fgp in fgps)
                {
                    StudentGroup g = null;
                    var ss = fgp.ToList(); //获取学生列表
                    var totalGn = (int)Math.Ceiling((double)ss.Count / 每组最大人数);
                    var 余数 = ss.Count % 每组最大人数;
                    if (余数 > 0 && 最后两组平均 && 余数 * 2 < 每组最大人数) 余数 = (每组最大人数 + 余数) / 2;
                    int count = 0;
                    int channel = 1;
                    for (int i = 0; i < ss.Count; i++)
                    {
                        if (g == null)
                        {
                            channel = 1;
                            count = 0;
                            int gn = 0;
                            if (gp.Key.Sex != null)
                            {
                                if (gp.Key.Sex == Sex.Male) gn = 男子组号++;
                                else gn = 女子组号++;
                            }
                            else
                            {
                                gn = 组号++;
                            }
                            g = new StudentGroup()
                            {
                                ID = Guid.NewGuid(),
                                Sex = gp.Key.Sex,
                                FacilityID = gp.Key.Facility,
                                FacilityName = gp.Key.FacilityName,
                                Number = gn,
                                PhysicalItems = pis,
                                PlanDate = planDate,
                                Items = new List<StudentGroupPair>()
                            };
                            ret.Add(g);
                        }
                        StudentGroupPair sp = new StudentGroupPair()
                        {
                            ID = Guid.NewGuid(),
                            GroupID = g.ID,
                            StudentID = ss[i].ID,
                            Channel = channel++,
                        };
                        g.Add(sp);
                        count++;
                        if (count >= 每组最大人数 || i == ss.Count - 1 - 余数) g = null;
                    }
                }
            }
            return ret;
        }
        #endregion

        #region 事件处理程序
        private void FrmScoreBillPrint_Load(object sender, EventArgs e)
        {
            ucStudentSearch1.Init(AppSettings.Current.PhysicalProject.ID);
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridview1.Rows)
            {
                row.Selected = true;
            }
        }

        private void btnNone_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridview1.Rows)
            {
                row.Selected = false;
            }
        }

        private void btnRevert_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridview1.Rows)
            {
                row.Selected = !row.Selected;
            }
        }

        private void lnk考试科目_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var frm = new Frm考试科目选择();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.SelectedPhysicalIDs = txt考试科目.Tag != null ? txt考试科目.Tag.ToString() : null;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                var sp = frm.SelectedPhysicalIDs;
                txt考试科目.Tag = frm.SelectedPhysicalIDs;
                txt考试科目.Text = AppSettings.Current.PhysicalProject.PhysicalItems?.GetNames(frm.SelectedPhysicalIDs);
                if (!string.IsNullOrEmpty(sp))
                {
                    chk分考试科目.Enabled = false;
                    chk分考试科目.Checked = false;
                }
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            dataGridview1.Rows.Clear();
            var con = ucStudentSearch1.GetSearchCondition();
            if (txt考试科目.Tag != null) con.PhysicalItems = txt考试科目.Tag.ToString();
            con.States = new List<StudentState>();
            if (chk正常考试.Checked) con.States.Add(StudentState.正常考试);
            if (chk择考.Checked) con.States.Add(StudentState.择考);
            if (chk缓考.Checked) con.States.Add(StudentState.缓考);
            if (chk显示已分组学生.Checked == false) con.Grouped = false;
            con.SortMode = LJH.GeneralLibrary.SortMode.Asc;
            var ret = new APIClient(AppSettings.Current.ConnStr).GetList<string, Student>(con, AppSettings.Current.PhysicalProject.ID).QueryObjects;
            if (ret != null && ret.Count > 0)
            {
                foreach (Student s in ret)
                {
                    int row = dataGridview1.Rows.Add();
                    ShowStudentInfo(dataGridview1.Rows[row], s);
                }
            }
            this.toolStripStatusLabel1.Text = string.Format("总共 {0} 项", dataGridview1.Rows.Count);
            btnWrite.Enabled = dataGridview1.Rows.Count > 0;
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            var students = GetSeletedStudents();
            if (students == null || students.Count == 0) return;
            var pis = txt考试科目.Tag != null ? txt考试科目.Tag.ToString() : null;
            var planDate = string.IsNullOrEmpty(txt考试日期.Text) ? null : txt考试日期.Text;
            var gs = 分组(students, chk分学校.Checked, chk分性别.Checked, chk分考试科目.Checked, chk分班级.Checked, txtInterval.IntergerValue, pis, planDate, chk最后两组平均.Checked);
            FrmAutoStudentGroupPreview frm = new FrmAutoStudentGroupPreview();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.StudentGroups = gs;
            frm.Students = new Dictionary<string, Student>();
            students.ForEach(it => frm.Students.Add(it.ID, it));
            frm.ShowDialog();
        }
        #endregion
    }
}
