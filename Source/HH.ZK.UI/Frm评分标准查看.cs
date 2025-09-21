using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HH.ZK.Model;
using HH.ZK.Model.SearchCondition;
using HH.ZK.WebAPIClient;
using HH.ZK.CommonUI;
using LJH.GeneralLibrary;
using LJH.GeneralLibrary.WinForm;

namespace HH.ZK.UI
{
    public partial class Frm评分标准查看 : Form
    {
        public Frm评分标准查看()
        {
            InitializeComponent();
        }

        #region 私有变量
        private Standard _CurStandard = null;
        #endregion

        #region 私有方法
        private void InitStandardTree()
        {
            this.myTree1.Nodes.Clear();
            TreeNode root = this.myTree1.Nodes.Add("考试科目");
            var 考试科目 = SysParaSettingsClient.GetSetting<PhysicalItemSettings>(AppSettings.Current.ConnStr, AppSettings.Current.PhysicalProject.ID);
            if (考试科目 == null || 考试科目.Items == null || 考试科目.Items.Count == 0) return;
            foreach (PhysicalItem pi in 考试科目.Items)
            {
                TreeNode node = new TreeNode();
                node.Text = string.Format("{0}[{1}]", pi.Name, pi.Unit);
                node.Tag = pi;
                root.Nodes.Add(node);
                if (pi.Gender == 0 || pi.Gender == (int)Gender.Male) node.Nodes.Add("男");
                if (pi.Gender == 0 || pi.Gender == (int)Gender.Female) node.Nodes.Add("女");
            }
            this.myTree1.ExpandAll();
        }

        private void ShowStandards(PhysicalItem pi, Gender sex)
        {
            this.dataGridview1.Rows.Clear();
            dataGridview1.Visible = true;
            var items = new APIClient(AppSettings.Current.ConnStr).GetList<Guid, Standard>(new StandardSearchCondition() { PhysicalItem = pi.ID, Sex = sex }, AppSettings.Current.PhysicalProject.ID).QueryObjects;
            if (items != null && items != null && items.Count >= 1)
            {
                _CurStandard = items[0];
                ShowStandardItems(_CurStandard,pi);
            }
        }

        private void ShowStandardItems(Standard s, PhysicalItem pi)
        {
            dataGridview1.Rows.Clear();
            List<StandardItem> objs = null;
            if (s != null && s.Items != null && s.Items.Count > 0)
            {
                if (s.Items != null && s.Items.Count > 0) objs = (from item in s.Items
                                                                  orderby item.Result descending  //以分数降序排列
                                                                  select item).ToList();
                for (int i = 0; i < objs.Count; i++)
                {
                    int row = dataGridview1.Rows.Add();
                    ShowStandardItemInGridViewRow(dataGridview1.Rows[row], objs[i], pi);
                }
            }
        }

        private void ShowSelectedNode()
        {
            TreeNode node = myTree1.SelectedNode;
            if (node != null && node.Text == "男")
            {
                PhysicalItem pi = node.Parent.Tag as PhysicalItem;
                ShowStandards(pi, Gender.Male);
            }
            else if (node != null && node.Text == "女")
            {
                PhysicalItem pi = node.Parent.Tag as PhysicalItem;
                ShowStandards(pi, Gender.Female);
            }
            else
            {
                dataGridview1.Visible = false;
                _CurStandard = null;
            }
        }
        #endregion

        #region 重写基类方法
        private void ShowStandardItemInGridViewRow(DataGridViewRow row, StandardItem si, PhysicalItem pi)
        {
            row.Cells["colSer"].Value = row.Index + 1;
            row.Cells["colRank"].Value = si.Rank;
            row.Cells["colResult"].Value = si.Result.Trim();
            row.Cells["colScore"].Value = pi.ConvertToStr(si.Score1);
            row.Tag = si;
        }
        #endregion

        #region 事件处理程序
        private void Frm评分标准查看_Load(object sender, EventArgs e)
        {
            InitStandardTree();
        }

        private void myTree1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            ShowSelectedNode();
        }
        #endregion

       
    }
}
