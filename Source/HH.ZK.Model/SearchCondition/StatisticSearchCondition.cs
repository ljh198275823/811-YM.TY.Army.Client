using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.ZK.Model.SearchCondition
{
    public class StatisticSearchCondition : StudentSearchCondition
    {
        public bool ByDivision { get; set; }//分区域
        public bool ByFacility { get; set; }//分学校
        public bool BySex { get; set; }//分性别
        public bool ByClass { get; set; }//分班级
        public List<int> PhysicalItemIDs { get; set; }

        public StatisticSearchCondition Clone()
        {
            return this.MemberwiseClone() as StatisticSearchCondition;
        }
    }
}
