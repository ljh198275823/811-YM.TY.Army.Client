using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net;
using System.IO;
using System.Linq;
using System.Drawing.Imaging;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;
using FluxJpeg.Core;
using FluxJpeg.Core.Decoder;
using FluxJpeg.Core.Filtering;
using HH.ZK.Model;
using HH.ZK.Model.CRM;
using HH.ZK.WebAPIClient;
using HH.Zhongkao.Device;
using HH.Zhongkao.Device.Wifi;

namespace HH.ZK.CommonUI
{
    public partial class FrmHosts : Form
    {
        public FrmHosts()
        {
            InitializeComponent();
        }

        #region 私有变量
        private readonly int _Port = 10000;
        private List<FrmScoreCollect_Wifi> _OpenFrms = new List<FrmScoreCollect_Wifi>();
        private List<FrmProcessing> _ProcessingForms = new List<FrmProcessing>();
        private int _Rows = 1;
        private int _Columns = 1;
        private Thread _SearchThread = null;
        private List<PhysicalItem> _AllPhysicalItems = null;
        #endregion

        #region 私有方法
        private void StartCollect(bool realTime, HostWifiReaderPara para)
        {
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                var row = dataGridView2.Rows[i];
                if (row.Selected && row.Tag == null && Convert.ToBoolean(row.Cells["colCheck"].EditedFormattedValue))
                {
                    try
                    {
                        var hi = row.Cells["colSer"].Tag as WifiHostInfo;
                        var reader = HostWifiReader.CreateInstance(hi.HostID, hi.IP, hi.LocalIP);
                        reader.IsRealTime = realTime;
                        reader.ReadPara = para;
                        reader.HostSN = row.Cells["colSer"].Value.ToString();
                        reader.UnSerialable = !realTime && reader.ReadPara.CollectType == 2; //按学号范围进行集中上传时记录可能是不连接的
                        reader.Log = chkLog.Checked;
                        reader.StateChanged += new EventHandler(reader_StateChanged);
                        row.Tag = reader;
                        row.Cells["colOperation"].Value = realTime ? "实时采集" : "集中采集";
                        row.DefaultCellStyle.ForeColor = Color.Black;
                        var frm = OpenCollectForm(row.Cells["colIP"].Value.ToString(), byte.Parse(row.Cells["colHostID"].Value.ToString()), row.Cells["colSer"].Value.ToString(), row.Cells["colPhysicalItem"].Value.ToString(), reader);
                    }
                    catch (Exception ex)
                    {
                        LJH.GeneralLibrary.ExceptionPolicy.HandleException(ex);
                    }
                }
            }
            RenderForms();
        }

        private FrmScoreCollect_Wifi OpenCollectForm(string ip, byte hostID, string serNum, string physical, HostWifiReader reader)
        {
            foreach (FrmScoreCollect_Wifi frm in _OpenFrms)
            {
                if (frm.Tag.ToString() == serNum)
                {
                    frm.Reader = reader;
                    return frm;
                }
            }
            FrmScoreCollect_Wifi frmC = new FrmScoreCollect_Wifi();
            frmC.Tag = serNum;
            frmC.Text = string.Format("主机{0}_{1}_{2}", hostID, serNum, physical);
            frmC.Reader = reader;
            frmC.MdiParent = this;
            frmC.FormClosed += new FormClosedEventHandler(frmC_FormClosed);
            frmC.Show();
            frmC.Activate();
            _OpenFrms.Add(frmC);
            return frmC;
        }

