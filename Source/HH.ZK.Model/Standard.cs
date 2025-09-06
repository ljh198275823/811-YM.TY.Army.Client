using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LJH.GeneralLibrary;

namespace HH.ZK.Model
{
    /// <summary>
    /// 表示评分标准
    /// </summary>
    public class Standard : LJH.GeneralLibrary.IEntity<Guid>
    {
        #region 构造函数
        public Standard()
        {
        }
        #endregion

        #region 公共属性
        /// <summary>
        /// 获取或设置ID
        /// </summary>
        public Guid ID { get; set; }
        /// <summary>
        /// 获取或设置名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 获取或设置标准适用的测试项目ID
        /// </summary>
        public int PhysicalItemID { get; set; }
        /// <summary>
        /// 获取或设置标准适用的测试项目
        /// </summary>
        public PhysicalItem PhysicalItem { get; set; }
        /// <summary>
        /// 获取或设置标准适用的性别
        /// </summary>
        public Sex Sex { get; set; }
        /// <summary>
        /// 获取或设置标准适用的年级
        /// </summary>
        public int Grade { get; set; }
        /// <summary>
        /// 获取或设置是否是加分评分标准
        /// </summary>
        public bool IsForJiafen { get; set; }
        /// <summary>
        /// 获取或设置评分标准项
        /// </summary>
        public List<StandardItem> Items { get; set; }
        #endregion

        #region 公共方法
        /// <summary>
        /// 根据测试成绩计算得分和等级
        /// </summary>
        /// <param name="score"></param>
        /// <returns></returns>
        public bool CalResult(decimal score, out decimal ret, out string rank)
        {
            ret = 0;
            rank = null;
            if (Items != null && Items.Count > 0)
            {
                StandardItem si = Items.FirstOrDefault(it => it.InMyRange(score));
                if (si != null)
                {
                    ret = si.Result;
                    rank = si.Rank;
                    return true;
                }
                return true; //如果值不在标准项范围内
            }
            return false;
        }
        /// <summary>
        /// 检测评分标准是否有效
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>
        public bool IsValid(out string msg)
        {
            msg = null;
            if (this.Items != null && Items.Count > 0)
            {
                decimal dmin = Items.Min(it => it.Score1);
                decimal dmax = Items.Max(it => it.Score1);
                decimal step = (decimal)(PhysicalItem != null ? (1 / Math.Pow(10, PhysicalItem.PointCount)) : 0.01);
                for (decimal i = dmin; i <= dmax; i += step)
                {
                    if (!Items.Exists(it => it.InMyRange(i))) //没有评分
                    {
                        msg = string.Format("标准没有完全包括某些值，比如:{0}", i);
                        return false;
                    }
                    if (Items.Count(it => it.InMyRange(i)) > 1) //重复评分
                    {
                        msg = string.Format("某些值有两个以上的评分标准项，比如:{0}", i);
                        return false;
                    }
                }
            }
            return true;
        }
        /// <summary>
        /// 将标准项转化成字符串的形式
        /// </summary>
        /// <param name="si"></param>
        /// <returns></returns>
        public string StandardItemToString(StandardItem si)
        {
            string ret = OperatorsHelper.GetString(si.Operator1) + (PhysicalItem != null ? PhysicalItem.ConvertToStr(si.Score1) : si.Score1.Trim().ToString());
            if (si.Operator2 != null && si.Score2 != null)
            {
                ret += "  " + OperatorsHelper.GetString(si.Operator2.Value) + (PhysicalItem != null ? PhysicalItem.ConvertToStr(si.Score2.Value) : si.Score2.Value.Trim().ToString());
            }
            return ret;
        }

        public Standard Clone()
        {
            var ret = MemberwiseClone() as Standard;
            ret.Items = new List<StandardItem>();
            ret.Items.AddRange(this.Items.Select(it => it.Clone()));
            return ret;
        }
        #endregion
    }
}
