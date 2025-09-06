using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.NetworkInformation;
using System.IO;
using Newtonsoft.Json;
using LJH.GeneralLibrary;
using HH.ZK.Model;
using HH.ZK.Model.CRM;

namespace HH.ZK.WebAPIClient
{
    public class APIClient
    {
        #region 构造函数
        public APIClient(string repoUri)
        {
            RepoUri = repoUri;
        }
        #endregion

        #region  公共属性
        /// <summary>
        /// 获取或设置服务器URL
        /// </summary>
        public string RepoUri { get; set; }
        #endregion

        #region 私有方法
        private string GetQueryString(SearchCondition con)
        {
            if (con == null) return null;
            var temp = JsonConvert.SerializeObject(con);
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(temp));
        }

        private string ToQueryString(SearchCondition con)
        {
            if (con != null) return string.Format("q={0}", HttpUtility.UrlEncode(GetQueryString(con), ASCIIEncoding.UTF8));
            return null;
        }

        protected string GetControllerUrl<TEntity>(string projectID)
        {
            if (string.IsNullOrEmpty(projectID)) return RepoUri.TrimEnd('/') + "/" + typeof(TEntity).Name + "s/";
            else return RepoUri.TrimEnd('/') + "/" + projectID + "/" + typeof(TEntity).Name + "s/";
        }

        private int GetTimestamp(DateTime dt)
        {
            DateTime temp = new DateTime(1970, 1, 1);
            long a = (dt.Ticks - temp.Ticks) / 10000000 - 8 * 60 * 60;
            return (int)a;
        }
        #endregion

