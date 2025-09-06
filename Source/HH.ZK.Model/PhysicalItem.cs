using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HH.ZK.Model
{
    /// <summary>
    /// 表示体能测试项
    /// </summary>
    public class PhysicalItem : LJH.GeneralLibrary.IEntity<int>
    {
        #region 静态常量
        public static int _身高 = 1;
        public static int _体重 = 2;
        public static int _引体向上 = 14;
        public static int _BMI = 24;
        public static int _50x8米 = 9;
        public static int _800米 = 10;
        public static int _1000米 = 11;
        public static int _左眼裸眼视力 = 71;
        public static int _右眼裸眼视力 = 72;
        public static int _左眼串镜 = 90;
        public static int _右眼串镜 = 91;
        public static int _左眼屈光不正 = 92;
        public static int _右眼屈光不正 = 93;

        public static int _斜体引体向上 = 150;
        public static int _体脂肪率 = 151;
        public static int _内脂指数 = 152;
        public static int _体水份率 = 153;
        public static int _骨骼肌率 = 154;
        public static int _骨矿含量 = 155;
        public static int _基础代谢 = 156;
        public static int _上肢平衡 = 157;
        public static int _下肢平衡 = 158;
        public static int _全身平衡 = 159;
        public static int _体成份综合评分 = 160;
        public static int _生理年龄 = 161;

        public static int ConvertPhysicalItem(Sex sex, int physicalItem)
        {
            if (sex == Model.Sex.Male && physicalItem == PhysicalItem._800米)
            {
                return PhysicalItem._1000米;
            }
            else if (sex == Model.Sex.Female && physicalItem == PhysicalItem._1000米)
            {
                return PhysicalItem._800米;
            }
            return physicalItem;
        }
        #endregion

        #region 构造函数
        public PhysicalItem() { }
        #endregion

        #region 公共属性
        /// <summary>
        /// 获取或设置ID
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// 获取或设置名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 获取或设置单位
        /// </summary>
        public string Unit { get; set; }
        /// <summary>
        /// 获取或设置小数点位数
        /// </summary>
        public int PointCount { get; set; }
        /// <summary>
        /// 获取或设置项目成绩来源，true表示通过设备测试，false表示通过手持机APP录入
        /// </summary>
        public bool HasMachine { get; set; }
        /// <summary>
        /// 获取或设置测试项目成绩的排序，0表示没有排序，1表示值越低，成绩越好，2表示值越高，成绩越好
        /// </summary>
        public int SortMode { get; set; }
        /// <summary>
        /// 获取或设置测试成绩的最大值
        /// </summary>
        public decimal? Max { get; set; }
        /// <summary>
        /// 获取或设置测试成绩的最小值
        /// </summary>
        public decimal? Min { get; set; }
        /// <summary>
        /// 获取或设置项目成绩的计算公式
        /// </summary>
        public string Formula { get; set; }
        /// <summary>
        /// 获取或设置备注
        /// </summary>
        public string Memo { get; set; }
        #endregion

        #region 实际计划中的属性
        /// <summary>
        /// 获取或设置项目简称
        /// </summary>
        public string ShortName { get; set; }
        /// <summary>
        /// 获取或设置测试次数
        /// </summary>
        public int? TestCount { get; set; }
        /// <summary>
        /// 0表示非零进一，1表示四舍五入，2表示直接截取
        /// </summary>
        public int PrecisionMode { get; set; }

        public bool IsMust { get; set; }

        public int Sex { get; set; }
        #endregion

        #region 公共方法
        /// <summary>
        /// 将成绩转化成项目规定的字符来表示
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public string ConvertToStr(decimal value)
        {
            value = Convert(value);
            if (Unit == "分:秒")
            {
                var f1 = ConvertToMinuteSecond(Math.Floor(value)).ToString("F2").Replace(".", ":");
                if (PointCount == 0) return f1;
                return f1 + (value - Math.Floor(value)).ToString("F" + PointCount).Replace("0.", ".");
            }
            else if (Unit == "分'秒\"")
            {
                var f1 = ConvertToMinuteSecond(Math.Floor(value)).ToString("F2").Replace(".", "'") + "\"";
                if (PointCount == 0) return f1;
                return f1 + (value - Math.Floor(value)).ToString("F" + PointCount).Replace("0.", ".");
            }
            else if (Unit == "分.秒")
            {
                return ConvertToMinuteSecond(Math.Floor(value)).ToString("F2");
            }
            if (this.ID == 6 && this.Unit == "米")
            {
                value = value / 100;
            }
            return value.ToString("F" + PointCount);
        }

        /// <summary>
        /// 获取原始成绩转化成有科目的小数位数的成绩
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public decimal Convert(decimal value)
        {
            if (this.ID == 6 && this.Unit == "米")
            {
                value = value / 100;
                value = Convert(value, PointCount);
                return value * 100;
            }
            else if (Unit == "分.秒")
            {
                return Convert(value, 0);
            }
            return Convert(value, PointCount);
        }

        /// <summary>
        /// 获取原始成绩转化成有科目的小数位数的成绩
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public decimal Convert(decimal value, int 小数位数)
        {
            if (PrecisionMode == 1) //四舍五入
            {
                return Math.Round(value, 小数位数);
            }
            else if (PrecisionMode == 2) //直接截取
            {
                var temp = Math.Floor((double)(value * System.Convert.ToDecimal(Math.Pow(10, 小数位数)))) / Math.Pow(10, 小数位数);
                return (decimal)temp;
            }
            var ret = Math.Ceiling((double)(value * System.Convert.ToDecimal(Math.Pow(10, 小数位数))));
            ret = ret / Math.Pow(10, 小数位数);
            return (decimal)ret;
        }

        public bool TryParse(string str, out decimal value)
        {
            value = 0;
            str = str.Replace(" ", string.Empty); //去掉空格
            if (Unit == "分.秒")
            {
                str = str.Replace("“", string.Empty).Replace("”", string.Empty).Replace("″", string.Empty).Replace("\"", string.Empty); //将中文的双引号替换成空
                str = str.Replace("''", string.Empty); //将两个单引号也替换成空
                str = str.Replace('‘', '.').Replace('’', '.').Replace('′', '.').Replace('\'', '.'); //将中文的全角单引号替换成小数点
                
                if (!decimal.TryParse(str, out value)) return false;
                if (value > 60) return true; //说明原始成绩是秒
                if ((value - (long)value) >= 0.6m) return false;
                value = ConvertToSeconds(value);
                return true;
            }
            else if (Unit == "分:秒" || Unit == "分'秒\"")
            {
                if (decimal.TryParse((string)str, out value)) //3.25这种格式的也要尝试转换
                {
                    if (value > 60) return true;
                    if ((value - (long)value) >= 0.6m) return false;
                    value = ConvertToSeconds(value);
                    return true;
                }
                var strTemp = str.IndexOf('.') > 0 ? str.Substring(0, (int)str.IndexOf('.')) : str;
                strTemp = strTemp.Replace("“", string.Empty).Replace("”", string.Empty).Replace("″", string.Empty).Replace("\"", string.Empty); //将中文的双引号替换成空
                strTemp = strTemp.Replace("''", string.Empty); //将两个单引号也替换成空
                strTemp = strTemp.Replace(":", ".").Replace("：", ".");
                strTemp = strTemp.Replace('‘', '.').Replace('’', '.').Replace('′', '.').Replace('\'', '.'); //将中文的全角单引号替换成小数点
                if (!decimal.TryParse((string)strTemp, out value)) return false;
                if (value > 60)
                {
                    //说明原始成绩是秒
                }
                else
                {
                    if ((value - (long)value) >= 0.6m) return false;
                    value = ConvertToSeconds(value);
                }
                if (str.IndexOf('.') > 0)
                {
                    decimal 小数部分;
                    str = "0" + str.Substring((int)str.IndexOf('.'));
                    if (!decimal.TryParse((string)str, out 小数部分)) return false;
                    value += 小数部分;
                }
                return true;
            }
            else if (Unit == "秒") //将双引号换成小数点
            {
                str = str.Replace("“", ".").Replace("”", ".").Replace("\"", ".").Replace("″", ".");
            }
            if (!decimal.TryParse(str, out value)) return false; //如果能转换成整数，则将值取成与项目的格式一致
            if (this.ID == 6 && this.Unit == "米") value = value * 100; //立定跳远用厘米表示
            if (this.ID == PhysicalItem._左眼串镜 || this.ID == PhysicalItem._右眼串镜)
            {
                if (value != 0 && value != -1 && value != 1 && value != 2) return false;
            }
            if (this.ID == PhysicalItem._左眼屈光不正 || this.ID == PhysicalItem._右眼屈光不正)
            {
                if (value != 0 && value != 1 && value != 2 && value != 3) return false;
            }
            return true;
        }
        /// <summary>
        /// 将秒表示的成绩转化成"分.秒"表示的成绩
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal ConvertToMinuteSecond(decimal value)
        {
            TimeSpan ts;
            ts = new TimeSpan(0, 0, (int)Math.Floor(value));
            return ts.Minutes + (decimal)ts.Seconds / 100;
        }

        public static decimal ConvertToSeconds(decimal value)
        {
            int f = (int)Math.Floor(value);
            return (int)(f * 60 + (value - f) * 100);
        }
        #endregion
    }
}
