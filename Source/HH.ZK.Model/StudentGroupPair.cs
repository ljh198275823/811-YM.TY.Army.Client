using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HH.ZK.Model
{
    public class StudentGroupPair : LJH.GeneralLibrary.IEntity<Guid>
    {
        #region 构造函数
        public StudentGroupPair()
        {
        }
        #endregion

        #region 公共属性
        public Guid ID { get; set; }
        /// <summary>
        /// 获取或设置组ID
        /// </summary>
        public Guid GroupID { get; set; }
        /// <summary>
        /// 获取或设置运动员编号
        /// </summary>
        public string StudentID { get; set; }
        /// <summary>
        /// 获取或设置道次
        /// </summary>
        public int? Channel { get; set; }
        #endregion

        public StudentGroupPair Clone()
        {
            return this.MemberwiseClone() as StudentGroupPair;
        }
    }
}
