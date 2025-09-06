namespace HH.ZK.UI.宁波中考
{
    partial class Frm宁波中考数据接口
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
            this.txtUrl = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn开始下载 = new System.Windows.Forms.Button();
            this.chk自动上传 = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblStudentMsg = new System.Windows.Forms.Label();
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
            this.gpDB.Controls.Add(this.txtUrl);
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
            this.btnConnectTest1.Location = new System.Drawing.Point(346, 71);
            this.btnConnectTest1.Name = "btnConnectTest1";
            this.btnConnectTest1.Size = new System.Drawing.Size(104, 48);
            this.btnConnectTest1.TabIndex = 7;
            this.btnConnectTest1.Text = "保存参数";
            this.btnConnectTest1.UseVisualStyleBackColor = true;
            this.btnConnectTest1.Click += new System.EventHandler(this.btnConnectTest1_Click);
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
            this.chk自动上传.Location = new System.Drawing.Point(353, 306);
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
            // Frm宁波中考数据接口
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 352);
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
            this.Name = "Frm宁波中考数据接口";
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
        private LJH.GeneralLibrary.WinformControl.DBCTextBox txtUrl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn开始下载;
        private System.Windows.Forms.CheckBox chk自动上传;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblStudentMsg;
    }
}