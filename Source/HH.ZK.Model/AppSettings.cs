using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Forms;

namespace HH.ZK.Model
{
    public class AppSettings
    {
        public static AppSettings Current
        {
            get
            {
                if (_instance == null)
                    _instance = new AppSettings(Path.Combine(Application.StartupPath, "config.xml"));
                return _instance;
            }
        }

        #region 私有变量
        private static AppSettings _instance = null;
        private XmlDocument _doc = null;
        private XmlNode _parent = null;
        private string _path;
        #endregion

        #region 构造函数
        public AppSettings(string path)
        {
            if (File.Exists(path))
            {
                try
                {
                    _path = path;
                    this._doc = new XmlDocument();
                    this._doc.Load(_path);
                    _parent = this._doc.SelectSingleNode("configuration/appSettings");
                }
                catch
                {
                }
            }
        }
        #endregion

        #region 公共属性
        /// <summary>
        /// 获取数据库连接接字符串
        /// </summary>
        public string CRMUrl
        {
            get
            {
                //return "http://localhost:8080/api";
                return "http://106.52.238.226:8080/api";
            }
        }

        /// <summary>
        /// 获取数据库连接接字符串
        /// </summary>
        public string ConnStr
        {
            get
            {
                //return "http://localhost:8080/api";
                return "http://106.52.238.226:8080/api";
            }
        }
        /// <summary>
        /// 获取本地数据库连接字符串
        /// </summary>
        public string LocalDB
        {
            get
            {
                return $"SQLITE:Data Source={Path.Combine(Application.StartupPath, "HHRawScore.db")}";
            }
        }
        /// <summary>
        /// 获取或设置主机连接的串口
        /// </summary>
        public byte HostCommport
        {
            get
            {
                var temp = GetConfigContent("HostCommport");
                byte ret = 0;
                if (!string.IsNullOrEmpty(temp) && byte.TryParse(temp, out ret)) return ret;
                return 0;
            }
            set
            {
                SaveConfig("HostCommport", value.ToString());
            }
        }
        /// <summary>
        /// 获取或设置读卡器连接的串口
        /// </summary>
        public byte CardReaderCommport
        {
            get
            {
                var temp = GetConfigContent("CardReaderCommport");
                byte ret = 0;
                if (!string.IsNullOrEmpty(temp) && byte.TryParse(temp, out ret)) return ret;
                return 0;
            }
            set
            {
                SaveConfig("CardReaderCommport", value.ToString());
            }
        }
        /// <summary>
        /// 获取或设置条码枪的串口
        /// </summary>
        public byte BarcodeReaderCommport
        {
            get
            {
                var temp = GetConfigContent("BarcodeReaderCommport");
                byte ret = 0;
                if (!string.IsNullOrEmpty(temp) && byte.TryParse(temp, out ret)) return ret;
                return 0;
            }
            set
            {
                SaveConfig("BarcodeReaderCommport", value.ToString());
            }
        }
        /// <summary>
        /// 获取或设置学生成绩单模板路径
        /// </summary>
        public string ScorebillModal
        {
            get
            {
                return GetConfigContent("ScorebillModal");
            }
            set
            {
                SaveConfig("ScorebillModal", value);
            }
        }
        /// <summary>
        /// 获取或设置是否启用TTS语音
        /// </summary>
        public bool EnableTTS
        {
            get
            {
                bool ret = false;
                string temp = GetConfigContent("EnableTTS");
                if (!string.IsNullOrEmpty(temp))
                {
                    bool.TryParse(temp, out ret);
                }
                return ret;
            }
            set
            {
                SaveConfig("EnableTTS", value.ToString());
            }
        }

        /// <summary>
        /// 获取或设置本地视频文件夹
        /// </summary>
        public string VideoPath
        {
            get
            {
                var temp = GetConfigContent("VideoPath");
                if (string.IsNullOrEmpty(temp) || System.IO.Directory.Exists(temp) == false) return System.IO.Path.Combine(Application.StartupPath, "Videos");
                return temp;
            }
            set
            {
                SaveConfig("VideoPath", value.ToString());
            }
        }
        /// <summary>
        /// 获取或设置最后一次登录ID
        /// </summary>
        public string LastLogin
        {
            get
            {
                var temp = GetConfigContent("LastLogin");
                return temp;
            }
            set
            {
                SaveConfig("LastLogin", value.ToString());
            }
        }

        public bool SaveConfig(string configName, string configContent)
        {
            if (_parent != null)
            {
                try
                {
                    XmlElement add = null;
                    XmlAttribute key = null;
                    XmlAttribute value = null;
                    XmlNodeList nodeList = _parent.ChildNodes;
                    foreach (XmlNode xn in nodeList)
                    {
                        if (xn is XmlElement)
                        {
                            XmlElement xe = (XmlElement)xn;
                            if (xe.GetAttribute("key") == configName)
                            {
                                xe.SetAttribute("value", configContent);
                                add = xe;
                                break;
                            }
                        } // end if
                    }
                    if (add == null)
                    {
                        add = _doc.CreateElement("add");
                        key = _doc.CreateAttribute("key");
                        key.Value = configName;
                        value = _doc.CreateAttribute("value");
                        value.Value = configContent;

                        add.Attributes.Append(key);
                        add.Attributes.Append(value);
                        _parent.AppendChild(add);
                    }
                    this._doc.Save(_path.ToString());
                    return true;
                }
                catch (Exception ex)
                {
                    LJH.GeneralLibrary.ExceptionPolicy.HandleException(ex);
                }
            }
            return false;
        }

        public string GetConfigContent(string configName)
        {
            if (_parent != null)
            {
                try
                {
                    XmlNodeList nodeList = _parent.ChildNodes;
                    foreach (XmlNode xn in nodeList)
                    {
                        if (xn is XmlElement)
                        {
                            XmlElement xe = (XmlElement)xn;
                            if (xe.GetAttribute("key") == configName)
                            {
                                return xe.GetAttribute("value");
                            }
                        } // end if
                    }
                }
                catch (Exception ex)
                {
                    LJH.GeneralLibrary.ExceptionPolicy.HandleException(ex);
                }
            }
            return "";
        }
        #endregion

        #region 运行时属性
        public string AppName { get; set; }
        /// <summary>
        /// 获取或设置当前测试计划
        /// </summary>
        public Project PhysicalProject { get; set; }

        /// <summary>
        /// 获取或设置当前操作员
        /// </summary>
        public CRM.User Operator { get; set; }
        #endregion
    }
}
