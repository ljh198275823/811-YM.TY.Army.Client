using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Threading;
using System.Data.OleDb;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HH.ZK.Model;
using HH.ZK.WebAPIClient;
using LJH.GeneralLibrary;

namespace HH.ZK.CommonUI
{
    public partial class FrmScoreImport_SingleCol : Form
    {
        public FrmScoreImport_SingleCol()
        {
            InitializeComponent();
        }

        public Project Project { get; set; }

        #region 私有变量
        private DataTable _SourceTable = null;
        #endregion

        #region 私有方法
        private void ClearData()
        {
            viewDestination.Rows.Clear();
            lblSource.Text = "条数据";
            viewSource.DataSource = null;
            lblSource.Text = "条数据";
            cmbID.Items.Clear();
        }

        private bool CheckMapping()
        {
            if (string.IsNullOrEmpty(cmbID.Text))
            {
                MessageBox.Show("准考证号没有映射");
                cmbID.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(cmbPhysicalItem.Text))
            {
                MessageBox.Show("测试项没有映射");
                cmbPhysicalItem.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(cmbScore.Text))
            {
                MessageBox.Show("成绩没有映射");
                cmbScore.Focus();
                return false;
            }
            return true;
        }

        private void FillColumn(DataTable dt, ComboBox cmb)
        {
            cmb.Items.Clear();
            cmb.Items.Add(string.Empty);
            foreach (DataColumn col in dt.Columns)
            {
                cmb.Items.Add(col.ColumnName);
            }
        }

        private void PreFillDes(ComboBox cmb, string field)
        {
            if (cmb.Items.Count <= 0) return;
            for (int i = 0; i < cmb.Items.Count; i++)
            {
                if (cmb.Items[i].ToString() == field)
                {
                    cmb.SelectedIndex = i;
                }
            }
        }

        private StudentRawScore GetScore(DataGridViewRow row)
        {
            StudentRawScore ret = null;
            string studentID = row.Cells["colID"].Value != null ? row.Cells["colID"].Value.ToString().Trim().ToUpper() : null;
            if (!string.IsNullOrEmpty(studentID)) studentID = Regex.Replace(studentID, "[^0-9A-Z]", string.Empty);
            if (string.IsNullOrEmpty(studentID))
            {
                row.Cells["colReason"].Value = "学号为空";
                return ret;
            }
            string strPid = row.Cells["colPhysicalItem"].Value != null ? row.Cells["colPhysicalItem"].Value.ToString().Trim() : null;
            if (string.IsNullOrEmpty(strPid))
            {
                row.Cells["colReason"].Value = "测试项为空";
                return ret;
            }
            int pid = 0;
            if (int.TryParse(strPid, out pid) == false || pid <= 0)
            {
                row.Cells["colReason"].Value = "测试项为空";
                return ret;
            }
            string strDt = row.Cells["col测试时间"].Value != null ? row.Cells["col测试时间"].Value.ToString().Trim() : null;
            DateTime dt;
            if (string.IsNullOrEmpty(strDt) || !DateTime.TryParse(strDt, out dt))
            {
                row.Cells["colReason"].Value = "测试日期为空";
                return ret;
            }

            string s = row.Cells["colScore"].Value != null ? row.Cells["colScore"].Value.ToString().Trim() : null;
            decimal score = 0;
            if (string.IsNullOrEmpty(s))
            {
                row.Cells["colReason"].Value = "无效的成绩";
                return null;
            }
            if (!decimal.TryParse(s, out score))
            {
                row.Cells["colReason"].Value = "无效的成绩";
                return null;
            }
            ret = new StudentRawScore() { StudentID = studentID, TestID = pid, Score = score.ToString(), CreateTime = dt, ScoreFrom = ScoreSource.文件导入 };
            return ret;
        }
        #endregion

