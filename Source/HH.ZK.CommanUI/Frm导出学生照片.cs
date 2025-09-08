using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.IO;
using HH.ZK.Model;
using HH.ZK.WebAPIClient;
using LJH.GeneralLibrary.WinForm;

namespace HH.ZK.CommonUI
{
    public partial class Frm导出学生照片 : Form
    {
        public Frm导出学生照片()
        {
            InitializeComponent();
        }

        #region 私有变量
        #endregion

        #region 私有方法
        private void ShowStudentInfo(DataGridViewRow row, Student s)
        {
            row.Tag = s;
            row.Cells["colFacility"].Value = s.DivisionName;
            row.Cells["colID"].Value = s.ID;
            row.Cells["colClassName"].Value = s.ClassName;
            row.Cells["colGrade"].Value = GradeHelper.Instance.GetName(s.Grade);
            row.Cells["colName"].Value = s.Name;
            row.Cells["colSex"].Value = s.Gender == Gender.Male ? "男" : "女";
        }

        private DataGridViewRow GetPrintingRow()
        {
            for (int row = 0; row < dataGridView1.Rows.Count; row++)
            {
                if (dataGridView1.Rows[row].Cells["colSelect"].Value != null && (bool)(dataGridView1.Rows[row].Cells["colSelect"].Value))
                {
                    dataGridView1.Rows[row].Selected = true;
                    dataGridView1.Rows[row].Cells["colFill"].Value = "正在打印...";
                    if ((dataGridView1.FirstDisplayedScrollingRowIndex + dataGridView1.DisplayedRowCount(false)) <= row)
                    {
                        dataGridView1.FirstDisplayedScrollingRowIndex = (row - 5) > 0 ? (row - 5) : 0;
                    }
                    return dataGridView1.Rows[row];
                }
            }
            return null;
        }

        private List<DataGridViewRow> GetAllSelectedRows()
        {
            List<DataGridViewRow> rows = new List<DataGridViewRow>();
            for (int row = 0; row < dataGridView1.Rows.Count; row++)
            {
                if (dataGridView1.Rows[row].Cells["colSelect"].Value != null && (bool)(dataGridView1.Rows[row].Cells["colSelect"].Value))
                {
                    rows.Add(dataGridView1.Rows[row]);
                }
            }
            return rows;
        }

        private void ExportRows(List<DataGridViewRow> rows, string file)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("学校");
            dt.Columns.Add("学籍号");
            dt.Columns.Add("姓名");
            dt.Columns.Add("性别");
            dt.Columns.Add("年级");
            dt.Columns.Add("班级编号");
            dt.Columns.Add("班级名称");
            dt.Columns.Add("身份证号");
            foreach (DataGridViewRow row in rows)
            {
                var s = row.Tag as Student;
                dt.Rows.Add(s.DivisionName, s.ID, s.Name, s.Gender == Gender.Male ? "男" : "女", GradeHelper.Instance.GetName(s.Grade), "1", string.IsNullOrEmpty(s.ClassName) ? "1" : s.ClassName, s.IDNumber);
            }
            NPOIExcelHelper.Export(dt, file);
        }
        #endregion

