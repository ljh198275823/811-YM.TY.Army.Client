using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Threading;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HH.ZK.Model;
using HH.ZK.CommonUI;
using HH.ZK.WebAPIClient;
using LJH.GeneralLibrary;

namespace HH.ZK.CommonUI
{
    public partial class Frm导入特殊情况学生 : Form
    {
        public Frm导入特殊情况学生()
        {
            InitializeComponent();
        }

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
                MessageBox.Show("学号没有映射");
                cmbID.Focus();
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
            txt考试状态.Init(AppSettings.Current.PhysicalProject.StateSettings, false);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog saveFileDialog1 = new OpenFileDialog();
                saveFileDialog1.Filter = "Excel文档|*.xls;*.xlsx|所有文件(*.*)|*.*";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    ClearData();
                    string path = saveFileDialog1.FileName;
                    txtPath.Text = path;

                    _SourceTable = LJH.GeneralLibrary.WinForm.NPOIExcelHelper.Import(path);
                    if (_SourceTable != null)
                    {
                        viewSource.DataSource = _SourceTable;
                        FillColumn(_SourceTable, cmbID);
                        PreFillDes(cmbID, "学号");
                        PreFillDes(cmbID, "学籍号");
                        PreFillDes(cmbID, "准考证号");
                        FillColumn(_SourceTable, cmbName);
                        PreFillDes(cmbName, "姓名");
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
            if(string.IsNullOrEmpty (txt考试状态.Text))
            {
                MessageBox.Show("请设置特殊情况");
                return;
            }
            StudentState state = txt考试状态.SelectedStudentState;
            int perTime = 100;  //每次上传的记录数量
            FrmProcessing frm = new FrmProcessing();
            Action action = delegate ()
            {
                try
                {
                    int success = 0;
                    int fail = 0;
                    List<UpdateItem<string>> temp = new List<UpdateItem<string>>();
                    var rows = new Dictionary<string, DataGridViewRow>();
                    for (int i = 0; i < viewDestination.Rows.Count; i++)
                    {
                        if (viewDestination.Rows[i].Visible)
                        {
                            string sid = viewDestination.Rows[i].Cells["colID"].Value != null ? viewDestination.Rows[i].Cells["colID"].Value.ToString().Trim().ToUpper() : null;
                            if (!string.IsNullOrEmpty(sid) && !temp.Exists(it => it.ID == sid))
                            {
                                temp.Add(new UpdateItem<string>() { ID = sid, Key = "State", Value = ((int)state).ToString() });
                                rows.Add(sid, viewDestination.Rows[i]);
                            }
                        }
                        if (temp.Count >= perTime || i == viewDestination.Rows.Count - 1)
                        {
                            var ret = new APIClient(AppSettings.Current.ConnStr).BatchPatch<string, Student>(temp, AppSettings.Current.PhysicalProject.ID);
                            if (ret.Result == ResultCode.Successful)
                            {
                                success += ret.Value.Successes != null ? ret.Value.Successes.Count : 0;
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
                                this.Invoke((Action)(() =>
                                {
                                    foreach (var pair in rows)
                                    {
                                        pair.Value.Cells["colReason"].Value = ret.Message;
                                    }
                                }));
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
        }
        #endregion
    }
}
