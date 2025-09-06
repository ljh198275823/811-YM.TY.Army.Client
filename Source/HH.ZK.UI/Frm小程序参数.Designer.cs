namespace HH.ZK.UI
{
    partial class Frm小程序参数
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
            this.lnk考试科目1 = new System.Windows.Forms.LinkLabel();
            this.txt考试科目1 = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.dt报名结束日期 = new System.Windows.Forms.DateTimePicker();
            this.dt报名开始日期 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dt成绩查询结束日期 = new System.Windows.Forms.DateTimePicker();
            this.dt成绩查询开始日期 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.chk启用报名 = new System.Windows.Forms.CheckBox();
            this.chk启用成绩查询 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtName1 = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.txtName2 = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.lnk考试科目2 = new System.Windows.Forms.LinkLabel();
            this.txt考试科目2 = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.txtName3 = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.lnk考试科目3 = new System.Windows.Forms.LinkLabel();
            this.txt考试科目3 = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.txt考试科目0 = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.txtName0 = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.txt选择数量1 = new LJH.GeneralLibrary.WinformControl.IntergerTextBox(this.components);
            this.txt选择数量2 = new LJH.GeneralLibrary.WinformControl.IntergerTextBox(this.components);
            this.txt选择数量3 = new LJH.GeneralLibrary.WinformControl.IntergerTextBox(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lnk考试科目1
            // 
            this.lnk考试科目1.AutoSize = true;
            this.lnk考试科目1.Location = new System.Drawing.Point(629, 137);
            this.lnk考试科目1.Name = "lnk考试科目1";
            this.lnk考试科目1.Size = new System.Drawing.Size(53, 12);
            this.lnk考试科目1.TabIndex = 104;
            this.lnk考试科目1.TabStop = true;
            this.lnk考试科目1.Text = "设置科目";
            this.lnk考试科目1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk考试科目1_LinkClicked);
            // 
            // txt考试科目1
            // 
            this.txt考试科目1.Enabled = false;
            this.txt考试科目1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txt考试科目1.Location = new System.Drawing.Point(277, 127);
            this.txt考试科目1.MaxLength = 20;
            this.txt考试科目1.Multiline = true;
            this.txt考试科目1.Name = "txt考试科目1";
            this.txt考试科目1.Size = new System.Drawing.Size(340, 33);
            this.txt考试科目1.TabIndex = 103;
            // 
            // dt报名结束日期
            // 
            this.dt报名结束日期.CustomFormat = "yyyy年MM月dd日";
            this.dt报名结束日期.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dt报名结束日期.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt报名结束日期.Location = new System.Drawing.Point(372, 29);
            this.dt报名结束日期.Name = "dt报名结束日期";
            this.dt报名结束日期.Size = new System.Drawing.Size(180, 30);
            this.dt报名结束日期.TabIndex = 108;
            // 
            // dt报名开始日期
            // 
            this.dt报名开始日期.CustomFormat = "yyyy年MM月dd日";
            this.dt报名开始日期.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dt报名开始日期.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt报名开始日期.Location = new System.Drawing.Point(131, 29);
            this.dt报名开始日期.Name = "dt报名开始日期";
            this.dt报名开始日期.Size = new System.Drawing.Size(180, 30);
            this.dt报名开始日期.TabIndex = 107;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 106;
            this.label2.Text = "------";
            // 
            // dt成绩查询结束日期
            // 
            this.dt成绩查询结束日期.CustomFormat = "yyyy年MM月dd日";
            this.dt成绩查询结束日期.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dt成绩查询结束日期.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt成绩查询结束日期.Location = new System.Drawing.Point(372, 292);
            this.dt成绩查询结束日期.Name = "dt成绩查询结束日期";
            this.dt成绩查询结束日期.Size = new System.Drawing.Size(180, 30);
            this.dt成绩查询结束日期.TabIndex = 112;
            // 
            // dt成绩查询开始日期
            // 
            this.dt成绩查询开始日期.CustomFormat = "yyyy年MM月dd日";
            this.dt成绩查询开始日期.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dt成绩查询开始日期.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt成绩查询开始日期.Location = new System.Drawing.Point(131, 292);
            this.dt成绩查询开始日期.Name = "dt成绩查询开始日期";
            this.dt成绩查询开始日期.Size = new System.Drawing.Size(180, 30);
            this.dt成绩查询开始日期.TabIndex = 111;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(320, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 110;
            this.label3.Text = "------";
            // 
            // chk启用报名
            // 
            this.chk启用报名.AutoSize = true;
            this.chk启用报名.Location = new System.Drawing.Point(41, 37);
            this.chk启用报名.Name = "chk启用报名";
            this.chk启用报名.Size = new System.Drawing.Size(84, 16);
            this.chk启用报名.TabIndex = 113;
            this.chk启用报名.Text = "启用报名从";
            this.chk启用报名.UseVisualStyleBackColor = true;
            // 
            // chk启用成绩查询
            // 
            this.chk启用成绩查询.AutoSize = true;
            this.chk启用成绩查询.Location = new System.Drawing.Point(17, 301);
            this.chk启用成绩查询.Name = "chk启用成绩查询";
            this.chk启用成绩查询.Size = new System.Drawing.Size(108, 16);
            this.chk启用成绩查询.TabIndex = 114;
            this.chk启用成绩查询.Text = "启用成绩查询从";
            this.chk启用成绩查询.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 115;
            this.label5.Text = "必考项";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 116;
            this.label6.Text = "选考组一";
            // 
            // txtName1
            // 
            this.txtName1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtName1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtName1.Location = new System.Drawing.Point(131, 128);
            this.txtName1.Name = "txtName1";
            this.txtName1.Size = new System.Drawing.Size(132, 30);
            this.txtName1.TabIndex = 117;
            this.txtName1.Text = "选考组一";
            // 
            // txtName2
            // 
            this.txtName2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtName2.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtName2.Location = new System.Drawing.Point(131, 183);
            this.txtName2.Name = "txtName2";
            this.txtName2.Size = new System.Drawing.Size(132, 30);
            this.txtName2.TabIndex = 121;
            this.txtName2.Text = "选考组二";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(72, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 120;
            this.label7.Text = "选考组二";
            // 
            // lnk考试科目2
            // 
            this.lnk考试科目2.AutoSize = true;
            this.lnk考试科目2.Location = new System.Drawing.Point(629, 192);
            this.lnk考试科目2.Name = "lnk考试科目2";
            this.lnk考试科目2.Size = new System.Drawing.Size(53, 12);
            this.lnk考试科目2.TabIndex = 119;
            this.lnk考试科目2.TabStop = true;
            this.lnk考试科目2.Text = "设置科目";
            this.lnk考试科目2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk考试科目2_LinkClicked);
            // 
            // txt考试科目2
            // 
            this.txt考试科目2.Enabled = false;
            this.txt考试科目2.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txt考试科目2.Location = new System.Drawing.Point(277, 182);
            this.txt考试科目2.MaxLength = 20;
            this.txt考试科目2.Multiline = true;
            this.txt考试科目2.Name = "txt考试科目2";
            this.txt考试科目2.Size = new System.Drawing.Size(340, 33);
            this.txt考试科目2.TabIndex = 118;
            // 
            // txtName3
            // 
            this.txtName3.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtName3.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtName3.Location = new System.Drawing.Point(131, 237);
            this.txtName3.Name = "txtName3";
            this.txtName3.Size = new System.Drawing.Size(132, 30);
            this.txtName3.TabIndex = 125;
            this.txtName3.Text = "选考组三";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(72, 246);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 124;
            this.label8.Text = "选考组三";
            // 
            // lnk考试科目3
            // 
            this.lnk考试科目3.AutoSize = true;
            this.lnk考试科目3.Location = new System.Drawing.Point(629, 246);
            this.lnk考试科目3.Name = "lnk考试科目3";
            this.lnk考试科目3.Size = new System.Drawing.Size(53, 12);
            this.lnk考试科目3.TabIndex = 123;
            this.lnk考试科目3.TabStop = true;
            this.lnk考试科目3.Text = "设置科目";
            this.lnk考试科目3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk考试科目3_LinkClicked);
            // 
            // txt考试科目3
            // 
            this.txt考试科目3.Enabled = false;
            this.txt考试科目3.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txt考试科目3.Location = new System.Drawing.Point(277, 236);
            this.txt考试科目3.MaxLength = 20;
            this.txt考试科目3.Multiline = true;
            this.txt考试科目3.Name = "txt考试科目3";
            this.txt考试科目3.Size = new System.Drawing.Size(340, 33);
            this.txt考试科目3.TabIndex = 122;
            // 
            // txt考试科目0
            // 
            this.txt考试科目0.Enabled = false;
            this.txt考试科目0.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txt考试科目0.Location = new System.Drawing.Point(277, 76);
            this.txt考试科目0.MaxLength = 20;
            this.txt考试科目0.Multiline = true;
            this.txt考试科目0.Name = "txt考试科目0";
            this.txt考试科目0.Size = new System.Drawing.Size(340, 33);
            this.txt考试科目0.TabIndex = 126;
            // 
            // txtName0
            // 
            this.txtName0.Enabled = false;
            this.txtName0.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtName0.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtName0.Location = new System.Drawing.Point(131, 77);
            this.txtName0.Name = "txtName0";
            this.txtName0.Size = new System.Drawing.Size(132, 30);
            this.txtName0.TabIndex = 127;
            this.txtName0.Text = "必考项";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(676, 349);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(119, 34);
            this.btnCancel.TabIndex = 129;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(530, 349);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(119, 34);
            this.btnOk.TabIndex = 128;
            this.btnOk.Text = "确定(&O)";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txt选择数量1
            // 
            this.txt选择数量1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt选择数量1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txt选择数量1.Location = new System.Drawing.Point(752, 128);
            this.txt选择数量1.MaxValue = 100;
            this.txt选择数量1.MinValue = 0;
            this.txt选择数量1.Name = "txt选择数量1";
            this.txt选择数量1.Size = new System.Drawing.Size(39, 30);
            this.txt选择数量1.TabIndex = 130;
            this.txt选择数量1.Text = "1";
            // 
            // txt选择数量2
            // 
            this.txt选择数量2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt选择数量2.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txt选择数量2.Location = new System.Drawing.Point(752, 183);
            this.txt选择数量2.MaxValue = 100;
            this.txt选择数量2.MinValue = 0;
            this.txt选择数量2.Name = "txt选择数量2";
            this.txt选择数量2.Size = new System.Drawing.Size(39, 30);
            this.txt选择数量2.TabIndex = 131;
            this.txt选择数量2.Text = "1";
            // 
            // txt选择数量3
            // 
            this.txt选择数量3.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt选择数量3.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txt选择数量3.Location = new System.Drawing.Point(752, 237);
            this.txt选择数量3.MaxValue = 100;
            this.txt选择数量3.MinValue = 0;
            this.txt选择数量3.Name = "txt选择数量3";
            this.txt选择数量3.Size = new System.Drawing.Size(39, 30);
            this.txt选择数量3.TabIndex = 132;
            this.txt选择数量3.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(690, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 133;
            this.label1.Text = "选择数量";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(690, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 134;
            this.label4.Text = "选择数量";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(690, 246);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 135;
            this.label9.Text = "选择数量";
            // 
            // Frm小程序参数
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 395);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt选择数量3);
            this.Controls.Add(this.txt选择数量2);
            this.Controls.Add(this.txt选择数量1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtName0);
            this.Controls.Add(this.txt考试科目0);
            this.Controls.Add(this.txtName3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lnk考试科目3);
            this.Controls.Add(this.txt考试科目3);
            this.Controls.Add(this.txtName2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lnk考试科目2);
            this.Controls.Add(this.txt考试科目2);
            this.Controls.Add(this.txtName1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chk启用成绩查询);
            this.Controls.Add(this.chk启用报名);
            this.Controls.Add(this.dt成绩查询结束日期);
            this.Controls.Add(this.dt成绩查询开始日期);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dt报名结束日期);
            this.Controls.Add(this.dt报名开始日期);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lnk考试科目1);
            this.Controls.Add(this.txt考试科目1);
            this.Name = "Frm小程序参数";
            this.Text = "小程序参数";
            this.Load += new System.EventHandler(this.Frm小程序参数_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lnk考试科目1;
        private LJH.GeneralLibrary.WinformControl.DBCTextBox txt考试科目1;
        private System.Windows.Forms.DateTimePicker dt报名结束日期;
        private System.Windows.Forms.DateTimePicker dt报名开始日期;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dt成绩查询结束日期;
        private System.Windows.Forms.DateTimePicker dt成绩查询开始日期;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chk启用报名;
        private System.Windows.Forms.CheckBox chk启用成绩查询;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private LJH.GeneralLibrary.WinformControl.DBCTextBox txtName1;
        private LJH.GeneralLibrary.WinformControl.DBCTextBox txtName2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel lnk考试科目2;
        private LJH.GeneralLibrary.WinformControl.DBCTextBox txt考试科目2;
        private LJH.GeneralLibrary.WinformControl.DBCTextBox txtName3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.LinkLabel lnk考试科目3;
        private LJH.GeneralLibrary.WinformControl.DBCTextBox txt考试科目3;
        private LJH.GeneralLibrary.WinformControl.DBCTextBox txt考试科目0;
        private LJH.GeneralLibrary.WinformControl.DBCTextBox txtName0;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private LJH.GeneralLibrary.WinformControl.IntergerTextBox txt选择数量1;
        private LJH.GeneralLibrary.WinformControl.IntergerTextBox txt选择数量2;
        private LJH.GeneralLibrary.WinformControl.IntergerTextBox txt选择数量3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
    }
}