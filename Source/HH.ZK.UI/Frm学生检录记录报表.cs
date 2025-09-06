using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HH.ZK.Model;
using HH.ZK.Model.SearchCondition;
using HH.ZK.CommonUI;
using HH.ZK.WebAPIClient;
using LJH.GeneralLibrary;

namespace HH.ZK.UI
{
    public partial class Frm学生检录记录报表 : LJH.GeneralLibrary.WinForm.FrmReportBaseWithPaging<Guid,StudentCheckRecord>
    {
        public Frm学生检录记录报表()
        {
            InitializeComponent();
        }

        #region 重写基类方法
        protected override void Init()
        {
            base.Init();
            ucDateTimeInterval1.Init();
            ucDateTimeInterval1.SelectToday();
            ucStudentSearch1.Init(AppSettings.Current.PhysicalProject.ID);
        }

        protected override QueryResultList<StudentCheckRecord> GetDataSource(int pageSize, int pageIndex)
        {
            var con = new StudentCheckRecordSearchCondition();
            ucStudentSearch1.GetSearchCondition(con);
            con.PageIndex = pageIndex;
            con.PageSize = pageSize;
            con.CheckTime = new DateTimeRange(ucDateTimeInterval1.StartDateTime, ucDateTimeInterval1.EndDateTime);
            con.SortMode = SortMode.Desc;
            return new APIClient(AppSettings.Current.ConnStr).GetList<Guid, StudentCheckRecord>(con, AppSettings.Current.PhysicalProject.ID);
        }

        protected override void ShowItemInGridViewRow(DataGridViewRow row, StudentCheckRecord record)
        {
            row.Tag = record;
            row.Cells["colCheckTime"].Value = record.CheckTime;
            row.Cells["colFacility"].Value = record.Facility;
            row.Cells["colStudentID"].Value = record.StudentID;
            row.Cells["colName"].Value = record.Name;
            row.Cells["colSex"].Value = record.Sex;
            row.Cells["colGroupID"].Value = record.GroupID;
            row.Cells["colChannel"].Value = record.Channel;
            row.Cells["colResult"].Value = record.CheckResult;
            row.Cells["colOperator"].Value = record.Operator;
        }
        #endregion

        private List<StudentCheckRecord> GetSelectedStudents()
        {
            var students = new Dictionary<Guid, StudentCheckRecord>();
            foreach (DataGridViewCell cell in GridView.SelectedCells)
            {
                StudentCheckRecord student = GridView.Rows[cell.RowIndex].Tag as StudentCheckRecord;
                if (!students.ContainsKey(student.ID)) students.Add(student.ID, student);
            }
            return students.Values.ToList();
        }

        private void mnu取消检录_Click(object sender, EventArgs e)
        {
            var items = GetSelectedStudents();
            if (items == null || items.Count == 0) return;
            if (MessageBox.Show("是否删除所选记录?", "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            foreach (var item in items)
            {
                var ret = new APIClient(AppSettings.Current.ConnStr).Delete<Guid,StudentCheckRecord>(item, AppSettings.Current.PhysicalProject.ID);
            }
            btnSearch.PerformClick();
        }
    }
}
