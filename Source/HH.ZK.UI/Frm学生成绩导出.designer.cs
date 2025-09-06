namespace HH.ZK.UI
{
    partial class Frm学生成绩导出
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm学生成绩导出));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.ucStudentSearch1 = new HH.ZK.CommonUI.Controls.UCStudentSearch();
            this.txtStudentID1 = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.cmbDivision = new HH.ZK.CommonUI.Controls.DivisionComboBox(this.components);
            this.txtGroupID = new HH.ZK.CommonUI.Controls.StudentGroupComboBox(this.components);
            this.cmbFacility = new HH.ZK.CommonUI.Controls.FacilityComboBox(this.components);
            this.txtName = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.btnQuery = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colFacility = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col检录 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col考试科目 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col加分 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col总分 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnu数据另存为 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn模板设置 = new System.Windows.Forms.Button();
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
            this.rd检录All = new System.Windows.Forms.RadioButton();
            this.rd已检录 = new System.Windows.Forms.RadioButton();
            this.rd未检录 = new System.Windows.Forms.RadioButton();
            this.btn分学校导出 = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.ucStudentSearch1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 495);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1357, 22);
            this.statusStrip1.TabIndex = 159;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(1342, 17);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = "总共 0 项";
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(1119, 20);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(71, 74);
            this.btnExport.TabIndex = 162;
            this.btnExport.Text = "导出(&E)";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(1277, 20);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(71, 74);
            this.btnPrint.TabIndex = 170;
            this.btnPrint.Text = "打印(&P)";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
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
            this.btnQuery.Location = new System.Drawing.Point(948, 20);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(84, 74);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 32;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFacility,
            this.colID,
            this.colName,
            this.colSex,
            this.colClassName,
            this.col检录,
            this.colGroup,
            this.col考试科目,
            this.colState,
            this.col加分,
            this.col总分});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(1, 109);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1356, 384);
            this.dataGridView1.TabIndex = 306;
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
            // col检录
            // 
            this.col检录.HeaderText = "检录时间";
            this.col检录.Name = "col检录";
            this.col检录.ReadOnly = true;
            this.col检录.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col检录.Width = 150;
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
            this.col加分.HeaderText = "国标分";
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
            this.mnu数据另存为});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(146, 26);
            // 
            // mnu数据另存为
            // 
            this.mnu数据另存为.Name = "mnu数据另存为";
            this.mnu数据另存为.Size = new System.Drawing.Size(145, 22);
            this.mnu数据另存为.Text = "数据另存为...";
            this.mnu数据另存为.Click += new System.EventHandler(this.mnu数据另存为_Click);
            // 
            // btn模板设置
            // 
            this.btn模板设置.Location = new System.Drawing.Point(1040, 20);
            this.btn模板设置.Name = "btn模板设置";
            this.btn模板设置.Size = new System.Drawing.Size(71, 74);
            this.btn模板设置.TabIndex = 308;
            this.btn模板设置.Text = "模板设置(&S）";
            this.btn模板设置.UseVisualStyleBackColor = true;
            this.btn模板设置.Click += new System.EventHandler(this.btn模板设置_Click);
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
            this.panel3.Controls.Add(this.rd检录All);
            this.panel3.Controls.Add(this.rd已检录);
            this.panel3.Controls.Add(this.rd未检录);
            this.panel3.Location = new System.Drawing.Point(750, 72);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(187, 26);
            this.panel3.TabIndex = 311;
            // 
            // rd检录All
            // 
            this.rd检录All.AutoSize = true;
            this.rd检录All.Checked = true;
            this.rd检录All.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rd检录All.Location = new System.Drawing.Point(2, 4);
            this.rd检录All.Name = "rd检录All";
            this.rd检录All.Size = new System.Drawing.Size(47, 16);
            this.rd检录All.TabIndex = 9;
            this.rd检录All.TabStop = true;
            this.rd检录All.Text = "全部";
            this.rd检录All.UseVisualStyleBackColor = true;
            // 
            // rd已检录
            // 
            this.rd已检录.AutoSize = true;
            this.rd已检录.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rd已检录.Location = new System.Drawing.Point(56, 4);
            this.rd已检录.Name = "rd已检录";
            this.rd已检录.Size = new System.Drawing.Size(59, 16);
            this.rd已检录.TabIndex = 5;
            this.rd已检录.Text = "已检录";
            this.rd已检录.UseVisualStyleBackColor = true;
            // 
            // rd未检录
            // 
            this.rd未检录.AutoSize = true;
            this.rd未检录.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rd未检录.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rd未检录.Location = new System.Drawing.Point(122, 4);
            this.rd未检录.Name = "rd未检录";
            this.rd未检录.Size = new System.Drawing.Size(59, 16);
            this.rd未检录.TabIndex = 8;
            this.rd未检录.Text = "未检录";
            this.rd未检录.UseVisualStyleBackColor = true;
            // 
            // btn分学校导出
            // 
            this.btn分学校导出.Location = new System.Drawing.Point(1198, 20);
            this.btn分学校导出.Name = "btn分学校导出";
            this.btn分学校导出.Size = new System.Drawing.Size(71, 74);
            this.btn分学校导出.TabIndex = 314;
            this.btn分学校导出.Text = "分学校导出";
            this.btn分学校导出.UseVisualStyleBackColor = true;
            this.btn分学校导出.Click += new System.EventHandler(this.btn分学校导出_Click);
            // 
            // Frm学生成绩导出
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 517);
            this.Controls.Add(this.btn分学校导出);
            this.Controls.Add(this.txtClassName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn模板设置);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ucStudentSearch1);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnExport);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm学生成绩导出";
            this.Text = "导出成绩";
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnPrint;
        private CommonUI.Controls.UCStudentSearch ucStudentSearch1;
        private LJH.GeneralLibrary.WinformControl.DBCTextBox txtStudentID1;
        private CommonUI.Controls.DivisionComboBox cmbDivision;
        private CommonUI.Controls.StudentGroupComboBox txtGroupID;
        private CommonUI.Controls.FacilityComboBox cmbFacility;
        private LJH.GeneralLibrary.WinformControl.DBCTextBox txtName;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn模板设置;
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
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnu数据另存为;
        private LJH.GeneralLibrary.WinformControl.DBCTextBox txtClassName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rd检录All;
        private System.Windows.Forms.RadioButton rd已检录;
        private System.Windows.Forms.RadioButton rd未检录;
        private System.Windows.Forms.Button btn分学校导出;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFacility;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col检录;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn col考试科目;
        private System.Windows.Forms.DataGridViewTextBoxColumn colState;
        private System.Windows.Forms.DataGridViewTextBoxColumn col加分;
        private System.Windows.Forms.DataGridViewTextBoxColumn col总分;
    }
}