using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Threading;
using HH.ZK.Model;
using System.Net;
using System.Net.NetworkInformation;
using HH.ZK.Model.SearchCondition;
using LJH.GeneralLibrary;
using HH.ZK.WebAPIClient;
using HH.ZK.SQLite;
using HH.Zhongkao.Device;

namespace HH.ZK.CommonUI
{
    public class PhysicalScoresSavingService
    {
        #region 静态属性
        public static PhysicalScoresSavingService Current { get; set; }
        #endregion

        #region 构造函数
        public PhysicalScoresSavingService(PhysicalProject project)
        {
            _Project = project;
        }
        #endregion

        #region 私有变量
        private PhysicalProject _Project = null;

        private object _UnsavedRecordsLocker = new object();
        private Thread _SaveRecordsTask = null;
        private List<StudentRawScore> _UnsavedItems = new List<StudentRawScore>();
        private object _LocalDBLocker = new object();
        private Thread _UploadRecordsTask = null;
        #endregion

        #region 私有方法
        private void SaveRecordsTask()
        {
            Thread.Sleep(5000);
            List<StudentRawScore> savings = new List<StudentRawScore>();
            while (true)
            {
                try
                {
                    savings.Clear();
                    lock (_UnsavedRecordsLocker)
                    {
                        if (_UnsavedItems.Count > 0)
                        {
                            savings.AddRange(_UnsavedItems.Take(_UnsavedItems.Count > 500 ? 500 : _UnsavedItems.Count));  //每次取最多500条记录进行保存
                        }
                    }
                    if (savings.Count > 0)
                    {
                        CommandResult ret = null;
                        lock (_LocalDBLocker)
                        {
                            var temp = savings.Select(it => StudentLocalRawScore.CreateFrom(it, _Project.ID)).ToList();
                            ret = ProviderFactory.Create<StudentRawScoreProvider>(AppSettings.Current.LocalDB).BatchAdd(temp, _Project.ID);
                        }
                        if (ret != null)
                        {
                            if (ret.Result == ResultCode.Successful)
                            {
                                lock (_UnsavedRecordsLocker) //如果保存成功，则从缓存中将数据删除掉
                                {
                                    savings.ForEach(it => _UnsavedItems.Remove(it));
                                }
                            }
                            else
                            {
                                LJH.GeneralLibrary.FileLog.Log("原始成绩保存", $"原始成绩保存到本地失败：{ret.Message}");
                            }
                        }
                    }
                    Thread.Sleep(1000);
                }
                catch (ThreadAbortException)
                {
                    _SaveRecordsTask = null;
                    break;
                }
                catch (Exception ex)
                {
                    LJH.GeneralLibrary.ExceptionPolicy.HandleException(ex);
                }
            }
        }

