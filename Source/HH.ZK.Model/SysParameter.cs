using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HH.ZK.Model
{
    public class SysParameter : LJH.GeneralLibrary.IEntity<string>
    {
        #region 构造函数
        public SysParameter(string para, string paraValue, string desc)
        {
            this.ID = para;
            this.Value = paraValue;
            this.Memo = desc;
        }

        public SysParameter()
        {
        }
        #endregion

        #region 公共属性
        /// <summary>
        /// 获取或设置ID
        /// </summary>
        public string ID { get; set; }
        /// <summary>
        /// 获取或设置名称
        /// </summary>
        public string Name { get; set; }
        public string ProjectID { get; set; }
        /// <summary>
        /// 获取或设置参数值
        /// </summary>
        public string Value { get; set; }
        /// <summary>
        /// 获取或设置备注
        /// </summary>
        public string Memo { get; set; }
        #endregion
    }
}
