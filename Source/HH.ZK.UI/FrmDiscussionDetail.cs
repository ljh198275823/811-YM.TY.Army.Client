using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using HH.ZK.Model;
using HH.ZK.Model.CRM;
using HH.ZK.WebAPIClient;
using HH.ZK.CommonUI;
using LJH.GeneralLibrary;
using LJH.GeneralLibrary.WinForm;

namespace HH.ZK.UI
{
    public partial class FrmDiscussionDetail : FrmDetailBase<Guid, Discussion>
    {
        public FrmDiscussionDetail()
        {
            InitializeComponent();
        }

        public Student Student { get; set; }
        public StudentScore Score { get; set; }

        #region 私有方法
        private void ShowItemsOnGrid(List<TBVideoItem> items)
        {
            dataGridView1.Rows.Clear();
            if (items != null && items.Count > 0)
            {
                foreach (var item in items)
                {
                    int row = dataGridView1.Rows.Add();
                    ShowItemOnRow(dataGridView1.Rows[row], item);
                }
            }
        }

        private void ShowItemOnRow(DataGridViewRow row, TBVideoItem item)
        {
            row.Tag = item;
            row.Cells["colStudentID"].Value = item.studentId;
            row.Cells["colFile"].Value = item.videoName;
            row.Cells["colFileSize"].Value = item.FileSizeFormat();
            row.Cells["colPhysicalItem"].Value = AppSettings.Current.PhysicalProject.PhysicalItems?.GetName(item.testItemId);
            row.Cells["col测试时间"].Value = item.testTime.ToString("yyyy-MM-dd HH:mm:ss");
            row.Cells["colCamera"].Value = item.CameraLocationStr;
            if (ExistsVideo(item))
            {
                row.Cells["colLocalPath"].Value = "打开所在文件夹";
                row.Cells["colState"].Value = "已下载";
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
        #endregion

        #region 重写基类的方法
        protected override void InitControls()
        {
            base.InitControls();
            txtResolveType.Init();
            if (Score != null)
            {
                if (Student == null) Student = new APIClient(AppSettings.Current.ConnStr).GetByID<string, Student>(Score.StudentID, AppSettings.Current.PhysicalProject.ID).QueryObject;
                txtStudentID.Text = Score.StudentID;
                txtName.Text = Student?.Name;
                txtTestTime.Text = Score.TestTime.ToString("yyyy-MM-dd HH:mm:ss");
                var pi = AppSettings.Current.PhysicalProject.PhysicalItems?.GetPhysicalItem(Score.PhysicalItemID);
                txtPhysicalItem.Text = pi != null ? pi.Name : null;
                if (Score.SpecialType.HasValue) txtScore.Text = Score.SpecialType.Value.ToString();
                else txtScore.Text = Score.FormatScore;
                GetVideoThread();
                var para = SysParaSettingsClient.GetSetting<NVRClientSettings>(AppSettings.Current.ConnStr, AppSettings.Current.PhysicalProject.ID);
                if (para != null) NVRClientSettings.Current = para;
                if (NVRClientSettings.Current != null && !string.IsNullOrEmpty(Score.VideoChannels)) btn录相回放.Visible = true;
            }
            txtApprover.Text = AppSettings.Current.Operator.Name;
            btn生成仲裁报告.Visible = !IsAdding;
        }

        public override void ShowOperatorRights()
        {
            base.ShowOperatorRights();
            this.btn确定.Enabled = AppSettings.Current.Operator.PermitAny(Permission.Discussion, PermissionActions.Edit);
        }

        protected override void ItemShowing(Discussion item)
        {
            this.Text = string.Format("成绩仲裁单：{0}", item.Number);
            this.txtStudentID.Text = item.StudentID;
            this.txtName.Text = item.Name;
            var pi = AppSettings.Current.PhysicalProject.PhysicalItems?.GetPhysicalItem(item.PhysicalItem);
            txtPhysicalItem.Text = pi != null ? pi.Name : null;
            this.txtScore.Text = item.Score;
            txtTestTime.Text = item.ScoreTime.ToString("yyyy-MM-dd HH:mm:ss");
            txtDescription.Text = item.Description;
            txtResolveType.SelectedResolveType = item.ResolveType;
            txtNewScore.Text = item.NewScore;
            txtApprover.Text = item.Approver;
            btn确定.Enabled = false;
        }

        private void GetVideoThread()
        {
            if (string.IsNullOrEmpty(AppSettings.Current.PhysicalProject.Options?.VideoServiceUrl)) return;
            string sid = null;
            int pid = 0;
            var client = new VideoServerClient(AppSettings.Current.PhysicalProject.Options?.VideoServiceUrl);
            if (Score != null)
            {
                sid = Score.StudentID;
                pid = Score.PhysicalItemID == PhysicalItem._1000米 ? PhysicalItem._800米 : Score.PhysicalItemID;
            }
            else if (UpdatingItem != null)
            {
                var info = UpdatingItem as Discussion;
                sid = info.StudentID;
                pid = info.PhysicalItem == PhysicalItem._1000米 ? PhysicalItem._800米 : info.PhysicalItem;
            }
            var items = client.按考生号项目获取视频(sid, pid).QueryObjects;
            if (items != null && items.Count > 0)
            {
                this.Invoke((Action)(() => ShowItemsOnGrid(items)));
            }
        }

        protected override bool CheckInput()
        {
            if (string.IsNullOrEmpty(txtResolveType.Text))
            {
                MessageBox.Show("仲裁结果不能为空!");
                return false;
            }
            if (string.IsNullOrEmpty(txtDescription.Text))
            {
                MessageBox.Show("仲裁描述不能为空");
                return false;
            }
            if (txtResolveType.SelectedResolveType == ResolveType.修改当前成绩)
            {
                var pi = AppSettings.Current.PhysicalProject.PhysicalItems?.GetPhysicalItem(Score.PhysicalItemID);
                decimal dv = 0;
                if (!pi.TryParse(txtNewScore.Text, out dv))
                {
                    MessageBox.Show("输入的成绩格式不正确");
                    return false;
                }
                if (pi.Min != null && dv < pi.Min.Value)
                {
                    MessageBox.Show(string.Format("输入的成绩小于 {0} 的最小成绩 {1}", pi.Name, pi.ConvertToStr(pi.Min.Value)));
                    return false;
                }

                if (pi.Max != null && dv > pi.Max.Value)
                {
                    MessageBox.Show(string.Format("输入的成绩大于 {0} 的最大成绩 {1}", pi.Name, pi.ConvertToStr(pi.Max.Value)));
                    return false;
                }
            }
            if (string.IsNullOrEmpty(txtApprover.Text))
            {
                MessageBox.Show("仲裁人不能为空");
                return false;
            }
            return true;
        }

        protected override Discussion GetItemFromInput()
        {
            if (CheckInput() == false) return null;
            var info = UpdatingItem as Discussion;
            if (IsAdding)
            {
                info = new Discussion();
                info.ID = Score.ID;
                info.StudentID = Score.StudentID;
                if (Score.SpecialType.HasValue) info.Score = Score.SpecialType.Value.ToString();
                else info.Score = Score.FormatScore;
                info.PhysicalItem = Score.PhysicalItemID;
                info.ScoreTime = Score.TestTime;
                info.ResolveType = txtResolveType.SelectedResolveType;
                if (info.ResolveType == ResolveType.修改当前成绩) info.NewScore = txtNewScore.Text;
            }
            info.Description = txtDescription.Text;
            info.Approver = txtApprover.Text;
            return info;
        }
        #endregion

        #region 事件处理程序 
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
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

        private void txtResolveType_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNewScore.Enabled = txtResolveType.SelectedResolveType == ResolveType.修改当前成绩;
        }

        private void btn录相回放_Click(object sender, EventArgs e)
        {
        }

        private void btn生成仲裁报告_Click(object sender, EventArgs e)
        {
            try
            {
                var item = UpdatingItem as Discussion;
                var template = System.IO.Path.Combine(Application.StartupPath, "模板", "学生成绩复议单模板.xls");
                var file = System.IO.Path.Combine(LJH.GeneralLibrary.TempFolderManager.GetCurrentFolder(), item.ID.ToString() + ".xls");
                var exporter = new Printer.DiscussionExporter();
                exporter.ExportToFile(item, template, file);
                System.Diagnostics.Process.Start(file);
            }
            catch (Exception ex)
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
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "colPlay")
            {
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
        }

        private void btn确定_Click(object sender, EventArgs e)
        {
            if (!CheckInput()) return;
            var sheet = GetItemFromInput() as Discussion;
            var ret = new APIClient(AppSettings.Current.ConnStr).Add<Guid, Discussion>(sheet, AppSettings.Current.PhysicalProject.ID);
            if (IsAdding && ret.Result == ResultCode.Successful)
            {
                OnItemAdded(new ItemAddedEventArgs(sheet));
                UpdatingItem = sheet;
                btn生成仲裁报告.Visible = true;
                btn确定.Enabled = false;
                //btn生成仲裁报告.PerformClick();
            }
            else
            {
                MessageBox.Show(ret.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}