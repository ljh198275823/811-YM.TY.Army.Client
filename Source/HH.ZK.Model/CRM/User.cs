using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using LJH.GeneralLibrary;
using Newtonsoft.Json;

namespace HH.ZK.Model.CRM
{
    /// <summary>
    /// 代表系统操作员
    /// </summary>
    public class User : LJH.GeneralLibrary.IEntity<string>
    {
        #region 构造函数
        public User()
        {

        }
        #endregion

        #region 公共属性
        /// <summary>
        /// 操作员登录名
        /// </summary>
        public string ID { get; set; }
        /// <summary>
        /// 获取或设置操作员姓名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 操作员登录密码
        /// </summary>
        public string Password { get; set; }

        public string Role { get; set; }

        public string Permissions { get; set; }

        public int? SelectionType { get; set; }

        public string SelectionItems { get; set; }
        /// <summary>
        /// 获取或设置状态
        /// </summary>
        public OperatorState States { get; set; }
        /// <summary>
        /// 获取或设置创建日期
        /// </summary>
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 获取或设置手机号
        /// </summary>
        public string Mobile { get; set; }
        /// <summary>
        /// 获取或设置电子邮件
        /// </summary>
        public string Email { get; set; }

        public DateTime? ExpireDate { get; set; }
        #endregion

        #region 扩展属性
        /// <summary>
        /// 获取或设置额外信息
        /// </summary>
        public string Note { get; set; }
        private Dictionary<string, string> _Externals = null;

        public string GetProperty(OperatorNote pn)
        {
            if (_Externals == null && !string.IsNullOrEmpty(Note)) _Externals = JsonConvert.DeserializeObject<Dictionary<string, string>>(Note);
            if (_Externals == null) return null;
            if (_Externals.ContainsKey(((int)pn).ToString())) return _Externals[((int)pn).ToString()];
            if (_Externals.ContainsKey(pn.ToString())) return _Externals[pn.ToString()];
            return null;
        }

        public void SetProperty(OperatorNote pn, string value)
        {
            var key = ((int)pn).ToString();
            if (_Externals == null && !string.IsNullOrEmpty(Note)) _Externals = JsonConvert.DeserializeObject<Dictionary<string, string>>(Note);
            if (_Externals == null) _Externals = new Dictionary<string, string>();
            if (value == null) { if (_Externals.ContainsKey(key)) _Externals.Remove(key); }
            else _Externals[key] = value;
            Note = JsonConvert.SerializeObject(_Externals);
        }

        public void RemoveProperty(OperatorNote pn)
        {
            var key = ((int)pn).ToString();
            if (_Externals == null && !string.IsNullOrEmpty(Note)) _Externals = JsonConvert.DeserializeObject<Dictionary<string, string>>(Note);
            if (_Externals == null) return;
            if (_Externals.ContainsKey(key)) _Externals.Remove(key);
            Note = JsonConvert.SerializeObject(_Externals);
        }
        #endregion

        #region 公共方法
        /// <summary>
        /// 获取解密后的密码
        /// </summary>
        /// <returns></returns>
        public string GetPassword()
        {
            if (Password.Length > 14)
            {
                var ret = (new DTEncrypt()).DSEncrypt(Password);
                return ret;
            }
            else
            {
                return Password;
            }
        }

        public void SetPassword(string pwd)
        {
            Password = (new DTEncrypt()).Encrypt(pwd);
        }

        public User Clone()
        {
            var ret = this.MemberwiseClone() as User;
            ret._Externals = null;
            return ret;
        }
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
        #endregion
    }

    [Flags]
    public enum OperatorState
    {
        正常 = 0,
        未验证 = 0x01,
        禁用 = 0x2,
        密码过期 = 0x08,
    }

    public enum OperatorNote
    {
        微信号 = 1,
        QQ = 2,
    }

    public enum UserType
    {
        /// <summary>
        /// 账号可以关联多个客户
        /// </summary>
        一类账号 = 0,
        /// <summary>
        /// 账号只能关联一个客户，可以由客户的管理员来创建
        /// </summary>
        二类账号 = 1,
        /// <summary>
        /// VIP账号
        /// </summary>
        VIP账号 = 9,
    }
}
