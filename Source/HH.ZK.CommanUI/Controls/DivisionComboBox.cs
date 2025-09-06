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
    public partial class DivisionComboBox : ComboBox
    {
        public DivisionComboBox()
        {
            InitializeComponent();
        }

        public DivisionComboBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public void Init(string projectID)
        {
            var des = new List<Division>();
            var con = new DivisionSearchCondition() { SortMode = LJH.GeneralLibrary.SortMode.Asc };
            List<Division> ds = new APIClient(AppSettings.Current.ConnStr).GetList<string, Division>(con, projectID).QueryObjects;
            if (ds != null && ds.Count > 0)
            {
                AddItems(null, ds, des);
                des.Insert(0, new Division());
            }
            else
            {
                this.Enabled = false;
                return;
            }
            this.Enabled = true;
            this.DataSource = des;
            this.DisplayMember = "Name";
            this.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void AddItems(string parentid, List<Division> source, List<Division> des)
        {
            var items = source.Where(it => (string.IsNullOrEmpty(parentid) && string.IsNullOrEmpty (it.Parent)) || it.Parent == parentid).OrderBy(it => it.Name).ToList();
            if (items == null || items.Count == 0) return;
            foreach (var item in items)
            {
                if (!string.IsNullOrEmpty(item.Parent)) item.Name = "    " + item.Name;
                des.Add(item);
                AddItems(item.ID, source, des);
            }
        }

        [Browsable(false)]
        [Localizable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Division SelectedDivision
        {
            get
            {
                if (this.SelectedIndex <= 0)
                {
                    return null;
                }
                else
                {
                    return ((Division)this.Items[SelectedIndex]);
                }
            }
            set
            {
                for (int i = 1; i < this.Items.Count; i++)
                {
                    Division info = this.Items[i] as Division;
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
        public string SelectedDivisionID
        {
            get
            {
                if (this.SelectedIndex <= 0)
                {
                    return null;
                }
                else
                {
                    var Facility = (Division)this.Items[SelectedIndex];
                    return Facility.ID;
                }
            }
            set
            {
                for (int i = 1; i < this.Items.Count; i++)
                {
                    var info = this.Items[i] as Division;
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
