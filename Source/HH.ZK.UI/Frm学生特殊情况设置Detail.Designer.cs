namespace HH.ZK.UI
{
    partial class Frm学生特殊情况设置Detail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm学生特殊情况设置Detail));
            this.txt学生状态 = new HH.ZK.CommonUI.Controls.StudentStateComboBox(this.components);
            this.txt总分 = new LJH.GeneralLibrary.WinformControl.DecimalTextBox(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.chk固定总分 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txt学生状态
            // 
            this.txt学生状态.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt学生状态.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt学生状态.FormattingEnabled = true;
            this.txt学生状态.Location = new System.Drawing.Point(102, 29);
            this.txt学生状态.Name = "txt学生状态";
            this.txt学生状态.Size = new System.Drawing.Size(192, 28);
            this.txt学生状态.TabIndex = 0;
            // 
            // txt总分
            // 
            this.txt总分.Enabled = false;
            this.txt总分.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold);
            this.txt总分.ForeColor = System.Drawing.Color.Red;
            this.txt总分.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txt总分.Location = new System.Drawing.Point(198, 79);
            this.txt总分.MaxValue = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txt总分.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txt总分.Name = "txt总分";
            this.txt总分.PointCount = -1;
            this.txt总分.Size = new System.Drawing.Size(96, 30);
            this.txt总分.TabIndex = 220;
            this.txt总分.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(45, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 221;
            this.label1.Text = "学生状态";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(200, 139);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 34);
            this.btnCancel.TabIndex = 223;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(54, 139);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(119, 34);
            this.btnOk.TabIndex = 222;
            this.btnOk.Text = "确定(&O)";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // chk固定总分
            // 
            this.chk固定总分.AutoSize = true;
            this.chk固定总分.Location = new System.Drawing.Point(102, 86);
            this.chk固定总分.Name = "chk固定总分";
            this.chk固定总分.Size = new System.Drawing.Size(72, 16);
            this.chk固定总分.TabIndex = 224;
            this.chk固定总分.Text = "固定总分";
            this.chk固定总分.UseVisualStyleBackColor = true;
            this.chk固定总分.CheckedChanged += new System.EventHandler(this.chk固定总分_CheckedChanged);
            // 
            // Frm学生特殊情况设置Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 210);
            this.Controls.Add(this.chk固定总分);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt总分);
            this.Controls.Add(this.txt学生状态);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm学生特殊情况设置Detail";
            this.Text = "学生特殊情况设置";
            this.Load += new System.EventHandler(this.Frm学生特殊情况设置Detail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CommonUI.Controls.StudentStateComboBox txt学生状态;
        private LJH.GeneralLibrary.WinformControl.DecimalTextBox txt总分;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.CheckBox chk固定总分;
    }
}