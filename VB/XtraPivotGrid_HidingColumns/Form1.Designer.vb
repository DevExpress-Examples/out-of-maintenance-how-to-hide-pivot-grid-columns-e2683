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
            Dim DataSourceColumnBinding1 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim DataSourceColumnBinding2 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
            Me.fieldProductName1 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldProductSales1 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.ceHideColumnGrandTotal = New DevExpress.XtraEditors.CheckEdit()
            CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ceHideColumnGrandTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'pivotGridControl1
            '
            Me.pivotGridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldProductName1, Me.fieldProductSales1})
            Me.pivotGridControl1.Location = New System.Drawing.Point(14, 38)
            Me.pivotGridControl1.Name = "pivotGridControl1"
            Me.pivotGridControl1.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized
            Me.pivotGridControl1.Size = New System.Drawing.Size(388, 405)
            Me.pivotGridControl1.TabIndex = 0
            '
            'fieldProductName1
            '
            Me.fieldProductName1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldProductName1.AreaIndex = 0
            Me.fieldProductName1.Caption = "Product Name"
            DataSourceColumnBinding1.ColumnName = "ProductName"
            Me.fieldProductName1.DataBinding = DataSourceColumnBinding1
            Me.fieldProductName1.Name = "fieldProductName1"
            '
            'fieldProductSales1
            '
            Me.fieldProductSales1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldProductSales1.AreaIndex = 0
            Me.fieldProductSales1.Caption = "Sales"
            DataSourceColumnBinding2.ColumnName = "ProductSales"
            Me.fieldProductSales1.DataBinding = DataSourceColumnBinding2
            Me.fieldProductSales1.Name = "fieldProductSales1"
            '
            'ceHideColumnGrandTotal
            '
            Me.ceHideColumnGrandTotal.Location = New System.Drawing.Point(12, 13)
            Me.ceHideColumnGrandTotal.Name = "ceHideColumnGrandTotal"
            Me.ceHideColumnGrandTotal.Properties.Caption = "Hide Grand Total Column When Column Area Is Empty"
            Me.ceHideColumnGrandTotal.Size = New System.Drawing.Size(516, 20)
            Me.ceHideColumnGrandTotal.TabIndex = 1
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(414, 455)
            Me.Controls.Add(Me.ceHideColumnGrandTotal)
            Me.Controls.Add(Me.pivotGridControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ceHideColumnGrandTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private WithEvents pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
		Private fieldProductName1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldProductSales1 As DevExpress.XtraPivotGrid.PivotGridField
		Private WithEvents ceHideColumnGrandTotal As DevExpress.XtraEditors.CheckEdit
	End Class
End Namespace

