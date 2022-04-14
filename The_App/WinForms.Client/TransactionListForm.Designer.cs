namespace WinForms.Client {
    partial class TransactionListForm {
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.simpleButtonReverseActiveTransactions = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonNew = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonDelete = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonEdit = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonClose = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlTransactions = new DevExpress.XtraGrid.GridControl();
            this.gridViewTransactions = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.bsTransactions = new System.Windows.Forms.BindingSource(this.components);
            this.gridColumnDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnEmployee = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCustomer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnPaymentMethod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1TotalValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnTotalCost = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransactions)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.simpleButtonReverseActiveTransactions);
            this.layoutControl1.Controls.Add(this.simpleButtonNew);
            this.layoutControl1.Controls.Add(this.simpleButtonDelete);
            this.layoutControl1.Controls.Add(this.simpleButtonEdit);
            this.layoutControl1.Controls.Add(this.simpleButtonClose);
            this.layoutControl1.Controls.Add(this.gridControlTransactions);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1116, 450);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // simpleButtonReverseActiveTransactions
            // 
            this.simpleButtonReverseActiveTransactions.Location = new System.Drawing.Point(12, 12);
            this.simpleButtonReverseActiveTransactions.Name = "simpleButtonReverseActiveTransactions";
            this.simpleButtonReverseActiveTransactions.Size = new System.Drawing.Size(1092, 22);
            this.simpleButtonReverseActiveTransactions.StyleController = this.layoutControl1;
            this.simpleButtonReverseActiveTransactions.TabIndex = 9;
            this.simpleButtonReverseActiveTransactions.Text = "Show Deleted Transactions";
            this.simpleButtonReverseActiveTransactions.Click += new System.EventHandler(this.simpleButtonReverseActiveTransactions_Click);
            // 
            // simpleButtonNew
            // 
            this.simpleButtonNew.Location = new System.Drawing.Point(286, 416);
            this.simpleButtonNew.Name = "simpleButtonNew";
            this.simpleButtonNew.Size = new System.Drawing.Size(270, 22);
            this.simpleButtonNew.StyleController = this.layoutControl1;
            this.simpleButtonNew.TabIndex = 8;
            this.simpleButtonNew.Text = "New";
            this.simpleButtonNew.Click += new System.EventHandler(this.simpleButtonNew_Click);
            // 
            // simpleButtonDelete
            // 
            this.simpleButtonDelete.Location = new System.Drawing.Point(834, 416);
            this.simpleButtonDelete.Name = "simpleButtonDelete";
            this.simpleButtonDelete.Size = new System.Drawing.Size(270, 22);
            this.simpleButtonDelete.StyleController = this.layoutControl1;
            this.simpleButtonDelete.TabIndex = 7;
            this.simpleButtonDelete.Text = "Delete";
            this.simpleButtonDelete.Click += new System.EventHandler(this.simpleButtonDelete_Click);
            // 
            // simpleButtonEdit
            // 
            this.simpleButtonEdit.Location = new System.Drawing.Point(560, 416);
            this.simpleButtonEdit.Name = "simpleButtonEdit";
            this.simpleButtonEdit.Size = new System.Drawing.Size(270, 22);
            this.simpleButtonEdit.StyleController = this.layoutControl1;
            this.simpleButtonEdit.TabIndex = 6;
            this.simpleButtonEdit.Text = "Edit";
            this.simpleButtonEdit.Click += new System.EventHandler(this.simpleButtonEdit_Click);
            // 
            // simpleButtonClose
            // 
            this.simpleButtonClose.Location = new System.Drawing.Point(12, 416);
            this.simpleButtonClose.Name = "simpleButtonClose";
            this.simpleButtonClose.Size = new System.Drawing.Size(270, 22);
            this.simpleButtonClose.StyleController = this.layoutControl1;
            this.simpleButtonClose.TabIndex = 5;
            this.simpleButtonClose.Text = "Close";
            this.simpleButtonClose.Click += new System.EventHandler(this.simpleButtonClose_Click);
            // 
            // gridControlTransactions
            // 
            this.gridControlTransactions.Location = new System.Drawing.Point(12, 38);
            this.gridControlTransactions.MainView = this.gridViewTransactions;
            this.gridControlTransactions.Name = "gridControlTransactions";
            this.gridControlTransactions.Size = new System.Drawing.Size(1092, 374);
            this.gridControlTransactions.TabIndex = 4;
            this.gridControlTransactions.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewTransactions});
            // 
            // gridViewTransactions
            // 
            this.gridViewTransactions.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnDate,
            this.gridColumnEmployee,
            this.gridColumnCustomer,
            this.gridColumnPaymentMethod,
            this.gridColumn1TotalValue,
            this.gridColumnTotalCost});
            this.gridViewTransactions.GridControl = this.gridControlTransactions;
            this.gridViewTransactions.Name = "gridViewTransactions";
            this.gridViewTransactions.OptionsBehavior.Editable = false;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1116, 450);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControlTransactions;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1096, 378);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.simpleButtonClose;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 404);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(274, 26);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.simpleButtonEdit;
            this.layoutControlItem3.Location = new System.Drawing.Point(548, 404);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(274, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.simpleButtonDelete;
            this.layoutControlItem4.Location = new System.Drawing.Point(822, 404);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(274, 26);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.simpleButtonNew;
            this.layoutControlItem5.Location = new System.Drawing.Point(274, 404);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(274, 26);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.simpleButtonReverseActiveTransactions;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(1096, 26);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // gridColumnDate
            // 
            this.gridColumnDate.Caption = "Date";
            this.gridColumnDate.FieldName = "Date";
            this.gridColumnDate.Name = "gridColumnDate";
            this.gridColumnDate.Visible = true;
            this.gridColumnDate.VisibleIndex = 0;
            // 
            // gridColumnEmployee
            // 
            this.gridColumnEmployee.Caption = "Employee";
            this.gridColumnEmployee.FieldName = "Employee";
            this.gridColumnEmployee.Name = "gridColumnEmployee";
            this.gridColumnEmployee.Visible = true;
            this.gridColumnEmployee.VisibleIndex = 1;
            // 
            // gridColumnCustomer
            // 
            this.gridColumnCustomer.Caption = "Customer";
            this.gridColumnCustomer.FieldName = "Customer";
            this.gridColumnCustomer.Name = "gridColumnCustomer";
            this.gridColumnCustomer.Visible = true;
            this.gridColumnCustomer.VisibleIndex = 2;
            // 
            // gridColumnPaymentMethod
            // 
            this.gridColumnPaymentMethod.Caption = "Payment Method";
            this.gridColumnPaymentMethod.FieldName = "PaymentMethod";
            this.gridColumnPaymentMethod.Name = "gridColumnPaymentMethod";
            this.gridColumnPaymentMethod.Visible = true;
            this.gridColumnPaymentMethod.VisibleIndex = 3;
            // 
            // gridColumn1TotalValue
            // 
            this.gridColumn1TotalValue.Caption = "Tota lValue";
            this.gridColumn1TotalValue.FieldName = "TotalValue";
            this.gridColumn1TotalValue.Name = "gridColumn1TotalValue";
            this.gridColumn1TotalValue.Visible = true;
            this.gridColumn1TotalValue.VisibleIndex = 4;
            // 
            // gridColumnTotalCost
            // 
            this.gridColumnTotalCost.Caption = "Total Cost";
            this.gridColumnTotalCost.FieldName = "TotalCost";
            this.gridColumnTotalCost.Name = "gridColumnTotalCost";
            this.gridColumnTotalCost.Visible = true;
            this.gridColumnTotalCost.VisibleIndex = 5;
            // 
            // TransactionListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 450);
            this.Controls.Add(this.layoutControl1);
            this.Name = "TransactionListForm";
            this.Text = "Transactions";
            this.Load += new System.EventHandler(this.TransactionListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransactions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButtonNew;
        private DevExpress.XtraEditors.SimpleButton simpleButtonDelete;
        private DevExpress.XtraEditors.SimpleButton simpleButtonEdit;
        private DevExpress.XtraEditors.SimpleButton simpleButtonClose;
        private DevExpress.XtraGrid.GridControl gridControlTransactions;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewTransactions;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.SimpleButton simpleButtonReverseActiveTransactions;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private BindingSource bsTransactions;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDate;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnEmployee;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCustomer;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPaymentMethod;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1TotalValue;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnTotalCost;
    }
}