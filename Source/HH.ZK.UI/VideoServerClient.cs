using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Windows.Forms;
using HH.ZK.Model;
using HH.ZK.CommonUI;
using LJH.GeneralLibrary;
using Newtonsoft.Json;

namespace HH.ZK.UI
{
    public class VideoServerClient
    {
        #region 构造函数
        public VideoServerClient(string serverUrl)
        {
            _BaseUrl = serverUrl;
        }
        #endregion

        #region 私有变量
        private readonly string _AppKEY = "8fab4be99a6d079822c20e7128870ea0";
        private string _Token = null;
        private string _UserName = "huihai";
        private string _Password = "#$wx*&on";
        private string _Role = "user";
        private string _BaseUrl = null;
        #endregion

        #region 私有方法
        private void LogIn()
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    string url = _BaseUrl.TrimEnd('/') + "/login";
                    client.Headers.Add("accept", "application/json;charset=utf-8");
                    client.Headers.Add("Content-Type", "application/json;charset=utf-8");
                    var content = JsonConvert.SerializeObject(new { appkey = _AppKEY, username = _UserName, password = _Password, role = _Role });
                    var retBytes = client.UploadData(url, "POST", ASCIIEncoding.UTF8.GetBytes(content));
                    var ret = JsonConvert.DeserializeObject<VideoServerBaseResponse>(ASCIIEncoding.UTF8.GetString(retBytes));
                    if (ret.code == 200) _Token = ret.description;
                }
            }
            catch (Exception ex)
            {
                LJH.GeneralLibrary.ExceptionPolicy.HandleException(ex);
            }
        }

        private string CreateDirectories(string path,string root)
        {
            try
            {
                var dic = Path.GetDirectoryName(path);
                var temp = Path.Combine(root, dic);
                if (Directory.Exists(temp)) return temp;
                Directory.CreateDirectory(temp);
                return temp;
            }
            catch (Exception ex)
            {
                LJH.GeneralLibrary.ExceptionPolicy.HandleException(ex);
                return null;
            }
        }
        #endregion

        #region 公共方法
        public QueryResultList<TBVideoItem> 按考生号项目获取视频(string sid, int pid)
        {
            string url = string.Empty;
            if (pid > 0) url = string.Format("{0}/auth/GET/video/studentId/testItemId?studentId={01}&testItemId={2}", _BaseUrl.TrimEnd('/'), sid, pid);
            else url = string.Format("{0}/auth/GET/video/studentId?studentId={1}", _BaseUrl.TrimEnd('/'), sid);
            return 查询视频(url);
        }

        public QueryResultList<TBVideoItem> 获取所有视频()
        {
            string url = _BaseUrl.TrimEnd('/') + "/auth/GET/allVideoList";
            return 查询视频(url);
        }

        private QueryResultList<TBVideoItem> 查询视频(string url)
        {
            try
            {
                if (string.IsNullOrEmpty(_Token)) LogIn();
                if (string.IsNullOrEmpty(_Token))
                {
                    return new QueryResultList<TBVideoItem>(ResultCode.Fail, "登录视频服务器失败", null);
                }
                using (var client = new WebClient())
                {
                    client.Headers.Add("accept", "application/json;charset=utf-8");
                    client.Headers.Add("Authorization", string.Format("{0} {1}", "Bearer", _Token));
                    var data = client.DownloadData(url);
                    if (data != null && data.Length > 0)
                    {
                        var ret = JsonConvert.DeserializeObject<VideoListResponse>(System.Text.ASCIIEncoding.UTF8.GetString(data));
                        if (ret != null && ret.entity != null && ret.entity.Length > 0)
                        {
                            var items = (from it in ret.entity
                                         orderby it.testTime descending
                                         select it).ToList();
                            return new QueryResultList<TBVideoItem>(ResultCode.Successful, null, items);
                        }
                    }
                    return new QueryResultList<TBVideoItem>(ResultCode.Successful, null, null);
                }
            }
            catch (Exception ex)
            {
                return new QueryResultList<TBVideoItem>(ResultCode.Fail, ex.Message, null);
            }
        }

        public CommandResult 请求上传视频(List<TBVideoItem> items)
        {
            try
            {
                if (string.IsNullOrEmpty(_Token)) LogIn();
                if (string.IsNullOrEmpty(_Token)) return new CommandResult(ResultCode.Fail, "登录视频服务器失败");
                using (WebClient client = new WebClient())
                {
                    string url = _BaseUrl.TrimEnd('/') + "/auth/GET/video/pull";
                    client.Headers.Add("accept", "application/json;charset=utf-8");
                    client.Headers.Add("Content-Type", "application/json;charset=utf-8");
                    client.Headers.Add("Authorization", string.Format("{0} {1}", "Bearer", _Token));
                    var content = JsonConvert.SerializeObject(new { username = _UserName, videoNameList = items.Select(it => it.videoName).ToArray() });
                    var retBytes = client.UploadData(url, "POST", ASCIIEncoding.UTF8.GetBytes(content));
                    var ret = JsonConvert.DeserializeObject<VideoServerBaseResponse>(ASCIIEncoding.UTF8.GetString(retBytes));
                    if (ret.code == 200)
                    {
                        items.ForEach(it => it.isSync = 2);
                        return new CommandResult(ResultCode.Successful, null);
                    }
                    return new CommandResult(ResultCode.Fail, string.Format("错误：{0}--{1}", ret.code, ret.description));
                }
            }
            catch (Exception ex)
            {
                return new CommandResult(ResultCode.Fail, ex.Message);
            }
        }

        public string SaveVideo(TBVideoItem item,string root)
        {
            var path = CreateDirectories(item.videoPathInCamera, root);
            if (string.IsNullOrEmpty(path))
            {
                MessageBox.Show("创建视频路径出错");
                return null;
            }
            var file = System.IO.Path.Combine(path, item.videoName);
            if (System.IO.File.Exists(file)) return file;
            var tempFile = System.IO.Path.Combine(path, Guid.NewGuid() + ".mp4");

            if (string.IsNullOrEmpty(_Token)) LogIn();
            if (string.IsNullOrEmpty(_Token))
            {
                MessageBox.Show("登录视频服务器失败");
                return null;
            }

            FrmProcessing frm = new FrmProcessing();
            try
            {
                string url = string.Format("{0}/auth/GET/download/video/{1}", _BaseUrl.TrimEnd('/'), item.videoName);
                using (var client = new WebClient())
                {
                    client.Headers.Add("Authorization", string.Format("{0} {1}", "Bearer", _Token));
                    client.DownloadProgressChanged += delegate(object sender, DownloadProgressChangedEventArgs e)
                    {
                        if (item.videoSize > 0) frm.ShowProgress("正在下载...", (decimal)e.BytesReceived / item.videoSize);
                        else frm.ShowProgress("正在下载...", 0);
                    };
                    client.DownloadFileCompleted += delegate(object sender, AsyncCompletedEventArgs e)
                    {
                        frm.ShowProgress("下载完成", 1);
                        if (e.Error != null)
                        {
                            System.IO.File.Delete(tempFile);
                            tempFile = null;
                        }
                        else
                        {
                            System.IO.File.Copy(tempFile, file);
                        }
                    };
                    client.DownloadFileAsync(new Uri(url), tempFile);
                }
                frm.ShowDialog();
                if (System.IO.File.Exists(tempFile)) System.IO.File.Delete(tempFile);
                if (!string.IsNullOrEmpty(file) && System.IO.File.Exists(file)) return file;
            }
            catch (Exception ex)
            {
                frm.ShowProgress(ex.Message, 0);
                return null;
            }
            return null;
        }
        #endregion
    }

    internal class VideoServerBaseResponse
    {
        public int code { get; set; }

        public string description { get; set; }
    }

    internal class VideoListResponse : VideoServerBaseResponse
    {
        public TBVideoItem[] entity { get; set; }
    }

    public class TBVideoItem : IEntity<int>
    {
        public int ID { get; set; }
        public string studentId { get; set; }
        public string videoName { get; set; }
        public int videoSize { get; set; }
        public DateTime testTime { get; set; }
        public int testItemId { get; set; } //测试项目编号
        public string testItemName { get; set; }  //测试项目
        public string cameraIMEI { get; set; }  //摄像机ID
        public string cameraLocation { get; set; }
        public string videoPathInCamera { get; set; }  //视频本地路径
        public int isSync { get; set; }
        public string testVenue { get; set; }  //考场

        public string FileSizeFormat()
        {
            Decimal OneKiloByte = 1024M;
            Decimal OneMegaByte = OneKiloByte * 1024M;
            Decimal OneGigaByte = OneMegaByte * 1024M;
            string suffix;
            decimal temp = 0;
            if (this.videoSize > OneGigaByte)
            {
                temp = (decimal)this.videoSize / OneGigaByte;
                suffix = "GB";
            }
            else if (this.videoSize > OneMegaByte)
            {
                temp = (decimal)this.videoSize / OneMegaByte;
                suffix = "MB";
            }
            else if (this.videoSize > OneKiloByte)
            {
                temp = (decimal)this.videoSize / OneKiloByte;
                suffix = "kB";
            }
            else
            {
                temp = (decimal)this.videoSize;
                suffix = " B";
            }
            temp = Math.Round(temp, 2);
            return String.Format("{0:F}{1}", temp, suffix);
        }

        public string CameraLocationStr
        {
            get
            {
                if (cameraLocation == "0") return "默认";
                else if (cameraLocation == "1") return "起点";
                else if (cameraLocation == "2") return "终点";
                else if (cameraLocation == "3") return "东";
                else if (cameraLocation == "4") return "南";
                else if (cameraLocation == "5") return "西";
                else if (cameraLocation == "6") return "北";
                return cameraLocation;
            }
        }

        public string  考点
        {
            get
            {
                if(!string.IsNullOrEmpty (videoPathInCamera))
                {
                    var strs = videoPathInCamera.Split('/');
                    if (strs != null && strs.Length > 3) return strs[2];
                }
                return null;
            }
        }
    }
}
