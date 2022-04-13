namespace WinForms.Client {
    partial class ItemDetailsForm {
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
            this.textEditCode = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.textEditDescription = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lookUpEditItemType = new DevExpress.XtraEditors.LookUpEdit();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.calcEditCost = new DevExpress.XtraEditors.CalcEdit();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.calcEditPrice = new DevExpress.XtraEditors.CalcEdit();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleButtonClose = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleButtonSave = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.bsItem = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditItemType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcEditCost.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcEditPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsItem)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.simpleButtonSave);
            this.layoutControl1.Controls.Add(this.simpleButtonClose);
            this.layoutControl1.Controls.Add(this.calcEditPrice);
            this.layoutControl1.Controls.Add(this.calcEditCost);
            this.layoutControl1.Controls.Add(this.lookUpEditItemType);
            this.layoutControl1.Controls.Add(this.textEditDescription);
            this.layoutControl1.Controls.Add(this.textEditCode);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(800, 450);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(800, 450);
            this.Root.TextVisible = false;
            // 
            // textEditCode
            // 
            this.textEditCode.Location = new System.Drawing.Point(77, 12);
            this.textEditCode.Name = "textEditCode";
            this.textEditCode.Size = new System.Drawing.Size(711, 20);
            this.textEditCode.StyleController = this.layoutControl1;
            this.textEditCode.TabIndex = 4;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.textEditCode;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(780, 24);
            this.layoutControlItem1.Text = "Code";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(53, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 120);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(780, 284);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // textEditDescription
            // 
            this.textEditDescription.Location = new System.Drawing.Point(77, 36);
            this.textEditDescription.Name = "textEditDescription";
            this.textEditDescription.Size = new System.Drawing.Size(711, 20);
            this.textEditDescription.StyleController = this.layoutControl1;
            this.textEditDescription.TabIndex = 5;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.textEditDescription;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(780, 24);
            this.layoutControlItem2.Text = "Description";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(53, 13);
            // 
            // lookUpEditItemType
            // 
            this.lookUpEditItemType.Location = new System.Drawing.Point(77, 60);
            this.lookUpEditItemType.Name = "lookUpEditItemType";
            this.lookUpEditItemType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditItemType.Size = new System.Drawing.Size(711, 20);
            this.lookUpEditItemType.StyleController = this.layoutControl1;
            this.lookUpEditItemType.TabIndex = 6;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.lookUpEditItemType;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(780, 24);
            this.layoutControlItem3.Text = "Item Type";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(53, 13);
            // 
            // calcEditCost
            // 
            this.calcEditCost.Location = new System.Drawing.Point(77, 84);
            this.calcEditCost.Name = "calcEditCost";
            this.calcEditCost.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calcEditCost.Size = new System.Drawing.Size(711, 20);
            this.calcEditCost.StyleController = this.layoutControl1;
            this.calcEditCost.TabIndex = 7;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.calcEditCost;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(780, 24);
            this.layoutControlItem4.Text = "Cost";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(53, 13);
            // 
            // calcEditPrice
            // 
            this.calcEditPrice.Location = new System.Drawing.Point(77, 108);
            this.calcEditPrice.Name = "calcEditPrice";
            this.calcEditPrice.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calcEditPrice.Size = new System.Drawing.Size(711, 20);
            this.calcEditPrice.StyleController = this.layoutControl1;
            this.calcEditPrice.TabIndex = 8;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.calcEditPrice;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(780, 24);
            this.layoutControlItem5.Text = "Price";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(53, 13);
            // 
            // simpleButtonClose
            // 
            this.simpleButtonClose.Location = new System.Drawing.Point(12, 416);
            this.simpleButtonClose.Name = "simpleButtonClose";
            this.simpleButtonClose.Size = new System.Drawing.Size(386, 22);
            this.simpleButtonClose.StyleController = this.layoutControl1;
            this.simpleButtonClose.TabIndex = 9;
            this.simpleButtonClose.Text = "Close";
            this.simpleButtonClose.Click += new System.EventHandler(this.simpleButtonClose_Click);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.simpleButtonClose;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 404);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(390, 26);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // simpleButtonSave
            // 
            this.simpleButtonSave.Location = new System.Drawing.Point(402, 416);
            this.simpleButtonSave.Name = "simpleButtonSave";
            this.simpleButtonSave.Size = new System.Drawing.Size(386, 22);
            this.simpleButtonSave.StyleController = this.layoutControl1;
            this.simpleButtonSave.TabIndex = 10;
            this.simpleButtonSave.Text = "Save";
            this.simpleButtonSave.Click += new System.EventHandler(this.simpleButtonSave_Click);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.simpleButtonSave;
            this.layoutControlItem7.Location = new System.Drawing.Point(390, 404);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(390, 26);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // ItemDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.layoutControl1);
            this.Name = "ItemDetailsForm";
            this.Text = "Item Details";
            this.Load += new System.EventHandler(this.ItemDetailsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditItemType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcEditCost.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcEditPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButtonSave;
        private DevExpress.XtraEditors.SimpleButton simpleButtonClose;
        private DevExpress.XtraEditors.CalcEdit calcEditPrice;
        private DevExpress.XtraEditors.CalcEdit calcEditCost;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditItemType;
        private DevExpress.XtraEditors.TextEdit textEditDescription;
        private DevExpress.XtraEditors.TextEdit textEditCode;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private BindingSource bsItem;
    }
}