        #region 事件处理程序
        private void FrmStudentImport_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn col in viewSource.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            foreach (DataGridViewColumn col in viewDestination.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog saveFileDialog1 = new OpenFileDialog();
                saveFileDialog1.Filter = "Excel文档|*.xls;*.xlsx;*.csv|所有文件(*.*)|*.*";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    ClearData();
                    string path = saveFileDialog1.FileName;
                    txtPath.Text = path;

                    if (System.IO.Path.GetExtension(path).ToUpper() == ".CSV")
                    {
                        _SourceTable = LJH.GeneralLibrary.WinForm.CsvHelper.Import(path, Encoding.Default);
                    }
                    else
                    {
                        _SourceTable = LJH.GeneralLibrary.WinForm.NPOIExcelHelper.Import(path);
                    }
                    if (_SourceTable != null)
                    {
                        viewSource.DataSource = _SourceTable;
                        FillColumn(_SourceTable, cmbID);
                        PreFillDes(cmbID, "学号");
                        PreFillDes(cmbID, "学籍号");
                        PreFillDes(cmbID, "准考证号");
                        FillColumn(_SourceTable, cmbName);
                        PreFillDes(cmbName, "姓名");
                        FillColumn(_SourceTable, cmbPhysicalItem);
                        PreFillDes(cmbPhysicalItem, "测试项");
                        PreFillDes(cmbPhysicalItem, "项目编号");
                        PreFillDes(cmbPhysicalItem, "测试科目");
                        FillColumn(_SourceTable, cmbScore);
                        PreFillDes(cmbScore, "成绩");
                        FillColumn(_SourceTable, cmb测试时间);
                        PreFillDes(cmb测试时间, "测试时间");
                        PreFillDes(cmb测试时间, "测试日期");
                    }
                    lblSource.Text = string.Format("{0}条数据", _SourceTable != null ? _SourceTable.Rows.Count : 0);
                }
            }
            catch (Exception ex)
            {
                LJH.GeneralLibrary.ExceptionPolicy.HandleException(ex);
                MessageBox.Show(ex.Message);
            }
        }

        private void cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = sender as ComboBox;
            string colName = string.Empty;
            if (cmb != null)
            {
                colName = cmb.Tag.ToString();
                for (int i = 0; i < _SourceTable.Rows.Count; i++)
                {
                    if (viewDestination.Rows.Count < i + 1) viewDestination.Rows.Add();
                    object value = null;
                    if (!string.IsNullOrEmpty(cmb.Text)) value = _SourceTable.Rows[i][cmb.Text];
                    viewDestination.Rows[i].Cells[colName].Value = value;
                    viewDestination.Rows[i].Visible = true;
                }
                lblDesCount.Text = string.Format("{0}条数据", viewDestination.Rows.Count);
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            if (viewDestination.Rows.Count == 0) return;
            if (!CheckMapping()) return;
            int success = 0;
            int fail = 0;
            int perTime = 900;  //每次上传的记录数量
            FrmProcessing frm = new FrmProcessing();
            Action action = delegate ()
            {
                try
                {
                    List<StudentRawScore> temp = new List<StudentRawScore>();
                    var rows = new Dictionary<long, DataGridViewRow>();
                    for (int i = 0; i < viewDestination.Rows.Count; i++)
                    {
                        if (viewDestination.Rows[i].Visible)
                        {
                            var score = GetScore(viewDestination.Rows[i]);
                            if (score != null)
                            {
                                temp.Add(score);
                                rows.Add(i, viewDestination.Rows[i]);
                            }
                        }
                        if (temp.Count >= perTime || i == viewDestination.Rows.Count - 1)
                        {
                            ImportOption option = ImportOption.Ignore;
                            if (rdOverride.Checked) option = ImportOption.Override;
                            if (rdAppend.Checked) option = ImportOption.Append;
                            var ret = new APIClient(AppSettings.Current.ConnStr).BatchAdd<long,StudentRawScore>(temp, option, null);
                            if (ret.Result == ResultCode.Successful)
                            {
                                success +=temp.Count - (ret.Value.Errors != null ? ret.Value.Errors.Count : 0);
                                fail += ret.Value.Errors != null ? ret.Value.Errors.Count : 0;
                                this.Invoke((Action)(() =>
                                {
                                    foreach (var pair in rows)
                                    {
                                        if (ret.Value.Successes != null && ret.Value.Successes.ContainsKey(pair.Key)) pair.Value.Visible = false;
                                        else if (ret.Value.Errors != null && ret.Value.Errors.ContainsKey(pair.Key)) pair.Value.Cells["colReason"].Value = ret.Value.Errors[pair.Key];
                                    }
                                }));
                            }
                            else
                            {
                                fail += temp.Count;
                                LJH.GeneralLibrary.FileLog.Log("学生成绩导入", ret.Message);
                            }
                            temp.Clear();
                            rows.Clear();
                            frm.ShowProgress(string.Format("导入{0}条数据 成功{1}条 失败{2}条", success + fail, success, fail), (decimal)(i + 1) / viewDestination.Rows.Count);
                        }
                    }
                    frm.ShowProgress(string.Empty, 1);
                }
                catch (ThreadAbortException)
                {
                }
                catch (Exception ex)
                {
                    LJH.GeneralLibrary.ExceptionPolicy.HandleException(ex);
                }
            };

            Thread t = new Thread(new ThreadStart(action));
            t.IsBackground = true;
            t.Start();
            if (frm.ShowDialog() != DialogResult.OK)
            {
                t.Abort();
            }
            lblDesCount.Text = string.Format("{0}条数据", viewDestination.Rows.Count - success); //显示剩余的记录条数,所有导入成绩的列都会删除或隐藏
            MessageBox.Show(string.Format("共导入成功{0}条数据", success), "结果");
        }
        #endregion
    }
}
