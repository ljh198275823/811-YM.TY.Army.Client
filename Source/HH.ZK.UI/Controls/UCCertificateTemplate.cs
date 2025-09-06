using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HH.ZK.Model;
using HH.ZK.CommonUI;

namespace HH.ZK.UI.Controls
{
    public partial class UCCertificateTemplate : System.Windows.Forms.UserControl, ICertificateTemplate
    {
        public UCCertificateTemplate()
        {
            InitializeComponent();
        }

        private Barcode._1D.BarcodeGenerator b = new Barcode._1D.BarcodeGenerator();

        #region 公共方法
        public void FillCertificate(Student s, StudentPhoto sp, int? serial = null, string 自定义标题 = null)
        {
            try
            {
                if (!string.IsNullOrEmpty(自定义标题)) lblTitle.Text = 自定义标题;
                b.IncludeLabel = true;
                b.LabelPosition = Barcode._1D.LabelPositions.BOTTOMLEFT;
                b.Alignment = Barcode._1D.AlignmentPositions.LEFT;
                this.picBarcode.Image = b.Encode(Barcode._1D.TYPE.CODE128, s.ID, Color.Black, Color.White, this.picBarcode.Width, this.picBarcode.Height);
                lbl姓名.Text = s.Name;
                lbl性别.Text = s.Sex == Sex.Male ? "男" : "女";
                lbl考场.Text = string.Format("{0}", AppSettings.Current.PhysicalProject.Name);
                lbl考试科目.Text = AppSettings.Current.PhysicalProject.PhysicalItems?.GetShortNames(s.PhysicalItems, ",");
                var fname = s.FacilityName;
                lblSchool.Text = !string.IsNullOrEmpty(s.ClassName) ? string.Format("{0} {1}班", fname, s.ClassName.TrimEnd('班')) : fname;
                if (!string.IsNullOrEmpty(s.Groups)) lbl组别.Text = s.Groups.Replace("男子", string.Empty).Replace("女子", string.Empty);
                else lbl组别.Text = string.Empty;
                if (serial.HasValue)
                {
                    lblSerial.Visible = true;
                    lblSerial.Text = serial.Value.ToString();
                }
                else
                {
                    lblSerial.Visible = false;
                }
                picPhoto.Image = sp != null ? sp.GetPhoto() : null;
            }
            catch (Exception ex)
            {
            }
        }

        public void FillCertificate(Student s, string sg, int? serial = null, string 自定义标题 = null, StudentPhoto sp = null)
        {
            try
            {
                if (!string.IsNullOrEmpty(自定义标题)) lblTitle.Text = 自定义标题;
                b.IncludeLabel = true;
                b.LabelPosition = Barcode._1D.LabelPositions.BOTTOMLEFT;
                b.Alignment = Barcode._1D.AlignmentPositions.LEFT;
                this.picBarcode.Image = b.Encode(Barcode._1D.TYPE.CODE128, s.ID, Color.Black, Color.White, this.picBarcode.Width, this.picBarcode.Height);
                lbl姓名.Text = s.Name;
                lbl性别.Text = s.Sex == Sex.Male ? "男" : "女";
                lbl考场.Text = AppSettings.Current.PhysicalProject.Name;
                lbl考试科目.Text = AppSettings.Current.PhysicalProject.PhysicalItems?.GetShortNames(s.PhysicalItems, ",");
                var fname = s.FacilityName;
                lblSchool.Text = !string.IsNullOrEmpty(s.ClassName) ? string.Format("{0} {1}班", fname, s.ClassName.TrimEnd('班')) : fname;
                lbl组别.Text = string.Format("{0}{1}号", sg, s.Channel);
                picPhoto.Image = sp != null ? sp.GetPhoto() : null;
                if (serial.HasValue)
                {
                    lblSerial.Visible = true;
                    lblSerial.Text = serial.Value.ToString();
                }
                else
                {
                    lblSerial.Visible = false;
                }
            }
            catch (Exception ex)
            {
            }
        }
        #endregion
    }

    public interface ICertificateTemplate
    {
        void FillCertificate(Student s, StudentPhoto sp, int? serial = null, string 自定义标题 = null);
        void FillCertificate(Student s, string sg, int? serial = null, string 自定义标题 = null, StudentPhoto sp = null);
    }
}
