namespace HH.ZK.UI.中山中考
{
    partial class Frm中山中考数据接口
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
            this.pStudent = new LJH.GeneralLibrary.WinformControl.PercentageProgressBar(this.components);
            this.pScore = new LJH.GeneralLibrary.WinformControl.PercentageProgressBar(this.components);
            this.btnUpload = new System.Windows.Forms.Button();
            this.gpDB = new System.Windows.Forms.GroupBox();
            this.btnConnectTest1 = new System.Windows.Forms.Button();
            this.txtPasswd = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.txtUserID = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.txtUrl = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn开始下载 = new System.Windows.Forms.Button();
            this.chk自动上传 = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblStudentMsg = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn上传检录信息 = new System.Windows.Forms.Button();
            this.p上传检录信息 = new LJH.GeneralLibrary.WinformControl.PercentageProgressBar(this.components);
            this.gpDB.SuspendLayout();
            this.SuspendLayout();
            // 
            // pStudent
            // 
            this.pStudent.Location = new System.Drawing.Point(77, 171);
            this.pStudent.Name = "pStudent";
            this.pStudent.Size = new System.Drawing.Size(307, 38);
            this.pStudent.TabIndex = 5;
            this.pStudent.TextColor = System.Drawing.Color.Black;
            this.pStudent.TextFont = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // pScore
            // 
            this.pScore.Location = new System.Drawing.Point(77, 239);
            this.pScore.Name = "pScore";
            this.pScore.Size = new System.Drawing.Size(307, 38);
            this.pScore.TabIndex = 6;
            this.pScore.TextColor = System.Drawing.Color.Black;
            this.pScore.TextFont = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(403, 239);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(62, 38);
            this.btnUpload.TabIndex = 8;
            this.btnUpload.Text = "开始上传";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // gpDB
            // 
            this.gpDB.Controls.Add(this.btnConnectTest1);
            this.gpDB.Controls.Add(this.txtPasswd);
            this.gpDB.Controls.Add(this.txtUserID);
            this.gpDB.Controls.Add(this.txtUrl);
            this.gpDB.Controls.Add(this.label6);
            this.gpDB.Controls.Add(this.label4);
            this.gpDB.Controls.Add(this.label3);
            this.gpDB.Location = new System.Drawing.Point(7, 9);
            this.gpDB.Name = "gpDB";
            this.gpDB.Size = new System.Drawing.Size(465, 132);
            this.gpDB.TabIndex = 9;
            this.gpDB.TabStop = false;
            this.gpDB.Text = "数据库设置";
            // 
            // btnConnectTest1
            // 
            this.btnConnectTest1.Location = new System.Drawing.Point(388, 71);
            this.btnConnectTest1.Name = "btnConnectTest1";
            this.btnConnectTest1.Size = new System.Drawing.Size(62, 48);
            this.btnConnectTest1.TabIndex = 7;
            this.btnConnectTest1.Text = "保存参数";
            this.btnConnectTest1.UseVisualStyleBackColor = true;
            this.btnConnectTest1.Click += new System.EventHandler(this.btnConnectTest1_Click);
            // 
            // txtPasswd
            // 
            this.txtPasswd.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtPasswd.Location = new System.Drawing.Point(261, 75);
            this.txtPasswd.Name = "txtPasswd";
            this.txtPasswd.PasswordChar = '*';
            this.txtPasswd.Size = new System.Drawing.Size(109, 21);
            this.txtPasswd.TabIndex = 5;
            // 
            // txtUserID
            // 
            this.txtUserID.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtUserID.Location = new System.Drawing.Point(75, 75);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(132, 21);
            this.txtUserID.TabIndex = 4;
            // 
            // txtUrl
            // 
            this.txtUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUrl.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtUrl.Location = new System.Drawing.Point(76, 31);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(378, 21);
            this.txtUrl.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(225, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "密码";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "用户名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "服务器";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "学生信息";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "学生成绩";
            // 
            // btn开始下载
            // 
            this.btn开始下载.Location = new System.Drawing.Point(402, 171);
            this.btn开始下载.Name = "btn开始下载";
            this.btn开始下载.Size = new System.Drawing.Size(62, 38);
            this.btn开始下载.TabIndex = 12;
            this.btn开始下载.Text = "开始下载";
            this.btn开始下载.UseVisualStyleBackColor = true;
            this.btn开始下载.Click += new System.EventHandler(this.btn开始下载_Click);
            // 
            // chk自动上传
            // 
            this.chk自动上传.AutoSize = true;
            this.chk自动上传.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chk自动上传.ForeColor = System.Drawing.Color.Red;
            this.chk自动上传.Location = new System.Drawing.Point(349, 361);
            this.chk自动上传.Name = "chk自动上传";
            this.chk自动上传.Size = new System.Drawing.Size(112, 24);
            this.chk自动上传.TabIndex = 13;
            this.chk自动上传.Text = "自动上传";
            this.chk自动上传.UseVisualStyleBackColor = true;
            this.chk自动上传.CheckedChanged += new System.EventHandler(this.chk自动上传_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 20000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblStudentMsg
            // 
            this.lblStudentMsg.AutoSize = true;
            this.lblStudentMsg.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblStudentMsg.ForeColor = System.Drawing.Color.Blue;
            this.lblStudentMsg.Location = new System.Drawing.Point(69, 216);
            this.lblStudentMsg.Name = "lblStudentMsg";
            this.lblStudentMsg.Size = new System.Drawing.Size(0, 12);
            this.lblStudentMsg.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 17;
            this.label7.Text = "检录信息";
            // 
            // btn上传检录信息
            // 
            this.btn上传检录信息.Location = new System.Drawing.Point(403, 300);
            this.btn上传检录信息.Name = "btn上传检录信息";
            this.btn上传检录信息.Size = new System.Drawing.Size(62, 38);
            this.btn上传检录信息.TabIndex = 16;
            this.btn上传检录信息.Text = "开始上传";
            this.btn上传检录信息.UseVisualStyleBackColor = true;
            this.btn上传检录信息.Click += new System.EventHandler(this.btn上传检录信息_Click);
            // 
            // p上传检录信息
            // 
            this.p上传检录信息.Location = new System.Drawing.Point(77, 300);
            this.p上传检录信息.Name = "p上传检录信息";
            this.p上传检录信息.Size = new System.Drawing.Size(307, 38);
            this.p上传检录信息.TabIndex = 15;
            this.p上传检录信息.TextColor = System.Drawing.Color.Black;
            this.p上传检录信息.TextFont = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // Frm中山中考数据接口
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 402);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn上传检录信息);
            this.Controls.Add(this.p上传检录信息);
            this.Controls.Add(this.lblStudentMsg);
            this.Controls.Add(this.chk自动上传);
            this.Controls.Add(this.btn开始下载);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gpDB);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.pScore);
            this.Controls.Add(this.pStudent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Frm中山中考数据接口";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "第三方接口";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmHuihaiCloud_FormClosing);
            this.Load += new System.EventHandler(this.FrmHuihaiCloud_Load);
            this.gpDB.ResumeLayout(false);
            this.gpDB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LJH.GeneralLibrary.WinformControl.PercentageProgressBar pStudent;
        private LJH.GeneralLibrary.WinformControl.PercentageProgressBar pScore;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.GroupBox gpDB;
        private System.Windows.Forms.Button btnConnectTest1;
        private LJH.GeneralLibrary.WinformControl.DBCTextBox txtPasswd;
        private LJH.GeneralLibrary.WinformControl.DBCTextBox txtUserID;
        private LJH.GeneralLibrary.WinformControl.DBCTextBox txtUrl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn开始下载;
        private System.Windows.Forms.CheckBox chk自动上传;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblStudentMsg;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn上传检录信息;
        private LJH.GeneralLibrary.WinformControl.PercentageProgressBar p上传检录信息;
    }
}