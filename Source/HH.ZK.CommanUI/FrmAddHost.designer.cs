namespace HH.ZK.CommonUI
{
    partial class FrmAddHost
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHost = new LJH.GeneralLibrary.WinformControl.IntergerTextBox(this.components);
            this.txtSer = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtPid = new LJH.GeneralLibrary.WinformControl.IntergerTextBox(this.components);
            this.txtIP1 = new LJH.GeneralLibrary.WinformControl.IntergerTextBox(this.components);
            this.txtIP = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "主机IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "主机编号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "主机序列号";
            // 
            // txtHost
            // 
            this.txtHost.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtHost.Location = new System.Drawing.Point(97, 67);
            this.txtHost.MaxValue = 99;
            this.txtHost.MinValue = 0;
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(100, 21);
            this.txtHost.TabIndex = 1;
            this.txtHost.Text = "0";
            // 
            // txtSer
            // 
            this.txtSer.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtSer.Location = new System.Drawing.Point(97, 108);
            this.txtSer.Name = "txtSer";
            this.txtSer.Size = new System.Drawing.Size(100, 21);
            this.txtSer.TabIndex = 2;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(97, 156);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 33);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "确定(&O)";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(217, 156);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 33);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtPid
            // 
            this.txtPid.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtPid.Location = new System.Drawing.Point(217, 109);
            this.txtPid.MaxValue = 99;
            this.txtPid.MinValue = 0;
            this.txtPid.Name = "txtPid";
            this.txtPid.Size = new System.Drawing.Size(100, 21);
            this.txtPid.TabIndex = 5;
            this.txtPid.Text = "0";
            this.txtPid.Visible = false;
            // 
            // txtIP1
            // 
            this.txtIP1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtIP1.Location = new System.Drawing.Point(201, 25);
            this.txtIP1.MaxValue = 255;
            this.txtIP1.MinValue = 0;
            this.txtIP1.Name = "txtIP1";
            this.txtIP1.Size = new System.Drawing.Size(46, 21);
            this.txtIP1.TabIndex = 0;
            this.txtIP1.Text = "0";
            this.txtIP1.Leave += new System.EventHandler(this.txtIP_Leave);
            // 
            // txtIP
            // 
            this.txtIP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtIP.FormattingEnabled = true;
            this.txtIP.Location = new System.Drawing.Point(95, 26);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(100, 20);
            this.txtIP.TabIndex = 7;
            // 
            // FrmAddHost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(336, 204);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.txtIP1);
            this.Controls.Add(this.txtPid);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtSer);
            this.Controls.Add(this.txtHost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmAddHost";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "增加主机";
            this.Load += new System.EventHandler(this.FrmAddHost_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private LJH.GeneralLibrary.WinformControl.IntergerTextBox txtHost;
        private LJH.GeneralLibrary.WinformControl.DBCTextBox txtSer;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private LJH.GeneralLibrary.WinformControl.IntergerTextBox txtPid;
        private LJH.GeneralLibrary.WinformControl.IntergerTextBox txtIP1;
        private System.Windows.Forms.ComboBox txtIP;
    }
}