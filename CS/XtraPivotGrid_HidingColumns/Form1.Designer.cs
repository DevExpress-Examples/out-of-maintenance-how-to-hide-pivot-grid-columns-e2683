namespace XtraPivotGrid_ExampleTemplate {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding1 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding2 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.fieldProductName1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldProductSales1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.ceHideColumnGrandTotal = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceHideColumnGrandTotal.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldProductName1,
            this.fieldProductSales1});
            this.pivotGridControl1.Location = new System.Drawing.Point(14, 38);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized;
            this.pivotGridControl1.Size = new System.Drawing.Size(388, 405);
            this.pivotGridControl1.TabIndex = 0;
            this.pivotGridControl1.CustomFieldValueCells += new DevExpress.XtraPivotGrid.PivotCustomFieldValueCellsEventHandler(this.pivotGridControl1_CustomFieldValueCells);
            // 
            // fieldProductName1
            // 
            this.fieldProductName1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldProductName1.AreaIndex = 0;
            this.fieldProductName1.Caption = "Product Name";
            dataSourceColumnBinding1.ColumnName = "ProductName";
            this.fieldProductName1.DataBinding = dataSourceColumnBinding1;
            this.fieldProductName1.Name = "fieldProductName1";
            // 
            // fieldProductSales1
            // 
            this.fieldProductSales1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldProductSales1.AreaIndex = 0;
            this.fieldProductSales1.Caption = "Sales";
            dataSourceColumnBinding2.ColumnName = "ProductSales";
            this.fieldProductSales1.DataBinding = dataSourceColumnBinding2;
            this.fieldProductSales1.Name = "fieldProductSales1";
            // 
            // ceHideColumnGrandTotal
            // 
            this.ceHideColumnGrandTotal.Location = new System.Drawing.Point(12, 13);
            this.ceHideColumnGrandTotal.Name = "ceHideColumnGrandTotal";
            this.ceHideColumnGrandTotal.Properties.Caption = "Hide Grand Total Column When Column Area Is Empty";
            this.ceHideColumnGrandTotal.Size = new System.Drawing.Size(516, 20);
            this.ceHideColumnGrandTotal.TabIndex = 1;
            this.ceHideColumnGrandTotal.CheckedChanged += new System.EventHandler(this.ceHideColumnGrandTotal_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 455);
            this.Controls.Add(this.ceHideColumnGrandTotal);
            this.Controls.Add(this.pivotGridControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceHideColumnGrandTotal.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldProductName1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldProductSales1;
        private DevExpress.XtraEditors.CheckEdit ceHideColumnGrandTotal;
    }
}

