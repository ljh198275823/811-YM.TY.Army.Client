using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using Newtonsoft.Json;
using HH.ZK.Model;
using HH.ZK.CommonUI;
using LJH.GeneralLibrary;

namespace HH.ZK.UI.小奔体育
{
    public class 小奔体育接口Client
    {
        #region 构造函数
        public 小奔体育接口Client()
        {
        }

        public 小奔体育接口Client(ThirdPlateFormSettings ts)
        {
            this.BaseUrl = ts.Server;
            this.UserName = ts.User;
            this.Password = ts.Password;
            this.KS_NO = ts.KDNumber;
        }
        #endregion

        #region 公共属性
        public string BaseUrl { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string KS_NO { get; set; }

        public string Token { get; set; }
        #endregion

        #region 私有方法
        public void LogIn()
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    string url = BaseUrl.TrimEnd('/') + "/api/user/softAccountLogin" + $"?account={UserName}&password={Password}";
                    var retBytes = client.DownloadData(url);
                    var ret = JsonConvert.DeserializeObject<小奔体育接口Response<小奔体育用户信息>>(ASCIIEncoding.UTF8.GetString(retBytes));
                    if (ret.code == 200) Token = ret.data.token;
                }
            }
            catch (Exception ex)
            {
                Token = null;
                LJH.GeneralLibrary.ExceptionPolicy.HandleException(ex);
            }
        }

        private string 获取格式成绩(StudentScore score)
        {
            if (score.SpecialType.HasValue) return "0";
            var pi = AppSettings.Current.PhysicalProject.PhysicalItems?.GetPhysicalItem(score.PhysicalItemID);
            if (pi != null)
            {
                //转换成秒
                if (pi.ID == 10 || pi.ID == 11 || pi.ID == 100) return pi.Convert(score.RawScore, 0).ToString(); //800 1000米
            }
            return score.FormatScore;
        }

        private int 获取成绩状态(StudentScore score)
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

        private int 获取汇海项目编号(int pid)
        {
            if (pid == 101) return 11; //1000米
            if (pid == 102) return 10; //800米
            if (pid == 103) return 100; //100米游泳
            if (pid == 104) return 15; //实心球
            if (pid == 105) return 14; //引体向上
            if (pid == 106) return 12;  //一分钟仰卧起坐
            if (pid == 107) return 6;  //立定跳远
            if (pid == 108) return 27;  //三级蛙跳
            if (pid == 109) return 18;  //一分钟跳绳
            if (pid == 110) return 20;  //足球
            if (pid == 111) return 19;  //篮球
            if (pid == 112) return 21;  //排球
            LJH.GeneralLibrary.FileLog.Log("项目代码", "项目代码无法识别, 项目编号:" + pid.ToString());
            return 0;
        }

        private int 获取小奔项目编号(int pid)
        {
            if (pid == 11) return 101; //1000米
            if (pid == 10) return 102; //800米
            if (pid == 100) return 103; //100米游泳
            if (pid == 15) return 104; //实心球
            if (pid == 14) return 105; //引体向上
            if (pid == 12) return 106;  //一分钟仰卧起坐
            if (pid == 6) return 107;  //立定跳远
            if (pid == 27) return 108;  //三级蛙跳
            if (pid == 18) return 109;  //一分钟跳绳
            if (pid == 20) return 110;  //足球
            if (pid == 19) return 111;  //篮球
            if (pid == 21) return 112;  //排球
            LJH.GeneralLibrary.FileLog.Log("项目代码", "项目代码无法识别, 汇海项目编号:" + pid.ToString());
            return 0;
        }

        private string ErrorMsg(int retCode, string msg)
        {
            if (!string.IsNullOrEmpty(msg)) return string.Format("code={0} msg={1}", retCode, msg);
            string ret = string.Format("code={0} ", retCode);
            if (retCode == 1) return ret + "获取考点信息失败";
            else if (retCode == 2) return ret + "成绩格式转换错误";
            else if (retCode == 403) return ret + "校验失败或未分配权限";
            return ret + "其它错误";
        }
        #endregion

        #region 公共方法
        public QueryResultList<小奔体育学生信息> 下载全部考生()
        {
            if (string.IsNullOrEmpty(Token)) LogIn();
            if (string.IsNullOrEmpty(Token)) return null;
            try
            {
                using (WebClient client = new WebClient())
                {
                    string url = BaseUrl.TrimEnd('/') + $"/api/exam/queryStudentInfoByPlace?token={Token}&examId={KS_NO}";
                    client.Headers.Add("accept", "application/json");
                    var retBytes = client.DownloadData(url);
                    var ret = JsonConvert.DeserializeObject<小奔体育接口Response<List<小奔体育学生信息>>>(ASCIIEncoding.UTF8.GetString(retBytes));
                    if (ret.code == 200 && ret.data != null && ret.data.Count > 0)
                    {
                        foreach (var s in ret.data)
                        {
                            if (s.报考科目 != null && s.报考科目.Length > 0)
                            {
                                foreach (var f in s.报考科目)
                                {
                                    f.测试科目 = 获取汇海项目编号(int.Parse(f.项目代码));
                                }
                            }
                        }
                    }
                    return new QueryResultList<小奔体育学生信息>(ResultCode.Successful, ret.message, ret.data);
                }
            }
            catch (Exception ex)
            {
                LJH.GeneralLibrary.ExceptionPolicy.HandleException(ex);
                return new QueryResultList<小奔体育学生信息>(ResultCode.Fail, ex.Message, null);
            }
        }

        public CommandResult 上传成绩(StudentScore score, int index, int pt)
        {
            if (string.IsNullOrEmpty(Token)) LogIn();
            if (string.IsNullOrEmpty(Token)) return null;
            try
            {
                using (WebClient client = new WebClient())
                {
                    string url = BaseUrl.TrimEnd('/') + $"/api/exam/saveOrUpdateData?token={Token}";
                    client.Headers.Add("accept", "application/json");
                    client.Headers.Add("Content-Type", "application/json;charset=utf-8");
                    var json = JsonConvert.SerializeObject(new
                    {
                        stuCode = score.StudentID,
                        projectNo = 获取小奔项目编号(score.PhysicalItemID).ToString(),
                        projectType = pt,
                        scoreNo = index,
                        startTime = score.TestTime.ToString("yyyy-MM-dd HH:mm:ss"),
                        result = 获取格式成绩(score),
                        score = score.Result?.Trim().ToString(),
                        examStatus = 获取成绩状态(score)
                    });
                    json = $"[{json}]"; //加一个中括号表示数组
                    var content = string.Format("{0}", json);
                    var retBytes = client.UploadData(url, "POST", ASCIIEncoding.UTF8.GetBytes(content));
                    var rStr = ASCIIEncoding.UTF8.GetString(retBytes);
                    var ret = JsonConvert.DeserializeObject<小奔体育接口Response<List<成绩上传结果>>>(rStr);
                    LJH.GeneralLibrary.FileLog.Log("小奔体育", string.Format(@"发送内容:{0}\n 返回：{1}", json, rStr));
                    if (ret.code == 200 && ret.data != null && ret.data.Count > 0)
                    {
                        if (ret.data[0].code == 200) return new CommandResult(ResultCode.Successful, null);
                        else return new CommandResult(ResultCode.Fail, ret.data[0].message);
                    }
                    else
                    {
                        return new CommandResult(ResultCode.Fail, ErrorMsg(ret.code, ret.message));
                    }
                }
            }
            catch (Exception ex)
            {
                LJH.GeneralLibrary.ExceptionPolicy.HandleException(ex);
                return new CommandResult(ResultCode.Fail, ex.Message);
            }
        }

        public QueryResultList<StudentRawScore> 下载跳绳成绩(string studentIDs)
        {
            if (string.IsNullOrEmpty(Token)) LogIn();
            if (string.IsNullOrEmpty(Token)) return null;
            try
            {
                using (WebClient client = new WebClient())
                {
                    string url = BaseUrl.TrimEnd('/') + $"/api/sport/exam/out/getStuSkipResult?token={Token}&examId={KS_NO}";
                    client.Headers.Add("accept", "application/json");
                    var retBytes = client.DownloadData(url);
                    var rStr = ASCIIEncoding.UTF8.GetString(retBytes);
                    var ret = JsonConvert.DeserializeObject<小奔体育接口Response<List<小奔测试成绩>>>(rStr);
                    if (ret.code == 200)
                    {
                        List<StudentRawScore> items = new List<StudentRawScore>();
                        if (ret.data != null && ret.data.Count > 0)
                        {
                            foreach (var item in ret.data)
                            {
                                if (item.测试科目 != "109") continue; //只需要跳绳成绩
                                if (string.IsNullOrEmpty(item.设备序号)) continue;
                                if (string.IsNullOrEmpty(item.考试时间)) continue;
                                if (string.IsNullOrEmpty(item.学号)) continue;
                                items.Add(new StudentRawScore()
                                {
                                    ID = Guid.NewGuid(),
                                    StudentID = item.学号,
                                    TestID = 获取汇海项目编号(int.Parse(item.测试科目)),
                                    Score = decimal.Parse(item.成绩),
                                    CreateTime = DateTime.Parse(item.考试时间, null, System.Globalization.DateTimeStyles.None),
                                    ScoreSer = 1,
                                    ScoreFrom = ScoreSource.其它设备,
                                    HostSn = item.设备序号,
                                });
                            }
                        }
                        return new QueryResultList<StudentRawScore>(ResultCode.Successful, null, items);
                    }
                    else
                    {
                        return new QueryResultList<StudentRawScore>(ResultCode.Fail, ret.message, null);
                    }
                }
            }
            catch (Exception ex)
            {
                Token = null;
                LJH.GeneralLibrary.ExceptionPolicy.HandleException(ex);
                return new QueryResultList<StudentRawScore>(ResultCode.Fail, ex.Message, null);
            }
        }

        public byte[] 下载照片(string url)
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    var retBytes = client.DownloadData(url);
                    return retBytes;
                }
            }
            catch (Exception ex)
            {
                LJH.GeneralLibrary.ExceptionPolicy.HandleException(ex);
                return null;
            }
        }
        #endregion
    }

    internal class 小奔体育接口Response<T>
    {
        public int code { get; set; }

        public string message { get; set; }

        public T data { get; set; }
    }

    internal class 小奔体育用户信息
    {
        public string token { get; set; }
    }

    public class 小奔体育学生信息
    {
        [JsonProperty(PropertyName = "schName")]
        public string 学校名称 { get; set; }

        [JsonProperty(PropertyName = "stuCode")]
        public string 考生号 { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string 姓名 { get; set; }

        [JsonProperty(PropertyName = "gender")]
        public string 性别 { get; set; }

        [JsonProperty(PropertyName = "bj")]
        public string 考生班级 { get; set; }

        [JsonProperty(PropertyName = "imgSrc")]
        public string 考生相片 { get; set; }

        [JsonProperty(PropertyName = "groupName")]
        public string 组别 { get; set; }

        [JsonProperty(PropertyName = "examNo")]
        public string 道次 { get; set; }

        [JsonProperty(PropertyName = "examStudentProjectResVoList")]
        public 小奔体育报考项目[] 报考科目 { get; set; }
    }

    public class 小奔体育报考项目
    {
        [JsonProperty(PropertyName = "projectNo")]
        public string 项目代码 { get; set; }

        [JsonProperty(PropertyName = "projectType")]
        public string 项目类别 { get; set; }

        public int 测试科目 { get; set; }
    }

    internal class 成绩上传结果
    {
        public int code { get; set; }

        public string message { get; set; }
    }

    internal class 小奔测试成绩
    {
        [JsonProperty(PropertyName = "cz")]
        public string 设备序号 { get; set; }

        [JsonProperty(PropertyName = "ksno")]
        public string 学号 { get; set; }

        [JsonProperty(PropertyName = "xmno")]
        public string 测试科目 { get; set; }

        [JsonProperty(PropertyName = "xmcj")]
        public string 成绩 { get; set; }

        [JsonProperty(PropertyName = "kssj")]
        public string 考试时间 { get; set; }

    }
}
