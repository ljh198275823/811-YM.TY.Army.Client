using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace HH.ZK.Model
{
    public class ProjectOptions
    {
        #region 构造函数
        public ProjectOptions()
        {
            MaxTotal = 100;
            ScoreSelectMode = 0;
            IgnoreFaceFeature = true;
        }
        #endregion

        #region 公共属性
        /// <summary>
        /// 成绩选择模式,0选择得分最高的成绩,1选择最后一次测试的成绩
        /// </summary>
        public int ScoreSelectMode { get; set; }
        /// <summary>
        /// 获取或设置准考证标题
        /// </summary>
        public string CertificateTitle { get; set; }
        /// <summary>
        /// 获取或设置满分
        /// </summary>
        public decimal MaxTotal { get; set; }
        /// <summary>
        /// 获取或设置总分计算方法
        /// </summary>
        public TotalCalType TotalCalType { get; set; }
        /// <summary>
        /// 获取或设置总分的计算公式
        /// </summary>
        public string TotalFormula { get; set; }
        /// <summary>
        /// 获取或设置总分小数位数
        /// </summary>
        public int? TotalPoint { get; set; }
        /// <summary>
        /// 获取或设置总分精度舍入方式，0表示非零进一，1表示四舍五入，2表示直接截取
        /// </summary>
        public int? TotalMode { get; set; }
        /// <summary>
        /// 获取或设置是否可以修改现有成绩
        /// </summary>
        public bool CannotModifyScore { get; set; }
        /// <summary>
        /// 获取或设置视频服务器地址
        /// </summary>
        public string VideoServiceUrl { get; set; }
        /// <summary>
        /// 获取或设置照片是否忽略提取特征值
        /// </summary>
        public bool IgnoreFaceFeature { get; set; }
        #endregion
    }
}
