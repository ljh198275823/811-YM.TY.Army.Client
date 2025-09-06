using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using Newtonsoft.Json;
using HH.ZK.Model;
using LJH.GeneralLibrary;

namespace HH.ZK.UI.瑞致和
{
    public class RZH接口Client
    {
        #region 构造函数
        public RZH接口Client(string url)
        {
            this.BaseUrl = url;
        }
        #endregion

        #region 公共属性
        public string BaseUrl { get; set; }
        #endregion

        #region 私有方法
        private string Get体测成绩Json(StudentScore score, int serIndex, string name)
        {
            var items = (from it in new List<StudentScore>() { score }
                         select new
                         {
                             xsbm = it.StudentID,
                             xsxm = name,
                             xmno = it.PhysicalItemID.ToString(),
                             xmcj = 获取襄阳格式成绩(it),
                             xh = serIndex,
                             kszt = 获取襄阳成绩状态(it),
                             kssj = it.TestTime.ToString("yyyy-MM-dd HH:mm:ss")
                         }
                         ).ToArray();
            if (items != null && items.Length > 0) return JsonConvert.SerializeObject(items);
            return null;
        }

        public static string 获取襄阳格式成绩(StudentScore score)
        {
            if (score.SpecialType.HasValue) return string.Empty;
            var pi = score.PhysicalItemID;
            if (score.PhysicalItemID == 10 || score.PhysicalItemID == 11 || score.PhysicalItemID == 9) //中长跑传到秒
            {
                return score.RawScore.Trim().ToString();
            }
            return score.FormatScore;
        }

        public static int 获取襄阳成绩状态(StudentScore score)
        {
            if (score.SpecialType.HasValue)
            {
                if (score.SpecialType == SpecialScoreType.犯规) return 1;
                else if (score.SpecialType == SpecialScoreType.弃考) return 2;
                else if (score.SpecialType == SpecialScoreType.未完成) return 3;
                return 2;
            }
            return 0;
        }
        #endregion

        #region 学生体测接口
        public QueryResultList<RZH学校信息> 获取学校信息(string jh_no)
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    string url = BaseUrl.TrimEnd('/') + "/downLoadSchoolInfo";
                    client.Headers.Add("accept", "application/json");
                    client.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
                    var content = string.Format("jhbh={0}", jh_no);
                    var retBytes = client.UploadData(url, "POST", ASCIIEncoding.UTF8.GetBytes(content));
                    var ret = JsonConvert.DeserializeObject<RZH获取学校Response>(ASCIIEncoding.UTF8.GetString(retBytes));
                    return new QueryResultList<RZH学校信息>(ResultCode.Successful, null, ret.body);
                }
            }
            catch (Exception ex)
            {
                LJH.GeneralLibrary.ExceptionPolicy.HandleException(ex);
                return new QueryResultList<RZH学校信息>(ResultCode.Fail, ex.Message, null);
            }
        }

        public RZH获取学生Response 分页获取学生(string jh_no, string jgdm, int pageIndex, string includePhoto)
        {
            using (WebClient client = new WebClient())
            {
                string url = BaseUrl.TrimEnd('/') + "/downLoadStudentInfo";
                client.Headers.Add("accept", "application/json");
                client.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
                var content = $"devtype=HXHH&jhbh={jh_no}&jgdm={jgdm}&dlfaceimg={includePhoto}&currentpage={pageIndex}";
                var retBytes = client.UploadData(url, "POST", ASCIIEncoding.UTF8.GetBytes(content));
                var ret = JsonConvert.DeserializeObject<RZH获取学生Response>(ASCIIEncoding.UTF8.GetString(retBytes));
                return ret;
            }
        }

        public CommandResult 上传成绩(string jh_no, StudentScore score, int serIndex, string name)
        {
            var json = Get体测成绩Json(score, serIndex, name);
            try
            {
                using (WebClient client = new WebClient())
                {
                    string url = BaseUrl.TrimEnd('/') + "/uploadTestResult";
                    client.Headers.Add("accept", "application/json");
                    client.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
                    var content = string.Format("jhbh={0}&devtype=HXHH&devno={1}&cjJson={2}", jh_no, score.DeviceSn ?? "0000", json);
                    var retBytes = client.UploadData(url, "POST", ASCIIEncoding.UTF8.GetBytes(content));
                    var rStr = ASCIIEncoding.UTF8.GetString(retBytes);
                    var ret = JsonConvert.DeserializeObject<RZH接口Response>(rStr);
                    if (ret.ret != 0) LJH.GeneralLibrary.FileLog.Log("襄阳接口", string.Format(@"发送内容:{0}\n 返回：{1}", json, rStr));
                    if (ret.ret == 0) return new CommandResult(ResultCode.Successful, null);
                    return new CommandResult(ResultCode.Fail, ret.msg);
                }
            }
            catch (Exception ex)
            {
                LJH.GeneralLibrary.ExceptionPolicy.HandleException(ex);
                return new CommandResult(ResultCode.Fail, ex.Message);
            }
        }
        #endregion
    }

    internal class RZH接口Response
    {
        public int ret { get; set; }

        public string msg { get; set; }

        public object body { get; set; }
    }

    public class RZH获取学校Response
    {
        public int ret { get; set; }

        public string msg { get; set; }

        public List<RZH学校信息> body { get; set; }
    }

    public class RZH学校信息
    {
        [JsonProperty(PropertyName = "jgdm")]
        public string ID { get; set; }

        [JsonProperty(PropertyName = "jgmc")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "fjdm")]
        public string DivisionID { get; set; }

        [JsonProperty(PropertyName = "fjmc")]
        public string DivisionName { get; set; }
    }

    public class RZH获取学生Response
    {
        public int ret { get; set; }

        public string msg { get; set; }

        public RZH学生分页信息 body { get; set; }
    }

    public class RZH学生分页信息
    {
        public int pages { get; set; }

        public int currentpage { get; set; }

        public List<RZH学生信息> list { get; set; }
    }

    public class RZH学生信息
    {
        [JsonProperty(PropertyName = "xxmc")]
        public string 学校名称 { get; set; }

        [JsonProperty(PropertyName = "xsbm")]
        public string 考生号 { get; set; }

        [JsonProperty(PropertyName = "xm")]
        public string 姓名 { get; set; }

        [JsonProperty(PropertyName = "xb")]
        public string 性别 { get; set; }

        [JsonProperty(PropertyName = "njbm")]
        public int 年级编码 { get; set; }

        [JsonProperty(PropertyName = "bjbh")]
        public string 班级编号 { get; set; }

        [JsonProperty(PropertyName = "bjmc")]
        public string 班级名称 { get; set; }

        [JsonProperty(PropertyName = "xskh")]
        public string 卡号 { get; set; }

        [JsonProperty(PropertyName = "csxm")]
        public string 测试项目 { get; set; }

        [JsonProperty(PropertyName = "xstxbase64")]
        public string 考生相片 { get; set; }
    }
}