        #region 公共方法
        /// <summary>
        /// 通过ID获取实体
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public virtual QueryResult<TEntity> GetByID<TID, TEntity>(TID id, string projectID = null) where TEntity : class, IEntity<TID>
        {
            try
            {
                if (InternetPingService.Current != null && InternetPingService.Current.Pingable == false) return new QueryResult<TEntity>(ResultCode.NotConnected, "网络连接失败", null);
                using (var client = new GZipWebClient())
                {
                    if (TokenInfo.Current == null || TokenInfo.Current.NeedNewToken()) CRMAPIClient.GetToken();
                    client.Headers.Add("Authorization", string.Format("{0} {1}", "Bearer", TokenInfo.Current.Token));
                    client.Headers.Add("accept", "application/json;charset=utf-8");
                    string url = GetControllerUrl<TEntity>(projectID) + HttpUtility.UrlEncode(string.Format("{0}", id), ASCIIEncoding.UTF8);
                    var retBytes = client.DownloadData(url);
                    var ret = JsonConvert.DeserializeObject<QueryResult<TEntity>>(ASCIIEncoding.UTF8.GetString(retBytes));
                    return ret;
                }
            }
            catch (Exception ex)
            {
                LJH.GeneralLibrary.ExceptionPolicy.HandleException(ex);
                if (ex is WebException)
                {
                    var wex = ex as WebException;
                    var response = wex.Response as System.Net.HttpWebResponse;
                    if (response != null && response.StatusCode == HttpStatusCode.Unauthorized) TokenInfo.Current = null;  //如果是未授权，则清掉当前Token
                    else return new QueryResult<TEntity>(ResultCode.Fail, ex.Message, null);
                }
                return new QueryResult<TEntity>(ResultCode.Fail, ex.Message, null);
            }
        }
        /// <summary>
        /// 通过查询条件获取指定的实体信息
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public virtual QueryResultList<TEntity> GetList<TID, TEntity>(SearchCondition con, string projectID = null) where TEntity : class, IEntity<TID>
        {
            try
            {
                if (InternetPingService.Current != null && InternetPingService.Current.Pingable == false) return new QueryResultList<TEntity>(ResultCode.NotConnected, "网络连接失败", null);
                using (var client = new GZipWebClient())
                {
                    if (TokenInfo.Current == null || TokenInfo.Current.NeedNewToken()) CRMAPIClient.GetToken();
                    client.Headers.Add("Authorization", string.Format("{0} {1}", "Bearer", TokenInfo.Current.Token));
                    string url = GetControllerUrl<TEntity>(projectID);
                    if (con != null) url += "?" + ToQueryString(con);
                    client.Headers.Add("accept", "application/json;charset=utf-8");
                    client.Headers.Add(System.Net.HttpRequestHeader.AcceptEncoding, "gzip");
                    var retBytes = client.DownloadData(url);
                    var ret = JsonConvert.DeserializeObject<QueryResultList<TEntity>>(ASCIIEncoding.UTF8.GetString(retBytes));
                    return ret;
                }
            }
            catch (Exception ex)
            {
                if (ex is WebException)
                {
                    var wex = ex as WebException;
                    var response = wex.Response as System.Net.HttpWebResponse;
                    if (response != null && response.StatusCode == HttpStatusCode.Unauthorized) TokenInfo.Current = null;  //如果是未授权，则清掉当前Token
                    return new QueryResultList<TEntity>(ResultCode.Fail, ex.Message, new List<TEntity>());
                }
                LJH.GeneralLibrary.ExceptionPolicy.HandleException(ex);
                return new QueryResultList<TEntity>(ResultCode.Fail, ex.Message, new List<TEntity>());
            }
        }
        /// <summary>
        /// 增加实体
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public virtual CommandResult<TEntity> Add<TID, TEntity>(TEntity info, string projectID = null) where TEntity : class, IEntity<TID>
        {
            try
            {
                if (InternetPingService.Current != null && InternetPingService.Current.Pingable == false) return new CommandResult<TEntity>(ResultCode.NotConnected, "网络连接失败", null);
                using (var client = new GZipWebClient())
                {
                    if (TokenInfo.Current == null || TokenInfo.Current.NeedNewToken()) CRMAPIClient.GetToken();
                    client.Headers.Add("Authorization", string.Format("{0} {1}", "Bearer", TokenInfo.Current.Token));
                    string url = GetControllerUrl<TEntity>(projectID);
                    client.Encoding = System.Text.Encoding.UTF8;
                    client.Headers.Add("accept", "application/json;charset=utf-8");
                    client.Headers.Add("content-type", "application/json;charset=utf-8;");
                    var content = JsonConvert.SerializeObject(info);
                    var retBytes = client.UploadData(url, "POST", System.Text.ASCIIEncoding.UTF8.GetBytes(content));
                    var ret = JsonConvert.DeserializeObject<CommandResult<TEntity>>(System.Text.ASCIIEncoding.UTF8.GetString(retBytes));
                    if (ret.Result == ResultCode.Successful && ret.Value != null) info.ID = ret.Value.ID;
                    return ret;
                }
            }
            catch (Exception ex)
            {
                if (ex is WebException)
                {
                    var wex = ex as WebException;
                    var response = wex.Response as System.Net.HttpWebResponse;
                    if (response != null && response.StatusCode == HttpStatusCode.Unauthorized) TokenInfo.Current = null;  //如果是未授权，则清掉当前Token
                    return new CommandResult<TEntity>(ResultCode.Fail, ex.Message, null);
                }
                LJH.GeneralLibrary.ExceptionPolicy.HandleException(ex);
                return new CommandResult<TEntity>(ResultCode.Fail, ex.Message, null);
            }
        }
        /// <summary>
        /// Patch数据
        /// </summary>
        /// <param name="id"></param>
        /// <param name="items"></param>
        /// <returns></returns>
        public virtual CommandResult<TEntity> Patch<TID, TEntity>(TID id, List<UpdateItem<TID>> items, string projectID = null) where TEntity : class, IEntity<TID>
        {
            try
            {
                if (InternetPingService.Current != null && InternetPingService.Current.Pingable == false) return new CommandResult<TEntity>(ResultCode.NotConnected, "网络连接失败", null);
                using (var client = new GZipWebClient())
                {
                    if (TokenInfo.Current == null || TokenInfo.Current.NeedNewToken()) CRMAPIClient.GetToken();
                    client.Headers.Add("Authorization", string.Format("{0} {1}", "Bearer", TokenInfo.Current.Token));
                    string url = GetControllerUrl<TEntity>(projectID) + HttpUtility.UrlEncode(string.Format("{0}", id), ASCIIEncoding.UTF8) + "/";
                    client.Encoding = System.Text.Encoding.UTF8;
                    client.Headers.Add("accept", "application/json;charset=utf-8");
                    client.Headers.Add("content-type", "application/json;charset=utf-8;");
                    var content = JsonConvert.SerializeObject(items);
                    var retBytes = client.UploadData(url, "PATCH", System.Text.ASCIIEncoding.UTF8.GetBytes(content));
                    return JsonConvert.DeserializeObject<CommandResult<TEntity>>(System.Text.ASCIIEncoding.UTF8.GetString(retBytes));
                }
            }
            catch (Exception ex)
            {
                if (ex is WebException)
                {
                    var wex = ex as WebException;
                    var response = wex.Response as System.Net.HttpWebResponse;
                    if (response != null && response.StatusCode == HttpStatusCode.Unauthorized) TokenInfo.Current = null;  //如果是未授权，则清掉当前Token
                    return new CommandResult<TEntity>(ResultCode.Fail, ex.Message, null);
                }
                LJH.GeneralLibrary.ExceptionPolicy.HandleException(ex);
                return new CommandResult<TEntity>(ResultCode.Fail, ex.Message, null);
            }
        }
        /// <summary>
        /// 删除实体
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public virtual CommandResult Delete<TID, TEntity>(TEntity info, string projectID = null) where TEntity : class, IEntity<TID>
        {
            return Delete<TID, TEntity>(info.ID, projectID);
        }
        /// <summary>
        /// 删除实体
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public virtual CommandResult Delete<TID, TEntity>(TID id, string projectID = null) where TEntity : class, IEntity<TID>
        {
            try
            {
                if (InternetPingService.Current != null && InternetPingService.Current.Pingable == false) return new CommandResult(ResultCode.NotConnected, "网络连接失败");
                using (var client = new GZipWebClient())
                {
                    if (TokenInfo.Current == null || TokenInfo.Current.NeedNewToken()) CRMAPIClient.GetToken();
                    client.Headers.Add("Authorization", string.Format("{0} {1}", "Bearer", TokenInfo.Current.Token));
                    string url = GetControllerUrl<TEntity>(projectID) + HttpUtility.UrlEncode(string.Format("{0}", id), ASCIIEncoding.UTF8) + "/";
                    client.Encoding = System.Text.Encoding.UTF8;
                    client.Headers.Add("accept", "application/json;charset=utf-8");
                    client.Headers.Add("content-type", "application/json;charset=utf-8;");
                    var retBytes = client.UploadString(url, "DELETE", string.Empty);
                    if (!string.IsNullOrEmpty(retBytes)) return JsonConvert.DeserializeObject<CommandResult>(retBytes);
                    return new CommandResult(ResultCode.Successful, string.Empty);
                }
            }
            catch (Exception ex)
            {
                if (ex is WebException)
                {
                    var wex = ex as WebException;
                    var response = wex.Response as System.Net.HttpWebResponse;
                    if (response != null && response.StatusCode == HttpStatusCode.Unauthorized) TokenInfo.Current = null;  //如果是未授权，则清掉当前Token
                    return new CommandResult(ResultCode.Fail, ex.Message);
                }
                LJH.GeneralLibrary.ExceptionPolicy.HandleException(ex);
                return new CommandResult(ResultCode.Fail, ex.Message);
            }
        }
        /// <summary>
        /// 批量增加数据
        /// </summary>
        public virtual CommandResult<BatchOptResult<TID, TEntity>> BatchAdd<TID, TEntity>(List<TEntity> items, ImportOption option, string projectID = null) where TEntity : class, IEntity<TID>
        {
            try
            {
                if (InternetPingService.Current != null && InternetPingService.Current.Pingable == false) return new CommandResult<BatchOptResult<TID, TEntity>>(ResultCode.NotConnected, "网络连接失败", null);
                using (var client = new GZipWebClient())
                {
                    if (TokenInfo.Current == null || TokenInfo.Current.NeedNewToken()) CRMAPIClient.GetToken();
                    client.Headers.Add("Authorization", string.Format("{0} {1}", "Bearer", TokenInfo.Current.Token));
                    string url = GetControllerUrl<TEntity>(projectID) + string.Format("batchAdd?option={0}", option);
                    client.Encoding = System.Text.Encoding.UTF8;
                    client.Headers.Add("accept", "application/json;charset=utf-8");
                    client.Headers.Add("content-type", "application/json;charset=utf-8;");
                    var content = JsonConvert.SerializeObject(items);
                    var retBytes = client.UploadData(url, "POST", System.Text.ASCIIEncoding.UTF8.GetBytes(content));
                    var ret = JsonConvert.DeserializeObject<CommandResult<BatchOptResult<TID, TEntity>>>(System.Text.ASCIIEncoding.UTF8.GetString(retBytes));
                    return ret;
                }
            }
            catch (Exception ex)
            {
                if (ex is WebException)
                {
                    var wex = ex as WebException;
                    var response = wex.Response as System.Net.HttpWebResponse;
                    if (response != null && response.StatusCode == HttpStatusCode.Unauthorized) TokenInfo.Current = null;  //如果是未授权，则清掉当前Token
                    return new CommandResult<BatchOptResult<TID, TEntity>>(ResultCode.Fail, ex.Message, null);
                }
                LJH.GeneralLibrary.ExceptionPolicy.HandleException(ex);
                return new CommandResult<BatchOptResult<TID, TEntity>>(ResultCode.Fail, ex.Message, null);
            }
        }
        /// <summary>
        /// 批量更新数据
        /// </summary>
        public virtual CommandResult<BatchOptResult<TID, TEntity>> BatchPatch<TID, TEntity>(List<UpdateItem<TID>> items, string projectID = null) where TEntity : class, IEntity<TID>
        {
            try
            {
                if (InternetPingService.Current != null && InternetPingService.Current.Pingable == false) return new CommandResult<BatchOptResult<TID, TEntity>>(ResultCode.NotConnected, "网络连接失败", null);
                using (var client = new GZipWebClient())
                {
                    if (TokenInfo.Current == null || TokenInfo.Current.NeedNewToken()) CRMAPIClient.GetToken();
                    client.Headers.Add("Authorization", string.Format("{0} {1}", "Bearer", TokenInfo.Current.Token));
                    string url = GetControllerUrl<TEntity>(projectID) + string.Format("batchpatch");
                    client.Encoding = System.Text.Encoding.UTF8;
                    client.Headers.Add("accept", "application/json;charset=utf-8");
                    client.Headers.Add("content-type", "application/json;charset=utf-8;");
                    var content = JsonConvert.SerializeObject(items);
                    var retBytes = client.UploadData(url, "POST", System.Text.ASCIIEncoding.UTF8.GetBytes(content));
                    var ret = JsonConvert.DeserializeObject<CommandResult<BatchOptResult<TID, TEntity>>>(System.Text.ASCIIEncoding.UTF8.GetString(retBytes));
                    return ret;
                }
            }
            catch (Exception ex)
            {
                if (ex is WebException)
                {
                    var wex = ex as WebException;
                    var response = wex.Response as System.Net.HttpWebResponse;
                    if (response != null && response.StatusCode == HttpStatusCode.Unauthorized) TokenInfo.Current = null;  //如果是未授权，则清掉当前Token
                    return new CommandResult<BatchOptResult<TID, TEntity>>(ResultCode.Fail, ex.Message, null);
                }
                LJH.GeneralLibrary.ExceptionPolicy.HandleException(ex);
                return new CommandResult<BatchOptResult<TID, TEntity>>(ResultCode.Fail, ex.Message, null);
            }
        }
        /// <summary>
        /// 批量删除数据
        /// </summary>
        public virtual CommandResult BatchDelete<TID, TEntity>(List<TEntity> items, string projectID = null) where TEntity : class, IEntity<TID>
        {
            return BatchDelete<TID, TEntity>(items.Select(it => it.ID).ToList(), projectID);
        }
        /// <summary>
        /// 批量删除数据
        /// </summary>
        public virtual CommandResult BatchDelete<TID, TEntity>(List<TID> items, string projectID = null) where TEntity : class, IEntity<TID>
        {
            try
            {
                if (InternetPingService.Current != null && InternetPingService.Current.Pingable == false) return new CommandResult(ResultCode.NotConnected, "网络连接失败");
                using (var client = new GZipWebClient())
                {
                    if (TokenInfo.Current == null || TokenInfo.Current.NeedNewToken()) CRMAPIClient.GetToken();
                    client.Headers.Add("Authorization", string.Format("{0} {1}", "Bearer", TokenInfo.Current.Token));
                    string url = GetControllerUrl<TEntity>(projectID) + string.Format("batchDelete");
                    client.Encoding = System.Text.Encoding.UTF8;
                    client.Headers.Add("accept", "application/json;charset=utf-8");
                    client.Headers.Add("content-type", "application/json;charset=utf-8;");
                    var content = JsonConvert.SerializeObject(items);
                    var retBytes = client.UploadData(url, "POST", System.Text.ASCIIEncoding.UTF8.GetBytes(content));
                    var ret = JsonConvert.DeserializeObject<CommandResult>(System.Text.ASCIIEncoding.UTF8.GetString(retBytes));
                    return ret;
                }
            }
            catch (Exception ex)
            {
                if (ex is WebException)
                {
                    var wex = ex as WebException;
                    var response = wex.Response as System.Net.HttpWebResponse;
                    if (response != null && response.StatusCode == HttpStatusCode.Unauthorized) TokenInfo.Current = null;  //如果是未授权，则清掉当前Token
                    return new CommandResult(ResultCode.Fail, ex.Message);
                }
                LJH.GeneralLibrary.ExceptionPolicy.HandleException(ex);
                return new CommandResult(ResultCode.Fail, ex.Message);
            }
        }
        #endregion

