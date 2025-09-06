using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HH.ZK.Model.CRM
{
    public class UserPermissionSearchCondition : LJH.GeneralLibrary.SearchCondition
    {
        public string UserID { get; set; }

        public string ProjectID { get; set; }

        public HHModules? Module { get; set; }
    }
}
