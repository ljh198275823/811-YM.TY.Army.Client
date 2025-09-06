namespace HH.ZK.UI
{
    partial class Frm学生成绩导出模板设置
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTemplateRow = new LJH.GeneralLibrary.WinformControl.IntergerTextBox(this.components);
            this.btnModalBrowser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtModelFile = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(385, 169);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(119, 58);
            this.btnCancel.TabIndex = 88;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(239, 169);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(119, 58);
            this.btnOk.TabIndex = 87;
            this.btnOk.Text = "确定(&O)";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 12);
            this.label2.TabIndex = 173;
            this.label2.Text = "从第几行开始填充";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTemplateRow
            // 
            this.txtTemplateRow.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTemplateRow.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtTemplateRow.Location = new System.Drawing.Point(138, 130);
            this.txtTemplateRow.MaxValue = 30;
            this.txtTemplateRow.MinValue = 1;
            this.txtTemplateRow.Name = "txtTemplateRow";
            this.txtTemplateRow.Size = new System.Drawing.Size(53, 26);
            this.txtTemplateRow.TabIndex = 172;
            this.txtTemplateRow.Text = "2";
            // 
            // btnModalBrowser
            // 
            this.btnModalBrowser.Location = new System.Drawing.Point(453, 42);
            this.btnModalBrowser.Name = "btnModalBrowser";
            this.btnModalBrowser.Size = new System.Drawing.Size(51, 77);
            this.btnModalBrowser.TabIndex = 171;
            this.btnModalBrowser.Text = "...";
            this.btnModalBrowser.UseVisualStyleBackColor = true;
            this.btnModalBrowser.Click += new System.EventHandler(this.btnModalBrowser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 169;
            this.label1.Text = "导出模板";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtModelFile
            // 
            this.txtModelFile.Enabled = false;
            this.txtModelFile.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtModelFile.Location = new System.Drawing.Point(12, 42);
            this.txtModelFile.Multiline = true;
            this.txtModelFile.Name = "txtModelFile";
            this.txtModelFile.Size = new System.Drawing.Size(435, 77);
            this.txtModelFile.TabIndex = 170;
            // 
            // Frm学生成绩导出模板设置
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 239);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTemplateRow);
            this.Controls.Add(this.btnModalBrowser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtModelFile);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Name = "Frm学生成绩导出模板设置";
            this.Text = "学生成绩导出模板设置";
            this.Load += new System.EventHandler(this.Frm学生成绩导出模板设置_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label2;
        private LJH.GeneralLibrary.WinformControl.IntergerTextBox txtTemplateRow;
        private System.Windows.Forms.Button btnModalBrowser;
        private System.Windows.Forms.Label label1;
        private LJH.GeneralLibrary.WinformControl.DBCTextBox txtModelFile;
    }
}