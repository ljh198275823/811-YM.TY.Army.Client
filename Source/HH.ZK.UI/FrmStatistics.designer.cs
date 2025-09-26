namespace HH.ZK.UI
{
    partial class FrmStatistics
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStatistics));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cMnu_SelectColumns = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.chkByDivision = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.chkByGender = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dt结束训练日期 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dt开始训练日期 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProject = new HH.ZK.CommonUI.Controls.PhysicalProjectComboBox(this.components);
            this.ucStudentSearch1 = new HH.ZK.CommonUI.Controls.UCStudentSearch();
            this.txtStudentID1 = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.cmbDivision = new HH.ZK.CommonUI.Controls.DivisionComboBox(this.components);
            this.txtName = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.dbcTextBox1 = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.dbcTextBox2 = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.divisionComboBox1 = new HH.ZK.CommonUI.Controls.DivisionComboBox(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.txt科目 = new System.Windows.Forms.ComboBox();
            this.colDivision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhysicalItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col总人数 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.col完成人数 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.col未测试人数 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.col总成绩 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAverage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col标准差 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col最高成绩 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col最低成绩 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col平均得分 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colManFen = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colManFenRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colYouxiu = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colYouxiuRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLianghao = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colLianghaoRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col优良人数 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.col优良率 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col合格人数 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.col合格率 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col中等人数 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.col中等率 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJige = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colJigeRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBujige = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colBujigeRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.ucStudentSearch1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnColumn
            // 
            this.btnColumn.Location = new System.Drawing.Point(1108, 15);
            this.btnColumn.Size = new System.Drawing.Size(111, 66);
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.Location = new System.Drawing.Point(986, 15);
            this.btnSaveAs.Size = new System.Drawing.Size(111, 66);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(848, 15);
            this.btnSearch.Size = new System.Drawing.Size(111, 66);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeight = 32;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDivision,
            this.colPhysicalItem,
            this.colSex,
            this.col总人数,
            this.col完成人数,
            this.col未测试人数,
            this.col总成绩,
            this.colAverage,
            this.col标准差,
            this.col最高成绩,
            this.col最低成绩,
            this.col平均得分,
            this.colManFen,
            this.colManFenRate,
            this.colYouxiu,
            this.colYouxiuRate,
            this.colLianghao,
            this.colLianghaoRate,
            this.col优良人数,
            this.col优良率,
            this.col合格人数,
            this.col合格率,
            this.col中等人数,
            this.col中等率,
            this.colJige,
            this.colJigeRate,
            this.colBujige,
            this.colBujigeRate});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(0, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("宋体", 10.5F);
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1362, 506);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cMnu_SelectColumns});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(122, 26);
            // 
            // cMnu_SelectColumns
            // 
            this.cMnu_SelectColumns.Name = "cMnu_SelectColumns";
            this.cMnu_SelectColumns.Size = new System.Drawing.Size(121, 22);
            this.cMnu_SelectColumns.Text = "选择列...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(629, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 18;
            this.label1.Text = "科目";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkByDivision
            // 
            this.chkByDivision.AutoSize = true;
            this.chkByDivision.Checked = true;
            this.chkByDivision.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkByDivision.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkByDivision.Location = new System.Drawing.Point(472, 80);
            this.chkByDivision.Name = "chkByDivision";
            this.chkByDivision.Size = new System.Drawing.Size(60, 16);
            this.chkByDivision.TabIndex = 335;
            this.chkByDivision.Text = "分部门";
            this.chkByDivision.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(532, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 12);
            this.label8.TabIndex = 334;
            this.label8.Text = "+";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkByGender
            // 
            this.chkByGender.AutoSize = true;
            this.chkByGender.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkByGender.Location = new System.Drawing.Point(550, 80);
            this.chkByGender.Name = "chkByGender";
            this.chkByGender.Size = new System.Drawing.Size(60, 16);
            this.chkByGender.TabIndex = 333;
            this.chkByGender.Text = "分性别";
            this.chkByGender.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(411, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 332;
            this.label11.Text = "统计方式";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dt结束训练日期
            // 
            this.dt结束训练日期.CustomFormat = "yyyy-MM-dd";
            this.dt结束训练日期.Font = new System.Drawing.Font("宋体", 15F);
            this.dt结束训练日期.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt结束训练日期.Location = new System.Drawing.Point(665, 40);
            this.dt结束训练日期.Name = "dt结束训练日期";
            this.dt结束训练日期.Size = new System.Drawing.Size(152, 30);
            this.dt结束训练日期.TabIndex = 331;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(641, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 330;
            this.label3.Text = "--";
            // 
            // dt开始训练日期
            // 
            this.dt开始训练日期.CustomFormat = "yyyy-MM-dd";
            this.dt开始训练日期.Font = new System.Drawing.Font("宋体", 15F);
            this.dt开始训练日期.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt开始训练日期.Location = new System.Drawing.Point(470, 40);
            this.dt开始训练日期.Name = "dt开始训练日期";
            this.dt开始训练日期.Size = new System.Drawing.Size(152, 30);
            this.dt开始训练日期.TabIndex = 329;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(411, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 328;
            this.label2.Text = "训练日期";
            // 
            // txtProject
            // 
            this.txtProject.Font = new System.Drawing.Font("宋体", 15F);
            this.txtProject.FormattingEnabled = true;
            this.txtProject.Location = new System.Drawing.Point(470, 5);
            this.txtProject.Name = "txtProject";
            this.txtProject.Size = new System.Drawing.Size(152, 28);
            this.txtProject.TabIndex = 327;
            this.txtProject.SelectedIndexChanged += new System.EventHandler(this.txtProject_SelectedIndexChanged);
            // 
            // ucStudentSearch1
            // 
            this.ucStudentSearch1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucStudentSearch1.Controls.Add(this.txtStudentID1);
            this.ucStudentSearch1.Controls.Add(this.cmbDivision);
            this.ucStudentSearch1.Controls.Add(this.txtName);
            this.ucStudentSearch1.Controls.Add(this.dbcTextBox1);
            this.ucStudentSearch1.Controls.Add(this.dbcTextBox2);
            this.ucStudentSearch1.Location = new System.Drawing.Point(4, 0);
            this.ucStudentSearch1.Name = "ucStudentSearch1";
            this.ucStudentSearch1.Size = new System.Drawing.Size(398, 100);
            this.ucStudentSearch1.TabIndex = 326;
            // 
            // txtStudentID1
            // 
            this.txtStudentID1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtStudentID1.Location = new System.Drawing.Point(36, 38);
            this.txtStudentID1.Name = "txtStudentID1";
            this.txtStudentID1.Size = new System.Drawing.Size(166, 21);
            this.txtStudentID1.TabIndex = 283;
            // 
            // cmbDivision
            // 
            this.cmbDivision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDivision.Enabled = false;
            this.cmbDivision.Font = new System.Drawing.Font("宋体", 9F);
            this.cmbDivision.FormattingEnabled = true;
            this.cmbDivision.Location = new System.Drawing.Point(36, 6);
            this.cmbDivision.Name = "cmbDivision";
            this.cmbDivision.Size = new System.Drawing.Size(355, 20);
            this.cmbDivision.TabIndex = 280;
            // 
            // txtName
            // 
            this.txtName.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtName.Location = new System.Drawing.Point(36, 71);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(166, 21);
            this.txtName.TabIndex = 178;
            // 
            // dbcTextBox1
            // 
            this.dbcTextBox1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dbcTextBox1.Location = new System.Drawing.Point(36, 38);
            this.dbcTextBox1.Name = "dbcTextBox1";
            this.dbcTextBox1.Size = new System.Drawing.Size(166, 21);
            this.dbcTextBox1.TabIndex = 283;
            // 
            // dbcTextBox2
            // 
            this.dbcTextBox2.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dbcTextBox2.Location = new System.Drawing.Point(36, 71);
            this.dbcTextBox2.Name = "dbcTextBox2";
            this.dbcTextBox2.Size = new System.Drawing.Size(166, 21);
            this.dbcTextBox2.TabIndex = 178;
            // 
            // divisionComboBox1
            // 
            this.divisionComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.divisionComboBox1.Enabled = false;
            this.divisionComboBox1.Font = new System.Drawing.Font("宋体", 9F);
            this.divisionComboBox1.FormattingEnabled = true;
            this.divisionComboBox1.Location = new System.Drawing.Point(41, 5);
            this.divisionComboBox1.Name = "divisionComboBox1";
            this.divisionComboBox1.Size = new System.Drawing.Size(355, 20);
            this.divisionComboBox1.TabIndex = 325;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(411, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 336;
            this.label4.Text = "训练大纲";
            // 
            // txt科目
            // 
            this.txt科目.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt科目.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt科目.FormattingEnabled = true;
            this.txt科目.Location = new System.Drawing.Point(665, 5);
            this.txt科目.Name = "txt科目";
            this.txt科目.Size = new System.Drawing.Size(152, 28);
            this.txt科目.TabIndex = 337;
            // 
            // colDivision
            // 
            this.colDivision.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colDivision.HeaderText = "部门";
            this.colDivision.MinimumWidth = 100;
            this.colDivision.Name = "colDivision";
            this.colDivision.ReadOnly = true;
            // 
            // colPhysicalItem
            // 
            this.colPhysicalItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colPhysicalItem.HeaderText = "考试科目";
            this.colPhysicalItem.MinimumWidth = 100;
            this.colPhysicalItem.Name = "colPhysicalItem";
            this.colPhysicalItem.ReadOnly = true;
            // 
            // colSex
            // 
            this.colSex.HeaderText = "性别";
            this.colSex.Name = "colSex";
            this.colSex.ReadOnly = true;
            this.colSex.Width = 60;
            // 
            // col总人数
            // 
            this.col总人数.HeaderText = "总人数";
            this.col总人数.Name = "col总人数";
            this.col总人数.ReadOnly = true;
            this.col总人数.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col总人数.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col总人数.Width = 80;
            // 
            // col完成人数
            // 
            this.col完成人数.HeaderText = "已考人数";
            this.col完成人数.Name = "col完成人数";
            this.col完成人数.ReadOnly = true;
            this.col完成人数.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col完成人数.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col完成人数.Width = 80;
            // 
            // col未测试人数
            // 
            this.col未测试人数.HeaderText = "未测人数";
            this.col未测试人数.Name = "col未测试人数";
            this.col未测试人数.ReadOnly = true;
            this.col未测试人数.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col未测试人数.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col未测试人数.Width = 80;
            // 
            // col总成绩
            // 
            this.col总成绩.HeaderText = "总成绩";
            this.col总成绩.Name = "col总成绩";
            this.col总成绩.ReadOnly = true;
            this.col总成绩.Width = 80;
            // 
            // colAverage
            // 
            this.colAverage.HeaderText = "平均成绩";
            this.colAverage.Name = "colAverage";
            this.colAverage.ReadOnly = true;
            this.colAverage.Width = 80;
            // 
            // col标准差
            // 
            this.col标准差.HeaderText = "标准差";
            this.col标准差.Name = "col标准差";
            this.col标准差.ReadOnly = true;
            this.col标准差.Visible = false;
            this.col标准差.Width = 80;
            // 
            // col最高成绩
            // 
            this.col最高成绩.HeaderText = "最高成绩";
            this.col最高成绩.Name = "col最高成绩";
            this.col最高成绩.ReadOnly = true;
            this.col最高成绩.Width = 80;
            // 
            // col最低成绩
            // 
            this.col最低成绩.HeaderText = "最低成绩";
            this.col最低成绩.Name = "col最低成绩";
            this.col最低成绩.ReadOnly = true;
            this.col最低成绩.Width = 80;
            // 
            // col平均得分
            // 
            dataGridViewCellStyle1.Format = "N2";
            this.col平均得分.DefaultCellStyle = dataGridViewCellStyle1;
            this.col平均得分.HeaderText = "平均得分";
            this.col平均得分.Name = "col平均得分";
            this.col平均得分.ReadOnly = true;
            this.col平均得分.Width = 80;
            // 
            // colManFen
            // 
            this.colManFen.HeaderText = "满分人数";
            this.colManFen.Name = "colManFen";
            this.colManFen.ReadOnly = true;
            this.colManFen.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colManFen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colManFen.Width = 80;
            // 
            // colManFenRate
            // 
            dataGridViewCellStyle2.Format = "P2";
            this.colManFenRate.DefaultCellStyle = dataGridViewCellStyle2;
            this.colManFenRate.HeaderText = "满分率";
            this.colManFenRate.Name = "colManFenRate";
            this.colManFenRate.ReadOnly = true;
            this.colManFenRate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colManFenRate.Width = 80;
            // 
            // colYouxiu
            // 
            this.colYouxiu.HeaderText = "优秀人数";
            this.colYouxiu.Name = "colYouxiu";
            this.colYouxiu.ReadOnly = true;
            this.colYouxiu.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colYouxiu.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colYouxiu.Width = 80;
            // 
            // colYouxiuRate
            // 
            dataGridViewCellStyle3.Format = "P2";
            this.colYouxiuRate.DefaultCellStyle = dataGridViewCellStyle3;
            this.colYouxiuRate.HeaderText = "优秀率";
            this.colYouxiuRate.Name = "colYouxiuRate";
            this.colYouxiuRate.ReadOnly = true;
            this.colYouxiuRate.Width = 80;
            // 
            // colLianghao
            // 
            this.colLianghao.HeaderText = "良好人数";
            this.colLianghao.Name = "colLianghao";
            this.colLianghao.ReadOnly = true;
            this.colLianghao.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colLianghao.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colLianghao.Width = 80;
            // 
            // colLianghaoRate
            // 
            dataGridViewCellStyle4.Format = "P2";
            this.colLianghaoRate.DefaultCellStyle = dataGridViewCellStyle4;
            this.colLianghaoRate.HeaderText = "良好率";
            this.colLianghaoRate.Name = "colLianghaoRate";
            this.colLianghaoRate.ReadOnly = true;
            this.colLianghaoRate.Width = 80;
            // 
            // col优良人数
            // 
            this.col优良人数.HeaderText = "优良人数";
            this.col优良人数.Name = "col优良人数";
            this.col优良人数.ReadOnly = true;
            this.col优良人数.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col优良人数.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col优良人数.Width = 80;
            // 
            // col优良率
            // 
            dataGridViewCellStyle5.Format = "P2";
            this.col优良率.DefaultCellStyle = dataGridViewCellStyle5;
            this.col优良率.HeaderText = "优良率";
            this.col优良率.Name = "col优良率";
            this.col优良率.ReadOnly = true;
            this.col优良率.Width = 80;
            // 
            // col合格人数
            // 
            this.col合格人数.HeaderText = "合格人数";
            this.col合格人数.Name = "col合格人数";
            this.col合格人数.ReadOnly = true;
            this.col合格人数.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col合格人数.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col合格人数.Width = 80;
            // 
            // col合格率
            // 
            dataGridViewCellStyle6.Format = "P2";
            this.col合格率.DefaultCellStyle = dataGridViewCellStyle6;
            this.col合格率.HeaderText = "合格率";
            this.col合格率.Name = "col合格率";
            this.col合格率.ReadOnly = true;
            this.col合格率.Width = 80;
            // 
            // col中等人数
            // 
            this.col中等人数.HeaderText = "中等人数";
            this.col中等人数.Name = "col中等人数";
            this.col中等人数.ReadOnly = true;
            this.col中等人数.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col中等人数.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col中等人数.Width = 80;
            // 
            // col中等率
            // 
            dataGridViewCellStyle7.Format = "P2";
            this.col中等率.DefaultCellStyle = dataGridViewCellStyle7;
            this.col中等率.HeaderText = "中等率";
            this.col中等率.Name = "col中等率";
            this.col中等率.ReadOnly = true;
            this.col中等率.Width = 80;
            // 
            // colJige
            // 
            this.colJige.HeaderText = "及格人数";
            this.colJige.Name = "colJige";
            this.colJige.ReadOnly = true;
            this.colJige.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colJige.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colJige.Width = 80;
            // 
            // colJigeRate
            // 
            dataGridViewCellStyle8.Format = "P2";
            this.colJigeRate.DefaultCellStyle = dataGridViewCellStyle8;
            this.colJigeRate.HeaderText = "及格率";
            this.colJigeRate.Name = "colJigeRate";
            this.colJigeRate.ReadOnly = true;
            this.colJigeRate.Width = 80;
            // 
            // colBujige
            // 
            this.colBujige.HeaderText = "不及格人数";
            this.colBujige.Name = "colBujige";
            this.colBujige.ReadOnly = true;
            this.colBujige.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colBujige.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colBujige.Width = 90;
            // 
            // colBujigeRate
            // 
            dataGridViewCellStyle9.Format = "P2";
            this.colBujigeRate.DefaultCellStyle = dataGridViewCellStyle9;
            this.colBujigeRate.HeaderText = "不及格率";
            this.colBujigeRate.Name = "colBujigeRate";
            this.colBujigeRate.ReadOnly = true;
            this.colBujigeRate.Width = 80;
            // 
            // FrmStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 639);
            this.Controls.Add(this.txt科目);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chkByDivision);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.chkByGender);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dt结束训练日期);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dt开始训练日期);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProject);
            this.Controls.Add(this.ucStudentSearch1);
            this.Controls.Add(this.divisionComboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmStatistics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "单项成绩统计报表";
            this.Controls.SetChildIndex(this.btnSearch, 0);
            this.Controls.SetChildIndex(this.btnSaveAs, 0);
            this.Controls.SetChildIndex(this.btnColumn, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.divisionComboBox1, 0);
            this.Controls.SetChildIndex(this.ucStudentSearch1, 0);
            this.Controls.SetChildIndex(this.txtProject, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.dt开始训练日期, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.dt结束训练日期, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.chkByGender, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.chkByDivision, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txt科目, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ucStudentSearch1.ResumeLayout(false);
            this.ucStudentSearch1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cMnu_SelectColumns;
        private System.Windows.Forms.CheckBox chkByDivision;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chkByGender;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dt结束训练日期;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dt开始训练日期;
        private System.Windows.Forms.Label label2;
        private CommonUI.Controls.PhysicalProjectComboBox txtProject;
        private CommonUI.Controls.UCStudentSearch ucStudentSearch1;
        private LJH.GeneralLibrary.WinformControl.DBCTextBox txtStudentID1;
        private CommonUI.Controls.DivisionComboBox cmbDivision;
        private LJH.GeneralLibrary.WinformControl.DBCTextBox txtName;
        private LJH.GeneralLibrary.WinformControl.DBCTextBox dbcTextBox1;
        private LJH.GeneralLibrary.WinformControl.DBCTextBox dbcTextBox2;
        private CommonUI.Controls.DivisionComboBox divisionComboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox txt科目;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDivision;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhysicalItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSex;
        private System.Windows.Forms.DataGridViewLinkColumn col总人数;
        private System.Windows.Forms.DataGridViewLinkColumn col完成人数;
        private System.Windows.Forms.DataGridViewLinkColumn col未测试人数;
        private System.Windows.Forms.DataGridViewTextBoxColumn col总成绩;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAverage;
        private System.Windows.Forms.DataGridViewTextBoxColumn col标准差;
        private System.Windows.Forms.DataGridViewTextBoxColumn col最高成绩;
        private System.Windows.Forms.DataGridViewTextBoxColumn col最低成绩;
        private System.Windows.Forms.DataGridViewTextBoxColumn col平均得分;
        private System.Windows.Forms.DataGridViewLinkColumn colManFen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colManFenRate;
        private System.Windows.Forms.DataGridViewLinkColumn colYouxiu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colYouxiuRate;
        private System.Windows.Forms.DataGridViewLinkColumn colLianghao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLianghaoRate;
        private System.Windows.Forms.DataGridViewLinkColumn col优良人数;
        private System.Windows.Forms.DataGridViewTextBoxColumn col优良率;
        private System.Windows.Forms.DataGridViewLinkColumn col合格人数;
        private System.Windows.Forms.DataGridViewTextBoxColumn col合格率;
        private System.Windows.Forms.DataGridViewLinkColumn col中等人数;
        private System.Windows.Forms.DataGridViewTextBoxColumn col中等率;
        private System.Windows.Forms.DataGridViewLinkColumn colJige;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJigeRate;
        private System.Windows.Forms.DataGridViewLinkColumn colBujige;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBujigeRate;
    }
}