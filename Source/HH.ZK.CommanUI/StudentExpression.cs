using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using HH.ZK.Model;
using HH.ZK.Model.CRM;
using LJH.GeneralLibrary;

namespace HH.ZK.CommonUI
{
    public class StudentExpression
    {
        #region 私有方法
        private static bool TryGetField(StudentWithTotal s, string expression, out string ret)
        {
            bool temp = false;
            ret = null;
            if (s == null) return false;
            string[] strs = expression.Split(',', '，');
            if (strs == null || strs.Length == 0) return false;
            switch (strs[0])
            {
                case "学号":
                case "准考证号":
                case "学籍号":
                    ret = s.ID;
                    return true;
                case "姓名":
                    ret = s.Name;
                    return true;
                case "卡号":
                    ret = s.CardID;
                    return true;
                case "性别":
                    ret = s.Sex == Sex.Male ? "男" : "女";
                    return true;
                case "性别代码":
                    ret = s.Sex == Sex.Male ? "1" : "2";
                    return true;
                case "身份证号":
                    ret = s.IDNumber;
                    return true;
                case "区域":
                case "所属区域":
                    ret = s.DivisionName;
                    return true;
                case "学校":
                case "学校名称":
                    ret = s.FacilityName;
                    return true;
                case "考点":
                    ret = AppSettings.Current.PhysicalProject.Name;
                    return true;
                case "年级编号":
                    ret = s.Grade.ToString();
                    return true;
                case "年级":
                    ret = GradeHelper.Instance.GetName(s.Grade);
                    return true;
                case "班级":
                case "班级名称":
                    ret = s.ClassName;
                    return true;
                case "考试科目":
                    ret= AppSettings.Current.PhysicalProject.PhysicalItems?.GetNames(s.PhysicalItems);
                    return true;
                case "组别":
                case "分组":
                    ret = s.Groups;
                    return true;
                case "总分":
                    if (AppSettings.Current.Operator.PermitAll(Permission.总分, PermissionActions.Read)) ret = s.Total.ToString();
                    else ret = null;
                    return true;
                case "加分":
                case "附加分":
                case "平时成绩":
                case "国标分":
                    if (AppSettings.Current.Operator.PermitAll(Permission.总分, PermissionActions.Read)) ret = s.JiaFen.Trim().ToString();
                    else ret = null;
                    return true;
                case "标准分":
                case "考试分":
                    if (AppSettings.Current.Operator.PermitAll(Permission.总分, PermissionActions.Read)) ret = (s.Total - s.JiaFen).ToString();
                    else ret = null;
                    return true;
                case "特殊情况":
                    ret = s.State != StudentState.正常考试 ? s.State.ToString() : null;
                    return true;
                default:
                    ret = null;
                    break;
            }
            return temp; ;
        }

