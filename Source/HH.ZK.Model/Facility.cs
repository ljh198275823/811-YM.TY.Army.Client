using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HH.ZK.Model
{
    /// <summary>
    /// 表示学校或院系
    /// </summary>
    public class Facility : LJH.GeneralLibrary.IEntity<string>
    {
        #region 构造函数
        public Facility()
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
        /// <summary>
        /// 获取或设置注册学校ID
        /// </summary>
        public string SchoolID { get; set; }
        /// <summary>
        /// 获取或设置区域ID
        /// </summary>
        public long? DivisionID { get; set; }
        /// <summary>
        /// 获取或设置区域名称
        /// </summary>
        public string DivisionName { get; set; }
        /// <summary>
        /// 获取或设置城乡类型 1表示城镇 2表示农村
        /// </summary>
        public int? ChengXian { get; set; }
        #endregion

        #region 公共方法
        /// <summary>
        /// 克隆一个复本
        /// </summary>
        /// <returns></returns>
        public Facility Clone()
        {
            return this.MemberwiseClone() as Facility;
        }
        #endregion
    }
}
