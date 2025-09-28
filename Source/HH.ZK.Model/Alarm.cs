using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HH.ZK.Model
{
    /// <summary>
    /// 表示系统的一些报警日志
    /// </summary>
    public class Alarm : LJH.GeneralLibrary.IEntity<long>
    {
        #region 构造函数
        public Alarm() { }
        #endregion

        #region 公共属性
        /// <summary>
        /// 报警ID
        /// </summary>
        public long ID { get; set; }
        /// <summary>
        /// 获取或设置报警发生时间
        /// </summary>
        public DateTime AlarmDateTime { get; set; }
        /// <summary>
        /// 获取或设置报警说明
        /// </summary>
        public string AlarmDescr { get; set; }
        /// <summary>
        /// 获取或设置报警操作员
        /// </summary>
        public string OperatorID { get; set; }
        #endregion

        #region 公共方法
        public Alarm Clone()
        {
            return this.MemberwiseClone() as Alarm;
        }
        #endregion
    }
}
