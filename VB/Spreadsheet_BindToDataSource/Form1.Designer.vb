Namespace Spreadsheet_BindToDataSource
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.verticalSplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
            Me.spreadsheet = New DevExpress.XtraSpreadsheet.SpreadsheetControl()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.gridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
            DirectCast(Me.verticalSplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.verticalSplitContainerControl1.SuspendLayout()
            DirectCast(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' verticalSplitContainerControl1
            ' 
            Me.verticalSplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.verticalSplitContainerControl1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.None
            Me.verticalSplitContainerControl1.Horizontal = False
            Me.verticalSplitContainerControl1.Location = New System.Drawing.Point(0, 0)
            Me.verticalSplitContainerControl1.Name = "verticalSplitContainerControl1"
            Me.verticalSplitContainerControl1.Panel1.Controls.Add(Me.spreadsheet)
            Me.verticalSplitContainerControl1.Panel1.Text = "Panel1"
            Me.verticalSplitContainerControl1.Panel2.Controls.Add(Me.gridControl1)
            Me.verticalSplitContainerControl1.Panel2.Text = "Panel2"
            Me.verticalSplitContainerControl1.Size = New System.Drawing.Size(1212, 655)
            Me.verticalSplitContainerControl1.SplitterPosition = 327
            Me.verticalSplitContainerControl1.TabIndex = 0
            Me.verticalSplitContainerControl1.Text = "verticalSplitContainerControl1"
            ' 
            ' spreadsheet
            ' 
            Me.spreadsheet.Dock = System.Windows.Forms.DockStyle.Fill
            Me.spreadsheet.Location = New System.Drawing.Point(0, 0)
            Me.spreadsheet.LookAndFeel.SkinName = "Office 2016 Colorful"
            Me.spreadsheet.LookAndFeel.UseDefaultLookAndFeel = False
            Me.spreadsheet.Name = "spreadsheet"
            Me.spreadsheet.Options.CalculationEngineType = DevExpress.Spreadsheet.CalculationEngineType.Recursive
            Me.spreadsheet.Options.Culture = New System.Globalization.CultureInfo("")
            Me.spreadsheet.Options.View.ShowPrintArea = False
            Me.spreadsheet.Size = New System.Drawing.Size(1212, 327)
            Me.spreadsheet.TabIndex = 0
            Me.spreadsheet.Text = "spreadsheetControl1"
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl1.Location = New System.Drawing.Point(0, 0)
            Me.gridControl1.LookAndFeel.SkinName = "Office 2016 Colorful"
            Me.gridControl1.LookAndFeel.UseDefaultLookAndFeel = False
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.Size = New System.Drawing.Size(1212, 323)
            Me.gridControl1.TabIndex = 0
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
            ' 
            ' gridView1
            ' 
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.gridColumn1, Me.gridColumn2, Me.gridColumn3, Me.gridColumn4, Me.gridColumn5, Me.gridColumn6})
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
            Me.gridView1.OptionsView.ColumnAutoWidth = False
            Me.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
            Me.gridView1.OptionsView.ShowGroupPanel = False
            ' 
            ' gridColumn1
            ' 
            Me.gridColumn1.Caption = "Operation Expenses"
            Me.gridColumn1.FieldName = "Column 0"
            Me.gridColumn1.Name = "gridColumn1"
            Me.gridColumn1.OptionsColumn.FixedWidth = True
            Me.gridColumn1.Visible = True
            Me.gridColumn1.VisibleIndex = 0
            Me.gridColumn1.Width = 215
            ' 
            ' gridColumn2
            ' 
            Me.gridColumn2.Caption = "Q1"
            Me.gridColumn2.DisplayFormat.FormatString = "$ {0:n2}"
            Me.gridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
            Me.gridColumn2.FieldName = "Column 1"
            Me.gridColumn2.Name = "gridColumn2"
            Me.gridColumn2.OptionsColumn.FixedWidth = True
            Me.gridColumn2.Visible = True
            Me.gridColumn2.VisibleIndex = 1
            Me.gridColumn2.Width = 117
            ' 
            ' gridColumn3
            ' 
            Me.gridColumn3.Caption = "Q2"
            Me.gridColumn3.DisplayFormat.FormatString = "$ {0:n2}"
            Me.gridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
            Me.gridColumn3.FieldName = "Column 2"
            Me.gridColumn3.Name = "gridColumn3"
            Me.gridColumn3.OptionsColumn.FixedWidth = True
            Me.gridColumn3.Visible = True
            Me.gridColumn3.VisibleIndex = 2
            Me.gridColumn3.Width = 117
            ' 
            ' gridColumn4
            ' 
            Me.gridColumn4.Caption = "Q3"
            Me.gridColumn4.DisplayFormat.FormatString = "$ {0:n2}"
            Me.gridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
            Me.gridColumn4.FieldName = "Column 3"
            Me.gridColumn4.Name = "gridColumn4"
            Me.gridColumn4.OptionsColumn.FixedWidth = True
            Me.gridColumn4.Visible = True
            Me.gridColumn4.VisibleIndex = 3
            Me.gridColumn4.Width = 117
            ' 
            ' gridColumn5
            ' 
            Me.gridColumn5.Caption = "Q4"
            Me.gridColumn5.DisplayFormat.FormatString = "$ {0:n2}"
            Me.gridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
            Me.gridColumn5.FieldName = "Column 4"
            Me.gridColumn5.Name = "gridColumn5"
            Me.gridColumn5.OptionsColumn.FixedWidth = True
            Me.gridColumn5.Visible = True
            Me.gridColumn5.VisibleIndex = 4
            Me.gridColumn5.Width = 117
            ' 
            ' gridColumn6
            ' 
            Me.gridColumn6.Caption = "Yearly Total"
            Me.gridColumn6.DisplayFormat.FormatString = "$ {0:n2}"
            Me.gridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
            Me.gridColumn6.FieldName = "Column 5"
            Me.gridColumn6.Name = "gridColumn6"
            Me.gridColumn6.OptionsColumn.AllowEdit = False
            Me.gridColumn6.OptionsColumn.FixedWidth = True
            Me.gridColumn6.Visible = True
            Me.gridColumn6.VisibleIndex = 5
            Me.gridColumn6.Width = 144
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1212, 655)
            Me.Controls.Add(Me.verticalSplitContainerControl1)
            Me.Name = "Form1"
            Me.Text = "Two-Way Data Binding"
            DirectCast(Me.verticalSplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.verticalSplitContainerControl1.ResumeLayout(False)
            DirectCast(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private verticalSplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
        Private WithEvents spreadsheet As DevExpress.XtraSpreadsheet.SpreadsheetControl
        Private gridControl1 As DevExpress.XtraGrid.GridControl
        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
        Private gridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
        Private gridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
        Private gridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
        Private gridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
        Private gridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
        Private gridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    End Class
End Namespace

