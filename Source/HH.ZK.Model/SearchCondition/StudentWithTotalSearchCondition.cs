using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HH.ZK.Model.SearchCondition
{
    public class StudentWithTotalSearchCondition : StudentSearchCondition
    {
        public ScoreRank? TotalRank { get; set; }

        public List<TestCompleteState> TestStates { get; set; }
    }
}
