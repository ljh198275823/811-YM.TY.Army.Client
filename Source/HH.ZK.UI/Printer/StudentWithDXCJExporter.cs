using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using HH.ZK.Model;
using HH.ZK.Model.CRM;
using NPOI.SS.UserModel;
using HH.ZK.CommonUI;
using LJH.GeneralLibrary;

namespace HH.ZK.UI
{
    public class StudentWithDXCJExporter
    {
        public StudentWithDXCJExporter(string modalPath)
        {
            _ModalPath = modalPath;
        }

        /// <summary>
        /// 获取或设置EXCEL模板的路径
        /// </summary>
        protected string _ModalPath;

        #region 私有方法
        private void FillStudentGroupInfo(StudentGroupSummary info, PhysicalItem pi, ISheet sheet, int templateRow, string title)
        {
            for (int i = sheet.FirstRowNum; i <= sheet.LastRowNum; i++)
            {
                if (i == templateRow) continue;//这一行是单据项的模板行，不用去解析
                IRow row = sheet.GetRow(i);
                if (row == null) continue;
                for (int j = row.FirstCellNum; j <= row.LastCellNum; j++)
                {
                    ICell cell = row.GetCell(j);
                    if (cell == null) continue;
                    var express = cell.StringCellValue;
                    if (string.IsNullOrEmpty(express) || !express.StartsWith("[") || !express.EndsWith("]")) continue;
                    if (express == "[考点]" || express == "[考场]")
                    {
                        cell.SetCellValue(AppSettings.Current.PhysicalProject.Name);
                    }
                    if (express == "[学校]")
                    {
                        cell.SetCellValue(info.FacilityName);
                    }
                    if (express == "[标题]")
                    {
                        cell.SetCellValue(title);
                    }
                    if (express == "[考试时间]")
                    {
                        var sj = info.PlanDate;
                        if (string.IsNullOrEmpty(sj)) sj = DateTime.Today.ToString("yyyy年MM月dd日");
                        cell.SetCellValue(sj);
                    }
                    if (express == "[打印时间]" || express == "[打印日期]")
                    {
                        var sj = DateTime.Today.ToString("yyyy年MM月dd日");
                        cell.SetCellValue(sj);
                    }
                    if (express == "[组别]")
                    {
                        var zb = info.Name;
                        cell.SetCellValue(zb);
                    }
                    else if (express == "[考试科目]")
                    {
                        cell.SetCellValue(pi.Name);
                    }
                }
            }
        }

        private void FillSheetItems(List<StudentWithDXCJ> ss, PhysicalItem pi, ISheet sheet, int templateRow, bool createNewRow)
        {
            Dictionary<int, string> templates = new Dictionary<int, string>();
            IRow tr = sheet.GetRow(templateRow);
            if (tr == null) return;
            for (int i = tr.FirstCellNum; i <= tr.LastCellNum; i++)
            {
                ICell cell = tr.GetCell(i);
                if (cell == null) continue;
                templates.Add(i, cell.StringCellValue);
            }
            if (templates.Count == 0) return;
            if (createNewRow && ss.Count > 1) //这里要在模板中插入除第一行外的其它行，并且要保证模板中后面的列格式不变
            {
                sheet.ShiftRows(templateRow + 1, sheet.LastRowNum, ss.Count - 1, true, false);  //移动行
                for (int i = 1; i < ss.Count; i++)
                {
                    var fuckRow = sheet.GetRow(i + templateRow);
                    if (fuckRow == null) fuckRow = sheet.CreateRow(i + templateRow);
                    CopyRow(sheet, tr, fuckRow);
                }
            }
            for (int i = 0; i < ss.Count; i++)
            {
                var s = ss[i];
                var row = sheet.GetRow(i + templateRow);
                if (row == null) continue;
                for (int j = row.FirstCellNum; j <= row.LastCellNum; j++)
                {
                    ICell cell = row.GetCell(j);
                    if (cell == null) continue;
                    var express = j < templates.Count ? templates[j] : null;
                    if (string.IsNullOrEmpty(express) || !express.StartsWith("[") || !express.EndsWith("]")) continue;
                    if (express == "[学号]" || express == "[准考证号]") cell.SetCellValue(s.ID);
                    else if (express == "[姓名]")
                    {
                        cell.SetCellValue(s.Name);
                    }
                    else if (express == "[性别]")
                    {
                        cell.SetCellValue(s.Sex == Sex.Male ? "男" : "女");
                    }
                    else if (express == "[学校]")
                    {
                        cell.SetCellValue(s.FacilityName);
                    }
                    else if (express == "[班级]" || express == "[班级名称]")
                    {
                        cell.SetCellValue(s.ClassName);
                    }
                    else if (express == "[道次]")
                    {
                        cell.SetCellValue(s.Channel.HasValue ? s.Channel.ToString() : string.Empty);
                    }
                    else if (express == "[考试科目]")
                    {
                        cell.SetCellValue(pi.Name);
                    }
                    else if (express == "[特殊情况]")
                    {
                        cell.SetCellValue(s.State != StudentState.正常考试 ? s.State.ToString() : null);
                    }
                    else if (express == "[主机号]")
                    {
                        if (pi.TestCount >= 1)
                        {
                            var score = s.GetScoreByIndex(0);
                            cell.SetCellValue(score?.HostID?.ToString());
                        }
                    }
                    else if (express == "[第一次成绩]")
                    {
                        if (pi.TestCount >= 1)
                        {
                            var score = s.GetScoreByIndex(0);
                            cell.SetCellValue(score?.FormatScore);
                        }
                    }
                    else if (express == "[第一次得分]")
                    {
                        if (AppSettings.Current.Operator.PermitAny(Permission.总分, PermissionActions.Read) && pi.TestCount >= 1)
                        {
                            var score = s.GetScoreByIndex(0);
                            cell.SetCellValue(score?.Result?.Trim().ToString());
                        }
                    }
                    else if (express == "[第二次成绩]")
                    {
                        if (pi.TestCount >= 2)
                        {
                            var score = s.GetScoreByIndex(1);
                            cell.SetCellValue(score?.FormatScore);
                        }
                    }
                    else if (express == "[第二次得分]")
                    {
                        if (AppSettings.Current.Operator.PermitAny(Permission.总分, PermissionActions.Read) && pi.TestCount >= 2)
                        {
                            var score = s.GetScoreByIndex(1);
                            cell.SetCellValue(score?.Result?.Trim().ToString());
                        }
                    }
                    else if (express == "[第三次成绩]")
                    {
                        if (pi.TestCount >= 3)
                        {
                            var score = s.GetScoreByIndex(2);
                            cell.SetCellValue(score?.FormatScore);
                        }
                    }
                    else if (express == "[第三次得分]")
                    {
                        if (AppSettings.Current.Operator.PermitAny(Permission.总分, PermissionActions.Read) && pi.TestCount >= 3)
                        {
                            var score = s.GetScoreByIndex(2);
                            cell.SetCellValue(score?.Result?.Trim().ToString());
                        }
                    }
                    else if (express == "[最终成绩]")
                    {
                        cell.SetCellValue(s.BestScore?.FormatScore);
                    }
                    else if (express == "[最终得分]")
                    {
                        if (AppSettings.Current.Operator.PermitAny(Permission.总分, PermissionActions.Read))
                        {
                            cell.SetCellValue(s.BestScore?.Result?.Trim().ToString());
                        }
                        else cell.SetCellValue(string.Empty);
                    }
                }
            }
        }

