using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HH.ZK.Model.SearchCondition
{
    public class StudentWithDXCJSearchCondition : StudentSearchCondition
    {
        public int? PhysicalItem { get; set; }

        public bool? HasScore { get; set; }

        public ScoreRank? ScoreRank { get; set; }

        public bool? OverCount { get; set; }

        public bool? OverCountHandled { get; set; }

        public bool? ScoreUploaded { get; set; } //获取或设置是否已经上传到第三方平台
    }
}
