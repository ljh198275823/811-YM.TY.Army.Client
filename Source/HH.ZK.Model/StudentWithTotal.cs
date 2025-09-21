using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HH.ZK.Model
{
    /// <summary>
    /// 表示带总分的学生信息
    /// </summary>
    public class StudentWithTotal : Student
    {
        #region 构造函数
        public StudentWithTotal() : base()
        {

        }
        #endregion

        #region 公共属性
        public DateTime TestDate { get; set; }

        public string ProjectID { get; set; }

        public string ProjectName { get; set; }
        #endregion

        #region 学生成绩相关属性
        /// <summary>
        /// 获取或设置学生总分
        /// </summary>
        public decimal Total { get; set; }
        /// <summary>
        /// 获取或设置考试情况
        /// </summary>
        public TestCompleteState TestState { get; set; }
        /// <summary>
        /// 获取或设置考生成绩
        /// </summary>
        public List<StudentScoreExpress> Scores { get; set; }
        #endregion
    }
}
