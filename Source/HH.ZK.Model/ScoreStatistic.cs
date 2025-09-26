using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.ZK.Model
{
    public class ScoreStatistic : LJH.GeneralLibrary.IEntity<Guid>
    {
        public Guid ID { get; set; }

        public StatiticKey Key { get; set; }

        public int TestID { get; set; }

        public string TestName { get; set; }
        /// <summary>
        /// 获取或设置总人数
        /// </summary>
        public int Total { get; set; }
        /// <summary>
        /// 获取或设置完成人数
        /// </summary>
        public int Completed { get; set; }
        /// <summary>
        /// 获取或设置未测试人数
        /// </summary>
        public int NoneTest { get; set; }
        /// <summary>
        /// 获取或设置总成绩
        /// </summary>
        public string TotalScore { get; set; }
        /// <summary>
        /// 获取或设置平均分
        /// </summary>
        public string Average { get; set; }
        /// <summary>
        /// 获取或设置标准差
        /// </summary>
        public string StandardDeviation { get; set; }
        /// <summary>
        /// 获取或设置最高成绩
        /// </summary>
        public string MaxScore { get; set; }
        /// <summary>
        /// 获取或设置最低成绩
        /// </summary>
        public string MinScore { get; set; }
        /// <summary>
        /// 获取或设置平均得分
        /// </summary>
        public decimal AverageResult { get; set; }
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
