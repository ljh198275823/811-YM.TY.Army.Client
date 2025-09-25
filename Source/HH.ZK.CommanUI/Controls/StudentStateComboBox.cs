using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HH.ZK.Model;
using HH.ZK.Model.SearchCondition;

namespace HH.ZK.CommonUI.Controls
{
    public partial class StudentStateComboBox : ComboBox
    {
        public StudentStateComboBox()
        {
            InitializeComponent();
        }

        public StudentStateComboBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        #region 私有变量
        #endregion

        public void Init(bool 显示正常状态)
        {
            this.Items.Clear();
            this.Items.Add(string.Empty);
            for (int i = 显示正常状态 ? 0 : 1; i < 100; i++)
            {
                if (Enum.IsDefined(typeof(StudentState), i)) this.Items.Add(((StudentState)i).ToString());
            }
        }

        public void Init(StudentStateSettings ss, bool 显示正常状态)
        {
            this.Items.Clear();
            this.Items.Add(string.Empty);
            if (ss != null && ss.Items != null && ss.Items.Count > 0)
            {
                foreach (var item in ss.Items)
                {
                    this.Items.Add(item.State.ToString());
                }
            }
            if (显示正常状态) this.Items.Add(StudentState.正常.ToString());
        }

        [Browsable(false)]
        [Localizable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public StudentState SelectedStudentState
        {
            get
            {

                if (!string.IsNullOrEmpty(this.Text))
                {
                    StudentState st;
                    if (Enum.TryParse<StudentState>(this.Text, out st))
                    {
                        return st;
                    }
                }
                return StudentState.正常;
            }
            set
            {
                for (int i = 1; i < this.Items.Count; i++)
                {
                    if (value.ToString() == this.Items[i].ToString())
                    {
                        this.SelectedIndex = i;
                        break;
                    }
                }
            }
        }
    }
}