        #region 事件处理程序
        private void FrmScoreBillPrint_Load(object sender, EventArgs e)
        {
            ucStudentSearch1.Init();
            int printInterval = 0;
            string temp = AppSettings.Current.GetConfigContent("PrintInterval");
            int.TryParse(temp, out printInterval);
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            var con = ucStudentSearch1.GetSearchCondition();
            con.HasPhoto = true;
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
                    int row = dataGridView1.Rows.Add();
                    ShowStudentInfo(dataGridView1.Rows[row], s);
                }
            }
            this.toolStripStatusLabel1.Text = string.Format("总共 {0} 项", dataGridView1.Rows.Count);
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells["colSelect"].Value = true;
                count++;
            }
            lbl选择数量.Text = count.ToString();
        }

        private void btnNone_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells["colSelect"].Value = false;
            }
            lbl选择数量.Text = "0";
        }

        private void btnRevert_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells["colSelect"].Value = !(Convert.ToBoolean(row.Cells["colSelect"].Value));
                if (Convert.ToBoolean(row.Cells["colSelect"].Value)) count++;
            }
            lbl选择数量.Text = count.ToString();
        }

        private void dataGridview1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "colSelect")
            {
                var cell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewCheckBoxCell;
                int count = int.Parse(lbl选择数量.Text);
                if (Convert.ToBoolean(cell.EditingCellFormattedValue)) count++;
                else count--;
                lbl选择数量.Text = count.ToString();
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (chk学号.Checked == false && chk姓名.Checked == false)
            {
                MessageBox.Show("文件命名至少要选择学号或姓名中的一项");
                return;
            }
            bool includeID = chk学号.Checked;
            bool include下划线 = chk下划线.Checked;
            bool includeName = chk姓名.Checked;
            FolderBrowserDialog dig = new FolderBrowserDialog();
            if (dig.ShowDialog() != DialogResult.OK) return;
            var folder = dig.SelectedPath;
            var rows = GetAllSelectedRows();
            if (rows.Count == 0) return;
            FrmProcessing frm = new FrmProcessing();
            int count = 0;
            int success = 0;
            Thread t = null;
            Action action = delegate ()
            {
                try
                {
                    for (int i = 0; i < rows.Count; i++)
                    {
                        Student s = rows[i].Tag as Student;
                        string file = Path.Combine(folder, string.Format("{0}{1}{2}.jpg", includeID ? s.ID : string.Empty, include下划线 ? "_" : string.Empty, includeName ? s.Name : string.Empty));
                        StudentPhoto sp = (new APIClient(AppSettings.Current.ConnStr)).GetByID<string, StudentPhoto>(s.ID, AppSettings.Current.PhysicalProject.ID).QueryObject;
                        if (sp != null) File.WriteAllBytes(file, sp.Photo);
                        count++;
                        if (System.IO.File.Exists(file)) success++;
                        frm.ShowProgress(string.Format("正在导出第 {0} 个学生，成功导出 {1} 个学生", i + 1, success), (decimal)i / rows.Count);
                    }
                }
                catch (ThreadAbortException)
                {
                }
                catch (Exception)
                {
                }
                frm.ShowProgress(string.Empty, 1);
                t = null;
            };
            t = new Thread(new ThreadStart(action));
            t.Start();
            frm.ShowDialog();
            if (t != null) t.Abort();
            MessageBox.Show(string.Format("总共导出 {0} 个学生，其中成功导出 {1} 个学生", count, success));
        }
        
        private void btn开始人脸识别文件夹_Click(object sender, EventArgs e)
        {
            if (chk学号.Checked == false)
            {
                MessageBox.Show("请选择按学号导出照片");
                return;
            }
            if (chk姓名.Checked || chk下划线.Checked)
            {
                MessageBox.Show("请选择按学号导出照片");
                return;
            }
            var rows = GetAllSelectedRows();
            if (rows.Count == 0)
            {
                MessageBox.Show("请选择要导出照片的学生");
                return;
            }
            bool includeID = chk学号.Checked;
            bool include下划线 = chk下划线.Checked;
            bool includeName = chk姓名.Checked;
            FolderBrowserDialog dig = new FolderBrowserDialog();
            if (dig.ShowDialog() != DialogResult.OK) return;
            var folder = dig.SelectedPath;
            string photos = null;
            string fname = null;
            if (string.IsNullOrEmpty(fname)) fname = ucStudentSearch1.GetFacilityName();
            if (string.IsNullOrEmpty(fname)) fname = ucStudentSearch1.GetDivisionName();
            if (string.IsNullOrEmpty(fname)) fname = DateTime.Now.ToString("yyyyMMddHHmmss");
            try
            {
                Directory.CreateDirectory(Path.Combine(folder, fname));
                photos = Path.Combine(folder, fname, "photos");
                Directory.CreateDirectory(photos);
                var xls = Path.Combine(folder, fname, fname + ".xls");
                ExportRows(rows, xls);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            FrmProcessing frm = new FrmProcessing();
            int count = 0;
            int success = 0;
            Thread t = null;
            Action action = delegate ()
            {
                try
                {
                    for (int i = 0; i < rows.Count; i++)
                    {
                        Student s = rows[i].Tag as Student;
                        string file = Path.Combine(photos, string.Format("{0}{1}{2}.jpg", includeID ? s.ID : string.Empty, include下划线 ? "_" : string.Empty, includeName ? s.Name : string.Empty));
                        StudentPhoto sp = (new APIClient(AppSettings.Current.ConnStr)).GetByID<string, StudentPhoto>(s.ID, AppSettings.Current.PhysicalProject.ID).QueryObject;
                        if (sp != null) File.WriteAllBytes(file, sp.Photo);
                        count++;
                        if (System.IO.File.Exists(file)) success++;
                        frm.ShowProgress(string.Format("正在导出第 {0} 个学生，成功导出 {1} 个学生", i + 1, success), (decimal)i / rows.Count);
                    }
                }
                catch (ThreadAbortException)
                {
                }
                catch (Exception)
                {
                }
                frm.ShowProgress(string.Empty, 1);
                t = null;
            };
            t = new Thread(new ThreadStart(action));
            t.Start();
            frm.ShowDialog();
            if (t != null) t.Abort();
            MessageBox.Show(string.Format("总共导出 {0} 个学生，其中成功导出 {1} 个学生", count, success));
        }
        #endregion

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
    }
}
