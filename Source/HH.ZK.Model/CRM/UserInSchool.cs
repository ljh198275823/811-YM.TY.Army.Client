using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HH.ZK.Model.CRM
{
    public class UserInSchool : LJH.GeneralLibrary.IEntity<string>
    {

        #region 构造函数
        public UserInSchool()
        { }
        #endregion

        #region 私有变量
        private Dictionary<uint, uint> _AllRights = null;
        #endregion

        #region 公共属性
        /// <summary>
        /// ID 由 操作员ID + SchoolID组成
        /// </summary>
        public string ID { get; set; }

        public string UserID { get; set; }

        public User User { get; set; }

        public string SchoolID { get; set; }

        public School School { get; set; }
        /// <summary>
        /// 获取或设置角色
        /// </summary>
        public string Role { get; set; }
        /// <summary>
        /// 获取或设置过期日期
        /// </summary>
        public DateTime ExpireDate { get; set; }
        /// <summary>
        /// 获取或设置操作员管理的所有考点
        /// </summary>
        public string Projects { get; set; }
        /// <summary>
        /// 获取或设置区域选择模式
        /// </summary>
        public int? SelectionType { get; set; }
        /// <summary>
        /// 获取或设置所可以使用的所有区域
        /// </summary>
        public string SelectionItems { get; set; }
        /// <summary>
        /// 获取或设置是否使用加密狗
        /// </summary>
        public bool? Ukey { get; set; }
        /// <summary>
        /// 获取或设置是否需要验证
        /// </summary>
        public bool NeedConfirm { get; set; }
        #endregion

        #region 权限判断
        /// <summary>
        /// 获取或设置当前模块的权限
        /// </summary>
        [JsonIgnore]
        public string CurrentPermissions { get; set; }

        /// <summary>
        /// 检测此操作员是否被授予某个数据的所有指定权限
        /// </summary>
        /// <param name="right"></param>
        /// <param name="action"></param>
        /// <returns></returns>
        public bool PermitAll(Permission right, PermissionActions action)
        {
            if (IsAdmin) return true;
            if (CurrentPermissions == "all") return true;
            var AllRights = GetAllRights();
            if (AllRights != null && AllRights.Count > 0)
            {
                if (AllRights.Keys.Contains(right))
                {
                    return (AllRights[right] & action) == action;
                }
            }
            return false;
        }
        /// <summary>
        /// 检测此操作员是否被授予某个数据的其中任意一个权限
        /// </summary>
        /// <param name="right"></param>
        /// <param name="action"></param>
        /// <returns></returns>
        public bool PermitAny(Permission right, PermissionActions action)
        {
            if (IsAdmin) return true;
            if (CurrentPermissions == "all") return true;
            var _AllRights = GetAllRights();
            if (_AllRights != null && _AllRights.Count > 0)
            {
                if (_AllRights.Keys.Contains(right))
                {
                    return (_AllRights[right] & action) > 0;
                }
            }
            return false;
        }

        private Dictionary<Permission, PermissionActions> GetAllRights()
        {
            try
            {
                return JsonConvert.DeserializeObject<Dictionary<Permission, PermissionActions>>(CurrentPermissions);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        #endregion

        #region 公共方法
        /// <summary>
        /// 获取是否是管理员
        /// </summary>
        public bool IsAdmin
        {
            get { return Role == Roles.系统管理员.ToString(); }
        }

        public UserInSchool Clone()
        {
            return this.MemberwiseClone() as UserInSchool;
        }
        #endregion
    }
}
