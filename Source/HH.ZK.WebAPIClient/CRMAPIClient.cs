using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Web;
using System.Net;
using Newtonsoft.Json;
using LJH.GeneralLibrary;
using HH.ZK.Model;
using HH.ZK.Model.CRM;

namespace HH.ZK.WebAPIClient
{
    public class CRMAPIClient
    {
        private static string _LogID;
        public static string _Password;
        private static ProjectClass _SystemFlag;
        private static string _ClientID;

        #region 私有方法
        private static string GetQueryString(SearchCondition con)
        {
            if (con == null) return null;
            var temp = JsonConvert.SerializeObject(con);
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(temp));
        }

        private static string ToQueryString(SearchCondition con)
        {
            if (con != null) return string.Format("q={0}", HttpUtility.UrlEncode(GetQueryString(con), ASCIIEncoding.UTF8));
            return null;
        }

        protected static string GetControllerUrl<TEntity>()
        {
            var name = typeof(TEntity).Name;
            return AppSettings.Current.ConnStr.TrimEnd('/') + "/" + name + "s/";
        }

        private static int GetTimestamp(DateTime dt)
        {
            DateTime temp = new DateTime(1970, 1, 1);
            long a = (dt.Ticks - temp.Ticks) / 10000000 - 8 * 60 * 60;
            return (int)a;
        }
        #endregion

        #region UKey相关
        /// <summary>
        /// 获取UKey签名数据
        /// </summary>
        /// <param name="ukeyID"></param>
        /// <returns></returns>
        public static QueryResult<UKeySign> GetSign(int ukeyID)
        {
            try
            {
                using (var client = new WebClient())
                {
                    client.Headers.Add("accept", "application/json;charset=utf-8");
                    string url = string.Format("{0}/{1}/{2}/sign/", AppSettings.Current.ConnStr.TrimEnd('/'), "ukeys", ukeyID);
                    var retBytes = client.DownloadData(url);
                    var ret = JsonConvert.DeserializeObject<QueryResult<UKeySign>>(ASCIIEncoding.UTF8.GetString(retBytes));
                    return ret;
                }
            }
            catch (Exception ex)
            {
                LJH.GeneralLibrary.ExceptionPolicy.HandleException(ex);
                return new QueryResult<UKeySign>(ResultCode.Fail, ex.Message, null);
            }
        }

        /// <summary>
        /// 初始化UKey
        /// </summary>
        /// <param name="project"></param>
        /// <param name="softwareType"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public static CommandResult<UKeySign> InitUKey(string project, int softwareType, string data)
        {
            try
            {
                using (var client = new WebClient())
                {
                    string url = string.Format("{0}/{1}/{2}/", AppSettings.Current.ConnStr.TrimEnd('/'), "ukeys", "init");
                    client.Headers.Add("accept", "application/json;charset=utf-8");
                    client.Headers.Add("content-type", "application/json;charset=utf-8;");

                    var content = JsonConvert.SerializeObject(new
                    {
                        Project = project,
                        SoftwareList = softwareType,
                        Data = data
                    });
                    var retBytes = client.UploadData(url, "POST", System.Text.ASCIIEncoding.UTF8.GetBytes(content));
                    var ret = JsonConvert.DeserializeObject<CommandResult<UKeySign>>(System.Text.ASCIIEncoding.UTF8.GetString(retBytes));
                    return ret;
                }
            }
            catch (Exception ex)
            {
                LJH.GeneralLibrary.ExceptionPolicy.HandleException(ex);
                return new CommandResult<UKeySign>(ResultCode.Fail, ex.Message, null);
            }
        }
        #endregion

