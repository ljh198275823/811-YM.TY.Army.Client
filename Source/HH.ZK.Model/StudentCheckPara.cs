using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.ZK.Model
{
    public class StudentCheckPara
    {
        /// <summary>
        /// 获取或设置学号
        /// </summary>
        public string StudentID { get; set; }
        /// <summary>
        /// 获取或设置检录方式 0 人工确认 1 人脸识别
        /// </summary>
        public int CheckMode { get; set; }
        /// <summary>
        /// 获取或设置体温
        /// </summary>
        public decimal? Temperature { get; set; }
        /// <summary>
        /// 获取或设置检录学生组别
        /// </summary>
        public string GroupName { get; set; }
        /// <summary>
        /// 获取或设置检录学生道次
        /// </summary>
        public int? Channel { get; set; }
    }
}
