using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using HH.ZK.Model;
using HH.ZK.WebAPIClient;
using LJH.GeneralLibrary;

namespace HH.ZK.CommonUI
{
    public partial class FrmPhysicalItemMaster : LJH.GeneralLibrary.WinForm.FrmMasterBase<int, PhysicalItem>
    {
        public FrmPhysicalItemMaster()
        {
            InitializeComponent();
        }

        #region 重写基类方法
        protected override QueryResultList<PhysicalItem> GetDataSource()
        {
            return CRMAPIClient.GetList<int, PhysicalItem>(SearchCondition);
        }

        protected override List<PhysicalItem> FilterData(List<PhysicalItem> items)
        {
            return (from item in items orderby item.ID ascending select item).ToList();
        }

        protected override object GetCellValue(PhysicalItem item, string colName)
        {
            if (colName == "colID") return item.ID;
            if (colName == "colName") return item.Name;
            if (colName == "colShortName") return item.ShortName;
            if (colName == "colUnit") return item.Unit;
            if (colName == "colPointCount") return item.PointCount;
            if (colName == "colHasMachine") return item.HasMachine;
            if (colName == "colMax") return item.Max != null ? item.ConvertToStr(item.Max.Value) : null;
            if (colName == "colMin") return item.Min != null ? item.ConvertToStr(item.Min.Value) : null;
            if (colName == "colSortMode") return item.SortMode;
            if (colName == "colFormula") return item.Formula;
            if (colName == "colTestCount") return item.TestCount;
            if (colName == "colMemo") return item.Memo;
            return base.GetCellValue(item, colName);
        }
        #endregion
    }
}
