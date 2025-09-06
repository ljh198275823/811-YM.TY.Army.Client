using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HH.ZK.CommonUI;
using HH.ZK.Model;
using HH.ZK.Model.SearchCondition;
using HH.ZK.WebAPIClient;
using LJH.GeneralLibrary.WinformControl;
using LJH.GeneralLibrary;

namespace HH.ZK.UI.小奔体育
{
    public partial class Frm小奔体育数据接口 : Form
    {
        public Frm小奔体育数据接口()
        {
            InitializeComponent();
        }

        #region 私有变量
        private Thread _UploadStudents = null;
        private Thread _UploadScores = null;
        private Thread _UploadStudentCheckInfos = null;
        private 小奔体育接口Client _DBClient = null;
        private ThirdPlateFormSettings _ThirdServer = null;
        private bool _下载照片 = false;
        #endregion

        #region 私有方法
        private void UploadStudentsTask()
        {
            try
            {
                ShowProgress(0, pStudent, "正在下载学生信息...");
                var ret = _DBClient.下载全部考生();
                if (ret != null && ret.QueryObjects != null && ret.QueryObjects.Count > 0)
                {
                    var process = 0.25m;
                    ShowProgress(process, pStudent, "正在提取学生信息...");
                    var students = new List<Student>();
                    var gps = new List<StudentGroup>();
                    var photos = new List<StudentPhoto>();
                    var counts = students.Count + gps.Count;
                    for (int i = 0; i < ret.QueryObjects.Count; i++)
                    {
                        提取学生信息(ret.QueryObjects[i], students, gps, photos);
                    }
                    ShowProgress(1, pStudent);
                    if (students.Count > 0)
                    {
                        ShowProgress(0, pStudent, "正在保存学生信息...");
                        List<Student> temp = new List<Student>();
                        for (int i = 0; i < students.Count; i++)
                        {
                            temp.Add(students[i]);
                            if (temp.Count >= 200 || i == students.Count - 1)
                            {
                                new APIClient(AppSettings.Current.ConnStr).BatchAdd<string, Student>(temp, ImportOption.Override, AppSettings.Current.PhysicalProject.ID);
                                temp.Clear();
                                ShowProgress((decimal)(i + 1) / students.Count, pStudent);
                            }
                        }
                    }
                    if (gps.Count > 0)
                    {
                        ShowProgress(0, pStudent, "正在保存学生分组信息...");
                        List<StudentGroup> gtemp = new List<StudentGroup>();
                        for (int i = 0; i < gps.Count; i++)
                        {
                            gtemp.Add(gps[i]);
                            if (gtemp.Count >= 100 || i == gps.Count - 1)
                            {
                                new APIClient(AppSettings.Current.ConnStr).BatchAdd<Guid, StudentGroup>(gtemp, ImportOption.Override, AppSettings.Current.PhysicalProject.ID);
                                gtemp.Clear();
                                ShowProgress((decimal)(i + 1) / gps.Count, pStudent);
                            }
                        }
                    }
                    if (photos.Count > 0)
                    {
                        ShowProgress(0, pStudent, "正在保存学生照片信息...");
                        List<StudentPhoto> potoTemp = new List<StudentPhoto>();
                        for (int i = 0; i < photos.Count; i++)
                        {
                            potoTemp.Add(photos[i]);
                            if (potoTemp.Count >= 50 || i == photos.Count - 1)
                            {
                                new APIClient(AppSettings.Current.ConnStr).BatchAdd<string, StudentPhoto>(potoTemp, ImportOption.Override, AppSettings.Current.PhysicalProject.ID);
                                potoTemp.Clear();
                                ShowProgress((decimal)(i + 1) / photos.Count, pStudent);
                            }
                        }
                    }
                }
            }
            catch (ThreadAbortException)
            {
            }
            catch (Exception ex)
            {
                LJH.GeneralLibrary.ExceptionPolicy.HandleException(ex);
            }
            _UploadStudents = null;
            this.Invoke((Action)(() => { btn开始下载.Text = "开始下载"; lblStudentMsg.Text = string.Empty; }));
        }