        private void CopyRow(ISheet sheet, IRow sourceRow, IRow targetRow)
        {
            if (targetRow == null)
            {
                return;
            }
            ICell sourceCell = null;
            ICell targetCell = null;
            int startMergeCell = -1;  //记录每行的合并单元格起始位置
            int sourceCellCount = sourceRow.Cells.Count;

            targetRow.Height = sourceRow.Height;  //复制行高
            for (int m = sourceRow.FirstCellNum; m <= sourceRow.LastCellNum; m++)
            {
                sourceCell = sourceRow.GetCell(m);
                if (sourceCell == null) continue;
                targetCell = targetRow.GetCell(m);
                if (targetCell == null) targetCell = targetRow.CreateCell(m);
                targetCell.CellStyle = sourceCell.CellStyle;   //赋值单元格格式
                targetCell.SetCellType(sourceCell.CellType);

                //以下为复制模板行的单元格合并格式
                if (sourceCell.IsMergedCell)
                {
                    if (startMergeCell < 0) startMergeCell = m;
                    else if (startMergeCell > 0 && sourceCellCount == m + 1)
                    {
                        sheet.AddMergedRegion(new NPOI.SS.Util.CellRangeAddress(targetRow.RowNum, targetRow.RowNum, startMergeCell, m));
                        startMergeCell = -1;
                    }
                }
                else
                {
                    if (startMergeCell >= 0)
                    {
                        sheet.AddMergedRegion(new NPOI.SS.Util.CellRangeAddress(targetRow.RowNum, targetRow.RowNum, startMergeCell, m - 1));
                        startMergeCell = -1;
                    }
                }
            }
        }
        #endregion

        #region 公共方法
        /// <summary>
        /// 导出信息到EXCEL中
        /// </summary>
        /// <param name="optLog"></param>
        public void Export(StudentGroupSummary group, PhysicalItem pi, List<StudentWithDXCJ> students, string path, string title, int templateRow = 5)
        {
            try
            {
                using (FileStream fs = new FileStream(_ModalPath, FileMode.Open, FileAccess.Read))
                {
                    IWorkbook wb = WorkbookFactory.Create(fs);
                    ISheet sheet = wb.GetSheetAt(0);
                    FillStudentGroupInfo(group, pi, sheet, templateRow - 1, title);
                    FillSheetItems(students, pi, sheet, templateRow - 1, true);
                    MemoryStream stream = new MemoryStream();
                    wb.Write(stream);
                    var buf = stream.ToArray();
                    //保存为Excel文件
                    using (FileStream fs1 = new FileStream(path, FileMode.Create, FileAccess.Write))
                    {
                        fs1.Write(buf, 0, buf.Length);
                        fs1.Flush();
                    }
                }
            }
            catch (Exception ex)
            {
                LJH.GeneralLibrary.ExceptionPolicy.HandleException(ex);
            }
        }
        #endregion
    }
}
