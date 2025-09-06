using System;
using System.IO;
using System.Windows.Forms;
using LJH.GeneralLibrary;
using LJH.GeneralLibrary.SoftDog;

namespace HH.ZK.CommonUI
{
    public partial class FrmSoftDog : Form
    {
        public FrmSoftDog()
        {
            InitializeComponent();
        }

        public SoftwareType SoftWareType { get; set; }

        #region 私有变量
        private Random _MyRandom = new Random();
        private SoftDogReader _dogReader = null;
        private string _PubKey = @"<RSAKeyValue><Modulus>wYbaab6MxTcMwrsR8ymQZ4+0ZgAuwI3CQeWx3GQINQI/dhpwBSlULvHeRA4LUg6kJcVRAu3tDrHEryOYFUhJbtSj1vKGvmY36FHOmRX5wayw3WsrbBRiijyXLtsGEcnMcmPp0FhvoPGiWPPOruOcig5Mx1N4py15FWg7BcBtECv9NhV2HZ6Zl+c8JVTjP4jG0OP9d7Hh/vx6jFwO6hfSLH6aT2YVHjfJMNwyT7VaqULdzBN6fGW4CMDlFDQu0efLhbVciB9454QBPkMIK49YutWrZoCM8jlBmPlPIW+xyIzEc4lv1BVxMGFyRIz3DbMS1jUR0FuZln5LayHqSmXmgQ==</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";
        #endregion

        #region 私有方法
        private void ReadSoftDog()
        {
            try
            {
                var skey = @"#i~xnUc4RH1G@\)$&7z6qv9xy@~<mTR5nUR?OU}jh`4r<qN>:*xZwz~E$0";
                if (_dogReader == null) _dogReader = new SoftDogReader(skey);
                var _SoftDog = _dogReader.ReadDog();
                string sign = null;
                string fileSign = _SoftDog.ProjectNo + ".sign";
                if (File.Exists(fileSign) && File.GetLastWriteTime(fileSign) < DateTime.Now.AddDays(-30)) File.Delete(fileSign); //超过一个月的签名文件删除，重新验证
                if (!File.Exists(fileSign))
                {
                    var cr = WebAPIClient.CRMAPIClient.GetSign(_SoftDog.ProjectNo);
                    if (cr.Result == ResultCode.Successful && cr.QueryObject != null)
                    {
                        File.WriteAllText(fileSign, cr.QueryObject.Sign);
                        File.SetAttributes(fileSign, FileAttributes.Hidden);
                    }
                    else if (cr.Result == ResultCode.Successful && cr.QueryObject == null) //说明加密狗没有在CRM中注册，进行注册程序
                    {
                        var frm = new FrmUKey初始化();
                        frm.StartPosition = FormStartPosition.CenterParent;
                        frm.SoftWareType = SoftWareType;
                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            var ret = WebAPIClient.CRMAPIClient.InitUKey(frm.School, (int)SoftWareType, _SoftDog.Data);
                            if (ret.Result == ResultCode.Successful)
                            {
                                _dogReader.WriteData(ret.Value.Data);
                                _SoftDog = _dogReader.ReadDog();
                                fileSign = _SoftDog.ProjectNo + ".sign";
                                File.WriteAllText(fileSign, ret.Value.Sign);
                                File.SetAttributes(fileSign, FileAttributes.Hidden);
                            }
                            else
                            {
                                MessageBox.Show(ret.Message);
                                System.Environment.Exit(0);
                            }
                        }
                        else
                        {
                            System.Environment.Exit(0);
                        }
                    }
                }
                if (File.Exists(fileSign)) sign = File.ReadAllText(fileSign);
                if (string.IsNullOrEmpty(sign))
                {
                    MessageBox.Show("加密狗没有通过签名认证，请确保电脑连接外网正常。");
                    if (File.Exists(fileSign)) File.Delete(fileSign);
                    System.Environment.Exit(0);
                }
                if (LJH.GeneralLibrary.RSASignHelper.VerifySignedHash(_SoftDog.Data, sign, _PubKey) == false)
                {
                    MessageBox.Show("加密狗没有通过签名认证，请确保加密狗是供应商发的狗。");
                    if (File.Exists(fileSign)) File.Delete(fileSign);
                    System.Environment.Exit(0);
                }
                if ((_SoftDog.SoftwareList & SoftWareType) == 0)
                {
                    MessageBox.Show(string.Format("加密狗权限不足：此加密狗不能用于{0}！", GetSoftType()), "注意");
                    System.Environment.Exit(0);
                }
                SoftDogInfo.Current = _SoftDog;
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
                System.Environment.Exit(0);
            }
        }

        private string GetSoftType()
        {
            switch (SoftWareType)
            {
                case SoftwareType.TYPE_汇海学生体测软件:
                    return "学生体测软件";
                case SoftwareType.TYPE_汇海中考软件:
                    return "中考软件";
                case SoftwareType.TYPE_汇海国民体测软件:
                    return "国民体测软件";
                case SoftwareType.TYPE_汇海运动会软件:
                    return "运动会软件";
                default:
                    return string.Empty;
            }
        }
        #endregion

        private void FrmSoftDog_Load(object sender, EventArgs e)
        {
            ReadSoftDog();
            tmrCheckDog.Enabled = true;
        }

        private void FrmSoftDog_Activated(object sender, EventArgs e)
        {
            if (SoftDogInfo.Current != null) this.Hide();
        }

        private void tmrCheckDog_Tick(object sender, EventArgs e)
        {
            try
            {
                var _SoftDog = _dogReader.ReadDog();
                if ((_SoftDog.SoftwareList & SoftWareType) == 0)
                {
                    tmrCheckDog.Enabled = false;
                    MessageBox.Show(string.Format("加密狗权限不足：此加密狗不能用于{0}！", GetSoftType()), "注意");
                    System.Environment.Exit(0);
                }
            }
            catch (InvalidOperationException ex)
            {
                tmrCheckDog.Enabled = false;
                MessageBox.Show(ex.Message);
                tmrCheckDog.Enabled = true;
                tmrCheckDog.Interval = 1000;
            }
            int interval = _MyRandom.Next(10, 20);
            tmrCheckDog.Interval = interval * 1000;
        }
    }
}
