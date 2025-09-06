using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HH.ZK.Model;
using HH.ZK.Model.CRM;
using HH.ZK.Model.SearchCondition;
using HH.ZK.CommonUI;
using HH.ZK.WebAPIClient;
using LJH.GeneralLibrary;
using LJH.GeneralLibrary.WinForm;

namespace HH.ZK.UI
{
    public partial class Frm分组学生选择 : Form
    {
        public Frm分组学生选择()
        {
            InitializeComponent();
        }

        private List<Student> _Students = null;

        #region 公共属性
        public List<Student> SelectedStudents { get; set; }

        public string PhysicalItems { get; set; }

        public Sex? StudentSex { get; set; }

        public string FacilityID { get; set; }


        #endregion

        #region 私有方法
        private List<Student> Filter(List<Student> dataSource)
        {
            IEnumerable<Student> ret = dataSource;
            if (dataSource != null && dataSource.Count > 0)
            {
                if (!string.IsNullOrEmpty(txtKeyWord.Text))
                {
                    ret = ret.Where(item => item.ID.Contains(txtKeyWord.Text) || item.Name.Contains(txtKeyWord.Text) || (!string.IsNullOrEmpty(item.ClassName) && item.ClassName.Contains(txtKeyWord.Text)));
                }
                return ret.ToList();
            }
            return null;
        }

        private void ShowItemInGridViewRow(DataGridViewRow row, Student s)
        {
            row.Tag = s;
            row.Cells["colID"].Value = s.ID;
            row.Cells["colName"].Value = s.Name;
            row.Cells["colSex"].Value = s.Sex == Sex.Male ? "男" : "女";
            row.Cells["colFacility"].Value = s.FacilityName;
            row.Cells["colClassID"].Value = s.ClassName;
            row.Cells["col考试科目"].Value = AppSettings.Current.PhysicalProject.PhysicalItems?.GetNames(s.PhysicalItems);
            row.Cells["colClassName"].Value = s.ClassName;
        }

        private void ShowItemsOnGrid(List<Student> items)
        {
            this.GridView.Rows.Clear();
            if (items != null && items.Count > 0)
            {
                foreach (Student s in items)
                {
                    int row = this.GridView.Rows.Add();
                    ShowItemInGridViewRow(this.GridView.Rows[row], s);
                }
            }
            if (this.GridView.Rows.Count > 0) this.GridView.Rows[0].Selected = false;
            lblCount.Text = string.Format("共有 {0} 项", GridView.Rows.Count);
        }
        #endregion

        #region 事件处理程序
        private void FrmPhysicalProjectStudentSelection_Load(object sender, EventArgs e)
        {
            var con = new StudentSearchCondition() { FacilityID = this.FacilityID, Sex = StudentSex, PhysicalItems = PhysicalItems, SortMode = SortMode.Asc };
            _Students = new APIClient(AppSettings.Current.ConnStr).GetList<string, Student>(con, AppSettings.Current.PhysicalProject.ID).QueryObjects;
            List<Student> showing = Filter(_Students);
            ShowItemsOnGrid(showing);
        }

        private void txField_Click(object sender, EventArgs e)
        {
            List<Student> showing = Filter(_Students);
            ShowItemsOnGrid(showing);
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in GridView.Rows)
            {
                row.Selected = true;
            }
        }

        private void btnNone_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in GridView.Rows)
            {
                row.Selected = false;
            }
        }

        private void btnRevert_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in GridView.Rows)
            {
                row.Selected = !row.Selected;
            }
        }
        #endregion

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SelectedStudents = new List<Student>();
            foreach (DataGridViewRow row in GridView.Rows)
            {
                if (row.Selected)
                {
                    SelectedStudents.Add(row.Tag as Student);
                }
            }
            if (SelectedStudents.Count > 0)
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void GridView_SelectionChanged(object sender, EventArgs e)
        {
            lbl选择数量.Text = GridView.SelectedRows.Count.ToString();
        }
    }
}
