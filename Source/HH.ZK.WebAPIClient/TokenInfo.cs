using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace HH.ZK.WebAPIClient
{
    internal class TokenInfo
    {
        public static TokenInfo Current { get; set; }

        #region 构造函数
        public TokenInfo()
        {
        }
        #endregion

        #region 公共属性
        public string Token { get; set; }
        /// <summary>
        /// 获取或设置多久后过期，用秒表示
        /// </summary>
        public int ExpireTime { get; set; }

        public string Sign { get; set; }

        public DateTime CreateTime { get; set; }
        #endregion

        public bool NeedNewToken()
        {
            return string.IsNullOrEmpty(Token) || CreateTime.AddSeconds(ExpireTime - 30) < DateTime.Now; //比过期日期提前30秒钟就要开始重新获取TOKEN了
        }
    }
}
