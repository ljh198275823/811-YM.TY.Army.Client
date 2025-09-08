using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using HH.ZK.Model;
using HH.ZK.Model.SearchCondition;
using HH.ZK.WebAPIClient;

namespace HH.ZK.CommonUI
{
    public partial class FrmStudentDownloadPara : Form
    {
        public FrmStudentDownloadPara()
        {
            InitializeComponent();
        }

        #region 私有变量

        #endregion

        #region 公共属性
        public List<Student> students = null;
        public int maxStudentPertime = 20;
        public bool cardID4StudentID = false;
        public bool clearFirst = false;
        public bool DownloadPhoto = false;
        #endregion

        #region 私有方法
        private void ShowStudentInfo(DataGridViewRow row, Student s)
        {
            row.Tag = s;
            row.Cells["colFacility"].Value = s.DivisionName;
            row.Cells["colID"].Value = s.ID;
            row.Cells["colClassName"].Value = s.ClassName;
            row.Cells["colName"].Value = s.Name;
            row.Cells["colSex"].Value = s.Gender == Gender.Male ? "男" : "女";
            row.Cells["colCardID"].Value = s.CardID;
        }

        private List<Student> GetSelectedStudents()
        {
            List<Student> ret = new List<Student>();
            foreach (DataGridViewRow row in dataGridview1.Rows)
            {
                if (row.Cells["colSelect"].Value != null && (bool)(row.Cells["colSelect"].Value))
                {
                    ret.Add(row.Tag as Student);
                }
            }
            return ret;
        }
        #endregion

        #region 事件处理程序
        private void FrmStudentUpload_Load(object sender, EventArgs e)
        {
            ucStudentSearch1.Init();
            bool clearFirst = false;
            string temp = AppSettings.Current.GetConfigContent(string.Format("{0}_{1}", this.Name, chkClearFirst.Name));
            bool.TryParse(temp, out clearFirst);
            chkClearFirst.Checked = clearFirst;
            bool cardID = false;
            temp = AppSettings.Current.GetConfigContent(string.Format("{0}_{1}", this.Name, chkCardIDForStudentID.Name));
            bool.TryParse(temp, out cardID);
            chkCardIDForStudentID.Checked = cardID;
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
            }
            this.toolStripStatusLabel1.Text = string.Format("总共 {0} 项", dataGridview1.Rows.Count);
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (DataGridViewRow row in dataGridview1.Rows)
            {
                row.Cells["colSelect"].Value = true;
                count++;
            }
            lbl选择数量.Text = count.ToString();
        }

        private void btnNone_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridview1.Rows)
            {
                row.Cells["colSelect"].Value = false;
            }
            lbl选择数量.Text = "0";
        }

        private void btnRevert_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (DataGridViewRow row in dataGridview1.Rows)
            {
                row.Cells["colSelect"].Value = !(Convert.ToBoolean(row.Cells["colSelect"].Value));
                if (Convert.ToBoolean(row.Cells["colSelect"].Value)) count++;
            }
            lbl选择数量.Text = count.ToString();
        }

        private void dataGridview1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridview1.Columns[e.ColumnIndex].Name == "colSelect")
            {
                var cell = dataGridview1.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewCheckBoxCell;
                int count = int.Parse(lbl选择数量.Text);
                if (Convert.ToBoolean(cell.EditingCellFormattedValue)) count++;
                else count--;
                lbl选择数量.Text = count.ToString();
            }
        }

        private void chkClearFirst_CheckedChanged(object sender, EventArgs e)
        {
            AppSettings.Current.SaveConfig(string.Format("{0}_{1}", this.Name, chkClearFirst.Name), chkClearFirst.Checked.ToString());
        }

        private void chkCardIDForStudentID_CheckedChanged(object sender, EventArgs e)
        {
            AppSettings.Current.SaveConfig(string.Format("{0}_{1}", this.Name, chkCardIDForStudentID.Name), chkCardIDForStudentID.Checked.ToString());
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            cardID4StudentID = chkCardIDForStudentID.Checked;
            clearFirst = chkClearFirst.Checked;
            maxStudentPertime = this.txtMaxPertime.IntergerValue > 0 ? txtMaxPertime.IntergerValue : 1;
            students = GetSelectedStudents();
            DownloadPhoto = chkPhoto.Checked;
            if (students == null || students.Count == 0)
            {
                MessageBox.Show("请选择要下载的学生信息");
                return;
            }
            this.DialogResult = DialogResult.OK;
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

        private void btnExportCSV_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridView view = this.dataGridview1;
                if (view != null)
                {
                    SaveFileDialog dig = new SaveFileDialog();
                    dig.Filter = "CSV文档|*.csv;";
                    dig.FileName = "CSZXX.CSV";
                    dig.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    if (dig.ShowDialog() == DialogResult.OK)
                    {
                        string path = dig.FileName;
                        ExportStudentsToCVS(GetSelectedStudents(), path);
                        MessageBox.Show("导出成功");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("保存到电子表格时出现错误!");
            }
        }

        private void ExportStudentsToCVS(List<Student> students, string path)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("学号,姓名,性别,年级,班级,卡号,\r\n");
            foreach (var s in students)
            {
                sb.Append(string.Format("{0},{1},{2},{3},{4},{5},\r\n", s.ID, s.Name, s.Gender == Gender.Male ? "男" : "女", s.Grade, s.ClassName, s.CardID));
            }
            File.WriteAllText(path, sb.ToString(), Encoding.Default);
        }
    }
}
