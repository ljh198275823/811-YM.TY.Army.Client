using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LJH.GeneralLibrary;

namespace HH.ZK.Model.SearchCondition
{
    public class StudentScoreSearchCondition : StudentSearchCondition
    {
        #region 公共属性
        public int? PhysicalItem { get; set; }
        public DateTimeRange DateTimeRange { get; set; }
        public ScoreSource? ScoreFrom { get; set; }
        public string DeviceSN { get; set; }
        public string HostID { get; set; }
        public bool? SpecialScore { get; set; }
        public bool? Uploaded { get; set; } //获取或设置是否已经上传到第三方平台
        public bool? UploadedSuccess { get; set; } //获取或设置是否上传成功
        #endregion
    }
}
