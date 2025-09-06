using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HH.ZK.Model
{
    public class NationHelper : Dictionary<int, string>
    {
        #region 静态变量
        private static NationHelper _Instance;
        /// <summary>
        /// 获取单例
        /// </summary>
        public static NationHelper Instance
        {
            get
            {
                if (_Instance == null) _Instance = new NationHelper();
                return _Instance;
            }
        }
        #endregion

        #region 构造函数
        public NationHelper()
        {
            this.Add(1, "汉族");
            this.Add(2, "蒙古族");
            this.Add(3, "回族");
            this.Add(4, "藏族");
            this.Add(5, "维吾尔族");
            this.Add(6, "苗族");
            this.Add(7, "彝族");
            this.Add(8, "壮族");
            this.Add(9, "布依族");
            this.Add(10, "朝鲜族");
            this.Add(11, "满族");
            this.Add(12, "侗族");
            this.Add(13, "瑶族");
            this.Add(14, "白族");
            this.Add(15, "土家族");
            this.Add(16, "哈尼族");
            this.Add(17, "哈萨克族");
            this.Add(18, "傣族");
            this.Add(19, "黎族");
            this.Add(20, "傈僳族");
            this.Add(21, "佤族");
            this.Add(22, "畲族");
            this.Add(23, "高山族");
            this.Add(24, "拉祜族");
            this.Add(25, "水族");
            this.Add(26, "东乡族");
            this.Add(27, "纳西族");
            this.Add(28, "景颇族");
            this.Add(29, "柯尔克孜族");
            this.Add(30, "土族");
            this.Add(31, "达斡尔族");
            this.Add(32, "仫佬族");
            this.Add(33, "羌族");
            this.Add(34, "布朗族");
            this.Add(35, "撒拉族");
            this.Add(36, "毛南族");
            this.Add(37, "仡佬族");
            this.Add(38, "锡伯族");
            this.Add(39, "阿昌族");
            this.Add(40, "普米族");
            this.Add(41, "塔吉克族");
            this.Add(42, "怒族");
            this.Add(43, "乌孜别克族");
            this.Add(44, "俄罗斯族");
            this.Add(45, "鄂温克族");
            this.Add(46, "德昂族");
            this.Add(47, "保安族");
            this.Add(48, "裕固族");
            this.Add(49, "京族");
            this.Add(50, "塔塔尔族");
            this.Add(51, "独龙族");
            this.Add(52, "鄂伦春族");
            this.Add(53, "赫哲族");
            this.Add(54, "门巴族");
            this.Add(55, "珞巴族");
            this.Add(56, "基诺族");
            this.Add(57, "其他");
            this.Add(58, "外国血统");
        }
        #endregion

        #region 公共方法
        public string GetName(int nation)
        {
            if (this.ContainsKey(nation)) return this[nation];
            return null;
        }
        /// <summary>
        /// 将字符串的民族表示转化成民族代码，字符串有可能是民族名称或民族代码
        /// </summary>
        /// <param name="nation"></param>
        /// <param name="m_Nation"></param>
        /// <returns></returns>
        public bool TryParse(string nation, out int m_Nation)
        {
            m_Nation = 0;
            if (this.ContainsValue(nation))
            {
                m_Nation = this.Single(item => item.Value == nation).Key; //用的民族名称
                return true;
            }
            else
            {
                int temp = 0;
                if (int.TryParse(nation, out temp))
                {
                    if (this.ContainsKey(temp))
                    {
                        m_Nation = temp;
                        return true;
                    }
                    else if (temp > 58) //大于58的民族代码都设置成其它
                    {
                        m_Nation = 57;
                        return true;
                    }
                }
            }
            return false;
        }
        #endregion
    }
}
