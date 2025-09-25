using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.IO;
using System.Drawing.Imaging;
using System.Threading;
using System.Windows.Forms;
using HH.ZK.Model;
using HH.ZK.WebAPIClient;
using LJH.GeneralLibrary;

namespace HH.ZK.CommonUI
{
    public partial class Frm导入人员照片 : Form
    {
        public Frm导入人员照片()
        {
            InitializeComponent();
        }

        #region 私有方法
        private List<string> FindPhoto(string path)
        {
            if (!string.IsNullOrEmpty(path) && Directory.Exists(path))
            {
                string[] files = Directory.GetFiles(path, "*.jpg");
                if (files != null || files.Length > 0)
                {
                    return files.ToList();
                }
            }
            return null;
        }

        private void FindPhoto_级联(string path, List<string> photoes)
        {
            if (!string.IsNullOrEmpty(path) && Directory.Exists(path))
            {
                string[] files = Directory.GetFiles(path, "*.jpg");
                if (files != null || files.Length > 0) photoes.AddRange(files);
                var dics = Directory.GetDirectories(path);
                if (dics != null && dics.Length > 0)
                {
                    foreach (var dic in dics)
                    {
                        FindPhoto_级联(dic, photoes);
                    }
                }
            }
        }

        private void ShowFiles(List<string> files)
        {
            dataGridView1.Rows.Clear();
            if (files != null || files.Count > 0)
            {
                foreach (string file in files)
                {
                    string sid = Path.GetFileNameWithoutExtension(file).Trim().ToUpper();
                    int row = dataGridView1.Rows.Add();
                    ShowStudentInfo(dataGridView1.Rows[row], sid, file);
                }
            }
            this.toolStripStatusLabel1.Text = string.Format("总共 {0} 项", dataGridView1.Rows.Count);
            btnImport.Enabled = dataGridView1.Rows.Count > 0;
        }

        private void ShowStudentInfo(DataGridViewRow row, string s, string file)
        {
            row.Tag = file;
            row.Cells["colID"].Value = s;
            row.Cells["colID"].Tag = s;
        }

        private byte[] 压缩图片(byte[] photo, int width = 200, int height = 200)
        {
            try
            {
                System.Drawing.Image targetImg = new System.Drawing.Bitmap(width, height);
                using (System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(targetImg))
                {
                    g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                    g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                    g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                    g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
                    using (MemoryStream fileStream = new MemoryStream(photo))
                    {
                        var sourceImg = System.Drawing.Bitmap.FromStream(fileStream);
                        g.DrawImage(sourceImg, new System.Drawing.Rectangle(0, 0, width, height), new System.Drawing.Rectangle(0, 0, sourceImg.Width, sourceImg.Height), System.Drawing.GraphicsUnit.Pixel);
                        g.Dispose();
                    }
                }
                using (MemoryStream ms = new MemoryStream())
                {
                    targetImg.Save(ms, ImageFormat.Jpeg);
                    var data = ms.GetBuffer();
                    return data;
                }
            }
            catch (Exception)
            {
            }
            return null;
        }
        #endregion

        #region 事件处理程序
        private void FrmPhotoImport_Load(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Tag != null)
            {
                try
                {
                    string file = dataGridView1.Rows[e.RowIndex].Tag.ToString();
                    picPhoto.Image = Image.FromFile(file);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog frm = new FolderBrowserDialog();
            if (!string.IsNullOrEmpty(txtPath.Text)) frm.SelectedPath = txtPath.Text;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = frm.SelectedPath;
                string path = txtPath.Text.Trim();
                var files = FindPhoto(path);
                ShowFiles(files);
            }
        }

        private void btn级联获取_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPath.Text))
            {
                var files = new List<string>();
                FindPhoto_级联(txtPath.Text, files);
                ShowFiles(files);
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            int success = 0;
            int fail = 0;
            bool beOverride = chkOverride.Checked;
            bool zipable = chk压缩图片.Checked;
            int perTime = chkOnebyOne.Checked ? 1 : 50;  //每次上传的记录数量
            FrmProcessing frm = new FrmProcessing();
            Action action = delegate ()
            {
                try
                {
                    List<StudentPhoto> photoes = new List<StudentPhoto>();
                    var rows = new Dictionary<string, DataGridViewRow>();
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        if (dataGridView1.Rows[i].Visible)
                        {
                            var sid = (dataGridView1.Rows[i].Cells["colID"].Tag as string).Trim().ToUpper();
                            if (!string.IsNullOrEmpty(sid)) sid = Regex.Replace(sid, "[^0-9A-Z]", string.Empty);
                            if (rows.ContainsKey(sid))
                            {
                                dataGridView1.Rows[i].Cells["colReason"].Value = "已经存在同名文件";
                            }
                            else
                            {
                                string file = dataGridView1.Rows[i].Tag.ToString();
                                var photo = File.ReadAllBytes(file);
                                if (photo != null && photo.Length > 0)
                                {
                                    if (photo.Length > 500 * 1024 && zipable)
                                    {
                                        var photo1 = 压缩图片(photo);
                                        if (photo1.Length < photo.Length) photo = photo1; //压缩后比较一下压缩效果如果没有效果用原图
                                    }
                                    if (photo.Length <= 500 * 1024)
                                    {
                                        var sp = new StudentPhoto(sid, photo);
                                        sp.CheckFace = AppSettings.Current.PhysicalProject.Options.IgnoreFaceFeature ? false : true;
                                        photoes.Add(sp);
                                        rows.Add(sid, dataGridView1.Rows[i]);
                                    }
                                    else
                                    {
                                        dataGridView1.Rows[i].Cells["colReason"].Value = "照片不能超过500K";
                                    }
                                }
                            }
                        }
                        if (photoes.Count == perTime || i == dataGridView1.Rows.Count - 1)
                        {
                            var ret = new APIClient(AppSettings.Current.ConnStr).BatchAdd<string, StudentPhoto>(photoes, beOverride ? ImportOption.Override : ImportOption.Ignore, AppSettings.Current.PhysicalProject.ID);
                            if (ret.Result == ResultCode.Successful)
                            {
                                success += ret.Value.Successes != null ? ret.Value.Successes.Count : 0;
                                fail += ret.Value.Errors != null ? ret.Value.Errors.Count : 0;
                                this.Invoke((Action)(() =>
                                {
                                    foreach (var pair in rows)
                                    {
                                        if (ret.Value.Successes != null && ret.Value.Successes.ContainsKey(pair.Key)) pair.Value.Visible = false;
                                        else if (ret.Value.Errors != null && ret.Value.Errors.ContainsKey(pair.Key)) pair.Value.Cells["colReason"].Value = ret.Value.Errors[pair.Key];
                                    }
                                }));
                            }
                            else
                            {
                                fail += photoes.Count;
                                this.Invoke((Action)(() =>
                                {
                                    foreach (var pair in rows)
                                    {
                                        pair.Value.Cells["colReason"].Value = ret.Message;
                                    }
                                }));
                            }
                            photoes.Clear();
                            rows.Clear();
                            frm.ShowProgress(string.Format("导入{0}条数据 成功{1}条 失败{2}条", success + fail, success, fail), (decimal)(i + 1) / dataGridView1.Rows.Count);
                        }
                    }
                    frm.ShowProgress(string.Empty, 1);
                }
                catch (ThreadAbortException)
                {
                }
                catch (Exception ex)
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
            MessageBox.Show(string.Format("共导入 {0} 个学生的照片", success));
        }
        #endregion
    }
}
