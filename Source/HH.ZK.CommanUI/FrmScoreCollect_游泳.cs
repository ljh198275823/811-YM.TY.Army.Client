using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;
using System.Diagnostics;
using System.Windows.Forms;
using HH.Zhongkao.Device;
using HH.Zhongkao.Device.澳亚特;
using HH.ZK.Model;
using HH.ZK.Model.CRM;
using LJH.GeneralLibrary;
using LJH.GeneralLibrary;
using LJH.GeneralLibrary.WinForm;

namespace HH.ZK.CommonUI
{
    public partial class FrmScoreCollect_游泳 : Form
    {
        public FrmScoreCollect_游泳()
        {
            InitializeComponent();
        }

        #region 私有变量
        private long _TotalCount = 0;
        private long _CurCount = 0;
        private object _GridLocker = new object();

        private int _CurItemCount = 0;
        #endregion

        #region 公共属性
        public bool Log { get; set; }
        #endregion

        #region 私有方法
        private void AddToGrid(PhysicalRecord record)
        {
            lock (_GridLocker)
            {
                dataGridView1.Rows.Insert(0, 1);
                dataGridView1.Rows[0].Tag = record;
                dataGridView1.Rows[0].DefaultCellStyle.ForeColor = Color.Red;
                dataGridView1.Rows[0].Cells["colSer"].Value = record.SN;
                dataGridView1.Rows[0].Cells["colStudentID"].Value = record.StudentNumber;
                dataGridView1.Rows[0].Cells["colName"].Value = record.Name;
                dataGridView1.Rows[0].Cells["colSex"].Value = record.Sex;
                PhysicalItem pi = AppSettings.Current.PhysicalProject.PhysicalItems?.GetPhysicalItem(record.PhysicalItem);
                if (pi != null)
                {
                    dataGridView1.Rows[0].Cells["colPhysicalItem"].Value = string.Format("{0}", pi.Name);
                    dataGridView1.Rows[0].Cells["colUnit"].Value = pi.Unit;
                    if (pi.Unit == "分.秒") record.Result = PhysicalItem.ConvertToMinuteSecond(record.Result);
                    dataGridView1.Rows[0].Cells["colScore"].Value = pi.ConvertToStr(record.Result);
                }
                else
                {
                    dataGridView1.Rows[0].Cells["colPhysicalItem"].Value = record.PhysicalItem;
                    dataGridView1.Rows[0].Cells["colUnit"].Value = string.Empty;
                    dataGridView1.Rows[0].Cells["colScore"].Value = record.Result;
                }
                dataGridView1.Rows[0].Cells["colRecordDate"].Value = record.RecordDate != null ? record.RecordDate.Value.ToString("yyyy-MM-dd HH:mm") : string.Empty;
                if (dataGridView1.Rows[0].Visible) _CurItemCount++;
                lblCount.Text = string.Format("总共 {0} 项", _CurItemCount);
            }
        }
        #endregion

        #region 事件处理程序
        private void Form1_Load(object sender, EventArgs e)
        {
            btnCancel.Enabled = false;
            btnBegin.Enabled = true;
            txtPath.Text = AppSettings.Current.GetConfigContent("YY_SyncFolder");
        }

        private void btnModalBrowser_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog frm = new FolderBrowserDialog();
            if (!string.IsNullOrEmpty(txtPath.Text)) frm.SelectedPath = txtPath.Text;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = frm.SelectedPath;
            }
        }

        private void btnBegin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPath.Text) && Directory.Exists(txtPath.Text))
            {
                _CurCount = 0;
                btnCancel.Enabled = true;
                btnBegin.Enabled = false;
                AppSettings.Current.SaveConfig("YY_SyncFolder", txtPath.Text);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnBegin.Enabled = true;
            btnCancel.Enabled = false;
        }

        private void FrmScoreCollect_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //var items = _RecordBuffer.Read();
            //lblPic.Image = items != null ? Properties.Resources.reddot : Properties.Resources.greydot;
            //this.statusStrip1.Refresh();
            //if (items != null)
            //{
            //    if (_Reader != null && _Reader.IsRealTime) AppSettings.Current.SaveConfig("AoYeTeLastSN", _Reader.LastSN.ToString());
            //    foreach (var item in items)
            //    {
            //        if (!item.Invalid)//如果不是无效记录
            //        {
            //            _TotalCount++;
            //            _CurCount++;
            //            AddToGrid(item);
            //            PhysicalScoresSavingService.Current?.AddScore(item, ScoreSource.电动计时, txtIP.IP);
            //        }
            //    }
            //}
            //lblCurCount.Text = _CurCount.ToString();
            //lblToal.Text = _TotalCount.ToString();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridView view = this.dataGridView1;
                if (view != null)
                {
                    SaveFileDialog dig = new SaveFileDialog();
                    dig.Filter = "Excel文档|*.xls;*.xlsx|所有文件(*.*)|*.*";
                    dig.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    if (dig.ShowDialog() == DialogResult.OK)
                    {
                        string path = dig.FileName;
                        lock (_GridLocker)
                        {
                            NPOIExcelHelper.Export(view, path);
                        }
                        MessageBox.Show("导出成功");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("保存到电子表格时出现错误!");
            }
        }
        #endregion
    }
}