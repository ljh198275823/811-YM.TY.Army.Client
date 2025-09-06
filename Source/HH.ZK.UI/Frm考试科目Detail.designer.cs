namespace HH.ZK.UI
{
    partial class Frm考试科目Detail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm考试科目Detail));
            this.txtID = new LJH.GeneralLibrary.WinformControl.IntergerTextBox(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPointCount = new LJH.GeneralLibrary.WinformControl.IntergerTextBox(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtShortName = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtUnit = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.txtMin = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.txtMax = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txt舍入方式 = new System.Windows.Forms.ComboBox();
            this.chk必考 = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rd不限男女 = new System.Windows.Forms.RadioButton();
            this.rdFemale = new System.Windows.Forms.RadioButton();
            this.rdMale = new System.Windows.Forms.RadioButton();
            this.txt测试次数 = new LJH.GeneralLibrary.WinformControl.IntergerTextBox(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.rdNone = new System.Windows.Forms.RadioButton();
            this.rdDesending = new System.Windows.Forms.RadioButton();
            this.rdAscending = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.pnl成绩模式 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rd通过手持机录入 = new System.Windows.Forms.RadioButton();
            this.rd采用设备测试 = new System.Windows.Forms.RadioButton();
            this.panel2.SuspendLayout();
            this.pnl成绩模式.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtID.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtID.Location = new System.Drawing.Point(68, 22);
            this.txtID.MaxValue = 255;
            this.txtID.MinValue = 1;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(326, 30);
            this.txtID.TabIndex = 0;
            this.txtID.Text = "100";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 52;
            this.label1.Text = "编号";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtName.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtName.Location = new System.Drawing.Point(68, 67);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(326, 30);
            this.txtName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 49;
            this.label3.Text = "名称";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 54;
            this.label4.Text = "单位";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(199, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 55;
            this.label5.Text = "小数位数";
            // 
            // txtPointCount
            // 
            this.txtPointCount.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPointCount.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtPointCount.Location = new System.Drawing.Point(260, 152);
            this.txtPointCount.MaxValue = 5;
            this.txtPointCount.MinValue = 0;
            this.txtPointCount.Name = "txtPointCount";
            this.txtPointCount.Size = new System.Drawing.Size(119, 30);
            this.txtPointCount.TabIndex = 5;
            this.txtPointCount.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 57;
            this.label6.Text = "最小值";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(216, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 59;
            this.label7.Text = "最大值";
            // 
            // txtShortName
            // 
            this.txtShortName.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtShortName.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtShortName.Location = new System.Drawing.Point(68, 112);
            this.txtShortName.Name = "txtShortName";
            this.txtShortName.Size = new System.Drawing.Size(119, 30);
            this.txtShortName.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(36, 121);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 103;
            this.label11.Text = "简称";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(320, 479);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(74, 41);
            this.btnClose.TabIndex = 105;
            this.btnClose.Text = "关闭(&C)";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(120, 479);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(181, 41);
            this.btnOk.TabIndex = 104;
            this.btnOk.Text = "确定(&O)";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtUnit
            // 
            this.txtUnit.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtUnit.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtUnit.Location = new System.Drawing.Point(68, 153);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(119, 30);
            this.txtUnit.TabIndex = 4;
            // 
            // txtMin
            // 
            this.txtMin.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtMin.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtMin.Location = new System.Drawing.Point(68, 198);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(119, 30);
            this.txtMin.TabIndex = 6;
            // 
            // txtMax
            // 
            this.txtMax.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtMax.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtMax.Location = new System.Drawing.Point(260, 198);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(121, 30);
            this.txtMax.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 109;
            this.label2.Text = "舍入方式";
            // 
            // txt舍入方式
            // 
            this.txt舍入方式.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt舍入方式.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt舍入方式.FormattingEnabled = true;
            this.txt舍入方式.Items.AddRange(new object[] {
            "非零进一",
            "四舍五入",
            "截取"});
            this.txt舍入方式.Location = new System.Drawing.Point(68, 247);
            this.txt舍入方式.Name = "txt舍入方式";
            this.txt舍入方式.Size = new System.Drawing.Size(311, 28);
            this.txt舍入方式.TabIndex = 8;
            // 
            // chk必考
            // 
            this.chk必考.AutoSize = true;
            this.chk必考.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chk必考.ForeColor = System.Drawing.Color.Red;
            this.chk必考.Location = new System.Drawing.Point(260, 114);
            this.chk必考.Name = "chk必考";
            this.chk必考.Size = new System.Drawing.Size(91, 24);
            this.chk必考.TabIndex = 3;
            this.chk必考.Text = "必考项";
            this.chk必考.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 342);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 112;
            this.label8.Text = "考生性别";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.rd不限男女);
            this.panel2.Controls.Add(this.rdFemale);
            this.panel2.Controls.Add(this.rdMale);
            this.panel2.Location = new System.Drawing.Point(68, 333);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(326, 31);
            this.panel2.TabIndex = 9;
            // 
            // rd不限男女
            // 
            this.rd不限男女.AutoSize = true;
            this.rd不限男女.Checked = true;
            this.rd不限男女.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rd不限男女.Location = new System.Drawing.Point(3, 4);
            this.rd不限男女.Name = "rd不限男女";
            this.rd不限男女.Size = new System.Drawing.Size(67, 24);
            this.rd不限男女.TabIndex = 4;
            this.rd不限男女.TabStop = true;
            this.rd不限男女.Text = "不限";
            this.rd不限男女.UseVisualStyleBackColor = true;
            // 
            // rdFemale
            // 
            this.rdFemale.AutoSize = true;
            this.rdFemale.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdFemale.Location = new System.Drawing.Point(201, 4);
            this.rdFemale.Name = "rdFemale";
            this.rdFemale.Size = new System.Drawing.Size(107, 24);
            this.rdFemale.TabIndex = 3;
            this.rdFemale.Text = "只限女生";
            this.rdFemale.UseVisualStyleBackColor = true;
            // 
            // rdMale
            // 
            this.rdMale.AutoSize = true;
            this.rdMale.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdMale.Location = new System.Drawing.Point(81, 4);
            this.rdMale.Name = "rdMale";
            this.rdMale.Size = new System.Drawing.Size(107, 24);
            this.rdMale.TabIndex = 2;
            this.rdMale.Text = "只限男生";
            this.rdMale.UseVisualStyleBackColor = true;
            // 
            // txt测试次数
            // 
            this.txt测试次数.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt测试次数.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txt测试次数.Location = new System.Drawing.Point(68, 380);
            this.txt测试次数.MaxValue = 5;
            this.txt测试次数.MinValue = 0;
            this.txt测试次数.Name = "txt测试次数";
            this.txt测试次数.Size = new System.Drawing.Size(119, 30);
            this.txt测试次数.TabIndex = 10;
            this.txt测试次数.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 389);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 114;
            this.label9.Text = "测试次数";
            // 
            // rdNone
            // 
            this.rdNone.AutoSize = true;
            this.rdNone.Checked = true;
            this.rdNone.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdNone.Location = new System.Drawing.Point(3, 3);
            this.rdNone.Name = "rdNone";
            this.rdNone.Size = new System.Drawing.Size(47, 24);
            this.rdNone.TabIndex = 115;
            this.rdNone.TabStop = true;
            this.rdNone.Text = "无";
            this.rdNone.UseVisualStyleBackColor = true;
            // 
            // rdDesending
            // 
            this.rdDesending.AutoSize = true;
            this.rdDesending.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdDesending.Location = new System.Drawing.Point(187, 3);
            this.rdDesending.Name = "rdDesending";
            this.rdDesending.Size = new System.Drawing.Size(127, 24);
            this.rdDesending.TabIndex = 117;
            this.rdDesending.Text = "值越高越好";
            this.rdDesending.UseVisualStyleBackColor = true;
            // 
            // rdAscending
            // 
            this.rdAscending.AutoSize = true;
            this.rdAscending.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdAscending.Location = new System.Drawing.Point(54, 3);
            this.rdAscending.Name = "rdAscending";
            this.rdAscending.Size = new System.Drawing.Size(127, 24);
            this.rdAscending.TabIndex = 116;
            this.rdAscending.Text = "值越低越好";
            this.rdAscending.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 298);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 118;
            this.label10.Text = "成绩模式";
            // 
            // pnl成绩模式
            // 
            this.pnl成绩模式.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl成绩模式.Controls.Add(this.rdNone);
            this.pnl成绩模式.Controls.Add(this.rdDesending);
            this.pnl成绩模式.Controls.Add(this.rdAscending);
            this.pnl成绩模式.Location = new System.Drawing.Point(68, 289);
            this.pnl成绩模式.Name = "pnl成绩模式";
            this.pnl成绩模式.Size = new System.Drawing.Size(326, 31);
            this.pnl成绩模式.TabIndex = 119;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 435);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 120;
            this.label12.Text = "成绩来源";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rd通过手持机录入);
            this.panel1.Controls.Add(this.rd采用设备测试);
            this.panel1.Location = new System.Drawing.Point(68, 426);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 31);
            this.panel1.TabIndex = 121;
            // 
            // rd通过手持机录入
            // 
            this.rd通过手持机录入.AutoSize = true;
            this.rd通过手持机录入.Checked = true;
            this.rd通过手持机录入.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rd通过手持机录入.Location = new System.Drawing.Point(156, 4);
            this.rd通过手持机录入.Name = "rd通过手持机录入";
            this.rd通过手持机录入.Size = new System.Drawing.Size(157, 24);
            this.rd通过手持机录入.TabIndex = 3;
            this.rd通过手持机录入.TabStop = true;
            this.rd通过手持机录入.Text = "手持机APP录入";
            this.rd通过手持机录入.UseVisualStyleBackColor = true;
            // 
            // rd采用设备测试
            // 
            this.rd采用设备测试.AutoSize = true;
            this.rd采用设备测试.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rd采用设备测试.Location = new System.Drawing.Point(3, 4);
            this.rd采用设备测试.Name = "rd采用设备测试";
            this.rd采用设备测试.Size = new System.Drawing.Size(107, 24);
            this.rd采用设备测试.TabIndex = 2;
            this.rd采用设备测试.Text = "设备测试";
            this.rd采用设备测试.UseVisualStyleBackColor = true;
            // 
            // Frm考试科目Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 532);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pnl成绩模式);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt测试次数);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.chk必考);
            this.Controls.Add(this.txt舍入方式);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.txtUnit);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtShortName);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPointCount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm考试科目Detail";
            this.Text = "体能测试项目";
            this.Load += new System.EventHandler(this.FrmPhysicalItemDetail_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnl成绩模式.ResumeLayout(false);
            this.pnl成绩模式.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LJH.GeneralLibrary.WinformControl.IntergerTextBox  txtID;
        private System.Windows.Forms.Label label1;
        private LJH.GeneralLibrary.WinformControl.DBCTextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private LJH.GeneralLibrary.WinformControl.IntergerTextBox txtPointCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private LJH.GeneralLibrary.WinformControl.DBCTextBox txtShortName;
        private System.Windows.Forms.Label label11;
        protected System.Windows.Forms.Button btnClose;
        protected System.Windows.Forms.Button btnOk;
        private LJH.GeneralLibrary.WinformControl.DBCTextBox txtUnit;
        private LJH.GeneralLibrary.WinformControl.DBCTextBox txtMin;
        private LJH.GeneralLibrary.WinformControl.DBCTextBox txtMax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox txt舍入方式;
        private System.Windows.Forms.CheckBox chk必考;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rd不限男女;
        private System.Windows.Forms.RadioButton rdFemale;
        private System.Windows.Forms.RadioButton rdMale;
        private LJH.GeneralLibrary.WinformControl.IntergerTextBox txt测试次数;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rdNone;
        private System.Windows.Forms.RadioButton rdDesending;
        private System.Windows.Forms.RadioButton rdAscending;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel pnl成绩模式;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rd通过手持机录入;
        private System.Windows.Forms.RadioButton rd采用设备测试;
    }
}