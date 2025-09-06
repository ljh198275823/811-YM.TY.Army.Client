using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.ZK.Model
{
    /// <summary>
    /// 表示学生原始成绩记录
    /// </summary>
    public class StudentRawScore : LJH.GeneralLibrary.IEntity<Guid>
    {
        public Guid ID { get; set; }
        /// <summary>
        /// 获取或设置学生学号
        /// </summary>
        public string StudentID { get; set; }
        /// <summary>
        /// 获取或设置学生姓名
        /// </summary>
        public string StudentName { get; set; }
        /// <summary>
        /// 获取或设置学生性别 用男或女表示 
        /// </summary>
        public string Sex { get; set; }
        /// <summary>
        /// 获取或设置测试科目
        /// </summary>
        public int TestID { get; set; }
        /// <summary>
        /// 获取或设置成绩
        /// </summary>
        public decimal? Score { get; set; }
        /// <summary>
        /// 获取或设置犯规次数
        /// </summary>
        public int? FGCount { get; set; }
        /// <summary>
        /// 获取或设置测试时间
        /// </summary>
        public DateTime? CreateTime { get; set; }
        /// <summary>
        /// 获取或设置测试成绩的来源
        /// </summary>
        public ScoreSource ScoreFrom { get; set; }
        /// <summary>
        /// 获取或设置成绩特殊值
        /// </summary>
        public SpecialScoreType? SpecialType { get; set; }
        /// <summary>
        /// 获取或设置主机序列号
        /// </summary>
        public string HostSn { get; set; }
        /// <summary>
        /// 获取或设置主机编号
        /// </summary>
        public int? HostID { get; set; }
        /// <summary>
        /// 获取或设置成绩在主机里面保存的序列号
        /// </summary>
        public int? ScoreSer { get; set; }

        public StudentRawScore Clone()
        {
            return this.MemberwiseClone() as StudentRawScore;
        }
    }
}
