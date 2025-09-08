using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HH.ZK.Model;
using HH.ZK.WebAPIClient;
using HH.ZK.CommonUI;
using LJH.GeneralLibrary;
using LJH.GeneralLibrary;

namespace HH.ZK.UI
{
    public partial class Frm评分标准导入 : Form
    {
        public Frm评分标准导入()
        {
            InitializeComponent();
        }

        public PhysicalProject Project { get; set; }

        #region 私有变量
        private DataTable _SourceTable = null;

        private List<Standard> _Standards = new List<Standard>();

        private List<ComboBox> _PhysicalItemCmbs_Male = new List<ComboBox>();
        private List<ComboBox> _PhysicalItemCmbs_Female = new List<ComboBox>();
        #endregion

        #region 私有方法
        private void InitPhysicalComboBoxs()
        {
            _PhysicalItemCmbs_Male.Clear();
            ComboBox preCmb = cmbResult;
            Label preArrow = lblArrow;
            Label preDes = lblDestination;
            int pad = 30;
            var 考试科目 = SysParaSettingsClient.GetSetting<PhysicalItemSettings>(AppSettings.Current.ConnStr, Project.ID);
            if (考试科目 == null || 考试科目.Items == null || 考试科目.Items.Count == 0) return;
            foreach (PhysicalItem pi in 考试科目.Items)
            {
                if (pi.Sex == 0 || pi.Sex == (int)Gender.Male)
                {
                    ComboBox cmb = new ComboBox();
                    cmb.Name = "cmb" + pi.ID.ToString();
                    cmb.Tag = pi;
                    cmb.DropDownStyle = ComboBoxStyle.DropDownList;
                    cmb.Left = preCmb.Left;
                    cmb.Width = preCmb.Width;
                    cmb.Height = preCmb.Height;
                    cmb.Top = preCmb.Top + pad;
                    cmb.SelectedIndexChanged += cmb_SelectedIndexChanged;
                    _PhysicalItemCmbs_Male.Add(cmb);
                    Label lblArrow1 = new Label();
                    lblArrow1.Left = preArrow.Left;
                    lblArrow1.Top = preArrow.Top + pad;
                    lblArrow1.Width = preArrow.Width;
                    lblArrow1.Height = preArrow.Height;
                    lblArrow1.TextAlign = preArrow.TextAlign;
                    lblArrow1.Text = preArrow.Text;
                    Label lblDes = new Label();
                    lblDes.AutoSize = true;
                    lblDes.Left = preDes.Left;
                    lblDes.Top = preDes.Top + pad;
                    lblDes.Height = preDes.Height;
                    lblDes.Text = pi.Name + "_男";
                    lblDes.TextAlign = preDes.TextAlign;
                    pnlMap.Controls.Add(cmb);
                    pnlMap.Controls.Add(lblArrow1);
                    pnlMap.Controls.Add(lblDes);
                    preCmb = cmb;
                    preArrow = lblArrow1;
                    preDes = lblDes;
                }
                if (pi.Sex == 0 || pi.Sex == (int)Gender.Female)
                {
                    ComboBox cmb_F = new ComboBox();
                    cmb_F.Name = "cmb" + pi.ID.ToString();
                    cmb_F.Tag = pi;
                    cmb_F.DropDownStyle = ComboBoxStyle.DropDownList;
                    cmb_F.Left = preCmb.Left;
                    cmb_F.Width = preCmb.Width;
                    cmb_F.Height = preCmb.Height;
                    cmb_F.Top = preCmb.Top + pad;
                    cmb_F.SelectedIndexChanged += cmb_SelectedIndexChanged;
                    _PhysicalItemCmbs_Female.Add(cmb_F);
                    Label lblArrow1_F = new Label();
                    lblArrow1_F.Left = preArrow.Left;
                    lblArrow1_F.Top = preArrow.Top + pad;
                    lblArrow1_F.Width = preArrow.Width;
                    lblArrow1_F.Height = preArrow.Height;
                    lblArrow1_F.TextAlign = preArrow.TextAlign;
                    lblArrow1_F.Text = preArrow.Text;
                    Label lblDes_F = new Label();
                    lblDes_F.AutoSize = true;
                    lblDes_F.Left = preDes.Left;
                    lblDes_F.Top = preDes.Top + pad;
                    lblDes_F.Height = preDes.Height;
                    lblDes_F.Text = pi.Name + "_女";
                    lblDes_F.TextAlign = preDes.TextAlign;
                    pnlMap.Controls.Add(cmb_F);
                    pnlMap.Controls.Add(lblArrow1_F);
                    pnlMap.Controls.Add(lblDes_F);
                    preCmb = cmb_F;
                    preArrow = lblArrow1_F;
                    preDes = lblDes_F;
                }
            }
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

        private void ClearData()
        {
            viewDestination.Rows.Clear();
            viewSource.DataSource = null;
            cmbResult.Items.Clear();
            for (int i = viewDestination.Columns.Count - 1; i >= 0; i--) //删除自动生成的列
            {
                if (viewDestination.Columns[i].Tag is PhysicalItem)
                {
                    viewDestination.Columns.Remove(viewDestination.Columns[i]);
                }
            }
        }

        private bool CheckMapping()
        {
            return true;
        }

        private List<StandardItem> DoSort(List<StandardItem> sis)
        {
            int ret = 0;
            for (int i = 1; i < sis.Count; i++)
            {
                if (sis[i - 1].Score1 > sis[i].Score1 && ret != 1) //降序
                {
                    sis[i - 1].Operator1 = Operators.BigOrEquel;
                    sis[i].Operator1 = Operators.BigOrEquel;
                    sis[i].Operator2 = Operators.Small;
                    sis[i].Score2 = sis[i - 1].Score1;
                    if (string.IsNullOrEmpty(sis[i].Rank)) sis[i].Rank = sis[i - 1].Rank; //等级列将Excel中的合并列分别赋到其余行
                    ret = 2;
                }
                else if (sis[i - 1].Score1 < sis[i].Score1 && ret != 2) //升序
                {
                    sis[i - 1].Operator1 = Operators.SmallOrEquel;
                    sis[i].Operator1 = Operators.SmallOrEquel;
                    sis[i].Operator2 = Operators.Big;
                    sis[i].Score2 = sis[i - 1].Score1;
                    if (string.IsNullOrEmpty(sis[i].Rank)) sis[i].Rank = sis[i - 1].Rank; //等级列将Excel中的合并列分别赋到其余行
                    ret = 1;
                }
                else
                {
                    return null;
                }
            }
            return sis;
        }

        private void ShowStandardItems(Standard s, PhysicalItem pi)
        {
            string colName = string.Format("col_{0}_{1}", s.PhysicalItemID.ToString(), s.Gender == Gender.Male ? 1 : 2);
            if (viewDestination.Columns[colName] == null) AddPhysicalColumn(pi, s.Gender);
            for (int i = 0; i < s.Items.Count; i++)
            {
                if (viewDestination.Rows.Count < (i + 1))
                {
                    viewDestination.Rows.Add();
                }
                DataGridViewRow row = viewDestination.Rows[i];
                row.Cells["colSer"].Value = row.Index + 1;
                row.Cells["colResult"].Value = s.Items[i].Result.Trim();
                row.Cells["colRank"].Value = s.Items[i].Rank;
                row.Cells[colName].Value = pi.ConvertToStr(s.Items[i].Score1);
            }
        }

        private DataGridViewColumn AddPhysicalColumn(PhysicalItem item, Gender sex)
        {
            DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
            col.Name = string.Format("col_{0}_{1}", item.ID.ToString(), sex == Gender.Male ? 1 : 2);
            col.Tag = item;
            col.MinimumWidth = 60;
            col.Width = 80;
            col.ReadOnly = true;
            col.SortMode = DataGridViewColumnSortMode.NotSortable;
            col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            col.HeaderText = string.Format("{0}_{1}", item.Name, sex == Gender.Male ? "男" : "女");
            this.viewDestination.Columns.Insert(this.viewDestination.Columns.Count, col);
            return col;
        }

        private void ClearStandard(Standard s)
        {
            string colName = string.Format("col_{0}_{1}", s.PhysicalItemID.ToString(), s.Gender == Gender.Male ? 1 : 2);
            if (viewDestination.Columns[colName] != null)
            {
                foreach (DataGridViewRow row in viewDestination.Rows)
                {
                    row.Cells[colName].Value = null;
                }
            }
        }

        private Standard CreateStandard(PhysicalItem pi, int grade, Gender sex)
        {
            Standard ret = new Standard();
            ret.ID = Guid.NewGuid();
            ret.Name = pi.Name + "评分标准";
            ret.PhysicalItemID = pi.ID;
            ret.Gender = sex;
            ret.Grade = grade;
            return ret;
        }
        #endregion

        #region 事件处理程序
        private void FrmStandardImport_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn col in viewDestination.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            InitPhysicalComboBoxs();
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
                        FillColumn(_SourceTable, cmbResult);
                        FillColumn(_SourceTable, cmbRank);
                        foreach (ComboBox cmb in _PhysicalItemCmbs_Male)
                        {
                            FillColumn(_SourceTable, cmb);
                        }
                        foreach (ComboBox cmb in _PhysicalItemCmbs_Female)
                        {
                            FillColumn(_SourceTable, cmb);
                        }
                        PreFillDes(cmbResult, "得分");
                        PreFillDes(cmbResult, "分值");
                        PreFillDes(cmbRank, "等级");
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
            //每先一个评分标准项,都重新生成所有标准,这样有一个好处就是每次都有一致的状态
            viewDestination.Rows.Clear();
            _Standards.Clear();
            if (string.IsNullOrEmpty(cmbResult.Text)) return;
            CreateStandards(_PhysicalItemCmbs_Male, Gender.Male);
            CreateStandards(_PhysicalItemCmbs_Female, Gender.Female);
        }

