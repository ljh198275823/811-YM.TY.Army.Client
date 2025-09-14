using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HH.ZK.Model
{
    public class School : LJH.GeneralLibrary.IEntity<string>
    {
        #region 构造函数
        public School()
        {

        }
        #endregion

        #region 公共属性
        /// <summary>
        /// 学校ID
        /// </summary>
        public string ID { get; set; }
        /// <summary>
        /// 获取或设置学校名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 获取或设置学校可用的项目类型，有中考，体测，抽测，国民等。
        /// </summary>
        public ProjectClass ProjectClass { get; set; }
        /// <summary>
        /// 获取或设置所在城市
        /// </summary>
        public string City { get; set; }
        /// <summary>
        /// 获取或设置最低年级
        /// </summary>
        public int MinGrade { get; set; }
        /// <summary>
        /// 获取或设置最高年级
        /// </summary>
        public int MaxGrade { get; set; }
        /// <summary>
        /// 获取或设置创建日期
        /// </summary>
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 获取或设置最大学生数量
        /// </summary>
        public int? MaxStudentCount { get; set; }
        /// <summary>
        /// 获取或设置是否使用加密狗
        /// </summary>
        public bool? Ukey { get; set; }

        public string URL { get; set; }
        /// <summary>
        /// 获取或设置对接的第三方数据同步平台
        /// </summary>
        public ThirdPlateForm? ThirdSyncPlateForm { get; set; }
        #endregion
    }
}
