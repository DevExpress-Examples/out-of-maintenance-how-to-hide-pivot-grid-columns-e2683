Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraPivotGrid

Namespace XtraPivotGrid_ExampleTemplate
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
		End Sub
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
			Dim adapter As New nwindDataSetTableAdapters.ProductReportsTableAdapter()
			pivotGridControl1.DataSource = adapter.GetData()
			pivotGridControl1.BestFit()
		End Sub
		Private Sub pivotGridControl1_CustomFieldValueCells(ByVal sender As Object, ByVal e As PivotCustomFieldValueCellsEventArgs) Handles pivotGridControl1.CustomFieldValueCells
			If pivotGridControl1.Fields.GetVisibleFieldCount(PivotArea.ColumnArea) = 0 AndAlso ceHideColumnGrandTotal.Checked Then
				e.Remove(e.GetCell(True, 0))
			End If
		End Sub
		Private Sub ceHideColumnGrandTotal_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceHideColumnGrandTotal.CheckedChanged
			pivotGridControl1.RefreshData()
		End Sub
	End Class
End Namespace