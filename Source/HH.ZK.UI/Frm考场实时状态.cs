using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using HH.ZK.Model;
using HH.ZK.Model.SearchCondition;
using HH.ZK.Model.CRM;
using HH.ZK.WebAPIClient;
using HH.ZK.CommonUI;
using HH.ZK.UI.Controls;

namespace HH.ZK.UI
{
    public partial class Frm考场实时状态 : LJH.GeneralLibrary.WinForm.FrmGenericReportBase<string, PhysicalProjectStatistic>
    {
        public Frm考场实时状态()
        {
            InitializeComponent();
        }

        private string _PnlLeftWidthConfig = System.IO.Path.Combine(Application.StartupPath, "PnlLeftWidthConf.xml");

        #region 重写基类方法
        protected override DataGridView GridView
        {
            get
            {
                return this.dataGridView1;
            }
        }
        #endregion

        private PhysicalProjectSearchCondition _Search = null;

        private Thread _ThreadFresh = null;

        private void FreshData()
        {
            bool firstTime = true;
            while (true)
            {
                try
                {
                    Thread.Sleep(firstTime ? 3000 : 60000);
                    firstTime = false;
                    var _Projects = new APIClient(AppSettings.Current.ConnStr).GetList<string, PhysicalProjectStatistic>(_Search, null).QueryObjects;
                    Action action = delegate ()
                    {
                        dataGridView1.Rows.Clear();
                        if (_Projects != null && _Projects.Count > 0)
                        {
                            foreach (var p in _Projects)
                            {
                                int row = dataGridView1.Rows.Add();
                                ShowStateOnRow(dataGridView1.Rows[row], p);
                                foreach (var c in pnlView.Controls)
                                {
                                    var uc = c as UC考场进度;
                                    if (uc != null && (uc.Tag as PhysicalProjectStatistic).ID == p.ID)
                                    {
                                        uc.FreshState(p);
                                    }
                                }
                            }
                        }
                        FreshStatusBar();
                    };
                    this.Invoke(action);
                }
                catch (ThreadAbortException ex)
                {
                }
                catch (Exception ex)
                {
                }
            }
        }

        private Controls.UC考场进度 GetControl(string projectID)
        {
            return null;
        }

        private void ShowStateOnRow(DataGridViewRow row, PhysicalProjectStatistic ps)
        {
            row.Tag = ps;
            row.Cells["col考点"].Value = ps.Name;
            row.Cells["col总人数"].Value = ps.TotalCount;
            row.Cells["col已考人数"].Value = ps.Completed;
            row.Cells["col已检录人数"].Value = ps.Checked;
            row.Cells["col缺免考数"].Value = ps.Absent;
            row.Cells["col今日已考试人数"].Value = ps.TodayCompleted;
            row.Cells["col今日已检录数"].Value = ps.TodayChecked;
            if (ps.TotalCount > 0)
            {
                row.Cells["col完成进度"].Value = ((decimal)(ps.Completed + ps.Absent) / ps.TotalCount).ToString("P0");
                row.Cells["col检录进度"].Value = ((decimal)(ps.Checked + ps.Absent) / ps.TotalCount).ToString("P0");
            }
        }

        #region 事件处理程序
        private void Frm考场实时状态_Load(object sender, EventArgs e)
        {
            int top = 0;
            var temp = GetConfig(_PnlLeftWidthConfig, string.Format("{0}_PnlTop", this.GetType().Name));
            if (!string.IsNullOrEmpty(temp) && int.TryParse(temp, out top) && top > 0) pnlTop.Height = top;
            FreshStatusBar();
            if (_ThreadFresh == null)
            {
                _ThreadFresh = new Thread(new ThreadStart(FreshData));
                _ThreadFresh.IsBackground = true;
                _ThreadFresh.Start();
            }
        }

        private void Frm考场实时状态_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveConfig(_PnlLeftWidthConfig, string.Format("{0}_PnlTop", this.GetType().Name), pnlTop.Height.ToString());
            if (_ThreadFresh != null)
            {
                _ThreadFresh.Abort();
                _ThreadFresh = null;
            }
        }

        private void studentView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var p = dataGridView1.Rows[e.RowIndex].Tag as PhysicalProjectStatistic;
            Controls.UC考场进度 uc = null;
            if (pnlView.Controls.Count == 0)
            {
                uc = new UI.Controls.UC考场进度();
                pnlView.Controls.Add(uc);
            }
            else
            {
                uc = pnlView.Controls[0] as Controls.UC考场进度;
            }
            uc.FreshState(p);
        }
        #endregion
    }
}
