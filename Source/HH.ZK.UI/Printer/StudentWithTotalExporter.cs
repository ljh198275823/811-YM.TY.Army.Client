using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using NPOI.SS.UserModel;
using HH.ZK.Model;
using HH.ZK.CommonUI;

namespace HH.ZK.UI
{
    /// <summary>
    /// 表示体质测试上传文件导出类
    /// </summary>
    public class StudentWithTotalExporter
    {
        public StudentWithTotalExporter(string modalPath)
        {
            _ModalPath = modalPath;
        }

        /// <summary>
        /// 获取或设置EXCEL模板的路径
        /// </summary>
        protected string _ModalPath;

        #region 公共方法
        /// <summary>
        /// 通过指定的模板文件导出数据
        /// </summary>
        /// <param name="students"></param>
        /// <param name="modelFile"></param>
        /// <param name="desFile"></param>
        /// <param name="templateRow">指定模板文件中数据模板在哪一行，如果没有指定则模板行为首行</param>
        /// <returns></returns>
        public bool ExportToFile(List<StudentWithTotal> students, string desFile, int templateRow, string facility, StudentGroupSummary group)
        {

            try
            {
                using (FileStream fs = new FileStream(_ModalPath, FileMode.Open, FileAccess.Read))
                {
                    IWorkbook wb = WorkbookFactory.Create(fs);
                    ISheet sheet = wb.GetSheetAt(0);
                    FillHeader(sheet, templateRow - 1, facility, group, students); //填充模板行前面的行
                    FillStudents(sheet, students, templateRow - 1, true);
                    MemoryStream stream = new MemoryStream();
                    wb.Write(stream);
                    var buf = stream.ToArray();
                    //保存为Excel文件
                    using (FileStream fs1 = new FileStream(desFile, FileMode.Create, FileAccess.Write))
                    {
                        fs1.Write(buf, 0, buf.Length);
                        fs1.Flush();
                    }
                    return true;
                }
            }
            catch (Exception ex)
            {
                LJH.GeneralLibrary.ExceptionPolicy.HandleException(ex);
            }
            return false;
        }

        private void FillHeader(ISheet sheet, int templateRow, string facility, StudentGroupSummary group, List<StudentWithTotal> students)
        {
            for (int r = sheet.FirstRowNum; r < sheet.LastRowNum; r++)
            {
                if (r == templateRow) continue;//这一行是单据项的模板行，不用去解析
                IRow row = sheet.GetRow(r);
                if (row == null) continue;
                for (int col = 0; col < row.LastCellNum; col++)
                {
                    ICell cell = row.GetCell(col);
                    if (cell == null) continue;
                    if (cell.CellType == CellType.String)
                    {
                        string value = cell.StringCellValue;
                        if (!string.IsNullOrEmpty(value))
                        {
                            if (value == "[打印日期]" || value == "[考试时间]")
                            {
                                cell.SetCellValue(DateTime.Today.ToString("yyyy年MM月dd日"));
                            }
                            else if (value == "[考点]")
                            {
                                cell.SetCellValue(AppSettings.Current.PhysicalProject.Name);
                            }
                            else if (value == "[学校]")
                            {
                                cell.SetCellValue(facility);
                            }
                            else if (value == "[组别]")
                            {
                                cell.SetCellValue(group?.Name);
                            }
                            else if (value == "[项目一]")
                            {
                                cell.SetCellValue(GetPhysicalName(group, students, 0));
                            }
                            else if (value == "[项目二]")
                            {
                                cell.SetCellValue(GetPhysicalName(group, students, 1));
                            }
                            else if (value == "[项目三]")
                            {
                                cell.SetCellValue(GetPhysicalName(group, students, 2));
                            }
                            else if (value == "[项目四]")
                            {
                                cell.SetCellValue(GetPhysicalName(group, students, 3));
                            }
                            else if (value == "[项目五]")
                            {
                                cell.SetCellValue(GetPhysicalName(group, students, 4));
                            }
                            else if (value == "[项目六]")
                            {
                                cell.SetCellValue(GetPhysicalName(group, students, 5));
                            }
                        }
                    }
                }
            }
        }

        private string GetPhysicalName(StudentGroupSummary group, List<StudentWithTotal> ss, int index)
        {
            var pnames = AppSettings.Current.PhysicalProject.PhysicalItems.GetNames(group?.PhysicalItems);
            if (string.IsNullOrEmpty (pnames)) pnames = AppSettings.Current.PhysicalProject.PhysicalItems.GetNames(ss[0].PhysicalItems);
            if (string.IsNullOrEmpty(pnames)) return null;
            var strs = pnames.Split(',');
            if (strs.Length < index + 1) return null;
            return strs[index];
        }

        private void FillStudents(ISheet sheet, List<StudentWithTotal> students, int templateRow, bool createRow)
        {
            Dictionary<int, string> templates = new Dictionary<int, string>();
            IRow tr = sheet.GetRow(templateRow); //如果没有指定开始导入的行
            if (tr == null) return;
            for (int i = tr.FirstCellNum; i < tr.LastCellNum; i++)
            {
                ICell headerCell = tr.GetCell(i);
                if (headerCell!=null && headerCell.CellType == CellType.String && !string.IsNullOrEmpty(headerCell.StringCellValue))
                {
                    templates.Add(i, headerCell.StringCellValue);
                }
            }
            if (templates.Count == 0) return;
            if (createRow && students.Count > 1) //这里要在模板中插入除第一行外的其它行，并且要保证模板中后面的列格式不变
            {
                if (sheet.LastRowNum > templateRow) sheet.ShiftRows(templateRow + 1, sheet.LastRowNum, students.Count - 1, true, false);  //移动行
                for (int i = 1; i < students.Count; i++)
                {
                    var fuckRow = sheet.GetRow(i + templateRow);
                    if (fuckRow == null) fuckRow = sheet.CreateRow(i + templateRow);
                    CopyRow(sheet, tr, fuckRow);
                }
            }
            for (int r = 0; r < students.Count; r++)
            {
                var s = students[r];
                IRow row = sheet.GetRow(r + templateRow);
                if (row == null) continue;
                foreach (var pair in templates)
                {
                    string express = pair.Value;
                    string value = null;
                    if (express == "[序号]") value = (r + 1).ToString();
                    else value = HH.ZK.CommonUI.StudentExpression.Extra(s, express, string.Empty);
                    if (value == express) value = null;
                    ICell cell = row.GetCell(pair.Key);
                    if (cell == null) cell = row.CreateCell(pair.Key);
                    if (value != null) cell.SetCellValue(value);
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
    }
}
