using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.IO;
using System.Xml;
using System.Windows.Forms;
using HH.ZK.Model;
using LJH.GeneralLibrary;
using LJH.GeneralLibrary;
using Newtonsoft.Json;

namespace HH.ZK.CommonUI
{
    /// <summary>
    ///用于从SysParameter表中保存或获取一些系统设置,这些设置的实例被序列化为XML字串保存在ParameterValue字段中
    /// </summary>
    public class LocalSysParaSettingsBll
    {
        /// <summary>
        ///保存到数据库
        /// </summary>
        /// <param name="info"></param>
        public static CommandResult SaveSetting<T>(T info, string projectID) where T : class
        {
            try
            {
                Type t = typeof(T);
                var file = Path.Combine(Application.StartupPath, $"{projectID}_{t.Name}.json");
                File.WriteAllText(file, JsonConvert.SerializeObject(info));
                return new CommandResult(ResultCode.Successful, string.Empty);
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
        public static T GetSetting<T>(string projectID) where T : class
        {
            try
            {
                Type t = typeof(T);
                var file = Path.Combine(Application.StartupPath, $"{projectID}_{t.Name}.json");
                if(File.Exists(file))
                {
                    var value = File.ReadAllText(file);
                    if(!string.IsNullOrEmpty (value))
                    {
                        return JsonConvert.DeserializeObject<T>(value);
                    }
                }
                return null;
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
        public static T GetOrCreateSetting<T>(string projectID) where T : class, new()
        {
            T t = GetSetting<T>(projectID);

            if (t == null)
            {
                t = new T();
            }
            return t;
        }
    }
}
