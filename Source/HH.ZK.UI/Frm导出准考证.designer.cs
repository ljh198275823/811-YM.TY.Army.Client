namespace HH.ZK.UI
{
    partial class Frm导出准考证
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm导出准考证));
            this.progressBar1 = new LJH.GeneralLibrary.WinformControl.PercentageProgressBar(this.components);
            this.btn导出 = new System.Windows.Forms.Button();
            this.lblMsg = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt排版 = new System.Windows.Forms.ComboBox();
            this.chk打印序号 = new System.Windows.Forms.CheckBox();
            this.rd导成一个文件 = new System.Windows.Forms.RadioButton();
            this.btnFileBrowser = new System.Windows.Forms.Button();
            this.txtFile = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.btnOpenDir = new System.Windows.Forms.Button();
            this.txtFolder = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.rd导出到多个文件 = new System.Windows.Forms.RadioButton();
            this.chk分学校 = new System.Windows.Forms.CheckBox();
            this.chk分性别 = new System.Windows.Forms.CheckBox();
            this.txtError = new System.Windows.Forms.RichTextBox();
            this.chk分班级 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(29, 248);
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
            this.btn导出.Location = new System.Drawing.Point(424, 248);
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
            this.lblMsg.Location = new System.Drawing.Point(29, 316);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(71, 12);
            this.lblMsg.TabIndex = 166;
            this.lblMsg.Text = "正在运行...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 167;
            this.label1.Text = "准考证排版";
            // 
            // txt排版
            // 
            this.txt排版.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt排版.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt排版.FormattingEnabled = true;
            this.txt排版.Items.AddRange(new object[] {
            "默认--每页8个准考证",
            "卡片--每页15个准考证",
            "紧凑--每页21个准考证",
            "较大--每页4个准考证",
            "较大--每页6个准考证",
            "较大--每页2个登分卡"});
            this.txt排版.Location = new System.Drawing.Point(93, 20);
            this.txt排版.Name = "txt排版";
            this.txt排版.Size = new System.Drawing.Size(274, 28);
            this.txt排版.TabIndex = 168;
            // 
            // chk打印序号
            // 
            this.chk打印序号.AutoSize = true;
            this.chk打印序号.Checked = true;
            this.chk打印序号.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk打印序号.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chk打印序号.ForeColor = System.Drawing.Color.Red;
            this.chk打印序号.Location = new System.Drawing.Point(414, 27);
            this.chk打印序号.Name = "chk打印序号";
            this.chk打印序号.Size = new System.Drawing.Size(76, 16);
            this.chk打印序号.TabIndex = 169;
            this.chk打印序号.Text = "打印序号";
            this.chk打印序号.UseVisualStyleBackColor = true;
            // 
            // rd导成一个文件
            // 
            this.rd导成一个文件.AutoSize = true;
            this.rd导成一个文件.Location = new System.Drawing.Point(29, 67);
            this.rd导成一个文件.Name = "rd导成一个文件";
            this.rd导成一个文件.Size = new System.Drawing.Size(83, 16);
            this.rd导成一个文件.TabIndex = 170;
            this.rd导成一个文件.TabStop = true;
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
            this.btnOpenDir.Location = new System.Drawing.Point(477, 201);
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
            this.txtFolder.Location = new System.Drawing.Point(29, 201);
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
            this.rd导出到多个文件.TabStop = true;
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
            this.chk分学校.Location = new System.Drawing.Point(40, 174);
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
            this.chk分性别.Location = new System.Drawing.Point(325, 174);
            this.chk分性别.Name = "chk分性别";
            this.chk分性别.Size = new System.Drawing.Size(60, 16);
            this.chk分性别.TabIndex = 177;
            this.chk分性别.Text = "分男女";
            this.chk分性别.UseVisualStyleBackColor = true;
            // 
            // txtError
            // 
            this.txtError.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtError.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtError.Location = new System.Drawing.Point(31, 335);
            this.txtError.Name = "txtError";
            this.txtError.Size = new System.Drawing.Size(525, 236);
            this.txtError.TabIndex = 180;
            this.txtError.Text = "";
            // 
            // chk分班级
            // 
            this.chk分班级.AutoSize = true;
            this.chk分班级.Checked = true;
            this.chk分班级.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk分班级.Enabled = false;
            this.chk分班级.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chk分班级.Location = new System.Drawing.Point(388, 174);
            this.chk分班级.Name = "chk分班级";
            this.chk分班级.Size = new System.Drawing.Size(60, 16);
            this.chk分班级.TabIndex = 181;
            this.chk分班级.Text = "分班级";
            this.chk分班级.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 182;
            this.label2.Text = "文件生成";
            // 
            // Frm导出准考证
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 579);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chk分班级);
            this.Controls.Add(this.txtError);
            this.Controls.Add(this.chk分学校);
            this.Controls.Add(this.chk分性别);
            this.Controls.Add(this.btnOpenDir);
            this.Controls.Add(this.txtFolder);
            this.Controls.Add(this.rd导出到多个文件);
            this.Controls.Add(this.btnFileBrowser);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.rd导成一个文件);
            this.Controls.Add(this.chk打印序号);
            this.Controls.Add(this.txt排版);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btn导出);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm导出准考证";
            this.Text = "导出准考证";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm按组导出准考证_FormClosed);
            this.Load += new System.EventHandler(this.Frm按组导出准考证_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LJH.GeneralLibrary.WinformControl.PercentageProgressBar progressBar1;
        private System.Windows.Forms.Button btn导出;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txt排版;
        private System.Windows.Forms.CheckBox chk打印序号;
        private System.Windows.Forms.RadioButton rd导成一个文件;
        private System.Windows.Forms.Button btnFileBrowser;
        private LJH.GeneralLibrary.WinformControl.DBCTextBox txtFile;
        private System.Windows.Forms.Button btnOpenDir;
        private LJH.GeneralLibrary.WinformControl.DBCTextBox txtFolder;
        private System.Windows.Forms.RadioButton rd导出到多个文件;
        private System.Windows.Forms.CheckBox chk分学校;
        private System.Windows.Forms.CheckBox chk分性别;
        private System.Windows.Forms.RichTextBox txtError;
        private System.Windows.Forms.CheckBox chk分班级;
        private System.Windows.Forms.Label label2;
    }
}