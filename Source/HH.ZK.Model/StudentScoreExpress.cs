using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HH.ZK.Model
{
    public class StudentScoreExpress
    {
        #region 公共属性
        /// <summary>
        /// 获取或设置测试项目
        /// </summary>
        public int TestID { get; set; }
        /// <summary>
        /// 获取或设置成绩创建时间
        /// </summary>
        public DateTime TestTime { get; set; }
        /// <summary>
        /// 获取或设置成绩
        /// </summary>
        public string FormatScore { get; set; }
        /// <summary>
        /// 获取或设置得分
        /// </summary>
        public decimal? Result { get; set; }
        /// <summary>
        /// 获取或设置加分
        /// </summary>
        public decimal? Jiafen { get; set; }
        /// <summary>
        /// 获取或设置得分等级
        /// </summary>
        public string Rank { get; set; }
        #endregion
    }
}
