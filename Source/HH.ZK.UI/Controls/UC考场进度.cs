using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HH.ZK.Model ;

namespace HH.ZK.UI.Controls
{
    public partial class UC考场进度 : System.Windows.Forms.UserControl
    {
        public UC考场进度()
        {
            InitializeComponent();
        }

        public void FreshState(PhysicalProjectStatistic ps)
        {
            if (ps != null)
            {
                this.Tag = ps;
                lbl考点.Text = ps.Name;
                lbl总人数.Text = ps.TotalCount.ToString();
                lbl完成人数.Text = ps.Completed.ToString();
                lbl已检录人数.Text = ps.Checked.ToString();
                lbl缺免考人数.Text = ps.Absent.ToString();
                if (ps.TotalCount > 0)
                {
                    pr学生完成进度.Value = (int)(Math.Round((decimal)(ps.Completed + ps.Absent) / ps.TotalCount, 2) * 100);
                    pr学生检录进度.Value = (int)(Math.Round((decimal)(ps.Checked + ps.Absent) / ps.TotalCount, 2) * 100);
                }
            }
        }
    }
}
