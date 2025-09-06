using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HH.ZK.Model
{
    public class StudentGroupWithCheckState : StudentGroupSummary
    {
        #region 公共属性
        /// <summary>
        /// 获取或设置已检录学生数量
        /// </summary>
        public virtual int CheckedCount { get; set; }
        #endregion
    }
}
