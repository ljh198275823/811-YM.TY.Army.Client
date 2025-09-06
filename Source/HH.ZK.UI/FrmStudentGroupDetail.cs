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

namespace HH.ZK.UI
{
    public partial class FrmStudentGroupDetail : LJH.GeneralLibrary.WinForm.FrmDetailBase<Guid, StudentGroup>
    {
        public FrmStudentGroupDetail()
        {
            InitializeComponent();
        }

        #region 私有方法
        private void ShowGroupPairOnRow(DataGridViewRow row, Student s, StudentGroupPair pair)
        {
            row.Tag = pair;
            row.Cells["colID"].Value = s.ID;
            row.Cells["colID"].Tag = s;
            row.Cells["colName"].Value = s.Name;
            row.Cells["colSex"].Value = s.Sex == Sex.Male ? "男" : "女";
            row.Cells["colIDNumber"].Value = s.IDNumber;
            row.Cells["colClassName"].Value = s.ClassName;
            row.Cells["colChannel"].Value = row.Index + 1;
            lblCount.Text = string.Format("共 {0} 项", dataGridView1.Rows.Count);
        }
        #endregion

        #region 重写基类方法
        protected override void InitControls()
        {
            base.InitControls();
            txtFacility.Init(AppSettings.Current.PhysicalProject.ID);
        }

        public override void ShowOperatorRights()
        {
            base.ShowOperatorRights();
            btnOk.Enabled = AppSettings.Current.Operator.PermitAny(Permission.StudentGroup, PermissionActions.Edit);
        }

        protected override void ItemShowing(StudentGroup sg)
        {
            txt考试科目.Text = AppSettings.Current.PhysicalProject.PhysicalItems?.GetNames(sg.PhysicalItems);
            txt考试科目.Tag = sg.PhysicalItems;
            txtNumber.IntergerValue = sg.Number;
            rdMale.Checked = sg.Sex == Sex.Male;
            rdFemale.Checked = sg.Sex == Sex.Female;
            txtFacility.SelectedFacilityID = sg.FacilityID;
            txt考试时间.Text = sg.PlanDate;
            dataGridView1.Rows.Clear();
            if (sg.ItemsCount > 0)
            {
                var con = new StudentSearchCondition() { GroupID = sg.ID };
                var cr = new APIClient(AppSettings.Current.ConnStr).GetList<string, Student>(con, AppSettings.Current.PhysicalProject.ID);
                if (cr.Result == ResultCode.Successful)
                {
                    var ss = cr.QueryObjects;
                    foreach (var it in sg.Items.OrderBy(it => it.Channel))
                    {
                        var student = ss?.SingleOrDefault(s => s.ID == it.StudentID);
                        //将信息显示在网格中
                        if (student != null)
                        {
                            int row = dataGridView1.Rows.Add();
                            ShowGroupPairOnRow(dataGridView1.Rows[row], student, it);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("获取学生信息失败");
                    btnOk.Visible = false;
                }
            }
        }

        protected override bool CheckInput()
        {
            if (txtNumber.IntergerValue <= 0)
            {
                MessageBox.Show("请填写组号");
                return false;
            }
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("组别至少要有一个学生");
                return false;
            }
            return true;
        }

        protected override StudentGroup GetItemFromInput()
        {
            var info = UpdatingItem as StudentGroup;
            if (UpdatingItem == null)
            {
                info = new StudentGroup();
                info.ID = Guid.NewGuid();
            }
            info.PhysicalItems = txt考试科目.Tag != null ? txt考试科目.Tag.ToString() : null;
            if (string.IsNullOrEmpty(info.PhysicalItems)) info.PhysicalItems = null;
            info.PlanDate = string.IsNullOrEmpty(txt考试时间.Text) == false ? txt考试时间.Text : null;
            if (rdMale.Checked) info.Sex = Sex.Male;
            else if (rdFemale.Checked) info.Sex = Sex.Female;
            else info.Sex = null;
            info.FacilityID = txtFacility.SelectedFacilityID;
            info.Number = txtNumber.IntergerValue;
            info.Clear();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                var pair = row.Tag as StudentGroupPair;
                pair.Channel = row.Index + 1;
                info.Add(pair);
            }
            return info;
        }

        protected override CommandResult<StudentGroup> AddItem(StudentGroup addingItem)
        {
            var sg = addingItem as StudentGroup;
            var ret = (new APIClient(AppSettings.Current.ConnStr)).Add<Guid, StudentGroup>(sg, AppSettings.Current.PhysicalProject.ID);
            if (ret.Result == ResultCode.Successful && ret.Value != null)
            {
                sg.FacilityName = ret.Value.FacilityName;
            }
            return ret;
        }

        protected override CommandResult<StudentGroup> UpdateItem(StudentGroup updatingItem)
        {
            var sg = updatingItem as StudentGroup;
            var ret = (new APIClient(AppSettings.Current.ConnStr)).Add<Guid, StudentGroup>(sg, AppSettings.Current.PhysicalProject.ID);
            if (ret.Result == ResultCode.Successful && ret.Value != null)
            {
                sg.FacilityName = ret.Value.FacilityName;
            }
            return ret;
        }
        #endregion

