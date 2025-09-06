using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.ZK.Model
{
    /// <summary>
    /// 表示总分统计
    /// </summary>
    public class TotalStatistic : LJH.GeneralLibrary.IEntity<Guid>
    {
        public Guid ID { get; set; }

        public StatiticKey Key { get; set; }
        /// <summary>
        /// 获取或设置总人数
        /// </summary>
        public int Total { get; set; }
        /// <summary>
        /// 获取或设置完成人数
        /// </summary>
        public int Completed { get; set; }
        /// <summary>
        /// 获取或设置未完成人数
        /// </summary>
        public int NotCompleted { get; set; }
        /// <summary>
        /// 获取或设置未测试人数
        /// </summary>
        public int NoneTest { get; set; }
        /// <summary>
        /// 获取或设置平均分
        /// </summary>
        public decimal Average { get; set; }
        /// <summary>
        /// 获取或设置平均分等级
        /// </summary>
        public ScoreRank AverageRank { get; set; }
        /// <summary>
        /// 获取或设置标准差
        /// </summary>
        public decimal StandardDeviation { get; set; }
        /// <summary>
        /// 获取或设置满分人数
        /// </summary>
        public int ManFen { get; set; }
        /// <summary>
        /// 获取或设置满分率
        /// </summary>
        public decimal ManFenRate { get; set; }
        /// <summary>
        /// 获取或设置优秀人数
        /// </summary>
        public int YouXiu { get; set; }
        /// <summary>
        /// 获取或设置优秀率
        /// </summary>
        public decimal YouXiuRate { get; set; }
        /// <summary>
        /// 获取或设置良好人数
        /// </summary>
        public int LiangHao { get; set; }
        /// <summary>
        /// 获取或设置良好率
        /// </summary>
        public decimal LiangHaoRate { get; set; }
        /// <summary>
        /// 获取或设置中等人数
        /// </summary>
        public int ZhongDeng { get; set; }
        /// <summary>
        /// 获取或设置中等率
        /// </summary>
        public decimal ZhongDengRate { get; set; }
        /// <summary>
        /// 获取或设置及格人数
        /// </summary>
        public int JiGe { get; set; }
        /// <summary>
        /// 获取或设置及格率
        /// </summary>
        public decimal JiGeRate { get; set; }
        /// <summary>
        /// 获取或设置不及格人数
        /// </summary>
        public int BuJiGe { get; set; }
        /// <summary>
        /// 获取或设置不及格率
        /// </summary>
        public decimal BuJiGeRate { get; set; }
    }
}
