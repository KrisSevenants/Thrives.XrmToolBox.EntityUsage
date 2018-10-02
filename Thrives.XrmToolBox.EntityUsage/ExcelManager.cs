using OfficeOpenXml;
using System.Collections.Generic;
using System.IO;
using Thrives.XrmToolBox.EntityUsage.Model;

namespace Thrives.XrmToolBox.EntityUsage
{
    class ExcelManager
    {
        private readonly ExcelPackage innerWorkBook;
        private ExcelWorksheet sheet;
        private List<EntityUsageGridModel> _data;

        public ExcelManager(List<EntityUsageGridModel> data)
        {
            innerWorkBook = new ExcelPackage();
            sheet =  innerWorkBook.Workbook.Worksheets.Add("EntityUsageOverview");
            _data = data;
            sheet.Cells[1, 1].Value = "EnttiyName";
            sheet.Cells[1, 2].Value = "EntitySchemaName";
            sheet.Cells[1, 3].Value = "RecordCount";
            sheet.Cells[1, 4].Value = "LastCreated";
            sheet.Cells[1, 5].Value = "LastModified";
            sheet.Cells[1, 6].Value = "ErrorMessage";
            AddDataToXlsx();
        }

        private void AddDataToXlsx()
        {
            int rowIndex = 2;
            foreach(EntityUsageGridModel row in _data)
            {
                sheet.Cells[rowIndex, 1].Value = row.EntityName;
                sheet.Cells[rowIndex, 2].Value = row.EntitySchemaName;
                sheet.Cells[rowIndex ,3].Value = row.RecordCount;
                sheet.Cells[rowIndex, 4].Value = row.LastCreated;
                sheet.Cells[rowIndex, 5].Value = row.LastModified;
                sheet.Cells[rowIndex, 6].Value = row.ErrorMessage;
                rowIndex++;
            } 
        }
        public void Save(string path)
        {
            innerWorkBook.SaveAs(new FileInfo(path));
        }
    }
}


