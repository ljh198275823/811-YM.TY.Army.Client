using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HH.ZK.Model.CRM
{
    public class UserPermission : LJH.GeneralLibrary.IEntity<string>
    {
        #region 构造函数
        public UserPermission()
        {

        }
        #endregion

        #region 公共属性
        public string ID { get; set; }
        /// <summary>
        /// 获取或设置用户ID
        /// </summary>
        public string UserID { get; set; }
        /// <summary>
        /// 获取或设置用户信息
        /// </summary>
        public User User { get; set; }
        /// <summary>
        /// 获取或设置模块
        /// </summary>
        public HHModules Modules { get; set; }
        /// <summary>
        /// 获取或设置计划ID
        /// </summary>
        public string ProjectID { get; set; }
        /// <summary>
        /// 获取或设置角色
        /// </summary>
        public string Role { get; set; }
        /// <summary>
        /// 获取或设置权限
        /// </summary>
        public string Permissions { get; set; }
        #endregion

        public UserPermission Clone()
        {
            return this.MemberwiseClone() as UserPermission;
        }
    }
}