        #region 事件处理程序
        private void mnu_Add_Click(object sender, EventArgs e)
        {
            Frm分组学生选择 frm = new Frm分组学生选择();
            frm.FacilityID = txtFacility.SelectedFacilityID;
            if (rdMale.Checked) frm.StudentSex = Sex.Male;
            else if (rdFemale.Checked) frm.StudentSex = Sex.Female;
            frm.PhysicalItems = txt考试科目.Tag != null ? txt考试科目.Tag.ToString() : null;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                bool exists = false;
                foreach (var s in frm.SelectedStudents)
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        var pair = row.Tag as StudentGroupPair;
                        if (pair.StudentID == s.ID)
                        {
                            exists = true;
                            break;
                        }
                    }
                    if (!exists)
                    {
                        var Group = UpdatingItem as StudentGroup;
                        StudentGroupPair pair = new StudentGroupPair()
                        {
                            ID = Guid.NewGuid(),
                            StudentID = s.ID,
                        };
                        if (Group.ItemsCount == 0) pair.Channel = 1;
                        else
                        {
                            var c = Group.Items.Max(it => it.Channel);
                            if (c.HasValue) pair.Channel = c + 1;
                        }
                        Group.Add(pair);
                        int row = dataGridView1.Rows.Add();
                        ShowGroupPairOnRow(dataGridView1.Rows[row], s, pair);
                    }
                }
            }
        }

        private void mnu_Delete_Click(object sender, EventArgs e)
        {
            var Group = UpdatingItem as StudentGroup;
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                Group.Remove(row.Tag as StudentGroupPair);
                dataGridView1.Rows.Remove(row);
            }
            if (dataGridView1.Rows.Count > 0)
            {
                foreach (DataGridViewRow r in this.dataGridView1.Rows)
                {
                    r.Cells["colChannel"].Value = r.Index + 1;
                }
            }
        }

        private void studentView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "colChannel")
                {
                    var pair = dataGridView1.Rows[e.RowIndex].Tag as StudentGroupPair;
                    int ch = 0;
                    if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null && int.TryParse(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), out ch))
                    {
                        pair.Channel = ch;
                    }
                }
            }
        }

        private void lnk考试科目_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (rdMale.Checked == false && rdFemale.Checked == false)
            {
                MessageBox.Show("请先指定是男子还是女子组别");
                return;
            }
            var frm = new Frm考试科目选择();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.SexFlag = rdMale.Checked ? Sex.Male : Sex.Female;
            frm.SelectedPhysicalIDs = txt考试科目.Tag != null ? txt考试科目.Tag.ToString() : null;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                var sp = frm.SelectedPhysicalIDs;
                txt考试科目.Tag = frm.SelectedPhysicalIDs;
                txt考试科目.Text = AppSettings.Current.PhysicalProject.PhysicalItems?.GetNames(frm.SelectedPhysicalIDs);
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count == 1 && this.dataGridView1.SelectedRows[0].Index > 0)
            {
                var curRow = this.dataGridView1.SelectedRows[0].Index;
                var preObj = this.dataGridView1.Rows[curRow - 1].Tag as StudentGroupPair;
                var preStud = this.dataGridView1.Rows[curRow - 1].Cells["colID"].Tag as Student;
                ShowGroupPairOnRow(this.dataGridView1.Rows[curRow - 1], this.dataGridView1.Rows[curRow].Cells["colID"].Tag as Student, this.dataGridView1.Rows[curRow].Tag as StudentGroupPair);
                ShowGroupPairOnRow(this.dataGridView1.Rows[curRow], preStud, preObj);
                this.dataGridView1.Rows[curRow].Selected = false;
                this.dataGridView1.Rows[curRow - 1].Selected = true;
                foreach (DataGridViewRow r in this.dataGridView1.Rows)
                {
                    r.Cells["colChannel"].Value = r.Index + 1;
                }
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count == 1 && this.dataGridView1.SelectedRows[0].Index < this.dataGridView1.Rows.Count - 1)
            {
                var curRow = this.dataGridView1.SelectedRows[0].Index;
                var preObj = this.dataGridView1.Rows[curRow + 1].Tag as StudentGroupPair;
                var preStud = this.dataGridView1.Rows[curRow + 1].Cells["colID"].Tag as Student;
                ShowGroupPairOnRow(this.dataGridView1.Rows[curRow + 1], this.dataGridView1.Rows[curRow].Cells["colID"].Tag as Student, this.dataGridView1.Rows[curRow].Tag as StudentGroupPair);
                ShowGroupPairOnRow(this.dataGridView1.Rows[curRow], preStud, preObj);
                this.dataGridView1.Rows[curRow].Selected = false;
                this.dataGridView1.Rows[curRow + 1].Selected = true;
                foreach (DataGridViewRow r in this.dataGridView1.Rows)
                {
                    r.Cells["colChannel"].Value = r.Index + 1;
                }
            }
        }
        #endregion
    }
}
