using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HH.ZK.Model;

namespace HH.ZK.UI
{
    public partial class Frm学生特殊情况设置Detail : Form
    {
        public Frm学生特殊情况设置Detail()
        {
            InitializeComponent();
        }

        public StudentStatePara Item { get; set; }

        private void Frm学生特殊情况设置Detail_Load(object sender, EventArgs e)
        {
            txt学生状态.Init(false);
            if (Item != null)
            {
                txt学生状态.Enabled = false;
                txt学生状态.SelectedStudentState = Item.State;
                chk固定总分.Checked = Item.Total.HasValue;
                if (Item.Total.HasValue) txt总分.DecimalValue = Item.Total.Value;
                else txt总分.DecimalValue = 0;
            }
        }

        private void chk固定总分_CheckedChanged(object sender, EventArgs e)
        {
            txt总分.Enabled = chk固定总分.Checked;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty (txt学生状态.Text))
            {
                MessageBox.Show("请选择学生状态");
                return;
            }
            if (Item == null) Item = new StudentStatePara() { State = txt学生状态.SelectedStudentState };
            if (chk固定总分.Checked) Item.Total = txt总分.DecimalValue;
            else Item.Total = null;
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
