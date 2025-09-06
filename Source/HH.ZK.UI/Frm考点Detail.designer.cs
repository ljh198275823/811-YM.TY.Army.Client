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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtEndDate = new System.Windows.Forms.DateTimePicker();
            this.rd模拟考试 = new System.Windows.Forms.RadioButton();
            this.rd正式考试 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(340, 224);
            this.btnClose.Size = new System.Drawing.Size(75, 40);
            this.btnClose.TabIndex = 5;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(181, 224);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 42;
            this.label1.Text = "开考日期";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 43;
            this.label2.Text = "结束日期";
            // 
            // dtStartDate
            // 
            this.dtStartDate.CustomFormat = "yyyy年MM月dd日";
            this.dtStartDate.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtStartDate.Location = new System.Drawing.Point(92, 72);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(323, 30);
            this.dtStartDate.TabIndex = 44;
            // 
            // dtEndDate
            // 
            this.dtEndDate.CustomFormat = "yyyy年MM月dd日";
            this.dtEndDate.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEndDate.Location = new System.Drawing.Point(92, 123);
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Size = new System.Drawing.Size(323, 30);
            this.dtEndDate.TabIndex = 45;
            // 
            // rd模拟考试
            // 
            this.rd模拟考试.AutoSize = true;
            this.rd模拟考试.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rd模拟考试.ForeColor = System.Drawing.Color.Red;
            this.rd模拟考试.Location = new System.Drawing.Point(92, 173);
            this.rd模拟考试.Name = "rd模拟考试";
            this.rd模拟考试.Size = new System.Drawing.Size(94, 20);
            this.rd模拟考试.TabIndex = 47;
            this.rd模拟考试.TabStop = true;
            this.rd模拟考试.Text = "模拟考试";
            this.rd模拟考试.UseVisualStyleBackColor = true;
            // 
            // rd正式考试
            // 
            this.rd正式考试.AutoSize = true;
            this.rd正式考试.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rd正式考试.ForeColor = System.Drawing.Color.Blue;
            this.rd正式考试.Location = new System.Drawing.Point(223, 173);
            this.rd正式考试.Name = "rd正式考试";
            this.rd正式考试.Size = new System.Drawing.Size(94, 20);
            this.rd正式考试.TabIndex = 48;
            this.rd正式考试.TabStop = true;
            this.rd正式考试.Text = "正式考试";
            this.rd正式考试.UseVisualStyleBackColor = true;
            // 
            // Frm考点Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 276);
            this.Controls.Add(this.rd正式考试);
            this.Controls.Add(this.rd模拟考试);
            this.Controls.Add(this.dtEndDate);
            this.Controls.Add(this.dtStartDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm考点Detail";
            this.Text = "考点";
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtName, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.dtStartDate, 0);
            this.Controls.SetChildIndex(this.dtEndDate, 0);
            this.Controls.SetChildIndex(this.rd模拟考试, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.rd正式考试, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private LJH.GeneralLibrary.WinformControl.DBCTextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtStartDate;
        private System.Windows.Forms.DateTimePicker dtEndDate;
        private System.Windows.Forms.RadioButton rd模拟考试;
        private System.Windows.Forms.RadioButton rd正式考试;
    }
}