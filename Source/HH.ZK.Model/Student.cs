using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using Newtonsoft.Json;

namespace HH.ZK.Model
{
    /// <summary>
    /// 表示学生
    /// </summary>
    public class Student : LJH.GeneralLibrary.IEntity<string>
    {
        #region 构造函数
        public Student() { }
        #endregion

        #region 公共属性
        /// <summary>
        /// 获取或设置学号
        /// </summary>
        public string ID { get; set; }
        /// <summary>
        /// 获取或设置姓名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 获取或设置学生姓别
        /// </summary>
        public Gender Gender { get; set; }
        /// <summary>
        /// 获取或设置学生的年级编号
        /// </summary>
        public int Grade { get; set; }
        /// <summary>
        /// 获取或设置学生状态
        /// </summary>
        public StudentState State { get; set; }
        /// <summary>
        /// 获取或设置区域ID
        /// </summary>
        public Guid DivisionID { get; set; }
        /// <summary>
        /// 获取或设置身份证号
        /// </summary>
        public string IDNumber { get; set; }
        /// <summary>
        /// 获取或设置学生卡号
        /// </summary>
        public string CardID { get; set; }

        public string ClassName { get; set; }
        /// <summary>
        /// 获取或设置出生日期
        /// </summary>
        public DateTime? BirthDay { get; set; }
        #endregion

        #region 其它属性
        /// <summary>
        /// 是否带有照片
        /// </summary>
        public bool HasPhoto { get; set; }
        
        /// <summary>
        /// 获取或设置区域名称
        /// </summary>
        public string DivisionName { get; set; }
        #endregion

        #region 扩展属性
        /// <summary>
        ///获取或设置扩展信息
        /// </summary>
        public string Note { get; set; }

        private Dictionary<string, string> _Externals = null;

        public string GetProperty(string key)
        {
            if (_Externals == null && !string.IsNullOrEmpty(Note)) _Externals = JsonConvert.DeserializeObject<Dictionary<string, string>>(Note);
            if (_Externals == null) return null;
            if (_Externals.ContainsKey(key.ToString())) return _Externals[key.ToString()];
            return null;
        }

        public void SetProperty(string key, string value)
        {
            if (_Externals == null && !string.IsNullOrEmpty(Note)) _Externals = JsonConvert.DeserializeObject<Dictionary<string, string>>(Note);
            if (_Externals == null) _Externals = new Dictionary<string, string>();
            if (value == null && _Externals.ContainsKey(key.ToString())) _Externals.Remove(key.ToString());
            else _Externals[key.ToString()] = value;
            Note = JsonConvert.SerializeObject(_Externals);
        }
        #endregion

        #region 公共方法
        /// <summary>
        /// 克隆一个复本
        /// </summary>
        /// <returns></returns>
        public Student Clone()
        {
            var ret = this.MemberwiseClone() as Student;
            ret._Externals = null;
            return ret;
        }
        #endregion
    }
}
