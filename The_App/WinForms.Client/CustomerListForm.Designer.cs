namespace WinForms.Client {
    partial class CustomerListForm {
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
            this.bsCustomers = new System.Windows.Forms.BindingSource(this.components);
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.simpleButtonNew = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonEdit = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonDelete = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonClose = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlCustomers = new DevExpress.XtraGrid.GridControl();
            this.gridViewCustomers = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.simpleButtonReverseActive = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.simpleButtonNew);
            this.layoutControl1.Controls.Add(this.simpleButtonEdit);
            this.layoutControl1.Controls.Add(this.simpleButtonDelete);
            this.layoutControl1.Controls.Add(this.simpleButtonClose);
            this.layoutControl1.Controls.Add(this.gridControlCustomers);
            this.layoutControl1.Controls.Add(this.simpleButtonReverseActive);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(657, 0, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(800, 450);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // simpleButtonNew
            // 
            this.simpleButtonNew.Location = new System.Drawing.Point(207, 416);
            this.simpleButtonNew.Name = "simpleButtonNew";
            this.simpleButtonNew.Size = new System.Drawing.Size(191, 22);
            this.simpleButtonNew.StyleController = this.layoutControl1;
            this.simpleButtonNew.TabIndex = 8;
            this.simpleButtonNew.Text = "New";
            this.simpleButtonNew.Click += new System.EventHandler(this.simpleButtonNew_ClickAsync);
            // 
            // simpleButtonEdit
            // 
            this.simpleButtonEdit.Location = new System.Drawing.Point(402, 416);
            this.simpleButtonEdit.Name = "simpleButtonEdit";
            this.simpleButtonEdit.Size = new System.Drawing.Size(191, 22);
            this.simpleButtonEdit.StyleController = this.layoutControl1;
            this.simpleButtonEdit.TabIndex = 7;
            this.simpleButtonEdit.Text = "Edit";
            this.simpleButtonEdit.Click += new System.EventHandler(this.simpleButtonEdit_Click);
            // 
            // simpleButtonDelete
            // 
            this.simpleButtonDelete.Location = new System.Drawing.Point(597, 416);
            this.simpleButtonDelete.Name = "simpleButtonDelete";
            this.simpleButtonDelete.Size = new System.Drawing.Size(191, 22);
            this.simpleButtonDelete.StyleController = this.layoutControl1;
            this.simpleButtonDelete.TabIndex = 6;
            this.simpleButtonDelete.Text = "Delete";
            this.simpleButtonDelete.Click += new System.EventHandler(this.simpleButtonDelete_Click);
            // 
            // simpleButtonClose
            // 
            this.simpleButtonClose.Location = new System.Drawing.Point(12, 416);
            this.simpleButtonClose.Name = "simpleButtonClose";
            this.simpleButtonClose.Size = new System.Drawing.Size(191, 22);
            this.simpleButtonClose.StyleController = this.layoutControl1;
            this.simpleButtonClose.TabIndex = 5;
            this.simpleButtonClose.Text = "Close";
            this.simpleButtonClose.Click += new System.EventHandler(this.simpleButtonClose_Click);
            // 
            // gridControlCustomers
            // 
            this.gridControlCustomers.Location = new System.Drawing.Point(11, 40);
            this.gridControlCustomers.MainView = this.gridViewCustomers;
            this.gridControlCustomers.Name = "gridControlCustomers";
            this.gridControlCustomers.Size = new System.Drawing.Size(776, 370);
            this.gridControlCustomers.TabIndex = 4;
            this.gridControlCustomers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCustomers});
            // 
            // gridViewCustomers
            // 
            this.gridViewCustomers.GridControl = this.gridControlCustomers;
            this.gridViewCustomers.Name = "gridViewCustomers";
            // 
            // simpleButtonReverseActive
            // 
            this.simpleButtonReverseActive.Location = new System.Drawing.Point(12, 12);
            this.simpleButtonReverseActive.Name = "simpleButtonReverseActive";
            this.simpleButtonReverseActive.Size = new System.Drawing.Size(776, 22);
            this.simpleButtonReverseActive.StyleController = this.layoutControl1;
            this.simpleButtonReverseActive.TabIndex = 9;
            this.simpleButtonReverseActive.Text = "Show Deleted Customers";
            this.simpleButtonReverseActive.Click += new System.EventHandler(this.simpleButtonReverseActive_Click);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(800, 450);
            this.Root.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(780, 430);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // CustomerListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.layoutControl1);
            this.Name = "CustomerListForm";
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.CustomerListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BindingSource bsCustomers;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButtonNew;
        private DevExpress.XtraEditors.SimpleButton simpleButtonEdit;
        private DevExpress.XtraEditors.SimpleButton simpleButtonDelete;
        private DevExpress.XtraEditors.SimpleButton simpleButtonClose;
        private DevExpress.XtraGrid.GridControl gridControlCustomers;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCustomers;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.SimpleButton simpleButtonReverseActive;
    }
}