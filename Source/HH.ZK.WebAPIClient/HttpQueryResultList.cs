using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HH.ZK.WebAPIClient
{
    /// <summary>
    /// 查询数据返回结果集合
    /// </summary>
    /// <typeparam name="T"></typeparam>
    [Serializable()]
    public class HttpQueryResultList<T>
    {
        #region 构造函数
        public HttpQueryResultList()
        {
        }

        public HttpQueryResultList(HttpResultCode code, string msg, List<T> list, int pageSize = 0, int pageIndex = 1, int totalCount = 0)
        {
            this.Result = code;
            this.Message = msg;
            this.QueryObjects = list;
        }
        #endregion

        #region IQueryResultList<T> 成员

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
        public List<T> QueryObjects { get; set; }
        /// <summary>
        /// 获取或设置每页数据条数,为0时表示返回所有数据
        /// </summary>
        public int PageSize { get; set; }
        /// <summary>
        /// 获取或设置当前页
        /// </summary>
        public int PageIndex { get; set; }
        /// <summary>
        /// 获取或设置查询到的总记录数
        /// </summary>
        public int TotalCount { get; set; }
        #endregion
    }
}
