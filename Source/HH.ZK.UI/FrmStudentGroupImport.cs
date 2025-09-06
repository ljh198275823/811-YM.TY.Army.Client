using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using HH.ZK.Model;
using HH.ZK.CommonUI;
using LJH.GeneralLibrary;

namespace HH.ZK.UI
{
    public partial class FrmStudentGroupImport : Form
    {
        public FrmStudentGroupImport()
        {
            InitializeComponent();
        }

        #region 私有变量
        private DataTable _SourceTable = null;
        private List<StudentGroup> _StudentGroups = null;
        private Dictionary<string, Student> _AllStudents = new Dictionary<string, Student>();
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

        private void ClearData()
        {
            viewDestination.Rows.Clear();
            lblSource.Text = "条数据";
            viewSource.DataSource = null;
            lblSource.Text = "条数据";
            cmbID.Items.Clear();
            cmbGroupID.Items.Clear();
            cmbPhysical.Items.Clear();
            cmbChanel.Items.Clear();
        }

        private bool CheckMapping()
        {
            if (string.IsNullOrEmpty(cmbID.Text))
            {
                MessageBox.Show("准考证号没有映射");
                cmbID.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(cmbGroupID.Text))
            {
                MessageBox.Show("组别没有映射");
                cmbGroupID.Focus();
                return false;
            }
            return true;
        }

        private void GetAllStudents()
        {
            _AllStudents.Clear();
            var ss = new HH.ZK.WebAPIClient.APIClient(AppSettings.Current.ConnStr).GetList<string, Student>(null, AppSettings.Current.PhysicalProject.ID).QueryObjects;
            if (ss != null && ss.Count > 0)
            {
                foreach (var s in ss)
                {
                    _AllStudents.Add(s.ID, s);
                }
            }
        }

        private void GetStudentGroupFromRow(DataGridViewRow row, bool 不分学校)
        {
            bool success = false;
            string msg = null;
            string sid = row.Cells["colID"].Value != null ? StringHelper.ToDBC(row.Cells["colID"].Value.ToString()).Trim().ToUpper() : null;
            if (string.IsNullOrEmpty(sid))
            {
                row.Cells["colReason"].Value = "没有提供准考证号";
                return;
            }
            var s = _AllStudents.ContainsKey(sid) ? _AllStudents[sid] : null;
            if (s == null)
            {
                row.Cells["colReason"].Value = "不存在此准考证号学生";
                return;
            }
            string pis = row.Cells["colPhysicalItem"].Value != null ? row.Cells["colPhysicalItem"].Value.ToString().Trim() : null;
            var physicalItems = 获取考试科目(pis, out success, out msg);
            if (!success)
            {
                row.Cells["colReason"].Value = msg;
                return;
            }
            int number = 0;
            string groupID = row.Cells["colGroupID"].Value != null ? row.Cells["colGroupID"].Value.ToString().Trim() : null;
            if (string.IsNullOrEmpty(groupID))
            {
                row.Cells["colReason"].Value = "没有指定组号";
                return;
            }
            else
            {
                groupID = Regex.Replace(groupID, @"[^\d]*", "");
                if (string.IsNullOrEmpty(groupID) || !int.TryParse(groupID, out number) || number <= 0)
                {
                    row.Cells["colReason"].Value = "组号不是大于零的整数";
                    return;
                }
            }
            string strSex = row.Cells["colSex"].Value != null ? row.Cells["colSex"].Value.ToString().Trim() : null;
            Sex? sex = null;
            if (!string.IsNullOrEmpty(strSex) && strSex.Contains("男")) sex = Sex.Male;
            else if (!string.IsNullOrEmpty(strSex) && strSex.Contains("女")) sex = Sex.Female;
            string kssj = row.Cells["col考试时间"].Value != null ? row.Cells["col考试时间"].Value.ToString().Trim() : null;
            int channel = 0;
            string c = row.Cells["colChannel"].Value != null ? row.Cells["colChannel"].Value.ToString().Trim() : null;
            if (!string.IsNullOrEmpty(c) && !int.TryParse(c, out channel))
            {
                row.Cells["colReason"].Value = "道次不是整数";
                return;
            }
            var fid = 不分学校 ? null : s.FacilityID;
            var fname= 不分学校 ? null : s.FacilityName;
            var sg = _StudentGroups.SingleOrDefault(it => it.Sex == sex && it.Number == number && it.PhysicalItems == physicalItems && it.PlanDate == kssj && it.FacilityID == fid);
            if (sg == null)
            {
                sg = new StudentGroup()
                {
                    ID = Guid.NewGuid(),
                    Sex = sex,
                    Number = number,
                    PhysicalItems = physicalItems,
                    FacilityID = fid,
                    FacilityName = fname,
                    PlanDate = kssj,
                    Items = new List<StudentGroupPair>()
                };
                _StudentGroups.Add(sg);
            }
            if (!sg.Items.Exists(it => it.StudentID == s.ID))
            {
                sg.Add(new StudentGroupPair()
                {
                    ID = Guid.NewGuid(),
                    GroupID = sg.ID,
                    StudentID = sid,
                    Channel = channel
                });
            }
        }