        #region 成绩管理相关
        /// <summary>
        /// 批量增加成绩
        /// </summary>
        public virtual CommandResult<BatchOptResult<Guid, StudentScore>> BatchAddScores(List<StudentRawScore> items, ImportOption option, string projectID)
        {
            try
            {
                if (InternetPingService.Current != null && InternetPingService.Current.Pingable == false) return new CommandResult<BatchOptResult<Guid, StudentScore>>(ResultCode.NotConnected, "网络连接失败", null);
                using (var client = new GZipWebClient())
                {
                    if (TokenInfo.Current == null || TokenInfo.Current.NeedNewToken()) CRMAPIClient.GetToken();
                    client.Headers.Add("Authorization", string.Format("{0} {1}", "Bearer", TokenInfo.Current.Token));
                    string url = GetControllerUrl<StudentScore>(projectID) + string.Format("batchAdd?option={0}", option);
                    client.Encoding = System.Text.Encoding.UTF8;
                    client.Headers.Add("accept", "application/json;charset=utf-8");
                    client.Headers.Add("content-type", "application/json;charset=utf-8;");
                    var content = JsonConvert.SerializeObject(items);
                    var retBytes = client.UploadData(url, "POST", System.Text.ASCIIEncoding.UTF8.GetBytes(content));
                    var ret = JsonConvert.DeserializeObject<CommandResult<BatchOptResult<Guid, StudentScore>>>(System.Text.ASCIIEncoding.UTF8.GetString(retBytes));
                    return ret;
                }
            }
            catch (Exception ex)
            {
                if (ex is WebException)
                {
                    var wex = ex as WebException;
                    var response = wex.Response as System.Net.HttpWebResponse;
                    if (response != null && response.StatusCode == HttpStatusCode.Unauthorized) TokenInfo.Current = null;  //如果是未授权，则清掉当前Token
                    return new CommandResult<BatchOptResult<Guid, StudentScore>>(ResultCode.Fail, ex.Message, null);
                }
                LJH.GeneralLibrary.ExceptionPolicy.HandleException(ex);
                return new CommandResult<BatchOptResult<Guid, StudentScore>>(ResultCode.Fail, ex.Message, null);
            }
        }

