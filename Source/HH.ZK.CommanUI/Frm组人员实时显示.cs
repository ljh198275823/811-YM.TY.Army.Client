using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HH.ZK.Model;
using HH.ZK.Model.SearchCondition;
using HH.ZK.WebAPIClient;

namespace HH.ZK.CommonUI
{
    public partial class Frm组人员实时显示 : Form
    {
        public Frm组人员实时显示()
        {
            InitializeComponent();
        }

        private List<UC学生信息> _panels = new List<UC学生信息>();

        public void ShowStudentGroup(StudentGroup gp)
        {
            lblGroup.Text = string.Format("{0} 共 {1} 人", gp.FullName, gp.ItemsCount);
            foreach (var p in _panels)
            {
                this.flowLayoutPanel1.Controls.Remove(p);
            }
            _panels.Clear();
            var con = new StudentSearchCondition() { GroupID = gp.ID };
            var ss = new APIClient(AppSettings.Current.ConnStr).GetList<string, Student>(con, AppSettings.Current.PhysicalProject.ID).QueryObjects;
            foreach (var pair in gp.Items.OrderBy(it => it.Channel))
            {
                var s = ss.SingleOrDefault(it => it.ID == pair.StudentID);
                var p = new UC学生信息();
                p.FillCertificate(gp, pair, s);
                p.Tag = pair;
                _panels.Add(p);
                this.flowLayoutPanel1.Controls.Add(p);
            }
        }
    }
}
