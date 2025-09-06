using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HH.ZK.Model.SearchCondition
{
    public class PhysicalProjectSearchCondition : LJH.GeneralLibrary.SearchCondition
    {
        public string Name { get; set; }

        public bool IsTemplate { get; set; }
    }
}
