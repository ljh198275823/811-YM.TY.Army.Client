using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using HH.ZK.Model;
using HH.ZK.WebAPIClient;
using HH.ZK.CommonUI;
using LJH.GeneralLibrary;

namespace HH.ZK.UI
{
    public partial class Frm考试科目导入 : Form
    {
        public Frm考试科目导入()
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
                        FillColumn(_SourceTable, cmbPhysicalID1);
                        PreFillDes(cmbPhysicalID1, "考试科目");
                        PreFillDes(cmbPhysicalID1, "科目");
                        PreFillDes(cmbPhysicalID1, "选考科目");
                        FillColumn(_SourceTable, cmbPhysicalID2);
                        FillColumn(_SourceTable, cmbPhysicalID3);
                        FillColumn(_SourceTable, cmbPhysicalID4);
                        FillColumn(_SourceTable, cmbPhysicalID5);
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
            int perTime = 100;  //每次上传的记录数量
            string merge = rdOverride.Checked ? "override" : null;
            FrmProcessing frm = new FrmProcessing();
            Action action = delegate ()
            {
                try
                {
                    List<DataGridViewRow> rows = new List<DataGridViewRow>();
                    List<UpdateItem<string>> patches = new List<UpdateItem<string>>();
                    for (int i = 0; i < viewDestination.Rows.Count; i++)
                    {
                        if (viewDestination.Rows[i].Visible)
                        {
                            var item = GetPatch(viewDestination.Rows[i]);
                            if (item != null)
                            {
                                item.OriginalValue = merge;
                                patches.Add(item);
                            }
                            rows.Add(viewDestination.Rows[i]);
                        }
                        if (patches.Count >= perTime || i == viewDestination.Rows.Count - 1)
                        {
                            var ret = new APIClient(AppSettings.Current.ConnStr).BatchPatch<string, Student>(patches, AppSettings.Current.PhysicalProject.ID);
                            if (ret.Result == ResultCode.Successful && ret.Value != null)
                            {
                                this.Invoke((Action)(() =>
                                {
                                    foreach (DataGridViewRow row in rows)
                                    {
                                        var studentID = row.Cells["colID"].Value.ToString();
                                        if (ret.Value.Successes != null && ret.Value.Successes.ContainsKey(studentID))
                                        {
                                            success++;
                                            row.Visible = false;
                                        }
                                        else if (ret.Value.Errors != null && ret.Value.Errors.ContainsKey(studentID))
                                        {
                                            fail++;
                                            row.Cells["colReason"].Value = ret.Value.Errors[studentID];
                                        }
                                    }
                                }));
                            }
                            else
                            {
                                fail += rows.Count;
                            }
                            patches.Clear();
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
            MessageBox.Show(string.Format("共导入成功{0}条数据", success), "结果");
        }

        private UpdateItem<string> GetPatch(DataGridViewRow row)
        {
            string sid = row.Cells["colID"].Value != null ? row.Cells["colID"].Value.ToString().Trim().ToUpper() : null;
            if (string.IsNullOrEmpty(sid)) return null; ;
            string names = string.Empty;
            if (row.Cells["col考试科目1"].Value != null) names += row.Cells["col考试科目1"].Value.ToString() + ",";
            if (row.Cells["col考试科目2"].Value != null) names += row.Cells["col考试科目2"].Value.ToString() + ",";
            if (row.Cells["col考试科目3"].Value != null) names += row.Cells["col考试科目3"].Value.ToString() + ",";
            if (row.Cells["col考试科目4"].Value != null) names += row.Cells["col考试科目4"].Value.ToString() + ",";
            if (row.Cells["col考试科目5"].Value != null) names += row.Cells["col考试科目5"].Value.ToString() + ",";

            if (string.IsNullOrEmpty(names)) return null;
            if (AppSettings.Current.PhysicalProject.PhysicalItems == null) return null;
            List<string> physicals = new List<string>();
            string[] strPhysicals = names.Split(',', '，');
            foreach (var str in strPhysicals)
            {
                if (string.IsNullOrEmpty(str) || string.IsNullOrEmpty(str.Trim())) continue;
                var pi = AppSettings.Current.PhysicalProject.PhysicalItems.GetPhysicalItem(str.Trim());
                if (pi != null)
                {
                    physicals.Add(pi.ID.ToString());
                }
                else
                {

                    row.Cells["colReason"].Value = $"不能识别 {str}";
                    return null;
                }
            }
            if (physicals.Count == 0)
            {
                row.Cells["colReason"].Value = "不能识别这些科目";
                return null;
            }
            return new UpdateItem<string>() { ID = sid, Key = "PhysicalItems", Value = string.Join(",", physicals) };
        }
        #endregion
    }
}
