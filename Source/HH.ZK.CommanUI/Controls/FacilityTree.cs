using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HH.ZK.Model;
using HH.ZK.Model.CRM;
using HH.ZK.WebAPIClient;

namespace HH.ZK.CommonUI.Controls
{
    public partial class FacilityTree : LJH.GeneralLibrary.WinformControl.MyTree
    {
        public FacilityTree()
        {
            InitializeComponent();
        }

        public FacilityTree(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        #region 私有变量
        private List<TreeNode> _AllDivisionNodes = new List<TreeNode>();
        #endregion

        #region 私有方法
        private void AddDivisionNodes(List<Division> items, TreeNode parent)
        {
            List<Division> pcs = null;
            if (parent.Tag == null)
            {
                pcs = (from it in items
                       where it.ParentID == null
                       orderby it.Number ascending, it.Name ascending
                       select it).ToList();
            }
            else
            {
                pcs = (from it in items
                       where it.ParentID == (parent.Tag as Division).ID
                       orderby it.Name ascending
                       select it).ToList();
            }
            if (pcs != null && pcs.Count > 0)
            {
                foreach (Division pc in pcs)
                {
                    TreeNode node = AddDivisionNode(pc, parent);
                    AddDivisionNodes(items, node);
                }
            }
            parent.ImageIndex = 0;
            parent.SelectedImageIndex = 0;
        }

        private void RenderDivisionNode(Division pc, TreeNode node)
        {
            node.Tag = pc;
            node.SelectedImageIndex = 0;
            node.ImageIndex = 0;
        }
        #endregion

        #region 公共方法
        /// <summary>
        /// 初始化
        /// </summary
        public void Init(string projectID)
        {
            _AllDivisionNodes.Clear();
            this.ImageList = imageList1;
            this.Nodes.Clear();
            this.Nodes.Add("所有机构");

            List<Division> items = new APIClient(AppSettings.Current.ConnStr).GetList<Guid, Division>(null, projectID).QueryObjects;
            if (items != null && items.Count > 0)
            {
                AddDivisionNodes(items, this.Nodes[0]);
            }
            this.Nodes[0].Expand();
        }
        /// <summary>
        /// 增加区域
        /// </summary>
        /// <param name="pc"></param>
        /// <param name="parent"></param>
        /// <returns></returns>
        public TreeNode AddDivisionNode(Division pc, TreeNode parent)
        {
            TreeNode node = parent.Nodes.Add(string.Format("{0}", pc.Name));
            RenderDivisionNode(pc, node);
            _AllDivisionNodes.Add(node);
            return node;
        }
        /// <summary>
        /// 删除某个节点
        /// </summary>
        public void RemoveNode(TreeNode node)
        {
            this.Nodes.Remove(node);
            if (_AllDivisionNodes.Contains(node)) _AllDivisionNodes.Remove(node);
        }

        /// <summary>
        /// 选择指定区域ID的节点
        /// </summary>
        /// <param name="node"></param>
        /// <param name="parent"></param>
        public void SelectDivisionNode(Guid deptID)
        {
            foreach (TreeNode node in _AllDivisionNodes)
            {
                Division pdept = node.Tag as Division;
                if (pdept.ID == deptID)
                {
                    this.SelectedNode = node;
                    break;
                }
            }
        }
        public string GetCheckedItems(int selectionType)
        {
            string ret = string.Empty;
            if (this.Nodes[0].Checked) return null;
            if (selectionType == 0)
            {
                foreach (var n in _AllDivisionNodes)
                {
                    if (n.Checked) ret += (n.Tag as Division).ID + ",";
                }
            }
            return ret;
        }

        public void SetCheckedItems(int selectionType, string items)
        {
            if (string.IsNullOrEmpty(items))
            {
                this.Nodes[0].Checked = true;
                return;
            }
            var ids = items.Split(',');
            if (selectionType == 0)
            {
                foreach (var n in _AllDivisionNodes)
                {
                    n.Checked = ids.Contains((n.Tag as Division).ID.ToString());
                }
            }
        }
        #endregion
    }
}
