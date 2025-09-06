using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HH.ZK.Model;
using HH.ZK.CommonUI;
using HH.ZK.Model.SearchCondition;

namespace HH.ZK.CommonUI.Controls
{
    public partial class PhysicalItemComboBox : ComboBox
    {
        public PhysicalItemComboBox()
        {
            InitializeComponent();
        }

        public PhysicalItemComboBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        #region 公共方法
        public void Init(PhysicalProject project)
        {
            List<PhysicalItem> items = new List<PhysicalItem>();
            items.Add(new PhysicalItem { ID = 0, Name = string.Empty });
            if (project != null)
            {
                var pis = project.PhysicalItems.Items;
                if (pis != null)
                {
                    foreach (var pi in pis)
                    {
                        items.Add(pi);
                    }
                }
            }
            this.DataSource = items;
            this.DisplayMember = "Name";
            this.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        #endregion

        #region 公共属性
        [Browsable(false)]
        [Localizable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int SelectedPhysicalItem
        {
            get
            {
                if (this.SelectedIndex < 0)
                {
                    return 0;
                }
                else
                {
                    return (this.Items[SelectedIndex] as PhysicalItem).ID;
                }
            }
            set
            {
                for (int i = 0; i < this.Items.Count; i++)
                {
                    var info = this.Items[i] as PhysicalItem;
                    if (info.ID == value)
                    {
                        this.SelectedIndex = i;
                        break;
                    }
                }
            }
        }
        #endregion
    }
}
