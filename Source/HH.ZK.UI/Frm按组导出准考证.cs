using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Data;
using System.Threading;
using System.Windows.Forms;
using HH.ZK.Model;
using HH.ZK.Model.SearchCondition;
using HH.ZK.CommonUI;
using HH.ZK.WebAPIClient;
using HH.ZK.UI.Controls;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace HH.ZK.UI
{
    public partial class Frm按组导出准考证 : Form
    {
        public Frm按组导出准考证()
        {
            InitializeComponent();
        }

        public List<StudentGroupSummary> PrintingGroups { get; set; }

        #region 私有变量
        private string ExportTo = null;
        private bool _GroupBySex = false;
        private bool _CreateFacilityFolder = false;
        private int _Printed = 0;
        private ICertificateTemplate pnlCertificate = null;
        private int _CountPerPaper = 0; //每张纸打印的学生个数
        private int _Width = 0;
        private int _Height = 0;
        private int _Padding = 0;
        private int _Cols = 0;
        private Thread _exportThread = null;
        private bool _PrintSerial = false;

        #endregion

        #region 私有方法
        private void 设置准考证模板()
        {
            pnlCertificate = null;
            if (txt排版.SelectedIndex == 0)
            {
                pnlCertificate = new UCCertificateTemplate();
                (pnlCertificate as Control).Top = this.Height + 100;
                this.Controls.Add(pnlCertificate as Control);
                _Width = 365;
                _Height = 280;
                _Padding = 20;
                _Cols = 2;
                _CountPerPaper = 8;
            }
            else if (txt排版.SelectedIndex == 1)
            {
                pnlCertificate = new UCCertificateTemplate();
                (pnlCertificate as Control).Top = this.Height + 100;
                this.Controls.Add(pnlCertificate as Control);
                _Width = 365;
                _Height = 280;
                _Padding = 20;
                _Cols = 3;
                _CountPerPaper = 15;
            }
            else if (txt排版.SelectedIndex == 2)
            {
                pnlCertificate = new UCCertificateTemplate_Small();
                (pnlCertificate as Control).Top = this.Height + 100;
                this.Controls.Add(pnlCertificate as Control);
                _Width = 365;
                _Height = 200;
                _Padding = 20;
                _Cols = 3;
                _CountPerPaper = 21;
            }
            else if (txt排版.SelectedIndex == 3)
            {
                pnlCertificate = new UCCertificateTemplate_A4();
                (pnlCertificate as Control).Top = this.Height + 100;
                this.Controls.Add(pnlCertificate as Control);
                _Width = 400;
                _Height = 500;
                _Padding = 40;
                _Cols = 2;
                _CountPerPaper = 4;
            }
            else if (txt排版.SelectedIndex == 4)
            {
                pnlCertificate = new UCCertificateTemplate();
                (pnlCertificate as Control).Top = this.Height + 100;
                this.Controls.Add(pnlCertificate as Control);
                _Width = 365;
                _Height = 280;
                _Padding = 20;
                _Cols = 2;
                _CountPerPaper = 6;
            }
            else if (txt排版.SelectedIndex == 5)
            {
                if (AppSettings.Current.PhysicalProject.SchoolID == "1000027") pnlCertificate = new UCCertificateTemplate_江西();
                else pnlCertificate = new UCCertificateTemplate_阳江();
                (pnlCertificate as Control).Top = this.Height + 100;
                this.Controls.Add(pnlCertificate as Control);
                _Width = 800;
                _Height = 500;
                _Padding = 40;
                _Cols = 1;
                _CountPerPaper = 2;
            }
        }

        private void 导出到文件_Thread()
        {
            try
            {
                _Printed = 0;
                var ret = 生成PDF(ExportTo, PrintingGroups,  PrintingGroups.Count);
                _exportThread = null;
                this.Invoke((Action)(() =>
                {
                    this.lblMsg.Text = "导出完成";
                    this.progressBar1.Value = 100;
                    btn导出.Text = "开始导出";
                    if (ret && File.Exists(ExportTo)) OpenPDF(ExportTo);
                }));
            }
            catch (ThreadAbortException)
            {
            }
            catch (Exception)
            {
            }
        }

        private void 导出到文件夹_Thread()
        {
            try
            {
                _Printed = 0;
                var groups = from it in PrintingGroups
                             group it by new { FacilityName = string.IsNullOrEmpty(it.FacilityName) ? "准考证" : it.FacilityName, Sex = _GroupBySex ? it.Sex : null };
                foreach (var group in groups)
                {
                    string pdfFile = null;
                    pdfFile = ExportTo;
                    if (_CreateFacilityFolder)
                    {
                        pdfFile = Path.Combine(pdfFile, group.Key.FacilityName);
                        if (!Directory.Exists(pdfFile)) Directory.CreateDirectory(pdfFile);
                    }
                    if (group.Key.Sex.HasValue) pdfFile = Path.Combine(pdfFile, $"{group.Key.FacilityName}({SexStr(group.Key.Sex.Value)}).pdf");
                    else pdfFile = Path.Combine(pdfFile, $"{group.Key.FacilityName}.pdf");
                    生成PDF(pdfFile, group.ToList(),  PrintingGroups.Count);
                }
                _exportThread = null;
                this.Invoke((Action)(() =>
                {
                    this.lblMsg.Text = "导出完成";
                    this.progressBar1.Value = 100;
                    btn导出.Text = "开始导出";
                }));
            }
            catch (ThreadAbortException)
            {
            }
            catch (Exception)
            {
            }
        }

        private string SexStr(Sex sex)
        {
            return sex == Sex.Male ? "男" : "女";
        }

        private void OpenPDF(string pdfFile)
        {
            if (System.IO.File.Exists(pdfFile))
            {
                try
                {
                    System.Diagnostics.Process.Start(pdfFile);
                }
                catch (Exception ex)
                {
                    LJH.GeneralLibrary.ExceptionPolicy.HandleException(ex);
                }
            }
        }

        private void DeletePDF(string pdfFile)
        {
            if (System.IO.File.Exists(pdfFile))
            {
                try
                {
                    File.Delete(pdfFile);
                }
                catch (Exception ex)
                {
                    LJH.GeneralLibrary.ExceptionPolicy.HandleException(ex);
                }
            }
        }

        private void AppendError(string error)
        {
            Action action = delegate ()
            {
                txtError.AppendText(error);
                txtError.AppendText(System.Environment.NewLine);
            };
            if (this.InvokeRequired) this.Invoke(action);
            else action();
        }

        private Bitmap CreatePrintImage(StudentGroupSummary sg, List<Student> ss, int cols)
        {
            (pnlCertificate as Control).Width = _Width;
            (pnlCertificate as Control).Height = _Height;
            int xPadding = _Padding;
            int yPadding = _Padding;
            int rows = (int)Math.Ceiling((double)_CountPerPaper / cols);
            int x = 0;
            int y = 0;
            Bitmap bp = new Bitmap((_Width + xPadding) * cols + xPadding, (_Height + yPadding) * rows + yPadding);
            var con = new StudentSearchCondition() { StudentIDS = ss.Select(it => it.ID).ToList() };
            var cr = new APIClient(AppSettings.Current.ConnStr).GetList<string, StudentPhoto>(con, AppSettings.Current.PhysicalProject.ID);
            if (cr.Result != LJH.GeneralLibrary.ResultCode.Successful)
            {
                AppendError($"{sg.FullName} 获取人员照片失败");
                return null;
            }
            else
            {
                var photos = cr.QueryObjects;
                for (int i = 0; i < ss.Count; i++)
                {
                    x = (_Width + xPadding) * (i % cols) + xPadding;
                    y = (_Height + yPadding) * (i / cols) + yPadding;
                    var s = ss[i];
                    var sp = photos?.SingleOrDefault(it => it.ID == ss[i].ID);
                    pnlCertificate.FillCertificate(s, sg.Name, _PrintSerial ? ss[i].Channel : null, AppSettings.Current.PhysicalProject.Options?.CertificateTitle, sp);
                    (pnlCertificate as Control).DrawToBitmap(bp, new System.Drawing.Rectangle(x, y, _Width, _Height));
                }
                return bp;
            }
        }

        private bool 生成PDF(string pdfFile, List<StudentGroupSummary> items, int totalCount)
        {
            Document doc = null;
            PdfWriter pdf = null;
            try
            {
                doc = new Document();
                pdf = PdfWriter.GetInstance(doc, new FileStream(pdfFile, FileMode.Create, FileAccess.Write));
                doc.Open();
                foreach (var gp in items)
                {
                    _Printed++;
                    Action action = delegate ()
                    {
                        this.lblMsg.Text = string.Format("共 {0} 组 正在导出第 {1} 组 {2} ...", totalCount, _Printed, gp.FullName);
                        this.progressBar1.Value = (int)((decimal)_Printed / totalCount * 100);
                    };
                    this.Invoke(action);
                    导出准考证(gp, doc);
                }
                if (doc.IsOpen()) doc.Close();
                if (pdf != null) pdf.Close();
                return true;
            }
            catch (ThreadAbortException)
            {
                if (doc.IsOpen()) doc.Close();
                if (pdf != null) pdf.Close();
                DeletePDF(pdfFile);
                return false;
            }
            catch (Exception)
            {
                if (doc.IsOpen()) doc.Close();
                if (pdf != null) pdf.Close();
                DeletePDF(pdfFile);
                return false;
            }
        }

        private void 导出准考证(StudentGroupSummary group, Document doc)
        {
            try
            {
                var con = new StudentSearchCondition() { GroupID = group.ID };
                var cr = new APIClient(AppSettings.Current.ConnStr).GetList<string, Student>(con, AppSettings.Current.PhysicalProject.ID);
                if (cr.Result != LJH.GeneralLibrary.ResultCode.Successful)
                {
                    AppendError($"{group.FullName} 获取学生信息失败，未导到PDF");
                }
                else
                {
                    var ss = cr.QueryObjects;
                    if (ss == null || ss.Count == 0) return;
                    List<Student> temp = new List<Student>();
                    Action action = delegate ()
                    {
                        Bitmap bp = CreatePrintImage(group, temp, _Cols);
                        if (bp != null)
                        {
                            doc.SetPageSize(new iTextSharp.text.Rectangle(bp.Width + 20, bp.Height + 20));
                            doc.SetMargins(10, 10, 10, 10);
                            var img = iTextSharp.text.Image.GetInstance(bp, BaseColor.WHITE);
                            doc.NewPage();
                            doc.Add(img);
                        }
                        temp.Clear();
                    };

                    foreach (var s in ss)
                    {
                        if (temp.Count < _CountPerPaper) temp.Add(s);
                        if (temp.Count >= _CountPerPaper)
                        {
                            this.Invoke(action);
                        }
                    }
                    if (temp.Count > 0)
                    {
                        this.Invoke(action);
                    }
                }
            }
            catch (Exception ex)
            {
                LJH.GeneralLibrary.ExceptionPolicy.HandleException(ex);
            }
        }
        #endregion

        #region 事件处理程序
        private void Frm按组导出准考证_Load(object sender, EventArgs e)
        {
            txt排版.SelectedIndex = 0;
            var temp = AppSettings.Current.GetConfigContent("ZKZ_Paiban");
            if (!string.IsNullOrEmpty(temp)) txt排版.SelectedIndex = int.Parse(temp);
            temp = AppSettings.Current.GetConfigContent("ZKZ_Serial");
            if (!string.IsNullOrEmpty(temp)) chk打印序号.Checked = temp == "1";
        }

        private void rd导成一个文件_CheckedChanged(object sender, EventArgs e)
        {
            btnFileBrowser.Enabled = rd导成一个文件.Checked;
        }

        private void btnFileBrowser_Click(object sender, EventArgs e)
        {
            var dig = new SaveFileDialog();
            dig.Filter = "PDF文档|*.pdf|所有文件(*.*)|*.*";
            dig.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (dig.ShowDialog() == DialogResult.OK)
            {
                txtFile.Text = dig.FileName;
            }
        }

        private void rd导出到多个文件_CheckedChanged(object sender, EventArgs e)
        {
            chk分学校.Enabled = rd导出到多个文件.Checked;
            chk分性别.Enabled = rd导出到多个文件.Checked;
            btnOpenDir.Enabled = rd导出到多个文件.Checked;
        }

        private void btnOpenDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dig = new FolderBrowserDialog();
            if (dig.ShowDialog() == DialogResult.OK)
            {
                txtFolder.Text = dig.SelectedPath;
            }
        }

        private void btn导出_Click(object sender, EventArgs e)
        {
            if (btn导出.Text == "取消")
            {
                if (_exportThread != null)
                {
                    _exportThread.Abort();
                    _exportThread = null;
                }
                btn导出.Text = "开始导出";
            }
            else
            {
                if (CheckInput() == false) return;
                AppSettings.Current.SaveConfig("ZKZ_Paiban", txt排版.SelectedIndex.ToString());
                AppSettings.Current.SaveConfig("ZKZ_Serial", chk打印序号.Checked ? "1" : "0");
                _PrintSerial = chk打印序号.Checked;
                txtError.Text = string.Empty;

                设置准考证模板();
                if (pnlCertificate != null && PrintingGroups != null)
                {
                    if (rd导成一个文件.Checked)
                    {
                        ExportTo = txtFile.Text;
                        _exportThread = new Thread(new ThreadStart(导出到文件_Thread));
                        _exportThread.Start();
                    }
                    else if (rd导出到多个文件.Checked)
                    {
                        ExportTo = txtFolder.Text;
                        _GroupBySex = chk分性别.Checked;
                        _CreateFacilityFolder = chk分学校.Checked;
                        _exportThread = new Thread(new ThreadStart(导出到文件夹_Thread));
                        _exportThread.Start();
                    }
                    btn导出.Text = "取消";
                }
            }
        }

        private bool CheckInput()
        {
            if (rd导成一个文件.Checked == false && rd导出到多个文件.Checked == false)
            {
                MessageBox.Show("请选择一种文件导出方式");
                return false;
            }
            if (rd导成一个文件.Checked && string.IsNullOrEmpty(txtFile.Text))
            {
                MessageBox.Show("请选择要导出到哪个文件");
                return false;
            }
            if(rd导出到多个文件.Checked && string.IsNullOrEmpty (txtFolder.Text))
            {
                MessageBox.Show("请选择要导出到哪个文件夹");
                return false;
            }
            return true;
        }

        private void Frm按组导出准考证_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_exportThread != null)
            {
                _exportThread.Abort();
                _exportThread = null;
            }
        }
        #endregion

        
    }
}
