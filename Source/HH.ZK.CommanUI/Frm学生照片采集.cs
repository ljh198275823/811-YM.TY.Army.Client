using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Drawing.Imaging;
using System.Windows.Forms;
using HH.ZK.Model;
using HH.ZK.Model.SearchCondition;
using HH.ZK.WebAPIClient;
using LJH.GeneralLibrary;
using AForge.Video.DirectShow;

namespace HH.ZK.CommonUI
{
    public partial class Frm学生照片采集 : Form
    {
        public Frm学生照片采集()
        {
            InitializeComponent();
        }

        #region 私有变量
        private int _WritingRow = 0;
        #endregion

        #region 私有方法
        private void SelectStudent(int row)
        {
            if (dataGridView1.Rows.Count > row)
            {
                Student s = dataGridView1.Rows[row].Tag as Student;
                if (s == null) return;
                dataGridView1.Rows[row].Selected = true;
                dataGridView1.Rows[row].Cells["colFill"].Value = "正在拍照...";
            }
        }

        private Student GetWritingStudent()
        {
            if (dataGridView1.Rows.Count > _WritingRow)
            {
                return dataGridView1.Rows[_WritingRow].Tag as Student;
            }
            return null;
        }

        private FilterInfoCollection videoDevices;

        private void OpenCamara()
        {
            try
            {
                videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                if (videoDevices != null && videoDevices.Count > 0)
                {
                    var sindex = chk使用另一个摄像头.Checked ? 0 : videoDevices.Count - 1;
                    var ri = videoDevices[sindex];
                    var f = videoDevices[sindex].MonikerString;
                    VideoCaptureDevice videoSource = new VideoCaptureDevice(f);
                    videoSource.VideoResolution = videoSource.VideoCapabilities[0];
                    videPlayer.VideoSource = videoSource;
                    videPlayer.NewFrame -= new AForge.Controls.VideoSourcePlayer.NewFrameHandler(videPlayer_NewFrame);
                    videPlayer.NewFrame += new AForge.Controls.VideoSourcePlayer.NewFrameHandler(videPlayer_NewFrame);
                    videPlayer.Start();
                }
            }
            catch (Exception)
            {
            }
        }

        void videPlayer_NewFrame(object sender, ref Bitmap image)
        {
            try
            {
                if (image != null)
                {
                    if ((image.Height / 3) * 4 < image.Width)
                    {
                        var temp = image.Width - (image.Height / 3) * 4;
                        var img2 = KiCut(image, temp / 2, 0, image.Width - temp, image.Height);
                        this.pictureBox1.Image = img2;
                    }
                    else if ((image.Height / 3) * 4 == image.Width)
                    {
                        this.pictureBox1.Image = image;
                    }
                    else
                    {
                        var temp = image.Height - (image.Width / 4) * 3;
                        var img2 = KiCut(image, 0, temp / 2, image.Width, image.Height - temp);
                        this.pictureBox1.Image = img2;
                    }
                }
            }
            catch
            {

            }
        }

        private void CloseCamara()
        {
            try
            {
                videPlayer.SignalToStop();
                videPlayer.WaitForStop();
            }
            catch (Exception)
            {
            }
        }

        private byte[] SnapShot()
        {
            try
            {
                var bmpSource = this.pictureBox1.Image as Bitmap;
                if (bmpSource != null)
                {
                    var xScalle = (decimal)bmpSource.Width / this.pictureBox1.Width;
                    var yscalle = (decimal)bmpSource.Height / this.pictureBox1.Height;
                    var bmp = KiCut(bmpSource, (int)(_拍照框X * xScalle), (int)(_拍照框Y * yscalle), (int)(_拍照框宽 * xScalle), (int)(_拍照框高 * yscalle));
                    if (bmp != null)
                    {
                        using (MemoryStream ms = new MemoryStream())
                        {
                            bmp.Save(ms, ImageFormat.Jpeg);
                            byte[] buffer = new byte[ms.Length];
                            ms.Seek(0, SeekOrigin.Begin);
                            ms.Read(buffer, 0, buffer.Length);
                            return buffer;
                        }
                    }
                }
            }
            catch (Exception)
            {

            }
            return null;
        }

        private Bitmap KiCut(Bitmap b, int StartX, int StartY, int iWidth, int iHeight)
        {
            if (b == null) return null;
            int w = b.Width;
            int h = b.Height;
            if (StartX >= w || StartY >= h) return null;
            if (StartX + iWidth > w) iWidth = w - StartX;
            if (StartY + iHeight > h) iHeight = h - StartY;
            try
            {
                Bitmap bmpOut = new Bitmap(iWidth, iHeight, PixelFormat.Format24bppRgb);
                Graphics g = Graphics.FromImage(bmpOut);
                g.DrawImage(b, new Rectangle(0, 0, iWidth, iHeight), new Rectangle(StartX, StartY, iWidth, iHeight), GraphicsUnit.Pixel);
                g.Dispose();
                return bmpOut;
            }
            catch
            {
                return null;
            }
        }
        #endregion

        #region 事件处理程序
        private void FrmWriteStudentToICCard_Load(object sender, EventArgs e)
        {
            ucStudentSearch1.Init();
            lblClear.Visible = false;
            _拍照框X = (pictureBox1.Width - _拍照框宽) / 2;
            _拍照框Y = (pictureBox1.Height - _拍照框高) / 2;
            videPlayer.Top = this.Height + 300;
            OpenCamara();
        }

