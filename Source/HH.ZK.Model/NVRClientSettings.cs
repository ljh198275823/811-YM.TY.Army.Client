using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HH.ZK.Model
{
    public class NVRClientSettings
    {
        public static NVRClientSettings Current { get; set; }

        /// <summary>
        /// NVR品牌 1表示海康威视 2表示大华
        /// </summary>
        public int NVRType { get; set; }
        /// <summary>
        /// NVR IP地址
        /// </summary>
        public string ServerIP { get; set; }

        public int ServerPort { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }
        /// <summary>
        /// 获取或设置成绩与视频的时间延迟
        /// </summary>
        public int DelaySeconds { get; set; }
        /// <summary>
        /// 获取或设置各主机对应的视频通道
        /// </summary>
        public Dictionary<string, string> HostChannels { get; set; }
    }
}
