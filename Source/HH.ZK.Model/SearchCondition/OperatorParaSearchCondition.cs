using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HH.ZK.Model.SearchCondition
{
    public class OperatorParaSearchCondition : LJH.GeneralLibrary.SearchCondition
    {
        public string SchoolID { get; set; }

        public string OperatorID { get; set; }

        public ProjectClass? ProjectClass { get; set; }
    }
}
