using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HH.ZK.Model.CRM
{
    public class UserSearchCondition : LJH.GeneralLibrary.SearchCondition
    {
        public string NameOrMobile { get; set; }
    }
}
