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
        public Sex Sex { get; set; }
        /// <summary>
        /// 获取或设置学生的年级编号
        /// </summary>
        public int Grade { get; set; }
        /// <summary>
        /// 获取或设置学生状态
        /// </summary>
        public StudentState State { get; set; }
        /// <summary>
        /// 获取或设置考试科目
        /// </summary>
        public string PhysicalItems { get; set; }
        /// <summary>
        /// 获取或设置学生的平时成绩
        /// </summary>
        public decimal JiaFen { get; set; }
        /// <summary>
        /// 获取或设置更新时间
        /// </summary>
        public DateTime UpdateDate { get; set; }
        /// <summary>
        /// 获取或设置身份证号
        /// </summary>
        public string IDNumber { get; set; }
        /// <summary>
        /// 获取或设置学生卡号
        /// </summary>
        public string CardID { get; set; }
        /// <summary>
        /// 获取或设置学生的班级名称
        /// </summary>
        public string ClassName { get; set; }
        /// <summary>
        /// 获取或设置院系ID
        /// </summary>
        public string FacilityID { get; set; }
        /// <summary>
        /// 获取或设置学校代码
        /// </summary>
        public string SchoolCode { get; set; }
        /// <summary>
        /// 获取或设置检录时间
        /// </summary>
        public DateTime? CheckTime { get; set; }
        /// <summary>
        /// 获取或设置体温
        /// </summary>
        public decimal? Temperature { get; set; }

        /// <summary>
        /// 获取或设置上传到第三方平台时间
        /// </summary>
        public DateTime? UploadTime { get; set; }
        /// <summary>
        /// 获取或设置上传到第三方平台结果描述
        /// </summary>
        public string UploadMsg { get; set; }
        #endregion

        #region 其它属性
        /// <summary>
        /// 是否带有照片
        /// </summary>
        public bool HasPhoto { get; set; }
        /// <summary>
        /// 获取或设置院系名称
        /// </summary>
        public string FacilityName { get; set; }
        /// <summary>
        /// 获取或设置区域ID
        /// </summary>
        public string DivisionID { get; set; }
        /// <summary>
        /// 获取或设置区域名称
        /// </summary>
        public string DivisionName { get; set; }
        /// <summary>
        /// 获取或设置学生分组，多个分组之间用逗号隔开
        /// </summary>
        public string Groups { get; set; }
        /// <summary>
        /// 获取或设置道次
        /// </summary>
        public int? Channel { get; set; }
        #endregion

        #region 学生考试科目相关
        public List<int> 获取所有考试科目()
        {
            if (!string.IsNullOrEmpty(this.PhysicalItems))
            {
                var strs = this.PhysicalItems.Split(',');
                if (strs != null && strs.Length > 0) return strs.Select(it => int.Parse(it)).ToList();
            }
            return null;
        }

        public bool 包函考试科目(int pid)
        {
            var temp = 获取所有考试科目();
            if (temp == null || temp.Count == 0) return false;
            return temp.Exists(it => it == pid);
        }

        public void 增加考试科目(int pid)
        {
            var ret = 获取所有考试科目();
            if (ret == null) ret = new List<int>();
            if (!ret.Contains(pid)) ret.Add(pid);
            this.PhysicalItems = string.Join(",", ret.Select(it => it.ToString()));
        }
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
