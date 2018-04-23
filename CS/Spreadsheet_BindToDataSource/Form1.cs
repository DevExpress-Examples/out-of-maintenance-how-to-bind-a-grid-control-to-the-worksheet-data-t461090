using DevExpress.Spreadsheet;
using System;
using System.Windows.Forms;

namespace Spreadsheet_BindToDataSource
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            spreadsheet.LoadDocument(@"Documents/Expenses_template.xlsx", DocumentFormat.Xlsx);
        }

        private void spreadsheet_DocumentLoaded(object sender, EventArgs e)
        {
            #region #BindGridToSpreadsheetTable
            IWorkbook workbook = spreadsheet.Document;
            Worksheet worksheet = workbook.Worksheets[0];
            // Access the table on the worksheet. 
            Table expensesTable = worksheet.Tables[0];
            // Specify the data source settings.
            RangeDataSourceOptions options = new RangeDataSourceOptions();
            options.PreserveFormulas = true;
            options.SkipHiddenRows = true;
            // Bind the grid control to the table data.
            gridControl1.DataSource = expensesTable.DataRange.GetDataSource(options);
            #endregion #BindGridToSpreadsheetTable
        }
    }
}
