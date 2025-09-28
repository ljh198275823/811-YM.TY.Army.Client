using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HH.ZK.Model
{
    /// <summary>
    /// 表示评分标准的评分项
    /// </summary>
    public class StandardItem
    {
        #region 构造函数
        public StandardItem() { }
        #endregion

        #region 公共属性
        public long ID { get; set; }

        public long StandardID { get; set; }

        public Operators Operator1 { get; set; }

        public decimal Score1 { get; set; }

        public Operators? Operator2 { get; set; }

        public decimal? Score2 { get; set; }
        /// <summary>
        /// 获取或设置测试成绩对应的得分
        /// </summary>
        public decimal Result { get; set; }
        /// <summary>
        /// 获取或设置测试成绩对应的等级 比如"优秀","合格"等
        /// </summary>
        public string Rank { get; set; }
        #endregion

        #region 公共方法
        /// <summary>
        /// 检测成绩是否落在此标准项的范围内
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool InMyRange(decimal value)
        {
            if (value == Score1 && Operator1 != Operators.BigOrEquel && Operator1 != Operators.SmallOrEquel) return false;
            if (value > Score1 && Operator1 != Operators.BigOrEquel && Operator1 != Operators.Big) return false;
            if (value < Score1 && Operator1 != Operators.SmallOrEquel && Operator1 != Operators.Small) return false;
            if (Operator2 != null && Score2 != null)
            {
                if (value == Score2.Value && Operator2.Value != Operators.BigOrEquel && Operator2.Value != Operators.SmallOrEquel) return false;
                if (value > Score2.Value && Operator2.Value != Operators.Big && Operator2.Value != Operators.BigOrEquel) return false;
                if (value < Score2.Value && Operator2.Value != Operators.Small && Operator2.Value != Operators.SmallOrEquel) return false;
            }
            return true;
        }

        public StandardItem Clone()
        {
            return MemberwiseClone() as StandardItem;
        }
        #endregion
    }


    public enum Operators
    {
        /// <summary>
        /// 大于或等于
        /// </summary>
        BigOrEquel = 0,
        /// <summary>
        /// 大于
        /// </summary>
        Big = 1,
        /// <summary>
        /// 小于或等于
        /// </summary>
        SmallOrEquel = 2,
        /// <summary>
        /// 小于
        /// </summary>
        Small = 3,
    }

    public class OperatorsHelper
    {
        public static string GetString(Operators opt)
        {
            switch (opt)
            {
                case Operators.Big:
                    return ">";
                case Operators.BigOrEquel:
                    return ">=";
                case Operators.Small:
                    return "<";
                case Operators.SmallOrEquel:
                    return "<=";
                default:
                    return null;
            }
        }
    }
}
