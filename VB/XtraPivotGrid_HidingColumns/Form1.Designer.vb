Namespace XtraPivotGrid_ExampleTemplate
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
			Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
			Me.fieldProductName = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldProductSales = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.ceHideColumnGrandTotal = New DevExpress.XtraEditors.CheckEdit()
			DirectCast(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.ceHideColumnGrandTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' pivotGridControl1
			' 
			Me.pivotGridControl1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() { Me.fieldProductName, Me.fieldProductSales})
			Me.pivotGridControl1.Location = New System.Drawing.Point(14, 38)
			Me.pivotGridControl1.Name = "pivotGridControl1"
			Me.pivotGridControl1.Size = New System.Drawing.Size(388, 405)
			Me.pivotGridControl1.TabIndex = 0
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.pivotGridControl1.CustomFieldValueCells += new DevExpress.XtraPivotGrid.PivotCustomFieldValueCellsEventHandler(this.pivotGridControl1_CustomFieldValueCells);
			' 
			' fieldProductName
			' 
			Me.fieldProductName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldProductName.AreaIndex = 0
			Me.fieldProductName.Caption = "Product Name"
			Me.fieldProductName.FieldName = "ProductName"
			Me.fieldProductName.Name = "fieldProductName"
			' 
			' fieldProductSales
			' 
			Me.fieldProductSales.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldProductSales.AreaIndex = 0
			Me.fieldProductSales.Caption = "Sales"
			Me.fieldProductSales.FieldName = "ProductSales"
			Me.fieldProductSales.Name = "fieldProductSales"
			' 
			' ceHideColumnGrandTotal
			' 
			Me.ceHideColumnGrandTotal.Location = New System.Drawing.Point(12, 13)
			Me.ceHideColumnGrandTotal.Name = "ceHideColumnGrandTotal"
			Me.ceHideColumnGrandTotal.Properties.Caption = "Hide Grand Total Column When Column Area Is Empty"
			Me.ceHideColumnGrandTotal.Size = New System.Drawing.Size(516, 19)
			Me.ceHideColumnGrandTotal.TabIndex = 1
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.ceHideColumnGrandTotal.CheckedChanged += new System.EventHandler(this.ceHideColumnGrandTotal_CheckedChanged);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(414, 455)
			Me.Controls.Add(Me.ceHideColumnGrandTotal)
			Me.Controls.Add(Me.pivotGridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.Load += new System.EventHandler(this.Form1_Load);
			DirectCast(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.ceHideColumnGrandTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
		Private fieldProductName As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldProductSales As DevExpress.XtraPivotGrid.PivotGridField
		Private WithEvents ceHideColumnGrandTotal As DevExpress.XtraEditors.CheckEdit
	End Class
End Namespace

