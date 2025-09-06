using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using HH.ZK.Model;

namespace HH.ZK.UI
{
    public partial class Frm学生成绩导出模板设置 : Form
    {
        public Frm学生成绩导出模板设置()
        {
            InitializeComponent();
        }

        private void Frm学生成绩导出模板设置_Load(object sender, EventArgs e)
        {
            txtModelFile.Text = AppSettings.Current.GetConfigContent("ExportScoreModel");
            string temp = AppSettings.Current.GetConfigContent("ExportScoreModelTemplateRow");
            int template = 0;
            if (!string.IsNullOrEmpty(temp) && int.TryParse(temp, out template)) txtTemplateRow.IntergerValue = template;
        }

        private void btnModalBrowser_Click(object sender, EventArgs e)
        {
            OpenFileDialog dig = new OpenFileDialog();
            dig.Title = "选择模板";
            dig.Filter = "Excel文档|*.xls;*.xlsx|所有文件(*.*)|*.*";
            dig.InitialDirectory = System.IO.Path.Combine(Application.StartupPath, "模板");
            dig.RestoreDirectory = true;
            if (dig.ShowDialog() != DialogResult.OK) return;
            AppSettings.Current.SaveConfig("ExportScoreModel", dig.FileName);
            txtModelFile.Text = dig.FileName;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string model = txtModelFile.Text;
            if (string.IsNullOrEmpty(model) || !File.Exists(model))
            {
                MessageBox.Show("没有设置模板文件或模板文件不存在");
                return;
            }
            if(txtTemplateRow .IntergerValue <= 0)
            {
                MessageBox.Show("填充行不能为空");
                return;
            }
            AppSettings.Current.SaveConfig("ExportScoreModel", txtModelFile.Text);
            AppSettings.Current.SaveConfig("ExportScoreModelTemplateRow", txtTemplateRow.IntergerValue.ToString());
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
