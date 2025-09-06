using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HH.ZK.Model
{
    public class LogInInfo
    {
        public string SchoolID { get; set; }

        public string MAC { get; set; }

        public string PCName { get; set; }

        public string LocalIP { get; set; }

        public string Client { get; set; }

        public bool Veryfied { get; set; }
    }
}
