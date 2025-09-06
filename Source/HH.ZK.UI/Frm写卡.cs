using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using HH.ZK.Model;
using HH.ZK.WebAPIClient;
using HH.ZK.CommonUI;
using HH.Zhongkao.Device.Reader;
using LJH.GeneralLibrary;

namespace HH.ZK.UI
{
    public partial class Frm写卡 : Form
    {
        public Frm写卡()
        {
            InitializeComponent();
        }

        #region 私有变量
        private ICCardReader _ICCardReader = null;
        private int _WritingRow = 0;
        private string _LastStudentID = null; //获取最后一次写成功的学生学号
        private Thread _WriteStudentThread = null;
        private Thread _ClearCardThread = null;
        #endregion

        #region 私有方法
        private void InitCardReader()
        {
            try
            {
                if (_ICCardReader != null) _ICCardReader.Close();
                if (AppSettings.Current.CardReaderCommport > 0)
                {
                    _ICCardReader = new ICCardReader(AppSettings.Current.CardReaderCommport, 9600);
                    _ICCardReader.Log = chkLog.Checked;
                    _ICCardReader.Open();
                }
            }
            catch (Exception ex)
            {
                LJH.GeneralLibrary.ExceptionPolicy.HandleException(ex);
            }
        }

        private void SelectStudent(int row)
        {
            if (dataGridview1.Rows.Count > row)
            {
                Student s = dataGridview1.Rows[row].Tag as Student;
                dataGridview1.Rows[row].Selected = true;
                dataGridview1.Rows[row].Cells["colFill"].Value = "正在写卡...";
                if ((dataGridview1.FirstDisplayedScrollingRowIndex + dataGridview1.DisplayedRowCount(false)) <= row)
                {
                    dataGridview1.FirstDisplayedScrollingRowIndex = (row - 5) > 0 ? (row - 5) : 0;
                }
            }
        }

        private Student GetWritingStudent()
        {
            if (dataGridview1.Rows.Count > _WritingRow)
            {
                return dataGridview1.Rows[_WritingRow].Tag as Student;
            }
            return null;
        }

        private void WriteStudentInfo()
        {
            string sid;
            string sname;
            string gender;
            string grade;
            string cardID;

            Student s = GetWritingStudent();
            if (s == null)
            {
                btnWrite.PerformClick();
            }
            else if (_ICCardReader != null && _ICCardReader.IsOpened)
            {
                CommandRet ret = _ICCardReader.ReadCard(out sid, out sname, out gender, out grade, out cardID);
                if (ret == CommandRet.NoCar) return;  //如果没有卡片也不用继续了,
                if (ret == CommandRet.SUCCEED && !string.IsNullOrEmpty(sid) && sid == _LastStudentID) return;  //读到的卡片是上次写的学号，表示用户还没有将卡拿开，
                if (ret == CommandRet.SUCCEED && !string.IsNullOrEmpty(sid) && s.ID != sid.Trim() && !chkOverride.Checked) return;//如果卡片中已经有另外一个人的信息,如果不能覆盖则返回
                ret = _ICCardReader.InitCard(s.ID, s.Name, s.Sex == Sex.Male ? "1" : "2", string.Empty);
                if (ret == CommandRet.SUCCEED)
                {
                    Action action = delegate()
                    {
                        if (dataGridview1.Rows.Count > _WritingRow && _WritingRow >= 0)
                        {
                            dataGridview1.Rows[_WritingRow].Cells["colFill"].Value = "写卡成功";
                            dataGridview1.Rows[_WritingRow].Selected = false;
                        }
                        _LastStudentID = s.ID;
                        _WritingRow++;
                        SelectStudent(_WritingRow);
                    };
                    this.Invoke(action);
                }
            }
        }
        #endregion

        #region 事件处理程序
        private void FrmWriteStudentToICCard_Load(object sender, EventArgs e)
        {
            this.ucStudentSearch1.Init(AppSettings.Current.PhysicalProject.ID);
            lblClear.Visible = false;
        }

