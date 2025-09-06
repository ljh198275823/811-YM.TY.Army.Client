using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HH.ZK.Model;

namespace HH.ZK.UI.Controls
{
    public partial class UCCertificateTemplate_阳江 : System.Windows.Forms.UserControl, ICertificateTemplate
    {
        public UCCertificateTemplate_阳江()
        {
            InitializeComponent();
        }

        private Barcode._1D.BarcodeGenerator b = new Barcode._1D.BarcodeGenerator();

        private void UCCertificateTemplate_阳江_Load(object sender, EventArgs e)
        {
        }

        #region 公共方法
        public void FillCertificate(Student s, StudentPhoto sp, int? serial = null, string 自定义标题 = null)
        {
            try
            {
                if (!string.IsNullOrEmpty(自定义标题)) lblTitle.Text = 自定义标题;
                b.LabelPosition = Barcode._1D.LabelPositions.BOTTOMLEFT;
                b.Alignment = Barcode._1D.AlignmentPositions.LEFT;
                this.picBarcode.Image = b.Encode(Barcode._1D.TYPE.CODE128, s.ID, Color.Black, Color.White, this.picBarcode.Width, this.picBarcode.Height);
                lbl准考证号.Text = s.ID;
                lbl姓名.Text = s.Name;
                lbl性别.Text = s.Sex == Sex.Male ? "男" : "女";
                lblSchool.Text = AppSettings.Current.PhysicalProject.Name;
                var pis = s.获取所有考试科目();
                if (pis != null && pis.Count >= 1)
                {
                    var pi = AppSettings.Current.PhysicalProject.PhysicalItems?.GetPhysicalItem(pis[0]);
                    if (pi != null) lbl考试科目1.Text = string.IsNullOrEmpty(pi.ShortName) ? pi.Name : pi.ShortName;
                }
                if (pis != null && pis.Count >= 2)
                {
                    var pi = AppSettings.Current.PhysicalProject.PhysicalItems?.GetPhysicalItem(pis[1]);
                    if (pi != null) lbl考试科目2.Text = string.IsNullOrEmpty(pi.ShortName) ? pi.Name : pi.ShortName;
                }
                var fname = s.FacilityName;
                lblSchool.Text = !string.IsNullOrEmpty(s.ClassName) ? string.Format("{0} {1}班", fname, s.ClassName.TrimEnd('班')) : fname;
                lbl组别.Text = s.Groups;
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

        public void FillCertificate(Student s, string sg, int? serial = null, string 自定义标题 = null, StudentPhoto sp = null)
        {
            try
            {
                if (!string.IsNullOrEmpty(自定义标题)) lblTitle.Text = 自定义标题;
                b.LabelPosition = Barcode._1D.LabelPositions.BOTTOMLEFT;
                b.Alignment = Barcode._1D.AlignmentPositions.LEFT;
                this.picBarcode.Image = b.Encode(Barcode._1D.TYPE.CODE128, s.ID, Color.Black, Color.White, this.picBarcode.Width, this.picBarcode.Height);
                lbl准考证号.Text = s.ID;
                lbl姓名.Text = s.Name;
                lbl性别.Text = s.Sex == Sex.Male ? "男" : "女";
                lblSchool.Text = AppSettings.Current.PhysicalProject.Name;
                var pis = s.获取所有考试科目();
                if (pis != null && pis.Count >= 1)
                {
                    var pi = AppSettings.Current.PhysicalProject.PhysicalItems?.GetPhysicalItem(pis[0]);
                    if (pi != null) lbl考试科目1.Text = string.IsNullOrEmpty(pi.ShortName) ? pi.Name : pi.ShortName;
                }
                if (pis != null && pis.Count >= 2)
                {
                    var pi = AppSettings.Current.PhysicalProject.PhysicalItems?.GetPhysicalItem(pis[1]);
                    if (pi != null) lbl考试科目2.Text = string.IsNullOrEmpty(pi.ShortName) ? pi.Name : pi.ShortName;
                }
                var fname = s.FacilityName;
                lblSchool.Text = !string.IsNullOrEmpty(s.ClassName) ? string.Format("{0} {1}班", fname, s.ClassName.TrimEnd('班')) : fname;
                lbl组别.Text = string.Format("{0}{1}号", sg, s.Channel);
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
        #endregion
    }
}