        private void CreateStandards(List<ComboBox> cmbs, Gender sex)
        {
            foreach (ComboBox cmb in cmbs)
            {
                if (!string.IsNullOrEmpty(cmb.Text))
                {
                    PhysicalItem pi = cmb.Tag as PhysicalItem;
                    Standard standard = CreateStandard(pi, GradeHelper.无, sex);
                    standard.ProjectID = Project.ID;
                    List<StandardItem> sis = new List<StandardItem>();
                    for (int i = 0; i < _SourceTable.Rows.Count; i++)
                    {
                        string strRank = string.IsNullOrEmpty(cmbRank.Text) ? null : viewSource.Rows[i].Cells[cmbRank.Text].Value != null ? viewSource.Rows[i].Cells[cmbRank.Text].Value.ToString().Trim() : null;
                        string strResult = viewSource.Rows[i].Cells[cmbResult.Text].Value != null ? viewSource.Rows[i].Cells[cmbResult.Text].Value.ToString().Trim() : null;
                        string strScore = viewSource.Rows[i].Cells[cmb.Text].Value != null ? viewSource.Rows[i].Cells[cmb.Text].Value.ToString().Trim() : null;
                        decimal result = 0;
                        decimal score = 0;
                        if (decimal.TryParse(strResult, out result) && pi.TryParse(strScore, out score))
                        {
                            StandardItem si = new StandardItem();
                            si.ID = Guid.NewGuid();
                            si.StandardID = standard.ID;
                            si.Score1 = pi.Convert(score);
                            si.Result = result;
                            si.Rank = strRank;
                            sis.Add(si);
                        }
                    }
                    sis = DoSort(sis);
                    if (sis == null)
                    {
                        MessageBox.Show("源数据中的评分标准数据不能导入，请确保数据的格式为升序或降序排列", "出错", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        continue;
                    }
                    standard.Items = sis;
                    if (!_Standards.Contains(standard)) _Standards.Add(standard);
                    ShowStandardItems(standard, pi);
                }
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            if (_Standards != null && _Standards.Count > 0)
            {
                int success = 0;
                foreach (var std in _Standards)
                {
                    var ret = new APIClient(AppSettings.Current.ConnStr).Add<Guid, Standard>(std, null);
                    if (ret.Result == ResultCode.Successful) success++;
                }
                MessageBox.Show(string.Format("成功导入 {0} 个评分标准", success), "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
    }
}
