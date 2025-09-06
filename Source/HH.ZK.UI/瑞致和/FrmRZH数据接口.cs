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
using System.Net;
using System.Data.SqlClient;
using HH.ZK.Model;
using HH.ZK.Model.SearchCondition;
using HH.ZK.WebAPIClient;
using LJH.GeneralLibrary.SoftDog;
using LJH.GeneralLibrary.WinformControl;
using LJH.GeneralLibrary;

namespace HH.ZK.UI.瑞致和
{
    public partial class FrmRZH数据接口 : Form
    {
        public FrmRZH数据接口()
        {
            InitializeComponent();
        }

        #region 私有变量
        private ThirdPlateFormSettings _ThirdServer = null;
        private Thread _UploadStudents = null;
        private Thread _UploadScores = null;
        private List<RZH学校信息> _SelectedFacilites = null;
        private bool _IncludePhoto = false;
        private List<Facility> _AllFacilities = null;
        private List<Division> _AllDivisions = null;
        private List<RZH学校信息> _RZHFacilities = null;
        #endregion

        #region 私有方法
        private void SaveSettings()
        {
            if (_ThirdServer == null) _ThirdServer = new ThirdPlateFormSettings() { ThirdPlateForm = ThirdPlateForm.瑞致和 };
            if (txtUrl.Text != _ThirdServer.Server || txt考点.Text != _ThirdServer.KDNumber)
            {
                _ThirdServer.Server = txtUrl.Text;
                _ThirdServer.KDNumber = txt考点.Text;
                var ret = SysParaSettingsClient.SaveSetting<ThirdPlateFormSettings>(_ThirdServer, AppSettings.Current.ConnStr, AppSettings.Current.PhysicalProject.ID);
            }
        }

        private void UploadStudentsTask()
        {
            try
            {
                _AllFacilities = new APIClient(AppSettings.Current.ConnStr).GetList<string, Facility>(null, AppSettings.Current.PhysicalProject.ID).QueryObjects;
                if (_AllFacilities == null) _AllFacilities = new List<Facility>();
                _AllDivisions = new APIClient(AppSettings.Current.ConnStr).GetList<string, Division>(null, AppSettings.Current.PhysicalProject.ID).QueryObjects;
                if (_AllDivisions == null) _AllDivisions = new List<Division>();
                var _DBClient = new RZH接口Client(_ThirdServer.Server);
                foreach (var f in _SelectedFacilites)
                {
                    int studentCount = 0;
                    var facility = SaveFacility(f);
                    if (facility == null)
                    {
                        AppendMsg($"保存学校信息失败 {f.Name}");
                        continue;
                    }
                    ShowProgress(0, pStudent, $"正在下载 {facility.Name} 的学生信息...");
                    for (int i = 1; i <= 999999; i++)
                    {
                        var ret = _DBClient.分页获取学生(_ThirdServer.KDNumber, f.ID, i, _IncludePhoto ? "Y" : "N");
                        if (ret.ret != 0)
                        {
                            AppendMsg($"获取数据失败 page={i} msg={ret.msg}");
                            continue;
                        }
                        if (ret.body.list != null && ret.body.list.Count > 0)
                        {
                            AppendMsg($"获取到第 {i} 页 {ret.body.list.Count } 条学生信息");
                            SaveStudents(ret.body.list, facility);
                            ShowProgress(i / (decimal)ret.body.pages, pStudent);
                            studentCount += ret.body.list.Count;
                        }
                        if (i == ret.body.pages || ret.body.pages == 0)
                        {
                            AppendMsg($"{facility.Name} 共获取 {studentCount} 条学生信息");
                            AppendMsg($"----------------------------------------------------------------------------------------------------");
                            break;
                        }
                    }
                }
                ShowProgress(1, pStudent, "学生信息下载完成");
            }
            catch (ThreadAbortException)
            {
            }
            catch (Exception ex)
            {
                LJH.GeneralLibrary.ExceptionPolicy.HandleException(ex);
            }
            _UploadStudents = null;
            this.Invoke((Action)(() => { btn开始下载.Text = "开始下载"; }));
        }

