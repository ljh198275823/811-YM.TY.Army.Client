using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HH.ZK.Model;
using LJH.GeneralLibrary;

namespace HH.ZK.SQLite
{
    public class StudentRawScoreSearchCondition : LJH.GeneralLibrary.SearchCondition
    {
        public DateTimeRange DateTimeRange { get; set; }
        public string StudentIDLike { get; set; }
        public string Name { get; set; }
        public int? TestID { get; set; }
        public string ProjectID { get; set; }
        public string HostSN { get; set; }
        public int? SyncState { get; set; }  //0表示未上传，1表示上传并保存成功 2表示上传了但保存失败
    }
}
