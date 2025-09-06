using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using NPOI;
using NPOI.HPSF;
using NPOI.HSSF;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using NPOI.HSSF.UserModel;
using HH.ZK.Model;
using HH.ZK.CommonUI;

namespace HH.ZK.UI.Printer
{
    public class DiscussionExporter
    {
        #region 构造函数
        public DiscussionExporter()
        {
        }
        #endregion

        #region 公共方法
        public bool ExportToFile(Discussion discussion, string modelFile, string desFile)
        {
            try
            {
                using (FileStream fs = new FileStream(modelFile, FileMode.Open, FileAccess.Read))
                {
                    IWorkbook wb = WorkbookFactory.Create(fs);
                    ISheet sheet = wb.GetSheetAt(0);
                    for (int r = sheet.FirstRowNum; r <= sheet.LastRowNum; r++)
                    {
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
                                    if (value == "[仲裁单号]")
                                    {
                                        cell.SetCellValue(discussion.Number);
                                    }
                                    else if (value == "[仲裁日期]")
                                    {
                                        cell.SetCellValue(discussion.CreateTime.ToString("yyyy年MM月dd日"));
                                    }
                                    else if (value == "[准考证号]" || value == "[学号]")
                                    {
                                        cell.SetCellValue(discussion.StudentID);
                                    }
                                    else if (value == "[姓名]")
                                    {
                                        cell.SetCellValue(discussion.Name);
                                    }
                                    else if (value == "[学校]" || value == "[学校名称]")
                                    {
                                        cell.SetCellValue(discussion.FacilityName);
                                    }
                                    else if (value == "[考点]")
                                    {
                                        cell.SetCellValue(AppSettings.Current.PhysicalProject.Name);
                                    }
                                    else if (value == "[考试科目]")
                                    {
                                        var pi = AppSettings.Current.PhysicalProject.PhysicalItems?.GetPhysicalItem(discussion.PhysicalItem);
                                        cell.SetCellValue(pi != null ? pi.Name : string.Empty);
                                    }
                                    else if (value == "[考试成绩]")
                                    {
                                        cell.SetCellValue(discussion.Score);
                                    }
                                    else if (value == "[考试时间]")
                                    {
                                        cell.SetCellValue(discussion.ScoreTime.ToString("yyyy-MM-dd HH:mm:ss"));
                                    }
                                    else if (value == "[仲裁说明]")
                                    {
                                        cell.SetCellValue(discussion.Description);
                                    }
                                    else if (value == "[仲裁结果]")
                                    {
                                        cell.SetCellValue(discussion.ResolveType.ToString());
                                    }
                                    else if (value == "[仲裁老师]")
                                    {
                                        cell.SetCellValue(discussion.Approver);
                                    }
                                    else if (value == "[新成绩]")
                                    {
                                        cell.SetCellValue(discussion.NewScore);
                                    }
                                }
                            }
                        }
                    }
                    //转为字节数组
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
            }
            return false;
        }
        #endregion
    }
}
