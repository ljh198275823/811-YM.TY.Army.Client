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
        private List<TreeNode> _AllFacilityNodes = new List<TreeNode>();
        #endregion

        #region 私有方法
        private void AddDivisionNodes(List<Division> items, TreeNode parent)
        {
            List<Division> pcs = null;
            if (parent.Tag == null)
            {
                pcs = (from it in items
                       where string.IsNullOrEmpty(it.Parent)
                       orderby it.Name ascending
                       select it).ToList();
            }
            else
            {
                pcs = (from it in items
                       where it.Parent == (parent.Tag as Division).ID
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

        private void AddFacilityNodes(List<Facility> fcs, TreeNode parent)
        {
            Division ct = parent.Tag as Division;
            List<Facility> items = null;
            if (ct == null)
            {
                items = (from it in fcs
                         where string.IsNullOrEmpty(it.DivisionID)
                         orderby it.Name ascending
                         select it).ToList();
            }
            else
            {
                items = (from it in fcs
                         where it.DivisionID == ct.ID
                         orderby it.Name ascending
                         select it).ToList();
            }
            foreach (Facility c in items)
            {
                AddFacilityNode(c, parent);
            }
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
            _AllFacilityNodes.Clear();
            this.ImageList = imageList1;
            this.Nodes.Clear();
            this.Nodes.Add("所有学校");

            List<Division> items = new APIClient(AppSettings.Current.ConnStr).GetList<string, Division>(null, projectID).QueryObjects;
            if (items != null && items.Count > 0)
            {
                AddDivisionNodes(items, this.Nodes[0]);
            }

            List<Facility> fcs = new APIClient(AppSettings.Current.ConnStr).GetList<string, Facility>(null, projectID).QueryObjects;
            if (fcs != null && fcs.Count > 0)
            {
                AddFacilityNodes(fcs, this.Nodes[0]);
                foreach (TreeNode cnode in _AllDivisionNodes)
                {
                    AddFacilityNodes(fcs, cnode);
                }
            }

            this.Nodes[0].Expand();
            //foreach (var node in _AllDivisionNodes)
            //{
            //    var div = node.Tag as Division;
            //    if (string.IsNullOrEmpty(div.Parent)) node.Expand();
            //}
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
        /// 增加学校
        /// </summary>
        /// <param name="pc"></param>
        /// <param name="parent"></param>
        /// <returns></returns>
        public TreeNode AddFacilityNode(Facility pc, TreeNode parent)
        {
            TreeNode node = parent.Nodes.Add(string.Format("{0}", pc.Name));
            node.Tag = pc;
            node.SelectedImageIndex = 1;
            node.ImageIndex = 1;
            _AllFacilityNodes.Add(node);
            return node;
        }
        /// <summary>
        /// 删除某个节点
        /// </summary>
        public void RemoveNode(TreeNode node)
        {
            this.Nodes.Remove(node);
            if (_AllFacilityNodes.Contains(node)) _AllFacilityNodes.Remove(node);
            if (_AllDivisionNodes.Contains(node)) _AllDivisionNodes.Remove(node);
        }

        /// <summary>
        /// 获取所有某个节点下的所有产品类别信息，包括此节点下所有后代产品类别节点的产品类别信息
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public List<Facility> GetFacilitytofNode(TreeNode node)
        {
            List<Facility> items = new List<Facility>();
            if (node.Tag is Facility)
            {
                items.Add(node.Tag as Facility);
            }
            if (node.Nodes.Count > 0)
            {
                foreach (TreeNode child in node.Nodes)
                {
                    items.AddRange(GetFacilitytofNode(child));
                }
            }
            return items;
        }
        /// <summary>
        /// 选择指定区域ID的节点
        /// </summary>
        /// <param name="node"></param>
        /// <param name="parent"></param>
        public void SelectDivisionNode(string deptID)
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
        /// <summary>
        /// 选择指定学校ID的节点
        /// </summary>
        /// <param name="node"></param>
        /// <param name="parent"></param>
        public void SelectFacilityNode(string facilityID)
        {
            foreach (TreeNode node in _AllFacilityNodes)
            {
                Facility pdept = node.Tag as Facility;
                if (pdept.ID == facilityID)
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
            else if (selectionType == 1)
            {
                foreach (var n in _AllFacilityNodes)
                {
                    if (n.Checked) ret += (n.Tag as Facility).ID + ",";
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
                    n.Checked = ids.Contains((n.Tag as Division).ID);
                }
            }
            else if (selectionType == 1)
            {
                foreach (var n in _AllFacilityNodes)
                {
                    n.Checked = ids.Contains((n.Tag as Facility).ID);
                }
            }
        }
        #endregion
    }
}
