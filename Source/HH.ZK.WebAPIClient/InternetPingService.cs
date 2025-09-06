using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Net;
using System.Net.NetworkInformation;

namespace HH.ZK.WebAPIClient
{
    public class InternetPingService
    {
        public static InternetPingService Current { get; set; }

        #region 构造函数
        public InternetPingService()
        {

        }
        #endregion

        #region 私有变量
        private Thread _TCheckInternet = null;

        private void CheckConnect_Thread()
        {
            var firstTime = true;
            while (true)
            {
                try
                {
                    if (PingInternet())
                    {
                        if (Pingable == false || firstTime)
                        {
                            Pingable = true;
                            if (this.InternetConnected != null) this.InternetConnected(this, EventArgs.Empty);
                        }
                    }
                    else
                    {
                        if (Pingable == true || firstTime)
                        {
                            Pingable = false;
                            if (this.InternetDisconnected != null) this.InternetDisconnected(this, EventArgs.Empty);
                        }
                    }
                    firstTime = false;
                    Thread.Sleep(5000);
                }
                catch (ThreadAbortException)
                {
                    break;
                }
                catch (Exception)
                {

                }
            }
        }

        private bool PingInternet()
        {
            try
            {
                Ping ping = new Ping();
                PingReply reply = new Ping().Send("cn.aliyun.com", 1000);
                if (reply.Status == IPStatus.Success) return true;

                var ipAddr = IPAddress.Parse("106.52.238.226");
                reply = new Ping().Send(ipAddr, 1000);
                if (reply.Status == IPStatus.Success) return true;
                return false;
            }
            catch (Exception ex)
            {
                LJH.GeneralLibrary.ExceptionPolicy.HandleException(ex);
                return false;
            }
        }
        #endregion

        #region 公共属性
        public bool Pingable { get; set; }

        public event EventHandler InternetConnected;

        public event EventHandler InternetDisconnected;
        #endregion

        #region 公共方法
        public void Start()
        {
            if (_TCheckInternet != null)
            {
                _TCheckInternet.Abort();
                _TCheckInternet = null;
            }
            _TCheckInternet = new Thread(new ThreadStart(CheckConnect_Thread));
            _TCheckInternet.IsBackground = true;
            _TCheckInternet.Start();
        }

        public void Stop()
        {
            if (_TCheckInternet != null)
            {
                _TCheckInternet.Abort();
                _TCheckInternet = null;
            }
        }
        #endregion 
    }
}
