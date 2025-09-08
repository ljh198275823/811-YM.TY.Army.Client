using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HH.ZK.Model
{
    public class StudentGroupSummary : LJH.GeneralLibrary.IEntity<Guid>
    {
        #region 公共属性
        public Guid ID { get; set; }
        /// <summary>
        /// 获取或设置组号
        /// </summary>
        public int Number { get; set; }
        /// <summary>
        /// 获取或设置性别
        /// </summary>
        public Gender? Sex { get; set; }
        /// <summary>
        /// 获取或设置所属学校
        /// </summary>
        public string FacilityID { get; set; }
        /// <summary>
        /// 获取或设置学校名称
        /// </summary>
        public string FacilityName { get; set; }
        /// <summary>
        /// 获取或设置考试科目
        /// </summary>
        public string PhysicalItems { get; set; }
        /// <summary>
        /// 获取或设置考试日期
        /// </summary>
        public string PlanDate { get; set; }
        /// <summary>
        /// 获取或设置学生数量
        /// </summary>
        public virtual int ItemsCount { get; set; }
        #endregion

        #region 公共方法
        public string Name
        {
            get
            {
                if (ID == Guid.Empty) return null;
                return string.Format("{0}{1}{2}{3}组",
                    PlanDate,
                    AppSettings.Current?.PhysicalProject?.PhysicalItems?.GetShortNames(PhysicalItems, string.Empty),
                    Sex == null ? null : (Sex == HH.ZK.Model.Gender.Male ? "男子" : "女子"),
                    Number
                    );
            }
        }

        public string FullName
        {
            get
            {
                if (ID == Guid.Empty) return null;
                return string.Format("{0}{1}{2}{3}{4}组",
                    PlanDate,
                    FacilityName,
                    AppSettings.Current?.PhysicalProject?.PhysicalItems?.GetShortNames(PhysicalItems, string.Empty),
                    Sex == null ? null : (Sex == HH.ZK.Model.Gender.Male ? "男子" : "女子"),
                    Number
                    );
            }
        }

        public bool 包函考试科目(string pids)
        {
            if (string.IsNullOrEmpty(pids)) return true;
            if (string.IsNullOrEmpty(PhysicalItems)) return false;
            var f = pids.Split(',').ToList();
            var temp = PhysicalItems.Split(',').ToList();
            if (temp == null || temp.Count == 0) return false;
            return f.All(it => temp.Exists(t => t == it));
        }

        public List<int> 获取所有考试科目()
        {
            if (!string.IsNullOrEmpty(this.PhysicalItems))
            {
                var strs = this.PhysicalItems.Split(',');
                if (strs != null && strs.Length > 0) return strs.Select(it => int.Parse(it)).ToList();
            }
            return null;
        }
        #endregion
    }
}
