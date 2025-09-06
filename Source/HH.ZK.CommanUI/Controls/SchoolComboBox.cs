using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HH.ZK.Model;
using HH.ZK.Model.CRM;
using HH.ZK.Model.SearchCondition;
using HH.ZK.WebAPIClient;

namespace HH.ZK.CommonUI.Controls
{
    public partial class SchoolComboBox : ComboBox
    {
        public SchoolComboBox()
        {
            InitializeComponent();
        }

        public SchoolComboBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public void Init()
        {
            var items = CRMAPIClient.GetList<string, School>(null).QueryObjects;
            if (items != null)
            {
                items = (from s in items
                         orderby s.Name ascending
                         select s).ToList();
            }
            this.DataSource = items;
            this.DisplayMember = "Name";
            this.DropDownStyle = ComboBoxStyle.DropDownList;
            this.SelectedIndex = -1;
        }

        [Browsable(false)]
        [Localizable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public School SelectedSchool
        {
            get
            {
                if (this.SelectedIndex < 0)
                {
                    return null;
                }
                else
                {
                    return this.Items[SelectedIndex] as School;
                }
            }
            set
            {
                if (value == null)
                {
                    this.SelectedIndex = -1;
                }
                else
                {
                    for (int i = 0; i < this.Items.Count; i++)
                    {
                        var info = this.Items[i] as School;
                        if (info.ID == value.ID)
                        {
                            this.SelectedIndex = i;
                            break;
                        }
                    }
                }
            }
        }
    }
}
