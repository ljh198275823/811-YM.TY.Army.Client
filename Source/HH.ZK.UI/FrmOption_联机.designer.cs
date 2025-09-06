namespace HH.ZK.UI
{
    partial class FrmOption_联机
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
            this.cmbBarCodeReader = new LJH.GeneralLibrary.WinformControl.ComPortComboBox(this.components);
            this.chk启用二代身份证阅读器 = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbICCardReader = new LJH.GeneralLibrary.WinformControl.ComPortComboBox(this.components);
            this.chkEnableTTS = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(207, 266);
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
            this.btnCancel.Location = new System.Drawing.Point(353, 266);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(119, 34);
            this.btnCancel.TabIndex = 86;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 12);
            this.label1.TabIndex = 88;
            this.label1.Text = "条码枪/人脸识别平板串口";
            // 
            // cmbBarCodeReader
            // 
            this.cmbBarCodeReader.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbBarCodeReader.FormattingEnabled = true;
            this.cmbBarCodeReader.Location = new System.Drawing.Point(186, 26);
            this.cmbBarCodeReader.Name = "cmbBarCodeReader";
            this.cmbBarCodeReader.Size = new System.Drawing.Size(144, 28);
            this.cmbBarCodeReader.TabIndex = 87;
            // 
            // chk启用二代身份证阅读器
            // 
            this.chk启用二代身份证阅读器.AutoSize = true;
            this.chk启用二代身份证阅读器.Location = new System.Drawing.Point(186, 118);
            this.chk启用二代身份证阅读器.Name = "chk启用二代身份证阅读器";
            this.chk启用二代身份证阅读器.Size = new System.Drawing.Size(144, 16);
            this.chk启用二代身份证阅读器.TabIndex = 172;
            this.chk启用二代身份证阅读器.Text = "启用二代身份证阅读器";
            this.chk启用二代身份证阅读器.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(481, 239);
            this.tabControl1.TabIndex = 173;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.cmbICCardReader);
            this.tabPage1.Controls.Add(this.chkEnableTTS);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.chk启用二代身份证阅读器);
            this.tabPage1.Controls.Add(this.cmbBarCodeReader);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(473, 213);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "常规";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 175;
            this.label4.Text = "IC卡读卡器串口";
            // 
            // cmbICCardReader
            // 
            this.cmbICCardReader.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbICCardReader.FormattingEnabled = true;
            this.cmbICCardReader.Location = new System.Drawing.Point(186, 73);
            this.cmbICCardReader.Name = "cmbICCardReader";
            this.cmbICCardReader.Size = new System.Drawing.Size(144, 28);
            this.cmbICCardReader.TabIndex = 174;
            // 
            // chkEnableTTS
            // 
            this.chkEnableTTS.AutoSize = true;
            this.chkEnableTTS.Checked = true;
            this.chkEnableTTS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEnableTTS.Location = new System.Drawing.Point(186, 146);
            this.chkEnableTTS.Name = "chkEnableTTS";
            this.chkEnableTTS.Size = new System.Drawing.Size(96, 16);
            this.chkEnableTTS.TabIndex = 173;
            this.chkEnableTTS.Text = "启用语音提示";
            this.chkEnableTTS.UseVisualStyleBackColor = true;
            // 
            // FrmOption_联机
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(490, 312);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Name = "FrmOption_联机";
            this.Text = "系统选项";
            this.Load += new System.EventHandler(this.FrmOption_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private LJH.GeneralLibrary.WinformControl.ComPortComboBox cmbBarCodeReader;
        private System.Windows.Forms.CheckBox chk启用二代身份证阅读器;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox chkEnableTTS;
        private System.Windows.Forms.Label label4;
        private LJH.GeneralLibrary.WinformControl.ComPortComboBox cmbICCardReader;
    }
}