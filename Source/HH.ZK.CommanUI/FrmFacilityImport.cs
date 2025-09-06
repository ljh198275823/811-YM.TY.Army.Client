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
    public partial class FrmFacilityImport : Form
    {
        public FrmFacilityImport()
        {
            InitializeComponent();
        }

        #region 私有变量
        private DataTable _SourceTable = null;
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

        private void ClearData()
        {
            viewDestination.Rows.Clear();
            viewSource.DataSource = null;
            cmbName.Items.Clear();
            cmbDivision.Items.Clear();
        }

        private bool CheckMapping()
        {
            if (string.IsNullOrEmpty(cmbName.Text))
            {
                MessageBox.Show("学校名称没有映射");
                cmbName.Focus();
                return false;
            }
            return true;
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
        private void FrmSchoolImport_Load(object sender, EventArgs e)
        {
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
                        foreach (DataGridViewColumn col in viewSource.Columns)  //不能再按列排序，防止与目标网络中的数据不对应
                        {
                            col.SortMode = DataGridViewColumnSortMode.NotSortable;
                        }
                        FillColumn(_SourceTable, cmbName);
                        PreFillDes(cmbName, "学校名称");
                        FillColumn(_SourceTable, cmbDivision);
                        PreFillDes(cmbDivision, "所属地区");
                    }
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
            if (cmb != null)
            {
                for (int i = 0; i < _SourceTable.Rows.Count; i++)
                {
                    if (viewDestination.Rows.Count < i + 1) viewDestination.Rows.Add();
                    object value = null;
                    if (!string.IsNullOrEmpty(cmb.Text)) value = _SourceTable.Rows[i][cmb.Text];
                    viewDestination.Rows[i].Cells[cmb.Tag.ToString()].Value = value;
                    viewDestination.Rows[i].Visible = true;
                }
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            if (viewDestination.Rows.Count == 0) return;
            if (!CheckMapping()) return;
            int perTime = 200;  //每次上传的记录数量
            var rows = new Dictionary<string, DataGridViewRow>();
            int success = 0;
            int fail = 0;

            FrmProcessing frm = new FrmProcessing();
            Action action = delegate ()
            {
                try
                {
                    List<Facility> fs = new List<Facility>();
                    for (int i = 0; i < viewDestination.Rows.Count; i++)
                    {
                        if (viewDestination.Rows[i].Visible)
                        {
                            string name = viewDestination.Rows[i].Cells["colName"].Value != null ? viewDestination.Rows[i].Cells["colName"].Value.ToString() : null;
                            string division = viewDestination.Rows[i].Cells["colDivision"].Value != null ? viewDestination.Rows[i].Cells["colDivision"].Value.ToString() : null;
                            if (!string.IsNullOrEmpty(name) && !fs.Exists(item => item.Name == name))
                            {
                                var f = new Facility()
                                {
                                    ID = Guid.NewGuid().ToString(),
                                    Name = LJH.GeneralLibrary.StringHelper.ToDBC(name),
                                    DivisionName = !string.IsNullOrEmpty(division) ? LJH.GeneralLibrary.StringHelper.ToDBC(division) : null
                                };
                                fs.Add(f);
                                rows.Add(f.ID, viewDestination.Rows[i]);
                            }
                        }
                        if (fs.Count == perTime || i == (viewDestination.Rows.Count - 1))
                        {
                            var ret = new APIClient(AppSettings.Current.ConnStr).BatchAdd<string, Facility>(fs, rdIgnore.Checked ? ImportOption.Ignore : ImportOption.Override, AppSettings.Current.PhysicalProject.ID);
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
                                fail += fs.Count;
                                LJH.GeneralLibrary.FileLog.Log("学校导入", ret.Message);
                            }
                            fs.Clear();
                            rows.Clear();
                            frm.ShowProgress(string.Format("导入{0}条数据 成功{1}条 失败{2}条", i + 1, success, fail), (decimal)(i + 1) / viewDestination.Rows.Count);
                        }
                    }
                    frm.ShowProgress(string.Empty, 1);
                }
                catch (ThreadAbortException)
                {
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
        #endregion
    }
}