        /// <summary>
        /// 批量删除数据
        /// </summary>
        public virtual CommandResult BatchDeleteScores(List<StudentPhysicalPair> items, string projectID)
        {
            try
            {
                if (InternetPingService.Current != null && InternetPingService.Current.Pingable == false) return new CommandResult(ResultCode.NotConnected, "网络连接失败");
                using (var client = new GZipWebClient())
                {
                    if (TokenInfo.Current == null || TokenInfo.Current.NeedNewToken()) CRMAPIClient.GetToken();
                    client.Headers.Add("Authorization", string.Format("{0} {1}", "Bearer", TokenInfo.Current.Token));
                    string url = GetControllerUrl<StudentScore>(projectID) + string.Format("batchDeleteV2");
                    client.Encoding = System.Text.Encoding.UTF8;
                    client.Headers.Add("accept", "application/json;charset=utf-8");
                    client.Headers.Add("content-type", "application/json;charset=utf-8;");
                    var content = JsonConvert.SerializeObject(items);
                    var retBytes = client.UploadData(url, "POST", System.Text.ASCIIEncoding.UTF8.GetBytes(content));
                    var ret = JsonConvert.DeserializeObject<CommandResult>(System.Text.ASCIIEncoding.UTF8.GetString(retBytes));
                    return ret;
                }
            }
            catch (Exception ex)
            {
                if (ex is WebException)
                {
                    var wex = ex as WebException;
                    var response = wex.Response as System.Net.HttpWebResponse;
                    if (response != null && response.StatusCode == HttpStatusCode.Unauthorized) TokenInfo.Current = null;  //如果是未授权，则清掉当前Token
                    return new CommandResult(ResultCode.Fail, ex.Message);
                }
                LJH.GeneralLibrary.ExceptionPolicy.HandleException(ex);
                return new CommandResult(ResultCode.Fail, ex.Message);
            }
        }
        #endregion

