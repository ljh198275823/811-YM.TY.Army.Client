using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HH.ZK.Model
{
    public class VideoItem : LJH.GeneralLibrary.IEntity<long>
    {
        #region 公共属性
        public long ID { get; set; }

        public string ProjectID { get; set; }

        public string StudentID { get; set; }

        public int TestID { get; set; }

        public DateTime TestTime { get; set; }

        public int VideoSize { get; set; }

        public string CameraIMEI { get; set; }

        public string CameraLocation { get; set; }

        public long? VideoID { get; set; }

        public long? ScoreID { get; set; }

        public string VideoPath { get; set; }
        #endregion
    }
}