        private void UploadRecordsTask()
        {
            while (true)
            {
                try
                {
                    Thread.Sleep(3000);
                    List<StudentLocalRawScore> items = null;
                    CommandResult<BatchOptResult<Guid, StudentScore>> ret = null;
                    lock (_LocalDBLocker)
                    {
                        var con = new StudentRawScoreSearchCondition() { SortMode = SortMode.Asc, ProjectID = _Project.ID, PageIndex = 1, PageSize = 0, SyncState = 0 };
                        items = ProviderFactory.Create<StudentRawScoreProvider>(AppSettings.Current.LocalDB).GetItems(con).QueryObjects;
                    }
                    if (items != null && items.Count > 0)
                    {
                        while (items.Count > 0)
                        {
                            var count = items.Count > 900 ? 900 : items.Count;
                            var temp = items.Take(count).ToList();
                            items.RemoveRange(0, count);
                            var scores = temp.Select(it => StudentLocalRawScore.CreateScore(it)).ToList();
                            ret = new APIClient(AppSettings.Current.ConnStr).BatchAddScores(scores, ImportOption.Append, _Project.ID);
                            if (ret != null && ret.Result == ResultCode.Successful && ret.Value != null)
                            {
                                List<UpdateItem<Guid>> patches = new List<UpdateItem<Guid>>();
                                if (ret.Value.Successes != null && ret.Value.Successes.Count > 0)
                                {
                                    patches.AddRange(from it in ret.Value.Successes
                                                     select new UpdateItem<Guid>() { ID = it.Key, Key = "SyncTime", Value = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") });
                                    patches.AddRange(from it in ret.Value.Errors
                                                     select new UpdateItem<Guid>() { ID = it.Key, Key = "SyncError", Value = null });
                                }
                                if (ret.Value.Errors != null && ret.Value.Errors.Count > 0)
                                {
                                    patches.AddRange(from it in ret.Value.Errors
                                                     select new UpdateItem<Guid>() { ID = it.Key, Key = "SyncTime", Value = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") });
                                    patches.AddRange(from it in ret.Value.Errors
                                                     select new UpdateItem<Guid>() { ID = it.Key, Key = "SyncError", Value = it.Value });
                                }
                                lock (_LocalDBLocker)
                                {
                                    ProviderFactory.Create<StudentRawScoreProvider>(AppSettings.Current.LocalDB).BatchPatch(patches);
                                }
                            }
                        }
                    }
                }
                catch (ThreadAbortException)
                {
                    _UploadRecordsTask = null;
                    break;
                }
                catch (Exception ex)
                {
                    LJH.GeneralLibrary.ExceptionPolicy.HandleException(ex);
                }
            }
        }
        #endregion

        #region 公共方法
        public void Start()
        {
            ProviderFactory.UpgradeLocalDB(AppSettings.Current.LocalDB); //更新数据库
            if (_SaveRecordsTask == null) //开启保存数据的任务
            {
                _SaveRecordsTask = new Thread(new ThreadStart(SaveRecordsTask));
                _SaveRecordsTask.IsBackground = true;
                _SaveRecordsTask.Start();
            }

            if (_UploadRecordsTask == null) //开启上传数据的任务
            {
                _UploadRecordsTask = new Thread(new ThreadStart(UploadRecordsTask));
                _UploadRecordsTask.IsBackground = true;
                _UploadRecordsTask.Start();
            }
        }

        public void Stop()
        {
            if (_SaveRecordsTask != null)
            {
                _SaveRecordsTask.Abort();
                _SaveRecordsTask = null;
            }

            if (_UploadRecordsTask != null)
            {
                _UploadRecordsTask.Abort();
                _UploadRecordsTask = null;
            }
        }

        public void AddScore(PhysicalRecord item, ScoreSource scoreFrom, string hostSN = null)
        {
            lock (_UnsavedRecordsLocker)
            {
                var score = new StudentRawScore()
                {
                    ID = Guid.NewGuid(),
                    StudentID = item.StudentNumber,
                    StudentName = item.Name,
                    Sex = item.Sex,
                    TestID = item.PhysicalItem,
                    Score = item.Result,
                    FGCount = item.FGCount,
                    CreateTime = item.RecordDate ?? DateTime.Now,
                    HostSn = hostSN,
                    HostID = item.HostID,
                    ScoreSer = item.SN,
                    ScoreFrom = scoreFrom,
                };
                if (item.SpecialResult.HasValue)
                {
                    if (item.SpecialResult == 0xA0) score.SpecialType = SpecialScoreType.犯规;
                    else if (item.SpecialResult == 0xA1) score.SpecialType = SpecialScoreType.弃考;
                    else if (item.SpecialResult == 0xA2) score.SpecialType = SpecialScoreType.未完成;
                    else score.SpecialType = SpecialScoreType.犯规;
                }
                _UnsavedItems.Add(score);
            }
        }

        public void AddScore(StudentRawScore score)
        {
            lock (_UnsavedRecordsLocker)
            {
                _UnsavedItems.Add(score);
            }
        }
        #endregion
    }
}
