namespace HH.ZK.UI
{
    partial class FrmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.chk记住登录名 = new System.Windows.Forms.CheckBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnResetPwd = new System.Windows.Forms.Button();
            this.txtLogName = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "账号: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "密码:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(39, 166);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(339, 45);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "登录(&L)";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPassword.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtPassword.Location = new System.Drawing.Point(39, 94);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(339, 30);
            this.txtPassword.TabIndex = 1;
            // 
            // chk记住登录名
            // 
            this.chk记住登录名.AutoSize = true;
            this.chk记住登录名.Checked = true;
            this.chk记住登录名.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk记住登录名.Location = new System.Drawing.Point(295, 140);
            this.chk记住登录名.Name = "chk记住登录名";
            this.chk记住登录名.Size = new System.Drawing.Size(84, 16);
            this.chk记住登录名.TabIndex = 6;
            this.chk记住登录名.Text = "记住登录名";
            this.chk记住登录名.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(252, 234);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(126, 28);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "退出";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnResetPwd
            // 
            this.btnResetPwd.Location = new System.Drawing.Point(39, 234);
            this.btnResetPwd.Name = "btnResetPwd";
            this.btnResetPwd.Size = new System.Drawing.Size(123, 28);
            this.btnResetPwd.TabIndex = 8;
            this.btnResetPwd.Text = "忘记密码";
            this.btnResetPwd.UseVisualStyleBackColor = true;
            this.btnResetPwd.Click += new System.EventHandler(this.btnResetPwd_Click);
            // 
            // txtLogName
            // 
            this.txtLogName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtLogName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtLogName.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtLogName.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtLogName.Location = new System.Drawing.Point(39, 35);
            this.txtLogName.MaxLength = 20;
            this.txtLogName.Name = "txtLogName";
            this.txtLogName.Size = new System.Drawing.Size(339, 28);
            this.txtLogName.TabIndex = 0;
            // 
            // FrmLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 281);
            this.Controls.Add(this.txtLogName);
            this.Controls.Add(this.btnResetPwd);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.chk记住登录名);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btnLogin;
        public LJH.GeneralLibrary.WinformControl.DBCTextBox  txtPassword;
        private System.Windows.Forms.CheckBox chk记住登录名;
        public System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.Button btnResetPwd;
        public System.Windows.Forms.ComboBox txtLogName;
    }
}