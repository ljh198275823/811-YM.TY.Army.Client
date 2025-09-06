using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace HH.ZK.Model
{
    public class StudentScore : LJH.GeneralLibrary.IEntity<Guid>
    {
        #region 构造函数
        public StudentScore() { }
        #endregion

        #region 公共属性
        public Guid ID { get; set; }
        /// <summary>
        /// 获取或设置学号
        /// </summary>
        public string StudentID { get; set; }
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
        /// 获取或设置原始成绩
        /// </summary>
        public decimal RawScore { get; set; }
        /// <summary>
        /// 获取或设置成绩
        /// </summary>
        public string FormatScore { get; set; }
        /// <summary>
        /// 获取或设置犯规次数
        /// </summary>
        public int? FGCount { get; set; }
        /// <summary>
        /// 获取或设置得分
        /// </summary>
        public decimal? Result { get; set; }
        /// <summary>
        /// 获取或设置加分
        /// </summary>
        public decimal? JiaFen { get; set; }
        /// <summary>
        /// 获取或设置得分等级
        /// </summary>
        public string Rank { get; set; }
        /// <summary>
        /// 获取或设置成绩的优先级
        /// </summary>
        public int Priority { get; set; }
        /// <summary>
        /// 获取或设置特殊成绩类型 目前有缺考,免考,伤病等,特殊成绩类型一般会有一个默认的得分,但没有成绩
        /// </summary>
        public SpecialScoreType? SpecialType { get; set; }
        /// <summary>
        /// 获取或设置上传到第三方平台时间
        /// </summary>
        public DateTime? UploadTime { get; set; }
        /// <summary>
        /// 获取或设置上传到第三方平台结果描述
        /// </summary>
        public string UploadMsg { get; set; }
        /// <summary>
        /// 获取或设置测试开始时间
        /// </summary>
        public DateTime? StartTime { get; set; }
        /// <summary>
        /// 获取或设置对应视频通道
        /// </summary>
        public string VideoChannels { get; set; }
        /// <summary>
        /// 获取或设置备注信息
        /// </summary>
        public string Memo { get; set; }
        #endregion

        #region 汇海主机记录特有字段
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
        #endregion
    }
}
