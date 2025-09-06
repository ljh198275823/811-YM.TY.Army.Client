using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
    public partial class Frm考场视频 : Form
    {
        public Frm考场视频()
        {
            InitializeComponent();
        }

        #region 私有方法
        private bool 请求上传视频(List<TBVideoItem> items)
        {
            var ret = new VideoServerClient(AppSettings.Current.PhysicalProject.Options.VideoServiceUrl).请求上传视频(items);
            if (ret.Result == ResultCode.Successful)
            {
                MessageBox.Show("请求发送成功，请等一段时间后再查询视频是否已经上传");
                items.ForEach(it => it.isSync = 2);
                return true;
            }
            return false;
        }

        private void ShowItemsOnGrid(List<TBVideoItem> items)
        {
            dataGridView1.Rows.Clear();
            if (items != null && items.Count > 0)
            {
                items = (from it in items orderby it.testTime descending select it).ToList();
                foreach (var item in items)
                {
                    int row = dataGridView1.Rows.Add();
                    ShowItemOnRow(dataGridView1.Rows[row], item);
                }
            }
            lblCount.Text = string.Format("共 {0} 项", dataGridView1.Rows.Count);
        }

        private void ShowItemOnRow(DataGridViewRow row, TBVideoItem item)
        {
            row.Tag = item;
            row.Cells["col考点"].Value = item.考点;
            row.Cells["colStudentID"].Value = item.studentId;
            row.Cells["colFile"].Value = item.videoName;
            row.Cells["colFileSize"].Value = item.FileSizeFormat();
            var piname = AppSettings.Current.PhysicalProject.PhysicalItems?.GetName(item.testItemId);
            row.Cells["colPhysicalItem"].Value = string.IsNullOrEmpty(piname) ? item.testItemId.ToString() : piname;
            row.Cells["col测试时间"].Value = item.testTime.ToString("yyyy-MM-dd HH:mm:ss");
            row.Cells["colCameraLocation"].Value = item.CameraLocationStr;
            row.Cells["colFill"].Value = item.videoPathInCamera;
            row.Cells["colPlay"].Value = item.isSync == 1 ? "双击播放" : null;
            if (ExistsVideo(item))
            {
                row.Cells["colLocalPath"].Value = "打开所在文件夹";
                row.Cells["colState"].Value = "已下载";
                row.Cells["colPlay"].Value = "双击播放";
            }
            else if (item.isSync == 0) row.Cells["colState"].Value = "未上传";
            else if (item.isSync == 1) row.Cells["colState"].Value = "已上传";
            else if (item.isSync == 2) row.Cells["colState"].Value = "正在上传";
        }

        private bool ExistsVideo(TBVideoItem item)
        {
            try
            {
                var path = AppSettings.Current.VideoPath;
                var temp = System.IO.Path.Combine(path, item.videoPathInCamera);
                return System.IO.File.Exists(temp);
            }
            catch
            {
                return false;
            }
        }

        private string GetLocalVideoFile(TBVideoItem item)
        {
            try
            {
                var path = AppSettings.Current.VideoPath;
                var temp = System.IO.Path.Combine(path, item.videoPathInCamera);
                if (System.IO.File.Exists(temp)) return temp;
                return null;
            }
            catch
            {
                return null;
            }
        }

        private List<TBVideoItem> GetSelectedItems()
        {
            List<TBVideoItem> items = new List<TBVideoItem>();
            foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
            {
                var item = dataGridView1.Rows[cell.RowIndex].Tag as TBVideoItem;
                if (items.Contains(item) == false) items.Add(item);
            }
            return items;
        }
        #endregion

        #region 事件处理程序
        private void Frm考场视频_Load(object sender, EventArgs e)
        {
            cmbPhysicalItem.Init(AppSettings.Current.PhysicalProject);
            if (!string.IsNullOrEmpty(AppSettings.Current.PhysicalProject.Options?.VideoServiceUrl))
            {
                lblVideoUrl.Text = AppSettings.Current.PhysicalProject.Options?.VideoServiceUrl;
            }
            lblVideoPath.Text = $"{AppSettings.Current.VideoPath }";
            txt同步录像本地数据.Text = AppSettings.Current.GetConfigContent($"LocalVideoDBPath");
            lnkVideoUrl.Enabled = AppSettings.Current.Operator.PermitAny(Model.CRM.Permission.SystemOptions, Model.CRM.PermissionActions.Edit);
        }

        private void chk考试日期_CheckedChanged(object sender, EventArgs e)
        {
            dtDate.Enabled = chk考试日期.Checked;
        }

        private void lnkVideoUrl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //var frm = new Frm同步相像服务器设置();
            //frm.StartPosition = FormStartPosition.CenterParent;
            //frm.ShowDialog();
            //if (AppSettings.Current.PhysicalProject.VideoServer != null)
            //{
            //    lblVideoUrl.Text = AppSettings.Current.PhysicalProject.VideoServer.ServerUrl;
            //}
        }

        private void lnk同步录像本地数据_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FolderBrowserDialog frm = new FolderBrowserDialog();
            if (!string.IsNullOrEmpty(txt同步录像本地数据.Text)) frm.SelectedPath = txt同步录像本地数据.Text;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txt同步录像本地数据.Text = frm.SelectedPath;
                AppSettings.Current.SaveConfig($"LocalVideoDBPath", frm.SelectedPath);
            }
        }

        private void txt同步录像本地数据_DoubleClick(object sender, EventArgs e)
        {
            txt同步录像本地数据.Text = string.Empty;
            AppSettings.Current.SaveConfig($"LocalVideoDBPath", string.Empty);
        }

        private void lnkVideoPath_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var frm = new Frm同步相像本地保存路径设置();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
            lblVideoPath.Text = $"{AppSettings.Current.VideoPath }";
        }

        private void btn查询所有视频_Click(object sender, EventArgs e)
        {
            QueryResultList<TBVideoItem> ret = null;
            if (string.IsNullOrEmpty(AppSettings.Current.PhysicalProject.Options?.VideoServiceUrl) && string.IsNullOrEmpty(txt同步录像本地数据.Text))
            {
                MessageBox.Show("请先设置同步录像视频服务器地址");
                return;
            }
            if (!string.IsNullOrEmpty(txt同步录像本地数据.Text))
            {
                var client = new VideoLocalDBProvider(txt同步录像本地数据.Text);
                var sid = txtStudentID1.Text.Trim();
                if (!string.IsNullOrEmpty(sid)) ret = client.查询视频(sid, null, 0);
                else ret = client.查询视频(null, null, 0);
            }
            else
            {
                var client = new VideoServerClient(AppSettings.Current.PhysicalProject.Options?.VideoServiceUrl);
                var sid = txtStudentID1.Text;
                if (!string.IsNullOrEmpty(sid)) ret = client.按考生号项目获取视频(sid, 0);
                else ret = client.获取所有视频();
            }
            if (ret != null && ret.Result == ResultCode.Successful)
            {
                var items = ret.QueryObjects;
                if (items != null && items.Count > 0)
                {
                    if (!string.IsNullOrEmpty(cmbPhysicalItem.Text))
                    {
                        var pid = cmbPhysicalItem.SelectedPhysicalItem;
                        pid = pid == PhysicalItem._1000米 ? PhysicalItem._800米 : pid;
                        items = items.Where(it => it.testItemId == pid).ToList();
                    }
                    if (!string.IsNullOrEmpty(txt考点.Text)) items = items.Where(it => it.考点.Contains(txt考点.Text)).ToList();
                    if (chk考试日期.Checked) items = items.Where(it => it.testTime.Date == dtDate.Value.Date).ToList();
                }
                if (items != null && items.Count > 0) ShowItemsOnGrid(items);
                else
                {
                    MessageBox.Show("没有找到相关录像数据");
                    dataGridView1.Rows.Clear();
                }

            }
            else if (ret != null)
            {
                MessageBox.Show(ret.Message);
            }
        }

        private void mnu请求上传视频_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(AppSettings.Current.PhysicalProject.Options?.VideoServiceUrl))
            {
                MessageBox.Show("请先设置同步录像视频服务器地址");
                return;
            }
            var items = GetSelectedItems();
            if (items != null && items.Count > 0)
            {
                var ret = 请求上传视频(items);
                if (ret)
                {
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        if (dataGridView1.Rows[i].Selected) ShowItemOnRow(dataGridView1.Rows[i], dataGridView1.Rows[i].Tag as TBVideoItem);
                    }
                }
            }
            else MessageBox.Show("没有选择视频或选择的视频已经上传到服务器");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            var item = dataGridView1.Rows[e.RowIndex].Tag as TBVideoItem;
            if (!ExistsVideo(item) && item.isSync == 1)
            {
                if (string.IsNullOrEmpty(AppSettings.Current.PhysicalProject.Options?.VideoServiceUrl))
                {
                    MessageBox.Show("请先设置同步录像视频服务器地址");
                    return;
                }
                var client = new VideoServerClient(AppSettings.Current.PhysicalProject.Options?.VideoServiceUrl);
                var temp = client.SaveVideo(item, AppSettings.Current.VideoPath);
                if (!string.IsNullOrEmpty(temp)) dataGridView1.Rows[e.RowIndex].Cells["colLocalPath"].Value = "打开所在文件夹";
            }
            try
            {
                var file = GetLocalVideoFile(item);
                if (!string.IsNullOrEmpty(file))
                {
                    dataGridView1.Rows[e.RowIndex].Cells["colLocalPath"].Value = "打开所在文件夹";
                    System.Diagnostics.Process.Start(file);
                }
            }
            catch
            {

            }
        }

        private void listView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            var item = dataGridView1.Rows[e.RowIndex].Tag as TBVideoItem;
            if (dataGridView1.Columns[e.ColumnIndex].Name == "colLocalPath")
            {
                try
                {
                    var file = System.IO.Path.Combine(AppSettings.Current.VideoPath, item.videoPathInCamera);
                    file = file.Replace('/', '\\');
                    System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo("Explorer.exe");
                    psi.Arguments = "/e,/select," + file;
                    System.Diagnostics.Process.Start(psi);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {

            QueryResultList<TBVideoItem> ret = null;
            if (!string.IsNullOrEmpty(txt同步录像本地数据.Text))
            {
                var client = new VideoLocalDBProvider(txt同步录像本地数据.Text);
                var sid = txtStudentID1.Text.Trim();
                if (!string.IsNullOrEmpty(sid)) ret = client.查询视频(sid, null, 0);
                else ret = client.查询视频(null, null, 0);
            }
            else
            {
                var client = new VideoServerClient(AppSettings.Current.PhysicalProject.Options?.VideoServiceUrl);
                var sid = txtStudentID1.Text;
                if (!string.IsNullOrEmpty(sid)) ret = client.按考生号项目获取视频(sid, 0);
                else ret = client.获取所有视频();
            }
            if (ret != null && ret.Result == ResultCode.Successful)
            {
                var items = ret.QueryObjects;
                if (items != null && items.Count > 0)
                {
                    AddVideoItems(items);
                }
            }
        }

        private VideoItem CreateVideo(TBVideoItem item,Dictionary<string,Student> dic)
        {
            if (dic.ContainsKey(item.studentId) == false) return null;
            if (AppSettings.Current.PhysicalProject.PhysicalItems.GetPhysicalItem(item.testItemId) == null) return null;
            if (item.videoSize == 0) return null;
            var ret = new VideoItem()
            {
                ID = Guid.NewGuid(),
                ProjectID = AppSettings.Current.PhysicalProject.ID,
                StudentID = item.studentId,
                TestID = item.testItemId,
                CameraIMEI = item.cameraIMEI,
                CameraLocation = item.cameraLocation,
                TestTime = item.testTime,
                VideoPath = item.videoPathInCamera,
                VideoSize = item.videoSize,
            };
            return ret;
        }

        private void AddVideoItems(List<TBVideoItem> items)
        {
            var ss = new APIClient(AppSettings.Current.ConnStr).GetList<string, Student>(null, AppSettings.Current.PhysicalProject.ID).QueryObjects;
            var dic = new Dictionary<string, Student>();
            foreach (var s in ss)
            {
                dic.Add(s.ID, s);
            }
            int success = 0;
            FrmProcessing frm = new FrmProcessing();
            Action action = delegate ()
            {
                try
                {
                    for (int i = 0; i < items.Count; i++)
                    {
                        var temp = CreateVideo(items[i],dic);
                        if (temp == null) continue;
                        CommandResult ret = new APIClient(AppSettings.Current.ConnStr).Add<Guid, VideoItem>(temp, AppSettings.Current.PhysicalProject.ID);
                        if (ret.Result == ResultCode.Successful) success++;
                        frm.ShowProgress($"共导入 {i + 1} 成功 {success}", (decimal)(i + 1) / items.Count);
                    }
                }
                catch (ThreadAbortException)
                {
                }
                catch (Exception)
                {
                }
                frm.ShowProgress(string.Empty, 1);
            };
            Thread t = new Thread(new ThreadStart(action));
            t.IsBackground = true;
            t.Start();
            if (frm.ShowDialog() != DialogResult.OK)
            {
                t.Abort();
            }
        }
    }
}
