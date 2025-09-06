using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using LJH.GeneralLibrary;

namespace HH.ZK.Model
{
    public class StudentFP : LJH.GeneralLibrary.IEntity<string>
    {
        #region 构造函数
        public StudentFP()
        {
        }

        public StudentFP(string id, string path)
        {
            ID = id;
            FPImage = GetBytesFromPhoto(path);
        }

        public StudentFP(string id, byte[] photo)
        {
            ID = id;
            FPImage = photo;
        }
        #endregion

        #region 私有变量
        private Image _Img;
        #endregion

        #region 私有方法
        private Image GetImageFromBytes(byte[] photo)
        {
            try
            {
                if (photo != null)
                {
                    string path = Path.Combine(TempFolderManager.GetCurrentFolder(),
                    string.Format("{0}_{1}.jpg", "FP", Guid.NewGuid().ToString()));
                    using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
                    {
                        fs.Write(photo, 0, photo.Length);
                    }
                    Image img = Image.FromFile(path);
                    return img;
                }
                else
                {
                    return null;
                }
            }
            catch
            {
                return null;
            }
        }

        private byte[] GetBytesFromPhoto(string path)
        {
            byte[] bs = null;
            try
            {
                using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    bs = new byte[fs.Length];
                    fs.Position = 0;
                    fs.Read(bs, 0, (int)fs.Length);
                }
            }
            catch (Exception ex)
            {
                LJH.GeneralLibrary.ExceptionPolicy.HandleException(ex);
            }
            return bs;
        }
        #endregion

        #region 公共属性
        /// <summary>
        /// 获取或设置人员ID
        /// </summary>
        public string ID { get; set; }
        /// <summary>
        /// 获取图片的内容字节
        /// </summary>
        public byte[] FPImage { get; set; }
        /// <summary>
        /// 获取或设置创建时间
        /// </summary>
        public DateTime AddTime { get; set; }
        #endregion

        #region 公共方法
        /// <summary>
        /// 获取或设置人员图片
        /// </summary>
        public Image GetImage()
        {
            if (_Img == null)
            {
                if (FPImage != null)
                {
                    _Img = GetImageFromBytes(FPImage);
                }
            }
            return _Img;
        }
        #endregion
    }
}
