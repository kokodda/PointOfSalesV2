using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using static PointOfSalesV2.Common.Enums;

namespace PointOfSalesV2.Repository.Helpers
{
    public class ImportToExcel
    {
        public static string CreateXlsFile(string[] headers, ExcelColumnsDef[] colDef, List<string[]> dataList, string extension = "xls")
        {
            IWorkbook workbook;

            if (extension == "xlsx")
            {
                workbook = new XSSFWorkbook();
            }
            else if (extension == "xls")
            {
                workbook = new HSSFWorkbook();
            }
            else
            {
                throw new Exception("This format is not supported");
            }

            ISheet sheet1 = workbook.CreateSheet("Reporte");

            IRow headerRow = sheet1.CreateRow(0);
            for (int i = 0; i < headers.Length; i++)
            {
                ICell cell = headerRow.CreateCell(i);
                // String columnName = headers[i];
                cell.SetCellValue(headers[i]);
            }
            for (int i = 0; i < dataList.Count; i++)
            {
                IRow currentRow = sheet1.CreateRow(i + 1);
                for (int j = 0; j < dataList[i].Length; j++)
                {
                    ICell currentCell = currentRow.CreateCell(j);
                    SetCellValue(currentCell, dataList[i][j], colDef[j]);
                }
            }
            string directory = @"Uploads\"; Path.Combine(Directory.GetCurrentDirectory(), "Downloads");
            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);

            string path = Path.Combine(directory, $"reporte-{DateTime.Now.Ticks}.xls");
            FileStream xfile = new FileStream(path, FileMode.Create, System.IO.FileAccess.Write);
            workbook.Write(xfile);
            xfile.Close();
            return path;

        }

        public static MemoryStream CreateXlsStream(string[] headers, ExcelColumnsDef[] colDef, List<string[]> dataList, string extension = "xls")
        {
            IWorkbook workbook;

            if (extension == "xlsx")
            {
                workbook = new XSSFWorkbook();
            }
            else if (extension == "xls")
            {
                workbook = new HSSFWorkbook();
            }
            else
            {
                throw new Exception("This format is not supported");
            }

            ISheet sheet1 = workbook.CreateSheet("Reporte");

            IRow headerRow = sheet1.CreateRow(0);
            for (int i = 0; i < headers.Length; i++)
            {
                ICell cell = headerRow.CreateCell(i);
                // String columnName = headers[i];
                cell.SetCellValue(headers[i]);
            }
            for (int i = 0; i < dataList.Count; i++)
            {
                IRow currentRow = sheet1.CreateRow(i + 1);
                for (int j = 0; j < dataList[i].Length; j++)
                {
                    ICell currentCell = currentRow.CreateCell(j);
                    SetCellValue(currentCell, dataList[i][j], colDef[j]);
                }
            }


            MemoryStream xfile = new MemoryStream();
            workbook.Write(xfile);

            return xfile;

        }

        private static void SetCellValue(ICell currentCell, string value, ExcelColumnsDef columnsDef)
        {
            switch (columnsDef)
            {
                case ExcelColumnsDef.DATETIME:
                    currentCell.SetCellValue(value);

                    break;
                case ExcelColumnsDef.DECIMAL:
                    currentCell.SetCellValue(Convert.ToDouble(value));
                    break;
                case ExcelColumnsDef.TEXT:
                    currentCell.SetCellValue(value);
                    break;
                case ExcelColumnsDef.INTEGER:
                    currentCell.SetCellValue(Convert.ToInt32(value));
                    break;
                default:
                    currentCell.SetCellValue(value);
                    break;

            }
        }
    }
}
