using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HH.ZK.Model.SearchCondition
{
    public class StudentGroupSearchCondition : LJH.GeneralLibrary.SearchCondition
    {
        public string FacilityID { get; set; }

        public DateTime? TestTimeFrom { get; set; }
    }
}
