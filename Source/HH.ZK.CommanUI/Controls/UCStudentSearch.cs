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

        #region 公共方法
        public void Init()
        {
            cmbDivision.Init();
        }

        public StudentSearchCondition GetSearchCondition()
        {
            var con = new StudentSearchCondition();
            if (rdMale.Checked) con.Sex = Gender.Male;
            if (rdFemale.Checked) con.Sex = Gender.Female;
            if (!string.IsNullOrEmpty(txtStudentID1.Text)) con.StudentIDLike = txtStudentID1.Text;
            if (!string.IsNullOrEmpty(txtName.Text)) con.Name = txtName.Text;
            if (!string.IsNullOrEmpty(cmbDivision.Text)) con.DivisionID = cmbDivision.SelectedDivisionID;
            con.SortMode = LJH.GeneralLibrary.SortMode.Asc;
            return con;
        }

        public void GetSearchCondition(StudentSearchCondition con)
        {
            if (rdMale.Checked) con.Sex = Gender.Male;
            if (rdFemale.Checked) con.Sex = Gender.Female;
            if (!string.IsNullOrEmpty(txtStudentID1.Text)) con.StudentIDLike = txtStudentID1.Text;
            if (!string.IsNullOrEmpty(txtName.Text)) con.Name = txtName.Text;
            if (!string.IsNullOrEmpty(cmbDivision.Text)) con.DivisionID = cmbDivision.SelectedDivisionID;
            con.SortMode = LJH.GeneralLibrary.SortMode.Asc;
        }

        public string GetDivisionName()
        {
            return cmbDivision.Text;
        }

        public string GetFacilityName()
        {
            return null;
        }

        public string GetGroup()
        {
            return null;
        }
        #endregion
    }
}
