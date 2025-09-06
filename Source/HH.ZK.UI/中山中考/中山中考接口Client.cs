using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using Newtonsoft.Json;
using HH.ZK.Model;
using LJH.GeneralLibrary;

namespace HH.ZK.UI.中山中考
{
    public class 中山中考接口Client
    {
        #region 构造函数
        public 中山中考接口Client()
        {
        }

        public 中山中考接口Client(ThirdPlateFormSettings ts)
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
                    string url = BaseUrl.TrimEnd('/') + "/userLogin";
                    client.Headers.Add("accept", "application/json");
                    client.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
                    var content = string.Format("user_no={0}&user_pwd={1}", UserName, Password);
                    var retBytes = client.UploadData(url, "POST", ASCIIEncoding.UTF8.GetBytes(content));
                    var ret = JsonConvert.DeserializeObject<中山中考接口Response>(ASCIIEncoding.UTF8.GetString(retBytes));
                    if (ret.code == 0) Token = ret.token;
                }
            }
            catch (Exception ex)
            {
                Token = null;
                LJH.GeneralLibrary.ExceptionPolicy.HandleException(ex);
            }
        }

        private string 获取中山格式成绩(StudentScore score)
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

        private int 获取中山成绩状态(StudentScore score)
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
            LJH.GeneralLibrary.FileLog.Log("项目代码", "项目代码无法识别, 中山项目编号:" + pid.ToString());
            return 0;
        }

        private int 获取中山项目代码(int pid)
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
        public 中山中考获取学生Response 下载全部考生()
        {
            if (string.IsNullOrEmpty(Token)) LogIn();
            if (string.IsNullOrEmpty(Token)) return null;
            try
            {
                using (WebClient client = new WebClient())
                {
                    string url = BaseUrl.TrimEnd('/') + "/downloadKsInfos";
                    client.Headers.Add("Authorization", Token);
                    client.Headers.Add("accept", "application/json");
                    client.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
                    var retBytes = client.UploadData(url, "POST", new byte[0]);
                    var ret = JsonConvert.DeserializeObject<中山中考获取学生Response>(ASCIIEncoding.UTF8.GetString(retBytes));
                    if (ret.body != null && ret.body.Length > 0)
                    {
                        foreach (var s in ret.body)
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
                    return ret;
                }
            }
            catch (Exception ex)
            {
                LJH.GeneralLibrary.ExceptionPolicy.HandleException(ex);
                return null;
            }
        }

        public CommandResult 上传成绩(StudentScore score, int index)
        {
            if (string.IsNullOrEmpty(Token)) LogIn();
            if (string.IsNullOrEmpty(Token)) return null;
            try
            {
                using (WebClient client = new WebClient())
                {
                    string url = BaseUrl.TrimEnd('/') + "/uploadSportsScore";
                    client.Headers.Add("Authorization", Token);
                    client.Headers.Add("accept", "application/json");
                    client.Headers.Add("Content-Type", "application/json;charset=utf-8");
                    var json = JsonConvert.SerializeObject(new
                    {
                        ksno = score.StudentID,
                        xmno = 获取中山项目代码(score.PhysicalItemID).ToString(),
                        xh = index,
                        kssj = score.TestTime.ToString("yyyy-MM-dd HH:mm:ss"),
                        xmcj = 获取中山格式成绩(score),
                        kszt = 获取中山成绩状态(score)
                    });
                    json = $"[{json}]"; //加一个中括号表示数组
                    var content = string.Format("{0}", json);
                    var retBytes = client.UploadData(url, "POST", ASCIIEncoding.UTF8.GetBytes(content));
                    var rStr = ASCIIEncoding.UTF8.GetString(retBytes);
                    var ret = JsonConvert.DeserializeObject<中山中考接口Response>(rStr);
                    LJH.GeneralLibrary.FileLog.Log("中山接口", string.Format(@"发送内容:{0}\n 返回：{1}", json, rStr));
                    if (ret.code == 0) return new CommandResult(ResultCode.Successful, null);
                    else
                    {
                        return new CommandResult(ResultCode.Fail, ErrorMsg(ret.code, ret.msg));
                    }
                }
            }
            catch (Exception ex)
            {
                LJH.GeneralLibrary.ExceptionPolicy.HandleException(ex);
                return new CommandResult(ResultCode.Fail, ex.Message);
            }
        }

        public CommandResult 考生检录(string studentID, string name)
        {
            if (string.IsNullOrEmpty(Token)) LogIn();
            if (string.IsNullOrEmpty(Token)) return null;
            try
            {
                using (WebClient client = new WebClient())
                {
                    string url = BaseUrl.TrimEnd('/') + "/collectKs";
                    client.Headers.Add("Authorization", Token);
                    client.Headers.Add("accept", "application/json");
                    client.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
                    var content = string.Format("ks_no={0}&ks_xm={1}", studentID, name);
                    var retBytes = client.UploadData(url, "POST", ASCIIEncoding.UTF8.GetBytes(content));
                    var rStr = ASCIIEncoding.UTF8.GetString(retBytes);
                    var ret = JsonConvert.DeserializeObject<中山中考接口Response>(rStr);
                    if (ret.code == 0) return new CommandResult(ResultCode.Successful, null);
                    else
                    {
                        LJH.GeneralLibrary.FileLog.Log("中山接口检录", string.Format(@"发送内容:{0}\n 返回：{1}", content, rStr));
                        return new CommandResult(ResultCode.Fail, ret.msg);
                    }
                }
            }
            catch (Exception ex)
            {
                Token = null;
                LJH.GeneralLibrary.ExceptionPolicy.HandleException(ex);
                return new CommandResult(ResultCode.Fail, ex.Message);
            }
        }
        #endregion
    }

    internal class 中山中考接口Response
    {
        public int code { get; set; }

        public string msg { get; set; }

        public string token { get; set; }

        public object body { get; set; }
    }

    public class 中山中考获取学生Response
    {
        public int code { get; set; }

        public string msg { get; set; }

        public 中山中考学生信息[] body { get; set; }
    }

    public class 中山中考学生信息
    {
        [JsonProperty(PropertyName = "xxmc")]
        public string 学校名称 { get; set; }

        [JsonProperty(PropertyName = "ksno")]
        public string 考生号 { get; set; }

        [JsonProperty(PropertyName = "xm")]
        public string 姓名 { get; set; }

        [JsonProperty(PropertyName = "xb")]
        public string 性别 { get; set; }

        [JsonProperty(PropertyName = "bj")]
        public string 考生班级 { get; set; }

        [JsonProperty(PropertyName = "ksxp")]
        public string 考生相片 { get; set; }
        /// <summary>
        /// 报考科目
        /// </summary>
        [JsonProperty(PropertyName = "kmxm")]
        public 中山中考报考项目[] 报考科目 { get; set; }
    }

    public class 中山中考报考项目
    {
        /// <summary>
        ///项目代码
        /// </summary>
        [JsonProperty(PropertyName = "xmno")]
        public string 项目代码 { get; set; }
        /// <summary>
        /// 项目名称
        /// </summary>
        [JsonProperty(PropertyName = "xmmc")]
        public string 项目名称 { get; set; } //

        public int 测试科目 { get; set; }
        /// <summary>
        /// 考场
        /// </summary>
        [JsonProperty(PropertyName = "kc")]
        public string 考场 { get; set; }//
        /// <summary>
        /// 考试时间
        /// </summary>
        [JsonProperty(PropertyName = "kssj")]
        public string 考试时间 { get; set; }
        /// <summary>
        /// 组别
        /// </summary>
        [JsonProperty(PropertyName = "zb")]
        public string 组别 { get; set; }
        /// <summary>
        /// 道次
        /// </summary>
        [JsonProperty(PropertyName = "dc")]
        public string 道次 { get; set; }
    }
}
