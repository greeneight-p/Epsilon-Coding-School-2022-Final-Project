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
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
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
            this.lookUpEditUsers.Location = new System.Drawing.Point(70, 12);
            this.lookUpEditUsers.Name = "lookUpEditUsers";
            this.lookUpEditUsers.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditUsers.Properties.NullText = "Employee Type";
            this.lookUpEditUsers.Size = new System.Drawing.Size(718, 20);
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
            this.textEditPassword.Location = new System.Drawing.Point(70, 36);
            this.textEditPassword.Name = "textEditPassword";
            this.textEditPassword.Properties.PasswordChar = '*';
            this.textEditPassword.Size = new System.Drawing.Size(718, 20);
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
            this.User});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(800, 450);
            this.Root.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 74);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(780, 356);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // Password
            // 
            this.Password.Control = this.textEditPassword;
            this.Password.Location = new System.Drawing.Point(0, 24);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(780, 24);
            this.Password.TextSize = new System.Drawing.Size(46, 13);
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
            this.User.TextSize = new System.Drawing.Size(46, 13);
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
    }
}