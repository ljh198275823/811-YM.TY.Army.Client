using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HH.ZK.Model;

namespace HH.ZK.CommonUI
{
    public partial class Frm设置考试状态 : Form
    {
        public Frm设置考试状态()
        {
            InitializeComponent();
        }

        public HH.ZK.Model.StudentState StudentState { get; set; }

        private void Frm设置特殊情况_Load(object sender, EventArgs e)
        {
            txt考试状态.Init(AppSettings.Current.PhysicalProject.StateSettings, true);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt考试状态.Text))
            {
                MessageBox.Show("请指定一个学生状态");
                return;
            }
            StudentState = txt考试状态.SelectedStudentState;
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
