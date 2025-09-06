using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Threading;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HH.ZK.Model;
using HH.ZK.WebAPIClient;
using LJH.GeneralLibrary;

namespace HH.ZK.CommonUI
{
    public partial class FrmScoreImport_文件夹 : Form
    {
        public FrmScoreImport_文件夹()
        {
            InitializeComponent();
        }

        #region 私有变量
        private DataTable _SourceTable = null;
        private List<ComboBox> _PhysicalItemCmbs = new List<ComboBox>();
        #endregion

        #region 私有方法
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

        private void InitScoreComboBoxs()
        {
            ComboBox preCmb = cmbID;
            Label preArrow = lblArrow;
            Label preDes = lblDestination;
            int pad = 30;
            if (AppSettings.Current.PhysicalProject.PhysicalItems.Items == null || AppSettings.Current.PhysicalProject.PhysicalItems.Items.Count == 0) return;
            foreach (var pi in AppSettings.Current.PhysicalProject.PhysicalItems.Items)
            {
                if (!string.IsNullOrEmpty(pi.Formula)) continue;
                ComboBox cmb = new ComboBox();
                cmb.Name = "cmb" + pi.ID.ToString();
                cmb.Tag = pi;
                cmb.DropDownStyle = ComboBoxStyle.DropDownList;
                cmb.Left = preCmb.Left;
                cmb.Width = preCmb.Width;
                cmb.Height = preCmb.Height;
                cmb.Top = preCmb.Top + pad;
                cmb.SelectedIndexChanged += cmb_SelectedIndexChanged;
                _PhysicalItemCmbs.Add(cmb);
                Label lblArrow1 = new Label();
                lblArrow1.Left = preArrow.Left;
                lblArrow1.Top = preArrow.Top + pad;
                lblArrow1.Width = preArrow.Width;
                lblArrow1.Height = preArrow.Height;
                lblArrow1.TextAlign = preArrow.TextAlign;
                lblArrow1.Text = preArrow.Text;
                Label lblDes = new Label();
                lblDes.Left = preDes.Left;
                lblDes.Top = preDes.Top + pad;
                lblDes.Height = preDes.Height;
                lblDes.Text = pi.Name;
                lblDes.TextAlign = preDes.TextAlign;
                pnlPhysicalItem.Controls.Add(cmb);
                pnlPhysicalItem.Controls.Add(lblArrow1);
                pnlPhysicalItem.Controls.Add(lblDes);
                preCmb = cmb;
                preArrow = lblArrow1;
                preDes = lblDes;
                AddScoreColumn(pi);
            }
        }

        private DataGridViewColumn AddScoreColumn(PhysicalItem item)
        {
            DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
            col.Name = "col_" + item.ID.ToString(); ;
            col.Tag = item;
            col.MinimumWidth = 60;
            col.Width = 80;
            col.ReadOnly = true;
            col.SortMode = DataGridViewColumnSortMode.NotSortable;
            col.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            col.HeaderText = string.IsNullOrEmpty(item.Unit) ? item.Name : string.Format("{0}({1})", item.Name, item.Unit);
            this.viewDestination.Columns.Insert(this.viewDestination.Columns.Count - 1, col);
            return col;
        }

        private void ShowFile(string path)
        {
            try
            {
                viewDestination.Rows.Clear();
                cmbID.Items.Clear();
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
                    FillColumn(_SourceTable, cmbID);
                    PreFillDes(cmbID, "学号");
                    PreFillDes(cmbID, "学籍号");
                    PreFillDes(cmbID, "准考证号");
                    foreach (ComboBox cmb in _PhysicalItemCmbs)
                    {
                        FillColumn(_SourceTable, cmb);
                        PreFillDes(cmb, (cmb.Tag as PhysicalItem).Name);
                    }
                }
            }
            catch (Exception ex)
            {
                LJH.GeneralLibrary.ExceptionPolicy.HandleException(ex);
                MessageBox.Show(ex.Message);
            }
        }

        private void SelectFile(int row)
        {
            try
            {
                if (viewSource.Rows.Count > row)
                {
                    Student s = viewSource.Rows[row].Tag as Student;
                    viewSource.Rows[row].Selected = true;
                    if ((viewSource.FirstDisplayedScrollingRowIndex + viewSource.DisplayedRowCount(false)) <= row)
                    {
                        viewSource.FirstDisplayedScrollingRowIndex = (row - 5) > 0 ? (row - 5) : 0;
                    }
                }
            }
            catch
            {

            }
        }
        #endregion

