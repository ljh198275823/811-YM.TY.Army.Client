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
    public partial class TotalCalTypeComboBox : ComboBox
    {
        public TotalCalTypeComboBox()
        {
            InitializeComponent();
        }

        public TotalCalTypeComboBox(IContainer container)
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
            for (int i = 0; i <= 100; i++)
            {
                if (Enum.IsDefined(typeof(TotalCalType), i)) this.Items.Add(((TotalCalType)i).ToString());
            }
        }

        [Browsable(false)]
        [Localizable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public TotalCalType SelectedTotalCalType
        {
            get
            {
                if (SelectedIndex > 0)
                {
                    var ret = (TotalCalType)Enum.Parse(typeof(TotalCalType), this.Text);
                    return ret;
                }
                return TotalCalType.各科合计;
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
