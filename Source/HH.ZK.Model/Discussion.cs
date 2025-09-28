using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HH.ZK.Model
{
    /// <summary>
    /// 表示成绩仲裁记录
    /// </summary>
    public class Discussion : LJH.GeneralLibrary.IEntity<long>
    {
        #region 构造函数
        public Discussion()
        {
        }
        #endregion

        #region 公共属性
        public long ID { get; set; }
        /// <summary>
        /// 获取或设置编号
        /// </summary>
        public string Number { get; set; }
        /// <summary>
        /// 获取或设置仲裁时间
        /// </summary>
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 获取或设置学生学号
        /// </summary>
        public string StudentID { get; set; }
        /// <summary>
        /// 获取或设置学生姓名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 获取或设置学生学校ID
        /// </summary>
        public string FacilityID { get; set; }
        /// <summary>
        /// 获取或设置学生学校
        /// </summary>
        public string FacilityName { get; set; }
        /// <summary>
        /// 获取或设置考试科目
        /// </summary>
        public int PhysicalItem { get; set; }
        /// <summary>
        /// 获取或设置仲裁的成绩
        /// </summary>
        public string Score { get; set; }
        /// <summary>
        /// 获取或设置仲裁成绩测试时间
        /// </summary>
        public DateTime ScoreTime { get; set; }
        /// <summary>
        /// 获取或设置仲裁内容
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// 获取或设置仲裁结果
        /// </summary>
        public ResolveType ResolveType { get; set; }
        /// <summary>
        /// 获取或设置仲裁后的成绩
        /// </summary>
        public string NewScore { get; set; }
        /// <summary>
        /// 获取或设置审核人员
        /// </summary>
        public string Approver { get; set; }
        /// <summary>
        /// 获取或设置仲裁员
        /// </summary>
        public string Operator { get; set; }
        #endregion
    }

    public enum ResolveType
    {
        当前成绩有效 = 0,
        重考 = 1,
        修改当前成绩 = 2,
        取消当前成绩 = 3,
    }
}