        private void UploadScoresTask()
        {
            try
            {
                var con = new StudentWithDXCJSearchCondition() { ScoreUploaded = false};
                var students = new APIClient(AppSettings.Current.ConnStr).GetList<string, StudentWithDXCJ>(con, AppSettings.Current.PhysicalProject.ID).QueryObjects;
                if (students != null && students.Count > 0)
                {
                    int count = 0;
                    ShowProgress(0, pScore);
                    var patches = new List<UpdateItem<Guid>>();
                    foreach (var s in students)
                    {
                        count++;
                        if (s.TestScores == null || s.TestScores.Count == 0) continue;
                        s.TestScores.RemoveAll(it => it.SpecialType == SpecialScoreType.作废);
                        if (s.TestScores == null || s.TestScores.Count == 0) continue;
                        foreach (var score in s.TestScores)
                        {
                            if (score.UploadTime != null) continue;
                            var ret = _DBClient.上传成绩(score, s.获取成绩序号(score), 获取项目类别(s, score.PhysicalItemID));
                            if (ret.Result == ResultCode.Successful) //0成功
                            {
                                patches.Add(new UpdateItem<Guid>() { ID = score.ID, Key = "UploadTime", Value = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") });
                                patches.Add(new UpdateItem<Guid>() { ID = score.ID, Key = "UploadMsg", Value = null });
                            }
                            else
                            {
                                patches.Add(new UpdateItem<Guid>() { ID = score.ID, Key = "UploadTime", Value = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") });
                                patches.Add(new UpdateItem<Guid>() { ID = score.ID, Key = "UploadMsg", Value = ret.Message });
                            }
                            if (patches.Count >= 100)
                            {
                                var fret = new APIClient(AppSettings.Current.ConnStr).BatchPatch<Guid, StudentScore>(patches, AppSettings.Current.PhysicalProject.ID);
                                patches.Clear();
                            }
                        }
                        ShowProgress((decimal)count / students.Count, pScore);
                    }
                    if (patches.Count > 0)
                    {
                        var fret = new APIClient(AppSettings.Current.ConnStr).BatchPatch<Guid, StudentScore>(patches, AppSettings.Current.PhysicalProject.ID);
                    }
                }
            }
            catch (ThreadAbortException)
            {
            }
            catch (Exception ex)
            {
                LJH.GeneralLibrary.ExceptionPolicy.HandleException(ex);
            }
            _UploadScores = null;
            this.Invoke((Action)(() => { btnUpload.Text = "开始上传"; }));
        }

        private void UploadStudentCheckInfoTask()
        {
            try
            {
                ShowProgress(0, p跳绳成绩);
                var ret = _DBClient.下载跳绳成绩(null);
                if (ret != null && ret.QueryObjects != null && ret.QueryObjects.Count > 0)
                {
                    ShowProgress(0.25m, p跳绳成绩);
                    foreach (var score in ret.QueryObjects)
                    {
                        PhysicalScoresSavingService.Current?.AddScore(score);
                    }
                    ShowProgress(1, p跳绳成绩);
                }
            }
            catch (ThreadAbortException)
            {
            }
            catch (Exception ex)
            {
                LJH.GeneralLibrary.ExceptionPolicy.HandleException(ex);
            }
            _UploadStudentCheckInfos = null;
            this.Invoke((Action)(() => { btn下载学生成绩.Text = "开始下载"; }));
        }

        private void 提取学生信息(小奔体育学生信息 stu, List<Student> students, List<StudentGroup> groups, List<StudentPhoto> photos)
        {
            try
            {
                var s = students.SingleOrDefault(it => it.ID == stu.考生号);
                if (s == null)
                {
                    s = new Student() { ID = stu.考生号, Name = stu.姓名, Sex = stu.性别 == "1" ? Sex.Male : Sex.Female, Grade = GradeHelper.初三, ClassName = stu.考生班级, FacilityID = stu.学校名称 };
                    students.Add(s);
                    if (stu.报考科目 != null && stu.报考科目.Length > 0)
                    {
                        foreach (var xm in stu.报考科目)
                        {
                            s.增加考试科目(xm.测试科目);
                            s.SetProperty("ZSXM" + xm.测试科目.ToString(), xm.项目代码);
                            s.SetProperty("ProjectType" + xm.测试科目.ToString(), xm.项目类别);
                        }
                    }
                    if (!string.IsNullOrEmpty(stu.考生相片) && _下载照片)
                    {
                        var tp = _DBClient.下载照片(stu.考生相片);
                        if (tp != null && tp.Length > 0)
                        {
                            var photo = new StudentPhoto(s.ID, tp);
                            photos.Add(photo);
                        }
                    }
                    int 组别 = 0;
                    int 道次 = 0;
                    if (!string.IsNullOrEmpty(stu.组别) && int.TryParse(stu.组别.TrimEnd('组'), out 组别) && !string.IsNullOrEmpty(stu.道次) && int.TryParse(stu.道次.TrimEnd('号').TrimEnd('道'), out 道次))
                    {
                        var sg = groups.SingleOrDefault(it => it.Sex == s.Sex && it.Number == 组别 && it.FacilityName == s.FacilityID);
                        if (sg == null)
                        {
                            sg = new StudentGroup()
                            {
                                ID = Guid.NewGuid(),
                                Sex = s.Sex,
                                Number = 组别,
                                FacilityName = s.FacilityID,
                                Items = new List<StudentGroupPair>()
                            };
                            groups.Add(sg);
                        }
                        if (!sg.Items.Exists(it => it.StudentID == s.ID))
                        {
                            sg.Add(new StudentGroupPair()
                            {
                                ID = Guid.NewGuid(),
                                GroupID = sg.ID,
                                StudentID = s.ID,
                                Channel = 道次,
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LJH.GeneralLibrary.ExceptionPolicy.HandleException(ex);
            }
        }

        private int 获取项目类别(StudentWithDXCJ s,int pid)
        {
            var temp = s.GetProperty("ProjectType" + pid.ToString());
            if (!string.IsNullOrEmpty(temp)) return int.Parse(temp);
            return 0;
        }

        private void ShowProgress(decimal progress, PercentageProgressBar bar, string msg = null)
        {
            this.Invoke((Action)(() =>
            {
                bar.Value = (int)(progress * 100);
                if (!string.IsNullOrEmpty(msg)) lblStudentMsg.Text = msg;
            }));
        }

        private bool ConnectToServer()
        {
            if (_ThirdServer == null || string.IsNullOrEmpty(_ThirdServer.Server) || string.IsNullOrEmpty(_ThirdServer.User) || string.IsNullOrEmpty(_ThirdServer.Password) || string.IsNullOrEmpty(txt考点.Text))
            {
                timer1.Enabled = false;
                MessageBox.Show("请先设置数据上传参数");
                return false;
            }
            else
            {
                _DBClient = new 小奔体育接口Client(_ThirdServer);
                _DBClient.LogIn();
                if (string.IsNullOrEmpty(_DBClient.Token))
                {
                    timer1.Enabled = false;
                    MessageBox.Show("登录失败,请检查参数是否正确填写");
                    return false;
                }
            }
            return true;
        }

        #endregion

        #region 事件处理程序
        private void FrmHuihaiCloud_Load(object sender, EventArgs e)
        {
            _ThirdServer = SysParaSettingsClient.GetSetting<ThirdPlateFormSettings>(AppSettings.Current.ConnStr, AppSettings.Current.PhysicalProject.ID);
            if (_ThirdServer != null)
            {
                txtUrl.Text = _ThirdServer.Server;
                txtUserID.Text = _ThirdServer.User;
                txtPasswd.Text = _ThirdServer.Password;
                txt考点.Text = _ThirdServer.KDNumber;
            }
            chk自动上传.Checked = AppSettings.Current.GetConfigContent(string.Format("第三方接口成绩自动上传_{0}", AppSettings.Current.PhysicalProject.ID)) == "1";
            timer1.Enabled = chk自动上传.Checked;
        }

        private void btnConnectTest1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUrl.Text) || string.IsNullOrEmpty(txtUserID.Text) || string.IsNullOrEmpty(txtPasswd.Text) || string.IsNullOrEmpty(txt考点.Text))
            {
                MessageBox.Show("请先设置数据上传参数");
                return;
            }
            _ThirdServer = new ThirdPlateFormSettings() { ThirdPlateForm = ThirdPlateForm.小奔体育 };
            _ThirdServer.Server = txtUrl.Text;
            _ThirdServer.User = txtUserID.Text;
            _ThirdServer.Password = txtPasswd.Text;
            _ThirdServer.KDNumber = txt考点.Text;

            var client = new 小奔体育接口Client(_ThirdServer);
            client.LogIn();
            if (!string.IsNullOrEmpty(client.Token))
            {
                MessageBox.Show("登录成功");
                var ret = SysParaSettingsClient.SaveSetting<ThirdPlateFormSettings>(_ThirdServer, AppSettings.Current.ConnStr, AppSettings.Current.PhysicalProject.ID);
                timer1.Enabled = chk自动上传.Checked;
            }
            else
            {
                MessageBox.Show("登录失败,请检查参数是否正确填写");
                timer1.Enabled = false;
            }
        }

        private void btn开始下载_Click(object sender, EventArgs e)
        {
            if (btn开始下载.Text == "开始下载")
            {
                if (ConnectToServer())
                {
                    _下载照片 = chk照片.Checked;
                    _UploadStudents = new Thread(new ThreadStart(UploadStudentsTask));
                    _UploadStudents.IsBackground = true;
                    _UploadStudents.Start();
                    btn开始下载.Text = "结束下载";
                }
            }
            else
            {
                if (_UploadStudents != null && _UploadStudents.ThreadState != ThreadState.Stopped)
                {
                    _UploadStudents.Abort();
                    _UploadStudents = null;
                }
                btn开始下载.Text = "开始下载";
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (btnUpload.Text == "开始上传")
            {
                if (ConnectToServer())
                {
                    _UploadScores = new Thread(new ThreadStart(UploadScoresTask));
                    _UploadScores.IsBackground = true;
                    _UploadScores.Start();
                    btnUpload.Text = "结束上传";
                }
            }
            else
            {
                if (_UploadScores != null && _UploadScores.ThreadState != ThreadState.Stopped)
                {
                    _UploadScores.Abort();
                    _UploadScores = null;
                }
                btnUpload.Text = "开始上传";
            }
        }

        private void btn上传检录信息_Click(object sender, EventArgs e)
        {
            if (btn下载学生成绩.Text == "开始下载")
            {
                if (ConnectToServer())
                {
                    _UploadStudentCheckInfos = new Thread(new ThreadStart(UploadStudentCheckInfoTask));
                    _UploadStudentCheckInfos.IsBackground = true;
                    _UploadStudentCheckInfos.Start();
                    btn下载学生成绩.Text = "结束下载";
                }
            }
            else
            {
                if (_UploadStudentCheckInfos != null && _UploadStudentCheckInfos.ThreadState != ThreadState.Stopped)
                {
                    _UploadStudentCheckInfos.Abort();
                    _UploadStudentCheckInfos = null;
                }
                btn下载学生成绩.Text = "开始下载";
            }
        }

        private void chk自动上传_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Enabled = chk自动上传.Checked;
            AppSettings.Current.SaveConfig(string.Format("第三方接口成绩自动上传_{0}", AppSettings.Current.PhysicalProject.ID), chk自动上传.Checked ? "1" : "0");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_UploadScores == null) btnUpload.PerformClick();
            if (_UploadStudentCheckInfos == null) btn下载学生成绩.PerformClick();
        }

        private void FrmHuihaiCloud_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.timer1.Enabled = false;
            if (_UploadStudents != null) _UploadStudents.Abort();
            if (_UploadScores != null) _UploadScores.Abort();
            if (_UploadStudentCheckInfos != null) _UploadStudentCheckInfos.Abort();
        }
        #endregion
    }
}
