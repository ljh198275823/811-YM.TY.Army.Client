using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HH.ZK.Model
{
    public class CheckOptions
    {
        public CheckOptions()
        {

        }

        /// <summary>
        /// 获取或设置是否按分组进行检录
        /// </summary>
        public CheckMode CheckMode { get; set; }
    }

    public enum CheckMode
    {
        按分组进行检录 = 0,
        现场分组检录 = 1,
        随机检录 = 2
    }
}
