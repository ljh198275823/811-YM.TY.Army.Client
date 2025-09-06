namespace HH.ZK.UI
{
    partial class Frm学生成绩单导出
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm学生成绩单导出));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ucStudentSearch1 = new HH.ZK.CommonUI.Controls.UCStudentSearch();
            this.txtStudentID1 = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.cmbDivision = new HH.ZK.CommonUI.Controls.DivisionComboBox(this.components);
            this.txtGroupID = new HH.ZK.CommonUI.Controls.StudentGroupComboBox(this.components);
            this.cmbFacility = new HH.ZK.CommonUI.Controls.FacilityComboBox(this.components);
            this.txtName = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.btnQuery = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colFacility = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrinted = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col考试科目 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col加分 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col总分 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnu取消打印状态 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rd所有特殊状态 = new System.Windows.Forms.RadioButton();
            this.rd指定状态 = new System.Windows.Forms.RadioButton();
            this.rd不限状态 = new System.Windows.Forms.RadioButton();
            this.txt考试状态 = new HH.ZK.CommonUI.Controls.StudentStateComboBox(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.rd全部 = new System.Windows.Forms.RadioButton();
            this.rd测试完成 = new System.Windows.Forms.RadioButton();
            this.rd未测试 = new System.Windows.Forms.RadioButton();
            this.rd没有完成测试 = new System.Windows.Forms.RadioButton();
            this.txtClassName = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rd打印All = new System.Windows.Forms.RadioButton();
            this.rd已打印 = new System.Windows.Forms.RadioButton();
            this.rd未打印 = new System.Windows.Forms.RadioButton();
            this.gpStudent = new System.Windows.Forms.GroupBox();
            this.btnModalBrowser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtModelFile = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.btnExport = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl选择数量 = new System.Windows.Forms.Label();
            this.txtInterval = new LJH.GeneralLibrary.WinformControl.IntergerTextBox(this.components);
            this.btnNone = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAll = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn数据另存为 = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.ucStudentSearch1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.gpStudent.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 495);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1354, 22);
            this.statusStrip1.TabIndex = 159;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(1339, 17);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = "总共 0 项";
            // 
            // ucStudentSearch1
            // 
            this.ucStudentSearch1.Controls.Add(this.txtStudentID1);
            this.ucStudentSearch1.Controls.Add(this.cmbDivision);
            this.ucStudentSearch1.Controls.Add(this.txtGroupID);
            this.ucStudentSearch1.Controls.Add(this.cmbFacility);
            this.ucStudentSearch1.Controls.Add(this.txtName);
            this.ucStudentSearch1.Location = new System.Drawing.Point(5, 3);
            this.ucStudentSearch1.Name = "ucStudentSearch1";
            this.ucStudentSearch1.Size = new System.Drawing.Size(562, 100);
            this.ucStudentSearch1.TabIndex = 180;
            // 
            // txtStudentID1
            // 
            this.txtStudentID1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtStudentID1.Location = new System.Drawing.Point(387, 6);
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
            this.cmbDivision.Size = new System.Drawing.Size(312, 20);
            this.cmbDivision.TabIndex = 280;
            // 
            // txtGroupID
            // 
            this.txtGroupID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtGroupID.Enabled = false;
            this.txtGroupID.FormattingEnabled = true;
            this.txtGroupID.Location = new System.Drawing.Point(36, 72);
            this.txtGroupID.Name = "txtGroupID";
            this.txtGroupID.Size = new System.Drawing.Size(312, 20);
            this.txtGroupID.TabIndex = 185;
            // 
            // cmbFacility
            // 
            this.cmbFacility.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFacility.Enabled = false;
            this.cmbFacility.FormattingEnabled = true;
            this.cmbFacility.Location = new System.Drawing.Point(36, 39);
            this.cmbFacility.Name = "cmbFacility";
            this.cmbFacility.Size = new System.Drawing.Size(312, 20);
            this.cmbFacility.TabIndex = 184;
            // 
            // txtName
            // 
            this.txtName.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtName.Location = new System.Drawing.Point(387, 39);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(166, 21);
            this.txtName.TabIndex = 178;
            // 
            // btnQuery
            // 
            this.btnQuery.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnQuery.Location = new System.Drawing.Point(978, 17);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(127, 74);
            this.btnQuery.TabIndex = 176;
            this.btnQuery.Text = "查询(&Q)";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeight = 32;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSelect,
            this.colFacility,
            this.colID,
            this.colName,
            this.colSex,
            this.colClassName,
            this.colPrinted,
            this.colGroup,
            this.col考试科目,
            this.colState,
            this.col加分,
            this.col总分});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(1, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("宋体", 10.5F);
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1101, 384);
            this.dataGridView1.TabIndex = 306;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // colSelect
            // 
            this.colSelect.HeaderText = "";
            this.colSelect.Name = "colSelect";
            this.colSelect.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colSelect.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colSelect.Width = 40;
            // 
            // colFacility
            // 
            this.colFacility.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colFacility.HeaderText = "学校";
            this.colFacility.MinimumWidth = 100;
            this.colFacility.Name = "colFacility";
            this.colFacility.ReadOnly = true;
            // 
            // colID
            // 
            this.colID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colID.HeaderText = "准考证号";
            this.colID.MinimumWidth = 100;
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            // 
            // colName
            // 
            this.colName.HeaderText = "姓名";
            this.colName.MinimumWidth = 60;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Width = 80;
            // 
            // colSex
            // 
            this.colSex.HeaderText = "性别";
            this.colSex.Name = "colSex";
            this.colSex.ReadOnly = true;
            this.colSex.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colSex.Width = 40;
            // 
            // colClassName
            // 
            this.colClassName.HeaderText = "班级";
            this.colClassName.Name = "colClassName";
            this.colClassName.ReadOnly = true;
            // 
            // colPrinted
            // 
            this.colPrinted.HeaderText = "已打印";
            this.colPrinted.Name = "colPrinted";
            this.colPrinted.ReadOnly = true;
            this.colPrinted.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colPrinted.Width = 60;
            // 
            // colGroup
            // 
            this.colGroup.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colGroup.HeaderText = "分组";
            this.colGroup.MinimumWidth = 100;
            this.colGroup.Name = "colGroup";
            this.colGroup.ReadOnly = true;
            // 
            // col考试科目
            // 
            this.col考试科目.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.col考试科目.HeaderText = "考试科目";
            this.col考试科目.MinimumWidth = 100;
            this.col考试科目.Name = "col考试科目";
            this.col考试科目.ReadOnly = true;
            // 
            // colState
            // 
            this.colState.HeaderText = "特殊情况";
            this.colState.Name = "colState";
            this.colState.ReadOnly = true;
            this.colState.Width = 80;
            // 
            // col加分
            // 
            this.col加分.HeaderText = "平时分";
            this.col加分.Name = "col加分";
            this.col加分.ReadOnly = true;
            this.col加分.Width = 70;
            // 
            // col总分
            // 
            this.col总分.HeaderText = "总分";
            this.col总分.Name = "col总分";
            this.col总分.ReadOnly = true;
            this.col总分.Width = 65;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu取消打印状态});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(149, 26);
            // 
            // mnu取消打印状态
            // 
            this.mnu取消打印状态.Name = "mnu取消打印状态";
            this.mnu取消打印状态.Size = new System.Drawing.Size(148, 22);
            this.mnu取消打印状态.Text = "取消打印状态";
            this.mnu取消打印状态.Click += new System.EventHandler(this.mnu取消打印状态_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.rd所有特殊状态);
            this.panel2.Controls.Add(this.rd指定状态);
            this.panel2.Controls.Add(this.rd不限状态);
            this.panel2.Controls.Add(this.txt考试状态);
            this.panel2.Location = new System.Drawing.Point(570, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(372, 25);
            this.panel2.TabIndex = 310;
            // 
            // rd所有特殊状态
            // 
            this.rd所有特殊状态.AutoSize = true;
            this.rd所有特殊状态.Font = new System.Drawing.Font("宋体", 9F);
            this.rd所有特殊状态.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rd所有特殊状态.Location = new System.Drawing.Point(59, 4);
            this.rd所有特殊状态.Name = "rd所有特殊状态";
            this.rd所有特殊状态.Size = new System.Drawing.Size(95, 16);
            this.rd所有特殊状态.TabIndex = 177;
            this.rd所有特殊状态.Text = "所有特殊学生";
            this.rd所有特殊状态.UseVisualStyleBackColor = true;
            // 
            // rd指定状态
            // 
            this.rd指定状态.AutoSize = true;
            this.rd指定状态.Font = new System.Drawing.Font("宋体", 9F);
            this.rd指定状态.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rd指定状态.Location = new System.Drawing.Point(163, 4);
            this.rd指定状态.Name = "rd指定状态";
            this.rd指定状态.Size = new System.Drawing.Size(71, 16);
            this.rd指定状态.TabIndex = 179;
            this.rd指定状态.Text = "指定状态";
            this.rd指定状态.UseVisualStyleBackColor = true;
            this.rd指定状态.CheckedChanged += new System.EventHandler(this.rd指定状态_CheckedChanged);
            // 
            // rd不限状态
            // 
            this.rd不限状态.AutoSize = true;
            this.rd不限状态.Checked = true;
            this.rd不限状态.Font = new System.Drawing.Font("宋体", 9F);
            this.rd不限状态.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rd不限状态.Location = new System.Drawing.Point(2, 4);
            this.rd不限状态.Name = "rd不限状态";
            this.rd不限状态.Size = new System.Drawing.Size(47, 16);
            this.rd不限状态.TabIndex = 181;
            this.rd不限状态.TabStop = true;
            this.rd不限状态.Text = "不限";
            this.rd不限状态.UseVisualStyleBackColor = true;
            // 
            // txt考试状态
            // 
            this.txt考试状态.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt考试状态.Enabled = false;
            this.txt考试状态.Font = new System.Drawing.Font("宋体", 9F);
            this.txt考试状态.FormattingEnabled = true;
            this.txt考试状态.Location = new System.Drawing.Point(238, 2);
            this.txt考试状态.Name = "txt考试状态";
            this.txt考试状态.Size = new System.Drawing.Size(126, 20);
            this.txt考试状态.TabIndex = 175;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rd全部);
            this.panel1.Controls.Add(this.rd测试完成);
            this.panel1.Controls.Add(this.rd未测试);
            this.panel1.Controls.Add(this.rd没有完成测试);
            this.panel1.Location = new System.Drawing.Point(570, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 26);
            this.panel1.TabIndex = 309;
            // 
            // rd全部
            // 
            this.rd全部.AutoSize = true;
            this.rd全部.Checked = true;
            this.rd全部.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rd全部.Location = new System.Drawing.Point(2, 4);
            this.rd全部.Name = "rd全部";
            this.rd全部.Size = new System.Drawing.Size(47, 16);
            this.rd全部.TabIndex = 9;
            this.rd全部.TabStop = true;
            this.rd全部.Text = "全部";
            this.rd全部.UseVisualStyleBackColor = true;
            // 
            // rd测试完成
            // 
            this.rd测试完成.AutoSize = true;
            this.rd测试完成.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rd测试完成.Location = new System.Drawing.Point(59, 4);
            this.rd测试完成.Name = "rd测试完成";
            this.rd测试完成.Size = new System.Drawing.Size(71, 16);
            this.rd测试完成.TabIndex = 5;
            this.rd测试完成.Text = "完成考试";
            this.rd测试完成.UseVisualStyleBackColor = true;
            // 
            // rd未测试
            // 
            this.rd未测试.AutoSize = true;
            this.rd未测试.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rd未测试.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rd未测试.Location = new System.Drawing.Point(141, 4);
            this.rd未测试.Name = "rd未测试";
            this.rd未测试.Size = new System.Drawing.Size(59, 16);
            this.rd未测试.TabIndex = 8;
            this.rd未测试.Text = "未考试";
            this.rd未测试.UseVisualStyleBackColor = true;
            // 
            // rd没有完成测试
            // 
            this.rd没有完成测试.AutoSize = true;
            this.rd没有完成测试.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rd没有完成测试.Location = new System.Drawing.Point(211, 4);
            this.rd没有完成测试.Name = "rd没有完成测试";
            this.rd没有完成测试.Size = new System.Drawing.Size(83, 16);
            this.rd没有完成测试.TabIndex = 6;
            this.rd没有完成测试.Text = "未完成考试";
            this.rd没有完成测试.UseVisualStyleBackColor = true;
            // 
            // txtClassName
            // 
            this.txtClassName.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtClassName.Location = new System.Drawing.Point(604, 75);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(132, 21);
            this.txtClassName.TabIndex = 313;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(569, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 312;
            this.label5.Text = "班级";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.rd打印All);
            this.panel3.Controls.Add(this.rd已打印);
            this.panel3.Controls.Add(this.rd未打印);
            this.panel3.Location = new System.Drawing.Point(750, 72);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(187, 26);
            this.panel3.TabIndex = 311;
            // 
            // rd打印All
            // 
            this.rd打印All.AutoSize = true;
            this.rd打印All.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rd打印All.Location = new System.Drawing.Point(2, 4);
            this.rd打印All.Name = "rd打印All";
            this.rd打印All.Size = new System.Drawing.Size(47, 16);
            this.rd打印All.TabIndex = 9;
            this.rd打印All.Text = "全部";
            this.rd打印All.UseVisualStyleBackColor = true;
            // 
            // rd已打印
            // 
            this.rd已打印.AutoSize = true;
            this.rd已打印.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rd已打印.Location = new System.Drawing.Point(122, 4);
            this.rd已打印.Name = "rd已打印";
            this.rd已打印.Size = new System.Drawing.Size(59, 16);
            this.rd已打印.TabIndex = 5;
            this.rd已打印.Text = "已打印";
            this.rd已打印.UseVisualStyleBackColor = true;
            // 
            // rd未打印
            // 
            this.rd未打印.AutoSize = true;
            this.rd未打印.Checked = true;
            this.rd未打印.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rd未打印.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rd未打印.Location = new System.Drawing.Point(56, 4);
            this.rd未打印.Name = "rd未打印";
            this.rd未打印.Size = new System.Drawing.Size(59, 16);
            this.rd未打印.TabIndex = 8;
            this.rd未打印.TabStop = true;
            this.rd未打印.Text = "未打印";
            this.rd未打印.UseVisualStyleBackColor = true;
            // 
            // gpStudent
            // 
            this.gpStudent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpStudent.Controls.Add(this.btnModalBrowser);
            this.gpStudent.Controls.Add(this.label1);
            this.gpStudent.Controls.Add(this.txtModelFile);
            this.gpStudent.Controls.Add(this.btnExport);
            this.gpStudent.Controls.Add(this.label10);
            this.gpStudent.Controls.Add(this.lbl选择数量);
            this.gpStudent.Controls.Add(this.txtInterval);
            this.gpStudent.Controls.Add(this.btnNone);
            this.gpStudent.Controls.Add(this.label4);
            this.gpStudent.Controls.Add(this.btnAll);
            this.gpStudent.Controls.Add(this.btnPrint);
            this.gpStudent.Location = new System.Drawing.Point(1108, 109);
            this.gpStudent.Name = "gpStudent";
            this.gpStudent.Size = new System.Drawing.Size(246, 383);
            this.gpStudent.TabIndex = 314;
            this.gpStudent.TabStop = false;
            this.gpStudent.Text = "第二步  打印";
            // 
            // btnModalBrowser
            // 
            this.btnModalBrowser.Location = new System.Drawing.Point(115, 16);
            this.btnModalBrowser.Name = "btnModalBrowser";
            this.btnModalBrowser.Size = new System.Drawing.Size(105, 22);
            this.btnModalBrowser.TabIndex = 311;
            this.btnModalBrowser.Text = "查找模板...";
            this.btnModalBrowser.UseVisualStyleBackColor = true;
            this.btnModalBrowser.Click += new System.EventHandler(this.btnModalBrowser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 309;
            this.label1.Text = "模板";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtModelFile
            // 
            this.txtModelFile.Enabled = false;
            this.txtModelFile.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtModelFile.Location = new System.Drawing.Point(6, 44);
            this.txtModelFile.Multiline = true;
            this.txtModelFile.Name = "txtModelFile";
            this.txtModelFile.ReadOnly = true;
            this.txtModelFile.Size = new System.Drawing.Size(234, 65);
            this.txtModelFile.TabIndex = 310;
            // 
            // btnExport
            // 
            this.btnExport.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnExport.Location = new System.Drawing.Point(6, 281);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(202, 45);
            this.btnExport.TabIndex = 144;
            this.btnExport.Text = "导出成绩单(&E)";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(163, 190);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 143;
            this.label10.Text = "秒(1-30)";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl选择数量
            // 
            this.lbl选择数量.AutoSize = true;
            this.lbl选择数量.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Bold);
            this.lbl选择数量.ForeColor = System.Drawing.Color.Blue;
            this.lbl选择数量.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl选择数量.Location = new System.Drawing.Point(112, 131);
            this.lbl选择数量.Name = "lbl选择数量";
            this.lbl选择数量.Size = new System.Drawing.Size(27, 27);
            this.lbl选择数量.TabIndex = 165;
            this.lbl选择数量.Text = "0";
            this.lbl选择数量.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtInterval
            // 
            this.txtInterval.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtInterval.Location = new System.Drawing.Point(104, 186);
            this.txtInterval.MaxValue = 30;
            this.txtInterval.MinValue = 1;
            this.txtInterval.Name = "txtInterval";
            this.txtInterval.Size = new System.Drawing.Size(53, 21);
            this.txtInterval.TabIndex = 142;
            this.txtInterval.Text = "5";
            // 
            // btnNone
            // 
            this.btnNone.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnNone.Location = new System.Drawing.Point(6, 151);
            this.btnNone.Name = "btnNone";
            this.btnNone.Size = new System.Drawing.Size(89, 25);
            this.btnNone.TabIndex = 149;
            this.btnNone.Text = "全不选(&N)";
            this.btnNone.UseVisualStyleBackColor = true;
            this.btnNone.Click += new System.EventHandler(this.btnNone_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(6, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 141;
            this.label4.Text = "成绩单打印间隔";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnAll
            // 
            this.btnAll.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAll.Location = new System.Drawing.Point(6, 118);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(89, 25);
            this.btnAll.TabIndex = 148;
            this.btnAll.Text = "全选(&A)";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPrint.Location = new System.Drawing.Point(6, 223);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(202, 45);
            this.btnPrint.TabIndex = 135;
            this.btnPrint.Text = "开始打印(&P)";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn数据另存为
            // 
            this.btn数据另存为.BackColor = System.Drawing.SystemColors.Control;
            this.btn数据另存为.ForeColor = System.Drawing.Color.Black;
            this.btn数据另存为.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn数据另存为.Location = new System.Drawing.Point(1129, 17);
            this.btn数据另存为.Name = "btn数据另存为";
            this.btn数据另存为.Size = new System.Drawing.Size(127, 74);
            this.btn数据另存为.TabIndex = 315;
            this.btn数据另存为.Text = "数据另存为";
            this.btn数据另存为.UseVisualStyleBackColor = false;
            this.btn数据另存为.Click += new System.EventHandler(this.mnu数据另存为_Click);
            // 
            // Frm学生成绩单导出
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 517);
            this.Controls.Add(this.btn数据另存为);
            this.Controls.Add(this.gpStudent);
            this.Controls.Add(this.txtClassName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ucStudentSearch1);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm学生成绩单导出";
            this.Text = "打印学生成绩单";
            this.Load += new System.EventHandler(this.FrmExportScores_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ucStudentSearch1.ResumeLayout(false);
            this.ucStudentSearch1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.gpStudent.ResumeLayout(false);
            this.gpStudent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private CommonUI.Controls.UCStudentSearch ucStudentSearch1;
        private LJH.GeneralLibrary.WinformControl.DBCTextBox txtStudentID1;
        private CommonUI.Controls.DivisionComboBox cmbDivision;
        private CommonUI.Controls.StudentGroupComboBox txtGroupID;
        private CommonUI.Controls.FacilityComboBox cmbFacility;
        private LJH.GeneralLibrary.WinformControl.DBCTextBox txtName;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rd所有特殊状态;
        private System.Windows.Forms.RadioButton rd指定状态;
        private System.Windows.Forms.RadioButton rd不限状态;
        private CommonUI.Controls.StudentStateComboBox txt考试状态;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rd全部;
        private System.Windows.Forms.RadioButton rd测试完成;
        private System.Windows.Forms.RadioButton rd未测试;
        private System.Windows.Forms.RadioButton rd没有完成测试;
        private LJH.GeneralLibrary.WinformControl.DBCTextBox txtClassName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rd打印All;
        private System.Windows.Forms.RadioButton rd已打印;
        private System.Windows.Forms.RadioButton rd未打印;
        private System.Windows.Forms.GroupBox gpStudent;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl选择数量;
        private LJH.GeneralLibrary.WinformControl.IntergerTextBox txtInterval;
        private System.Windows.Forms.Button btnNone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnModalBrowser;
        private System.Windows.Forms.Label label1;
        private LJH.GeneralLibrary.WinformControl.DBCTextBox txtModelFile;
        private System.Windows.Forms.Button btn数据另存为;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnu取消打印状态;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFacility;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClassName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colPrinted;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn col考试科目;
        private System.Windows.Forms.DataGridViewTextBoxColumn colState;
        private System.Windows.Forms.DataGridViewTextBoxColumn col加分;
        private System.Windows.Forms.DataGridViewTextBoxColumn col总分;
    }
}