        #region 账号登录相关
        /// <summary>
        /// 获取TOKEN
        /// </summary>
        /// <returns></returns>
        public static CommandResult GetToken(string logid, string pwd)
        {
            try
            {
                if (InternetPingService.Current != null && InternetPingService.Current.Pingable == false) return new CommandResult(ResultCode.NotConnected, "网络连接失败");
                if (string.IsNullOrEmpty(logid) && string.IsNullOrEmpty(pwd)) return new CommandResult(ResultCode.Fail, "没有提供用户名或密码");
                using (var client = new GZipWebClient())
                {
                    string url = AppSettings.Current.ConnStr.TrimEnd('/') + "/" + "tokens/";
                    client.Encoding = System.Text.Encoding.UTF8;
                    client.Headers.Add("accept", "application/json;charset=utf-8");
                    client.Headers.Add("content-type", "application/json;charset=utf-8;");
                    var ts = GetTimestamp(DateTime.Now);
                    if (string.IsNullOrEmpty(_ClientID)) _ClientID = Guid.NewGuid().ToString();
                    var content = JsonConvert.SerializeObject(new
                    {
                        userid = logid,
                        password = pwd,
                        clientid = _ClientID,
                        mac = LJH.GeneralLibrary.Net.NetTool.GetLocalMAC(),
                    });
                    var retBytes = client.UploadData(url, "POST", System.Text.ASCIIEncoding.UTF8.GetBytes(content));
                    var ret = JsonConvert.DeserializeObject<CommandResult<TokenInfo>>(System.Text.ASCIIEncoding.UTF8.GetString(retBytes));
                    if (ret.Result == ResultCode.Successful && ret.Value != null)
                    {
                        TokenInfo.Current = ret.Value;
                        TokenInfo.Current.CreateTime = DateTime.Now;
                        _LogID = logid;
                        _Password = pwd;
                    }
                    return new CommandResult(ret.Result, ret.Message);
                }
            }
            catch (Exception ex)
            {
                return new CommandResult(ResultCode.Fail, ex.Message);
            }
        }

        public static bool GetToken()
        {
            if (string.IsNullOrEmpty(_LogID)) return false;
            var ret = GetToken(_LogID, _Password);
            return ret.Result == ResultCode.Successful;
        }
        /// <summary>
        /// 发送验证码
        /// </summary>
        /// <param name="mobile"></param>
        /// <returns></returns>
        public static CommandResult SendMobileVerifyCode(string mobile)
        {
            try
            {
                if (InternetPingService.Current != null && InternetPingService.Current.Pingable == false) return new CommandResult(ResultCode.NotConnected, "网络连接失败");
                using (var client = new GZipWebClient())
                {
                    string url = AppSettings.Current.ConnStr.TrimEnd('/') + "/" + "sms/send/";
                    client.Headers.Add("accept", "application/json;charset=utf-8");
                    client.Headers.Add("content-type", "application/json;charset=utf-8;");
                    var content = JsonConvert.SerializeObject(new
                    {
                        Mobile = mobile
                    });
                    var retBytes = client.UploadData(url, "POST", System.Text.ASCIIEncoding.UTF8.GetBytes(content));
                    var ret = JsonConvert.DeserializeObject<CommandResult>(System.Text.ASCIIEncoding.UTF8.GetString(retBytes));
                    return ret;
                }
            }
            catch (Exception ex)
            {
                LJH.GeneralLibrary.ExceptionPolicy.HandleException(ex);
                return new CommandResult(ResultCode.Fail, ex.Message);
            }
        }
        /// <summary>
        /// 检查验证码是否正确
        /// </summary>
        /// <param name="mobile"></param>
        /// <param name="code"></param>
        /// <returns></returns>
        public static CommandResult VerifyCode(string mobile, string code)
        {
            try
            {
                if (InternetPingService.Current != null && InternetPingService.Current.Pingable == false) return new CommandResult(ResultCode.NotConnected, "网络连接失败");
                using (var client = new GZipWebClient())
                {
                    string url = AppSettings.Current.ConnStr.TrimEnd('/') + "/" + "sms/verifycode/";
                    client.Headers.Add("accept", "application/json;charset=utf-8");
                    client.Headers.Add("content-type", "application/json;charset=utf-8;");
                    if (TokenInfo.Current == null || TokenInfo.Current.NeedNewToken()) GetToken();
                    client.Headers.Add("Authorization", string.Format("{0} {1}", "Bearer", TokenInfo.Current.Token));
                    var content = JsonConvert.SerializeObject(new
                    {
                        Mobile = mobile,
                        Code = code,
                    });
                    var retBytes = client.UploadData(url, "POST", System.Text.ASCIIEncoding.UTF8.GetBytes(content));
                    var ret = JsonConvert.DeserializeObject<CommandResult>(System.Text.ASCIIEncoding.UTF8.GetString(retBytes));
                    return ret;
                }
            }
            catch (Exception ex)
            {
                LJH.GeneralLibrary.ExceptionPolicy.HandleException(ex);
                return new CommandResult(ResultCode.Fail, ex.Message);
            }
        }
        /// <summary>
        /// 重置密码
        /// </summary>
        /// <param name="mobile"></param>
        /// <param name="code"></param>
        /// <returns></returns>
        public static CommandResult ResetPassword(string mobile, string code)
        {
            try
            {
                if (InternetPingService.Current != null && InternetPingService.Current.Pingable == false) return new CommandResult(ResultCode.NotConnected, "网络连接失败");
                using (var client = new GZipWebClient())
                {
                    string url = AppSettings.Current.ConnStr.TrimEnd('/') + "/" + "users/resetpwd/";
                    client.Headers.Add("accept", "application/json;charset=utf-8");
                    client.Headers.Add("content-type", "application/json;charset=utf-8;");
                    var content = JsonConvert.SerializeObject(new
                    {
                        Mobile = mobile,
                        Code = code,
                    });
                    var retBytes = client.UploadData(url, "POST", System.Text.ASCIIEncoding.UTF8.GetBytes(content));
                    var ret = JsonConvert.DeserializeObject<CommandResult>(System.Text.ASCIIEncoding.UTF8.GetString(retBytes));
                    return ret;
                }
            }
            catch (Exception ex)
            {
                LJH.GeneralLibrary.ExceptionPolicy.HandleException(ex);
                return new CommandResult(ResultCode.Fail, ex.Message);
            }
        }

