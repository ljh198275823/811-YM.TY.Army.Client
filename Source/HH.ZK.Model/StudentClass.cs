using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.ZK.Model
{
    public class StudentClass : LJH.GeneralLibrary.IEntity<long>
    {
        public StudentClass()
        {
        }

        #region 公共属性
        /// <summary>
        /// 获取或设置ID
        /// </summary>
        public long ID { get; set; }
        /// <summary>
        /// 获取或设置名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 获取或设置学校编号
        /// </summary>
        public string FacilityID { get; set; }
        #endregion
    }
}
