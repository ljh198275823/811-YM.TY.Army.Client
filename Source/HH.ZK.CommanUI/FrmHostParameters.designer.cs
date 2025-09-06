namespace HH.ZK.CommonUI
{
    partial class FrmHostParameters
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chk按键学号输入_人工确认 = new System.Windows.Forms.CheckBox();
            this.txt按键学号输入_递增间隔 = new LJH.GeneralLibrary.WinformControl.IntergerTextBox(this.components);
            this.txt按键学号输入_学号最大长度 = new LJH.GeneralLibrary.WinformControl.IntergerTextBox(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmb输入设备_IC卡物理号 = new System.Windows.Forms.ComboBox();
            this.cmb输入设备_扫描枪或身份证 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chk测试结果_LED屏上显示 = new System.Windows.Forms.CheckBox();
            this.chk测试结果_写入IC卡 = new System.Windows.Forms.CheckBox();
            this.cmb测试结果_确认方式 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chk辅助设备_红外防枪跑器 = new System.Windows.Forms.CheckBox();
            this.cmb辅助设备_无线音箱 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txt测试限制_总时间 = new LJH.GeneralLibrary.WinformControl.IntergerTextBox(this.components);
            this.cmb测试限制_进行方式 = new System.Windows.Forms.ComboBox();
            this.txt测试限制_测试次数 = new LJH.GeneralLibrary.WinformControl.IntergerTextBox(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.chk标签式中长跑_分组测试 = new System.Windows.Forms.CheckBox();
            this.txt标签式中长跑_圈数设定 = new LJH.GeneralLibrary.WinformControl.IntergerTextBox(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.chk地毯式中长跑_分组测试 = new System.Windows.Forms.CheckBox();
            this.txt地毯式中长跑_女生测试长度 = new LJH.GeneralLibrary.WinformControl.IntergerTextBox(this.components);
            this.label17 = new System.Windows.Forms.Label();
            this.txt地毯式中长跑_男生测试长度 = new LJH.GeneralLibrary.WinformControl.IntergerTextBox(this.components);
            this.label16 = new System.Windows.Forms.Label();
            this.txt地毯式中长跑_跑道长度 = new LJH.GeneralLibrary.WinformControl.IntergerTextBox(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.cmb短跑系列_项目选择 = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cmb仰卧起坐_躺平模式 = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt引体向上_难度系数 = new LJH.GeneralLibrary.WinformControl.IntergerTextBox(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblMsg = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "学号最大长度（1-20）";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chk按键学号输入_人工确认);
            this.groupBox1.Controls.Add(this.txt按键学号输入_递增间隔);
            this.groupBox1.Controls.Add(this.txt按键学号输入_学号最大长度);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(11, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(546, 56);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "按键学号输入";
            // 
            // chk按键学号输入_人工确认
            // 
            this.chk按键学号输入_人工确认.AutoSize = true;
            this.chk按键学号输入_人工确认.Location = new System.Drawing.Point(431, 24);
            this.chk按键学号输入_人工确认.Name = "chk按键学号输入_人工确认";
            this.chk按键学号输入_人工确认.Size = new System.Drawing.Size(72, 16);
            this.chk按键学号输入_人工确认.TabIndex = 7;
            this.chk按键学号输入_人工确认.Text = "人工确认";
            this.chk按键学号输入_人工确认.UseVisualStyleBackColor = true;
            // 
            // txt按键学号输入_递增间隔
            // 
            this.txt按键学号输入_递增间隔.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txt按键学号输入_递增间隔.Location = new System.Drawing.Point(319, 22);
            this.txt按键学号输入_递增间隔.MaxValue = 10;
            this.txt按键学号输入_递增间隔.MinValue = 0;
            this.txt按键学号输入_递增间隔.Name = "txt按键学号输入_递增间隔";
            this.txt按键学号输入_递增间隔.Size = new System.Drawing.Size(48, 21);
            this.txt按键学号输入_递增间隔.TabIndex = 3;
            this.txt按键学号输入_递增间隔.Text = "1";
            // 
            // txt按键学号输入_学号最大长度
            // 
            this.txt按键学号输入_学号最大长度.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txt按键学号输入_学号最大长度.Location = new System.Drawing.Point(142, 22);
            this.txt按键学号输入_学号最大长度.MaxValue = 20;
            this.txt按键学号输入_学号最大长度.MinValue = 1;
            this.txt按键学号输入_学号最大长度.Name = "txt按键学号输入_学号最大长度";
            this.txt按键学号输入_学号最大长度.Size = new System.Drawing.Size(48, 21);
            this.txt按键学号输入_学号最大长度.TabIndex = 2;
            this.txt按键学号输入_学号最大长度.Text = "20";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "递增间隔(0-10)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmb输入设备_IC卡物理号);
            this.groupBox2.Controls.Add(this.cmb输入设备_扫描枪或身份证);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(11, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(546, 56);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "输入设备";
            // 
            // cmb输入设备_IC卡物理号
            // 
            this.cmb输入设备_IC卡物理号.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb输入设备_IC卡物理号.FormattingEnabled = true;
            this.cmb输入设备_IC卡物理号.Items.AddRange(new object[] {
            "从左到右",
            "从右到左"});
            this.cmb输入设备_IC卡物理号.Location = new System.Drawing.Point(321, 23);
            this.cmb输入设备_IC卡物理号.Name = "cmb输入设备_IC卡物理号";
            this.cmb输入设备_IC卡物理号.Size = new System.Drawing.Size(114, 20);
            this.cmb输入设备_IC卡物理号.TabIndex = 3;
            // 
            // cmb输入设备_扫描枪或身份证
            // 
            this.cmb输入设备_扫描枪或身份证.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb输入设备_扫描枪或身份证.FormattingEnabled = true;
            this.cmb输入设备_扫描枪或身份证.Items.AddRange(new object[] {
            "扫描枪",
            "身份证读卡器",
            "其它"});
            this.cmb输入设备_扫描枪或身份证.Location = new System.Drawing.Point(81, 23);
            this.cmb输入设备_扫描枪或身份证.Name = "cmb输入设备_扫描枪或身份证";
            this.cmb输入设备_扫描枪或身份证.Size = new System.Drawing.Size(109, 20);
            this.cmb输入设备_扫描枪或身份证.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(223, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "IC卡物理号读取";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "输入设备";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chk测试结果_LED屏上显示);
            this.groupBox3.Controls.Add(this.chk测试结果_写入IC卡);
            this.groupBox3.Controls.Add(this.cmb测试结果_确认方式);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(11, 149);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(546, 56);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "测试结果";
            // 
            // chk测试结果_LED屏上显示
            // 
            this.chk测试结果_LED屏上显示.AutoSize = true;
            this.chk测试结果_LED屏上显示.Location = new System.Drawing.Point(340, 28);
            this.chk测试结果_LED屏上显示.Name = "chk测试结果_LED屏上显示";
            this.chk测试结果_LED屏上显示.Size = new System.Drawing.Size(102, 16);
            this.chk测试结果_LED屏上显示.TabIndex = 6;
            this.chk测试结果_LED屏上显示.Text = "在LED屏上显示";
            this.chk测试结果_LED屏上显示.UseVisualStyleBackColor = true;
            // 
            // chk测试结果_写入IC卡
            // 
            this.chk测试结果_写入IC卡.AutoSize = true;
            this.chk测试结果_写入IC卡.Location = new System.Drawing.Point(227, 28);
            this.chk测试结果_写入IC卡.Name = "chk测试结果_写入IC卡";
            this.chk测试结果_写入IC卡.Size = new System.Drawing.Size(72, 16);
            this.chk测试结果_写入IC卡.TabIndex = 5;
            this.chk测试结果_写入IC卡.Text = "写入IC卡";
            this.chk测试结果_写入IC卡.UseVisualStyleBackColor = true;
            // 
            // cmb测试结果_确认方式
            // 
            this.cmb测试结果_确认方式.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb测试结果_确认方式.FormattingEnabled = true;
            this.cmb测试结果_确认方式.Items.AddRange(new object[] {
            "自动确认",
            "人工确认"});
            this.cmb测试结果_确认方式.Location = new System.Drawing.Point(81, 25);
            this.cmb测试结果_确认方式.Name = "cmb测试结果_确认方式";
            this.cmb测试结果_确认方式.Size = new System.Drawing.Size(109, 20);
            this.cmb测试结果_确认方式.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "确认方式";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chk辅助设备_红外防枪跑器);
            this.groupBox4.Controls.Add(this.cmb辅助设备_无线音箱);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(11, 212);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(546, 56);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "辅助设备";
            // 
            // chk辅助设备_红外防枪跑器
            // 
            this.chk辅助设备_红外防枪跑器.AutoSize = true;
            this.chk辅助设备_红外防枪跑器.Location = new System.Drawing.Point(227, 28);
            this.chk辅助设备_红外防枪跑器.Name = "chk辅助设备_红外防枪跑器";
            this.chk辅助设备_红外防枪跑器.Size = new System.Drawing.Size(120, 16);
            this.chk辅助设备_红外防枪跑器.TabIndex = 5;
            this.chk辅助设备_红外防枪跑器.Text = "使用红外防枪跑器";
            this.chk辅助设备_红外防枪跑器.UseVisualStyleBackColor = true;
            // 
            // cmb辅助设备_无线音箱
            // 
            this.cmb辅助设备_无线音箱.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb辅助设备_无线音箱.FormattingEnabled = true;
            this.cmb辅助设备_无线音箱.Items.AddRange(new object[] {
            "不使用",
            "发令枪",
            "防抢跑发令枪"});
            this.cmb辅助设备_无线音箱.Location = new System.Drawing.Point(81, 25);
            this.cmb辅助设备_无线音箱.Name = "cmb辅助设备_无线音箱";
            this.cmb辅助设备_无线音箱.Size = new System.Drawing.Size(109, 20);
            this.cmb辅助设备_无线音箱.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "无线音箱";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txt测试限制_总时间);
            this.groupBox5.Controls.Add(this.cmb测试限制_进行方式);
            this.groupBox5.Controls.Add(this.txt测试限制_测试次数);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Location = new System.Drawing.Point(11, 277);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(546, 56);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "测试限制";
            // 
            // txt测试限制_总时间
            // 
            this.txt测试限制_总时间.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txt测试限制_总时间.Location = new System.Drawing.Point(301, 22);
            this.txt测试限制_总时间.MaxValue = 65535;
            this.txt测试限制_总时间.MinValue = 0;
            this.txt测试限制_总时间.Name = "txt测试限制_总时间";
            this.txt测试限制_总时间.Size = new System.Drawing.Size(61, 21);
            this.txt测试限制_总时间.TabIndex = 3;
            this.txt测试限制_总时间.Text = "0";
            // 
            // cmb测试限制_进行方式
            // 
            this.cmb测试限制_进行方式.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb测试限制_进行方式.FormattingEnabled = true;
            this.cmb测试限制_进行方式.Items.AddRange(new object[] {
            "主机统一口令",
            "外设自动完成"});
            this.cmb测试限制_进行方式.Location = new System.Drawing.Point(431, 22);
            this.cmb测试限制_进行方式.Name = "cmb测试限制_进行方式";
            this.cmb测试限制_进行方式.Size = new System.Drawing.Size(109, 20);
            this.cmb测试限制_进行方式.TabIndex = 6;
            // 
            // txt测试限制_测试次数
            // 
            this.txt测试限制_测试次数.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txt测试限制_测试次数.Location = new System.Drawing.Point(111, 22);
            this.txt测试限制_测试次数.MaxValue = 5;
            this.txt测试限制_测试次数.MinValue = 1;
            this.txt测试限制_测试次数.Name = "txt测试限制_测试次数";
            this.txt测试限制_测试次数.Size = new System.Drawing.Size(69, 21);
            this.txt测试限制_测试次数.TabIndex = 2;
            this.txt测试限制_测试次数.Text = "1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(372, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 5;
            this.label9.Text = "进行方式";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(194, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "总时间(0-65535秒)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "测试次数(1-5)";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(577, 369);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(569, 343);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "基本";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.groupBox9);
            this.tabPage2.Controls.Add(this.groupBox8);
            this.tabPage2.Controls.Add(this.groupBox7);
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(569, 343);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "高级";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.chk标签式中长跑_分组测试);
            this.groupBox9.Controls.Add(this.txt标签式中长跑_圈数设定);
            this.groupBox9.Controls.Add(this.label12);
            this.groupBox9.Location = new System.Drawing.Point(11, 242);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(546, 56);
            this.groupBox9.TabIndex = 5;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "标签式中长跑";
            // 
            // chk标签式中长跑_分组测试
            // 
            this.chk标签式中长跑_分组测试.AutoSize = true;
            this.chk标签式中长跑_分组测试.ForeColor = System.Drawing.Color.Red;
            this.chk标签式中长跑_分组测试.Location = new System.Drawing.Point(263, 24);
            this.chk标签式中长跑_分组测试.Name = "chk标签式中长跑_分组测试";
            this.chk标签式中长跑_分组测试.Size = new System.Drawing.Size(72, 16);
            this.chk标签式中长跑_分组测试.TabIndex = 8;
            this.chk标签式中长跑_分组测试.Text = "分组测试";
            this.chk标签式中长跑_分组测试.UseVisualStyleBackColor = true;
            // 
            // txt标签式中长跑_圈数设定
            // 
            this.txt标签式中长跑_圈数设定.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txt标签式中长跑_圈数设定.Location = new System.Drawing.Point(124, 22);
            this.txt标签式中长跑_圈数设定.MaxValue = 250;
            this.txt标签式中长跑_圈数设定.MinValue = 1;
            this.txt标签式中长跑_圈数设定.Name = "txt标签式中长跑_圈数设定";
            this.txt标签式中长跑_圈数设定.Size = new System.Drawing.Size(92, 21);
            this.txt标签式中长跑_圈数设定.TabIndex = 2;
            this.txt标签式中长跑_圈数设定.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 12);
            this.label12.TabIndex = 0;
            this.label12.Text = "圈数设定（1-250）";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.chk地毯式中长跑_分组测试);
            this.groupBox8.Controls.Add(this.txt地毯式中长跑_女生测试长度);
            this.groupBox8.Controls.Add(this.label17);
            this.groupBox8.Controls.Add(this.txt地毯式中长跑_男生测试长度);
            this.groupBox8.Controls.Add(this.label16);
            this.groupBox8.Controls.Add(this.txt地毯式中长跑_跑道长度);
            this.groupBox8.Controls.Add(this.label10);
            this.groupBox8.Location = new System.Drawing.Point(11, 142);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(546, 80);
            this.groupBox8.TabIndex = 4;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "地毯式中长跑";
            // 
            // chk地毯式中长跑_分组测试
            // 
            this.chk地毯式中长跑_分组测试.AutoSize = true;
            this.chk地毯式中长跑_分组测试.ForeColor = System.Drawing.Color.Red;
            this.chk地毯式中长跑_分组测试.Location = new System.Drawing.Point(24, 56);
            this.chk地毯式中长跑_分组测试.Name = "chk地毯式中长跑_分组测试";
            this.chk地毯式中长跑_分组测试.Size = new System.Drawing.Size(72, 16);
            this.chk地毯式中长跑_分组测试.TabIndex = 7;
            this.chk地毯式中长跑_分组测试.Text = "分组测试";
            this.chk地毯式中长跑_分组测试.UseVisualStyleBackColor = true;
            // 
            // txt地毯式中长跑_女生测试长度
            // 
            this.txt地毯式中长跑_女生测试长度.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txt地毯式中长跑_女生测试长度.Location = new System.Drawing.Point(444, 22);
            this.txt地毯式中长跑_女生测试长度.MaxValue = 50000;
            this.txt地毯式中长跑_女生测试长度.MinValue = 1;
            this.txt地毯式中长跑_女生测试长度.Name = "txt地毯式中长跑_女生测试长度";
            this.txt地毯式中长跑_女生测试长度.Size = new System.Drawing.Size(69, 21);
            this.txt地毯式中长跑_女生测试长度.TabIndex = 6;
            this.txt地毯式中长跑_女生测试长度.Text = "0";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(364, 26);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(77, 12);
            this.label17.TabIndex = 5;
            this.label17.Text = "女生测试长度";
            // 
            // txt地毯式中长跑_男生测试长度
            // 
            this.txt地毯式中长跑_男生测试长度.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txt地毯式中长跑_男生测试长度.Location = new System.Drawing.Point(271, 22);
            this.txt地毯式中长跑_男生测试长度.MaxValue = 50000;
            this.txt地毯式中长跑_男生测试长度.MinValue = 1;
            this.txt地毯式中长跑_男生测试长度.Name = "txt地毯式中长跑_男生测试长度";
            this.txt地毯式中长跑_男生测试长度.Size = new System.Drawing.Size(69, 21);
            this.txt地毯式中长跑_男生测试长度.TabIndex = 4;
            this.txt地毯式中长跑_男生测试长度.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(191, 26);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 12);
            this.label16.TabIndex = 3;
            this.label16.Text = "男生测试长度";
            // 
            // txt地毯式中长跑_跑道长度
            // 
            this.txt地毯式中长跑_跑道长度.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txt地毯式中长跑_跑道长度.Location = new System.Drawing.Point(102, 22);
            this.txt地毯式中长跑_跑道长度.MaxValue = 1000;
            this.txt地毯式中长跑_跑道长度.MinValue = 1;
            this.txt地毯式中长跑_跑道长度.Name = "txt地毯式中长跑_跑道长度";
            this.txt地毯式中长跑_跑道长度.Size = new System.Drawing.Size(69, 21);
            this.txt地毯式中长跑_跑道长度.TabIndex = 2;
            this.txt地毯式中长跑_跑道长度.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "跑道长度(米)";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.cmb短跑系列_项目选择);
            this.groupBox7.Controls.Add(this.label15);
            this.groupBox7.Location = new System.Drawing.Point(6, 72);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(546, 56);
            this.groupBox7.TabIndex = 3;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "短跑系列";
            // 
            // cmb短跑系列_项目选择
            // 
            this.cmb短跑系列_项目选择.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb短跑系列_项目选择.FormattingEnabled = true;
            this.cmb短跑系列_项目选择.Items.AddRange(new object[] {
            "无",
            "50米(限时20秒)\t",
            "60米(限时20秒)\t",
            "100米(限时30秒) ",
            "100米跨栏(限时30秒)",
            "110米跨栏(限时30秒)",
            "200米(限时40秒)",
            "400米(限时120秒)",
            "100米(限时120秒)"});
            this.cmb短跑系列_项目选择.Location = new System.Drawing.Point(103, 25);
            this.cmb短跑系列_项目选择.Name = "cmb短跑系列_项目选择";
            this.cmb短跑系列_项目选择.Size = new System.Drawing.Size(151, 20);
            this.cmb短跑系列_项目选择.TabIndex = 6;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(22, 29);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 12);
            this.label15.TabIndex = 5;
            this.label15.Text = "短跑项目选择";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cmb仰卧起坐_躺平模式);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.txt引体向上_难度系数);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Location = new System.Drawing.Point(6, 10);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(546, 56);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "引体向上/仰卧起坐";
            // 
            // cmb仰卧起坐_躺平模式
            // 
            this.cmb仰卧起坐_躺平模式.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb仰卧起坐_躺平模式.FormattingEnabled = true;
            this.cmb仰卧起坐_躺平模式.Items.AddRange(new object[] {
            "人工确定躺平",
            "机器确定躺平"});
            this.cmb仰卧起坐_躺平模式.Location = new System.Drawing.Point(373, 23);
            this.cmb仰卧起坐_躺平模式.Name = "cmb仰卧起坐_躺平模式";
            this.cmb仰卧起坐_躺平模式.Size = new System.Drawing.Size(114, 20);
            this.cmb仰卧起坐_躺平模式.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(266, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(101, 12);
            this.label14.TabIndex = 3;
            this.label14.Text = "仰卧起坐躺平模式";
            // 
            // txt引体向上_难度系数
            // 
            this.txt引体向上_难度系数.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txt引体向上_难度系数.Location = new System.Drawing.Point(163, 22);
            this.txt引体向上_难度系数.MaxValue = 5;
            this.txt引体向上_难度系数.MinValue = 1;
            this.txt引体向上_难度系数.Name = "txt引体向上_难度系数";
            this.txt引体向上_难度系数.Size = new System.Drawing.Size(69, 21);
            this.txt引体向上_难度系数.TabIndex = 2;
            this.txt引体向上_难度系数.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(143, 12);
            this.label11.TabIndex = 0;
            this.label11.Text = "引体向上难度系数（1-5）";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(449, 396);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(119, 34);
            this.btnCancel.TabIndex = 88;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(303, 396);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(119, 34);
            this.btnOk.TabIndex = 87;
            this.btnOk.Text = "确定(&O)";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMsg.ForeColor = System.Drawing.Color.Red;
            this.lblMsg.Location = new System.Drawing.Point(117, 405);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(127, 16);
            this.lblMsg.TabIndex = 90;
            this.lblMsg.Text = "参数设置失败！";
            // 
            // FrmHostParameters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 455);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmHostParameters";
            this.Text = "主机参数设置";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmHostParameters_FormClosing);
            this.Load += new System.EventHandler(this.FrmHostParameters_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private LJH.GeneralLibrary.WinformControl.IntergerTextBox txt按键学号输入_递增间隔;
        private LJH.GeneralLibrary.WinformControl.IntergerTextBox txt按键学号输入_学号最大长度;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb输入设备_IC卡物理号;
        private System.Windows.Forms.ComboBox cmb输入设备_扫描枪或身份证;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmb测试结果_确认方式;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chk测试结果_写入IC卡;
        private System.Windows.Forms.CheckBox chk测试结果_LED屏上显示;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox chk辅助设备_红外防枪跑器;
        private System.Windows.Forms.ComboBox cmb辅助设备_无线音箱;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox5;
        private LJH.GeneralLibrary.WinformControl.IntergerTextBox txt测试限制_总时间;
        private LJH.GeneralLibrary.WinformControl.IntergerTextBox txt测试限制_测试次数;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmb测试限制_进行方式;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.GroupBox groupBox6;
        private LJH.GeneralLibrary.WinformControl.IntergerTextBox txt引体向上_难度系数;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox8;
        private LJH.GeneralLibrary.WinformControl.IntergerTextBox txt地毯式中长跑_跑道长度;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox9;
        private LJH.GeneralLibrary.WinformControl.IntergerTextBox txt标签式中长跑_圈数设定;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmb仰卧起坐_躺平模式;
        private System.Windows.Forms.ComboBox cmb短跑系列_项目选择;
        private System.Windows.Forms.Label label15;
        private LJH.GeneralLibrary.WinformControl.IntergerTextBox txt地毯式中长跑_女生测试长度;
        private System.Windows.Forms.Label label17;
        private LJH.GeneralLibrary.WinformControl.IntergerTextBox txt地毯式中长跑_男生测试长度;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox chk地毯式中长跑_分组测试;
        private System.Windows.Forms.CheckBox chk标签式中长跑_分组测试;
        private System.Windows.Forms.CheckBox chk按键学号输入_人工确认;
        private System.Windows.Forms.Label lblMsg;
    }
}