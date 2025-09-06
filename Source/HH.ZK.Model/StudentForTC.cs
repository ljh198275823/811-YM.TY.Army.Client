using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HH.TiYu.Model
{
    public class StudentForTC : Student
    {
        /// <summary>
        /// 获取或设置民族编号
        /// </summary>
        public int? Nation { get; set; }
        /// <summary>
        /// 获取或设置学生来源编号
        /// </summary>
        public string District { get; set; }
        /// <summary>
        /// 获取或设置专业
        /// </summary>
        public string Professional { get; set; }
        /// <summary>
        /// 获取或设置毕业高中
        /// </summary>
        public string HighSchool { get; set; }
        /// <summary>
        /// 获取或设置学生是城镇还是乡村学生
        /// </summary>
        public string ChengXian { get; set; }
        /// <summary>
        /// 获取或设置综合评价
        /// </summary>
        public string Appraise { get; set; }
        /// <summary>
        /// 获取或设置运动建议
        /// </summary>
        public string SportSuggestion { get; set; }
        #region 公共方法
        /// <summary>
        /// 克隆一个复本
        /// </summary>
        /// <returns></returns>
        public StudentForTC Clone()
        {
            var ret = this.MemberwiseClone() as StudentForTC;
            return ret;
        }
        #endregion
    }
}
