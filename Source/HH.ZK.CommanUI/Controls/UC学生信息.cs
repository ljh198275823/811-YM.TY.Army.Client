using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HH.ZK.Model;
using HH.ZK.WebAPIClient;

namespace HH.ZK.CommonUI
{
    public partial class UC学生信息 : System.Windows.Forms.UserControl
    {
        public UC学生信息()
        {
            InitializeComponent();
        }

        public void FillCertificate(StudentGroup gp, StudentGroupPair p, Student s)
        {
            lblName.Text = s.Name;
            //lbl班级.Text = gp.ToString();
            lblGender.Text = s.Sex == Sex.Male ? "男" : "女";
            lblSchool.Text = s.FacilityName;
            StudentPhoto sp = new APIClient(AppSettings.Current.ConnStr).GetByID<string, StudentPhoto>(s.ID, AppSettings.Current.PhysicalProject.ID).QueryObject;
            picPhoto.Image = sp != null ? sp.GetPhoto() : null;
            if (p.Channel.HasValue)
            {
                lblSerial.Visible = true;
                lblSerial.Text = p.Channel.Value.ToString();
            }
            else
            {
                lblSerial.Visible = false;
            }
        }
    }
}
