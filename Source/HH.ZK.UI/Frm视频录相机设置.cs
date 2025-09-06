using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Threading;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HH.ZK.WebAPIClient;
using HH.ZK.Model;
using HH.Zhongkao.Device;
using HH.Zhongkao.Device.Wifi;
using HH.ZK.CommonUI;
using LJH.GeneralLibrary;

namespace HH.ZK.UI
{
    public partial class Frm视频录相机设置 : Form
    {
        public Frm视频录相机设置()
        {
            InitializeComponent();
        }

        #region 私有变量
        private Thread _SearchThread = null;
        #endregion

        #region 私有方法
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
            PhysicalItem pi = AppSettings.Current.PhysicalProject.PhysicalItems.GetPhysicalItem(host.PhysicalID);
            foreach (DataGridViewRow r in dataGridView2.Rows)
            {
                if (r.Cells["colSer"].Value != null && r.Cells["colSer"].Value.ToString() == host.SerialNumber) //相同序列号当成同一个设备
                {
                    r.Cells["colMemo"].Value = $"主机号:{host.HostID} 测试科目:{pi?.Name}";
                    existsRow = r;
                    break;
                }
            }
            if (existsRow == null)
            {
                var rIndex = dataGridView2.Rows.Add();
                dataGridView2.Rows[rIndex].Cells["colSer"].Value = host.SerialNumber;
                dataGridView2.Rows[rIndex].Cells["colMemo"].Value = $"主机号:{host.HostID} 测试科目:{pi?.Name}";
            }
            dataGridView2.Refresh();
        }

        private void ShowItem(string sn, string channels,string memo)
        {
            DataGridViewRow existsRow = null;
            foreach (DataGridViewRow r in dataGridView2.Rows)
            {
                if (r.Cells["colSer"].Value != null && r.Cells["colSer"].Value.ToString() == sn) //相同序列号当成同一个设备
                {
                    r.Cells["colChannels"].Value = channels;
                    r.Cells["colMemo"].Value = memo;
                    existsRow = r;
                    break;
                }
            }
            if (existsRow == null)
            {
                var rIndex = dataGridView2.Rows.Add();
                dataGridView2.Rows[rIndex].Cells["colSer"].Value = sn;
                dataGridView2.Rows[rIndex].Cells["colChannels"].Value = channels;
                dataGridView2.Rows[rIndex].Cells["colMemo"].Value = memo;
            }
            dataGridView2.Refresh();
        }
        #endregion

        #region 事件处理程序
        private void FrmDHClientSettings_Load(object sender, EventArgs e)
        {
            btnConnectTest1.Enabled = AppSettings.Current.Operator.IsAdmin;
            var para = SysParaSettingsClient.GetSetting<NVRClientSettings>(AppSettings.Current.ConnStr, AppSettings.Current.PhysicalProject.ID);
            if (para != null)
            {
                rd海康威视.Checked = para.NVRType == 1;
                rd大华.Checked = para.NVRType == 2;
                txtDelaySeconds.IntergerValue = para.DelaySeconds;
                txtUrl.Text = para.ServerIP;
                txtPort.Text = para.ServerPort.ToString();
                txtUserID.Text = para.UserName;
                txtPasswd.Text = para.Password;
                if (para.HostChannels != null && para.HostChannels.Count > 0)
                {
                    foreach (var p in para.HostChannels)
                    {
                        int row = dataGridView2.Rows.Add();
                        dataGridView2.Rows[row].Cells["colSer"].Value = p.Key;
                        dataGridView2.Rows[row].Cells["colChannels"].Value = p.Value;
                    }
                }
            }
        }

        private void rd大华_CheckedChanged(object sender, EventArgs e)
        {
            txtPort.Text = "37777";
        }

        private void rd海康威视_CheckedChanged(object sender, EventArgs e)
        {
            txtPort.Text = "8000";
        }

        private void btn搜索主机_Click(object sender, EventArgs e)
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
                _SearchThread = new Thread(new ThreadStart(Search_Thread));
                _SearchThread.IsBackground = true;
                _SearchThread.Start();
            }
        }

        private void btn新建_Click(object sender, EventArgs e)
        {
            var frm = new Frm视频通道明细();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                ShowItem(frm.DeviceSN, frm.Channels, frm.Memo);
            }
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >=0 && e.ColumnIndex >= 0)
            {
                var r = dataGridView2.Rows[e.RowIndex];
                var frm = new Frm视频通道明细();
                frm.DeviceSN = r.Cells["colSer"].Value?.ToString();
                frm.Channels = r.Cells["colChannels"].Value?.ToString();
                frm.Memo = r.Cells["colMemo"].Value?.ToString();
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    ShowItem(frm.DeviceSN, frm.Channels, frm.Memo);
                }
            }
        }

        private void btn删除所选项_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否删除所选项?", "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            List<DataGridViewRow> rows = new List<DataGridViewRow>();
            foreach (DataGridViewRow row in dataGridView2.SelectedRows)
            {
                rows.Add(row);
            }
            foreach (var row in rows)
            {
                dataGridView2.Rows.Remove(row);
            }
        }

        private bool CheckInput()
        {
            if (string.IsNullOrEmpty(txtUrl.Text))
            {
                MessageBox.Show("没有填写服务器IP");
                return false;
            }
            if (string.IsNullOrEmpty(txtPort.Text))
            {
                MessageBox.Show("没有填写端口号");
                return false;
            }
            ushort port = 0;
            if (ushort.TryParse(txtPort.Text, out port) == false)
            {
                MessageBox.Show("端口号不正确");
                return false;
            }
            if (string.IsNullOrEmpty(txtUserID.Text))
            {
                MessageBox.Show("没有填写用户名");
                return false;
            }
            if (string.IsNullOrEmpty(txtPasswd.Text))
            {
                MessageBox.Show("没有填写密码");
                return false;
            }
            return true;
        }

        private void btnConnectTest1_Click(object sender, EventArgs e)
        {
            if (CheckInput() == false) return;
            var para = new NVRClientSettings()
            {
                NVRType = rd海康威视.Checked ? 1 : 2,
                DelaySeconds = txtDelaySeconds.IntergerValue,
                ServerIP = txtUrl.Text,
                ServerPort = int.Parse(txtPort.Text),
                UserName = txtUserID.Text,
                Password = txtPasswd.Text
            };
            para.HostChannels = new Dictionary<string, string>();
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                var row = dataGridView2.Rows[i];
                if (row.Cells["colChannels"].Value != null)
                {
                    para.HostChannels.Add(row.Cells["colSer"].Value.ToString(), row.Cells["colChannels"].Value.ToString());
                }
            }
            var ret = SysParaSettingsClient.SaveSetting<NVRClientSettings>(para, AppSettings.Current.ConnStr, AppSettings.Current.PhysicalProject.ID);
            if (ret.Result == ResultCode.Successful)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show(ret.Message);
            }
        }

        private void Frm视频录相机设置_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_SearchThread != null) _SearchThread.Abort();
        }


        #endregion

        
    }
}