        #region 事件处理程序
        private void FrmStudentImport_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn col in viewDestination.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            InitScoreComboBoxs();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog frm = new FolderBrowserDialog();
            if (!string.IsNullOrEmpty(txtPath.Text)) frm.SelectedPath = txtPath.Text;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = frm.SelectedPath;
                string path = txtPath.Text.Trim();
                viewSource.Rows.Clear();
                if (!string.IsNullOrEmpty(path) && Directory.Exists(path))
                {
                    string[] files = Directory.GetFiles(path, "*.xls");
                    if (files != null || files.Length > 0)
                    {
                        foreach (string file in files)
                        {
                            int row = viewSource.Rows.Add();
                            viewSource.Rows[row].Tag = file;
                            viewSource.Rows[row].Cells["colFile"].Value = Path.GetFileNameWithoutExtension(file).Trim();
                        }
                    }
                }
                this.lblSource.Text = string.Format("总共 {0} 个文件", viewSource.Rows.Count);
                btnImport.Enabled = viewSource.Rows.Count > 0;
            }
        }

        private void cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = sender as ComboBox;
            string colName = string.Empty;
            if (cmb != null)
            {
                if (cmb.Tag is PhysicalItem)
                {
                    colName = "col_" + (cmb.Tag as PhysicalItem).ID.ToString();
                }
                else
                {
                    colName = cmb.Tag.ToString();
                }
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
            if (viewSource.Rows.Count == 0) return;
            for (int j = 0; j < viewSource.Rows.Count; j++)
            {
                int success = 0;
                int fail = 0;
                int perTime = 900;  //每次上传的记录数量
                var file = viewSource.Rows[j].Tag.ToString();
                if (j > 0) viewSource.Rows[j - 1].Selected = false;
                SelectFile(j);
                ShowFile(file);
                if (viewDestination.Rows.Count == 0)
                {
                    viewSource.Rows[j].Cells["colState"].Value = "没有要导入的数据";
                    continue;
                }
                if (string.IsNullOrEmpty(cmbID.Text))
                {
                    viewSource.Rows[j].Cells["colState"].Value = "没有找到学号列";
                    continue;
                }
                viewSource.Rows[j].Cells["colState"].Value = "正在导入...";
                FrmProcessing frm = new FrmProcessing();
                Action action = delegate ()
                {
                    try
                    {
                        List<StudentRawScore> temp = new List<StudentRawScore>();
                        for (int i = 0; i < viewDestination.Rows.Count; i++)
                        {
                            if (viewDestination.Rows[i].Visible)
                            {
                                List<StudentRawScore> ss = GetScore(viewDestination.Rows[i]);
                                if (ss != null && ss.Count > 0)
                                {
                                    temp.AddRange(ss);
                                }
                            }
                            if (temp.Count >= perTime || i == viewDestination.Rows.Count - 1)
                            {
                                ImportOption option = ImportOption.Ignore;
                                if (rdOverride.Checked) option = ImportOption.Override;
                                if (rdAppend.Checked) option = ImportOption.Append;
                                var ret = new APIClient(AppSettings.Current.ConnStr).BatchAddScores(temp, option, AppSettings.Current.PhysicalProject.ID);
                                if (ret.Result == ResultCode.Successful)
                                {
                                    success += ret.Value.Successes != null ? ret.Value.Successes.Count : 0;
                                    fail += ret.Value.Errors != null ? ret.Value.Errors.Count : 0;
                                }
                                else
                                {
                                    fail += temp.Count;
                                    LJH.GeneralLibrary.FileLog.Log("学生成绩导入", ret.Message);
                                }
                                temp.Clear();
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
                    break;
                }
                viewSource.Rows[j].Cells["colState"].Value = string.Format("共导入成功{0}条数据,失败{1}条数据", success, fail);
            }
        }

        private List<StudentRawScore> GetScore(DataGridViewRow row)
        {
            List<StudentRawScore> ret = null;
            string studentID = row.Cells["colID"].Value != null ? row.Cells["colID"].Value.ToString().Trim().ToUpper() : null;
            if (string.IsNullOrEmpty(studentID))
            {
                row.Cells["colReason"].Value = "学号为空";
                return ret;
            }
            foreach (DataGridViewColumn col in viewDestination.Columns)
            {
                if (col.Tag != null && col.Tag is PhysicalItem && row.Cells[col.Index].Value != null)
                {
                    PhysicalItem pi = col.Tag as PhysicalItem;
                    string s = row.Cells[col.Index].Value.ToString().Trim();
                    decimal value = 0;
                    SpecialScoreType spt;
                    StudentRawScore score = null;
                    if (string.IsNullOrEmpty(s)) continue;
                    if (pi.TryParse(s, out value))
                    {
                        if ((pi.Min != null && pi.Min.Value > value) || (pi.Max != null && pi.Max < value)) //判断成绩的取值范围
                        {
                            string v = row.Cells["colReason"].Value != null ? row.Cells["colReason"].Value.ToString() : string.Empty;
                            v += string.Format("{0} 成绩不在有效范围内 ", pi.Name);
                            row.Cells["colReason"].Value = v;
                        }
                        else
                        {
                            score = new StudentRawScore() { ID = Guid.NewGuid(), StudentID = studentID, TestID = pi.ID, Score = value, ScoreFrom = ScoreSource.文件导入 };
                        }
                    }
                    else if (Enum.GetNames(typeof(SpecialScoreType)).Contains(s))
                    {
                        Enum.TryParse<SpecialScoreType>(s, out spt);
                        score = new StudentRawScore() { ID = Guid.NewGuid(), StudentID = studentID, TestID = pi.ID, SpecialType = spt, ScoreFrom = ScoreSource.文件导入 };
                    }
                    if (score != null)
                    {
                        if (ret == null) ret = new List<StudentRawScore>();
                        if (!ret.Exists(it => it.StudentID == score.StudentID && it.TestID == score.TestID && it.Score == score.Score)) ret.Add(score); //同科相同的成绩不再导入
                    }
                }
            }
            return ret;
        }
        #endregion
    }
}
