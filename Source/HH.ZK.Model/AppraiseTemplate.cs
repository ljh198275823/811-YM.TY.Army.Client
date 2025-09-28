using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HH.ZK.Model
{
    /// <summary>
    /// 表示综合评价的模板
    /// </summary>
    public class AppraiseTemplate : LJH.GeneralLibrary.IEntity<long>
    {
        #region 构造函数
        public AppraiseTemplate()
        {
        }
        #endregion

        #region 公共属性
        public long ID { get; set; }
        /// <summary>
        /// 获取或设置综合评价
        /// </summary>
        public TotalRank TotalRank { get; set; }
        /// <summary>
        /// 获取或设置成绩状态，用于表示各种成绩的分布状态，比如是否有成绩优良的项，是否有成绩一般的项，是否有成绩较低的项
        /// </summary>
        public int ScoreState { get; set; }
        /// <summary>
        /// 获取或设置此模板适用的最低年级
        /// </summary>
        public int GradeLower { get; set; }
        /// <summary>
        /// 获取或设置此模板适用的最高年级
        /// </summary>
        public int GradeUpper { get; set; }
        /// <summary>
        /// 获取或设置模板
        /// </summary>
        public string Template { get; set; }
        #endregion

        public AppraiseTemplate Clone()
        {
            return MemberwiseClone() as AppraiseTemplate;
        }
    }

    public enum TotalRank
    {
        无 = 0,
        优秀 = 1,
        良好 = 2,
        合格 = 3,
        不合格 = 4
    }
}
