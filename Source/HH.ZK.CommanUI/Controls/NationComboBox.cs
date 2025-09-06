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
    public partial class NationComboBox : ComboBox
    {
        public NationComboBox()
        {
            InitializeComponent();
        }

        public NationComboBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        #region 公共方法
        public void Init()
        {
            this.Items.Clear();
            this.Items.Add(string.Empty);
            NationHelper nh = new NationHelper();
            foreach (var item in nh)
            {
                this.Items.Add(item.Value);
            }
            this.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        #endregion

        #region 公共属性
        [Browsable(false)]
        [Localizable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int SelectedNation
        {
            get
            {
                NationHelper nh = new NationHelper();
                if (!string.IsNullOrEmpty(this.Text) && nh.ContainsValue(this.Text))
                {
                    KeyValuePair<int, string> item = nh.Single(it => it.Value == this.Text);
                    return item.Key;
                }
                return 0;
            }
            set
            {
                NationHelper nh = new NationHelper();
                if (nh.ContainsKey(value)) this.Text = nh[value];
            }
        }
        #endregion
    }
}
