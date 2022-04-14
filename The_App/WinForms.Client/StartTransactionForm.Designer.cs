namespace WinForms.Client {
    partial class StartTransactionForm {
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
            this.gridControlEmployees = new DevExpress.XtraGrid.GridControl();
            this.gridViewEmployees = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnSurname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControlCustomers = new DevExpress.XtraGrid.GridControl();
            this.gridViewCustomers = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnNameCustomer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnSurnameCustomer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButtonConfirm = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonClose = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bsEmployees = new System.Windows.Forms.BindingSource(this.components);
            this.bsCustomers = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlEmployees
            // 
            this.gridControlEmployees.Location = new System.Drawing.Point(12, 40);
            this.gridControlEmployees.MainView = this.gridViewEmployees;
            this.gridControlEmployees.Name = "gridControlEmployees";
            this.gridControlEmployees.Size = new System.Drawing.Size(359, 356);
            this.gridControlEmployees.TabIndex = 0;
            this.gridControlEmployees.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewEmployees});
            // 
            // gridViewEmployees
            // 
            this.gridViewEmployees.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnName,
            this.gridColumnSurname,
            this.gridColumnType});
            this.gridViewEmployees.GridControl = this.gridControlEmployees;
            this.gridViewEmployees.Name = "gridViewEmployees";
            this.gridViewEmployees.OptionsBehavior.Editable = false;
            // 
            // gridColumnName
            // 
            this.gridColumnName.Caption = "Name";
            this.gridColumnName.FieldName = "Name";
            this.gridColumnName.Name = "gridColumnName";
            this.gridColumnName.Visible = true;
            this.gridColumnName.VisibleIndex = 0;
            // 
            // gridColumnSurname
            // 
            this.gridColumnSurname.Caption = "Surname";
            this.gridColumnSurname.FieldName = "Surname";
            this.gridColumnSurname.Name = "gridColumnSurname";
            this.gridColumnSurname.Visible = true;
            this.gridColumnSurname.VisibleIndex = 1;
            // 
            // gridColumnType
            // 
            this.gridColumnType.Caption = "Type";
            this.gridColumnType.FieldName = "EmployeeType";
            this.gridColumnType.Name = "gridColumnType";
            this.gridColumnType.Visible = true;
            this.gridColumnType.VisibleIndex = 2;
            // 
            // gridControlCustomers
            // 
            this.gridControlCustomers.Location = new System.Drawing.Point(397, 40);
            this.gridControlCustomers.MainView = this.gridViewCustomers;
            this.gridControlCustomers.Name = "gridControlCustomers";
            this.gridControlCustomers.Size = new System.Drawing.Size(400, 356);
            this.gridControlCustomers.TabIndex = 1;
            this.gridControlCustomers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCustomers});
            // 
            // gridViewCustomers
            // 
            this.gridViewCustomers.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnNameCustomer,
            this.gridColumnSurnameCustomer});
            this.gridViewCustomers.GridControl = this.gridControlCustomers;
            this.gridViewCustomers.Name = "gridViewCustomers";
            this.gridViewCustomers.OptionsBehavior.Editable = false;
            // 
            // gridColumnNameCustomer
            // 
            this.gridColumnNameCustomer.Caption = "Name";
            this.gridColumnNameCustomer.FieldName = "Name";
            this.gridColumnNameCustomer.Name = "gridColumnNameCustomer";
            this.gridColumnNameCustomer.Visible = true;
            this.gridColumnNameCustomer.VisibleIndex = 0;
            // 
            // gridColumnSurnameCustomer
            // 
            this.gridColumnSurnameCustomer.Caption = "Surname";
            this.gridColumnSurnameCustomer.FieldName = "Surname";
            this.gridColumnSurnameCustomer.Name = "gridColumnSurnameCustomer";
            this.gridColumnSurnameCustomer.Visible = true;
            this.gridColumnSurnameCustomer.VisibleIndex = 1;
            // 
            // simpleButtonConfirm
            // 
            this.simpleButtonConfirm.Location = new System.Drawing.Point(700, 402);
            this.simpleButtonConfirm.Name = "simpleButtonConfirm";
            this.simpleButtonConfirm.Size = new System.Drawing.Size(97, 47);
            this.simpleButtonConfirm.TabIndex = 2;
            this.simpleButtonConfirm.Text = "Confirm";
            this.simpleButtonConfirm.Click += new System.EventHandler(this.simpleButtonConfirm_Click);
            // 
            // simpleButtonClose
            // 
            this.simpleButtonClose.Location = new System.Drawing.Point(12, 402);
            this.simpleButtonClose.Name = "simpleButtonClose";
            this.simpleButtonClose.Size = new System.Drawing.Size(96, 47);
            this.simpleButtonClose.TabIndex = 3;
            this.simpleButtonClose.Text = "Close";
            this.simpleButtonClose.Click += new System.EventHandler(this.simpleButtonClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Employees";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(397, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "Customers";
            // 
            // StartTransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 455);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.simpleButtonClose);
            this.Controls.Add(this.simpleButtonConfirm);
            this.Controls.Add(this.gridControlCustomers);
            this.Controls.Add(this.gridControlEmployees);
            this.Name = "StartTransactionForm";
            this.Text = "New Transaction";
            this.Load += new System.EventHandler(this.StartTransactionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlEmployees;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewEmployees;
        private DevExpress.XtraGrid.GridControl gridControlCustomers;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCustomers;
        private DevExpress.XtraEditors.SimpleButton simpleButtonConfirm;
        private DevExpress.XtraEditors.SimpleButton simpleButtonClose;
        private Label label1;
        private Label label2;
        private BindingSource bsEmployees;
        private BindingSource bsCustomers;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSurname;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnType;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnNameCustomer;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSurnameCustomer;
    }
}