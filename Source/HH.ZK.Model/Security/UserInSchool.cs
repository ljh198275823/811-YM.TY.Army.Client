using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.ZK.Model.Security
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

        public bool Authorised { get; set; }
        /// <summary>
        /// 获取或设置是否是管理员
        /// </summary>
        public bool IsAdmin { get; set; }
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
        /// 获取或设置权限
        /// </summary>
        public string Permissions { get; set; }
        /// <summary>
        /// 获取或设置是否使用加密狗
        /// </summary>
        public bool? Ukey { get; set; }
        /// <summary>
        /// 获取或设置是否需要验证
        /// </summary>
        public bool NeedConfirm { get; set; }
        #endregion

        #region 查看权限
        /// <summary>
        /// 检测此操作员是否被授予某个数据的所有指定权限
        /// </summary>
        /// <param name="right"></param>
        /// <param name="action"></param>
        /// <returns></returns>
        public bool PermitAll(Permission right, PermissionActions action)
        {
            if (IsAdmin) return true;
            if (Permissions == "all") return true;
            if (_AllRights == null) GetAllRights();
            if (_AllRights != null && _AllRights.Count > 0)
            {
                if (_AllRights.Keys.Contains((uint)right))
                {
                    return (_AllRights[(uint)right] & (uint)action) == (uint)action;
                }
            }
            return false;
        }

        /// <summary>
        /// 检测此操作员是否被授予某个数据的其中一个权限
        /// </summary>
        /// <param name="right"></param>
        /// <param name="action"></param>
        /// <returns></returns>
        public bool Permit(Permission right, PermissionActions action)
        {
            if (IsAdmin) return true;
            if (Permissions == "all") return true;
            if (_AllRights == null) GetAllRights();
            if (_AllRights != null && _AllRights.Count > 0)
            {
                if (_AllRights.Keys.Contains((uint)right))
                {
                    return (_AllRights[(uint)right] & (uint)action) > 0;
                }
            }
            return false;
        }

        private Dictionary<uint, uint> GetAllRights()
        {
            if (_AllRights == null) _AllRights = new Dictionary<uint, uint>();
            if (!string.IsNullOrEmpty(Permissions))
            {
                foreach (string str in Permissions.Split(','))
                {
                    ulong temp = 0;
                    if (ulong.TryParse(str, out temp))
                    {
                        uint permission = (uint)((temp >> 32) & 0xFFFFFFFF); //高32位表示权限
                        uint actions = (uint)(temp & 0xFFFFFFFF); //低32位表示动作
                        if (_AllRights.Keys.Contains(permission))
                        {
                            _AllRights[permission] = _AllRights[permission] | actions;
                        }
                        else
                        {
                            _AllRights.Add(permission, actions);
                        }
                    }
                }
            }
            return _AllRights;
        }
        #endregion
    }
}