        /// <summary>
        /// 登录系统
        /// </summary>
        public static CommandResult<User> LogIn(LogInInfo info)
        {
            try
            {
                if (InternetPingService.Current != null && InternetPingService.Current.Pingable == false) return new CommandResult<User>(ResultCode.Fail, "网络连接失败", null);
                using (var client = new GZipWebClient())
                {
                    string url = AppSettings.Current.ConnStr.TrimEnd('/') + "/" + "login/";
                    client.Headers.Add("accept", "application/json;charset=utf-8");
                    client.Headers.Add("content-type", "application/json;charset=utf-8;");
                    if (TokenInfo.Current == null || TokenInfo.Current.NeedNewToken()) CRMAPIClient.GetToken();
                    client.Headers.Add("Authorization", string.Format("{0} {1}", "Bearer", TokenInfo.Current.Token));
                    var content = JsonConvert.SerializeObject(info);
                    var retBytes = client.UploadData(url, "POST", System.Text.ASCIIEncoding.UTF8.GetBytes(content));
                    var str = System.Text.ASCIIEncoding.UTF8.GetString(retBytes);
                    var ret = JsonConvert.DeserializeObject<CommandResult<User>>(str);
                    return ret;
                }
            }
            catch (Exception ex)
            {
                LJH.GeneralLibrary.ExceptionPolicy.HandleException(ex);
                return new CommandResult<User>(ResultCode.Fail, ex.Message, null);
            }
        }
        /// <summary>
        /// 退出系统
        /// </summary>
        public static CommandResult LogOut(LogInInfo info)
        {
            try
            {
                if (InternetPingService.Current != null && InternetPingService.Current.Pingable == false) return new CommandResult(ResultCode.Fail, "网络连接失败");
                using (var client = new GZipWebClient())
                {
                    string url = AppSettings.Current.ConnStr.TrimEnd('/') + "/" + "logout/";
                    client.Headers.Add("accept", "application/json;charset=utf-8");
                    client.Headers.Add("content-type", "application/json;charset=utf-8;");
                    if (TokenInfo.Current == null || TokenInfo.Current.NeedNewToken()) CRMAPIClient.GetToken();
                    client.Headers.Add("Authorization", string.Format("{0} {1}", "Bearer", TokenInfo.Current.Token));
                    var content = JsonConvert.SerializeObject(info);
                    var retBytes = client.UploadData(url, "POST", System.Text.ASCIIEncoding.UTF8.GetBytes(content));
                    var ret = JsonConvert.DeserializeObject<CommandResult>(System.Text.ASCIIEncoding.UTF8.GetString(retBytes));
                    return ret;
                }
            }
            catch (Exception ex)
            {
                LJH.GeneralLibrary.ExceptionPolicy.HandleException(ex);
                return new CommandResult(ResultCode.Fail, ex.Message);
            }
        }
        #endregion

