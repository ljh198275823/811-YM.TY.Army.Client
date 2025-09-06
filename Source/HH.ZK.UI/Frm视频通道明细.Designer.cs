namespace HH.ZK.UI
{
    partial class Frm视频通道明细
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
            this.txtSN = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.lnk视频通道 = new System.Windows.Forms.LinkLabel();
            this.txtChannels = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSN
            // 
            this.txtSN.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSN.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtSN.Location = new System.Drawing.Point(78, 21);
            this.txtSN.Name = "txtSN";
            this.txtSN.Size = new System.Drawing.Size(230, 30);
            this.txtSN.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "设备编号";
            // 
            // lnk视频通道
            // 
            this.lnk视频通道.AutoSize = true;
            this.lnk视频通道.Location = new System.Drawing.Point(20, 95);
            this.lnk视频通道.Name = "lnk视频通道";
            this.lnk视频通道.Size = new System.Drawing.Size(53, 12);
            this.lnk视频通道.TabIndex = 13;
            this.lnk视频通道.TabStop = true;
            this.lnk视频通道.Text = "视频通道";
            this.lnk视频通道.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk视频通道_LinkClicked);
            // 
            // txtChannels
            // 
            this.txtChannels.Enabled = false;
            this.txtChannels.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtChannels.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtChannels.Location = new System.Drawing.Point(78, 85);
            this.txtChannels.Name = "txtChannels";
            this.txtChannels.Size = new System.Drawing.Size(230, 30);
            this.txtChannels.TabIndex = 14;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(233, 142);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 34);
            this.btnCancel.TabIndex = 173;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(78, 142);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(140, 34);
            this.btnOk.TabIndex = 172;
            this.btnOk.Text = "确定(&O)";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // Frm视频通道明细
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 188);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtChannels);
            this.Controls.Add(this.lnk视频通道);
            this.Controls.Add(this.txtSN);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frm视频通道明细";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "视频通道明细";
            this.Load += new System.EventHandler(this.Frm视频通道明细_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LJH.GeneralLibrary.WinformControl.DBCTextBox txtSN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel lnk视频通道;
        private LJH.GeneralLibrary.WinformControl.DBCTextBox txtChannels;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
    }
}