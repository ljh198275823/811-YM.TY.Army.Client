using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using HH.Zhongkao .Device;
using HH.Zhongkao.Device.Wifi;
using HH.ZK.Model;
using LJH.GeneralLibrary.WinForm;

namespace HH.ZK.CommonUI
{
    public partial class FrmScoreCollect_Wifi : Form
    {
        public FrmScoreCollect_Wifi()
        {
            InitializeComponent();
        }

        #region 私有变量
        private HostWifiReader _Reader = null;
        private object _GridLocker = new object();
        private int _CurItemCount = 0;
        private List<PhysicalRecord> _Records = new List<PhysicalRecord>();
        #endregion

        #region 公共属性
        public HostWifiReader Reader
        {
            get { return _Reader; }
            set
            {
                _Reader = value;
                Reader.PhysicalRecordReceived -= new PhysicalRecordReceivedHandler(Reader_PhysicalRecordReceived);
                Reader.PhysicalRecordReceived += new PhysicalRecordReceivedHandler(Reader_PhysicalRecordReceived);
                _Reader.Open();
            }
        }
        #endregion

        #region 私有方法
        private void Reader_PhysicalRecordReceived(object sender, PhysicalRecordReceivedArgs e)
        {
            Action action = delegate ()
            {
                try
                {
                    foreach (var item in e.Records)
                    {
                        if (!item.Invalid)//如果不是无效记录
                        {
                            if (_Reader.IsRealTime && (item.RecordDate.HasValue == false || item.RecordDate.Value.Year == 2000)) item.RecordDate = DateTime.Now;  //实时采集时时间没同步的记录按当前时间为测试时间
                            LJH.GeneralLibrary.FileLog.Log("原始采集记录", item.ToString());
                            _Records.Add(item);
                            ShowRecord(item);
                            PhysicalScoresSavingService.Current?.AddScore(item, ScoreSource.汇海主机, Reader.HostSN);
                        }
                    }
                    lblCount.Text = string.Format("采集到 {0} 条记录  总共 {1} 条记录", e.Records.Count, dataGridView1.Rows.Count);
                    this.statusStrip1.Refresh();
                }
                catch (Exception ex)
                {
                    LJH.GeneralLibrary.ExceptionPolicy.HandleException(ex);
                }
            };
            this.Invoke(action);
        }

        private void ShowRecord(PhysicalRecord record)
        {
            lock (_GridLocker)
            {
                dataGridView1.Rows.Insert(0, 1);
                dataGridView1.Rows[0].Tag = record;
                dataGridView1.Rows[0].DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
                dataGridView1.Rows[0].Cells["colSN"].Value = record.SN;
                dataGridView1.Rows[0].Cells["colStudentID"].Value = record.StudentNumber;
                dataGridView1.Rows[0].Cells["colName"].Value = record.Name;
                dataGridView1.Rows[0].Cells["colSex"].Value = record.Sex;
                PhysicalItem pi = AppSettings.Current.PhysicalProject.PhysicalItems?.GetPhysicalItem(record.PhysicalItem);
                dataGridView1.Rows[0].Cells["colPhysicalItem"].Value = pi != null ? pi.Name : record.PhysicalItem.ToString();
                if (record.SpecialResult == null)
                {
                    dataGridView1.Rows[0].Cells["colScore"].Value = record.Result;
                    dataGridView1.Rows[0].Cells["col犯规次数"].Value = record.FGCount;
                }
                else
                {
                    if (record.SpecialResult == 0xA0) dataGridView1.Rows[0].Cells["colScore"].Value= SpecialScoreType.犯规.ToString();
                    else if (record.SpecialResult == 0xA1) dataGridView1.Rows[0].Cells["colScore"].Value = SpecialScoreType.弃考.ToString();
                    else if (record.SpecialResult == 0xA2) dataGridView1.Rows[0].Cells["colScore"].Value = SpecialScoreType.未完成.ToString();
                    else dataGridView1.Rows[0].Cells["colScore"].Value = SpecialScoreType.犯规.ToString();
                }
                dataGridView1.Rows[0].Cells["colRecordDate"].Value = record.RecordDate != null ? record.RecordDate.Value.ToString("yyyy-MM-dd HH:mm:ss") : string.Empty;
                if (AppSettings.Current.PhysicalProject.StartDate > record.RecordDate || record.RecordDate > AppSettings.Current.PhysicalProject.EndDate)
                {
                    dataGridView1.Rows[0].Cells["colMemo"].Value = "测试时间不在范围内";
                    dataGridView1.Rows[0].DefaultCellStyle.ForeColor = System.Drawing.Color.Red;
                }
                if (dataGridView1.Rows[0].Visible) _CurItemCount++;
                lblCount.Text = string.Format("总共 {0} 项", _CurItemCount);
            }
        }
        #endregion

        #region 事件处理程序
        private void FrmScoreCollect_Wifi_Load(object sender, EventArgs e)
        {
        }

        private void mnu_Clear_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            _Records.Clear();
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

        private void 查看统计信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int startSN = 0;
            int endSN = 0;
            int valid = 0;
            int invalid = 0;
            int total = 0;
            int missed = 0;
            decimal min = 0;
            decimal max = 0;
            string StrMissed = string.Empty;
            if (_Records != null || _Records.Count > 0)
            {
                var items = (from it in _Records
                             orderby it.SN ascending
                             select it).ToList();
                valid = _Records.Count;
                invalid = dataGridView1.Rows.Count - valid;
                total = dataGridView1.Rows.Count;
                startSN = items[0].SN;
                foreach (var record in items)
                {
                    if (record != null)
                    {
                        if (endSN != 0 && record.SN - endSN > 1)
                        {
                            for (int i = endSN + 1; i < record.SN; i++)
                            {
                                missed++;
                                StrMissed += i.ToString() + ",";
                            }
                        }
                        if (endSN == 0 || endSN < record.SN) endSN = record.SN;
                        if (min == 0 || min > record.Result) min = record.Result;
                        if (max == 0 || max < record.Result) max = record.Result;
                    }
                }
            }
            FrmScoreCollectStatitics frm = new FrmScoreCollectStatitics();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.Host = this.Text;
            frm.startSN = startSN;
            frm.endSN = endSN;
            frm.valid = valid;
            frm.invalid = invalid;
            frm.total = total;
            frm.missed = missed;
            frm.StrMissed = StrMissed;
            frm.min = min;
            frm.max = max;
            frm.ShowDialog();
        }
        #endregion

        #region 公共方法
        public void ShowPhysicalRecords(List<PhysicalRecord> records)
        {
            foreach (var item in records)
            {
                if (!item.Invalid)//如果不是无效记录
                {
                    _Records.Add(item);
                    ShowRecord(item);
                }
                else
                {
                    var f = item;
                }
            }
            lblCount.Text = string.Format("采集到 {0} 条记录  总共 {1} 条记录", records.Count, dataGridView1.Rows.Count);
            this.statusStrip1.Refresh();
        }
        #endregion
    }
}
