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
    public partial class Frm学生信息导入_仙桃 : Form
    {
        public Frm学生信息导入_仙桃()
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
            cmbName.Items.Clear();
            cmbSex.Items.Clear();
            cmb考试科目.Items.Clear();
            cmbFacility.Items.Clear();
        }

        private bool CheckMapping()
        {
            if (string.IsNullOrEmpty(cmbID.Text))
            {
                MessageBox.Show("准考证号没有映射");
                cmbID.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(cmbName.Text))
            {
                MessageBox.Show("姓名没有映射");
                cmbName.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(cmbSex.Text))
            {
                MessageBox.Show("性别没有映射");
                cmbSex.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(cmbFacility.Text) && string.IsNullOrEmpty(cmbExistsFacility.Text))
            {
                MessageBox.Show("学校没有映射");
                cmbFacility.Focus();
                return false;
            }
            return true;
        }

        private Student GetStudentFromRow(DataGridViewRow row)
        {
            string msg = null;
            string id = row.Cells["colID"].Value != null ? row.Cells["colID"].Value.ToString().Trim() : null;
            if (!string.IsNullOrEmpty(id)) id = Regex.Replace(id, "[^0-9A-Z]", string.Empty);
            if (string.IsNullOrEmpty(id))
            {
                row.Cells["colReason"].Value = "没有提供学号";
                return null;
            }
            if (!string.IsNullOrEmpty(id) && id.Length > 20)
            {
                row.Cells["colReason"].Value = "学号长度超过20位";
                return null;
            }
            string name = row.Cells["colName"].Value != null ? row.Cells["colName"].Value.ToString().Trim() : null;
            if (string.IsNullOrEmpty(name))
            {
                row.Cells["colReason"].Value = "没有提供学生姓名";
                return null;
            }
            string sex = row.Cells["colSex"].Value != null ? row.Cells["colSex"].Value.ToString().Trim() : null;
            if (string.IsNullOrEmpty(sex))
            {
                row.Cells["colReason"].Value = "没有提供学生性别";
                return null;
            }
            if (sex != "男" && sex != "女" && sex != "1" && sex != "2")
            {
                row.Cells["colReason"].Value = "性别值不在范围内";
                return null;
            }
            string facility = row.Cells["colFacility"].Value != null ? row.Cells["colFacility"].Value.ToString().Trim() : null;
            string className = row.Cells["colClassName"].Value != null ? row.Cells["colClassName"].Value.ToString().Trim() : null;
            string idNumber = row.Cells["colIDNumber"].Value != null ? row.Cells["colIDNumber"].Value.ToString().Trim() : null;
            var 特殊情况 = row.Cells["col特殊情况"].Value != null ? row.Cells["col特殊情况"].Value.ToString().Trim() : null;
            var 平时成绩 = row.Cells["col平时成绩"].Value != null ? row.Cells["col平时成绩"].Value.ToString().Trim() : null;
            Student s = ConvertToStudent(id, name, sex, facility, className, idNumber, 特殊情况, out msg);
            if (s == null)
            {
                row.Cells["colReason"].Value = msg;
                return null;
            }
            var sucess= Get考试科目(s,row);
            if (!sucess) return null;
            s.SchoolCode = row.Cells["col学校代码"].Value != null ? row.Cells["col学校代码"].Value.ToString().Trim() : null;
            decimal pscj = 0;
            if (decimal.TryParse(平时成绩, out pscj)) s.JiaFen = pscj;
            return s;
        }

        private bool Get考试科目(Student s, DataGridViewRow row)
        {
            var names = row.Cells["col考试科目"].Value != null ? row.Cells["col考试科目"].Value.ToString().Trim() : null;
            if (string.IsNullOrEmpty(names)) return true;
            if (AppSettings.Current.PhysicalProject.PhysicalItems == null) return true;
            if (names == "1.长跑、50米、篮球") names = s.Sex == Sex.Male ? "1000米,50米,篮球" : "800米,50米,篮球";
            else if (names == "2.长跑、50米、足球") names = s.Sex == Sex.Male ? "1000米,50米,足球" : "800米,50米,足球";
            else if (names == "3.长跑、50米、排球") names = s.Sex == Sex.Male ? "1000米,50米,排球" : "800米,50米,排球";
            else if (names == "4.长跑、立定跳远、篮球") names = s.Sex == Sex.Male ? "1000米,立定跳远,篮球" : "800米,立定跳远,篮球";
            else if (names == "5.长跑、立定跳远、足球") names = s.Sex == Sex.Male ? "1000米,立定跳远,足球" : "800米,立定跳远,足球";
            else if (names == "6.长跑、立定跳远、排球") names = s.Sex == Sex.Male ? "1000米,立定跳远,排球" : "800米,立定跳远,排球";
            else if (names == "7.长跑、跳绳、篮球") names = s.Sex == Sex.Male ? "1000米,跳绳,篮球" : "800米,跳绳,篮球";
            else if (names == "8.长跑、跳绳、足球") names = s.Sex == Sex.Male ? "1000米,跳绳,足球" : "800米,跳绳,足球";
            else if (names == "9.长跑、跳绳、排球") names = s.Sex == Sex.Male ? "1000米,跳绳,排球" : "800米,跳绳,排球";
            List<string> physicals = new List<string>();
            string[] strPhysicals = names.Split(',', '，');
            foreach (var str in strPhysicals)
            {
                if (string.IsNullOrEmpty(str) || string.IsNullOrEmpty(str.Trim())) continue;
                var pi = AppSettings.Current.PhysicalProject.PhysicalItems.GetPhysicalItem(str.Trim());
                if (pi != null)
                {
                    if (pi.Sex == 0 || pi.Sex == (int)s.Sex)
                    {
                        physicals.Add(pi.ID.ToString());
                    }
                    else
                    {
                        var sex = s.Sex == Sex.Male ? "男" : "女";
                        row.Cells["colReason"].Value = $"考试科目 {str} 不能应用在 {sex}生";
                        return false;
                    }
                }
                else
                {
                    row.Cells["colReason"].Value = $"不能识别 {str}";
                    return false;
                }
            }
            foreach (var pi in AppSettings.Current.PhysicalProject.PhysicalItems.Items)
            {
                if (pi.IsMust && (pi.Sex == 0 || pi.Sex == (int)s.Sex) && (s.State == StudentState.正常考试 || s.State == StudentState.缓考)) //如果是必考项，正常考试或缓考的学生就自动加上必考项
                {
                    if (!physicals.Contains(pi.ID.ToString())) physicals.Add(pi.ID.ToString());
                }
            }
            if (physicals.Count > 0) s.PhysicalItems = string.Join(",", physicals);
            return true;
        }

        private Student ConvertToStudent(string id, string name, string sex, string school, string className, string idNumber,string 特殊情况, out string msg)
        {
            msg = string.Empty;
            Sex s = (sex == "男" || sex == "1") ? Sex.Male : Sex.Female; //性别 男生可以用"男"和"1"表示 其它表示女生
            Student info = new Student();
            info.ID = id;
            info.Name = name;
            info.Sex = s;
            info.FacilityID = school;
            info.Grade = GradeHelper.初三;
            info.ClassName = className;
            info.IDNumber = idNumber;
            if (!string.IsNullOrEmpty(特殊情况))
            {
                if (特殊情况.Contains("尖子")) info.State = StudentState.尖子生免考;
                else if (特殊情况.Contains("残疾") || 特殊情况.Contains("CJ")) info.State = StudentState.残疾免考;
                else if (特殊情况.Contains("疾病") || 特殊情况.Contains("病疾")) info.State = StudentState.疾病免考;
                else if (特殊情况.Contains("择考")) info.State = StudentState.择考;
                else if (特殊情况.Contains("回往生") || 特殊情况.Contains("HK")) info.State = StudentState.回往生;
                else if (特殊情况.Contains("缓考")) info.State = StudentState.缓考;
                else if (特殊情况.Contains("免试") || 特殊情况.Contains("MS")) info.State = StudentState.免试;
                else if (特殊情况.Contains("免修") || 特殊情况.Contains("MX")) info.State = StudentState.免修;
            }
            return info;
        }
        #endregion

        #region 事件处理程序
        private void FrmStudentImport_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn col in viewDestination.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            cmbExistsFacility.Init(AppSettings.Current.PhysicalProject.ID);
            cmbFacility.Enabled = string.IsNullOrEmpty(AppSettings.Current.Operator.SelectionItems); //如果只是显示有限的学校信息，不能对应学校
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
                        foreach (DataGridViewColumn col in viewSource.Columns)  //不能再按列排序，防止与目标网络中的数据不对应
                        {
                            col.SortMode = DataGridViewColumnSortMode.NotSortable;
                        }
                        FillColumn(_SourceTable, cmbID);
                        PreFillDes(cmbID, "学号");
                        PreFillDes(cmbID, "学籍号");
                        PreFillDes(cmbID, "准考证号");
                        PreFillDes(cmbID, "报名号");
                        FillColumn(_SourceTable, cmbName);
                        PreFillDes(cmbName, "姓名");
                        FillColumn(_SourceTable, cmbSex);
                        PreFillDes(cmbSex, "性别");
                        PreFillDes(cmbSex, "性别代码");
                        FillColumn(_SourceTable, cmb考试科目);
                        PreFillDes(cmb考试科目, "考试科目");
                        PreFillDes(cmb考试科目, "体育测试项目");
                        FillColumn(_SourceTable, cmbFacility);
                        PreFillDes(cmbFacility, "学校");
                        FillColumn(_SourceTable, cmbClassName);
                        PreFillDes(cmbClassName, "班级名称");
                        PreFillDes(cmbClassName, "班级");
                        PreFillDes(cmbClassName, "班级代码");
                        FillColumn(_SourceTable, cmbIDNumber);
                        PreFillDes(cmbIDNumber, "身份证号");
                        FillColumn(_SourceTable, cmb特殊情况);
                        PreFillDes(cmb特殊情况, "特殊情况");
                        FillColumn(_SourceTable, cmb平时成绩);
                        PreFillDes(cmb平时成绩, "平时成绩");
                        FillColumn(_SourceTable, txt学校代码);
                        PreFillDes(txt学校代码, "学校代码");
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

        private void cmbExistsFacility_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cmbExistsFacility.Text) && _SourceTable != null)
            {
                for (int i = 0; i < _SourceTable.Rows.Count; i++)
                {
                    if (viewDestination.Rows.Count < i + 1) viewDestination.Rows.Add();
                    viewDestination.Rows[i].Cells[cmbExistsFacility.Tag.ToString()].Value = cmbExistsFacility.SelectedFacility.Name;
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
            int perTime = 200;  //每次上传的记录数量
            var rows = new Dictionary<string, DataGridViewRow>();
            FrmProcessing frm = new FrmProcessing();
            Action action = delegate ()
            {
                try
                {
                    List<Student> students = new List<Student>();
                    for (int i = 0; i < viewDestination.Rows.Count; i++)
                    {
                        try
                        {
                            if (viewDestination.Rows[i].Visible)
                            {
                                Student s = GetStudentFromRow(viewDestination.Rows[i]);
                                if (s != null && !students.Exists(item => item.ID == s.ID))
                                {
                                    students.Add(s);
                                    rows.Add(s.ID, viewDestination.Rows[i]);
                                }
                            }
                            if (students.Count == perTime || i == (viewDestination.Rows.Count - 1))
                            {
                                var ret = new APIClient(AppSettings.Current.ConnStr).BatchAdd<string, Student>(students, rdIgnore.Checked ? ImportOption.Ignore : ImportOption.Override, AppSettings.Current.PhysicalProject.ID);
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
                                    fail += students.Count;
                                    LJH.GeneralLibrary.FileLog.Log("学生导入", ret.Message);
                                }
                                students.Clear();
                                rows.Clear();
                                frm.ShowProgress(string.Format("导入{0}条数据 成功{1}条 失败{2}条", i + 1, success, fail), (decimal)(i + 1) / viewDestination.Rows.Count);
                            }
                        }
                        catch (Exception ex)
                        {
                            LJH.GeneralLibrary.ExceptionPolicy.HandleException(ex);
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
            lblDesCount.Text = string.Format("{0}条数据", viewDestination.Rows.Count - success); //显示剩余的记录条数,所有导入成绩的列都会删除或隐藏
            MessageBox.Show(string.Format("共导入成功{0}条数据", success), "结果");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "Excel文档|*.xls|所有文件(*.*)|*.*";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string path = saveFileDialog1.FileName;
                    LJH.GeneralLibrary.WinForm.NPOIExcelHelper.Export(this.viewDestination, path, true);
                    MessageBox.Show("导出成功");
                }
            }
            catch
            {
                MessageBox.Show("保存到电子表格时出现错误!");
            }
        }
        #endregion
    }
}
