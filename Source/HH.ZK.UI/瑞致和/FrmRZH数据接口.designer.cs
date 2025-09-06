namespace HH.ZK.UI.瑞致和
{
    partial class FrmRZH数据接口
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
            this.txt考点 = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.txtUrl = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn开始下载 = new System.Windows.Forms.Button();
            this.chk自动上传 = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtSchool = new System.Windows.Forms.ComboBox();
            this.btn获取学校信息 = new System.Windows.Forms.Button();
            this.txtDivision = new System.Windows.Forms.ComboBox();
            this.txtMsg = new System.Windows.Forms.RichTextBox();
            this.chk照片 = new System.Windows.Forms.CheckBox();
            this.gpDB.SuspendLayout();
            this.SuspendLayout();
            // 
            // pStudent
            // 
            this.pStudent.Location = new System.Drawing.Point(70, 218);
            this.pStudent.Name = "pStudent";
            this.pStudent.Size = new System.Drawing.Size(309, 38);
            this.pStudent.TabIndex = 5;
            this.pStudent.TextColor = System.Drawing.Color.Black;
            this.pStudent.TextFont = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // pScore
            // 
            this.pScore.Location = new System.Drawing.Point(70, 276);
            this.pScore.Name = "pScore";
            this.pScore.Size = new System.Drawing.Size(309, 38);
            this.pScore.TabIndex = 6;
            this.pScore.TextColor = System.Drawing.Color.Black;
            this.pScore.TextFont = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(396, 276);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(62, 38);
            this.btnUpload.TabIndex = 8;
            this.btnUpload.Text = "开始上传";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // gpDB
            // 
            this.gpDB.Controls.Add(this.txt考点);
            this.gpDB.Controls.Add(this.txtUrl);
            this.gpDB.Controls.Add(this.label5);
            this.gpDB.Controls.Add(this.label3);
            this.gpDB.Location = new System.Drawing.Point(7, 9);
            this.gpDB.Name = "gpDB";
            this.gpDB.Size = new System.Drawing.Size(539, 109);
            this.gpDB.TabIndex = 9;
            this.gpDB.TabStop = false;
            this.gpDB.Text = "数据库设置";
            // 
            // txt考点
            // 
            this.txt考点.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txt考点.Location = new System.Drawing.Point(76, 69);
            this.txt考点.Name = "txt考点";
            this.txt考点.Size = new System.Drawing.Size(150, 21);
            this.txt考点.TabIndex = 3;
            // 
            // txtUrl
            // 
            this.txtUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUrl.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtUrl.Location = new System.Drawing.Point(76, 31);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(452, 21);
            this.txtUrl.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "考点代码";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 18;
            this.label4.Text = "学校代码";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "学生信息";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "学生成绩";
            // 
            // btn开始下载
            // 
            this.btn开始下载.Location = new System.Drawing.Point(396, 218);
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
            this.chk自动上传.Location = new System.Drawing.Point(466, 287);
            this.chk自动上传.Name = "chk自动上传";
            this.chk自动上传.Size = new System.Drawing.Size(72, 16);
            this.chk自动上传.TabIndex = 13;
            this.chk自动上传.Text = "自动上传";
            this.chk自动上传.UseVisualStyleBackColor = true;
            this.chk自动上传.CheckedChanged += new System.EventHandler(this.chk自动上传_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtSchool
            // 
            this.txtSchool.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtSchool.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSchool.FormattingEnabled = true;
            this.txtSchool.Location = new System.Drawing.Point(70, 173);
            this.txtSchool.Name = "txtSchool";
            this.txtSchool.Size = new System.Drawing.Size(300, 28);
            this.txtSchool.TabIndex = 19;
            // 
            // btn获取学校信息
            // 
            this.btn获取学校信息.Location = new System.Drawing.Point(396, 149);
            this.btn获取学校信息.Name = "btn获取学校信息";
            this.btn获取学校信息.Size = new System.Drawing.Size(62, 38);
            this.btn获取学校信息.TabIndex = 20;
            this.btn获取学校信息.Text = "获取学校";
            this.btn获取学校信息.UseVisualStyleBackColor = true;
            this.btn获取学校信息.Click += new System.EventHandler(this.btn获取学校信息_Click);
            // 
            // txtDivision
            // 
            this.txtDivision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtDivision.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDivision.FormattingEnabled = true;
            this.txtDivision.Location = new System.Drawing.Point(70, 134);
            this.txtDivision.Name = "txtDivision";
            this.txtDivision.Size = new System.Drawing.Size(300, 28);
            this.txtDivision.TabIndex = 21;
            this.txtDivision.SelectedIndexChanged += new System.EventHandler(this.txtDivision_SelectedIndexChanged);
            // 
            // txtMsg
            // 
            this.txtMsg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMsg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMsg.HideSelection = false;
            this.txtMsg.Location = new System.Drawing.Point(565, 12);
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(445, 385);
            this.txtMsg.TabIndex = 22;
            this.txtMsg.Text = "";
            // 
            // chk照片
            // 
            this.chk照片.AutoSize = true;
            this.chk照片.Location = new System.Drawing.Point(466, 229);
            this.chk照片.Name = "chk照片";
            this.chk照片.Size = new System.Drawing.Size(72, 16);
            this.chk照片.TabIndex = 23;
            this.chk照片.Text = "下载照片";
            this.chk照片.UseVisualStyleBackColor = true;
            // 
            // FrmRZH数据接口
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 399);
            this.Controls.Add(this.chk照片);
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.txtDivision);
            this.Controls.Add(this.btn获取学校信息);
            this.Controls.Add(this.txtSchool);
            this.Controls.Add(this.label4);
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
            this.Name = "FrmRZH数据接口";
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
        private LJH.GeneralLibrary.WinformControl.DBCTextBox txtUrl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn开始下载;
        private LJH.GeneralLibrary.WinformControl.DBCTextBox txt考点;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chk自动上传;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox txtSchool;
        private System.Windows.Forms.Button btn获取学校信息;
        private System.Windows.Forms.ComboBox txtDivision;
        private System.Windows.Forms.RichTextBox txtMsg;
        private System.Windows.Forms.CheckBox chk照片;
    }
}