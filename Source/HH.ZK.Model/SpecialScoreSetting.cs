using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace HH.ZK.Model
{
    public class SpecialScoreSetting
    {
        #region 构造函数
        public SpecialScoreSetting()
        {
        }
        #endregion

        public List<SpecialScoreItem> Items { get; set; }

        #region 公共方法
        public void AddItem(int physicalItem, SpecialScoreType specialType, decimal value)
        {
            if (Items == null) Items = new List<SpecialScoreItem>();
            SpecialScoreItem ssi = Items.SingleOrDefault(it => it.PhysicalItem == physicalItem && it.SpecialScoreType == specialType);
            if (ssi == null)
            {
                ssi = new SpecialScoreItem();
                Items.Add(ssi);
            }
            ssi.PhysicalItem = physicalItem;
            ssi.SpecialScoreType = specialType;
            ssi.Value = value;
        }

        public decimal? GetValue(int physicalItem, SpecialScoreType specialType)
        {
            decimal? ret = null;
            if (Items != null)
            {
                SpecialScoreItem ssi = Items.SingleOrDefault(it => it.PhysicalItem == physicalItem && it.SpecialScoreType == specialType);
                if (ssi != null) ret = ssi.Value;
            }
            return ret;
        }

        public void Clear()
        {
            if (Items != null) Items.Clear();
        }
        #endregion
    }

    public class SpecialScoreItem
    {
        public int PhysicalItem { get; set; }

        public SpecialScoreType SpecialScoreType { get; set; }

        public decimal Value { get; set; }
    }
}