        private void ShowStudentInfo(DataGridViewRow row, Student s)
        {
            row.Tag = s;
            row.Cells["colFacility"].Value = s.FacilityName;
            row.Cells["colID"].Value = s.ID;
            row.Cells["colClassName"].Value = s.ClassName;
            row.Cells["colGroup"].Value = s.Groups;
            row.Cells["colName"].Value = s.Name;
            row.Cells["colSex"].Value = s.Sex == Sex.Male ? "男" : "女";
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            dataGridview1.Rows.Clear();
            var con = ucStudentSearch1.GetSearchCondition();
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
            btnWrite.Enabled = dataGridview1.Rows.Count > 0;
        }

        private void cmbCommport_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            if (_WriteStudentThread == null)
            {
                InitCardReader();
                if (_ICCardReader == null || !_ICCardReader.IsOpened)
                {
                    MessageBox.Show("读写器串口打开失败", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                dataGridview1.Enabled = false;
                btnQuery.Enabled = false;
                btnClear.Enabled = false;
                lblClear.Visible = false;
                _WritingRow = 0;
                _LastStudentID = null;
                if (dataGridview1.SelectedRows.Count > 0) _WritingRow = dataGridview1.SelectedRows[0].Index;
                foreach (DataGridViewRow row in dataGridview1.SelectedRows)
                {
                    row.Selected = false;
                }
                SelectStudent(_WritingRow);
                _WriteStudentThread = new Thread(new ThreadStart(WriteCard_Task));
                _WriteStudentThread.IsBackground = true;
                _WriteStudentThread.Start();
                btnWrite.Text = "停止写卡";
            }
            else
            {
                dataGridview1.Enabled = true;
                btnQuery.Enabled = true;
                btnClear.Enabled = true;
                _WriteStudentThread.Abort();
                _WriteStudentThread = null;
                btnWrite.Text = "开始写卡(&W)";
            }
        }

        private void WriteCard_Task()
        {
            try
            {
                while (true)
                {
                    WriteStudentInfo();
                    Thread.Sleep(200);
                }
            }
            catch (ThreadAbortException)
            {
            }
            catch (Exception)
            {
            }
        }

        private void FrmWriteStudentToICCard_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_WriteStudentThread != null)
            {
                _WriteStudentThread.Abort();
                _WriteStudentThread = null;
            }
            if (_ClearCardThread != null)
            {
                _ClearCardThread.Abort();
                _ClearCardThread = null;
            }
            if (_ICCardReader != null) _ICCardReader.Close();
        }
        #endregion

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (_ClearCardThread == null)
            {
                InitCardReader();
                if (_ICCardReader == null || !_ICCardReader.IsOpened)
                {
                    MessageBox.Show("读写器串口打开失败", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                btnWrite.Enabled = false;
                _ClearCardThread = new Thread(new ThreadStart(ClearCard_Task));
                _ClearCardThread.IsBackground = true;
                _ClearCardThread.Start();
                btnClear.Text = "停止清除卡片";
            }
            else
            {
                btnWrite.Enabled = dataGridview1.Rows.Count > 0;
                _ClearCardThread.Abort();
                _ClearCardThread = null;
                btnClear.Text = "开始清除卡片";
            }
        }

        private void ClearCard_Task()
        {
            try
            {
                int count = 0;
                while (true)
                {
                    CommandRet ret = _ICCardReader.InitCard(string.Empty, string.Empty, string.Empty, string.Empty);
                    if (ret == CommandRet.SUCCEED)
                    {
                        count++;
                        this.Invoke((Action)(() => { lblClear.Visible = true; lblClear.Text = string.Format("已清除卡片 ({0})张", count); }));
                    }
                    Thread.Sleep(1000);
                }
            }
            catch (ThreadAbortException)
            {
            }
            catch (Exception)
            {
            }
        }
    }
}
