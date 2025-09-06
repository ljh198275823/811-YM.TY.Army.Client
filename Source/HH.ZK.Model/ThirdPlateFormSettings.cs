using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HH.ZK.Model
{
    public class ThirdPlateFormSettings
    {
        #region 构造函数
        public ThirdPlateFormSettings()
        {

        }
        #endregion

        #region 公共属性
        /// <summary>
        /// 获取或设置第三方系统类型
        /// </summary>
        public ThirdPlateForm ThirdPlateForm { get; set; }
        /// <summary>
        /// 获取或设置服务器地址
        /// </summary>
        public string Server { get; set; }
        /// <summary>
        /// 获取或设置用户名
        /// </summary>
        public string User { get; set; }
        /// <summary>
        ///获取或设置密码
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// 获取或设置考点编号
        /// </summary>
        public string KDNumber { get; set; }
        #endregion
    }
}
