using System;
using System.Windows.Forms;
using DevExpress.XtraPivotGrid;

namespace XtraPivotGrid_ExampleTemplate {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e) {
            nwindDataSetTableAdapters.ProductReportsTableAdapter adapter =
                new nwindDataSetTableAdapters.ProductReportsTableAdapter();
            pivotGridControl1.DataSource = adapter.GetData();
            pivotGridControl1.BestFit();
        }
        private void pivotGridControl1_CustomFieldValueCells(object sender, 
            PivotCustomFieldValueCellsEventArgs e) {
            if (pivotGridControl1.Fields.GetVisibleFieldCount(PivotArea.ColumnArea) == 0
                && ceHideColumnGrandTotal.Checked)
                e.Remove(e.GetCell(true, 0));
        }
        private void ceHideColumnGrandTotal_CheckedChanged(object sender, EventArgs e) {
            pivotGridControl1.RefreshData();
        }
    }
}