        private static bool TryGetScore(StudentWithTotal s, string expression, out string ret, DateTime? dt = null)
        {
            try
            {
                string prefix = null;
                ret = null;
                bool temp = false;
                string strTemp = null;
                string[] strs = expression.Split(',', '，');
                if (strs == null || strs.Length == 0) return false;
                strTemp = strs[0];
                PhysicalItem pi;
                int pid = 0;

                if (strTemp.IndexOf("@@@") == 0)
                {
                    strTemp = strTemp.Substring(3);
                    prefix = "@@@";
                }
                else if (strTemp.IndexOf("@@") == 0)
                {
                    strTemp = strTemp.Substring(2);
                    prefix = "@@";
                }
                else if (strTemp.IndexOf("@") == 0)
                {
                    strTemp = strTemp.Substring(1);
                    prefix = "@";
                }
                else if (strTemp.IndexOf("###") == 0)
                {
                    strTemp = strTemp.Substring(3);
                    prefix = "###";
                }
                else if (strTemp.IndexOf("##") == 0) //##开头表示获取加分
                {
                    strTemp = strTemp.Substring(2);
                    prefix = "##";
                }
                else if (strTemp.IndexOf('#') == 0)
                {
                    strTemp = strTemp.Substring(1); //以#开头表示获取是成绩得分
                    prefix = "#";
                }
                if (int.TryParse(strTemp, out pid))
                {
                    pi = AppSettings.Current.PhysicalProject.PhysicalItems?.GetPhysicalItem(pid);
                }
                else  //不能转化成整数，表明有可能是以项目名称来解析的
                {
                    pi = AppSettings.Current.PhysicalProject.PhysicalItems?.GetPhysicalItem(strTemp);
                }
                if (pi != null && !s.包函考试科目(pi.ID)) return false;
                if (pi == null)  //
                {
                    List<string> pids = null;
                    var names = AppSettings.Current.PhysicalProject.PhysicalItems.GetNames(s.PhysicalItems);  //这里用项目名称的作用是让学生的项目按系统指定的科目排序
                    if (!string.IsNullOrEmpty(names)) pids = names.Split(',').ToList();
                    if (strTemp == "项目一" && pids != null && pids.Count >= 1) pi = AppSettings.Current.PhysicalProject.PhysicalItems?.GetPhysicalItem(pids[0]);
                    else if (strTemp == "项目二" && pids != null && pids.Count >= 2) pi = AppSettings.Current.PhysicalProject.PhysicalItems?.GetPhysicalItem(pids[1]);
                    else if (strTemp == "项目三" && pids != null && pids.Count >= 3) pi = AppSettings.Current.PhysicalProject.PhysicalItems?.GetPhysicalItem(pids[2]);
                    else if (strTemp == "项目四" && pids != null && pids.Count >= 4) pi = AppSettings.Current.PhysicalProject.PhysicalItems?.GetPhysicalItem(pids[3]);
                    else if (strTemp == "项目五" && pids != null && pids.Count >= 5) pi = AppSettings.Current.PhysicalProject.PhysicalItems?.GetPhysicalItem(pids[4]);
                    else if (strTemp == "项目六" && pids != null && pids.Count >= 6) pi = AppSettings.Current.PhysicalProject.PhysicalItems?.GetPhysicalItem(pids[5]);
                }
                if (pi == null) return false;
                var score = s.Scores?.SingleOrDefault(it => it.PhysicalItemID == pi.ID);
                if (score != null)
                {
                    temp = true;
                    ret = string.Empty;
                    if (string.IsNullOrEmpty(prefix)) //获取测试成绩
                    {
                        ret = score.FormatScore;
                    }
                    else if (prefix == "#") //获取成绩的得分
                    {
                        if (AppSettings.Current.Operator.PermitAll(Permission.总分, PermissionActions.Read) && score.Result != null) ret = score.Result.Value.Trim().ToString();
                    }
                    else if (prefix == "##") //加分
                    {
                        ret = score.JiaFen != null ? score.JiaFen.Value.Trim().ToString() : "0";
                    }
                    else if (prefix == "###") //等级
                    {
                        ret = score.Rank;
                    }
                    else if (prefix == "@")
                    {
                        ret = pi.Name;
                    }
                    else if (prefix == "@@")
                    {
                        ret = score.HostID?.ToString();
                    }
                    else if (prefix == "@@@")
                    {
                        ret = score.TestTime.ToString("yyyy-MM-dd HH:mm:ss");
                    }
                }
                else
                {
                    if (prefix == "@")
                    {
                        ret = pi.Name;
                        temp = true;
                    }
                    else
                    {
                        ret = string.Empty;
                        temp = false;
                    }
                }
                return temp;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        public static string Extra(StudentWithTotal s, string expression, string replaceBywhenUnmatch)
        {
            string ret = expression;
            string pattern = @"\[.+?\]"; //用于匹配 [至少一个字符]
            Regex rg = new Regex(pattern);
            var matches = rg.Matches(expression, 0);
            if (matches != null && matches.Count > 0)
            {
                foreach (var match in matches)
                {
                    string temp = match.ToString();
                    string ex = temp.TrimStart('[').TrimEnd(']');
                    string str = null;
                    if (TryGetField(s, ex, out str))
                    {
                        ret = ret.Replace(temp, str);
                    }
                    else if (TryGetScore(s, ex, out str))
                    {
                        ret = ret.Replace(temp, str);
                    }
                    else
                    {
                        if (replaceBywhenUnmatch != null) ret = ret.Replace(temp, replaceBywhenUnmatch);
                    }
                }
            }
            return ret;
        }
    }
}