        private void ShowStudentInfo(DataGridViewRow row, Student s)
        {
            row.Tag = s;
            row.Cells["colFacility"].Value = s.DivisionName;
            row.Cells["colID"].Value = s.ID;
            row.Cells["colClassName"].Value = s.ClassName;
            row.Cells["colName"].Value = s.Name;
            row.Cells["colSex"].Value = s.Gender == Gender.Male ? "男" : "女";
            row.Cells["colGrade"].Value = GradeHelper.Instance.GetName(s.Grade);
            row.Cells["col照片"].Value = s.HasPhoto;
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            _WritingRow = 0;
            var con = ucStudentSearch1.GetSearchCondition();
            if (rdHasPhoto.Checked) con.HasPhoto = true;
            if (rdNonePhoto.Checked) con.HasPhoto = false;
            if (rd有人脸特征.Checked) con.HasFaceFeature = true;
            if (rd无人脸特征.Checked) con.HasFaceFeature = false;
            var ret = new APIClient(AppSettings.Current.ConnStr).GetList<string, Student>(con, AppSettings.Current.PhysicalProject.ID);
            if (ret.Result != LJH.GeneralLibrary.ResultCode.Successful)
            {
                MessageBox.Show(ret.Message);
                return;
            }
            var students = ret.QueryObjects;
            if (students != null && students.Count > 0)
            {
                foreach (Student s in students)
                {
                    int row = dataGridView1.Rows.Add();
                    ShowStudentInfo(dataGridView1.Rows[row], s);
                }
            }
            this.toolStripStatusLabel1.Text = string.Format("总共 {0} 项", dataGridView1.Rows.Count);
            btnWrite.Enabled = dataGridView1.Rows.Count > 0;
            SelectStudent(_WritingRow);
        }

        private void btnSnapShot_Click(object sender, EventArgs e)
        {
            Student s = GetWritingStudent();
            if (s == null) return;
            var data = SnapShot();
            if (data != null && data.Length > 0)
            {
                var sp = new StudentPhoto(s.ID, data);
                pictureBox2.Tag = sp;
                pictureBox2.Image = sp.GetPhoto();
                btnSave.Enabled = true;
                btnSave.Focus();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var sp = pictureBox2.Tag as StudentPhoto;
            if (sp != null)
            {
                sp.CheckFace = AppSettings.Current.PhysicalProject.Options.IgnoreFaceFeature ? false : true;
                Student s = GetWritingStudent();
                var ret = (new APIClient(AppSettings.Current.ConnStr)).Add<string, StudentPhoto>(sp, AppSettings.Current.PhysicalProject.ID);
                if (ret.Result == ResultCode.Successful)
                {
                    if (ret.Value.FaceFeature == null || ret.Value.FaceFeature.Length == 0)
                    {
                        MessageBox.Show("提取人脸特征失败，请重新采集照片");
                    }
                    else
                    {
                        s.HasPhoto = true;
                        dataGridView1.SelectionChanged -= GridView_SelectionChanged;
                        dataGridView1.Rows.RemoveAt(_WritingRow);
                        dataGridView1.SelectionChanged += GridView_SelectionChanged;
                        SelectStudent(_WritingRow);
                        this.toolStripStatusLabel1.Text = string.Format("总共 {0} 项", dataGridView1.Rows.Count);
                    }
                }
                else
                {
                    MessageBox.Show(ret.Message);
                }
            }
            btnSave.Enabled = false;
        }

        private void GridView_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells["colFill"].Value = string.Empty;
            }
            if (dataGridView1.SelectedRows.Count > 0)
            {
                _WritingRow = dataGridView1.SelectedRows[0].Index;
                SelectStudent(_WritingRow);
            }
        }

        private void FrmWriteStudentToICCard_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseCamara();
        }

        private void btnOpenCamera_Click(object sender, EventArgs e)
        {
            CloseCamara();
            OpenCamara();
        }
        #endregion

        #region 移动拍照框相关
        private int _拍照框X = 0;
        private int _拍照框Y = 0;
        private int _拍照框宽 = 210;
        private int _拍照框高 = 280;
        private int _开始拖动X = 0;
        private int _开始拖动Y = 0;
        private bool _拍照框移动 = false;

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                var pen = new Pen(Brushes.Yellow, 4);
                var rec = new Rectangle(_拍照框X, _拍照框Y, _拍照框宽, _拍照框高);
                e.Graphics.DrawRectangle(pen, rec);

                pen = new Pen(Brushes.Red, 1);
                rec = new Rectangle(_拍照框X + 30, _拍照框Y + 20, _拍照框宽 - 60, _拍照框高 - 60); //头像
                e.Graphics.DrawRectangle(pen, rec);
            }
            catch
            {
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.X >= _拍照框X && e.X <= _拍照框X + _拍照框宽)
            {
                _拍照框移动 = true;
                _开始拖动X = e.X;
                _开始拖动Y = e.Y;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            _拍照框移动 = false;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_拍照框移动)
            {
                if (e.X >= _开始拖动X)
                {
                    if ((_拍照框X + _拍照框宽 + (e.X - _开始拖动X)) < pictureBox1.Width) _拍照框X = _拍照框X + (e.X - _开始拖动X);
                }
                else
                {
                    if (_拍照框X >= (_开始拖动X - e.X)) _拍照框X -= _开始拖动X - e.X;
                }
                _开始拖动X = e.X;
            }
        }
        #endregion

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var frm = new Frm照片采集示例();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
        }
    }
}
