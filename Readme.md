<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Spreadsheet_BindToDataSource/Form1.cs) (VB: [Form1.vb](./VB/Spreadsheet_BindToDataSource/Form1.vb))
<!-- default file list end -->
# How to bind a grid control to the worksheet data


<p>This example demonstrates how to bind the <a href="https://documentation.devexpress.com/#WindowsForms/CustomDocument3455">Grid Control</a> to the <a href="https://documentation.devexpress.com/#WindowsForms/CustomDocument12063">Spreadsheet</a> data. To do this, use the <a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressSpreadsheetRange_GetDataSourcetopic">Range.GetDataSource</a> method to create a data source object from a specific cell range in a worksheet, and then assign it to the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraGridGridControl_DataSourcetopic">GridControl.DataSource</a> property. The two-way binding is supported: any changes to worksheet (such as editing values, inserting and deleting rows, sorting and filtering) are immediately propagated to the Data Grid, and editing data in the grid is reflected in the spreadsheet.</p>

<br/>


