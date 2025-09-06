namespace HH.ZK.CommonUI
{
    partial class FrmUKey初始化
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
            this.gpDogInit = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn初始化 = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtSchool = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gpDogInit.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpDogInit
            // 
            this.gpDogInit.Controls.Add(this.button1);
            this.gpDogInit.Controls.Add(this.btn初始化);
            this.gpDogInit.Controls.Add(this.lblTitle);
            this.gpDogInit.Controls.Add(this.txtSchool);
            this.gpDogInit.Controls.Add(this.label5);
            this.gpDogInit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpDogInit.Location = new System.Drawing.Point(0, 0);
            this.gpDogInit.Name = "gpDogInit";
            this.gpDogInit.Size = new System.Drawing.Size(556, 261);
            this.gpDogInit.TabIndex = 1;
            this.gpDogInit.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(15, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(280, 42);
            this.button1.TabIndex = 14;
            this.button1.Text = "不，我要在其它软件上进行初始化";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn初始化
            // 
            this.btn初始化.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn初始化.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn初始化.Location = new System.Drawing.Point(392, 191);
            this.btn初始化.Name = "btn初始化";
            this.btn初始化.Size = new System.Drawing.Size(141, 42);
            this.btn初始化.TabIndex = 13;
            this.btn初始化.Text = "初始化";
            this.btn初始化.UseVisualStyleBackColor = true;
            this.btn初始化.Click += new System.EventHandler(this.btn初始化_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.BackColor = System.Drawing.SystemColors.Control;
            this.lblTitle.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(11, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(522, 94);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = "你的加密狗需要进行初始化";
            // 
            // txtSchool
            // 
            this.txtSchool.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSchool.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSchool.Location = new System.Drawing.Point(95, 129);
            this.txtSchool.Name = "txtSchool";
            this.txtSchool.Size = new System.Drawing.Size(438, 30);
            this.txtSchool.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "您所在的学校";
            // 
            // FrmUKey初始化
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 261);
            this.Controls.Add(this.gpDogInit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUKey初始化";
            this.Text = "初始化";
            this.Load += new System.EventHandler(this.FrmUKey初始化_Load);
            this.gpDogInit.ResumeLayout(false);
            this.gpDogInit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpDogInit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn初始化;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtSchool;
        private System.Windows.Forms.Label label5;
    }
}