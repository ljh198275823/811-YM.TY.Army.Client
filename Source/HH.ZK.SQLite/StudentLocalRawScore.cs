using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HH.ZK.Model;

namespace HH.ZK.SQLite
{
    public class StudentLocalRawScore : LJH.GeneralLibrary.IEntity<Guid>
    {
        public static StudentLocalRawScore CreateFrom(StudentRawScore score, string projectID)
        {
            return new StudentLocalRawScore()
            {
                ID = score.ID == Guid.Empty ? Guid.NewGuid() : score.ID,
                ProjectID = projectID,
                Key = $"{projectID}_{score.HostSn}_{score.HostID}_{score.ScoreSer}_{score.StudentID}_{score.TestID}_{score.Score}_{score.CreateTime.Value.ToString("yyyyMMddHHmmss")}",
                StudentID = score.StudentID,
                StudentName = score.StudentName,
                Sex = score.Sex,
                TestID = score.TestID,
                Score = score.Score,
                FGCount=score.FGCount,
                CreateTime = score.CreateTime.Value,
                ScoreFrom = score.ScoreFrom,
                HostID = score.HostID,
                HostSn = score.HostSn,
                ScoreSer = score.ScoreSer,
                SpecialType = score.SpecialType,
            };
        }

        public static StudentRawScore CreateScore(StudentLocalRawScore score)
        {
            return new StudentRawScore()
            {
                ID = score.ID,
                StudentID = score.StudentID,
                StudentName = score.StudentName,
                Sex = score.Sex,
                TestID = score.TestID,
                Score = score.Score,
                FGCount=score.FGCount,
                CreateTime = score.CreateTime,
                ScoreFrom = score.ScoreFrom,
                HostID = score.HostID,
                HostSn = score.HostSn,
                ScoreSer = score.ScoreSer,
                SpecialType = score.SpecialType
            };
        }

        #region 构造函数
        public StudentLocalRawScore()
        {
        }
        #endregion

        #region 公共方法
        public Guid ID { get; set; }
        /// <summary>
        /// 获取或设置测试计划ID
        /// </summary>
        public string ProjectID { get; set; }
        /// <summary>
        /// 获取或设置成绩的唯一KEY
        /// </summary>
        public string Key { get; set; }
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
        /// 获取或设置成绩特殊值
        /// </summary>
        public SpecialScoreType? SpecialType { get; set; }
        /// <summary>
        /// 获取或设置测试时间
        /// </summary>
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 获取或设置测试成绩的来源
        /// </summary>
        public ScoreSource ScoreFrom { get; set; }
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

        public DateTime? SyncTime { get; set; }

        public string SyncError { get; set; }
        #endregion
    }
}