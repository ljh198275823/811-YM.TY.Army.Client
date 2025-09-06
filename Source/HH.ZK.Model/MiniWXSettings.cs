using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HH.ZK.Model
{
    public class MiniWXSettings
    {
        public DateTime? ReservableBeginDate { get; set; }

        public DateTime? ReservableEndDate { get; set; }

        public List<PhysicalGroup> PhysicalGroups { get; set; }

        public DateTime? QueryTotalBeginDate { get; set; }

        public DateTime? QueryTotalEndDate { get; set; }
    }

    public class PhysicalGroup
    {
        public string Name { get; set; }
        public int ReserveCount { get; set; }
        public string Items { get; set; }
    }
}
