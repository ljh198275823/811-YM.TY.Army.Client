using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using LJH.GeneralLibrary;
using Newtonsoft.Json;

namespace HH.ZK.Model
{
    /// <summary>
    /// 表示体能测试项目,比如一次中考,一次全年级的体能测试
    /// </summary>
    public class PhysicalProject : LJH.GeneralLibrary.IEntity<string>
    {
        #region 构造函数
        public PhysicalProject()
        {
        }
        #endregion

        #region 公共属性
        /// <summary>
        /// 获取或设置ID
        /// </summary>
        public string ID { get; set; }
        /// <summary>
        /// 获取或设置类型
        /// </summary>
        public PhysicalProjectClass ProjectClass { get; set; }
        /// <summary>
        /// 获取或设置名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 获取或设置创建日期
        /// </summary>
        public DateTime CreateDate { get; set; }
        /// <summary>
        /// 获取或设置测试年度
        /// </summary>
        public int Year { get; set; }
        /// <summary>
        /// 获取或设置项目的开始日期
        /// </summary>
        public DateTime StartDate { get; set; }
        /// <summary>
        /// 获取或设置项目的结束日期
        /// </summary>
        public DateTime EndDate { get; set; }
        /// <summary>
        /// 获取或设置模板项目
        /// </summary>
        public string TemplateProjectID { get; set; }
        /// <summary>
        /// 获取或设置是否是模板项目
        /// </summary>
        public bool IsTemplate { get; set; }
        /// <summary>
        /// 获取或设置学校ID
        /// </summary>
        public string SchoolID { get; set; }
        /// <summary>
        /// 获取或设置状态
        /// </summary>
        public PhysicalProjectState State { get; set; }
        #endregion

        #region 运行时属性
        /// <summary>
        /// 获取或设置考点选项
        /// </summary>
        [JsonIgnore]
        public PhysicalProjectOptions Options { get; set; }
        /// <summary>
        /// 获取或设置考试科目设置
        /// </summary>
        [JsonIgnore]
        public PhysicalItemSettings PhysicalItems { get; set; }
        /// <summary>
        /// 获取或设置检录选项
        /// </summary>
        [JsonIgnore]
        public CheckOptions CheckOptions { get; set; }
        /// <summary>
        /// 获取或设置学生特殊情况设置
        /// </summary>
        [JsonIgnore]
        public StudentStateSettings StateSettings { get; set; }
        #endregion
    }

    public enum PhysicalProjectState
    {
        正式考试 = 3,
        模拟考试 = 4,
    }

    [Flags]
    public enum PhysicalProjectClass
    {
        汇海中考 = 0x01,
    }
}
