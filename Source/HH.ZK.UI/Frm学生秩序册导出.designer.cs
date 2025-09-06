namespace HH.ZK.UI
{
    partial class Frm学生秩序册导出
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm学生秩序册导出));
            this.progressBar1 = new LJH.GeneralLibrary.WinformControl.PercentageProgressBar(this.components);
            this.btn导出 = new System.Windows.Forms.Button();
            this.lblMsg = new System.Windows.Forms.Label();
            this.rd导成一个文件 = new System.Windows.Forms.RadioButton();
            this.btnFileBrowser = new System.Windows.Forms.Button();
            this.txtFile = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.btnOpenDir = new System.Windows.Forms.Button();
            this.txtFolder = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.rd导出到多个文件 = new System.Windows.Forms.RadioButton();
            this.chk分学校 = new System.Windows.Forms.CheckBox();
            this.chk分性别 = new System.Windows.Forms.CheckBox();
            this.txtError = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rd秩序册1 = new System.Windows.Forms.RadioButton();
            this.rd秩序册2 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rd秩序册3 = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(29, 226);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(383, 51);
            this.progressBar1.TabIndex = 165;
            this.progressBar1.TextColor = System.Drawing.Color.Black;
            this.progressBar1.TextFont = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // btn导出
            // 
            this.btn导出.BackColor = System.Drawing.Color.Blue;
            this.btn导出.ForeColor = System.Drawing.Color.White;
            this.btn导出.Location = new System.Drawing.Point(424, 226);
            this.btn导出.Name = "btn导出";
            this.btn导出.Size = new System.Drawing.Size(158, 51);
            this.btn导出.TabIndex = 164;
            this.btn导出.Text = "开始导出";
            this.btn导出.UseVisualStyleBackColor = false;
            this.btn导出.Click += new System.EventHandler(this.btn导出_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(29, 294);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(71, 12);
            this.lblMsg.TabIndex = 166;
            this.lblMsg.Text = "正在运行...";
            // 
            // rd导成一个文件
            // 
            this.rd导成一个文件.AutoSize = true;
            this.rd导成一个文件.Location = new System.Drawing.Point(29, 67);
            this.rd导成一个文件.Name = "rd导成一个文件";
            this.rd导成一个文件.Size = new System.Drawing.Size(83, 16);
            this.rd导成一个文件.TabIndex = 170;
            this.rd导成一个文件.Text = "导出到文件";
            this.rd导成一个文件.UseVisualStyleBackColor = true;
            this.rd导成一个文件.CheckedChanged += new System.EventHandler(this.rd导成一个文件_CheckedChanged);
            // 
            // btnFileBrowser
            // 
            this.btnFileBrowser.Enabled = false;
            this.btnFileBrowser.Location = new System.Drawing.Point(477, 89);
            this.btnFileBrowser.Name = "btnFileBrowser";
            this.btnFileBrowser.Size = new System.Drawing.Size(79, 36);
            this.btnFileBrowser.TabIndex = 173;
            this.btnFileBrowser.Text = "选择文件";
            this.btnFileBrowser.UseVisualStyleBackColor = true;
            this.btnFileBrowser.Click += new System.EventHandler(this.btnFileBrowser_Click);
            // 
            // txtFile
            // 
            this.txtFile.Enabled = false;
            this.txtFile.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtFile.Location = new System.Drawing.Point(29, 89);
            this.txtFile.Multiline = true;
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(435, 36);
            this.txtFile.TabIndex = 172;
            // 
            // btnOpenDir
            // 
            this.btnOpenDir.Enabled = false;
            this.btnOpenDir.Location = new System.Drawing.Point(477, 165);
            this.btnOpenDir.Name = "btnOpenDir";
            this.btnOpenDir.Size = new System.Drawing.Size(79, 36);
            this.btnOpenDir.TabIndex = 176;
            this.btnOpenDir.Text = "选择文件夹";
            this.btnOpenDir.UseVisualStyleBackColor = true;
            this.btnOpenDir.Click += new System.EventHandler(this.btnOpenDir_Click);
            // 
            // txtFolder
            // 
            this.txtFolder.Enabled = false;
            this.txtFolder.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtFolder.Location = new System.Drawing.Point(29, 165);
            this.txtFolder.Multiline = true;
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.Size = new System.Drawing.Size(435, 36);
            this.txtFolder.TabIndex = 175;
            // 
            // rd导出到多个文件
            // 
            this.rd导出到多个文件.AutoSize = true;
            this.rd导出到多个文件.Location = new System.Drawing.Point(29, 143);
            this.rd导出到多个文件.Name = "rd导出到多个文件";
            this.rd导出到多个文件.Size = new System.Drawing.Size(95, 16);
            this.rd导出到多个文件.TabIndex = 174;
            this.rd导出到多个文件.Text = "导出到文件夹";
            this.rd导出到多个文件.UseVisualStyleBackColor = true;
            this.rd导出到多个文件.CheckedChanged += new System.EventHandler(this.rd导出到多个文件_CheckedChanged);
            // 
            // chk分学校
            // 
            this.chk分学校.AutoSize = true;
            this.chk分学校.Checked = true;
            this.chk分学校.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk分学校.Enabled = false;
            this.chk分学校.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chk分学校.Location = new System.Drawing.Point(145, 143);
            this.chk分学校.Name = "chk分学校";
            this.chk分学校.Size = new System.Drawing.Size(180, 16);
            this.chk分学校.TabIndex = 178;
            this.chk分学校.Text = "每个学校单独生成一个文件夹";
            this.chk分学校.UseVisualStyleBackColor = true;
            // 
            // chk分性别
            // 
            this.chk分性别.AutoSize = true;
            this.chk分性别.Checked = true;
            this.chk分性别.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk分性别.Enabled = false;
            this.chk分性别.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chk分性别.Location = new System.Drawing.Point(341, 143);
            this.chk分性别.Name = "chk分性别";
            this.chk分性别.Size = new System.Drawing.Size(144, 16);
            this.chk分性别.TabIndex = 177;
            this.chk分性别.Text = "男女学生分开文件保存";
            this.chk分性别.UseVisualStyleBackColor = true;
            // 
            // txtError
            // 
            this.txtError.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtError.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtError.Location = new System.Drawing.Point(31, 313);
            this.txtError.Name = "txtError";
            this.txtError.Size = new System.Drawing.Size(429, 262);
            this.txtError.TabIndex = 180;
            this.txtError.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 167;
            this.label1.Text = "秩序册模板";
            // 
            // rd秩序册1
            // 
            this.rd秩序册1.AutoSize = true;
            this.rd秩序册1.Checked = true;
            this.rd秩序册1.Location = new System.Drawing.Point(8, 7);
            this.rd秩序册1.Name = "rd秩序册1";
            this.rd秩序册1.Size = new System.Drawing.Size(89, 16);
            this.rd秩序册1.TabIndex = 181;
            this.rd秩序册1.TabStop = true;
            this.rd秩序册1.Text = "秩序册模板1";
            this.rd秩序册1.UseVisualStyleBackColor = true;
            // 
            // rd秩序册2
            // 
            this.rd秩序册2.AutoSize = true;
            this.rd秩序册2.Location = new System.Drawing.Point(124, 7);
            this.rd秩序册2.Name = "rd秩序册2";
            this.rd秩序册2.Size = new System.Drawing.Size(89, 16);
            this.rd秩序册2.TabIndex = 182;
            this.rd秩序册2.Text = "秩序册模板2";
            this.rd秩序册2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rd秩序册3);
            this.panel1.Controls.Add(this.rd秩序册2);
            this.panel1.Controls.Add(this.rd秩序册1);
            this.panel1.Location = new System.Drawing.Point(100, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 29);
            this.panel1.TabIndex = 183;
            // 
            // rd秩序册3
            // 
            this.rd秩序册3.AutoSize = true;
            this.rd秩序册3.Location = new System.Drawing.Point(245, 7);
            this.rd秩序册3.Name = "rd秩序册3";
            this.rd秩序册3.Size = new System.Drawing.Size(89, 16);
            this.rd秩序册3.TabIndex = 183;
            this.rd秩序册3.Text = "秩序册模板3";
            this.rd秩序册3.UseVisualStyleBackColor = true;
            // 
            // Frm学生秩序册导出
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 579);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtError);
            this.Controls.Add(this.chk分学校);
            this.Controls.Add(this.chk分性别);
            this.Controls.Add(this.btnOpenDir);
            this.Controls.Add(this.txtFolder);
            this.Controls.Add(this.rd导出到多个文件);
            this.Controls.Add(this.btnFileBrowser);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.rd导成一个文件);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btn导出);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm学生秩序册导出";
            this.Text = "导出秩序册";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm按组导出准考证_FormClosed);
            this.Load += new System.EventHandler(this.Frm按组导出准考证_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LJH.GeneralLibrary.WinformControl.PercentageProgressBar progressBar1;
        private System.Windows.Forms.Button btn导出;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.RadioButton rd导成一个文件;
        private System.Windows.Forms.Button btnFileBrowser;
        private LJH.GeneralLibrary.WinformControl.DBCTextBox txtFile;
        private System.Windows.Forms.Button btnOpenDir;
        private LJH.GeneralLibrary.WinformControl.DBCTextBox txtFolder;
        private System.Windows.Forms.RadioButton rd导出到多个文件;
        private System.Windows.Forms.CheckBox chk分学校;
        private System.Windows.Forms.CheckBox chk分性别;
        private System.Windows.Forms.RichTextBox txtError;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rd秩序册1;
        private System.Windows.Forms.RadioButton rd秩序册2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rd秩序册3;
    }
}