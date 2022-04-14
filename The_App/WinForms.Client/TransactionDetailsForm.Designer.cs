namespace WinForms.Client {
    partial class TransactionDetailsForm {
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
            this.components = new System.ComponentModel.Container();
            this.gridControlLines = new DevExpress.XtraGrid.GridControl();
            this.gridViewLines = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnItemDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnItemPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnItemCost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnTotalCost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnNetValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDiscountPercent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDiscountValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnTotalValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControlItems = new DevExpress.XtraGrid.GridControl();
            this.gridViewItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButtonClose = new DevExpress.XtraEditors.SimpleButton();
            this.labelItems = new System.Windows.Forms.Label();
            this.labelLines = new System.Windows.Forms.Label();
            this.labelCustomer = new System.Windows.Forms.Label();
            this.labelEmployee = new System.Windows.Forms.Label();
            this.spinEditQuantity = new DevExpress.XtraEditors.SpinEdit();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.simpleButtonAddItem = new DevExpress.XtraEditors.SimpleButton();
            this.bsItems = new System.Windows.Forms.BindingSource(this.components);
            this.bsTransactionLines = new System.Windows.Forms.BindingSource(this.components);
            this.labelTotal = new System.Windows.Forms.Label();
            this.lookUpEditPaymentMethod = new DevExpress.XtraEditors.LookUpEdit();
            this.bsTransaction = new System.Windows.Forms.BindingSource(this.components);
            this.simpleButtonRemoveLine = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonCheckout = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonConfirm = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditQuantity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransactionLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditPaymentMethod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransaction)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlLines
            // 
            this.gridControlLines.Location = new System.Drawing.Point(493, 121);
            this.gridControlLines.MainView = this.gridViewLines;
            this.gridControlLines.Name = "gridControlLines";
            this.gridControlLines.Size = new System.Drawing.Size(694, 439);
            this.gridControlLines.TabIndex = 2;
            this.gridControlLines.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewLines});
            // 
            // gridViewLines
            // 
            this.gridViewLines.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnItemDescription,
            this.gridColumnQuantity,
            this.gridColumnItemPrice,
            this.gridColumnItemCost,
            this.gridColumnTotalCost,
            this.gridColumnNetValue,
            this.gridColumnDiscountPercent,
            this.gridColumnDiscountValue,
            this.gridColumnTotalValue});
            this.gridViewLines.GridControl = this.gridControlLines;
            this.gridViewLines.Name = "gridViewLines";
            this.gridViewLines.OptionsBehavior.Editable = false;
            // 
            // gridColumnItemDescription
            // 
            this.gridColumnItemDescription.Caption = "Item Description";
            this.gridColumnItemDescription.FieldName = "ItemDescription";
            this.gridColumnItemDescription.Name = "gridColumnItemDescription";
            this.gridColumnItemDescription.Visible = true;
            this.gridColumnItemDescription.VisibleIndex = 0;
            // 
            // gridColumnQuantity
            // 
            this.gridColumnQuantity.Caption = "Quantity";
            this.gridColumnQuantity.FieldName = "Quantity";
            this.gridColumnQuantity.Name = "gridColumnQuantity";
            this.gridColumnQuantity.Visible = true;
            this.gridColumnQuantity.VisibleIndex = 1;
            // 
            // gridColumnItemPrice
            // 
            this.gridColumnItemPrice.Caption = "Item Price";
            this.gridColumnItemPrice.FieldName = "ItemPrice";
            this.gridColumnItemPrice.Name = "gridColumnItemPrice";
            this.gridColumnItemPrice.Visible = true;
            this.gridColumnItemPrice.VisibleIndex = 2;
            // 
            // gridColumnItemCost
            // 
            this.gridColumnItemCost.Caption = "Item Cost";
            this.gridColumnItemCost.FieldName = "ItemCost";
            this.gridColumnItemCost.Name = "gridColumnItemCost";
            this.gridColumnItemCost.Visible = true;
            this.gridColumnItemCost.VisibleIndex = 3;
            // 
            // gridColumnTotalCost
            // 
            this.gridColumnTotalCost.Caption = "Total Cost";
            this.gridColumnTotalCost.FieldName = "TotalCost";
            this.gridColumnTotalCost.Name = "gridColumnTotalCost";
            this.gridColumnTotalCost.Visible = true;
            this.gridColumnTotalCost.VisibleIndex = 8;
            // 
            // gridColumnNetValue
            // 
            this.gridColumnNetValue.Caption = "Net Value";
            this.gridColumnNetValue.FieldName = "NetValue";
            this.gridColumnNetValue.Name = "gridColumnNetValue";
            this.gridColumnNetValue.Visible = true;
            this.gridColumnNetValue.VisibleIndex = 4;
            // 
            // gridColumnDiscountPercent
            // 
            this.gridColumnDiscountPercent.Caption = "Discount Percent";
            this.gridColumnDiscountPercent.FieldName = "DiscountPercent";
            this.gridColumnDiscountPercent.Name = "gridColumnDiscountPercent";
            this.gridColumnDiscountPercent.Visible = true;
            this.gridColumnDiscountPercent.VisibleIndex = 5;
            // 
            // gridColumnDiscountValue
            // 
            this.gridColumnDiscountValue.Caption = "Discount Value";
            this.gridColumnDiscountValue.FieldName = "DiscountValue";
            this.gridColumnDiscountValue.Name = "gridColumnDiscountValue";
            this.gridColumnDiscountValue.Visible = true;
            this.gridColumnDiscountValue.VisibleIndex = 6;
            // 
            // gridColumnTotalValue
            // 
            this.gridColumnTotalValue.Caption = "Total Value";
            this.gridColumnTotalValue.FieldName = "TotalValue";
            this.gridColumnTotalValue.Name = "gridColumnTotalValue";
            this.gridColumnTotalValue.Visible = true;
            this.gridColumnTotalValue.VisibleIndex = 7;
            // 
            // gridControlItems
            // 
            this.gridControlItems.Location = new System.Drawing.Point(4, 121);
            this.gridControlItems.MainView = this.gridViewItems;
            this.gridControlItems.Name = "gridControlItems";
            this.gridControlItems.Size = new System.Drawing.Size(400, 439);
            this.gridControlItems.TabIndex = 3;
            this.gridControlItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewItems});
            // 
            // gridViewItems
            // 
            this.gridViewItems.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnCode,
            this.gridColumnDescription,
            this.gridColumnCost,
            this.gridColumnPrice});
            this.gridViewItems.GridControl = this.gridControlItems;
            this.gridViewItems.Name = "gridViewItems";
            this.gridViewItems.OptionsBehavior.Editable = false;
            // 
            // gridColumnCode
            // 
            this.gridColumnCode.Caption = "Code";
            this.gridColumnCode.FieldName = "Code";
            this.gridColumnCode.Name = "gridColumnCode";
            this.gridColumnCode.Visible = true;
            this.gridColumnCode.VisibleIndex = 0;
            // 
            // gridColumnDescription
            // 
            this.gridColumnDescription.Caption = "Description";
            this.gridColumnDescription.FieldName = "Description";
            this.gridColumnDescription.Name = "gridColumnDescription";
            this.gridColumnDescription.Visible = true;
            this.gridColumnDescription.VisibleIndex = 1;
            // 
            // gridColumnCost
            // 
            this.gridColumnCost.Caption = "Cost";
            this.gridColumnCost.FieldName = "Cost";
            this.gridColumnCost.Name = "gridColumnCost";
            this.gridColumnCost.Visible = true;
            this.gridColumnCost.VisibleIndex = 2;
            // 
            // gridColumnPrice
            // 
            this.gridColumnPrice.Caption = "Price";
            this.gridColumnPrice.FieldName = "Price";
            this.gridColumnPrice.Name = "gridColumnPrice";
            this.gridColumnPrice.Visible = true;
            this.gridColumnPrice.VisibleIndex = 3;
            // 
            // simpleButtonClose
            // 
            this.simpleButtonClose.Location = new System.Drawing.Point(4, 566);
            this.simpleButtonClose.Name = "simpleButtonClose";
            this.simpleButtonClose.Size = new System.Drawing.Size(75, 41);
            this.simpleButtonClose.TabIndex = 4;
            this.simpleButtonClose.Text = "Close";
            this.simpleButtonClose.Click += new System.EventHandler(this.simpleButtonClose_Click);
            // 
            // labelItems
            // 
            this.labelItems.AutoSize = true;
            this.labelItems.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelItems.Location = new System.Drawing.Point(4, 93);
            this.labelItems.Name = "labelItems";
            this.labelItems.Size = new System.Drawing.Size(57, 25);
            this.labelItems.TabIndex = 5;
            this.labelItems.Text = "Items";
            // 
            // labelLines
            // 
            this.labelLines.AutoSize = true;
            this.labelLines.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLines.Location = new System.Drawing.Point(1031, 93);
            this.labelLines.Name = "labelLines";
            this.labelLines.Size = new System.Drawing.Size(156, 25);
            this.labelLines.TabIndex = 6;
            this.labelLines.Text = "Transaction Lines";
            // 
            // labelCustomer
            // 
            this.labelCustomer.AutoSize = true;
            this.labelCustomer.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCustomer.Location = new System.Drawing.Point(12, 39);
            this.labelCustomer.Name = "labelCustomer";
            this.labelCustomer.Size = new System.Drawing.Size(107, 30);
            this.labelCustomer.TabIndex = 7;
            this.labelCustomer.Text = "Customer:";
            // 
            // labelEmployee
            // 
            this.labelEmployee.AutoSize = true;
            this.labelEmployee.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEmployee.Location = new System.Drawing.Point(12, 9);
            this.labelEmployee.Name = "labelEmployee";
            this.labelEmployee.Size = new System.Drawing.Size(108, 30);
            this.labelEmployee.TabIndex = 8;
            this.labelEmployee.Text = "Employee:";
            // 
            // spinEditQuantity
            // 
            this.spinEditQuantity.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinEditQuantity.Location = new System.Drawing.Point(410, 204);
            this.spinEditQuantity.Name = "spinEditQuantity";
            this.spinEditQuantity.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditQuantity.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.spinEditQuantity.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinEditQuantity.Size = new System.Drawing.Size(77, 20);
            this.spinEditQuantity.TabIndex = 9;
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelQuantity.Location = new System.Drawing.Point(410, 178);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(76, 23);
            this.labelQuantity.TabIndex = 10;
            this.labelQuantity.Text = "Quantity";
            // 
            // simpleButtonAddItem
            // 
            this.simpleButtonAddItem.Location = new System.Drawing.Point(409, 255);
            this.simpleButtonAddItem.Name = "simpleButtonAddItem";
            this.simpleButtonAddItem.Size = new System.Drawing.Size(77, 93);
            this.simpleButtonAddItem.TabIndex = 11;
            this.simpleButtonAddItem.Text = "Add Item";
            this.simpleButtonAddItem.Click += new System.EventHandler(this.simpleButtonAddItem_Click);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTotal.Location = new System.Drawing.Point(570, 571);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(52, 25);
            this.labelTotal.TabIndex = 12;
            this.labelTotal.Text = "Total";
            // 
            // lookUpEditPaymentMethod
            // 
            this.lookUpEditPaymentMethod.Location = new System.Drawing.Point(761, 576);
            this.lookUpEditPaymentMethod.Name = "lookUpEditPaymentMethod";
            this.lookUpEditPaymentMethod.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditPaymentMethod.Size = new System.Drawing.Size(152, 20);
            this.lookUpEditPaymentMethod.TabIndex = 13;
            // 
            // simpleButtonRemoveLine
            // 
            this.simpleButtonRemoveLine.Location = new System.Drawing.Point(410, 368);
            this.simpleButtonRemoveLine.Name = "simpleButtonRemoveLine";
            this.simpleButtonRemoveLine.Size = new System.Drawing.Size(77, 44);
            this.simpleButtonRemoveLine.TabIndex = 14;
            this.simpleButtonRemoveLine.Text = "Remove Line";
            this.simpleButtonRemoveLine.Click += new System.EventHandler(this.simpleButtonRemoveLine_Click);
            // 
            // simpleButtonCheckout
            // 
            this.simpleButtonCheckout.Location = new System.Drawing.Point(493, 566);
            this.simpleButtonCheckout.Name = "simpleButtonCheckout";
            this.simpleButtonCheckout.Size = new System.Drawing.Size(71, 41);
            this.simpleButtonCheckout.TabIndex = 15;
            this.simpleButtonCheckout.Text = "Checkout";
            this.simpleButtonCheckout.Click += new System.EventHandler(this.simpleButtonCheckout_Click);
            // 
            // simpleButtonConfirm
            // 
            this.simpleButtonConfirm.Enabled = false;
            this.simpleButtonConfirm.Location = new System.Drawing.Point(1116, 566);
            this.simpleButtonConfirm.Name = "simpleButtonConfirm";
            this.simpleButtonConfirm.Size = new System.Drawing.Size(71, 41);
            this.simpleButtonConfirm.TabIndex = 16;
            this.simpleButtonConfirm.Text = "Confirm";
            this.simpleButtonConfirm.Click += new System.EventHandler(this.simpleButtonConfirm_Click);
            // 
            // TransactionDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 613);
            this.Controls.Add(this.simpleButtonConfirm);
            this.Controls.Add(this.simpleButtonCheckout);
            this.Controls.Add(this.simpleButtonRemoveLine);
            this.Controls.Add(this.lookUpEditPaymentMethod);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.simpleButtonAddItem);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.spinEditQuantity);
            this.Controls.Add(this.labelEmployee);
            this.Controls.Add(this.labelCustomer);
            this.Controls.Add(this.labelLines);
            this.Controls.Add(this.labelItems);
            this.Controls.Add(this.simpleButtonClose);
            this.Controls.Add(this.gridControlItems);
            this.Controls.Add(this.gridControlLines);
            this.Name = "TransactionDetailsForm";
            this.Text = "TransactionDetailsForm";
            this.Load += new System.EventHandler(this.TransactionDetailsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditQuantity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransactionLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditPaymentMethod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransaction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlLines;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewLines;
        private DevExpress.XtraGrid.GridControl gridControlItems;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewItems;
        private DevExpress.XtraEditors.SimpleButton simpleButtonClose;
        private Label labelItems;
        private Label labelLines;
        private Label labelCustomer;
        private Label labelEmployee;
        private DevExpress.XtraEditors.SpinEdit spinEditQuantity;
        private Label labelQuantity;
        private DevExpress.XtraEditors.SimpleButton simpleButtonAddItem;
        private BindingSource bsItems;
        private BindingSource bsTransactionLines;
        private Label labelTotal;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditPaymentMethod;
        private BindingSource bsTransaction;
        private DevExpress.XtraEditors.SimpleButton simpleButtonRemoveLine;
        private DevExpress.XtraEditors.SimpleButton simpleButtonCheckout;
        private DevExpress.XtraEditors.SimpleButton simpleButtonConfirm;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCode;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDescription;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCost;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPrice;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnItemPrice;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnItemCost;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnTotalCost;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnNetValue;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDiscountPercent;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDiscountValue;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnTotalValue;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnItemDescription;
    }
}