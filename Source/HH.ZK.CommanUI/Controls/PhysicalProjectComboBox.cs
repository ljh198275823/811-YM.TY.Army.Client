using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HH.ZK.Model;
using HH.ZK.Model.SearchCondition;
using HH.ZK.WebAPIClient;

namespace HH.ZK.CommonUI.Controls
{
    public partial class PhysicalProjectComboBox : ComboBox
    {
        public PhysicalProjectComboBox()
        {
            InitializeComponent();
        }

        public PhysicalProjectComboBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public void Init()
        {
            var ret = new APIClient(AppSettings.Current.ConnStr).GetList<string, Project>(null, null);
            var items =ret.QueryObjects;
            if (items != null && items.Count > 0)
            {
                items = (from item in items
                         orderby item.Name ascending
                         select item).ToList();
            }
            this.DataSource = items;
            this.DisplayMember = "Name";
            this.DropDownStyle = ComboBoxStyle.DropDownList;
            this.SelectedIndex = -1;
        }

        [Browsable(false)]
        [Localizable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Project SelectedProject
        {
            get
            {
                if (this.SelectedIndex < 0)
                {
                    return null;
                }
                else
                {
                    return ((Project)this.Items[SelectedIndex]);
                }
            }
            set
            {
                for (int i = 0; i < this.Items.Count; i++)
                {
                    var info = this.Items[i] as Project;
                    if (info.ID == value.ID)
                    {
                        this.SelectedIndex = i;
                        break;
                    }
                }
            }
        }

        [Browsable(false)]
        [Localizable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string SelectedProjectID
        {
            get
            {
                if (this.SelectedIndex < 0)
                {
                    return string.Empty;
                }
                else
                {
                    var Facility = (Project)this.Items[SelectedIndex];
                    return Facility.ID;
                }
            }
            set
            {
                for (int i = 0; i < this.Items.Count; i++)
                {
                    var info = this.Items[i] as Project;
                    if (info.ID == value)
                    {
                        this.SelectedIndex = i;
                        break;
                    }
                }
            }
        }
    }
}
