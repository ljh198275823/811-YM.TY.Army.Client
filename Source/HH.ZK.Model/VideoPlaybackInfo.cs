using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HH.ZK.Model;

namespace HH.ZK.Model
{
    public class VideoPlaybackInfo
    {
        public VideoPlaybackInfo()
        {

        }

        public VideoPlaybackInfo(StudentScore score, PhysicalItem pi, int delaySeconds = 0)
        {
            Score = score;
            PhysicalItem = pi;
            if (!string.IsNullOrEmpty(score.VideoChannels)) VideoChannels = score.VideoChannels.Split(',').Where(it => !string.IsNullOrEmpty(it)).Select(it => int.Parse(it)).ToList();
            DelaySeconds = delaySeconds;
            TimeRange = GetStartTime(pi, score);
        }

        #region 公共属性
        /// <summary>
        /// 获取或设置对应视频通道
        /// </summary>
        public List<int> VideoChannels { get; set; }
        /// <summary>
        /// 获取或设置回放时间段
        /// </summary>
        public LJH.GeneralLibrary.DateTimeRange TimeRange { get; set; }

        public StudentScore Score { get; set; }

        public PhysicalItem PhysicalItem { get; set; }
        /// <summary>
        /// 获取或设置成绩与视频的时间延迟
        /// </summary>
        public int DelaySeconds { get; set; }
        #endregion

        #region 方法
        private LJH.GeneralLibrary.DateTimeRange GetStartTime(PhysicalItem pi, StudentScore score)
        {
            DateTime begin = score.TestTime.AddSeconds(-60);
            DateTime end = score.TestTime.AddSeconds(60);
            if (score.StartTime.HasValue)
            {
                begin = score.StartTime.Value.AddSeconds(-10);
                end = score.TestTime.AddSeconds(10);
            }
            else
            {
                if (pi.Unit.Contains("秒"))//计时类项目
                {
                    begin = score.TestTime.AddSeconds(-(int)(Math.Ceiling(score.RawScore) + 10));
                }
                else if (pi.ID == 10 || pi.ID == 11 || pi.ID == 19 || pi.ID == 20)//中长跑及其它
                {
                    begin = score.TestTime.AddSeconds(-(int)(Math.Ceiling(score.RawScore) + 5));
                }
                else if (pi.ID ==21) //排球
                {
                    begin = score.TestTime.AddSeconds(-120);
                }
                else if (pi.ID == 18 || pi.ID == 12) //一分钟项目
                {
                    begin = score.TestTime.AddSeconds(-120);
                    end = score.TestTime.AddSeconds(240);
                }
            }
            return new LJH.GeneralLibrary.DateTimeRange(begin.AddSeconds(DelaySeconds), end.AddSeconds(DelaySeconds)); //最后要加上误差时间
        }
        #endregion
    }
}
