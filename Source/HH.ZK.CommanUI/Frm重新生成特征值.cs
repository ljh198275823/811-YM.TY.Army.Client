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
using HH.ZK.Model.SearchCondition;
using HH.ZK.WebAPIClient;
using LJH.GeneralLibrary;

namespace HH.ZK.CommonUI
{
    public partial class Frm重新生成特征值 : Form
    {
        public Frm重新生成特征值()
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
            row.Cells["colName"].Value = s.Name;
            row.Cells["colSex"].Value = s.Gender == Gender.Male ? "男" : "女";
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
            var con = new StudentSearchCondition();
            ucStudentSearch1.GetSearchCondition(con);
            con.HasPhoto = true;
            if (chk没有人脸特征.Checked) con.HasFaceFeature = false;
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
            else
            {
                MessageBox.Show("所有照片已有特征值，不需要重新生成");
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
            var rows = GetAllSelectedRows();
            if (rows.Count == 0)
            {
                MessageBox.Show("请选择要重新生成特征值的学生");
                return;
            }
            FrmProcessing frm = new FrmProcessing();
            int count = 0;
            int success = 0;
            int fail = 0;
            Thread t = null;
            Action action = delegate ()
            {
                try
                {
                    List<DataGridViewRow> temp = new List<DataGridViewRow>();
                    for (int i = 0; i < rows.Count; i++)
                    {
                        temp.Add(rows[i]);
                        if (temp.Count == 20 || i == rows.Count - 1)
                        {
                            var sids = temp.Select(it => (it.Tag as Student).ID).ToList();
                            var ret = new APIClient(AppSettings.Current.ConnStr).CreateFeature(sids, AppSettings.Current.PhysicalProject.ID);
                            if (ret.Result == ResultCode.Successful)
                            {
                                success += ret.Value.Successes != null ? ret.Value.Successes.Count : 0;
                                fail += ret.Value.Errors != null ? ret.Value.Errors.Count : 0;
                                this.Invoke((Action)(() =>
                                {
                                    foreach (var pair in temp)
                                    {
                                        var sid = (pair.Tag as Student).ID;
                                        if (ret.Value.Successes != null && ret.Value.Successes.ContainsKey(sid)) pair.Visible = false;
                                        else if (ret.Value.Errors != null && ret.Value.Errors.ContainsKey(sid)) pair.Cells["colReason"].Value = ret.Value.Errors[sid];
                                    }
                                }));
                            }
                            else
                            {
                                fail += temp.Count;
                                this.Invoke((Action)(() =>
                                {
                                    foreach (var pair in temp)
                                    {
                                        pair.Cells["colReason"].Value = ret.Message;
                                    }
                                }));
                            }
                            temp.Clear();
                            frm.ShowProgress(string.Format("执行{0}条数据 成功{1}条 失败{2}条", success + fail, success, fail), (decimal)(i + 1) / dataGridView1.Rows.Count);
                        }
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
            MessageBox.Show(string.Format("总共生成 {0} 条记录，其中成功 {1} 条", rows.Count, success));
        }
        #endregion
    }
}
