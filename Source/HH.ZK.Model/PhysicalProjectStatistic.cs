using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HH.ZK.Model
{
    /// <summary>
    /// 表示考点考试进度信息
    /// </summary>
    public class PhysicalProjectStatistic : LJH.GeneralLibrary.IEntity<string>
    {
        #region 公共属性
        /// <summary>
        /// 获取或设置ID
        /// </summary>
        public string ID { get; set; }
        /// <summary>
        /// 获取或设置类型
        /// </summary>
        public ProjectClass Class { get; set; }
        /// <summary>
        /// 获取或设置名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 获取或设置总人数
        /// </summary>
        public int TotalCount { get; set; }
        /// <summary>
        /// 获取或设置完成考试人数
        /// </summary>
        public int Completed { get; set; }
        /// <summary>
        /// 获取或设置完成检录人数
        /// </summary>
        public int Checked { get; set; }
        /// <summary>
        /// 获取或设置缺免考人数
        /// </summary>
        public int Absent { get; set; }

        public int TodayCompleted { get; set; }

        public int TodayChecked { get; set; }
        #endregion
    }
}
