using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Text;
using HH.ZK.Model.SearchCondition;
using LJH.GeneralLibrary;
using LJH.GeneralLibrary.Core.DAL.Linq;

namespace HH.ZK.SQLite
{
    public class StudentRawScoreProvider : ProviderBase<StudentLocalRawScore, Guid>
    {
        #region 构造函数
        public StudentRawScoreProvider(string connStr, System.Data.Linq.Mapping.MappingSource ms)
            : base(connStr, ms)
        {
        }
        #endregion

        #region 重写基类方法
        protected override StudentLocalRawScore GetingItemByID(Guid id, System.Data.Linq.DataContext dc)
        {
            return dc.GetTable<StudentLocalRawScore>().SingleOrDefault(item => item.ID == id);
        }

        protected override List<StudentLocalRawScore> GetingItems(DataContext dc, SearchCondition search)
        {
            IQueryable<StudentLocalRawScore> query = dc.GetTable<StudentLocalRawScore>();
            if (search is StudentRawScoreSearchCondition)
            {
                StudentRawScoreSearchCondition con = search as StudentRawScoreSearchCondition;
                if (con.DateTimeRange != null) query = query.Where(it => it.CreateTime >= con.DateTimeRange.Begin && it.CreateTime <= con.DateTimeRange.End);
                if (!string.IsNullOrEmpty(con.StudentIDLike)) query = query.Where(it => it.StudentID.Contains(con.StudentIDLike));
                if (!string.IsNullOrEmpty(con.Name)) query = query.Where(it => it.StudentName.Contains(con.Name));
                if (con.TestID.HasValue) query = query.Where(it => it.TestID == con.TestID);
                if (!string.IsNullOrEmpty(con.HostSN)) query = query.Where(it => it.HostSn == con.HostSN);
                if (!string.IsNullOrEmpty(con.ProjectID)) query = query.Where(it => it.ProjectID == con.ProjectID);
                if (con.SyncState.HasValue)
                {
                    if (con.SyncState == 0) query = query.Where(it => it.SyncTime == null);
                    else if (con.SyncState == 1) query = query.Where(it => it.SyncTime != null && it.SyncError == null);
                    else if (con.SyncState == 2) query = query.Where(it => it.SyncTime != null && it.SyncError != null);
                }
            }
            List<StudentLocalRawScore> items = null;
            if (search.SortMode == SortMode.Asc)
            {
                items = (from sc in query
                         orderby sc.HostSn ascending, sc.ScoreSer ascending, sc.CreateTime ascending
                         select sc).ToList();
            }
            else if (search.SortMode == SortMode.Desc)
            {
                items = (from sc in query
                         orderby sc.HostSn descending, sc.ScoreSer descending, sc.CreateTime descending
                         select sc).ToList();
            }
            else items = query.ToList();
            return items;
        }
        #endregion

        #region 实现接口
        public override QueryResultList<StudentLocalRawScore> GetItems(SearchCondition search)
        {
            var ret = base.GetItems(search);
            ret.TotalCount = ret.QueryObjects != null ? ret.QueryObjects.Count : 0;
            ret.PageIndex = search != null ? search.PageIndex : 1;
            ret.PageSize = search != null ? search.PageSize : 0;
            if (search != null && search.PageSize > 0 && search.PageIndex > 0 && ret.QueryObjects != null)
            {
                var items = ret.QueryObjects.Skip(search.PageSize * (search.PageIndex - 1)).Take(search.PageSize).ToList();
                ret.QueryObjects = items;
            }
            return ret;
        }

        public CommandResult BatchAdd(List<StudentLocalRawScore> scores, string projectID)
        {
            try
            {
                var dc = CreateDataContext();
                Dictionary<string, StudentLocalRawScore> allScores = new Dictionary<string, StudentLocalRawScore>();
                var ids = scores.Select(it => it.Key).Distinct().ToList();
                var temp = dc.GetTable<StudentLocalRawScore>().Where(it => it.ProjectID == projectID && ids.Contains(it.Key)).ToList();
                foreach (var item in temp)
                {
                    if (!allScores.ContainsKey(item.Key)) allScores.Add(item.Key, item);
                }
                foreach (StudentLocalRawScore score in scores)
                {
                    if (allScores.ContainsKey(score.Key))
                    {
                        continue;
                    }
                    else
                    {
                        score.ProjectID = projectID;
                        dc.GetTable<StudentLocalRawScore>().InsertOnSubmit(score);
                        allScores.Add(score.Key, score);
                    }
                }
                dc.SubmitChanges();
                return new CommandResult(ResultCode.Successful, string.Empty);
            }
            catch (Exception ex)
            {
                LJH.GeneralLibrary.ExceptionPolicy.HandleException(ex);
                return new CommandResult(ResultCode.Fail, ex.Message);
            }
        }

        public CommandResult BatchDelete(List<StudentLocalRawScore> items, string projectID)
        {
            try
            {
                var dc = CreateDataContext();
                foreach (StudentLocalRawScore item in items)
                {
                    DeletingItem(item, dc);
                }
                dc.SubmitChanges();
                return new CommandResult(ResultCode.Successful, string.Empty);
            }
            catch (Exception ex)
            {
                LJH.GeneralLibrary.ExceptionPolicy.HandleException(ex);
                return new CommandResult(ResultCode.Fail, ex.Message);
            }
        }

        public CommandResult BatchPatch(List<UpdateItem<Guid>> patchs)
        {
            try
            {
                var ids = patchs.Select(it => it.ID).Distinct().ToList();
                var dc = CreateDataContext();
                var ss = dc.GetTable<StudentLocalRawScore>().Where(it => ids.Contains(it.ID)).ToList();
                var dic = new Dictionary<Guid, StudentLocalRawScore>();
                foreach (var s in ss)
                {
                    if (!dic.ContainsKey(s.ID)) dic.Add(s.ID, s);
                }
                foreach (var patch in patchs)
                {
                    if (!dic.ContainsKey(patch.ID)) continue;
                    var info = dic[patch.ID];
                    switch (patch.Key)
                    {
                        case "SyncTime":
                            if (!string.IsNullOrEmpty(patch.Value)) info.SyncTime = DateTime.Parse(patch.Value);
                            else info.SyncTime = null;
                            break;
                        case "SyncError":
                            info.SyncError = patch.Value;
                            break;
                        default:
                            break;
                    }
                }
                dc.SubmitChanges();
                return new CommandResult(ResultCode.Successful, string.Empty);
            }
            catch (Exception ex)
            {
                LJH.GeneralLibrary.ExceptionPolicy.HandleException(ex);
                return new CommandResult(ResultCode.Fail, ex.Message);
            }
        }
        #endregion
    }
}

