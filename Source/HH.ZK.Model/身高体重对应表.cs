using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization ;

namespace HH.ZK.Model
{
    [DataContract]
    public class 身高体重对应表
    {
        public 身高体重对应表()
        {
        }

        [DataMember]
        public List<身高体重对应表项> Items { get; set; }

        /// <summary>
        /// 根据测试成绩计算得分和等级
        /// </summary>
        /// <param name="score"></param>
        /// <returns></returns>
        public bool CalResult(decimal 身高, decimal 体重, int grade, Sex sex, out decimal ret, out string rank)
        {
            ret = 0;
            rank = null;
            if (Items == null || Items.Count == 0) return false;
            var item = Items.FirstOrDefault(it => it.身高1 <= 身高 && 身高 <= it.身高2  && it.Grade == grade && it.Sex == sex && it.Items != null && it.Items.Count > 0);
            if (item == null) return false;
            var si = item.Items.FirstOrDefault(it => it.体重1 <= 体重 && 体重 <= it.体重2);
            if (si == null) return false;
            ret = si.Result;
            rank = si.Rank;
            return true;
        }
    }

    [DataContract]
    public class 身高体重对应表项
    {
        #region 公共属性
        /// <summary>
        /// 获取或设置标准适用的性别
        /// </summary>
        [DataMember]
        public Sex Sex { get; set; }
        /// <summary>
        /// 获取或设置标准适用的年级
        /// </summary>
        [DataMember]
        public int Grade { get; set; }

        [DataMember]
        public decimal 身高1 { get; set; }  //一般用于存储小值

        [DataMember]
        public decimal 身高2 { get; set; }  //一般用于存储大值

        [DataMember]
        public List<身高体重评分项> Items { get; set; }
        #endregion

        public string 身高段
        {
            get
            {
                if (身高1 == 身高2) return 身高1.ToString();
                else return string.Format("{0}-{1}", this.身高1, this.身高2);
            }
        }
    }

    [DataContract]
    public class 身高体重评分项
    {
        #region 公共属性
        [DataMember]
        public decimal 体重1 { get; set; } //一般用于存储小值
        [DataMember]
        public decimal 体重2 { get; set; } //一般用于存储大值
        /// <summary>
        /// 获取或设置测试成绩对应的得分
        /// </summary>
        [DataMember]
        public decimal Result { get; set; }
        /// <summary>
        /// 获取或设置测试成绩对应的等级 比如"优秀","合格"等
        /// </summary>
        [DataMember]
        public string Rank { get; set; }
        #endregion

        public string 体重段
        {
            get
            {
                if (体重2 >= 1000) return string.Format(">={0}", this.体重1);
                else return string.Format("{0}-{1}", this.体重1, this.体重2);
            }
        }
    }
}
