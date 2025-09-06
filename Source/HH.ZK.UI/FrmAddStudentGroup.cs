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
    public partial class FrmAddStudentGroup : Form
    {
        private static string __FacilityID = null;
        private static Sex? __Sex = null;

        public FrmAddStudentGroup()
        {
            InitializeComponent();
        }

        public StudentGroup StudentGroup { get; set; }

        #region 重写基类方法
        private bool CheckInput()
        {
            //if (string.IsNullOrEmpty(txtFacility.Text))
            //{
            //    MessageBox.Show("请选择学校");
            //    return false;
            //}
            if (txtNumber.IntergerValue <= 0)
            {
                MessageBox.Show("请填写组号");
                return false;
            }
            if (rdMale.Checked == false && rdFemale.Checked == false)
            {
                MessageBox.Show("请选择男子或女子组");
                return false;
            }
            return true;
        }

        private StudentGroup GetItemFromInput()
        {
            var info = new StudentGroup();
            info.ID = Guid.NewGuid();
            info.PlanDate = DateTime.Now.ToString("MM月dd日") + (DateTime.Now.Hour < 13 ? "上午" : "下午");
            if (rdMale.Checked) info.Sex = Sex.Male;
            else if (rdFemale.Checked) info.Sex = Sex.Female;
            else info.Sex = null;
            //info.FacilityID = txtFacility.SelectedFacilityID;
            //info.FacilityName = txtFacility.Text;
            info.Number = txtNumber.IntergerValue;
            return info;
        }
        #endregion

        #region 事件处理程序
        private void FrmAddStudentGroup_Load(object sender, EventArgs e)
        {
            //txtFacility.Init(AppSettings.Current.PhysicalProject.ID);
            //if (!string.IsNullOrEmpty(__FacilityID)) txtFacility.SelectedFacilityID = __FacilityID;
            if (__Sex.HasValue)
            {
                rdMale.Checked = __Sex == Sex.Male;
                rdFemale.Checked = __Sex == Sex.Female;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                StudentGroup = GetItemFromInput();
                //__FacilityID = txtFacility.SelectedFacilityID;
                __Sex = rdMale.Checked ? Sex.Male : Sex.Female;
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        #endregion
    }
}
