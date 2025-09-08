
namespace HH.ZK.CommonUI
{
    partial class FrmDivisionDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDivisionDetail));
            this.txtMemo = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDivision = new HH.ZK.CommonUI.Controls.DivisionComboBox(this.components);
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(333, 166);
            this.btnClose.Size = new System.Drawing.Size(99, 43);
            this.btnClose.TabIndex = 11;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(162, 166);
            this.btnOk.Size = new System.Drawing.Size(154, 43);
            this.btnOk.TabIndex = 10;
            // 
            // txtMemo
            // 
            this.txtMemo.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtMemo.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtMemo.Location = new System.Drawing.Point(66, 65);
            this.txtMemo.Name = "txtMemo";
            this.txtMemo.Size = new System.Drawing.Size(366, 30);
            this.txtMemo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 42;
            this.label2.Text = "编号";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtName.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtName.Location = new System.Drawing.Point(66, 17);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(366, 30);
            this.txtName.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 41;
            this.label3.Text = "名称";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 43;
            this.label1.Text = "上级区域";
            // 
            // txtDivision
            // 
            this.txtDivision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtDivision.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDivision.FormattingEnabled = true;
            this.txtDivision.Location = new System.Drawing.Point(66, 113);
            this.txtDivision.Name = "txtDivision";
            this.txtDivision.Size = new System.Drawing.Size(366, 28);
            this.txtDivision.TabIndex = 2;
            // 
            // FrmDivisionDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 224);
            this.Controls.Add(this.txtDivision);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMemo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDivisionDetail";
            this.Text = "区域信息";
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtName, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtMemo, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtDivision, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private LJH.GeneralLibrary.WinformControl.DBCTextBox txtMemo;
        private System.Windows.Forms.Label label2;
        private LJH.GeneralLibrary.WinformControl.DBCTextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Controls.DivisionComboBox txtDivision;
    }
}