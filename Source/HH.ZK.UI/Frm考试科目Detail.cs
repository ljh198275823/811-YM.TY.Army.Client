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
using LJH.GeneralLibrary;
using LJH.GeneralLibrary.WinForm;

namespace HH.ZK.UI
{
    public partial class Frm考试科目Detail : Form
    {
        public Frm考试科目Detail()
        {
            InitializeComponent();
        }

        public PhysicalItem PhysicalItem { get; set; }

        public bool IsAdding { get; set; }

        #region 重写基类方法
        private bool CheckInput()
        {
            if (IsAdding && txtID.IntergerValue < 100)
            {
                MessageBox.Show("测试项目编号不正确,自定义编号不能小于100");
                return false;
            }
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("名称不能为空");
                txtName.Focus();
                return false;
            }
            PhysicalItem temp = new PhysicalItem { ID = txtID.IntergerValue, Name = txtName.Text, Unit = txtUnit.Text, PointCount = txtPointCount.IntergerValue };
            decimal d = 0;
            if (!string.IsNullOrEmpty(txtMin.Text.Trim()))
            {
                if (temp.TryParse(txtMin.Text.Trim(), out d))
                {
                    temp.Min = d;
                }
                else
                {
                    MessageBox.Show("最小值输入有误");
                    return false;
                }
            }
            if (!string.IsNullOrEmpty(txtMax.Text.Trim()))
            {
                if (temp.TryParse(txtMax.Text.Trim(), out d))
                {
                    temp.Max = d;
                }
                else
                {
                    MessageBox.Show("最大值输入有误");
                    return false;
                }
            }
            if (temp.Min != null && temp.Max != null && temp.Min > temp.Max)
            {
                MessageBox.Show("最小值不能比最大值还要大");
                return false;
            }
            int testCount;
            if (string.IsNullOrEmpty(txt测试次数.Text) || int.TryParse(txt测试次数.Text, out testCount) == false || testCount < 0)
            {
                MessageBox.Show("请设置科目的测试次数");
                return false;
            }
            return true;
        }

        private void ItemShowing()
        {
            txtID.IntergerValue = PhysicalItem.ID;
            txtID.Enabled = false;
            txtName.Text = PhysicalItem.Name;
            txtShortName.Text = PhysicalItem.ShortName;
            txtUnit.Text = PhysicalItem.Unit;
            txtPointCount.IntergerValue = PhysicalItem.PointCount;
            txtMax.Text = PhysicalItem.Max != null ? PhysicalItem.ConvertToStr(PhysicalItem.Max.Value) : null;
            txtMin.Text = PhysicalItem.Min != null ? PhysicalItem.ConvertToStr(PhysicalItem.Min.Value) : null;
            txt舍入方式.SelectedIndex = PhysicalItem.PrecisionMode;
            rdNone.Checked = PhysicalItem.SortMode == 0;
            rdAscending.Checked = PhysicalItem.SortMode == 1;
            rdDesending.Checked = PhysicalItem.SortMode == 2;
            chk必考.Checked = PhysicalItem.IsMust;
            rd不限男女.Checked = PhysicalItem.Gender == 0;
            rdMale.Checked = PhysicalItem.Gender == (int)Gender.Male;
            rdFemale.Checked = PhysicalItem.Gender == (int)Gender.Female;
            txt测试次数.Text = PhysicalItem.TestCount.ToString();
        }

        private void GetItemFromInput()
        {
            if (PhysicalItem == null)
            {
                PhysicalItem = new PhysicalItem() { ID = txtID.IntergerValue };
            }
            PhysicalItem.Name = txtName.Text;
            PhysicalItem.ShortName = string.IsNullOrEmpty(txtShortName.Text.Trim()) ? null : txtShortName.Text.Trim();
            PhysicalItem.Unit = txtUnit.Text;
            PhysicalItem.PointCount = txtPointCount.IntergerValue;
            PhysicalItem.PrecisionMode = txt舍入方式.SelectedIndex;
            PhysicalItem.IsMust = chk必考.Checked;
            decimal min = 0;
            if (!string.IsNullOrEmpty(txtMin.Text.Trim()) && PhysicalItem.TryParse(txtMin.Text.Trim(), out min))
            {
                PhysicalItem.Min = min;
            }
            else
            {
                PhysicalItem.Min = null;
            }
            decimal max = 0;
            if (!string.IsNullOrEmpty(txtMax.Text.Trim()) && PhysicalItem.TryParse(txtMax.Text.Trim(), out max))
            {
                PhysicalItem.Max = max;
            }
            else
            {
                PhysicalItem.Max = null;
            }
            if (rd不限男女.Checked) PhysicalItem.Gender = 0;
            else if (rdMale.Checked) PhysicalItem.Gender = (int)Gender.Male;
            else PhysicalItem.Gender = (int)Gender.Female;
            if (rdNone.Checked) PhysicalItem.SortMode = 0;
            if (rdAscending.Checked) PhysicalItem.SortMode = 1;
            if (rdDesending.Checked) PhysicalItem.SortMode = 2;
            PhysicalItem.TestCount =int.Parse ( txt测试次数.Text );
        }
        #endregion

        private void FrmPhysicalItemDetail_Load(object sender, EventArgs e)
        {
            if (PhysicalItem != null)
            {
                ItemShowing();
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                GetItemFromInput();
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
