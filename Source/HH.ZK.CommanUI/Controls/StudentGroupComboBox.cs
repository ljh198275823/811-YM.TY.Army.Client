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
    public partial class StudentGroupComboBox : ComboBox
    {
        public StudentGroupComboBox()
        {
            InitializeComponent();
        }

        public StudentGroupComboBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        #region 公共方法
        public void Init(string projectID, string fid)
        {
            var con = new StudentGroupSearchCondition() { FacilityID = fid, SortMode = LJH.GeneralLibrary.SortMode.Asc };
            var gps = new APIClient(AppSettings.Current.ConnStr).GetList<Guid, StudentGroupSummary>(con, projectID).QueryObjects;
            if (gps != null && gps.Count > 0 && string.IsNullOrEmpty(fid)) gps.RemoveAll(it => !string.IsNullOrEmpty(it.FacilityID));
            if (gps != null) gps.Insert(0, new StudentGroupSummary());
            this.DataSource = gps;
            this.DisplayMember = "Name";
            this.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void Clear()
        {
            this.DataSource = null;
        }
        #endregion

        [Browsable(false)]
        [Localizable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Guid? SelectedGroupID
        {
            get
            {
                if (this.SelectedIndex <= 0)
                {
                    return null;
                }
                else
                {
                    StudentGroupSummary StudentGroup = (StudentGroupSummary)this.Items[SelectedIndex];
                    return StudentGroup.ID;
                }
            }
            set
            {
                for (int i = 1; i < this.Items.Count; i++)
                {
                    StudentGroupSummary info = this.Items[i] as StudentGroupSummary;
                    if (info.ID == value)
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
        public StudentGroupSummary SelectedGroup
        {
            get
            {
                if (this.SelectedIndex <= 0)
                {
                    return null;
                }
                else
                {
                    StudentGroupSummary StudentGroup = (StudentGroupSummary)this.Items[SelectedIndex];
                    return StudentGroup;
                }
            }
        }
    }
}
