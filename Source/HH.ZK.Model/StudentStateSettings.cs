using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.ZK.Model
{
    public class StudentStateSettings
    {
        #region 构造函数

        #endregion

        public List<StudentStatePara> Items { get; set; }

        public decimal ? GetTotal(StudentState st)
        {
            if (Items == null || Items.Count == 0) return null;
            var para = Items.SingleOrDefault(it => it.State == st);
            return para?.Total;
        }
    }

    public class StudentStatePara
    {
        /// <summary>
        /// 获取或设置学生状态
        /// </summary>
        public StudentState State { get; set; }
        /// <summary>
        /// 获取或设置学生总分，某些状态会直接设置一个总分值 
        /// </summary>
        public decimal? Total { get; set; }
    }
}
