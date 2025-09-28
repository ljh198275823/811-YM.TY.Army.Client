using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LJH.GeneralLibrary;

namespace HH.ZK.Model.SearchCondition
{
    public class DiscussionSearchCondition : LJH.GeneralLibrary.SearchCondition
    {
        public DateTimeRange CreateTime { get; set; }

        public string StudentID { get; set; }

        public string Name { get; set; }

        public long? ScoreID { get; set; }
    }
}
