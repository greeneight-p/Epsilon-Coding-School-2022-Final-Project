namespace WinForms.Client {
    partial class LoginForm {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.lookUpEditUsers = new DevExpress.XtraEditors.LookUpEdit();
            this.simpleButtonLogin = new DevExpress.XtraEditors.SimpleButton();
            this.textEditPassword = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.Password = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.User = new DevExpress.XtraLayout.LayoutControlItem();
            this.bsloginViewModel = new System.Windows.Forms.BindingSource(this.components);
            this.spinEditPort = new DevExpress.XtraEditors.SpinEdit();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleButtonPort = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.label1 = new System.Windows.Forms.Label();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditUsers.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.User)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsloginViewModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditPort.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.label1);
            this.layoutControl1.Controls.Add(this.simpleButtonPort);
            this.layoutControl1.Controls.Add(this.spinEditPort);
            this.layoutControl1.Controls.Add(this.lookUpEditUsers);
            this.layoutControl1.Controls.Add(this.simpleButtonLogin);
            this.layoutControl1.Controls.Add(this.textEditPassword);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(800, 450);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // lookUpEditUsers
            // 
            this.lookUpEditUsers.Location = new System.Drawing.Point(77, 12);
            this.lookUpEditUsers.Name = "lookUpEditUsers";
            this.lookUpEditUsers.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditUsers.Properties.NullText = "Employee Type";
            this.lookUpEditUsers.Size = new System.Drawing.Size(711, 20);
            this.lookUpEditUsers.StyleController = this.layoutControl1;
            this.lookUpEditUsers.TabIndex = 7;
            // 
            // simpleButtonLogin
            // 
            this.simpleButtonLogin.Location = new System.Drawing.Point(12, 60);
            this.simpleButtonLogin.Name = "simpleButtonLogin";
            this.simpleButtonLogin.Size = new System.Drawing.Size(776, 22);
            this.simpleButtonLogin.StyleController = this.layoutControl1;
            this.simpleButtonLogin.TabIndex = 6;
            this.simpleButtonLogin.Text = "Log In";
            this.simpleButtonLogin.Click += new System.EventHandler(this.simpleButtonLogin_Click);
            // 
            // textEditPassword
            // 
            this.textEditPassword.Location = new System.Drawing.Point(77, 36);
            this.textEditPassword.Name = "textEditPassword";
            this.textEditPassword.Properties.PasswordChar = '*';
            this.textEditPassword.Size = new System.Drawing.Size(711, 20);
            this.textEditPassword.StyleController = this.layoutControl1;
            this.textEditPassword.TabIndex = 5;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.Password,
            this.layoutControlItem1,
            this.User,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(800, 450);
            this.Root.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 74);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(780, 306);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // Password
            // 
            this.Password.Control = this.textEditPassword;
            this.Password.Location = new System.Drawing.Point(0, 24);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(780, 24);
            this.Password.TextSize = new System.Drawing.Size(53, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.simpleButtonLogin;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(780, 26);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // User
            // 
            this.User.Control = this.lookUpEditUsers;
            this.User.Location = new System.Drawing.Point(0, 0);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(780, 24);
            this.User.TextSize = new System.Drawing.Size(53, 13);
            // 
            // spinEditPort
            // 
            this.spinEditPort.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinEditPort.Location = new System.Drawing.Point(77, 416);
            this.spinEditPort.Name = "spinEditPort";
            this.spinEditPort.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditPort.Properties.MaxValue = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.spinEditPort.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinEditPort.Size = new System.Drawing.Size(321, 20);
            this.spinEditPort.StyleController = this.layoutControl1;
            this.spinEditPort.TabIndex = 8;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.spinEditPort;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 404);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(390, 26);
            this.layoutControlItem2.Text = "Active Port";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(53, 13);
            // 
            // simpleButtonPort
            // 
            this.simpleButtonPort.Location = new System.Drawing.Point(402, 416);
            this.simpleButtonPort.Name = "simpleButtonPort";
            this.simpleButtonPort.Size = new System.Drawing.Size(386, 22);
            this.simpleButtonPort.StyleController = this.layoutControl1;
            this.simpleButtonPort.TabIndex = 9;
            this.simpleButtonPort.Text = "Set";
            this.simpleButtonPort.Click += new System.EventHandler(this.simpleButtonPort_Click);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.simpleButtonPort;
            this.layoutControlItem3.Location = new System.Drawing.Point(390, 404);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(390, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 392);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(776, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Server";
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.label1;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 380);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(780, 24);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.layoutControl1);
            this.Name = "LoginForm";
            this.Text = "Fuel Station";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditUsers.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.User)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsloginViewModel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditPort.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit textEditPassword;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem Password;
        private DevExpress.XtraEditors.SimpleButton simpleButtonLogin;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditUsers;
        private DevExpress.XtraLayout.LayoutControlItem User;
        private BindingSource bsloginViewModel;
        private DevExpress.XtraEditors.SimpleButton simpleButtonPort;
        private DevExpress.XtraEditors.SpinEdit spinEditPort;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private Label label1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    }
}