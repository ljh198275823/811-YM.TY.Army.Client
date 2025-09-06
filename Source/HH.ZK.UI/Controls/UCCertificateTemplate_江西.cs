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
    public partial class UCCertificateTemplate_江西 : System.Windows.Forms.UserControl, ICertificateTemplate
    {
        public UCCertificateTemplate_江西()
        {
            InitializeComponent();
        }

        private void UCCertificateTemplate_江西_Load(object sender, EventArgs e)
        {
        }

        #region 公共方法
        public void FillCertificate(Student s, StudentPhoto sp, int? serial = null, string 自定义标题 = null)
        {
            try
            {
                if (!string.IsNullOrEmpty(自定义标题)) lblTitle.Text = 自定义标题;
                lbl姓名.Text = s.Name;
                lbl性别.Text = s.Sex == Sex.Male ? "男" : "女";
                lbl准考证号.Text = s.ID;
                lbl身份证号.Text = s.IDNumber;
                lbl学校.Text = s.FacilityName;
                lbl考点.Text = AppSettings.Current.PhysicalProject.Name;
                lbl考试科目.Text = AppSettings.Current.PhysicalProject.PhysicalItems?.GetNames(s.PhysicalItems);
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
                lbl姓名.Text = s.Name;
                lbl性别.Text = s.Sex == Sex.Male ? "男" : "女";
                lbl准考证号.Text = s.ID;
                lbl身份证号.Text = s.IDNumber;
                lbl学校.Text = s.FacilityName;
                lbl考点.Text = AppSettings.Current.PhysicalProject.Name;
                lbl考试科目.Text = AppSettings.Current.PhysicalProject.PhysicalItems?.GetNames(s.PhysicalItems);
                picPhoto.Image = sp != null ? sp.GetPhoto() : null;
            }
            catch (Exception ex)
            {
            }
        }
        #endregion
    }
}
