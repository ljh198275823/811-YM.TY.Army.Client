using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HH.ZK.Model
{
    public class StudentGroupWithTestState : StudentGroupSummary
    {
        #region 公共属性
        /// <summary>
        /// 获取或设置测试过的学生数量，有成绩，但没有完成测试
        /// </summary>
        public int Tested { get; set; }
        /// <summary>
        /// 获取或设置完成考试学生数量
        /// </summary>
        public virtual int Completed { get; set; }
        #endregion
    }
}