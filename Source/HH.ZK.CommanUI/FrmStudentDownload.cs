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
using HH.ZK.WebAPIClient;
using HH.Zhongkao.Device;
using LJH.GeneralLibrary;

namespace HH.ZK.CommonUI
{
    public partial class FrmStudentDownload : Form
    {
        public FrmStudentDownload()
        {
            InitializeComponent();
        }

        #region 私有变量
        private HH.Zhongkao.Device.Download.StudentDownloader _HXHost = null;
        private byte _HostID = 0;
        private bool _Stoping = false;
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

        private List<DataGridViewRow> GetSelectedRows()
        {
            List<DataGridViewRow> rows = new List<DataGridViewRow>();
            foreach (DataGridViewRow row in dataGridview1.Rows)
            {
                if (row.Cells["colSelect"].Value != null && (bool)(row.Cells["colSelect"].Value))
                {
                    rows.Add(row);
                }
            }
            return rows;
        }

        private void ExportStudentsToCVS(List<DataGridViewRow> rows, string path)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("学号,姓名,性别,年级,班级,卡号,\r\n");
            foreach (DataGridViewRow row in rows)
            {
                var s = row.Tag as Student;
                sb.Append(string.Format("{0},{1},{2},{3},{4},{5},\r\n", s.ID, s.Name, s.Gender == Gender.Male ? "男" : "女", s.Grade, s.ClassName, s.CardID));
            }
            File.WriteAllText(path, sb.ToString(), Encoding.Default);
        }
        #endregion

        #region 事件处理程序
        private void FrmStudentUpload_Load(object sender, EventArgs e)
        {
            cmbCommport.Init();
            ucStudentSearch1.Init();
            cmbCommport.ComPort = AppSettings.Current.HostCommport;

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
        #endregion

        private void btnWrite_Click(object sender, EventArgs e)
        {
            bool cardID4StudentID = chkCardIDForStudentID.Checked;
            if (cmbCommport.ComPort <= 0)
            {
                MessageBox.Show("请设置连接主机的串口号");
                return;
            }
            int maxStudentPertime = this.txtMaxPertime.IntergerValue > 0 ? txtMaxPertime.IntergerValue : 1;
            List<DataGridViewRow> rows = GetSelectedRows();
            if (rows == null || rows.Count == 0)
            {
                MessageBox.Show("请选择要下载的学生信息");
                return;
            }
            if (MessageBox.Show("是否需要下载所选的学生信息到主机?", "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            InitHost();
            if (!_HXHost.IsOpened)
            {
                MessageBox.Show("串口打开失败");
                return;
            }
            FrmProcessing frmP = new FrmProcessing();
            int count = 0;
            _Stoping = false;
            Action action = delegate ()
            {
                try
                {
                    if (chkClearFirst.Checked)
                    {
                        _HXHost.ClearStudents(_HostID);
                    }
                    List<HostStudent> ss = new List<HostStudent>();
                    foreach (DataGridViewRow row in rows)
                    {
                        if (_Stoping) break;
                        Student s = row.Tag as Student;
                        count++;
                        ss.Add(new HostStudent() { StudentID = (cardID4StudentID && !string.IsNullOrEmpty(s.CardID)) ? s.CardID : s.ID, Name = s.Name, Sex = s.Gender == Gender.Male ? "男" : "女", Grade = (byte)s.Grade, ClassName = s.ClassName, CardID = s.CardID });
                        if (ss.Count >= maxStudentPertime)
                        {
                            HH.Zhongkao.Device.Download.CommandResult ret = _HXHost.DownloadStudents(_HostID, ss.ToArray());
                            ss.Clear();
                            frmP.ShowProgress(string.Format("已经下载 {0} 人，总共 {1}", count, rows.Count), (decimal)count / rows.Count);
                        }
                        if (count == rows.Count)
                        {
                            if (ss.Count > 0)
                            {
                                HH.Zhongkao.Device.Download.CommandResult ret = _HXHost.DownloadStudents(_HostID, ss.ToArray());
                                ss.Clear();
                            }
                            _HXHost.CompleteDownload(_HostID);
                            frmP.ShowProgress(string.Format("已经下载 {0} 人，总共 {1}", count, rows.Count), (decimal)count / rows.Count);
                        }
                    }
                    frmP.ShowProgress(string.Empty, 1);
                }
                catch (ThreadAbortException)
                {
                }
                catch (Exception)
                {
                }
                finally
                {
                    _HXHost.Close();
                }
            };
            Thread t = new Thread(new ThreadStart(action));
            t.IsBackground = true;
            t.Start();
            if (frmP.ShowDialog() != DialogResult.OK)
            {
                _Stoping = true;
                if (_HXHost != null) _HXHost.Close();
            }
            MessageBox.Show(string.Format("下载完成, 总共下载人数 {0}", count));
        }

        private void InitHost()
        {
            try
            {
                if (_HXHost != null)
                {
                    _HXHost.Close();
                }
                _HXHost = new HH.Zhongkao.Device.Download.StudentDownloader(cmbCommport.ComPort, 115200);
                _HXHost.Log = chkLog.Checked;
                _HXHost.Open();
            }
            catch (Exception)
            {
            }
        }

        private void cmbCommport_SelectedIndexChanged(object sender, EventArgs e)
        {
            AppSettings.Current.HostCommport = cmbCommport.ComPort;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (cmbCommport.ComPort <= 0)
            {
                MessageBox.Show("请设置连接主机的串口号");
                return;
            }
            InitHost();
            if (!_HXHost.IsOpened)
            {
                MessageBox.Show("串口打开失败");
                return;
            }
            HH.Zhongkao.Device.Download.CommandResult ret = _HXHost.ClearStudents(_HostID);
            MessageBox.Show(ret.ToString());
        }

        private void chkClearFirst_CheckedChanged(object sender, EventArgs e)
        {
            AppSettings.Current.SaveConfig(string.Format("{0}_{1}", this.Name, chkClearFirst.Name), chkClearFirst.Checked.ToString());
        }

        private void chkCardIDForStudentID_CheckedChanged(object sender, EventArgs e)
        {
            AppSettings.Current.SaveConfig(string.Format("{0}_{1}", this.Name, chkCardIDForStudentID.Name), chkCardIDForStudentID.Checked.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridView view = this.dataGridview1;
                if (view != null)
                {
                    SaveFileDialog dig = new SaveFileDialog();
                    dig.Filter = "Excel文档|*.xls;*.xlsx|所有文件(*.*)|*.*";
                    dig.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    if (dig.ShowDialog() == DialogResult.OK)
                    {
                        string path = dig.FileName;
                        LJH.GeneralLibrary.WinForm.DataGridViewExporter.Export(this.dataGridview1, path);
                        MessageBox.Show("导出成功");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("保存到电子表格时出现错误!");
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
                        ExportStudentsToCVS(GetSelectedRows(), path);
                        MessageBox.Show("导出成功");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("保存到电子表格时出现错误!");
            }
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
    }
}
