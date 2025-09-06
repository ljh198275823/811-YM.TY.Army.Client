using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HH.ZK.Model.SearchCondition
{
    public class StandardSearchCondition : LJH.GeneralLibrary.SearchCondition
    {
        public int? Grade { get; set; }

        public int? PhysicalItem { get; set; }

        public Sex? Sex { get; set; }

        public bool? IsForJiaFen { get; set; }
    }
}
