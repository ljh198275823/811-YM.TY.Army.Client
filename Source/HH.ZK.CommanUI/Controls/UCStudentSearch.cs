using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HH.ZK.Model;
using HH.ZK.Model.SearchCondition;

namespace HH.ZK.CommonUI.Controls
{
    public partial class UCStudentSearch : UserControl
    {
        public UCStudentSearch()
        {
            InitializeComponent();
        }

        private string _ProjectID;

        #region 公共方法
        public void Init(string projectID)
        {
            _ProjectID = projectID;
            if (!string.IsNullOrEmpty(projectID))
            {
                cmbDivision.SelectedIndexChanged -= new System.EventHandler(this.cmbDivision_SelectedIndexChanged);
                cmbDivision.Init(projectID);
                cmbDivision.SelectedIndexChanged += new System.EventHandler(this.cmbDivision_SelectedIndexChanged);

                cmbFacility.SelectedIndexChanged -= new System.EventHandler(this.cmbFacility_SelectedIndexChanged);
                cmbFacility.Init(projectID);
                cmbFacility.SelectedIndexChanged += new System.EventHandler(this.cmbFacility_SelectedIndexChanged);

                txtGroupID.Init(projectID, null);
                txtGroupID.Enabled = txtGroupID.Items.Count > 1;
            }
            else
            {
                cmbDivision.Enabled = false;
                cmbFacility.Enabled = false;
                txtGroupID.Enabled = false;
            }
        }

        public StudentSearchCondition GetSearchCondition()
        {
            var con = new StudentSearchCondition();
            if (rdMale.Checked) con.Sex = Sex.Male;
            if (rdFemale.Checked) con.Sex = Sex.Female;
            if (!string.IsNullOrEmpty(txtStudentID1.Text)) con.StudentIDLike = txtStudentID1.Text;
            if (!string.IsNullOrEmpty(txtName.Text)) con.Name = txtName.Text;
            if (!string.IsNullOrEmpty(txtGroupID.Text)) con.GroupID = txtGroupID.SelectedGroupID;
            else if (!string.IsNullOrEmpty(cmbFacility.Text)) con.FacilityID = cmbFacility.SelectedFacilityID;
            else if (!string.IsNullOrEmpty(cmbDivision.Text)) con.DivisionID = cmbDivision.SelectedDivisionID;
            con.SortMode = LJH.GeneralLibrary.SortMode.Asc;
            return con;
        }

        public void GetSearchCondition(StudentSearchCondition con)
        {
            if (rdMale.Checked) con.Sex = Sex.Male;
            if (rdFemale.Checked) con.Sex = Sex.Female;
            if (!string.IsNullOrEmpty(txtStudentID1.Text)) con.StudentIDLike = txtStudentID1.Text;
            if (!string.IsNullOrEmpty(txtName.Text)) con.Name = txtName.Text;
            if (!string.IsNullOrEmpty(txtGroupID.Text)) con.GroupID = txtGroupID.SelectedGroupID;
            else if (!string.IsNullOrEmpty(cmbFacility.Text)) con.FacilityID = cmbFacility.SelectedFacilityID;
            else if (!string.IsNullOrEmpty(cmbDivision.Text)) con.DivisionID = cmbDivision.SelectedDivisionID;
            con.SortMode = LJH.GeneralLibrary.SortMode.Asc;
        }

        public string GetGroupName()
        {
            return txtGroupID.Text;
        }

        public StudentGroupSummary GetGroup()
        {
            return txtGroupID.SelectedGroup;
        }

        public string GetFacilityName()
        {
            return cmbFacility.Text;
        }

        public string GetDivisionName()
        {
            return cmbDivision.Text;
        }
        #endregion

        #region 事件处理程序
        private void cmbDivision_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbFacility.SelectedIndexChanged -= new System.EventHandler(this.cmbFacility_SelectedIndexChanged);
            cmbFacility.Init(_ProjectID, cmbDivision.SelectedDivisionID);
            txtGroupID.Init(_ProjectID, null);
            cmbFacility.SelectedIndexChanged += new System.EventHandler(this.cmbFacility_SelectedIndexChanged);
        }

        private void cmbFacility_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cmbFacility.SelectedFacilityID)) txtGroupID.Init(_ProjectID, cmbFacility.SelectedFacilityID);
            else txtGroupID.Init(_ProjectID, null);
            txtGroupID.Enabled = txtGroupID.Items.Count > 1;
        }
        #endregion
    }
}
