using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LJH.GeneralLibrary;

namespace HH.ZK.Model
{
    public class StudentInProject: IEntity<Guid>
    {
        #region 构造函数
        public StudentInProject() { }
        #endregion

        #region 公共属性
        /// <summary>
        /// 获取或设置ID
        /// </summary>
        public Guid ID { get; set; }
        /// <summary>
        /// 获取或设置测试日期
        /// </summary>
        public DateTime TestDate { get; set; }
        /// <summary>
        /// 获取或设置项目编号
        /// </summary>
        public string ProjectID { get; set; }
        /// <summary>
        /// 获取或设置学号
        /// </summary>
        public string StudentID { get; set; }
        /// <summary>
        /// 获取或设置学生状态
        /// </summary>
        public int State { get; set; }
        /// <summary>
        /// 获取或设置更新时间
        /// </summary>
        public DateTime? AddTime { get; set; }

        public string Teacher { get; set; }

        public string Operator { get; set; }
        #endregion
    }
}
