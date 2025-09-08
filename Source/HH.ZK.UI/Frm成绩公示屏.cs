using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using HH.ZK.Model;
using HH.ZK.Model.CRM;
using HH.ZK.CommonUI;
using HH.ZK.WebAPIClient;
using LJH.GeneralLibrary;
using libzkfpcsharp;

namespace HH.ZK.UI
{
    public partial class Frm成绩公示屏 : Form
    {
        public Frm成绩公示屏()
        {
            InitializeComponent();
        }

        #region 事件处理程序
        private void FrmScoreView_Load(object sender, EventArgs e)
        {
            InitFPDevice();
            picFPImg.Visible = false; // mDevHandle != IntPtr.Zero;
            txtBarcode.Focus();
            txtBarcode.SelectAll();
        }

        private void txt准考证号_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(txtBarcode.Text)) return;
                var sid = txtBarcode.Text.Trim();
                ShowSelectedStudent(sid);
            }
        }

        public void ShowSelectedStudent(string sid)
        {
            var s = new APIClient(AppSettings.Current.ConnStr).GetByID<string, StudentWithTotal>(sid, AppSettings.Current.PhysicalProject.ID).QueryObject;
            if (s != null)
            {
                ShowStudentInfo(s);
                ShowStudentScores(s);
                Bitmap bp = new Bitmap(pnl.Width, pnl.Height);
                pnl.DrawToBitmap(bp, new Rectangle(0, 0, pnl.Width, pnl.Height));
                pic.Image = bp;
                pic.Refresh();
                if (AppSettings.Current.Operator.PermitAny(Permission.总分, PermissionActions.Read))
                {
                    if (AppSettings.Current.EnableTTS) LJH.GeneralLibrary.Speech.TTSSpeech.Instance.Speek(string.Format("{0},{1}分", s.Name, s.Total), false);
                }
            }
            else
            {
                pic.Image = null;
                picFPImg.Image = null;
                picFPImg.Visible = false;
            }
            txtBarcode.SelectAll();
            txtBarcode.Focus();
        }

        private void ShowStudentScores(StudentWithTotal s)
        {
            //this.scoreView.Rows.Clear();
            //var pids = s.获取所有考试科目();
            //if (pids == null || pids.Count == 0) return;
            //this.scoreView.Height = pids.Count * 40 + 50 + 30;
            //foreach (var pid in s.获取所有考试科目())
            //{
            //    var pi = AppSettings.Current.PhysicalProject.PhysicalItems?.GetPhysicalItem(pid);
            //    if (pi != null)
            //    {
            //        int row = scoreView.Rows.Add();
            //        scoreView.Rows[row].Cells["colPhysicalItem"].Value = pi.Name;
            //        var ps = s.Scores.SingleOrDefault(it => it.PhysicalItemID == pid);
            //        if (ps != null)
            //        {
            //            scoreView.Rows[row].Cells["colScore"].Tag = pi;
            //            scoreView.Rows[row].Cells["colScore"].Value = ps.FormatScore;
            //            if (AppSettings.Current.Operator.PermitAny(Permission.总分, PermissionActions.Read))
            //            {
            //                scoreView.Rows[row].Cells["colResult"].Value = ps.Result != null ? ps.Result.Value.Trim().ToString() : null;
            //            }
            //        }
            //    }
            //}
            //if (AppSettings.Current.Operator.PermitAny(Permission.总分, PermissionActions.Read))
            //{
            //    int total = scoreView.Rows.Add();
            //    scoreView.Rows[total].Cells["colPhysicalItem"].Value = "总分";
            //    scoreView.Rows[total].Cells["colResult"].Value = s.Total > 0 ? s.Total : 0;
            //    scoreView.Rows[total].DefaultCellStyle.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            //    scoreView.Rows[total].Height = 50;
            //}

            //this.picFPImg.Left = this.scoreView.Left + 400;
            //this.picFPImg.Width = this.scoreView.Width - 400;
            //this.picFPImg.Top = this.scoreView.Top + this.scoreView.Height;
            //this.picFPImg.Height = pnl.Height - this.picFPImg.Top - 3;
            //var fp = (new APIClient(AppSettings.Current.ConnStr)).GetByID<string, StudentFP>(s.ID, AppSettings.Current.PhysicalProject.ID).QueryObject;
            //if (fp != null)
            //{
            //    this.picFPImg.Visible = true;
            //    this.picFPImg.Image = fp.GetImage();
            //    _FPCaptured = false;
            //}
            //else if (mDevHandle != IntPtr.Zero)
            //{
            //    this.picFPImg.Visible = true;
            //    picFPImg.Image = HH.ZK.UI.Properties.Resources.fpInput;
            //    _FPCaptured = true;
            //}
            //else
            //{
            //    this.picFPImg.Image = null;
            //    picFPImg.Visible = false;
            //}
        }

        private void ShowStudentInfo(Student s)
        {
            _txtID.Text = s.ID;
            _txtName.Text = s.Name;
            _rdMale.Checked = s.Gender == Gender.Male;
            _rdFemale.Checked = s.Gender == Gender.Female;
            txt学校.Text = s.DivisionName;
            StudentPhoto sp = (new APIClient(AppSettings.Current.ConnStr)).GetByID<string, StudentPhoto>(s.ID, AppSettings.Current.PhysicalProject.ID).QueryObject;
            if (sp != null)
            {
                picPhoto.Image = sp.GetPhoto();
            }
            else
            {
                picPhoto.Image = null;
            }
        }

        private void FrmScoreView_Resize(object sender, EventArgs e)
        {
            this.pnl.Top = this.Height + 100;
            this.pic.Width = (int)(this.Width * 0.9);
            this.pic.Height = (int)(this.Height * 0.8);
            this.pic.Location = new Point((int)(this.Width * 0.05), (int)(this.Height * 0.05));
        }

        private void Frm成绩公示屏_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseFPDevice();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region 指纹相关
        IntPtr mDevHandle = IntPtr.Zero;
        IntPtr mDBHandle = IntPtr.Zero;
        byte[] FPBuffer;
        byte[] CapTmp = new byte[2048];
        private int mfpWidth = 0;
        private int mfpHeight = 0;
        Thread captureThread = null;
        bool _FPCaptured = false;

        const int MESSAGE_CAPTURED_OK = 0x0400 + 6;

        private void InitFPDevice()
        {
            try
            {
                if (zkfp2.Init() != zkfperrdef.ZKFP_ERR_OK)
                {
                    LJH.GeneralLibrary.FileLog.Log("指纹", "初始化指纹库失败");
                    return;
                }
                int nCount = zkfp2.GetDeviceCount();
                if (nCount == 0)
                {
                    zkfp2.Terminate();
                    LJH.GeneralLibrary.FileLog.Log("指纹", "没有找到指纹设备");
                    return;
                }
                mDevHandle = zkfp2.OpenDevice(0);
                if (IntPtr.Zero == mDevHandle)
                {
                    zkfp2.Terminate();
                    LJH.GeneralLibrary.FileLog.Log("指纹", "打开指纹设备失败");
                    return;
                }
                mDBHandle = zkfp2.DBInit();
                if (IntPtr.Zero == mDBHandle)
                {
                    LJH.GeneralLibrary.FileLog.Log("指纹", "指纹数据库初始化失败");
                    zkfp2.CloseDevice(mDevHandle);
                    mDevHandle = IntPtr.Zero;
                    return;
                }
                byte[] paramValue = new byte[4];
                int size = 4;
                zkfp2.GetParameters(mDevHandle, 1, paramValue, ref size);
                zkfp2.ByteArray2Int(paramValue, ref mfpWidth);
                size = 4;
                zkfp2.GetParameters(mDevHandle, 2, paramValue, ref size);
                zkfp2.ByteArray2Int(paramValue, ref mfpHeight);
                FPBuffer = new byte[mfpWidth * mfpHeight];

                LJH.GeneralLibrary.FileLog.Log("指纹", "指纹设备打开成功");
                captureThread = new Thread(new ThreadStart(DoCapture));
                captureThread.IsBackground = true;
                captureThread.Start();
            }
            catch (Exception ex)
            {
                LJH.GeneralLibrary.FileLog.Log("指纹", ex.Message);
            }
        }

        private void DoCapture()
        {
            try
            {
                while (true)
                {
                    if (_FPCaptured)
                    {
                        try
                        {
                            int cbCapTmp = 2048;
                            int ret = zkfp2.AcquireFingerprint(mDevHandle, FPBuffer, CapTmp, ref cbCapTmp);
                            if (ret == zkfp.ZKFP_ERR_OK)
                            {
                                this.picFPImg.Image = null;
                                var path = Path.Combine(Application.StartupPath, "FingerPrinter.bmp");
                                using (var fs = new FileStream(path, FileMode.Create, FileAccess.Write))
                                {
                                    BitmapFormat.GetBitmap(FPBuffer, mfpWidth, mfpHeight, fs);
                                }
                                this.Invoke((Action)(delegate
                                {
                                    var ms = new MemoryStream(File.ReadAllBytes(path));
                                    Bitmap bmp = new Bitmap(ms);
                                    this.picFPImg.Image = bmp;

                                    Bitmap bp = new Bitmap(pnl.Width, pnl.Height);
                                    pnl.DrawToBitmap(bp, new Rectangle(0, 0, pnl.Width, pnl.Height));
                                    pic.Image = bp;
                                    pic.Refresh();

                                    if (!string.IsNullOrEmpty(_txtID.Text))
                                    {
                                        var fp = new StudentFP(_txtID.Text, path);
                                        var ret1 = new APIClient(AppSettings.Current.ConnStr).Add<string, StudentFP>(fp, AppSettings.Current.PhysicalProject.ID);
                                        if (ret1.Result == ResultCode.Successful) _FPCaptured = false; //指纹保存成功后，停止指纹采集，防止一个学生多次录入指纹
                                    }
                                }));
                            }
                        }
                        catch (Exception ex)
                        {

                        }
                    }
                    Thread.Sleep(200);
                }
            }
            catch (ThreadAbortException)
            {

            }
        }

        private void CloseFPDevice()
        {
            try
            {
                if (mDevHandle != IntPtr.Zero)
                {
                    zkfp2.CloseDevice(mDevHandle);
                    zkfp2.Terminate();
                    LJH.GeneralLibrary.FileLog.Log("指纹", "指纹设备关闭");
                }
            }
            catch (Exception ex)
            {

            }
            if (captureThread != null) captureThread.Abort();
        }
        #endregion
    }

    internal struct BITMAPFILEHEADER
    {
        public ushort bfType;
        public int bfSize;
        public ushort bfReserved1;
        public ushort bfReserved2;
        public int bfOffBits;
    }

    internal struct MASK
    {
        public byte redmask;
        public byte greenmask;
        public byte bluemask;
        public byte rgbReserved;
    }

    internal struct BITMAPINFOHEADER
    {
        public int biSize;
        public int biWidth;
        public int biHeight;
        public ushort biPlanes;
        public ushort biBitCount;
        public int biCompression;
        public int biSizeImage;
        public int biXPelsPerMeter;
        public int biYPelsPerMeter;
        public int biClrUsed;
        public int biClrImportant;
    }

    internal class BitmapFormat
    {
        /*******************************************
        * 函数名称：RotatePic       
        * 函数功能：旋转图片，目的是保存和显示的图片与按的指纹方向不同     
        * 函数入参：BmpBuf---旋转前的指纹字符串
        * 函数出参：ResBuf---旋转后的指纹字符串
        * 函数返回：无
        *********************************************/
        public static void RotatePic(byte[] BmpBuf, int width, int height, ref byte[] ResBuf)
        {
            int RowLoop = 0;
            int ColLoop = 0;
            int BmpBuflen = width * height;

            try
            {
                for (RowLoop = 0; RowLoop < BmpBuflen;)
                {
                    for (ColLoop = 0; ColLoop < width; ColLoop++)
                    {
                        ResBuf[RowLoop + ColLoop] = BmpBuf[BmpBuflen - RowLoop - width + ColLoop];
                    }

                    RowLoop = RowLoop + width;
                }
            }
            catch (Exception ex)
            {
                //ZKCE.SysException.ZKCELogger logger = new ZKCE.SysException.ZKCELogger(ex);
                //logger.Append();
            }
        }

        /*******************************************
        * 函数名称：StructToBytes       
        * 函数功能：将结构体转化成无符号字符串数组     
        * 函数入参：StructObj---被转化的结构体
        *           Size---被转化的结构体的大小
        * 函数出参：无
        * 函数返回：结构体转化后的数组
        *********************************************/
        public static byte[] StructToBytes(object StructObj, int Size)
        {
            int StructSize = Marshal.SizeOf(StructObj);
            byte[] GetBytes = new byte[StructSize];

            try
            {
                IntPtr StructPtr = Marshal.AllocHGlobal(StructSize);
                Marshal.StructureToPtr(StructObj, StructPtr, false);
                Marshal.Copy(StructPtr, GetBytes, 0, StructSize);
                Marshal.FreeHGlobal(StructPtr);

                if (Size == 14)
                {
                    byte[] NewBytes = new byte[Size];
                    int Count = 0;
                    int Loop = 0;

                    for (Loop = 0; Loop < StructSize; Loop++)
                    {
                        if (Loop != 2 && Loop != 3)
                        {
                            NewBytes[Count] = GetBytes[Loop];
                            Count++;
                        }
                    }

                    return NewBytes;
                }
                else
                {
                    return GetBytes;
                }
            }
            catch (Exception ex)
            {
                //ZKCE.SysException.ZKCELogger logger = new ZKCE.SysException.ZKCELogger(ex);
                //logger.Append();

                return GetBytes;
            }
        }

        /*******************************************
        * 函数名称：GetBitmap       
        * 函数功能：将传进来的数据保存为图片     
        * 函数入参：buffer---图片数据
        *           nWidth---图片的宽度
        *           nHeight---图片的高度
        * 函数出参：无
        * 函数返回：无
        *********************************************/
        public static void GetBitmap(byte[] buffer, int nWidth, int nHeight, Stream ms)
        {
            int ColorIndex = 0;
            ushort m_nBitCount = 8;
            int m_nColorTableEntries = 256;
            byte[] ResBuf = new byte[nWidth * nHeight * 2];

            BITMAPFILEHEADER BmpHeader = new BITMAPFILEHEADER();
            BITMAPINFOHEADER BmpInfoHeader = new BITMAPINFOHEADER();
            MASK[] ColorMask = new MASK[m_nColorTableEntries];

            int w = (((nWidth + 3) / 4) * 4);

            //图片头信息
            BmpInfoHeader.biSize = Marshal.SizeOf(BmpInfoHeader);
            BmpInfoHeader.biWidth = nWidth;
            BmpInfoHeader.biHeight = nHeight;
            BmpInfoHeader.biPlanes = 1;
            BmpInfoHeader.biBitCount = m_nBitCount;
            BmpInfoHeader.biCompression = 0;
            BmpInfoHeader.biSizeImage = 0;
            BmpInfoHeader.biXPelsPerMeter = 0;
            BmpInfoHeader.biYPelsPerMeter = 0;
            BmpInfoHeader.biClrUsed = m_nColorTableEntries;
            BmpInfoHeader.biClrImportant = m_nColorTableEntries;

            //文件头信息
            BmpHeader.bfType = 0x4D42;
            BmpHeader.bfOffBits = 14 + Marshal.SizeOf(BmpInfoHeader) + BmpInfoHeader.biClrUsed * 4;
            BmpHeader.bfSize = BmpHeader.bfOffBits + ((((w * BmpInfoHeader.biBitCount + 31) / 32) * 4) * BmpInfoHeader.biHeight);
            BmpHeader.bfReserved1 = 0;
            BmpHeader.bfReserved2 = 0;

            ms.Write(StructToBytes(BmpHeader, 14), 0, 14);
            ms.Write(StructToBytes(BmpInfoHeader, Marshal.SizeOf(BmpInfoHeader)), 0, Marshal.SizeOf(BmpInfoHeader));

            //调试板信息
            for (ColorIndex = 0; ColorIndex < m_nColorTableEntries; ColorIndex++)
            {
                ColorMask[ColorIndex].redmask = (byte)ColorIndex;
                ColorMask[ColorIndex].greenmask = (byte)ColorIndex;
                ColorMask[ColorIndex].bluemask = (byte)ColorIndex;
                ColorMask[ColorIndex].rgbReserved = 0;

                ms.Write(StructToBytes(ColorMask[ColorIndex], Marshal.SizeOf(ColorMask[ColorIndex])), 0, Marshal.SizeOf(ColorMask[ColorIndex]));
            }

            //图片旋转，解决指纹图片倒立的问题
            RotatePic(buffer, nWidth, nHeight, ref ResBuf);

            byte[] filter = null;
            if (w - nWidth > 0)
            {
                filter = new byte[w - nWidth];
            }
            for (int i = 0; i < nHeight; i++)
            {
                ms.Write(ResBuf, i * nWidth, nWidth);
                if (w - nWidth > 0)
                {
                    ms.Write(ResBuf, 0, w - nWidth);
                }
            }
        }

        /*******************************************
        * 函数名称：WriteBitmap       
        * 函数功能：将传进来的数据保存为图片     
        * 函数入参：buffer---图片数据
        *           nWidth---图片的宽度
        *           nHeight---图片的高度
        * 函数出参：无
        * 函数返回：无
        *********************************************/
        public static void WriteBitmap(byte[] buffer, int nWidth, int nHeight)
        {
            int ColorIndex = 0;
            ushort m_nBitCount = 8;
            int m_nColorTableEntries = 256;
            byte[] ResBuf = new byte[nWidth * nHeight];

            try
            {

                BITMAPFILEHEADER BmpHeader = new BITMAPFILEHEADER();
                BITMAPINFOHEADER BmpInfoHeader = new BITMAPINFOHEADER();
                MASK[] ColorMask = new MASK[m_nColorTableEntries];
                int w = (((nWidth + 3) / 4) * 4);
                //图片头信息
                BmpInfoHeader.biSize = Marshal.SizeOf(BmpInfoHeader);
                BmpInfoHeader.biWidth = nWidth;
                BmpInfoHeader.biHeight = nHeight;
                BmpInfoHeader.biPlanes = 1;
                BmpInfoHeader.biBitCount = m_nBitCount;
                BmpInfoHeader.biCompression = 0;
                BmpInfoHeader.biSizeImage = 0;
                BmpInfoHeader.biXPelsPerMeter = 0;
                BmpInfoHeader.biYPelsPerMeter = 0;
                BmpInfoHeader.biClrUsed = m_nColorTableEntries;
                BmpInfoHeader.biClrImportant = m_nColorTableEntries;

                //文件头信息
                BmpHeader.bfType = 0x4D42;
                BmpHeader.bfOffBits = 14 + Marshal.SizeOf(BmpInfoHeader) + BmpInfoHeader.biClrUsed * 4;
                BmpHeader.bfSize = BmpHeader.bfOffBits + ((((w * BmpInfoHeader.biBitCount + 31) / 32) * 4) * BmpInfoHeader.biHeight);
                BmpHeader.bfReserved1 = 0;
                BmpHeader.bfReserved2 = 0;

                Stream FileStream = File.Open("finger.bmp", FileMode.Create, FileAccess.Write);
                BinaryWriter TmpBinaryWriter = new BinaryWriter(FileStream);

                TmpBinaryWriter.Write(StructToBytes(BmpHeader, 14));
                TmpBinaryWriter.Write(StructToBytes(BmpInfoHeader, Marshal.SizeOf(BmpInfoHeader)));

                //调试板信息
                for (ColorIndex = 0; ColorIndex < m_nColorTableEntries; ColorIndex++)
                {
                    ColorMask[ColorIndex].redmask = (byte)ColorIndex;
                    ColorMask[ColorIndex].greenmask = (byte)ColorIndex;
                    ColorMask[ColorIndex].bluemask = (byte)ColorIndex;
                    ColorMask[ColorIndex].rgbReserved = 0;

                    TmpBinaryWriter.Write(StructToBytes(ColorMask[ColorIndex], Marshal.SizeOf(ColorMask[ColorIndex])));
                }
                //图片旋转，解决指纹图片倒立的问题
                RotatePic(buffer, nWidth, nHeight, ref ResBuf);

                //写图片
                //TmpBinaryWriter.Write(ResBuf);
                byte[] filter = null;
                if (w - nWidth > 0)
                {
                    filter = new byte[w - nWidth];
                }
                for (int i = 0; i < nHeight; i++)
                {
                    TmpBinaryWriter.Write(ResBuf, i * nWidth, nWidth);
                    if (w - nWidth > 0)
                    {
                        TmpBinaryWriter.Write(ResBuf, 0, w - nWidth);
                    }
                }

                FileStream.Close();
                TmpBinaryWriter.Close();
            }
            catch (Exception ex)
            {
                //ZKCE.SysException.ZKCELogger logger = new ZKCE.SysException.ZKCELogger(ex);
                //logger.Append();
            }
        }
    }
}
