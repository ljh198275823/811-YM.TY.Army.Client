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
using HH.ZK.Model;
using HH.ZK.Model.CRM;
using HH.ZK.WebAPIClient;
using LJH.GeneralLibrary;
using LJH.GeneralLibrary;
using LJH.GeneralLibrary.WinForm;

namespace HH.ZK.CommonUI
{
    public partial class FrmScoreCollect_Com : Form
    {
        public FrmScoreCollect_Com()
        {
            InitializeComponent();
        }

        #region 私有变量
        private List<byte> _selectedHostIds = new List<byte>();
        private PhysicalRecordBuffer _RecordBuffer = new PhysicalRecordBuffer();
        private IPhysicalRecordReader _Reader = null;
        private long _TotalCount = 0;
        private long _CurCount = 0;
        private object _GridLocker = new object();
        private string _SelectedKey = null;
        private int _CurItemCount = 0;
        private TSNUSBDataReader _TSNReader = null;
        #endregion

        #region 公共属性
        public bool Log { get; set; }
        #endregion

        #region 私有方法
        private void SelectHostIds()
        {
            FrmSelectHostIDs frmSelectHIds = new FrmSelectHostIDs();
            if (rdBatch.Checked)
            {
                frmSelectHIds.SelectSingle = true;
            }
            else
            {
                frmSelectHIds.SelectedHostIds = _selectedHostIds;
            }
            frmSelectHIds.ShowDialog();
            if (frmSelectHIds.DialogResult == DialogResult.OK)
            {
                _selectedHostIds = frmSelectHIds.SelectedHostIds;
            }
        }

        private void AddToGrid(PhysicalRecord record)
        {
            lock (_GridLocker)
            {
                dataGridView1.Rows.Insert(0, 1);
                dataGridView1.Rows[0].Tag = record;
                dataGridView1.Rows[0].DefaultCellStyle.ForeColor = Color.Red;
                dataGridView1.Rows[0].Cells["colHost"].Value = record.HostID;
                dataGridView1.Rows[0].Cells["colStudentID"].Value = record.StudentNumber;
                dataGridView1.Rows[0].Cells["colName"].Value = record.Name;
                dataGridView1.Rows[0].Cells["colSex"].Value = record.Sex;
                PhysicalItem pi = AppSettings.Current.PhysicalProject.PhysicalItems?.GetPhysicalItem(record.PhysicalItem);
                dataGridView1.Rows[0].Cells["colPhysicalItem"].Value = pi != null ? pi.Name : record.PhysicalItem.ToString();
                if (record.SpecialResult == null)
                {
                    dataGridView1.Rows[0].Cells["colScore"].Value = record.Result;
                }
                else
                {
                    if (record.SpecialResult == 0xA0) dataGridView1.Rows[0].Cells["colScore"].Value = SpecialScoreType.犯规.ToString();
                    else if (record.SpecialResult == 0xA1) dataGridView1.Rows[0].Cells["colScore"].Value = SpecialScoreType.弃考.ToString();
                    else if (record.SpecialResult == 0xA2) dataGridView1.Rows[0].Cells["colScore"].Value = SpecialScoreType.未完成.ToString();
                    else dataGridView1.Rows[0].Cells["colScore"].Value = SpecialScoreType.犯规.ToString();
                }
                dataGridView1.Rows[0].Cells["colRecordDate"].Value = record.RecordDate != null ? record.RecordDate.Value.ToString("yyyy-MM-dd HH:mm") : string.Empty;
                dataGridView1.Rows[0].Visible = ShowOrHidden(dataGridView1.Rows[0]);
                if (dataGridView1.Rows[0].Visible) _CurItemCount++;
                lblCount.Text = string.Format("总共 {0} 项", _CurItemCount);
            }
        }

        private bool ShowOrHidden(DataGridViewRow row)
        {
            if (row.Tag is StudentScore)
            {
                StudentScore score = row.Tag as StudentScore;
                int hostID = Convert.ToInt32(row.Cells["colHost"].Tag);
                if (!string.IsNullOrEmpty(_SelectedKey) && rdHost.Checked && hostID.ToString() != _SelectedKey) return false;
                if (!string.IsNullOrEmpty(_SelectedKey) && rdPhysicalItem.Checked && score.PhysicalItemID.ToString() != _SelectedKey) return false;
            }
            else if (row.Tag is PhysicalRecord)
            {
                PhysicalRecord record = row.Tag as PhysicalRecord;
                if (!string.IsNullOrEmpty(_SelectedKey) && rdHost.Checked && record.HostID.ToString() != _SelectedKey) return false;
                if (!string.IsNullOrEmpty(_SelectedKey) && rdPhysicalItem.Checked && record.PhysicalItem.ToString() != _SelectedKey) return false;
            }
            return true;
        }

        private void FilterByKey()
        {
            _CurItemCount = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Visible = ShowOrHidden(row);
                if (row.Visible) _CurItemCount++;
            }
            lblCount.Text = string.Format("共 {0} 项", _CurItemCount);
        }

        private void InitHostTree()
        {
            this.myTree1.Nodes.Clear();
            this.myTree1.Nodes.Add("所有主机");
            if (_selectedHostIds != null && _selectedHostIds.Count > 0)
            {
                foreach (byte hID in _selectedHostIds)
                {
                    this.myTree1.Nodes[0].Nodes.Add(string.Format("{0}号主机", hID)).Tag = hID.ToString();
                }
            }
            this.myTree1.ExpandAll();
        }

