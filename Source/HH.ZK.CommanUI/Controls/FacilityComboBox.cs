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
    public partial class FacilityComboBox : ComboBox
    {
        public FacilityComboBox()
        {
            InitializeComponent();
        }

        public FacilityComboBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        #region 私有变量
        #endregion

        public void Init(long? divisionID = null)
        {
            var con = new FacilitySearchCondition() { SortMode = LJH.GeneralLibrary.SortMode.Asc };
            if (divisionID.HasValue ) con.DivisionID = divisionID;
            var ss = new APIClient(AppSettings.Current.ConnStr).GetList<string, Facility>(con).QueryObjects;
            if (ss != null && ss.Count >0)
            {
                ss.Insert(0, new Facility());
            }
            else
            {
                this.Enabled = false;
                return;
            }
            this.Enabled = true;
            this.DataSource = ss;
            this.DisplayMember = "Name";
            this.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        [Browsable(false)]
        [Localizable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Facility SelectedFacility
        {
            get
            {
                if (this.SelectedIndex <= 0)
                {
                    return null;
                }
                else
                {
                    return ((Facility)this.Items[SelectedIndex]);
                }
            }
            set
            {
                for (int i = 1; i < this.Items.Count; i++)
                {
                    Facility info = this.Items[i] as Facility;
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
        public string SelectedFacilityID
        {
            get
            {
                if (this.SelectedIndex <= 0)
                {
                    return null;
                }
                else
                {
                    Facility Facility = (Facility)this.Items[SelectedIndex];
                    return Facility.ID;
                }
            }
            set
            {
                for (int i = 1; i < this.Items.Count; i++)
                {
                    Facility info = this.Items[i] as Facility;
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