        private void SaveStudents(List<RZH学生信息> ss, Facility f)
        {
            var students = new List<Student>();
            var gps = new List<StudentGroup>();
            var photos = new List<StudentPhoto>();
            foreach (var s in ss)
            {
                提取襄阳学生信息(s, f, students, gps, photos);
            }
            if (students.Count > 0)
            {
                List<Student> temp = new List<Student>();
                for (int i = 0; i < students.Count; i++)
                {
                    temp.Add(students[i]);
                    if (temp.Count >= 100 || i == students.Count - 1)
                    {
                        new APIClient(AppSettings.Current.ConnStr).BatchAdd<string, Student>(temp, ImportOption.Override, AppSettings.Current.PhysicalProject.ID);
                        temp.Clear();
                    }
                }
            }
            if (gps.Count > 0)
            {
                List<StudentGroup> gtemp = new List<StudentGroup>();
                for (int i = 0; i < gps.Count; i++)
                {
                    gtemp.Add(gps[i]);
                    if (gtemp.Count >= 100 || i == gps.Count - 1)
                    {
                        new APIClient(AppSettings.Current.ConnStr).BatchAdd<Guid, StudentGroup>(gtemp, ImportOption.Override, AppSettings.Current.PhysicalProject.ID);
                        gtemp.Clear();
                    }
                }
            }
            if (photos.Count > 0)
            {
                List<StudentPhoto> potoTemp = new List<StudentPhoto>();
                for (int i = 0; i < photos.Count; i++)
                {
                    potoTemp.Add(photos[i]);
                    if (potoTemp.Count >= 100 || i == photos.Count - 1)
                    {
                        new APIClient(AppSettings.Current.ConnStr).BatchAdd<string, StudentPhoto>(potoTemp, ImportOption.Override, AppSettings.Current.PhysicalProject.ID);
                        potoTemp.Clear();
                    }
                }
            }
        }

        private void 提取襄阳学生信息(RZH学生信息 stu, Facility f, List<Student> students, List<StudentGroup> groups, List<StudentPhoto> photos)
        {
            try
            {
                var s = students.SingleOrDefault(it => it.ID == stu.考生号);
                if (s == null)
                {
                    s = new Student() { ID = stu.考生号, Name = stu.姓名, Sex = stu.性别 == "男" ? Sex.Male : Sex.Female, Grade = GradeHelper.初三, ClassName = stu.班级名称, CardID = stu.卡号, FacilityID = f.ID };
                    students.Add(s);
                    if (!string.IsNullOrEmpty(stu.测试项目))
                    {
                        var xms = stu.测试项目.Split(',');
                        foreach (var xm in xms)
                        {
                            if (!string.IsNullOrEmpty(xm)) s.增加考试科目(int.Parse(xm));
                        }
                    }
                    if (!string.IsNullOrEmpty(stu.考生相片))
                    {
                        var photo = new StudentPhoto(s.ID, Convert.FromBase64String(stu.考生相片));
                        photos.Add(photo);
                    }
                }
            }
            catch (Exception ex)
            {
                AppendMsg($"提取学生 学号={stu.考生号} 姓名={stu.姓名} 信息失败 {ex.Message}");
            }
        }

        private void UploadScoresTask()
        {
            try
            {
                var _DBClient = new RZH接口Client(_ThirdServer.Server);
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
                            var ret = _DBClient.上传成绩(_ThirdServer.KDNumber, score, s.获取成绩序号(score),s.Name);
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
                            if(patches.Count >= 100)
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

        private void ShowProgress(decimal progress, PercentageProgressBar bar, string msg = null)
        {
            this.Invoke((Action)(() =>
            {
                bar.Value = (int)(progress * 100);
                if (!string.IsNullOrEmpty(msg))
                {
                    this.txtMsg.AppendText($"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}：{msg}");
                    this.txtMsg.AppendText(System.Environment.NewLine);
                    this.txtMsg.SelectionStart = this.txtMsg.Text.Length;
                    this.txtMsg.ScrollToCaret();
                }
            }));
        }

        private void AppendMsg(string msg)
        {
            this.Invoke((Action)(() =>
            {
                this.txtMsg.AppendText($"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}：{msg}");
                this.txtMsg.AppendText(System.Environment.NewLine);
            }));
        }

        private Facility SaveFacility(RZH学校信息 info)
        {
            Division d = null;
            if (!string.IsNullOrEmpty(info.DivisionID))
            {
                d = _AllDivisions.SingleOrDefault(it => it.ID == info.DivisionID);
                if (d == null)
                {
                    var ret1 = new APIClient(AppSettings.Current.ConnStr).Add<string, Division>(new Division() { ID = info.DivisionID, Name = info.DivisionName }, AppSettings.Current.PhysicalProject.ID);
                    if (ret1.Result == ResultCode.Successful && ret1.Value != null)
                    {
                        _AllDivisions.Add(ret1.Value);
                        d = ret1.Value;
                    }
                }
            }
            var f = _AllFacilities.SingleOrDefault(it => it.ID == info.ID);
            if (f == null)
            {
                var f1 = new Facility() { ID = info.ID, Name = info.Name, DivisionID = d?.ID };
                var ret = new APIClient(AppSettings.Current.ConnStr).Add<string, Facility>(f1, AppSettings.Current.PhysicalProject.ID);
                if (ret.Result == ResultCode.Successful && ret.Value != null)
                {
                    _AllFacilities.Add(ret.Value);
                    f = ret.Value;
                }
            }
            return f;
        }
        #endregion

        #region 事件处理程序
        private void FrmHuihaiCloud_Load(object sender, EventArgs e)
        {
            _ThirdServer = SysParaSettingsClient.GetSetting<ThirdPlateFormSettings>(AppSettings.Current.ConnStr, AppSettings.Current.PhysicalProject.ID);
            txtUrl.Text = _ThirdServer?.Server;
            txt考点.Text = _ThirdServer?.KDNumber;

            chk自动上传.Checked = AppSettings.Current.GetConfigContent(string.Format("第三方接口成绩自动上传_{0}", AppSettings.Current.PhysicalProject.ID)) == "1";
            timer1.Enabled = chk自动上传.Checked;
        }

        private void btn获取学校信息_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUrl.Text) || string.IsNullOrEmpty(txt考点.Text))
            {
                MessageBox.Show("没有指定连接参数");
                return;
            }
            SaveSettings();
            txtMsg.Text = string.Empty;
            var _DBClient = new RZH接口Client(_ThirdServer.Server);
            var ret = _DBClient.获取学校信息(_ThirdServer.KDNumber);
            if (ret != null && ret.Result == ResultCode.Successful && ret.QueryObjects != null && ret.QueryObjects.Count > 0)
            {
                var divisions = (from it in ret.QueryObjects where !string.IsNullOrEmpty(it.DivisionName) orderby it.DivisionName ascending select it.DivisionName).Distinct().ToList();
                if (divisions != null && divisions.Count > 0)
                {
                    txtDivision.Items.Clear();
                    txtDivision.Items.Add(string.Empty);
                    foreach (var d in divisions)
                    {
                        txtDivision.Items.Add(d);
                    }
                }
                _RZHFacilities = ret.QueryObjects.ToList();
                var temp = ret.QueryObjects.ToList();
                temp.Insert(0, new RZH学校信息());
                txtSchool.DataSource = temp;
                txtSchool.DisplayMember = "Name";
                AppendMsg("获取学校信息成功!");
            }
            else
            {
                AppendMsg(ret.Message);
            }
        }

