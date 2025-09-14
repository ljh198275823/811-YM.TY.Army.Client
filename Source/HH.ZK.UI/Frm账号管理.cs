using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HH.ZK.Model;
using HH.ZK.CommonUI;
using HH.ZK.WebAPIClient;
using HH.ZK.Model.CRM;
using HH.ZK.Model.SearchCondition;
using LJH.GeneralLibrary;
using LJH.GeneralLibrary.WinForm;

namespace HH.ZK.UI
{
    public partial class Frm账号管理 : LJH.GeneralLibrary.WinForm.FrmMasterBase<string, UserInSchool>
    {
        public Frm账号管理()
        {
            InitializeComponent();
        }

        private List<Project> _Projects = null;
        private Dictionary<string, List<Facility>> _Facilities = new Dictionary<string, List<Facility>>();

        #region 私有方法
        private string GetProjectNames(string pids)
        {
            if (string.IsNullOrEmpty(pids)) return null;
            if (_Projects == null || _Projects.Count == 0) return null;
            string ret = string.Empty;
            var strTemps = pids.Split(',');
            foreach (var str in strTemps)
            {
                if (!string.IsNullOrEmpty(str.Trim()))
                {
                    var p = _Projects.SingleOrDefault(it => it.ID == str.Trim());
                    if (p != null) ret += p.Name + ",";
                }
            }
            if (!string.IsNullOrEmpty(ret)) return ret.TrimEnd(',');
            return null;
        }

        private string GetFacilityNames(string fids, string projectID)
        {
            if (string.IsNullOrEmpty(fids)) return null;
            if (_Facilities.ContainsKey(projectID) == false)
            {
                var fret = new APIClient(AppSettings.Current.ConnStr).GetList<string, Facility>(null, projectID);
                if (fret.Result != ResultCode.Successful)
                {
                    return null;
                }
                _Facilities[projectID] = fret.QueryObjects;
            }
            var fs = _Facilities[projectID];
            if (fs == null || fs.Count == 0) return null;
            string ret = string.Empty;
            var strTemps = fids.Split(',');
            foreach (var str in strTemps)
            {
                if (!string.IsNullOrEmpty(str.Trim()))
                {
                    var p = fs.SingleOrDefault(it => it.ID == str.Trim());
                    if (p != null) ret += p.Name + ",";
                }
            }
            if (!string.IsNullOrEmpty(ret)) return ret.TrimEnd(',');
            return null;
        }
        #endregion

        #region 重写基类方法
        protected override FrmDetailBase<string, UserInSchool> GetDetailForm()
        {
            var frm = new FrmOperatorParaDetail();
            return frm;
        }

        protected override QueryResultList<UserInSchool> GetDataSource()
        {
            _Projects = new APIClient(AppSettings.Current.ConnStr).GetList<string, Project>(null, null).QueryObjects;
            if (SearchCondition == null)
            {
                var con = new OperatorParaSearchCondition() { };
                return new APIClient(AppSettings.Current.ConnStr).GetList<string, UserInSchool>(con, null);
            }
            else
            {
                return new APIClient(AppSettings.Current.ConnStr).GetList<string, UserInSchool>(SearchCondition, null);
            }
        }

        protected override List<UserInSchool> FilterData(List<UserInSchool> items)
        {
            items = FullTextSearch(items, txtKeyword.Text);
            return (from it in items where it.UserID != AppSettings.Current.Operator.ID where it.UserID != AppSettings.Current.Operator.ID orderby it.User?.Mobile ascending select it).ToList();
        }

        protected override object GetCellValue(UserInSchool info, string colName)
        {
            if (colName == "colID") return !string.IsNullOrEmpty(info.User.Mobile) ? info.User.Mobile : info.UserID;
            if (colName == "colName") return info.User.Name;
            if (colName == "colRole") return info.Role;
            return base.GetCellValue(info, colName);
        }

        protected override CommandResult DeletingItem(UserInSchool item)
        {
            return CRMAPIClient.Delete<string, UserInSchool>(item);
        }
        #endregion

        private void mnu复位密码_Click(object sender, EventArgs e)
        {
            var dig = MessageBox.Show("是否需要重置所选账号的密码?", "询问", MessageBoxButtons.YesNo);
            if (dig != DialogResult.Yes) return;
            int count = 0;
            foreach (DataGridViewRow row in GridView.SelectedRows)
            {
                var opt = GetRowTag(row);
                var patch = new UpdateItem<string>() { ID = opt.UserID, Key = "Password", Value = "123" };
                CommandResult result = CRMAPIClient.Patch<string, User>(opt.UserID, new List<UpdateItem<string>>() { patch });
                if (result.Result == ResultCode.Successful)
                {
                    count++;
                }
                else
                {
                    MessageBox.Show(result.Message);
                }
            }
            if (count > 0)
            {
                MessageBox.Show($"操作员的密码已经复位成默认密码 123");
            }
        }

        private void txtKeyword_TextChanged(object sender, EventArgs e)
        {
            FreshView();
        }
    }
}
