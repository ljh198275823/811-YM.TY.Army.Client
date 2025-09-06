using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HH.ZK.Model;

namespace HH.ZK.CommonUI.Controls
{
    public partial class ResolveTypeComboBox : ComboBox
    {
        public ResolveTypeComboBox()
        {
            InitializeComponent();
        }

        public ResolveTypeComboBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        #region 私有变量
        #endregion

        #region 私有方法

        #endregion

        public void Init()
        {
            this.Items.Clear();
            for (int i = 0; i < 50; i++)
            {
                if (Enum.IsDefined(typeof(ResolveType), i)) this.Items.Add(((ResolveType)i).ToString());
            }
        }

        [Browsable(false)]
        [Localizable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public ResolveType SelectedResolveType
        {
            get
            {
                if (SelectedIndex > 0)
                {
                    var ret = (ResolveType)Enum.Parse(typeof(ResolveType), this.Text);
                    return ret;
                }
                return ResolveType.当前成绩有效;
            }
            set
            {
                for (int i = 0; i < this.Items.Count; i++)
                {
                    if (this.Items[i].ToString() == value.ToString())
                    {
                        this.SelectedIndex = i;
                        break;
                    }
                }
            }
        }
    }
}
