namespace HH.ZK.UI
{
    partial class FrmOption_检录
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
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBarcodeReader = new LJH.GeneralLibrary.WinformControl.ComPortComboBox(this.components);
            this.chk启用二代身份证阅读器 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbICCardReader = new LJH.GeneralLibrary.WinformControl.ComPortComboBox(this.components);
            this.chkAutoWriteCard = new System.Windows.Forms.CheckBox();
            this.chkEnableTTS = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rd按分组进行检录 = new System.Windows.Forms.RadioButton();
            this.rd现场分组检录 = new System.Windows.Forms.RadioButton();
            this.rd随机检录 = new System.Windows.Forms.RadioButton();
            this.chk扫码后自动通过检录 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(153, 255);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(119, 34);
            this.btnOk.TabIndex = 85;
            this.btnOk.Text = "确定(&O)";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(299, 255);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(119, 34);
            this.btnCancel.TabIndex = 86;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 88;
            this.label1.Text = "人脸识别平板串口";
            // 
            // cmbBarcodeReader
            // 
            this.cmbBarcodeReader.FormattingEnabled = true;
            this.cmbBarcodeReader.Location = new System.Drawing.Point(119, 50);
            this.cmbBarcodeReader.Name = "cmbBarcodeReader";
            this.cmbBarcodeReader.Size = new System.Drawing.Size(132, 20);
            this.cmbBarcodeReader.TabIndex = 87;
            // 
            // chk启用二代身份证阅读器
            // 
            this.chk启用二代身份证阅读器.AutoSize = true;
            this.chk启用二代身份证阅读器.Location = new System.Drawing.Point(119, 87);
            this.chk启用二代身份证阅读器.Name = "chk启用二代身份证阅读器";
            this.chk启用二代身份证阅读器.Size = new System.Drawing.Size(144, 16);
            this.chk启用二代身份证阅读器.TabIndex = 99;
            this.chk启用二代身份证阅读器.Text = "启用二代身份证阅读器";
            this.chk启用二代身份证阅读器.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 139;
            this.label4.Text = "IC卡读卡器串口";
            // 
            // cmbICCardReader
            // 
            this.cmbICCardReader.FormattingEnabled = true;
            this.cmbICCardReader.Location = new System.Drawing.Point(119, 19);
            this.cmbICCardReader.Name = "cmbICCardReader";
            this.cmbICCardReader.Size = new System.Drawing.Size(132, 20);
            this.cmbICCardReader.TabIndex = 138;
            // 
            // chkAutoWriteCard
            // 
            this.chkAutoWriteCard.AutoSize = true;
            this.chkAutoWriteCard.Checked = true;
            this.chkAutoWriteCard.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAutoWriteCard.Location = new System.Drawing.Point(119, 118);
            this.chkAutoWriteCard.Name = "chkAutoWriteCard";
            this.chkAutoWriteCard.Size = new System.Drawing.Size(132, 16);
            this.chkAutoWriteCard.TabIndex = 141;
            this.chkAutoWriteCard.Text = "检录时自动提示发卡";
            this.chkAutoWriteCard.UseVisualStyleBackColor = true;
            // 
            // chkEnableTTS
            // 
            this.chkEnableTTS.AutoSize = true;
            this.chkEnableTTS.Location = new System.Drawing.Point(119, 147);
            this.chkEnableTTS.Name = "chkEnableTTS";
            this.chkEnableTTS.Size = new System.Drawing.Size(96, 16);
            this.chkEnableTTS.TabIndex = 174;
            this.chkEnableTTS.Text = "启用语音提示";
            this.chkEnableTTS.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 176;
            this.label2.Text = "检录方式";
            // 
            // rd按分组进行检录
            // 
            this.rd按分组进行检录.AutoSize = true;
            this.rd按分组进行检录.Checked = true;
            this.rd按分组进行检录.Location = new System.Drawing.Point(119, 211);
            this.rd按分组进行检录.Name = "rd按分组进行检录";
            this.rd按分组进行检录.Size = new System.Drawing.Size(107, 16);
            this.rd按分组进行检录.TabIndex = 177;
            this.rd按分组进行检录.TabStop = true;
            this.rd按分组进行检录.Text = "按分组进行检录";
            this.rd按分组进行检录.UseVisualStyleBackColor = true;
            // 
            // rd现场分组检录
            // 
            this.rd现场分组检录.AutoSize = true;
            this.rd现场分组检录.Location = new System.Drawing.Point(239, 211);
            this.rd现场分组检录.Name = "rd现场分组检录";
            this.rd现场分组检录.Size = new System.Drawing.Size(95, 16);
            this.rd现场分组检录.TabIndex = 178;
            this.rd现场分组检录.Text = "现场分组检录";
            this.rd现场分组检录.UseVisualStyleBackColor = true;
            // 
            // rd随机检录
            // 
            this.rd随机检录.AutoSize = true;
            this.rd随机检录.Location = new System.Drawing.Point(350, 211);
            this.rd随机检录.Name = "rd随机检录";
            this.rd随机检录.Size = new System.Drawing.Size(71, 16);
            this.rd随机检录.TabIndex = 179;
            this.rd随机检录.Text = "随机检录";
            this.rd随机检录.UseVisualStyleBackColor = true;
            // 
            // chk扫码后自动通过检录
            // 
            this.chk扫码后自动通过检录.AutoSize = true;
            this.chk扫码后自动通过检录.Location = new System.Drawing.Point(119, 177);
            this.chk扫码后自动通过检录.Name = "chk扫码后自动通过检录";
            this.chk扫码后自动通过检录.Size = new System.Drawing.Size(132, 16);
            this.chk扫码后自动通过检录.TabIndex = 180;
            this.chk扫码后自动通过检录.Text = "扫码后自动通过检录";
            this.chk扫码后自动通过检录.UseVisualStyleBackColor = true;
            // 
            // FrmOption_检录
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(438, 313);
            this.Controls.Add(this.chk扫码后自动通过检录);
            this.Controls.Add(this.rd随机检录);
            this.Controls.Add(this.rd现场分组检录);
            this.Controls.Add(this.rd按分组进行检录);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkEnableTTS);
            this.Controls.Add(this.chkAutoWriteCard);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbICCardReader);
            this.Controls.Add(this.chk启用二代身份证阅读器);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBarcodeReader);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Name = "FrmOption_检录";
            this.Text = "系统选项";
            this.Load += new System.EventHandler(this.FrmOption_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private LJH.GeneralLibrary.WinformControl.ComPortComboBox cmbBarcodeReader;
        private System.Windows.Forms.CheckBox chk启用二代身份证阅读器;
        private System.Windows.Forms.Label label4;
        private LJH.GeneralLibrary.WinformControl.ComPortComboBox cmbICCardReader;
        private System.Windows.Forms.CheckBox chkAutoWriteCard;
        private System.Windows.Forms.CheckBox chkEnableTTS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rd按分组进行检录;
        private System.Windows.Forms.RadioButton rd现场分组检录;
        private System.Windows.Forms.RadioButton rd随机检录;
        private System.Windows.Forms.CheckBox chk扫码后自动通过检录;
    }
}