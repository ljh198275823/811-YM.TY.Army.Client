using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HH.ZK.Model
{
    /// <summary>
    /// 表示区域信息
    /// </summary>
    public class Division : LJH.GeneralLibrary.IEntity<long>
    {
        #region 构造函数
        public Division() { }
        #endregion

        #region 公共属性
        /// <summary>
        /// 获取或设置ID
        /// </summary>
        public long ID { get; set; }
        /// <summary>
        /// 获取或设置名称
        /// </summary>
        public string Name { get; set; }

        public string Number { get; set; }
        /// <summary>
        /// 获取或设置上级区域ID
        /// </summary>
        public long? ParentID { get; set; }

        public string FullPath { get; set; }
        #endregion

        public Division Clone()
        {
            return this.MemberwiseClone() as Division;
        }
    }
}
