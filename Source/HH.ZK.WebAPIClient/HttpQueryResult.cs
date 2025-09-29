using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HH.ZK.WebAPIClient
{
    public class HttpQueryResult<T>
    {
        #region 构造函数
        public HttpQueryResult()
        {
        }

        public HttpQueryResult(HttpResultCode code, string msg, T obj)
        {
            this.Result = code;
            this.Message = msg;
            this.QueryObject = obj;
        }
        #endregion

        #region 公共属性
        /// <summary>
        ///获取或设置执行结果
        /// </summary>
        public HttpResultCode Result { get; set; }
        /// <summary>
        /// 获取或设置执行结果的文字描述
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// 获取或设置返回的查询对象
        /// </summary>
        public T QueryObject { get; set; }
        #endregion
    }
}
