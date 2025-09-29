using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HH.ZK.WebAPIClient
{
    public enum HttpResultCode
    {
        /// <summary>
        /// 成功
        /// </summary>
        Successful = 200,
        /// <summary>
        ///失败
        /// </summary>
        Fail = 1,
        /// <summary>
        /// 连接失败
        /// </summary>
        NotConnected = 2,
    }
}
