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
        public int PhysicalItemID { get; set; }

        public Guid? BestScoreID { get; set; }

        public List<StudentScore> TestScores { get; set; }
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
                return TestScores.Single(it => it.ID == BestScoreID);
            }
        }

        public StudentScore GetScoreByIndex(int ind, bool 包括作废 = false)
        {
            if (TestScores == null || TestScores.Count == 0) return null;
            if (包括作废)
            {
                if (TestScores.Count <= ind) return null;
                return TestScores.ElementAt(ind);
            }
            else
            {
                if (TestScores.Count(it => it.SpecialType != SpecialScoreType.作废) <= ind) return null;
                return TestScores.Where(it => it.SpecialType != SpecialScoreType.作废).ElementAt(ind);
            }
        }

        public int 获取成绩序号(StudentScore score)
        {
            if (this.TestScores == null || this.TestScores.Count == 0) return -1;
            return this.TestScores.FindIndex(it => it.ID == score.ID) + 1;
        }
    }
}
