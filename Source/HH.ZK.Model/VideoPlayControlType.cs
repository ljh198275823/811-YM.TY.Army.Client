using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HH.ZK.Model
{
    public enum VideoPlayControlType
    {
        /// <summary>
        /// play
        /// 播放
        /// </summary>
        Play,
        /// <summary>
        /// pause
        /// 暂停
        /// </summary>
        Pause,
        /// <summary>
        /// 继续播放
        /// </summary>
        ReStart,
        /// <summary>
        /// stop
        /// 停止
        /// </summary>
        Stop,
        /// <summary>
        /// fast
        /// 快放
        /// </summary>
        Fast,
        /// <summary>
        /// slow
        /// 慢放
        /// </summary>
        Slow,
        /// <summary>
        /// normal
        /// 正常播放
        /// </summary>
        Normal,
        /// <summary>
        /// 单帧播放
        /// </summary>
        Frame,
        /// <summary>
        /// 打开声音
        /// </summary>
        AudioOn,
        /// <summary>
        /// 关闭声音
        /// </summary>
        AudioOff,
    }
}