        #region 检录相关
        /// <summary>
        /// 检录
        /// </summary>
        /// <param name="studentID"></param>
        /// <param name="projectID"></param>
        /// <returns></returns>
        public virtual CommandResult<Student> Check(StudentCheckPara info, string projectID)
        {
            try
            {
                if (InternetPingService.Current != null && InternetPingService.Current.Pingable == false) return new CommandResult<Student>(ResultCode.NotConnected, "网络连接失败", null);
                using (var client = new GZipWebClient())
                {
                    if (TokenInfo.Current == null || TokenInfo.Current.NeedNewToken()) CRMAPIClient.GetToken();
                    client.Headers.Add("Authorization", string.Format("{0} {1}", "Bearer", TokenInfo.Current.Token));
                    string url = GetControllerUrl<Student>(projectID) + string.Format("jianlu");
                    client.Encoding = System.Text.Encoding.UTF8;
                    client.Headers.Add("accept", "application/json;charset=utf-8");
                    client.Headers.Add("content-type", "application/json;charset=utf-8;");
                    var content = JsonConvert.SerializeObject(info);
                    var retBytes = client.UploadData(url, "POST", System.Text.ASCIIEncoding.UTF8.GetBytes(content));
                    var ret = JsonConvert.DeserializeObject<CommandResult<Student>>(System.Text.ASCIIEncoding.UTF8.GetString(retBytes));
                    return ret;
                }
            }
            catch (Exception ex)
            {
                if (ex is WebException)
                {
                    var wex = ex as WebException;
                    var response = wex.Response as System.Net.HttpWebResponse;
                    if (response != null && response.StatusCode == HttpStatusCode.Unauthorized) TokenInfo.Current = null;  //如果是未授权，则清掉当前Token
                    return new CommandResult<Student>(ResultCode.Fail, ex.Message, null);
                }
                LJH.GeneralLibrary.ExceptionPolicy.HandleException(ex);
                return new CommandResult<Student>(ResultCode.Fail, ex.Message, null);
            }
        }

