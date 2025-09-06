using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data;
using System.Data.SQLite;
using HH.ZK.Model;
using HH.ZK.CommonUI;
using LJH.GeneralLibrary;
using Newtonsoft.Json;

namespace HH.ZK.UI
{
    public class VideoLocalDBProvider
    {
        public VideoLocalDBProvider(string dbpath)
        {
            DBPath = dbpath;
        }

        public string DBPath { get; set; }

        private string CreateQuery(string studentID, DateTime? date, int physicalItem)
        {
            var sql = "select c._id,b.student_number,c.name as filename,c.size,a.physical_id,c.time_detail,c.direction,d.NAME as kd, c.path,c.camera  " +
                     "from information a inner join student b on a.Student_id = b._id " +
                     "inner join video c on a.video_id = c._id inner join location d on d._id = c.location_id where 1=1 ";
            if (!string.IsNullOrEmpty(studentID)) sql += $" and b.student_number='{studentID}' ";
            if (date.HasValue) sql += $"and c.TIME_ROUGH='{date?.ToString("yyyy-MM-dd")}' ";
            if (physicalItem > 0) sql += $" and a.physical_id={physicalItem} ";
            return sql;
        }

        private QueryResultList<TBVideoItem> 查询视频(string file, string studentID, DateTime? date, int physicalItem)
        {
            try
            {
                List<TBVideoItem> ret = null;
                var conStr = $"Data Source={file}";
                using (var con = new SQLiteConnection(conStr))
                {
                    using (var cmd = new SQLiteCommand(con))
                    {
                        con.Open();
                        cmd.CommandText = CreateQuery(studentID, date, physicalItem);
                        using (var dbreader = cmd.ExecuteReader())
                        {
                            ret = new List<TBVideoItem>();
                            while (dbreader.Read())
                            {
                                var item = new TBVideoItem()
                                {
                                    ID = dbreader.GetInt32(0),
                                    studentId = dbreader.GetString(1),
                                    videoName = dbreader.GetString(2),
                                    videoSize = dbreader.GetInt32(3),
                                    testItemId = dbreader.GetInt32(4),
                                    testTime = dbreader.GetDateTime(5),
                                    cameraLocation = dbreader.GetString(6),
                                    testVenue = dbreader.GetString(7),
                                    videoPathInCamera = dbreader.GetString(8),
                                    cameraIMEI = dbreader.GetString(9),
                                    isSync = 0,
                                };
                                ret.Add(item);
                            }
                        }
                    }
                }
                return new QueryResultList<TBVideoItem>(ResultCode.Successful, string.Empty, ret);
            }
            catch (Exception ex)
            {
                LJH.GeneralLibrary.FileLog.Log("视频查询", ex.Message);
                return new QueryResultList<TBVideoItem>(ResultCode.Fail, ex.Message, null);
            }
        }

        public QueryResultList<TBVideoItem> 查询视频(string studentID, DateTime? date, int physicalItem)
        {
            if (string.IsNullOrEmpty(DBPath)) return new QueryResultList<TBVideoItem>(ResultCode.Fail, "数据文件路径为空", new List<TBVideoItem>());
            if (Directory.Exists(DBPath) == false) return new QueryResultList<TBVideoItem>(ResultCode.Fail, "数据文件夹不存在", new List<TBVideoItem>());
            var files = Directory.GetFiles(DBPath, "*.db");
            if (files != null && files.Length == 0) return new QueryResultList<TBVideoItem>(ResultCode.Fail, "没有找到数据文件", new List<TBVideoItem>());
            Dictionary<string, TBVideoItem> ret = new Dictionary<string, TBVideoItem>();
            foreach (var file in files)
            {
                var temp = 查询视频(file, studentID, date, physicalItem);
                if (temp.QueryObjects != null && temp.QueryObjects.Count > 0)
                {
                    foreach (var item in temp.QueryObjects)
                    {
                        var key = $"{item.studentId}_{item.testItemId}_{item.videoPathInCamera}";
                        if (!ret.ContainsKey(key)) ret.Add(key, item);
                    }
                }
            }
            return new QueryResultList<TBVideoItem>(ResultCode.Successful, string.Empty, ret.Values.ToList());
        }
    }
}
