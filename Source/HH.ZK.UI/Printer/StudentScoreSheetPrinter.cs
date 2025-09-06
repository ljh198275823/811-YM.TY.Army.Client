using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.IO;
using NPOI.SS.UserModel;
using HH.ZK.Model;
using HH.ZK.CommonUI;

namespace HH.ZK.UI.Printer
{
    public class StudentScoreSheetPrinter
    {
        public StudentScoreSheetPrinter(string modalFile)
        {
            _ModelFile = modalFile;
        }

        private string _ModelFile = null;

        #region 公共方法
        public bool ExportToFile(StudentWithTotal s, string desFile)
        {
            try
            {
                using (FileStream fs = new FileStream(_ModelFile, FileMode.Open, FileAccess.Read))
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
                                string pattern = @"\[.+?\]"; //用于匹配 [至少一个字符]
                                Regex rg = new Regex(pattern);
                                var matches = rg.Matches(value, 0);
                                if (matches != null && matches.Count > 0)
                                {
                                    foreach (var match in matches)
                                    {
                                        string temp = match.ToString();
                                        string str = null;
                                        if (Extra(s, temp, out str))
                                        {
                                            value = value.Replace(temp, str);
                                        }
                                        else
                                        {
                                            str = StudentExpression.Extra(s, temp, string.Empty);
                                            value = value.Replace(temp, str);
                                        }
                                    }
                                    cell.SetCellValue(value);
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
            catch (Exception)
            {
            }
            return false;
        }

        private bool Extra(StudentWithTotal s, string espression, out string str)
        {
            str = null;
            if (espression == "[打印日期]" || espression == "[考试时间]")
            {
                str = DateTime.Today.ToString("yyyy年MM月dd日");
                return true;
            }
            else if (espression == "[考点]")
            {
                str = AppSettings.Current.PhysicalProject.Name;
                return true;
            }
            else if (espression == "[学校]")
            {
                str = s.FacilityName;
                return true;
            }
            else if (espression == "[组别]")
            {
                str = s.Groups;
                return true;
            }
            return false;
        }
        #endregion
    }
}
