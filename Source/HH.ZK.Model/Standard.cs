using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LJH.GeneralLibrary;

namespace HH.ZK.Model
{
    /// <summary>
    /// 表示评分标准
    /// </summary>
    public class Standard : LJH.GeneralLibrary.IEntity<Guid>
    {
        #region 构造函数
        public Standard()
        {
        }
        #endregion

        #region 公共属性
        /// <summary>
        /// 获取或设置ID
        /// </summary>
        public Guid ID { get; set; }
        /// <summary>
        /// 获取或设置名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 获取或设置ProjectID
        /// </summary>
        public string ProjectID { get; set; }
        /// <summary>
        /// 获取或设置标准适用的测试项目ID
        /// </summary>
        public int PhysicalItemID { get; set; }
        /// <summary>
        /// 获取或设置标准适用的性别
        /// </summary>
        public Gender Gender { get; set; }
        /// <summary>
        /// 获取或设置标准适用的年级
        /// </summary>
        public int Grade { get; set; }
        /// <summary>
        /// 获取或设置是否是加分评分标准
        /// </summary>
        public bool IsForJiafen { get; set; }
        /// <summary>
        /// 获取或设置评分标准项
        /// </summary>
        public List<StandardItem> Items { get; set; }
        #endregion

        #region 公共方法
        public Standard Clone()
        {
            var ret = MemberwiseClone() as Standard;
            ret.Items = new List<StandardItem>();
            ret.Items.AddRange(this.Items.Select(it => it.Clone()));
            return ret;
        }
        #endregion
    }
}
