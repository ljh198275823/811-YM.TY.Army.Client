using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HH.ZK.Model
{
    public class StudentScoreFull : StudentScore
    {
        #region 公共属性
        /// <summary>
        /// 获取或设置学生姓名
        /// </summary>
        public string StudentName { get; set; }
        /// <summary>
        /// 获取或设置年级
        /// </summary>
        public int Grade { get; set; }
        /// <summary>
        /// 获取或设置学生性别
        /// </summary>
        public Sex Sex { get; set; }
        /// <summary>
        /// 获取或设置学生学校名称
        /// </summary>
        public string FacilityName { get; set; }
        /// <summary>
        /// 获取或设置测试项目名称
        /// </summary>
        public string PhysicalItemName { get; set; }
        #endregion
    }
}
