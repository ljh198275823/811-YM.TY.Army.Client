using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LJH.GeneralLibrary.SoftDog;

namespace HH.ZK.CommonUI
{
    public partial class FrmUKey初始化 : Form
    {
        public FrmUKey初始化()
        {
            InitializeComponent();
        }

        public SoftwareType SoftWareType { get; set; }

        public string School
        {
            get { return txtSchool.Text; }
        }

        private string GetSoftType()
        {
            switch (SoftWareType)
            {
                case SoftwareType.TYPE_汇海学生体测软件:
                    return "学生体测软件";
                case SoftwareType.TYPE_汇海中考软件:
                    return "中考软件";
                case SoftwareType.TYPE_汇海国民体测软件:
                    return "国民体测软件";
                case SoftwareType.TYPE_汇海运动会软件:
                    return "运动会软件";
                default:
                    return string.Empty;
            }
        }

        private void FrmUKey初始化_Load(object sender, EventArgs e)
        {
            lblTitle.Text = string.Format("加密狗需要进行初始化，初始化成功后，加密狗只能在 {0} 上使用，如果你的加密狗是其它用途的加密狗，请在对应的软件上进行初始化。", GetSoftType());
            gpDogInit.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn初始化_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSchool.Text))
            {
                MessageBox.Show("你没有填写学校信息");
                return;
            }
            this.DialogResult = DialogResult.OK;
        }
    }
}
