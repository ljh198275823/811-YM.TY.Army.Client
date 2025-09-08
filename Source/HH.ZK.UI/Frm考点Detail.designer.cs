namespace HH.ZK.UI
{
    partial class Frm考点Detail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm考点Detail));
            this.txtName = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.rd训练 = new System.Windows.Forms.RadioButton();
            this.rd考核 = new System.Windows.Forms.RadioButton();
            this.txt简称 = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(340, 187);
            this.btnClose.Size = new System.Drawing.Size(75, 40);
            this.btnClose.TabIndex = 5;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(181, 187);
            this.btnOk.Size = new System.Drawing.Size(137, 40);
            this.btnOk.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtName.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtName.Location = new System.Drawing.Point(92, 21);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(323, 30);
            this.txtName.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 41;
            this.label3.Text = "名称";
            // 
            // rd训练
            // 
            this.rd训练.AutoSize = true;
            this.rd训练.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rd训练.ForeColor = System.Drawing.Color.Red;
            this.rd训练.Location = new System.Drawing.Point(96, 128);
            this.rd训练.Name = "rd训练";
            this.rd训练.Size = new System.Drawing.Size(60, 20);
            this.rd训练.TabIndex = 47;
            this.rd训练.TabStop = true;
            this.rd训练.Text = "训练";
            this.rd训练.UseVisualStyleBackColor = true;
            // 
            // rd考核
            // 
            this.rd考核.AutoSize = true;
            this.rd考核.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rd考核.ForeColor = System.Drawing.Color.Blue;
            this.rd考核.Location = new System.Drawing.Point(176, 128);
            this.rd考核.Name = "rd考核";
            this.rd考核.Size = new System.Drawing.Size(60, 20);
            this.rd考核.TabIndex = 48;
            this.rd考核.TabStop = true;
            this.rd考核.Text = "考核";
            this.rd考核.UseVisualStyleBackColor = true;
            // 
            // txt简称
            // 
            this.txt简称.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt简称.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txt简称.Location = new System.Drawing.Point(92, 74);
            this.txt简称.Name = "txt简称";
            this.txt简称.Size = new System.Drawing.Size(323, 30);
            this.txt简称.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 50;
            this.label1.Text = "简称";
            // 
            // Frm考点Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 239);
            this.Controls.Add(this.txt简称);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rd考核);
            this.Controls.Add(this.rd训练);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm考点Detail";
            this.Text = "训练/考核大纲";
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtName, 0);
            this.Controls.SetChildIndex(this.rd训练, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.rd考核, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txt简称, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private LJH.GeneralLibrary.WinformControl.DBCTextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rd训练;
        private System.Windows.Forms.RadioButton rd考核;
        private LJH.GeneralLibrary.WinformControl.DBCTextBox txt简称;
        private System.Windows.Forms.Label label1;
    }
}