        public virtual CommandResult UndoCheck(List<string> studentIDs, string projectID)
        {
            try
            {
                if (InternetPingService.Current != null && InternetPingService.Current.Pingable == false) return new CommandResult<Student>(ResultCode.NotConnected, "网络连接失败", null);
                using (var client = new GZipWebClient())
                {
                    if (TokenInfo.Current == null || TokenInfo.Current.NeedNewToken()) CRMAPIClient.GetToken();
                    client.Headers.Add("Authorization", string.Format("{0} {1}", "Bearer", TokenInfo.Current.Token));
                    string url = GetControllerUrl<Student>(projectID) + string.Format("undojianlu");
                    client.Encoding = System.Text.Encoding.UTF8;
                    client.Headers.Add("accept", "application/json;charset=utf-8");
                    client.Headers.Add("content-type", "application/json;charset=utf-8;");
                    var content = JsonConvert.SerializeObject(studentIDs);
                    var retBytes = client.UploadData(url, "POST", System.Text.ASCIIEncoding.UTF8.GetBytes(content));
                    var ret = JsonConvert.DeserializeObject<CommandResult>(System.Text.ASCIIEncoding.UTF8.GetString(retBytes));
                    return ret;
                }
            }
            catch (Exception ex)
            {
                if (ex is WebException)
                {
                    var wex = ex as WebException;
                    var response = wex.Response as System.Net.HttpWebResponse;
                    if (response != null && response.StatusCode == HttpStatusCode.Unauthorized) TokenInfo.Current = null;  //如果是未授权，则清掉当前Token
                    return new CommandResult(ResultCode.Fail, ex.Message);
                }
                LJH.GeneralLibrary.ExceptionPolicy.HandleException(ex);
                return new CommandResult(ResultCode.Fail, ex.Message);
            }
        }
        #endregion