        private void txtDivision_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_RZHFacilities != null && _RZHFacilities.Count > 0)
            {
                var temp = _RZHFacilities.ToList();
                if (!string.IsNullOrEmpty(txtDivision.Text)) temp = temp.Where(it => it.DivisionName == txtDivision.Text).ToList();
                temp.Insert(0, new RZH学校信息());
                txtSchool.DataSource = temp;
                txtSchool.DisplayMember = "Name";
            }
        }

        private void btn开始下载_Click(object sender, EventArgs e)
        {
            if (btn开始下载.Text == "开始下载")
            {
                if (string.IsNullOrEmpty(txtUrl.Text) || string.IsNullOrEmpty(txt考点.Text))
                {
                    MessageBox.Show("没有指定连接参数");
                    return;
                }
                SaveSettings();
                if(txtSchool.DataSource == null)
                {
                    MessageBox.Show("请选获取学校信息");
                    return;
                }
                if (!string.IsNullOrEmpty(txtSchool.Text))
                {
                    _SelectedFacilites = new List<RZH学校信息>() { txtSchool.SelectedItem as RZH学校信息 };
                }
                else
                {
                    _SelectedFacilites = (txtSchool.DataSource as List<RZH学校信息>).ToList();
                    _SelectedFacilites.RemoveAll(it => it.ID == null);
                }
                _IncludePhoto = chk照片.Checked;
                txtMsg.Text = string.Empty;
                _UploadStudents = new Thread(new ThreadStart(UploadStudentsTask));
                _UploadStudents.IsBackground = true;
                _UploadStudents.Start();
                btn开始下载.Text = "结束下载";
            }
            else
            {
                if (_UploadStudents != null && _UploadStudents.ThreadState != ThreadState.Stopped)
                {
                    _UploadStudents.Abort();
                    _UploadStudents = null;
                }
                btn开始下载.Text = "开始下载";
                pStudent.Value = 0;
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (btnUpload.Text == "开始上传")
            {
                if (string.IsNullOrEmpty(txtUrl.Text) || string.IsNullOrEmpty(txt考点.Text))
                {
                    MessageBox.Show("没有指定汇海云平台的数据库连接参数");
                    return;
                }
                SaveSettings();
                _UploadScores = new Thread(new ThreadStart(UploadScoresTask));
                _UploadScores.IsBackground = true;
                _UploadScores.Start();
                btnUpload.Text = "结束上传";
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

        private void chk自动上传_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Enabled = chk自动上传.Checked;
            AppSettings.Current.SaveConfig(string.Format("第三方接口成绩自动上传_{0}", AppSettings.Current.PhysicalProject.ID), chk自动上传.Checked ? "1" : "0");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUrl.Text) || string.IsNullOrEmpty(txt考点.Text)) return;
            if (_UploadScores == null) btnUpload.PerformClick();
        }

        private void FrmHuihaiCloud_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.timer1.Enabled = false;
            if (_UploadStudents != null) _UploadStudents.Abort();
            if (_UploadScores != null) _UploadScores.Abort();
        }
        #endregion
    }
}
