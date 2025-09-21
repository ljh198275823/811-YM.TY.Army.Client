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
using HH.ZK.WebAPIClient;
using HH.ZK.CommonUI;
using LJH.GeneralLibrary;
using LJH.GeneralLibrary.WinForm;
using LJH.GeneralLibrary;

namespace HH.ZK.UI
{
    public partial class Frm增加成绩 : Form
    {
        public Frm增加成绩()
        {
            InitializeComponent();
        }

        #region 公共属性
        public Student Student { get; set; }

        public PhysicalItem PhysicalItem { get; set; }

        public StudentScore Score { get; set; }
        #endregion

        #region 私有方法
        private bool CheckInput()
        {
            if (Student == null)
            {
                MessageBox.Show("没有指定学生");
                return false;
            }
            if (PhysicalItem == null)
            {
                MessageBox.Show("没有指定体能测试项目");
                return false;
            }
            if (rd免考.Checked || rd犯规.Checked || rd弃考.Checked || rd伤病.Checked || rd残疾.Checked || rd未完成.Checked)
            {
            }
            else
            {
                decimal dv = 0;
                if (!PhysicalItem.TryParse(txtScore.Text, out dv))
                {
                    MessageBox.Show("输入的成绩格式不正确");
                    return false;
                }
                if (PhysicalItem.Min != null && dv < PhysicalItem.Min.Value)
                {
                    MessageBox.Show(string.Format("输入的成绩小于 {0} 的最小成绩 {1}", PhysicalItem.Name, PhysicalItem.ConvertToStr(PhysicalItem.Min.Value)));
                    return false;
                }

                if (PhysicalItem.Max != null && dv > PhysicalItem.Max.Value)
                {
                    MessageBox.Show(string.Format("输入的成绩大于 {0} 的最大成绩 {1}", PhysicalItem.Name, PhysicalItem.ConvertToStr(PhysicalItem.Max.Value)));
                    return false;
                }
                if (PhysicalItem.Unit == "分.秒") //小数点后面的部分不能大于0.59 表示的秒数
                {
                    if ((dv - (long)dv) >= 0.6m)
                    {
                        MessageBox.Show("成绩的秒部分输入有错,不能大于0.59");
                        return false;
                    }
                }
            }
            return true;
        }
        #endregion

        #region 事件处理程序
        private void Frm增加成绩_Load(object sender, EventArgs e)
        {
            btnOk.Enabled = AppSettings.Current.Operator.PermitAny(Permission.StudentScore, PermissionActions.Edit);
            if (Student != null)
            {
                txtID.Text = Student.ID;
                txtID.Enabled = false;
                txtName.Text = Student.Name;
                txtFacility.Text = Student.DivisionName;
                if (Student.Gender == Gender.Male)
                {
                    rdMale.Checked = true;
                }
                else
                {
                    rdFemale.Checked = true;
                }
            }
            if (PhysicalItem != null)
            {
                lblPhysicalItem.Text = PhysicalItem.Name;
                lblUnit.Text = PhysicalItem.Unit;
            }
        }
        #endregion

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (CheckInput() == false) return;
            StudentRawScore raw = new StudentRawScore() { ID = Guid.NewGuid() };
            raw.StudentID = Student.ID;
            raw.TestID = PhysicalItem.ID;
            raw.ScoreFrom = ScoreSource.手工录入;
            if (rd免考.Checked || rd犯规.Checked || rd弃考.Checked || rd伤病.Checked || rd残疾.Checked || rd未完成.Checked)
            {
                if (rd免考.Checked) raw.SpecialType = SpecialScoreType.免考;
                else if (rd犯规.Checked) raw.SpecialType = SpecialScoreType.犯规;
                else if (rd弃考.Checked) raw.SpecialType = SpecialScoreType.弃考;
                else if (rd伤病.Checked) raw.SpecialType = SpecialScoreType.伤病;
                else if (rd残疾.Checked) raw.SpecialType = SpecialScoreType.残疾;
                else if (rd未完成.Checked) raw.SpecialType = SpecialScoreType.未完成;
            }
            else
            {
                decimal dv = 0;
                PhysicalItem.TryParse(txtScore.Text, out dv);
                raw.Score = dv.ToString ();
            }
            var ret = new APIClient(AppSettings.Current.ConnStr).BatchAddScores(new List<StudentRawScore>() { raw }, ImportOption.Append, AppSettings.Current.PhysicalProject.ID);
            if (ret.Result == ResultCode.Successful && ret.Value != null && ret.Value.Successes != null && ret.Value.Successes.ContainsKey(raw.ID))
            {
                this.Score = ret.Value.Successes[raw.ID];
                this.DialogResult = DialogResult.OK;
            }
            else if (ret.Result == ResultCode.Fail)
            {
                MessageBox.Show(ret.Message);
            }
            else if (ret.Result == ResultCode.Successful && ret.Value != null && ret.Value.Errors != null && ret.Value.Errors.ContainsKey(raw.ID))
            {
                MessageBox.Show(ret.Value.Errors[raw.ID]);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
