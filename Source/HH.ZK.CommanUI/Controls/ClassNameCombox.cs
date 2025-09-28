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
    public partial class ClassNameCombox : ComboBox
    {
        public ClassNameCombox()
        {
            InitializeComponent();
        }

        public ClassNameCombox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public void Init(string projectID, string facility = null)
        {
            var ss = new APIClient(AppSettings.Current.ConnStr).GetList<long, StudentClass>(new StudentClassSearchCondition() { FacilityID = facility, SortMode = LJH.GeneralLibrary.SortMode.Asc }, projectID).QueryObjects;
            if (ss != null && ss.Count > 0)
            {
                ss.Insert(0, new StudentClass());
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

        public void Clear()
        {
            this.DataSource = null;
        }

        [Browsable(false)]
        [Localizable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public StudentClass SelectedClass
        {
            get
            {
                if (this.SelectedIndex <= 0)
                {
                    return null;
                }
                else
                {
                    return ((StudentClass)this.Items[SelectedIndex]);
                }
            }
            set
            {
                for (int i = 1; i < this.Items.Count; i++)
                {
                    StudentClass info = this.Items[i] as StudentClass;
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
        public long? SelectedClassID
        {
            get
            {
                if (this.SelectedIndex <= 0)
                {
                    return null;
                }
                else
                {
                    StudentClass Facility = (StudentClass)this.Items[SelectedIndex];
                    return Facility.ID;
                }
            }
            set
            {
                for (int i = 1; i < this.Items.Count; i++)
                {
                    StudentClass info = this.Items[i] as StudentClass;
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