        #region 公共方法
        /// <summary>
        /// 通过ID获取实体
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static QueryResult<TEntity> GetByID<TID, TEntity>(TID id) where TEntity : class, IEntity<TID>
        {
            try
            {
                if (InternetPingService.Current != null && InternetPingService.Current.Pingable == false) return new QueryResult<TEntity>(ResultCode.NotConnected, "网络连接失败", null);
                using (var client = new GZipWebClient())
                {
                    if (TokenInfo.Current == null || TokenInfo.Current.NeedNewToken()) GetToken();
                    client.Headers.Add("Authorization", string.Format("{0} {1}", "Bearer", TokenInfo.Current.Token));
                    client.Headers.Add("accept", "application/json;charset=utf-8");
                    string url = GetControllerUrl<TEntity>() + HttpUtility.UrlEncode(string.Format("{0}", id), ASCIIEncoding.UTF8);
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
        public static QueryResultList<TEntity> GetList<TID, TEntity>(SearchCondition con) where TEntity : class, IEntity<TID>
        {
            try
            {
                if (InternetPingService.Current != null && InternetPingService.Current.Pingable == false) return new QueryResultList<TEntity>(ResultCode.NotConnected, "网络连接失败", null);
                using (var client = new GZipWebClient())
                {
                    if (TokenInfo.Current == null || TokenInfo.Current.NeedNewToken()) GetToken();
                    client.Headers.Add("Authorization", string.Format("{0} {1}", "Bearer", TokenInfo.Current.Token));
                    string url = GetControllerUrl<TEntity>();
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
        public static CommandResult<TEntity> Add<TID, TEntity>(TEntity info) where TEntity : class, IEntity<TID>
        {
            try
            {
                if (InternetPingService.Current != null && InternetPingService.Current.Pingable == false) return new CommandResult<TEntity>(ResultCode.NotConnected, "网络连接失败", null);
                using (var client = new GZipWebClient())
                {
                    if (TokenInfo.Current == null || TokenInfo.Current.NeedNewToken()) GetToken();
                    client.Headers.Add("Authorization", string.Format("{0} {1}", "Bearer", TokenInfo.Current.Token));
                    string url = GetControllerUrl<TEntity>();
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
        public static CommandResult<TEntity> Patch<TID, TEntity>(TID id, List<UpdateItem<TID>> items) where TEntity : class, IEntity<TID>
        {
            try
            {
                if (InternetPingService.Current != null && InternetPingService.Current.Pingable == false) return new CommandResult<TEntity>(ResultCode.NotConnected, "网络连接失败", null);
                using (var client = new GZipWebClient())
                {
                    if (TokenInfo.Current == null || TokenInfo.Current.NeedNewToken()) GetToken();
                    client.Headers.Add("Authorization", string.Format("{0} {1}", "Bearer", TokenInfo.Current.Token));
                    string url = GetControllerUrl<TEntity>() + HttpUtility.UrlEncode(string.Format("{0}", id), ASCIIEncoding.UTF8) + "/";
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
        public static CommandResult Delete<TID, TEntity>(TEntity info) where TEntity : class, IEntity<TID>
        {
            return Delete<TID, TEntity>(info.ID);
        }
        /// <summary>
        /// 删除实体
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static CommandResult Delete<TID, TEntity>(TID id) where TEntity : class, IEntity<TID>
        {
            try
            {
                if (InternetPingService.Current != null && InternetPingService.Current.Pingable == false) return new CommandResult(ResultCode.NotConnected, "网络连接失败");
                using (var client = new GZipWebClient())
                {
                    if (TokenInfo.Current == null || TokenInfo.Current.NeedNewToken()) GetToken();
                    client.Headers.Add("Authorization", string.Format("{0} {1}", "Bearer", TokenInfo.Current.Token));
                    string url = GetControllerUrl<TEntity>() + HttpUtility.UrlEncode(string.Format("{0}", id), ASCIIEncoding.UTF8) + "/";
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
        #endregion
    }
}
