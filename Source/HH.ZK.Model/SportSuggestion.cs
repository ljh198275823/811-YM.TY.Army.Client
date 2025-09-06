using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HH.ZK.Model
{
    public class SportSuggestion : LJH.GeneralLibrary.IEntity<Guid>
    {
        #region 构造函数
        public SportSuggestion()
        {
        }
        #endregion

        #region 公共属性
        public Guid ID { get; set; }
        /// <summary>
        /// 获取或设置适用此建议的测试项目
        /// </summary>
        public int PhysicalItem { get; set; }
        /// <summary>
        /// 获取或设置适用此建议的最低得分
        /// </summary>
        public int ScoreLower { get; set; }
        /// <summary>
        /// 获取或设置适用此建议的最低得分
        /// </summary>
        public int ScoreUpper { get; set; }
        /// <summary>
        /// 获取或设置得分等级
        /// </summary>
        public string Rank { get; set; }
        /// <summary>
        /// 运动建议适用性别，用男，女表示，其它值表示男女通用
        /// </summary>
        public string Sex { get; set; }
        /// <summary>
        /// 获取或设置适用此建议的最低年级
        /// </summary>
        public int GradeLower { get; set; }
        /// <summary>
        /// 获取或设置适用此建议的最高年级
        /// </summary>
        public int GradeUpper { get; set; }
        /// <summary>
        /// 获取或设置评价
        /// </summary>
        public string Evaluation { get; set; }
        /// <summary>
        /// 获取或设置建议的内容
        /// </summary>
        public string Suggestion { get; set; }
        /// <summary>
        /// 获取或设置更新时间
        /// </summary>
        public DateTime UpdateTime { get; set; }
        #endregion

        public SportSuggestion Clone()
        {
            return MemberwiseClone() as SportSuggestion;
        }
    }
}