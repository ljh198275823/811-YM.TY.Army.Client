namespace HH.ZK.CommonUI
{
    partial class FrmScoreCollectStatitics
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.txtStartSN = new System.Windows.Forms.TextBox();
            this.txtEndSN = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtMissed = new System.Windows.Forms.TextBox();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtMissedDetail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "主机号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "最小记录编号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "最大记录编号";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "最小成绩";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "最大成绩";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "采集总记录数";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(31, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "丢失记录数";
            // 
            // txtHost
            // 
            this.txtHost.BackColor = System.Drawing.Color.White;
            this.txtHost.Location = new System.Drawing.Point(103, 23);
            this.txtHost.Name = "txtHost";
            this.txtHost.ReadOnly = true;
            this.txtHost.Size = new System.Drawing.Size(178, 21);
            this.txtHost.TabIndex = 7;
            // 
            // txtStartSN
            // 
            this.txtStartSN.BackColor = System.Drawing.Color.White;
            this.txtStartSN.Location = new System.Drawing.Point(103, 54);
            this.txtStartSN.Name = "txtStartSN";
            this.txtStartSN.ReadOnly = true;
            this.txtStartSN.Size = new System.Drawing.Size(178, 21);
            this.txtStartSN.TabIndex = 8;
            // 
            // txtEndSN
            // 
            this.txtEndSN.BackColor = System.Drawing.Color.White;
            this.txtEndSN.Location = new System.Drawing.Point(103, 89);
            this.txtEndSN.Name = "txtEndSN";
            this.txtEndSN.ReadOnly = true;
            this.txtEndSN.Size = new System.Drawing.Size(178, 21);
            this.txtEndSN.TabIndex = 9;
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.White;
            this.txtTotal.Location = new System.Drawing.Point(103, 120);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(178, 21);
            this.txtTotal.TabIndex = 10;
            // 
            // txtMissed
            // 
            this.txtMissed.BackColor = System.Drawing.Color.White;
            this.txtMissed.ForeColor = System.Drawing.Color.Red;
            this.txtMissed.Location = new System.Drawing.Point(103, 150);
            this.txtMissed.Name = "txtMissed";
            this.txtMissed.ReadOnly = true;
            this.txtMissed.Size = new System.Drawing.Size(178, 21);
            this.txtMissed.TabIndex = 11;
            // 
            // txtMin
            // 
            this.txtMin.BackColor = System.Drawing.Color.White;
            this.txtMin.Location = new System.Drawing.Point(103, 177);
            this.txtMin.Name = "txtMin";
            this.txtMin.ReadOnly = true;
            this.txtMin.Size = new System.Drawing.Size(178, 21);
            this.txtMin.TabIndex = 12;
            // 
            // txtMax
            // 
            this.txtMax.BackColor = System.Drawing.Color.White;
            this.txtMax.Location = new System.Drawing.Point(103, 209);
            this.txtMax.Name = "txtMax";
            this.txtMax.ReadOnly = true;
            this.txtMax.Size = new System.Drawing.Size(178, 21);
            this.txtMax.TabIndex = 13;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(228, 265);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(115, 35);
            this.btnOk.TabIndex = 14;
            this.btnOk.Text = "确定(&O)";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtMissedDetail
            // 
            this.txtMissedDetail.BackColor = System.Drawing.Color.White;
            this.txtMissedDetail.ForeColor = System.Drawing.Color.Red;
            this.txtMissedDetail.Location = new System.Drawing.Point(301, 39);
            this.txtMissedDetail.Multiline = true;
            this.txtMissedDetail.Name = "txtMissedDetail";
            this.txtMissedDetail.ReadOnly = true;
            this.txtMissedDetail.Size = new System.Drawing.Size(248, 191);
            this.txtMissedDetail.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(299, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 15;
            this.label8.Text = "丢失记录号";
            // 
            // FrmStatitics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 322);
            this.Controls.Add(this.txtMissedDetail);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.txtMissed);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtEndSN);
            this.Controls.Add(this.txtStartSN);
            this.Controls.Add(this.txtHost);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmStatitics";
            this.Text = "采集统计";
            this.Load += new System.EventHandler(this.FrmStatitics_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.TextBox txtStartSN;
        private System.Windows.Forms.TextBox txtEndSN;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtMissed;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtMissedDetail;
        private System.Windows.Forms.Label label8;
    }
}