        private void frmC_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmScoreCollect_Wifi frm = sender as FrmScoreCollect_Wifi;
            _OpenFrms.Remove(frm);
            var reader = frm.Reader;
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if (row.Tag == reader)
                {
                    row.Cells["colOperation"].Value = string.Empty;
                    row.Tag = null;
                    reader.Close();
                }
            }
            RenderForms();
        }

        private void RenderForms()
        {
            if (_OpenFrms.Count == 1) _Columns = 1;
            else if (_OpenFrms.Count <= 4) _Columns = 2;
            else _Columns = 3;
            _Rows = (int)(Math.Ceiling((decimal)_OpenFrms.Count / _Columns));
            if (_Rows == 0) _Rows = 1;
            MdiClient mc = null;
            foreach (var ctrl in this.Controls)
            {
                if (ctrl is MdiClient) mc = ctrl as MdiClient;
            }
            if (mc == null) return;
            int width = (mc.Width - 5) / _Columns;
            int height = (mc.Height - 5) / _Rows;

            for (int r = 0; r < _Rows; r++)
            {
                int top = r * height;
                for (int c = 0; c < _Columns; c++)
                {
                    int left = c * width;
                    int id = r * _Columns + c;
                    if (_OpenFrms.Count >= id + 1)
                    {
                        var frm = _OpenFrms[id];
                        frm.Location = new Point(left, top);
                        frm.Width = width;
                        frm.Height = height;
                    }
                }
            }
        }

        private void RenderProcessingForms()
        {
            if (_ProcessingForms.Count == 0) return;
            int rows = _ProcessingForms.Count;
            int columns = 2;
            MdiClient mc = null;
            foreach (var ctrl in this.Controls)
            {
                if (ctrl is MdiClient) mc = ctrl as MdiClient;
            }
            if (mc == null) return;

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    int id = r * columns + c;
                    if (_ProcessingForms.Count >= id + 1)
                    {
                        var frm = _ProcessingForms[id];
                        int top = r * frm.Height;
                        int left = c * frm.Width;
                        frm.Location = new Point(left, top);
                    }
                }
            }
        }
        #endregion

        #region 事件处理程序
        private void Form1_Load(object sender, EventArgs e)
        {
            _AllPhysicalItems = AppSettings.Current.PhysicalProject?.PhysicalItems.Items;
        }

        protected override void OnClientSizeChanged(EventArgs e)
        {
            RenderForms();
            base.OnClientSizeChanged(e);
        }

        private void reader_StateChanged(object sender, EventArgs e)
        {
            Action action = delegate ()
            {
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    if (object.ReferenceEquals(row.Tag, sender))
                    {
                        var reader = row.Tag as HostWifiReader;
                        row.DefaultCellStyle.ForeColor = reader.State == 0 ? Color.Black : Color.Red;
                        row.Selected = false;
                    }
                }
            };
            this.Invoke(action);
        }

        private void FrmHosts_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("是否关闭此窗口?", "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No) e.Cancel = true;
            foreach (var frm in _OpenFrms)
            {
                FrmScoreCollect_Wifi frm1 = frm as FrmScoreCollect_Wifi;
                if (frm1 != null)
                {
                    var reader = frm1.Reader;
                    reader.Close();
                }
            }
            if (_SearchThread != null) _SearchThread.Abort();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (btnSearch.Text != "搜索主机")
            {
                btnSearch.Text = "搜索主机";
                btnSearch.BackColor = Color.Blue;
                if (_SearchThread != null) _SearchThread.Abort();
            }
            else
            {
                btnSearch.Text = "停止搜索";
                btnSearch.BackColor = Color.Red;
                List<DataGridViewRow> delRows = new List<DataGridViewRow>();
                foreach (DataGridViewRow row in this.dataGridView2.Rows)
                {
                    if (row.Tag == null) delRows.Add(row);
                }
                foreach (DataGridViewRow row in delRows)
                {
                    this.dataGridView2.Rows.Remove(row);
                }
                _SearchThread = new Thread(new ThreadStart(Search_Thread));
                _SearchThread.IsBackground = true;
                _SearchThread.Start();
            }
        }

        private void Search_Thread()
        {
            try
            {
                int timeout = 2000;
                for (int i = 0; i < int.MaxValue; i++)
                {
                    try
                    {
                        var hosts = WifiSearcher.Search(timeout);
                        Action action = delegate ()
                        {
                            if (hosts != null && hosts.Count > 0)
                            {
                                hosts.ForEach(it => ShowHostInfo(it));
                            }
                        };
                        this.Invoke(action);
                        if (timeout < 10000) timeout += 2000;
                        else timeout = 2000;
                    }
                    catch (ThreadAbortException)
                    {
                        break;
                    }
                    catch (Exception)
                    {
                    }
                }
            }
            catch (ThreadAbortException)
            {
            }
            catch (Exception)
            {
            }
        }

        private void ShowHostInfo(WifiHostInfo host)
        {
            DataGridViewRow existsRow = null;
            PhysicalItem pi = _AllPhysicalItems?.SingleOrDefault(it => it.ID == host.PhysicalID);
            foreach (DataGridViewRow r in dataGridView2.Rows)
            {
                if (r.Cells["colSer"].Value != null && r.Cells["colSer"].Value.ToString() == host.SerialNumber) //相同序列号当成同一个设备
                {
                    if (r.Cells["colIP"].Value.ToString() != host.IP && r.Tag != null && r.Tag is HostWifiReader) //如果本主机正在采集数据，并且前后IP不一样，则将当前采集换成新IP
                    {
                        HostWifiReader reader = r.Tag as HostWifiReader;
                        reader.IP = host.IP;
                        reader.Port = _Port;
                        reader.HostID = host.HostID;
                    }
                    r.Cells["colIP"].Value = host.IP;
                    r.Cells["colSer"].Value = host.SerialNumber;
                    r.Cells["colSer"].Tag = host;
                    r.Cells["colHostID"].Value = host.HostID;
                    r.Cells["colPhysicalItem"].Value = pi != null ? pi.Name : string.Empty;
                    existsRow = r;
                    break;
                }
            }
            if (existsRow == null)
            {
                int rIndex = -1;
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    byte h = byte.Parse(row.Cells["colHostID"].Value.ToString());
                    if (h > host.HostID)
                    {
                        rIndex = row.Index;
                        break;
                    }
                }
                if (rIndex < 0) rIndex = dataGridView2.Rows.Add();
                else dataGridView2.Rows.Insert(rIndex, 1);
                dataGridView2.Rows[rIndex].Cells["colIP"].Value = host.IP;
                dataGridView2.Rows[rIndex].Cells["colHostID"].Value = host.HostID;
                dataGridView2.Rows[rIndex].Cells["colSer"].Value = host.SerialNumber;
                dataGridView2.Rows[rIndex].Cells["colSer"].Tag = host;
                dataGridView2.Rows[rIndex].Cells["colPhysicalItem"].Value = pi != null ? pi.Name : string.Empty;
            }
            dataGridView2.Refresh();
            lblCount.Text = string.Format("共有 {0} 台主机", dataGridView2.Rows.Count);
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                row.Cells["colCheck"].Value = true;
            }
        }

        private void btnNone_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                row.Cells["colCheck"].Value = false;
            }
        }

        private void btnRevert_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                row.Cells["colCheck"].Value = row.Cells["colCheck"].Value != null && (bool)(row.Cells["colCheck"].Value) ? false : true;
            }
        }

        #endregion

        #region 数据采集相关
        private void mnu_开始实时采集_Click(object sender, EventArgs e)
        {
            StartCollect(true, null);
        }

        private void 结束实时采集ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView2.SelectedRows)
            {
                if (row.Tag != null)
                {
                    var reader = row.Tag as HostWifiReader;
                    if (reader != null && reader.IsRealTime) //只结束实时采集
                    {
                        reader.Close();
                        row.Cells["colOperation"].Value = string.Empty;
                        row.Tag = null;
                    }
                }
            }
        }

        private void mnu_开始集中采集_Click(object sender, EventArgs e)
        {
            HostWifiReaderPara para = new HostWifiReaderPara() { CollectType = 0 };
            int count = 0;
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                var row = dataGridView2.Rows[i];
                if (row.Selected && row.Tag == null && Convert.ToBoolean(row.Cells["colCheck"].EditedFormattedValue))
                {
                    Start集中采集(row, para);
                    count++;
                }
            }
            if (count > 0) RenderProcessingForms();
        }

        private void 集中采集剩余数据ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HostWifiReaderPara para = new HostWifiReaderPara() { CollectType = 1 };
            int count = 0;
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                var row = dataGridView2.Rows[i];
                if (row.Selected && row.Tag == null && Convert.ToBoolean(row.Cells["colCheck"].EditedFormattedValue))
                {
                    Start集中采集(row, para);
                    count++;
                }
            }
            if (count > 0) RenderProcessingForms();
        }

        private void 指定学号的数据ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStudentIDRange frm = new FrmStudentIDRange();
            frm.StartPosition = FormStartPosition.CenterParent;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                HostWifiReaderPara para = new HostWifiReaderPara()
                {
                    CollectType = 2,
                    BeginSid = frm.BeginSid,
                    EndSid = frm.EndSid
                };
                int count = 0;
                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    var row = dataGridView2.Rows[i];
                    if (row.Selected && row.Tag == null && Convert.ToBoolean(row.Cells["colCheck"].EditedFormattedValue))
                    {
                        Start集中采集(row, para);
                        count++;
                    }
                }
                if (count > 0) RenderProcessingForms();
            }
        }

        private void 集中采集指定时间段的数据ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDateRange frm = new FrmDateRange();
            frm.StartPosition = FormStartPosition.CenterParent;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                HostWifiReaderPara para = new HostWifiReaderPara()
                {
                    CollectType = 3,
                    BeginDt = frm.BeginDt,
                    EndDt = frm.EndDt
                };
                int count = 0;
                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    var row = dataGridView2.Rows[i];
                    if (row.Selected && row.Tag == null && Convert.ToBoolean(row.Cells["colCheck"].EditedFormattedValue))
                    {
                        Start集中采集(row, para);
                        count++;
                    }
                }
                if (count > 0) RenderProcessingForms();
            }
        }

        private void 指定序列号段的数据ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSerialRange frm = new FrmSerialRange();
            frm.StartPosition = FormStartPosition.CenterParent;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                HostWifiReaderPara para = new HostWifiReaderPara()
                {
                    CollectType = 4,
                    BeginSer = frm.BeginSer,
                    EndSer = frm.EndSer
                };
                int count = 0;
                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    var row = dataGridView2.Rows[i];
                    if (row.Selected && row.Tag == null && Convert.ToBoolean(row.Cells["colCheck"].EditedFormattedValue))
                    {
                        Start集中采集(row, para);
                        count++;
                    }
                }
                if (count > 0) RenderProcessingForms();
            }
        }

        private void Start集中采集(DataGridViewRow row, HostWifiReaderPara para)
        {
            List<PhysicalRecord> records = new List<PhysicalRecord>();
            var hi = row.Cells["colSer"].Tag as WifiHostInfo;
            var reader = HostWifiReader.CreateInstance(hi.HostID, hi.IP, hi.LocalIP);
            reader.IsRealTime = false;
            reader.ReadPara = para;
            reader.HostSN = row.Cells["colSer"].Value.ToString();
            reader.UnSerialable = reader.ReadPara.CollectType == 2; //按学号范围进行集中上传时记录可能是不连接的
            reader.Log = chkLog.Checked;
            reader.StateChanged += new EventHandler(reader_StateChanged);
            row.Tag = reader;
            row.Cells["colOperation"].Value = "集中采集";
            row.DefaultCellStyle.ForeColor = Color.Black;
            FrmProcessing frmP = new FrmProcessing();
            frmP.MdiParent = this;
            _ProcessingForms.Add(frmP);
            frmP.Caption = string.Format("主机{0}_{1} 集中采集", hi.HostID, hi.SerialNumber);
            int recordCount = 0;
            reader.PhysicalRecordReceived += delegate (object r, PhysicalRecordReceivedArgs args)
            {
                foreach (var item in args.Records) //
                {
                    if (item.Invalid) continue;
                    if (para != null && para.CollectType == 3 && (para.BeginDt > item.RecordDate || para.EndDt < item.RecordDate)) continue; //按时间段采集时，只处理在时间段范围内的记录
                    recordCount++;
                    records.Add(item);
                    if (PhysicalScoresSavingService.Current != null)
                    {
                        PhysicalScoresSavingService.Current.AddScore(item, item.HostID == 200 ? ScoreSource.汇海APP : ScoreSource.汇海主机, reader.HostSN);
                    }
                    //LJH.GeneralLibrary.FileLog.Log("原始采集记录", item.ToString());
                }
                var msg = string.Format("采集到 {0} 条记录  总共 {1} 条记录", recordCount, args.LastSN);
                var rate = (decimal)args.Records.Max(it => it.SN) / args.LastSN;
                frmP.ShowProgress(msg, rate);
            };
            Action action = delegate ()
            {
                try
                {
                    frmP.ShowProgress(string.Format("正在进入采集界面...", hi.HostID), 0);
                    reader.Open();
                }
                catch (ThreadAbortException)
                {
                }
                catch (Exception)
                {
                }
            };
            Thread t = new Thread(new ThreadStart(action));
            t.IsBackground = true;
            t.Start();
            frmP.FormClosed += delegate (object obj, FormClosedEventArgs args)
            {
                _ProcessingForms.Remove(obj as FrmProcessing);
                row.Tag = null;
                row.Cells["colOperation"].Tag = records;
                row.Cells["colOperation"].Value = "查看数据";
                reader.Close();
                t.Abort();
                RenderProcessingForms();
            };
            frmP.Show();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (dataGridView2.Columns[e.ColumnIndex].Name == "colOperation" && dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null &&
                dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "查看数据")
            {
                var records = dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag as List<PhysicalRecord>;
                if (records != null)
                {
                    var frm = new FrmScoreCollect_Wifi();
                    frm.StartPosition = FormStartPosition.CenterParent;
                    frm.Text = string.Format("主机 {0} 的集中采集数据", dataGridView2.Rows[e.RowIndex].Cells["colHostID"].Value.ToString());
                    frm.ShowPhysicalRecords(records);
                    frm.ShowDialog();
                }
            }
        }
        #endregion

        #region 学生下载相关
        private void 下载学生名单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool needDownload = false;
            foreach (DataGridViewRow row in dataGridView2.SelectedRows)
            {
                if (row.Tag == null && Convert.ToBoolean(row.Cells["colCheck"].EditedFormattedValue))
                {
                    needDownload = true;
                    break;
                }
            }
            if (!needDownload) return;
            FrmStudentDownloadPara frm = new FrmStudentDownloadPara();
            frm.StartPosition = FormStartPosition.CenterParent;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                List<Model.Student> students = frm.students;
                int maxStudentPertime = frm.maxStudentPertime;
                bool cardID4StudentID = frm.cardID4StudentID;
                bool clearFirst = frm.clearFirst;
                bool withPhoto = frm.DownloadPhoto;
                int count = 0;
                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    var row = dataGridView2.Rows[i];
                    if (row.Selected && row.Tag == null && Convert.ToBoolean(row.Cells["colCheck"].EditedFormattedValue))
                    {
                        if (withPhoto) UploadStudentsWithPhoto(row, students, cardID4StudentID);
                        else UploadStudents(row, students, maxStudentPertime, cardID4StudentID);
                        count++;
                    }
                }
                if (count > 0) RenderProcessingForms();
            }
        }

        private void 清空学生名单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int count = 0;
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                var row = dataGridView2.Rows[i];
                if (row.Selected && row.Tag == null && Convert.ToBoolean(row.Cells["colCheck"].EditedFormattedValue))
                {
                    ClearStudents(row);
                    count++;
                }
            }
            if (count > 0) RenderProcessingForms();
        }

        private void UploadStudents(DataGridViewRow row, List<HH.ZK.Model.Student> students, int maxStudentPertime, bool cardID4StudentID)
        {
            var hi = row.Cells["colSer"].Tag as WifiHostInfo;
            StudentDownloader sd = StudentDownloader.CreateInstance(hi.HostID, hi.IP, hi.LocalIP);
            sd.Log = chkLog.Checked;
            row.Tag = sd;
            row.Cells["colOperation"].Value = "下载学生";
            FrmProcessing frmP = new FrmProcessing();
            frmP.MdiParent = this;
            _ProcessingForms.Add(frmP);
            frmP.Caption = string.Format("主机{0}_{1} 下载学生", hi.HostID, hi.SerialNumber);
            Action action = delegate ()
            {
                try
                {
                    int count = 0;
                    List<HostStudent> ss = new List<HostStudent>();
                    frmP.ShowProgress(string.Format("正在下载学生信息到 主机 {0} ...", hi.HostID), 0);
                    using (var host = WifiHost.CreateInstance(hi.HostID, hi.IP, hi.LocalIP)) //让主机进入学生名单下载界面
                    {
                        host.Log = sd.Log;
                        host.PreDownloadStudent();
                    }
                    sd.Open();
                    foreach (var s in students)
                    {
                        ss.Add(new HostStudent() { StudentID = (cardID4StudentID && !string.IsNullOrEmpty(s.CardID)) ? s.CardID : s.ID, Name = s.Name, Sex = s.Gender == Gender.Male ? "男" : "女", Grade = (byte)s.Grade, ClassName = s.ClassName, CardID = s.CardID });
                        count++;
                        if (ss.Count >= maxStudentPertime || (count == students.Count && ss.Count > 0))
                        {
                            var ret = sd.DownloadStudents(ss.ToArray());
                            ss.Clear();
                            frmP.ShowProgress(string.Format("主机 {0} 已经下载 {1} 人，总共 {2}", hi.HostID, count, students.Count), (decimal)count / students.Count);
                            if (ret == StudentDownloadResult.存储器已满)
                            {
                                frmP.ShowProgress(string.Format("主机 {0} 存储器已满", hi.HostID), 0.9m, Color.Red);
                                return;
                            }
                        }
                    }
                    frmP.ShowProgress(string.Empty, 1);
                }
                catch (ThreadAbortException)
                {
                }
                catch (Exception)
                {
                }
                finally
                {
                    sd.Close();
                }
            };
            Thread t = new Thread(new ThreadStart(action));
            t.IsBackground = true;
            t.Start();
            frmP.FormClosed += delegate (object obj, FormClosedEventArgs args)
            {
                _ProcessingForms.Remove(obj as FrmProcessing);
                t.Abort();
                row.Tag = null;
                row.Cells["colOperation"].Value = null;
            };
            frmP.Show();
        }

        private void UploadStudentsWithPhoto(DataGridViewRow row, List<HH.ZK.Model.Student> students, bool cardID4StudentID)
        {
            var hi = row.Cells["colSer"].Tag as WifiHostInfo;
            StudentDownloader sd = StudentDownloader.CreateInstance(hi.HostID, hi.IP, hi.LocalIP);
            sd.Log = chkLog.Checked;
            row.Tag = sd;
            row.Cells["colOperation"].Value = "下载学生";
            FrmProcessing frmP = new FrmProcessing();
            frmP.MdiParent = this;
            _ProcessingForms.Add(frmP);
            frmP.Caption = string.Format("主机{0}_{1} 下载学生", hi.HostID, hi.SerialNumber);
            Action action = delegate ()
            {
                try
                {
                    int count = 0;
                    List<HostStudent> ss = new List<HostStudent>();
                    frmP.ShowProgress(string.Format("正在下载学生信息到 主机 {0} ...", hi.HostID), 0);
                    using (var host = WifiHost.CreateInstance(hi.HostID, hi.IP, hi.LocalIP)) //让主机进入学生名单下载界面
                    {
                        host.Log = sd.Log;
                        host.PreDownloadStudent();
                    }
                    sd.Open();
                    foreach (var s in students)
                    {
                        count++;
                        byte[] photo = null;
                        var image = new APIClient(AppSettings.Current.ConnStr).GetByID<string, StudentPhoto>(s.ID, AppSettings.Current.PhysicalProject.ID).QueryObject;
                        if (image != null) photo = ReadImage(image.Photo);
                        var hostStudent = new HostStudent() { StudentID = (cardID4StudentID && !string.IsNullOrEmpty(s.CardID)) ? s.CardID : s.ID, Name = s.Name, Sex = s.Gender == Gender.Male ? "男" : "女", Grade = (byte)s.Grade, ClassName = s.ClassName, CardID = s.CardID };
                        var ret = sd.DownloadStudentWithPhoto(hostStudent, photo);
                        frmP.ShowProgress(string.Format("主机 {0} 已经下载 {1} 人，总共 {2}", hi.HostID, count, students.Count), (decimal)count / students.Count);
                        if (ret == StudentDownloadResult.存储器已满)
                        {
                            frmP.ShowProgress(string.Format("主机 {0} 存储器已满", hi.HostID), 0.9m);
                            return;
                        }
                    }
                    frmP.ShowProgress(string.Empty, 1);
                }
                catch (ThreadAbortException)
                {
                }
                catch (Exception)
                {
                }
                finally
                {
                    sd.Close();
                }
            };
            Thread t = new Thread(new ThreadStart(action));
            t.IsBackground = true;
            t.Start();
            frmP.FormClosed += delegate (object obj, FormClosedEventArgs args)
            {
                _ProcessingForms.Remove(obj as FrmProcessing);
                row.Tag = null;
                row.Cells["colOperation"].Value = null;
                t.Abort();
            };
            frmP.Show();
        }

        private void ClearStudents(DataGridViewRow row)
        {
            var hi = row.Cells["colSer"].Tag as WifiHostInfo;
            StudentDownloader sd = StudentDownloader.CreateInstance(hi.HostID, hi.IP, hi.LocalIP);
            sd.Log = chkLog.Checked;
            row.Tag = sd;
            row.Cells["colOperation"].Value = "清空学生";
            FrmProcessing frmP = new FrmProcessing();
            frmP.MdiParent = this;
            _ProcessingForms.Add(frmP);
            frmP.Caption = string.Format("主机{0}_{1} 清空学生", hi.HostID, hi.SerialNumber);
            Action action = delegate ()
            {
                try
                {
                    frmP.ShowProgress(string.Format("正在清空 主机 {0} 的学生信息...", hi.HostID), 0m);
                    using (var host = WifiHost.CreateInstance(hi.HostID, hi.IP, hi.LocalIP)) //让主机进入学生名单下载界面
                    {
                        host.Log = sd.Log;
                        host.PreDownloadStudent();
                        frmP.ShowProgress(string.Format("正在清空 主机 {0} 的学生信息...", hi.HostID), 0.1m);
                    }
                    sd.Open();
                    Thread.Sleep(1000);
                    sd.ClearStudents();
                    frmP.ShowProgress(string.Empty, 1);
                }
                catch (ThreadAbortException)
                {
                }
                catch (Exception)
                {
                }
                finally
                {
                    sd.Close();
                }
            };
            Thread t = new Thread(new ThreadStart(action));
            t.IsBackground = true;
            t.Start();
            frmP.FormClosed += delegate (object obj, FormClosedEventArgs args)
            {
                _ProcessingForms.Remove(obj as FrmProcessing);
                row.Tag = null;
                row.Cells["colOperation"].Value = null;
                t.Abort();
                RenderProcessingForms();
            };
            frmP.Show();
        }

        private byte[] ReadImage(byte[] photo)
        {
            try
            {
                using (MemoryStream fileStream = new MemoryStream(photo))
                {
                    DecodedJpeg jpegIn = new JpegDecoder(fileStream).Decode(); //解码
                    FluxJpeg.Core.Image img = jpegIn.Image;
                    if (ImageResizer.ResizeNeeded(img, 200)) img = new ImageResizer(img).ResizeToScale(200, 200, ResamplingFilters.LowpassAntiAlias);//改变大小
                    var bmp = img.ToBitmap();
                    using (MemoryStream ms = new MemoryStream())
                    {
                        bmp.Save(ms, ImageFormat.Jpeg);
                        var data = ms.GetBuffer();
                        return data;
                    }
                }
            }
            catch (Exception)
            {
            }
            return null;
        }
        #endregion

        #region 其它命令
        private void 同步时间ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int count = 0;
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                var row = dataGridView2.Rows[i];
                if (row.Selected && row.Tag == null && Convert.ToBoolean(row.Cells["colCheck"].EditedFormattedValue))
                {
                    if (row.Tag == null)
                    {
                        SynTime(row);
                        count++;
                    }
                }
            }
            if (count > 0) RenderProcessingForms();
        }

        private void SynTime(DataGridViewRow row)
        {
            var hi = row.Cells["colSer"].Tag as WifiHostInfo;
            var host = WifiHost.CreateInstance(hi.HostID, hi.IP, hi.LocalIP);
            host.Log = chkLog.Checked;
            row.Tag = host;
            row.Cells["colOperation"].Value = "同步时间";
            FrmProcessing frmP = new FrmProcessing();
            frmP.MdiParent = this;
            _ProcessingForms.Add(frmP);
            frmP.Caption = string.Format("主机{0}_{1} 同步时间", hi.HostID, hi.SerialNumber);
            Action action = delegate ()
            {
                try
                {
                    frmP.ShowProgress("正在同步时间...", 0);
                    var ret = host.SyncTime(DateTime.Now);
                    if (ret)
                    {
                        frmP.ShowProgress(string.Empty, 1);
                    }
                    else
                    {
                        frmP.ShowProgress("时间同步失败!", 0.9m, Color.Red);
                    }
                }
                catch
                {
                }
                finally
                {
                    host.Dispose();
                }
            };
            Thread t = new Thread(new ThreadStart(action));
            t.IsBackground = true;
            t.Start();
            frmP.FormClosed += delegate (object obj, FormClosedEventArgs args)
            {
                _ProcessingForms.Remove(obj as FrmProcessing);
                row.Tag = null;
                row.Cells["colOperation"].Value = null;
                t.Abort();
                RenderProcessingForms();
            };
            frmP.Show();
        }

        private void 关机ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否要进行关机操作？", "询问", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
            int count = 0;
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                var row = dataGridView2.Rows[i];
                if (row.Selected && row.Tag == null && Convert.ToBoolean(row.Cells["colCheck"].EditedFormattedValue))
                {
                    if (row.Tag == null)
                    {
                        ShutDown(row);
                        count++;
                    }
                }
            }
            if (count > 0) RenderProcessingForms();
        }

        private void ShutDown(DataGridViewRow row)
        {
            var hi = row.Cells["colSer"].Tag as WifiHostInfo;
            var host = WifiHost.CreateInstance(hi.HostID, hi.IP, hi.LocalIP);
            host.Log = chkLog.Checked;
            row.Tag = host;
            row.Cells["colOperation"].Value = "关机";
            FrmProcessing frmP = new FrmProcessing();
            frmP.MdiParent = this;
            _ProcessingForms.Add(frmP);
            frmP.Caption = string.Format("主机{0}_{1} 关机", hi.HostID, hi.SerialNumber);
            Action action = delegate ()
            {
                try
                {
                    frmP.ShowProgress("正在关机...", 0);
                    var ret = host.Shutdown();
                    if (ret)
                    {
                        frmP.ShowProgress(string.Empty, 1);
                    }
                    else
                    {
                        frmP.ShowProgress("关机失败!", 0.9m, Color.Red);
                    }
                }
                catch
                {
                }
                finally
                {
                    host.Dispose();
                }
            };
            Thread t = new Thread(new ThreadStart(action));
            t.IsBackground = true;
            t.Start();
            frmP.FormClosed += delegate (object obj, FormClosedEventArgs args)
            {
                _ProcessingForms.Remove(obj as FrmProcessing);
                row.Tag = null;
                row.Cells["colOperation"].Value = null;
                t.Abort();
                RenderProcessingForms();
            };
            frmP.Show();
        }

        private void 通讯质量测试ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int count = 0;
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                var row = dataGridView2.Rows[i];
                if (row.Selected && row.Tag == null && Convert.ToBoolean(row.Cells["colCheck"].EditedFormattedValue))
                {
                    if (row.Tag == null)
                    {
                        CommunicationTest(row);
                        count++;
                    }
                }
            }
            if (count > 0) RenderProcessingForms();
        }

        private void CommunicationTest(DataGridViewRow row)
        {
            var hi = row.Cells["colSer"].Tag as WifiHostInfo;
            var host = WifiHost.CreateInstance(hi.HostID, hi.IP, hi.LocalIP);
            host.Log = chkLog.Checked;
            row.Tag = host;
            row.Cells["colOperation"].Value = "通讯质量检测";
            FrmProcessing frmP = new FrmProcessing();
            frmP.MdiParent = this;
            _ProcessingForms.Add(frmP);
            frmP.Caption = string.Format("主机{0}_{1} 通讯质量检测", hi.HostID, hi.SerialNumber);
            Action action = delegate ()
            {
                Queue<bool> rets = new Queue<bool>();
                try
                {
                    frmP.ShowProgress("通讯质量检测...", 0);
                    while (true)
                    {
                        var ret = host.Echo();
                        if (rets.Count == 10) rets.Dequeue();
                        rets.Enqueue(ret);
                        var c = rets.Count(it => it);
                        var rate = (decimal)(rets.Count(it => it)) / rets.Count;
                        string msg = null;
                        Color color = Color.Black;
                        if (rate >= 0.8m)
                        {
                            msg = "通讯质量良好";
                            color = Color.Blue;
                        }
                        else if (rate >= 0.6m)
                        {
                            msg = "通讯质量一般";
                            color = Color.Black;
                        }
                        else if (rate >= 0.5m)
                        {
                            msg = "通讯质量较差";
                            color = Color.Orange;
                        }
                        else
                        {
                            msg = "通讯质量很差";
                            color = Color.Red;
                        }
                        frmP.ShowProgressEX(msg, rate, color);
                    }
                }
                catch
                {
                }
                finally
                {
                    host.Dispose();
                }
            };
            Thread t = new Thread(new ThreadStart(action));
            t.IsBackground = true;
            t.Start();
            frmP.FormClosed += delegate (object obj, FormClosedEventArgs args)
            {
                _ProcessingForms.Remove(obj as FrmProcessing);
                row.Tag = null;
                row.Cells["colOperation"].Value = null;
                t.Abort();
                RenderProcessingForms();
            };
            frmP.Show();
        }

        private void 参数设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                var row = dataGridView2.Rows[i];
                if (row.Selected && row.Tag == null && Convert.ToBoolean(row.Cells["colCheck"].EditedFormattedValue))
                {
                    if (row.Tag == null)
                    {
                        SetParameter(row);
                    }
                }
            }
        }

        private void SetParameter(DataGridViewRow row)
        {
            var hi = row.Cells["colSer"].Tag as WifiHostInfo;
            var host = WifiHost.CreateInstance(hi.HostID, hi.IP, hi.LocalIP);
            host.Log = chkLog.Checked;
            row.Tag = host;
            row.Cells["colOperation"].Value = "参数设置";
            FrmHostParameters frmP = new FrmHostParameters();
            frmP.MdiParent = this;
            frmP.Host = host;
            frmP.Text = string.Format("主机{0}_{1} 参数设置", hi.HostID, hi.SerialNumber);
            frmP.FormClosed += delegate (object obj, FormClosedEventArgs args)
            {
                row.Tag = null;
                row.Cells["colOperation"].Value = null;
                host.Dispose();
            };
            frmP.Show();
        }

        private void 增加主机USBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddHost_USB frm = new FrmAddHost_USB();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                ShowHostInfo(new WifiHostInfo() { IP = frm.Commport.ToString(), HostID = frm.HostID, SerialNumber = "COM" + frm.Commport.ToString() });
            }
        }
        #endregion
    }
}
