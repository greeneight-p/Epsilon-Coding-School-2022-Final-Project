namespace WinForms.Client {
    partial class ItemListForm {
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
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.gridControlItems = new DevExpress.XtraGrid.GridControl();
            this.gridViewItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleButtonClose = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleButtonEdit = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleButtonDelete = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleButtonNew = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleButtonReverseActiveItems = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.bsItemList = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsItemList)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.simpleButtonReverseActiveItems);
            this.layoutControl1.Controls.Add(this.simpleButtonNew);
            this.layoutControl1.Controls.Add(this.simpleButtonDelete);
            this.layoutControl1.Controls.Add(this.simpleButtonEdit);
            this.layoutControl1.Controls.Add(this.simpleButtonClose);
            this.layoutControl1.Controls.Add(this.gridControlItems);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(800, 452);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
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
            this.Root.Size = new System.Drawing.Size(800, 452);
            this.Root.TextVisible = false;
            // 
            // gridControlItems
            // 
            this.gridControlItems.Location = new System.Drawing.Point(12, 38);
            this.gridControlItems.MainView = this.gridViewItems;
            this.gridControlItems.Name = "gridControlItems";
            this.gridControlItems.Size = new System.Drawing.Size(776, 376);
            this.gridControlItems.TabIndex = 4;
            this.gridControlItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewItems});
            // 
            // gridViewItems
            // 
            this.gridViewItems.GridControl = this.gridControlItems;
            this.gridViewItems.Name = "gridViewItems";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControlItems;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(780, 380);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // simpleButtonClose
            // 
            this.simpleButtonClose.Location = new System.Drawing.Point(12, 418);
            this.simpleButtonClose.Name = "simpleButtonClose";
            this.simpleButtonClose.Size = new System.Drawing.Size(191, 22);
            this.simpleButtonClose.StyleController = this.layoutControl1;
            this.simpleButtonClose.TabIndex = 5;
            this.simpleButtonClose.Text = "Close";
            this.simpleButtonClose.Click += new System.EventHandler(this.simpleButtonClose_Click);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.simpleButtonClose;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 406);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(195, 26);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // simpleButtonEdit
            // 
            this.simpleButtonEdit.Location = new System.Drawing.Point(402, 418);
            this.simpleButtonEdit.Name = "simpleButtonEdit";
            this.simpleButtonEdit.Size = new System.Drawing.Size(191, 22);
            this.simpleButtonEdit.StyleController = this.layoutControl1;
            this.simpleButtonEdit.TabIndex = 6;
            this.simpleButtonEdit.Text = "Edit";
            this.simpleButtonEdit.Click += new System.EventHandler(this.simpleButtonEdit_Click);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.simpleButtonEdit;
            this.layoutControlItem3.Location = new System.Drawing.Point(390, 406);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(195, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // simpleButtonDelete
            // 
            this.simpleButtonDelete.Location = new System.Drawing.Point(597, 418);
            this.simpleButtonDelete.Name = "simpleButtonDelete";
            this.simpleButtonDelete.Size = new System.Drawing.Size(191, 22);
            this.simpleButtonDelete.StyleController = this.layoutControl1;
            this.simpleButtonDelete.TabIndex = 7;
            this.simpleButtonDelete.Text = "Delete";
            this.simpleButtonDelete.Click += new System.EventHandler(this.simpleButtonDelete_Click);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.simpleButtonDelete;
            this.layoutControlItem4.Location = new System.Drawing.Point(585, 406);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(195, 26);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // simpleButtonNew
            // 
            this.simpleButtonNew.Location = new System.Drawing.Point(207, 418);
            this.simpleButtonNew.Name = "simpleButtonNew";
            this.simpleButtonNew.Size = new System.Drawing.Size(191, 22);
            this.simpleButtonNew.StyleController = this.layoutControl1;
            this.simpleButtonNew.TabIndex = 8;
            this.simpleButtonNew.Text = "New";
            this.simpleButtonNew.Click += new System.EventHandler(this.simpleButtonNew_Click);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.simpleButtonNew;
            this.layoutControlItem5.Location = new System.Drawing.Point(195, 406);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(195, 26);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // simpleButtonReverseActiveItems
            // 
            this.simpleButtonReverseActiveItems.Location = new System.Drawing.Point(12, 12);
            this.simpleButtonReverseActiveItems.Name = "simpleButtonReverseActiveItems";
            this.simpleButtonReverseActiveItems.Size = new System.Drawing.Size(776, 22);
            this.simpleButtonReverseActiveItems.StyleController = this.layoutControl1;
            this.simpleButtonReverseActiveItems.TabIndex = 9;
            this.simpleButtonReverseActiveItems.Text = "Show Deleted Items";
            this.simpleButtonReverseActiveItems.Click += new System.EventHandler(this.simpleButtonReverseActiveItems_Click);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.simpleButtonReverseActiveItems;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(780, 26);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // ItemListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 452);
            this.Controls.Add(this.layoutControl1);
            this.Name = "ItemListForm";
            this.Text = "Items";
            this.Load += new System.EventHandler(this.ItemListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsItemList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButtonReverseActiveItems;
        private DevExpress.XtraEditors.SimpleButton simpleButtonNew;
        private DevExpress.XtraEditors.SimpleButton simpleButtonDelete;
        private DevExpress.XtraEditors.SimpleButton simpleButtonEdit;
        private DevExpress.XtraEditors.SimpleButton simpleButtonClose;
        private DevExpress.XtraGrid.GridControl gridControlItems;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewItems;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private BindingSource bsItemList;
    }
}