using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.IO;
using System.Xml;
using HH.ZK.Model;
using LJH.GeneralLibrary;
using Newtonsoft.Json;

namespace HH.ZK.WebAPIClient
{
    /// <summary>
    ///用于从SysParameter表中保存或获取一些系统设置,这些设置的实例被序列化为XML字串保存在ParameterValue字段中
    /// </summary>
    public class SysParaSettingsClient
    {
        /// <summary>
        ///保存到数据库
        /// </summary>
        /// <param name="info"></param>
        public static CommandResult SaveSetting<T>(T info, string repUri, string ownerID) where T : class
        {
            try
            {
                Type t = typeof(T);
                SysParameter para = new SysParameter()
                {
                    ID = string.IsNullOrEmpty(ownerID) ? t.Name : t.Name + "_" + ownerID,
                    Name = t.Name,
                    ProjectID = ownerID,
                    Value = JsonConvert.SerializeObject(info),
                };
                return new APIClient(repUri).Add<string, SysParameter>(para, null);
            }
            catch (Exception ex)
            {
                ExceptionPolicy.HandleException(ex);
                return new CommandResult(ResultCode.Fail, ex.Message);
            }
        }

        /// <summary>
        /// 从数据库中获取对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T GetSetting<T>(string repUri, string projectID) where T : class
        {
            try
            {
                SysParameter para = null;
                QueryResult<SysParameter> result = null;

                Type t = typeof(T);
                string id = string.IsNullOrEmpty(projectID) ? t.Name : t.Name + "_" + projectID;
                result = new APIClient(repUri).GetByID<string, SysParameter>(id, null);

                if (result.QueryObject != null)
                {
                    para = result.QueryObject;
                    string value = para.Value;
                    if (!string.IsNullOrEmpty(value))
                    {
                        return JsonConvert.DeserializeObject<T>(value);
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionPolicy.HandleException(ex);
            }
            return null;
        }

        /// <summary>
        /// 从持久层获取设置，如果不存在就创建一个
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T GetOrCreateSetting<T>(string repUri, string projectID) where T : class, new()
        {
            T t = GetSetting<T>(repUri, projectID);

            if (t == null)
            {
                t = new T();
            }
            return t;
        }
    }
}
