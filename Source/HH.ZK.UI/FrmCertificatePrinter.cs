using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using HH.ZK.Model;
using HH.ZK.Model.CRM;
using HH.ZK.Model.SearchCondition;
using HH.ZK.CommonUI;
using HH.ZK.WebAPIClient;
using HH.ZK.UI.Controls;
using LJH.GeneralLibrary;

namespace HH.ZK.UI
{
    public partial class FrmCertificatePrinter : Form
    {
        public FrmCertificatePrinter()
        {
            InitializeComponent();
        }

        #region 私有方法
        private void ShowStudentInfo(DataGridViewRow row, Student s)
        {
            row.Tag = s;
            row.Cells["colFacility"].Value = s.FacilityName;
            row.Cells["colID"].Value = s.ID;
            row.Cells["colClassName"].Value = s.ClassName;
            row.Cells["colGroupID"].Value = s.Groups;
            row.Cells["colName"].Value = s.Name;
            row.Cells["colSex"].Value = s.Sex == Sex.Male ? "男" : "女";
            row.Cells["col考试科目"].Value = AppSettings.Current.PhysicalProject.PhysicalItems?.GetNames(s.PhysicalItems);
        }

        private List<Student> GetSelectedStudents()
        {
            List<Student> ret = new List<Student>();
            for(int i = 0; i < dataGridview1.Rows.Count; i++)
            {
                var row = dataGridview1.Rows[i];
                if (row.Selected) ret.Add(row.Tag as Student);
            }
            return ret;
        }
        #endregion

        #region 事件处理程序
        private void FrmCertificatePrinter_Load(object sender, EventArgs e)
        {
            ucStudentSearch1.Init(AppSettings.Current.PhysicalProject.ID);
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            dataGridview1.Rows.Clear();
            var con = ucStudentSearch1.GetSearchCondition();
            if (rdHasPhoto.Checked) con.HasPhoto = true;
            if (rdNonePhoto.Checked) con.HasPhoto = false;
            if (txt考试科目.Tag != null)
            {
                if (chk任意一项.Checked) con.AnyPhysicalItems = txt考试科目.Tag.ToString();
                else con.PhysicalItems = txt考试科目.Tag.ToString();
            }
            con.States = new List<StudentState>();
            if (chk正常考试.Checked) con.States.Add(StudentState.正常考试);
            if (chk择考.Checked) con.States.Add(StudentState.择考);
            if (chk缓考.Checked) con.States.Add(StudentState.缓考);
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
                    int row = dataGridview1.Rows.Add();
                    ShowStudentInfo(dataGridview1.Rows[row], s);
                }
                btnExportPdf.Enabled = true;
            }
            this.toolStripStatusLabel1.Text = string.Format("总共 {0} 项", dataGridview1.Rows.Count);
        }

        private void lnk考试科目_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var frm = new Frm考试科目选择();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.SelectedPhysicalIDs = txt考试科目.Tag != null ? txt考试科目.Tag.ToString() : null;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                var sp = frm.SelectedPhysicalIDs;
                txt考试科目.Tag = frm.SelectedPhysicalIDs;
                txt考试科目.Text = AppSettings.Current.PhysicalProject.PhysicalItems?.GetNames(frm.SelectedPhysicalIDs);
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (DataGridViewRow row in dataGridview1.Rows)
            {
                row.Selected = true;
                count++;
            }
            lbl选择数量.Text = count.ToString();
        }

        private void btnNone_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridview1.Rows)
            {
                row.Selected = false;
            }
            lbl选择数量.Text = "0";
        }

        private void dataGridview1_SelectionChanged(object sender, EventArgs e)
        {
            lbl选择数量.Text = dataGridview1.SelectedRows.Count.ToString();
        }

        private void btnExportPdf_Click(object sender, EventArgs e)
        {
            var ss = GetSelectedStudents();
            if(ss!=null && ss.Count > 0)
            {
                var frm = new Frm导出准考证();
                frm.PrintingStudents = ss;
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.ShowDialog();
            }
        }
        #endregion
    }
}
