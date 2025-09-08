using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HH.ZK.Model
{
    public class StudentScoreLog : LJH.GeneralLibrary.IEntity<Guid>
    {
        #region 构造函数
        public StudentScoreLog()
        {

        }
        #endregion

        #region 公共属性
        /// <summary>
        /// ID
        /// </summary>
        public Guid ID { get; set; }
        /// <summary>
        /// 获取或设置报警发生时间
        /// </summary>
        public DateTime OptTime { get; set; }
        /// <summary>
        /// 获取或设置报警说明
        /// </summary>
        public string OptType { get; set; }
        /// <summary>
        /// 获取或设置报警操作员
        /// </summary>
        public string Operator { get; set; }
        /// <summary>
        /// 获取或设置学号
        /// </summary>
        public string StudentID { get; set; }
        /// <summary>
        /// 获取或设置学生姓名
        /// </summary>
        public string StudentName { get; set; }
        /// <summary>
        /// 获取或设置学生性别
        /// </summary>
        public Gender Sex { get; set; }
        /// <summary>
        /// 获取或设置学生学校名称
        /// </summary>
        public string FacilityName { get; set; }
        /// <summary>
        /// 获取或设置测试项目
        /// </summary>
        public int PhysicalItemID { get; set; }
        /// <summary>
        /// 获取或设置成绩创建时间
        /// </summary>
        public DateTime TestTime { get; set; }
        /// <summary>
        /// 获取或设置测试成绩的来源
        /// </summary>
        public ScoreSource ScoreFrom { get; set; }
        /// <summary>
        /// 获取或设置主机编号
        /// </summary>
        public int? HostID { get; set; }
        /// <summary>
        /// 获取或设置成绩在主机里面保存的序列号
        /// </summary>
        public int? ScoreSer { get; set; }
        /// <summary>
        /// 获取或设置主机序列号
        /// </summary>
        public string DeviceSn { get; set; }
        /// <summary>
        /// 获取或设置成绩
        /// </summary>
        public string Score { get; set; }
        /// <summary>
        /// 获取或设置新成绩
        /// </summary>
        public string NewScore { get; set; }
        /// <summary>
        /// 获取或设置备注
        /// </summary>
        public string Memo { get; set; }
        #endregion
    }
}
