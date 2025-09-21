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
using HH.Zhongkao.Device;

namespace HH.ZK.CommonUI
{
    public class PhysicalScoresSavingService
    {
        #region 静态属性
        public static PhysicalScoresSavingService Current { get; set; }
        #endregion

        #region 构造函数
        public PhysicalScoresSavingService(Project project)
        {
            _Project = project;
        }
        #endregion

        #region 私有变量
        private Project _Project = null;

        private object _UnsavedRecordsLocker = new object();
        private Thread _SaveRecordsTask = null;
        private List<StudentRawScore> _UnsavedItems = new List<StudentRawScore>();
        private object _LocalDBLocker = new object();
        private Thread _UploadRecordsTask = null;
        #endregion

        #region 公共方法
        public void Start()
        {
            
        }

        public void Stop()
        {
            
        }

        public void AddScore(PhysicalRecord item, ScoreSource scoreFrom, string hostSN = null)
        {
            
        }

        public void AddScore(StudentRawScore score)
        {
            
        }
        #endregion
    }
}
