using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LJH.GeneralLibrary;

namespace HH.ZK.Model.SearchCondition
{
    public class StudentCheckRecordSearchCondition : StudentSearchCondition
    {
        public DateTimeRange CheckTime { get; set; }
        public string Operator { get; set; }
    }
}