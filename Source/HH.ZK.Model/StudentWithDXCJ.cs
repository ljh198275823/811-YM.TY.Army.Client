using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HH.ZK.Model
{
    /// <summary>
    /// 表示带单项成绩的学生信息
    /// </summary>
    public class StudentWithDXCJ : Student
    {
        #region 构造函数

        #endregion

        #region 公共属性
        public DateTime TestDate { get; set; }

        public string ProjectID { get; set; }

        public string ProjectName { get; set; }

        public string ProjectShortName { get; set; }
        #endregion

        #region 公共属性
        public int TestID { get; set; }

        public long? BestScoreID { get; set; }

        public List<StudentScore> Scores { get; set; }
        /// <summary>
        /// 获取或设置是否超出测试次数
        /// </summary>
        public int OverCount { get; set; }
        /// <summary>
        /// 获取或设置违规考试是否已经处理
        /// </summary>
        public bool OverCountHandled { get; set; }
        #endregion

        public StudentScore BestScore
        {
            get
            {
                if (BestScoreID == null) return null;
                return Scores.Single(it => it.ID == BestScoreID);
            }
        }

        public StudentScore GetScoreByIndex(int ind, bool 包括作废 = false)
        {
            if (Scores == null || Scores.Count == 0) return null;
            if (包括作废)
            {
                if (Scores.Count <= ind) return null;
                return Scores.ElementAt(ind);
            }
            else
            {
                if (Scores.Count(it => it.SpecialType != SpecialScoreType.作废) <= ind) return null;
                return Scores.Where(it => it.SpecialType != SpecialScoreType.作废).ElementAt(ind);
            }
        }

        public int 获取成绩序号(StudentScore score)
        {
            if (this.Scores == null || this.Scores.Count == 0) return -1;
            return this.Scores.FindIndex(it => it.ID == score.ID) + 1;
        }
    }
}