        private void InitPhysicalItemTree()
        {
            this.myTree1.Nodes.Clear();
            this.myTree1.Nodes.Add("所有科目");
            foreach (PhysicalItem p in AppSettings.Current.PhysicalProject.PhysicalItems.Items)
            {
                this.myTree1.Nodes[0].Nodes.Add(p.Name).Tag = p.ID;
            }
            this.myTree1.ExpandAll();
        }
        #endregion

        #region 事件处理程序
        private void Form1_Load(object sender, EventArgs e)
        {
            this.cmbCommport.Init();
            this.cmbCommport.ComPort = AppSettings.Current.HostCommport;
            btnCancel.Enabled = false;
            cmbBaud.SelectedIndex = 0;
            btnBegin.Enabled = true;
            _selectedHostIds.Clear();
            string temp = AppSettings.Current.GetConfigContent("SelectedHosts");
            if (!string.IsNullOrEmpty(temp))
            {
                string[] hs = temp.Split(',');
                foreach (string h in hs)
                {
                    byte host = 0;
                    if (!string.IsNullOrEmpty(h) && byte.TryParse(h, out host))
                    {
                        _selectedHostIds.Add(host);
                    }
                }
            }
        }

        private void btnBegin_Click(object sender, EventArgs e)
        {
            if (cmbCommport.ComPort <= 0)
            {
                MessageBox.Show("请设置正确的串口号和机器编号");
                return;
            }
            SelectHostIds();
            if (_selectedHostIds == null || _selectedHostIds.Count == 0)
            {
                MessageBox.Show("未设置主机编号.");
                return;
            }
            if (rdHost.Checked) InitHostTree();
            if (chkOldHost.Checked) _Reader = new OldHostReader(cmbCommport.ComPort, Convert.ToInt32(cmbBaud.Text));
            else _Reader = new PhysicalRecordReader(cmbCommport.ComPort, Convert.ToInt32(cmbBaud.Text));
            _Reader.Hosts = _selectedHostIds;
            _Reader.IsRealTime = rdRealTime.Checked;
            _Reader.RecordBuffer = _RecordBuffer;
            _Reader.Log = true;
            _Reader.ReadCompleted += new EventHandler(_Reader_ReadCompleted);
            _Reader.Open();
            _CurCount = 0;
            btnCancel.Enabled = true;
            btnBegin.Enabled = false;
            timer1.Enabled = true;

            string temp = string.Empty;
            foreach (byte host in _selectedHostIds)
            {
                temp += host.ToString() + ",";
            }
            AppSettings.Current.SaveConfig("SelectedHosts", temp);
        }

        private void _Reader_ReadCompleted(object sender, EventArgs e)
        {
            Action action = delegate ()
            {
                btnBegin.Enabled = true;
                btnCancel.Enabled = false;
                MessageBox.Show("数据采集完成，您还可以继续采集其它主机的数据", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            };
            this.Invoke(action);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (_Reader != null) _Reader.Close();
            btnBegin.Enabled = true;
            btnCancel.Enabled = false;
        }

        private void FrmScoreCollect_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_Reader != null) _Reader.Close();
            if (timer1.Enabled) timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var items = _RecordBuffer.Read();
            lblPic.Image = items != null ? Properties.Resources.reddot : Properties.Resources.greydot;
            this.statusStrip1.Refresh();
            if (items != null)
            {
                foreach (var item in items)
                {
                    if (!item.Invalid)//如果不是无效记录
                    {
                        _TotalCount++;
                        _CurCount++;
                        AddToGrid(item);
                        PhysicalScoresSavingService.Current?.AddScore(item, ScoreSource.汇海主机);
                    }
                }
            }
            lblCurCount.Text = _CurCount.ToString();
            lblToal.Text = _TotalCount.ToString();
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
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("保存到电子表格时出现错误! 原因：{0}", ex.Message));
            }
        }

        private void cmbCommport_SelectedIndexChanged(object sender, EventArgs e)
        {
            AppSettings.Current.HostCommport = cmbCommport.ComPort;
        }

        private void rdHost_CheckedChanged(object sender, EventArgs e)
        {
            InitHostTree();
            _SelectedKey = null;
            FilterByKey();
        }

        private void rdPhysicalItem_CheckedChanged(object sender, EventArgs e)
        {
            InitPhysicalItemTree();
            _SelectedKey = null;
            FilterByKey();
        }

        private void myTree1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            _SelectedKey = e.Node.Tag != null ? e.Node.Tag.ToString() : null;
            FilterByKey();
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            if (timer2.Enabled)
            {
                _TSNReader.StopRead();
            }
            else
            {
                FrmTsnConnect frm = new FrmTsnConnect();
                _TSNReader = new TSNUSBDataReader();
                _TSNReader.Log = chkLog.Checked;
                frm.TSNReader = _TSNReader;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    timer2.Enabled = true;
                    _TSNReader.BeginRead(frm.SelectedClass);
                    button1.Text = "停止有线数据传输";
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            PhysicalRecord item = _TSNReader.Read();
            lblPic.Image = item != null ? Properties.Resources.reddot : Properties.Resources.greydot;
            this.statusStrip1.Refresh();
            while (item != null)
            {
                if (!item.Invalid)//如果不是无效记录
                {
                    _TotalCount++;
                    _CurCount++;
                    AddToGrid(item);
                    PhysicalScoresSavingService.Current?.AddScore(item, ScoreSource.其它设备);
                }
                item = _TSNReader.Read();
            }
            lblCurCount.Text = _CurCount.ToString();
            lblToal.Text = _TotalCount.ToString();
            if (_TSNReader.IsComplete)
            {
                timer2.Enabled = false;
                button1.Text = "体适能主机有线数据传输";
                MessageBox.Show("数据传输完成!");
            }
        }
    }
}
