using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using HH.ZK.Model;
using HH.ZK.CommonUI;
using HH.ZK.WebAPIClient;
using LJH.GeneralLibrary;

namespace HH.ZK.UI
{
    public partial class Frm考场视频查询 : Form
    {
        public Frm考场视频查询()
        {
            InitializeComponent();
        }

        #region 事件处理程序
        private void Frm考场视频_Load(object sender, EventArgs e)
        {
            lblVideoPath.Text = $"{AppSettings.Current.GetConfigContent($"VideoFileFindPath") }";
        }

        private void lnkVideoPath_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FolderBrowserDialog frm = new FolderBrowserDialog();
            if (!string.IsNullOrEmpty(lblVideoPath.Text )) frm.SelectedPath = lblVideoPath.Text;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                lblVideoPath.Text = frm.SelectedPath;
                AppSettings.Current.SaveConfig($"VideoFileFindPath", frm.SelectedPath);
            }
        }

        private void btn查询所有视频_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblVideoPath.Text))
            {
                MessageBox.Show("请设置视频文件查找路径");
                return;
            }
            if (string.IsNullOrEmpty(txtStudentID1.Text))
            {
                MessageBox.Show("请输入要查询的准考证号");
                return;
            }
            dataGridView1.Rows.Clear();
            try
            {
                var files = Directory.GetFiles(lblVideoPath.Text, $"{txtStudentID1.Text.Trim()}*.mp4", SearchOption.AllDirectories);
                if (files != null && files.Length > 0)
                {
                    var items = (from it in files orderby it ascending select it).ToList();
                    foreach (var f in items)
                    {
                        int row = dataGridView1.Rows.Add();
                        dataGridView1.Rows[row].Cells["colPlay"].Value = "双击播放";
                        dataGridView1.Rows[row].Cells["colLocalPath"].Value = f;
                    }
                }
                else
                {
                    MessageBox.Show("没有找到相关视频");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            lblCount.Text = string.Format("共 {0} 项", dataGridView1.Rows.Count);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            try
            {
                var file = dataGridView1.Rows[e.RowIndex].Cells["colLocalPath"].Value.ToString();
                if (!string.IsNullOrEmpty(file))
                {
                    System.Diagnostics.Process.Start(file);
                }
            }
            catch
            {

            }
        }

        private void mnu播放视频_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    var file = dataGridView1.SelectedRows[0].Cells["colLocalPath"].Value.ToString();
                    if (!string.IsNullOrEmpty(file))
                    {
                        System.Diagnostics.Process.Start(file);
                    }
                }
                catch
                {

                }
            }
        }

        private void mnu打开视频所在位置_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    var file = dataGridView1.SelectedRows[0].Cells["colLocalPath"].Value.ToString();
                    if (!string.IsNullOrEmpty(file))
                    {
                        file = file.Replace('/', '\\');
                        System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo("Explorer.exe");
                        psi.Arguments = "/e,/select," + file;
                        System.Diagnostics.Process.Start(psi);
                    }
                }
                catch
                {

                }
            }
        }
        #endregion
    }
}
