using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HH.ZK.Model
{
    public class StudentCheckRecord : LJH.GeneralLibrary.IEntity<Guid>
    {
        #region 构造函数
        public StudentCheckRecord()
        {
        }
        #endregion

        #region 公共属性
        public Guid ID { get; set; }
        /// <summary>
        /// 获取或设置检录时间
        /// </summary>
        public DateTime CheckTime { get; set; }
        /// <summary>
        /// 获取或设置检录学号
        /// </summary>
        public string StudentID { get; set; }
        /// <summary>
        /// 获取或设置检录学生姓名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 获取或设置检录学生学校
        /// </summary>
        public string Facility { get; set; }
        /// <summary>
        /// 获取或设置检录学生性别
        /// </summary>
        public string Sex { get; set; }
        /// <summary>
        /// 获取或设置检录学生组别
        /// </summary>
        public string GroupID { get; set; }
        /// <summary>
        /// 获取或设置检录学生道次
        /// </summary>
        public int? Channel { get; set; }
        /// <summary>
        /// 获取或设置检录结果
        /// </summary>
        public string CheckResult { get; set; }
        /// <summary>
        /// 获取或设置体温
        /// </summary>
        public decimal? Temperature { get; set; }
        /// <summary>
        /// 获取或设置检录操作员
        /// </summary>
        public string Operator { get; set; }
        /// <summary>
        /// 获取或设置扩展信息
        /// </summary>
        public string Memo { get; set; }
        #endregion
    }
}
