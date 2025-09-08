using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HH.ZK.Model;
using HH.ZK.Model.CRM;
using HH.ZK.WebAPIClient;
using HH.ZK.CommonUI;
using LJH.GeneralLibrary;
using LJH.GeneralLibrary.WinForm;

namespace HH.ZK.UI
{
    public partial class FrmStudentDetail : FrmDetailBase<string,Student>
    {
        public FrmStudentDetail()
        {
            InitializeComponent();
        }

        #region 重写基类方法
        protected override void InitControls()
        {
            base.InitControls();
            txtFacility.Init();
        }

        public override void ShowOperatorRights()
        {
            base.ShowOperatorRights();
            btnOk.Enabled = AppSettings.Current.Operator.PermitAll(Permission.Student, PermissionActions.Edit);
            btnBrowserPhoto.Enabled = AppSettings.Current.Operator.PermitAll(Permission.StudentPhoto, PermissionActions.Edit);
            btnDelPhoto.Enabled = AppSettings.Current.Operator.PermitAll(Permission.StudentPhoto, PermissionActions.Edit);
        }

        protected override void ItemShowing(Student item)
        {
            txtID.Text = item.ID;
            txtID.Enabled = false;
            txtName.Text = item.Name;
            txtCardID.Text = item.CardID;
            txtFacility.SelectedDivisionID = item.DivisionID;
            rdMale.Checked = item.Gender == Gender.Male;
            rdFemale.Checked = item.Gender == Gender.Female;
            txtClassName.Text = item.ClassName;
            txtIDNumber.Text = item.IDNumber;
            StudentPhoto sp = (new APIClient(AppSettings.Current.ConnStr)).GetByID<string, StudentPhoto>(item.ID).QueryObject;
            if (sp != null) picPhoto.Image = sp.GetPhoto();
        }

        protected override bool CheckInput()
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("学号不能为空");
                txtID.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("姓名不能为空");
                txtName.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtFacility.Text))
            {
                MessageBox.Show("学生的所属学校没有指定");
                return false;
            }
            return true;
        }

        protected override Student GetItemFromInput()
        {
            Student info = UpdatingItem as Student;
            if (UpdatingItem == null) info = new Student();
            info.ID = txtID.Text.Trim();
            info.Name = txtName.Text.Trim();
            info.CardID = txtCardID.Text.Trim();
            info.DivisionID = txtFacility.SelectedDivisionID.Value;
            info.Gender = rdMale.Checked ? Gender.Male : Gender.Female;
            info.Grade = GradeHelper.无;
            info.ClassName = !string.IsNullOrEmpty(txtClassName.Text) ? txtClassName.Text : null;
            info.IDNumber = !string.IsNullOrEmpty(txtIDNumber.Text) ? txtIDNumber.Text.Trim() : null;
            return info;
        }

        protected override CommandResult<Student> AddItem(Student addingItem)
        {
            Student s = addingItem;
            var ret = (new APIClient(AppSettings.Current.ConnStr)).Add<string, Student>(s);
            if (ret.Result == ResultCode.Successful)
            {
                if (picPhoto.Tag != null)
                {
                    var sp = new StudentPhoto(s.ID, picPhoto.Tag.ToString());
                    sp.CheckFace = AppSettings.Current.PhysicalProject.Options.IgnoreFaceFeature ? false : true;
                    if (sp.Photo != null && sp.Photo.Length > 200 * 1024)
                    {
                        MessageBox.Show("学生信息增加成功，但学生照片保存失败，失败原因:图片超过200K");
                    }
                    else
                    {
                        CommandResult ret1 = (new APIClient(AppSettings.Current.ConnStr)).Add<string, StudentPhoto>(sp);
                        if (ret1.Result == ResultCode.Successful)
                        {
                            s.HasPhoto = true;
                        }
                        else
                        {
                            MessageBox.Show("学生信息增加成功，但学生照片保存失败，失败原因:" + ret1.Message);
                        }
                    }
                }
                s.DivisionName = ret.Value.DivisionName;
            }
            return ret;
        }

        protected override CommandResult<Student> UpdateItem(Student updatingItem)
        {
            Student s = updatingItem;
            var ret = (new APIClient(AppSettings.Current.ConnStr)).Add<string, Student>(s);
            if (ret.Result == ResultCode.Successful)
            {
                if (picPhoto.Tag != null)
                {
                    var sp = new StudentPhoto(s.ID, picPhoto.Tag.ToString());
                    if (sp.Photo != null && sp.Photo.Length > 200 * 1024)
                    {
                        MessageBox.Show("学生信息增加成功，但学生照片保存失败，失败原因:图片超过200K");
                    }
                    else
                    {
                        CommandResult ret1 = (new APIClient(AppSettings.Current.ConnStr)).Add<string, StudentPhoto>(sp);
                        if (ret1.Result == ResultCode.Successful)
                        {
                            s.HasPhoto = true;
                        }
                        else
                        {
                            MessageBox.Show("学生信息增加成功，但学生照片保存失败，失败原因:" + ret1.Message);
                        }
                    }
                }
                s.DivisionName = ret.Value.DivisionName;
            }
            return ret;
        }
        #endregion

        #region 事件处理程序
        private void btnBrowserPhoto_Click(object sender, EventArgs e)
        {
            if (picPhoto.Image != null)
            {
                MessageBox.Show("学生照片已经存在，请先删除旧照片");
                return;
            }
            try
            {
                OpenFileDialog saveFileDialog1 = new OpenFileDialog();
                saveFileDialog1.Filter = "JPG文件|*.jpg|所有文件(*.*)|*.*";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string path = saveFileDialog1.FileName;
                    picPhoto.Image = Image.FromFile(path);
                    picPhoto.Tag = path;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelPhoto_Click(object sender, EventArgs e)
        {
            if (UpdatingItem != null)
            {
                Student student = UpdatingItem as Student;
                CommandResult ret = (new APIClient(AppSettings.Current.ConnStr)).Delete<string, StudentPhoto>(student.ID);
                if (ret.Result == ResultCode.Successful)
                {
                    student.HasPhoto = false;
                    picPhoto.Image = null;
                    picPhoto.Tag = null;
                }
                else
                {
                    MessageBox.Show(ret.Message);
                }
            }
            else
            {
                picPhoto.Image = null;
            }
        }
        #endregion
    }
}
