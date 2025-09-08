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
    public partial class UCStatiticsSearch : UserControl
    {
        public UCStatiticsSearch()
        {
            InitializeComponent();
        }

        private string _ProjectID;

        #region 公共方法
        public void Init()
        {
            cmbDivision.Init();
            cmbDivision.SelectedIndexChanged -= new System.EventHandler(this.cmbDivision_SelectedIndexChanged);
            cmbDivision.SelectedIndexChanged += new System.EventHandler(this.cmbDivision_SelectedIndexChanged);

            cmbFacility.Init();
            cmbFacility.SelectedIndexChanged -= new System.EventHandler(this.cmbFacility_SelectedIndexChanged);
            cmbFacility.SelectedIndexChanged += new System.EventHandler(this.cmbFacility_SelectedIndexChanged);
        }

        public StatisticSearchCondition GetSearchCondition()
        {
            var con = new StatisticSearchCondition();
            con.ByDivision = chkByDivision.Checked;
            con.ByFacility = chkByFacility.Checked;
            con.ByClass = chkByClass.Checked;
            con.BySex = chkBySex.Checked;
            if (rdMale.Checked) con.Sex = Gender.Male;
            if (rdFemale.Checked) con.Sex = Gender.Female;
            if (!string.IsNullOrEmpty(txtClassName.Text)) con.ClassName = txtClassName.Text;
            if (!string.IsNullOrEmpty(cmbFacility.Text)) con.FacilityID = cmbFacility.SelectedFacilityID;
            else if (!string.IsNullOrEmpty(cmbDivision.Text)) con.DivisionID = cmbDivision.SelectedDivisionID;
            con.SortMode = LJH.GeneralLibrary.SortMode.None;
            return con;
        }

        public string GetStudentClassName()
        {
            return txtClassName.Text;
        }

        public string GetFacilityName()
        {
            return cmbFacility.Text;
        }
        #endregion

        #region 事件处理程序
        private void cmbDivision_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbFacility.SelectedIndexChanged -= new System.EventHandler(this.cmbFacility_SelectedIndexChanged);
            cmbFacility.Init(cmbDivision.SelectedDivisionID);
            txtClassName.DataSource = null;
            cmbFacility.SelectedIndexChanged += new System.EventHandler(this.cmbFacility_SelectedIndexChanged);
        }

        private void cmbFacility_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cmbFacility.SelectedFacilityID)) txtClassName.Init(_ProjectID, cmbFacility.SelectedFacilityID);
            else txtClassName.Clear();
            txtClassName.Enabled = !string.IsNullOrEmpty(cmbFacility.SelectedFacilityID) && txtClassName.Items.Count > 1;
        }
        #endregion
    }
}