        private string 获取考试科目(string pNames, out bool success, out string msg)
        {
            success = false;
            msg = string.Empty; ;
            if (string.IsNullOrEmpty(pNames))
            {
                success = true;
                return null;
            }
            List<string> physicals = new List<string>();
            string[] strPhysicals = pNames.Split(',', '，');
            foreach (var str in strPhysicals)
            {
                if (string.IsNullOrEmpty(str.Trim())) continue;
                var pi = AppSettings.Current.PhysicalProject.PhysicalItems.GetPhysicalItem(str.Trim());
                if (pi == null)
                {
                    msg = string.Format("系统没有 \"{0}\" 考试科目", str.Trim());
                    success = false;
                    return null;
                }
                physicals.Add(pi.ID.ToString());
            }
            success = true;
            return string.Join(",", physicals);
        }
        #endregion

        #region 事件处理程序
        private void FrmStudentImport_Load(object sender, EventArgs e)
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
                        FillColumn(_SourceTable, cmbID);
                        PreFillDes(cmbID, "学号");
                        PreFillDes(cmbID, "学籍号");
                        PreFillDes(cmbID, "准考证号");
                        FillColumn(_SourceTable, cmb性别);
                        PreFillDes(cmb性别, "性别");
                        FillColumn(_SourceTable, cmbPhysical);
                        PreFillDes(cmbPhysical, "考试科目");
                        FillColumn(_SourceTable, cmbGroupID);
                        PreFillDes(cmbGroupID, "组别");
                        PreFillDes(cmbGroupID, "分组");
                        FillColumn(_SourceTable, cmb考试时间);
                        PreFillDes(cmb考试时间, "考试时间");
                        PreFillDes(cmb考试时间, "考试日期");
                        FillColumn(_SourceTable, cmbChanel);
                        PreFillDes(cmbChanel, "道次");
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
            if (cmb != null)
            {
                for (int i = 0; i < _SourceTable.Rows.Count; i++)
                {
                    if (viewDestination.Rows.Count < i + 1) viewDestination.Rows.Add();
                    object value = null;
                    if (!string.IsNullOrEmpty(cmb.Text)) value = _SourceTable.Rows[i][cmb.Text];
                    viewDestination.Rows[i].Cells[cmb.Tag.ToString()].Value = value;
                    if (!viewDestination.Rows[i].Visible) viewDestination.Rows[i].Visible = true;
                }
                lblDesCount.Text = string.Format("{0}条数据", viewDestination.Rows.Count);
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            if (viewDestination.Rows.Count == 0) return;
            if (!CheckMapping()) return;
            _StudentGroups = new List<StudentGroup>();
            GetAllStudents();
            List<DataGridViewRow> rows = new List<DataGridViewRow>();
            try
            {
                for (int i = 0; i < viewDestination.Rows.Count; i++)
                {
                    GetStudentGroupFromRow(viewDestination.Rows[i], chk不按学校分组.Checked);
                }
                if (_StudentGroups.Count > 0)
                {
                    FrmAutoStudentGroupPreview frm = new FrmAutoStudentGroupPreview();
                    frm.StartPosition = FormStartPosition.CenterParent;
                    frm.StudentGroups = _StudentGroups;
                    frm.Students = _AllStudents;
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                LJH.GeneralLibrary.ExceptionPolicy.HandleException(ex);
            }
        }
        #endregion
    }
}
