using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LJH.GeneralLibrary;

namespace HH.ZK.Model.SearchCondition
{
    public class AlarmSearchCondition : LJH.GeneralLibrary.SearchCondition
    {
        public DateTimeRange AlarmDateTime { get; set; }
        public string OperatorID { get; set; } //报警来源
    }
}
