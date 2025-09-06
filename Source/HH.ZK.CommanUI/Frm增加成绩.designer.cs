namespace HH.ZK.UI
{
    partial class Frm增加成绩
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm增加成绩));
            this.txtID = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txtFacility = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdFemale = new System.Windows.Forms.RadioButton();
            this.rdMale = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.txtName = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lblPhysicalItem = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtScore = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.rd犯规 = new System.Windows.Forms.RadioButton();
            this.rd残疾 = new System.Windows.Forms.RadioButton();
            this.rd未完成 = new System.Windows.Forms.RadioButton();
            this.rd弃考 = new System.Windows.Forms.RadioButton();
            this.rd免考 = new System.Windows.Forms.RadioButton();
            this.pnlSpecial = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.rd伤病 = new System.Windows.Forms.RadioButton();
            this.panel2.SuspendLayout();
            this.pnlSpecial.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtID.Location = new System.Drawing.Point(75, 20);
            this.txtID.MaxLength = 20;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(282, 21);
            this.txtID.TabIndex = 67;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(14, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 76;
            this.label2.Text = "准考证号";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFacility
            // 
            this.txtFacility.BackColor = System.Drawing.Color.White;
            this.txtFacility.Enabled = false;
            this.txtFacility.Location = new System.Drawing.Point(75, 83);
            this.txtFacility.Name = "txtFacility";
            this.txtFacility.ReadOnly = true;
            this.txtFacility.Size = new System.Drawing.Size(282, 21);
            this.txtFacility.TabIndex = 71;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdFemale);
            this.panel2.Controls.Add(this.rdMale);
            this.panel2.Location = new System.Drawing.Point(77, 113);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(282, 24);
            this.panel2.TabIndex = 75;
            // 
            // rdFemale
            // 
            this.rdFemale.AutoSize = true;
            this.rdFemale.Enabled = false;
            this.rdFemale.Location = new System.Drawing.Point(55, 4);
            this.rdFemale.Name = "rdFemale";
            this.rdFemale.Size = new System.Drawing.Size(35, 16);
            this.rdFemale.TabIndex = 6;
            this.rdFemale.Text = "女";
            this.rdFemale.UseVisualStyleBackColor = true;
            // 
            // rdMale
            // 
            this.rdMale.AutoSize = true;
            this.rdMale.Checked = true;
            this.rdMale.Enabled = false;
            this.rdMale.Location = new System.Drawing.Point(4, 4);
            this.rdMale.Name = "rdMale";
            this.rdMale.Size = new System.Drawing.Size(35, 16);
            this.rdMale.TabIndex = 5;
            this.rdMale.TabStop = true;
            this.rdMale.Text = "男";
            this.rdMale.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(38, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 74;
            this.label8.Text = "性别";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtName.Location = new System.Drawing.Point(75, 53);
            this.txtName.MaxLength = 20;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(282, 21);
            this.txtName.TabIndex = 68;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(38, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 72;
            this.label1.Text = "姓名";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPhysicalItem
            // 
            this.lblPhysicalItem.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPhysicalItem.Location = new System.Drawing.Point(7, 166);
            this.lblPhysicalItem.Name = "lblPhysicalItem";
            this.lblPhysicalItem.Size = new System.Drawing.Size(114, 12);
            this.lblPhysicalItem.TabIndex = 77;
            this.lblPhysicalItem.Text = "50米";
            this.lblPhysicalItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblUnit.Location = new System.Drawing.Point(287, 166);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(17, 12);
            this.lblUnit.TabIndex = 78;
            this.lblUnit.Text = "秒";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(38, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 79;
            this.label6.Text = "学校";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtScore
            // 
            this.txtScore.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtScore.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtScore.Location = new System.Drawing.Point(127, 157);
            this.txtScore.MaxLength = 20;
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(154, 30);
            this.txtScore.TabIndex = 83;
            // 
            // rd犯规
            // 
            this.rd犯规.AutoSize = true;
            this.rd犯规.Location = new System.Drawing.Point(64, 7);
            this.rd犯规.Name = "rd犯规";
            this.rd犯规.Size = new System.Drawing.Size(47, 16);
            this.rd犯规.TabIndex = 88;
            this.rd犯规.Text = "犯规";
            this.rd犯规.UseVisualStyleBackColor = true;
            // 
            // rd残疾
            // 
            this.rd残疾.AutoSize = true;
            this.rd残疾.Location = new System.Drawing.Point(178, 7);
            this.rd残疾.Name = "rd残疾";
            this.rd残疾.Size = new System.Drawing.Size(47, 16);
            this.rd残疾.TabIndex = 89;
            this.rd残疾.Text = "残疾";
            this.rd残疾.UseVisualStyleBackColor = true;
            // 
            // rd未完成
            // 
            this.rd未完成.AutoSize = true;
            this.rd未完成.Location = new System.Drawing.Point(235, 7);
            this.rd未完成.Name = "rd未完成";
            this.rd未完成.Size = new System.Drawing.Size(59, 16);
            this.rd未完成.TabIndex = 90;
            this.rd未完成.Text = "未完成";
            this.rd未完成.UseVisualStyleBackColor = true;
            // 
            // rd弃考
            // 
            this.rd弃考.AutoSize = true;
            this.rd弃考.Location = new System.Drawing.Point(304, 7);
            this.rd弃考.Name = "rd弃考";
            this.rd弃考.Size = new System.Drawing.Size(47, 16);
            this.rd弃考.TabIndex = 91;
            this.rd弃考.Text = "弃考";
            this.rd弃考.UseVisualStyleBackColor = true;
            // 
            // rd免考
            // 
            this.rd免考.AutoSize = true;
            this.rd免考.Location = new System.Drawing.Point(7, 7);
            this.rd免考.Name = "rd免考";
            this.rd免考.Size = new System.Drawing.Size(47, 16);
            this.rd免考.TabIndex = 92;
            this.rd免考.Text = "免考";
            this.rd免考.UseVisualStyleBackColor = true;
            // 
            // pnlSpecial
            // 
            this.pnlSpecial.Controls.Add(this.rd伤病);
            this.pnlSpecial.Controls.Add(this.rd免考);
            this.pnlSpecial.Controls.Add(this.rd犯规);
            this.pnlSpecial.Controls.Add(this.rd残疾);
            this.pnlSpecial.Controls.Add(this.rd弃考);
            this.pnlSpecial.Controls.Add(this.rd未完成);
            this.pnlSpecial.Location = new System.Drawing.Point(16, 207);
            this.pnlSpecial.Name = "pnlSpecial";
            this.pnlSpecial.Size = new System.Drawing.Size(356, 30);
            this.pnlSpecial.TabIndex = 94;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(253, 262);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(119, 34);
            this.btnCancel.TabIndex = 96;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(107, 262);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(119, 34);
            this.btnOk.TabIndex = 95;
            this.btnOk.Text = "确定(&O)";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // rd伤病
            // 
            this.rd伤病.AutoSize = true;
            this.rd伤病.Location = new System.Drawing.Point(121, 7);
            this.rd伤病.Name = "rd伤病";
            this.rd伤病.Size = new System.Drawing.Size(47, 16);
            this.rd伤病.TabIndex = 93;
            this.rd伤病.Text = "伤病";
            this.rd伤病.UseVisualStyleBackColor = true;
            // 
            // Frm增加成绩
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 317);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.pnlSpecial);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblUnit);
            this.Controls.Add(this.lblPhysicalItem);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFacility);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm增加成绩";
            this.Text = "学生成绩";
            this.Load += new System.EventHandler(this.Frm增加成绩_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlSpecial.ResumeLayout(false);
            this.pnlSpecial.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LJH.GeneralLibrary.WinformControl.DBCTextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFacility;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdFemale;
        private System.Windows.Forms.RadioButton rdMale;
        private System.Windows.Forms.Label label8;
        private LJH.GeneralLibrary.WinformControl.DBCTextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPhysicalItem;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Label label6;
        private LJH.GeneralLibrary.WinformControl.DBCTextBox txtScore;
        private System.Windows.Forms.RadioButton rd犯规;
        private System.Windows.Forms.RadioButton rd残疾;
        private System.Windows.Forms.RadioButton rd未完成;
        private System.Windows.Forms.RadioButton rd弃考;
        private System.Windows.Forms.RadioButton rd免考;
        private System.Windows.Forms.Panel pnlSpecial;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.RadioButton rd伤病;
    }
}