        #region 学生照片相关
        public CommandResult<BatchOptResult<string, StudentPhoto>> CreateFeature(List<string> studentIDs, string projectID)
        {
            try
            {
                if (InternetPingService.Current != null && InternetPingService.Current.Pingable == false) return new CommandResult<BatchOptResult<string, StudentPhoto>>(ResultCode.NotConnected, "网络连接失败", null);
                using (var client = new GZipWebClient())
                {
                    if (TokenInfo.Current == null || TokenInfo.Current.NeedNewToken()) CRMAPIClient.GetToken();
                    client.Headers.Add("Authorization", string.Format("{0} {1}", "Bearer", TokenInfo.Current.Token));
                    string url = GetControllerUrl<StudentPhoto>(projectID) + string.Format("createfeature");
                    client.Encoding = System.Text.Encoding.UTF8;
                    client.Headers.Add("accept", "application/json;charset=utf-8");
                    client.Headers.Add("content-type", "application/json;charset=utf-8;");
                    var content = JsonConvert.SerializeObject(studentIDs);
                    var retBytes = client.UploadData(url, "POST", System.Text.ASCIIEncoding.UTF8.GetBytes(content));
                    var ret = JsonConvert.DeserializeObject<CommandResult<BatchOptResult<string, StudentPhoto>>>(System.Text.ASCIIEncoding.UTF8.GetString(retBytes));
                    return ret;
                }
            }
            catch (Exception ex)
            {
                if (ex is WebException)
                {
                    var wex = ex as WebException;
                    var response = wex.Response as System.Net.HttpWebResponse;
                    if (response != null && response.StatusCode == HttpStatusCode.Unauthorized) TokenInfo.Current = null;  //如果是未授权，则清掉当前Token
                    return new CommandResult<BatchOptResult<string, StudentPhoto>>(ResultCode.Fail, ex.Message, null);
                }
                LJH.GeneralLibrary.ExceptionPolicy.HandleException(ex);
                return new CommandResult<BatchOptResult<string, StudentPhoto>>(ResultCode.Fail, ex.Message, null);
            }
        }
        #endregion
    }
}
