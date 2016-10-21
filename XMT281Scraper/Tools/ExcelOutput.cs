using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OfficeOpenXml;
using OfficeOpenXml.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Data;

namespace XMT281Scraper.Tools
{
    public static class ExcelOutput
    {
        public static void ListViewToExcel(System.Windows.Forms.ListView listview, string filenamewithpath, string sheetName)
        {

            FileInfo f = new FileInfo(filenamewithpath);
            if (f.Exists)
            {
                f.Delete();
                f = new FileInfo(filenamewithpath);
            }

            using (ExcelPackage ep = new ExcelPackage(f))
            {
                ExcelWorksheet osheet = ep.Workbook.Worksheets.Add(sheetName);

                for (int i = 0; i < listview.Columns.Count; i++)
                {
                    osheet.Cells[1, i + 1].Value = listview.Columns[i].Text;
                }
                for (int i = 0; i < listview.Items.Count; i++)
                {
                    for (int j = 0; j < listview.Columns.Count; j++)
                    {
                        osheet.Cells[i + 2, j + 1].Value = listview.Items[i].SubItems[j].Text;
                    }
                }

                for (int i = 1; i <= osheet.Dimension.End.Column; i++)
                {
                    osheet.Column(i).AutoFit(8.43);
                    //osheet.Column(i).Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                }


                ep.Save();
            }
        }

        public static void DataTableToExcel(DataTable dt, string fileName)
        {
            try
            {
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }
                using (ExcelPackage ep = new ExcelPackage(new FileInfo(fileName)))
                {
                    var st = ep.Workbook.Worksheets.Add(Path.GetFileNameWithoutExtension(fileName));
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        st.Cells[1, i + 1].Value = dt.Columns[i].ColumnName;
                    }

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            st.Cells[i + 2, j + 1].Value = dt.Rows[i][j].ToString();
                        }
                    }
                    for (int i = 0; i < st.Dimension.End.Column; i++)
                    {
                        st.Column(i + 1).AutoFit();
                    }
                    ep.Save();
                }
            }
            catch (Exception err)
            {
                throw err;
            }

        }
        /// <summary>
        /// Excel文件修改
        /// </summary>
        /// <param name="newfile">新文件</param>
        /// <param name="template">模板文件</param>
        /// <param name="kvpRangeAndData">要修改的数据字典，key为单元格地址，Value为单元格的数据</param>
        public static void ModifyExcel(FileInfo newfile, FileInfo template, Dictionary<string, object> kvpRangeAndData)
        {
            using (ExcelPackage ep = new ExcelPackage(newfile, template))
            {
                var wb = ep.Workbook;
                foreach (var item in kvpRangeAndData)
                {
                    wb.Worksheets[1].Cells[item.Key].Value = item.Value;
                }
                ep.Save();
            }
        }
        #region Sample For ModifyExcel
        //FileInfo ff = new FileInfo(@"E:\日检表\广播智能监测系统日检表.xlsx");
        //var nf = new FileInfo(@"e:\日检表\广播智能监测系统日检表" + DateTime.Now.ToShortDateString() + ".xlsx");
        //Dictionary<string, string> dic = new Dictionary<string, string>();
        //dic.Add("C2", DateTime.Now.ToString("yyyy年MM月dd日"));
        //dic.Add("H2", "申健");
        //ModifyExcel(nf, ff, dic); 
        #endregion
        /// <summary>
        /// 续写文件
        /// </summary>
        /// <param name="file"></param>
        /// <param name="kvpRangeAndData"></param>
        public static void ModifyExcel(FileInfo file, Dictionary<string, object> kvpRangeAndData)
        {
            using (ExcelPackage ep = new ExcelPackage(file))
            {
                var wb = ep.Workbook;
                foreach (var item in kvpRangeAndData)
                {
                    wb.Worksheets[1].Cells[item.Key].Value = item.Value;
                }
                ep.Save();
            }
        }


    }
}
