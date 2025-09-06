using System;
using System.Collections.Generic;
using System.Text;

namespace HH.ZK.Model
{
    public class GlobalSettings
    {
        public static GlobalSettings Current { get; set; }

        /// <summary>
        /// 获取或设置连接字符串
        /// </summary>
        public string ConnStr { get; set; }

        #region 私有变量
        private Dictionary<string, string> _Items = new Dictionary<string, string>();
        #endregion

        #region 公共方法
        public string this[string key]
        {
            get
            {
                if (_Items.ContainsKey(key)) return _Items[key];
                return null;
            }
            set
            {
                _Items[key] = value;
            }
        }
        #endregion
    }
}
