namespace HH.ZK.CommonUI
{
    partial class FrmStudentDownload
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataGridview1 = new System.Windows.Forms.DataGridView();
            this.colSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colFacility = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCardID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMemo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpStudent = new System.Windows.Forms.GroupBox();
            this.btnExportCSV = new System.Windows.Forms.Button();
            this.chkCardIDForStudentID = new System.Windows.Forms.CheckBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtMaxPertime = new LJH.GeneralLibrary.WinformControl.IntergerTextBox(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.chkClearFirst = new System.Windows.Forms.CheckBox();
            this.btnWrite = new System.Windows.Forms.Button();
            this.chkLog = new System.Windows.Forms.CheckBox();
            this.cmbCommport = new LJH.GeneralLibrary.WinformControl.ComPortComboBox(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.btnQuery = new System.Windows.Forms.Button();
            this.lbl选择数量 = new System.Windows.Forms.Label();
            this.btnNone = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.ucStudentSearch1 = new HH.ZK.CommonUI.Controls.UCStudentSearch();
            this.chk任意一项 = new System.Windows.Forms.CheckBox();
            this.chk缓考 = new System.Windows.Forms.CheckBox();
            this.chk择考 = new System.Windows.Forms.CheckBox();
            this.chk正常考试 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.rdHasPhoto = new System.Windows.Forms.RadioButton();
            this.rdNonePhoto = new System.Windows.Forms.RadioButton();
            this.rdPhotoAll = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.lnk考试科目 = new System.Windows.Forms.LinkLabel();
            this.txt考试科目 = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridview1)).BeginInit();
            this.gpStudent.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 640);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1263, 22);
            this.statusStrip1.TabIndex = 119;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(1248, 17);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = "总共 0 项";
            // 
            // dataGridview1
            // 
            this.dataGridview1.AllowUserToAddRows = false;
            this.dataGridview1.AllowUserToDeleteRows = false;
            this.dataGridview1.AllowUserToResizeRows = false;
            this.dataGridview1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridview1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridview1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridview1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSelect,
            this.colFacility,
            this.colClassName,
            this.colID,
            this.colName,
            this.colSex,
            this.colCardID,
            this.colMemo});
            this.dataGridview1.Location = new System.Drawing.Point(3, 110);
            this.dataGridview1.Name = "dataGridview1";
            this.dataGridview1.RowHeadersVisible = false;
            this.dataGridview1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dataGridview1.RowTemplate.Height = 23;
            this.dataGridview1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridview1.Size = new System.Drawing.Size(959, 527);
            this.dataGridview1.TabIndex = 120;
            this.dataGridview1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridview1_CellContentClick);
            // 
            // colSelect
            // 
            this.colSelect.HeaderText = "";
            this.colSelect.Name = "colSelect";
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
            // colClassName
            // 
            this.colClassName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colClassName.HeaderText = "班级";
            this.colClassName.MinimumWidth = 100;
            this.colClassName.Name = "colClassName";
            this.colClassName.ReadOnly = true;
            // 
            // colID
            // 
            this.colID.HeaderText = "学籍号";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Width = 120;
            // 
            // colName
            // 
            this.colName.HeaderText = "姓名";
            this.colName.MinimumWidth = 120;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Width = 120;
            // 
            // colSex
            // 
            this.colSex.HeaderText = "性别";
            this.colSex.Name = "colSex";
            this.colSex.ReadOnly = true;
            this.colSex.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colSex.Width = 60;
            // 
            // colCardID
            // 
            this.colCardID.HeaderText = "卡号";
            this.colCardID.Name = "colCardID";
            this.colCardID.ReadOnly = true;
            // 
            // colMemo
            // 
            this.colMemo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMemo.HeaderText = "";
            this.colMemo.MinimumWidth = 100;
            this.colMemo.Name = "colMemo";
            this.colMemo.ReadOnly = true;
            // 
            // gpStudent
            // 
            this.gpStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gpStudent.Controls.Add(this.btnExportCSV);
            this.gpStudent.Controls.Add(this.chkCardIDForStudentID);
            this.gpStudent.Controls.Add(this.btnClear);
            this.gpStudent.Controls.Add(this.txtMaxPertime);
            this.gpStudent.Controls.Add(this.label9);
            this.gpStudent.Controls.Add(this.chkClearFirst);
            this.gpStudent.Controls.Add(this.btnWrite);
            this.gpStudent.Controls.Add(this.chkLog);
            this.gpStudent.Controls.Add(this.cmbCommport);
            this.gpStudent.Controls.Add(this.label4);
            this.gpStudent.Location = new System.Drawing.Point(973, 103);
            this.gpStudent.Name = "gpStudent";
            this.gpStudent.Size = new System.Drawing.Size(283, 301);
            this.gpStudent.TabIndex = 144;
            this.gpStudent.TabStop = false;
            this.gpStudent.Text = "第二步  下载";
            // 
            // btnExportCSV
            // 
            this.btnExportCSV.Location = new System.Drawing.Point(22, 248);
            this.btnExportCSV.Name = "btnExportCSV";
            this.btnExportCSV.Size = new System.Drawing.Size(240, 35);
            this.btnExportCSV.TabIndex = 149;
            this.btnExportCSV.Text = "导出CSV文件";
            this.btnExportCSV.UseVisualStyleBackColor = true;
            this.btnExportCSV.Click += new System.EventHandler(this.btnExportCSV_Click);
            // 
            // chkCardIDForStudentID
            // 
            this.chkCardIDForStudentID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkCardIDForStudentID.AutoSize = true;
            this.chkCardIDForStudentID.ForeColor = System.Drawing.Color.Red;
            this.chkCardIDForStudentID.Location = new System.Drawing.Point(22, 132);
            this.chkCardIDForStudentID.Name = "chkCardIDForStudentID";
            this.chkCardIDForStudentID.Size = new System.Drawing.Size(156, 16);
            this.chkCardIDForStudentID.TabIndex = 148;
            this.chkCardIDForStudentID.Text = "将卡号作为学生的学籍号";
            this.chkCardIDForStudentID.UseVisualStyleBackColor = true;
            this.chkCardIDForStudentID.CheckedChanged += new System.EventHandler(this.chkCardIDForStudentID_CheckedChanged);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(144, 169);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(116, 29);
            this.btnClear.TabIndex = 147;
            this.btnClear.Text = "清空主机";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtMaxPertime
            // 
            this.txtMaxPertime.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtMaxPertime.Location = new System.Drawing.Point(186, 67);
            this.txtMaxPertime.MaxValue = 20;
            this.txtMaxPertime.MinValue = 1;
            this.txtMaxPertime.Name = "txtMaxPertime";
            this.txtMaxPertime.Size = new System.Drawing.Size(63, 21);
            this.txtMaxPertime.TabIndex = 146;
            this.txtMaxPertime.Text = "20";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(173, 12);
            this.label9.TabIndex = 145;
            this.label9.Text = "单次下载最大学生数量（1-20）";
            // 
            // chkClearFirst
            // 
            this.chkClearFirst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkClearFirst.AutoSize = true;
            this.chkClearFirst.ForeColor = System.Drawing.Color.Red;
            this.chkClearFirst.Location = new System.Drawing.Point(20, 104);
            this.chkClearFirst.Name = "chkClearFirst";
            this.chkClearFirst.Size = new System.Drawing.Size(240, 16);
            this.chkClearFirst.TabIndex = 144;
            this.chkClearFirst.Text = "下载学生信息之前先将主机学生信息清空";
            this.chkClearFirst.UseVisualStyleBackColor = true;
            this.chkClearFirst.CheckedChanged += new System.EventHandler(this.chkClearFirst_CheckedChanged);
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(20, 204);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(240, 35);
            this.btnWrite.TabIndex = 135;
            this.btnWrite.Text = "开始下载(&U)";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // chkLog
            // 
            this.chkLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkLog.AutoSize = true;
            this.chkLog.Location = new System.Drawing.Point(197, 34);
            this.chkLog.Name = "chkLog";
            this.chkLog.Size = new System.Drawing.Size(72, 16);
            this.chkLog.TabIndex = 143;
            this.chkLog.Text = "记录日志";
            this.chkLog.UseVisualStyleBackColor = true;
            // 
            // cmbCommport
            // 
            this.cmbCommport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCommport.FormattingEnabled = true;
            this.cmbCommport.Location = new System.Drawing.Point(54, 32);
            this.cmbCommport.Name = "cmbCommport";
            this.cmbCommport.Size = new System.Drawing.Size(134, 20);
            this.cmbCommport.TabIndex = 141;
            this.cmbCommport.SelectedIndexChanged += new System.EventHandler(this.cmbCommport_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 142;
            this.label4.Text = "串口";
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(896, 4);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(167, 84);
            this.btnQuery.TabIndex = 133;
            this.btnQuery.Text = "查询(&Q)";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // lbl选择数量
            // 
            this.lbl选择数量.AutoSize = true;
            this.lbl选择数量.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Bold);
            this.lbl选择数量.ForeColor = System.Drawing.Color.Blue;
            this.lbl选择数量.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl选择数量.Location = new System.Drawing.Point(1190, 39);
            this.lbl选择数量.Name = "lbl选择数量";
            this.lbl选择数量.Size = new System.Drawing.Size(27, 27);
            this.lbl选择数量.TabIndex = 171;
            this.lbl选择数量.Text = "0";
            this.lbl选择数量.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnNone
            // 
            this.btnNone.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnNone.Location = new System.Drawing.Point(1083, 51);
            this.btnNone.Name = "btnNone";
            this.btnNone.Size = new System.Drawing.Size(89, 25);
            this.btnNone.TabIndex = 170;
            this.btnNone.Text = "全不选(&N)";
            this.btnNone.UseVisualStyleBackColor = true;
            this.btnNone.Click += new System.EventHandler(this.btnNone_Click);
            // 
            // btnAll
            // 
            this.btnAll.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAll.Location = new System.Drawing.Point(1083, 18);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(89, 25);
            this.btnAll.TabIndex = 169;
            this.btnAll.Text = "全选(&A)";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // ucStudentSearch1
            // 
            this.ucStudentSearch1.Location = new System.Drawing.Point(3, 4);
            this.ucStudentSearch1.Name = "ucStudentSearch1";
            this.ucStudentSearch1.Size = new System.Drawing.Size(562, 100);
            this.ucStudentSearch1.TabIndex = 172;
            // 
            // chk任意一项
            // 
            this.chk任意一项.AutoSize = true;
            this.chk任意一项.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chk任意一项.Location = new System.Drawing.Point(818, 13);
            this.chk任意一项.Name = "chk任意一项";
            this.chk任意一项.Size = new System.Drawing.Size(72, 16);
            this.chk任意一项.TabIndex = 310;
            this.chk任意一项.Text = "任意一项";
            this.chk任意一项.UseVisualStyleBackColor = true;
            // 
            // chk缓考
            // 
            this.chk缓考.AutoSize = true;
            this.chk缓考.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chk缓考.Location = new System.Drawing.Point(755, 83);
            this.chk缓考.Name = "chk缓考";
            this.chk缓考.Size = new System.Drawing.Size(48, 16);
            this.chk缓考.TabIndex = 309;
            this.chk缓考.Text = "缓考";
            this.chk缓考.UseVisualStyleBackColor = true;
            // 
            // chk择考
            // 
            this.chk择考.AutoSize = true;
            this.chk择考.Checked = true;
            this.chk择考.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk择考.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chk择考.Location = new System.Drawing.Point(701, 83);
            this.chk择考.Name = "chk择考";
            this.chk择考.Size = new System.Drawing.Size(48, 16);
            this.chk择考.TabIndex = 308;
            this.chk择考.Text = "择考";
            this.chk择考.UseVisualStyleBackColor = true;
            // 
            // chk正常考试
            // 
            this.chk正常考试.AutoSize = true;
            this.chk正常考试.Checked = true;
            this.chk正常考试.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk正常考试.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chk正常考试.Location = new System.Drawing.Point(626, 83);
            this.chk正常考试.Name = "chk正常考试";
            this.chk正常考试.Size = new System.Drawing.Size(72, 16);
            this.chk正常考试.TabIndex = 307;
            this.chk正常考试.Text = "正常考试";
            this.chk正常考试.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(567, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 306;
            this.label2.Text = "考试状态";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.rdHasPhoto);
            this.panel5.Controls.Add(this.rdNonePhoto);
            this.panel5.Controls.Add(this.rdPhotoAll);
            this.panel5.Location = new System.Drawing.Point(626, 43);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(149, 25);
            this.panel5.TabIndex = 305;
            // 
            // rdHasPhoto
            // 
            this.rdHasPhoto.AutoSize = true;
            this.rdHasPhoto.Font = new System.Drawing.Font("宋体", 9F);
            this.rdHasPhoto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rdHasPhoto.Location = new System.Drawing.Point(61, 4);
            this.rdHasPhoto.Name = "rdHasPhoto";
            this.rdHasPhoto.Size = new System.Drawing.Size(35, 16);
            this.rdHasPhoto.TabIndex = 177;
            this.rdHasPhoto.Text = "有";
            this.rdHasPhoto.UseVisualStyleBackColor = true;
            // 
            // rdNonePhoto
            // 
            this.rdNonePhoto.AutoSize = true;
            this.rdNonePhoto.Font = new System.Drawing.Font("宋体", 9F);
            this.rdNonePhoto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rdNonePhoto.Location = new System.Drawing.Point(106, 4);
            this.rdNonePhoto.Name = "rdNonePhoto";
            this.rdNonePhoto.Size = new System.Drawing.Size(35, 16);
            this.rdNonePhoto.TabIndex = 179;
            this.rdNonePhoto.Text = "无";
            this.rdNonePhoto.UseVisualStyleBackColor = true;
            // 
            // rdPhotoAll
            // 
            this.rdPhotoAll.AutoSize = true;
            this.rdPhotoAll.Checked = true;
            this.rdPhotoAll.Font = new System.Drawing.Font("宋体", 9F);
            this.rdPhotoAll.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rdPhotoAll.Location = new System.Drawing.Point(2, 4);
            this.rdPhotoAll.Name = "rdPhotoAll";
            this.rdPhotoAll.Size = new System.Drawing.Size(47, 16);
            this.rdPhotoAll.TabIndex = 181;
            this.rdPhotoAll.TabStop = true;
            this.rdPhotoAll.Text = "全部";
            this.rdPhotoAll.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(591, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 304;
            this.label6.Text = "照片";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lnk考试科目
            // 
            this.lnk考试科目.AutoSize = true;
            this.lnk考试科目.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lnk考试科目.Location = new System.Drawing.Point(567, 14);
            this.lnk考试科目.Name = "lnk考试科目";
            this.lnk考试科目.Size = new System.Drawing.Size(53, 12);
            this.lnk考试科目.TabIndex = 303;
            this.lnk考试科目.TabStop = true;
            this.lnk考试科目.Text = "考试科目";
            this.lnk考试科目.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk考试科目_LinkClicked);
            // 
            // txt考试科目
            // 
            this.txt考试科目.BackColor = System.Drawing.Color.White;
            this.txt考试科目.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txt考试科目.Location = new System.Drawing.Point(626, 10);
            this.txt考试科目.MaxLength = 20;
            this.txt考试科目.Name = "txt考试科目";
            this.txt考试科目.ReadOnly = true;
            this.txt考试科目.Size = new System.Drawing.Size(186, 21);
            this.txt考试科目.TabIndex = 302;
            // 
            // FrmStudentDownload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 662);
            this.Controls.Add(this.chk任意一项);
            this.Controls.Add(this.chk缓考);
            this.Controls.Add(this.chk择考);
            this.Controls.Add(this.chk正常考试);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lnk考试科目);
            this.Controls.Add(this.txt考试科目);
            this.Controls.Add(this.ucStudentSearch1);
            this.Controls.Add(this.lbl选择数量);
            this.Controls.Add(this.btnNone);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.gpStudent);
            this.Controls.Add(this.dataGridview1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "FrmStudentDownload";
            this.Text = "学生信息下载";
            this.Load += new System.EventHandler(this.FrmStudentUpload_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridview1)).EndInit();
            this.gpStudent.ResumeLayout(false);
            this.gpStudent.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.DataGridView dataGridview1;
        private System.Windows.Forms.GroupBox gpStudent;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.CheckBox chkLog;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnQuery;
        private LJH.GeneralLibrary.WinformControl.ComPortComboBox cmbCommport;
        private System.Windows.Forms.CheckBox chkClearFirst;
        private System.Windows.Forms.Label label9;
        private LJH.GeneralLibrary.WinformControl.IntergerTextBox txtMaxPertime;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.CheckBox chkCardIDForStudentID;
        private System.Windows.Forms.Button btnExportCSV;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFacility;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCardID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMemo;
        private System.Windows.Forms.Label lbl选择数量;
        private System.Windows.Forms.Button btnNone;
        private System.Windows.Forms.Button btnAll;
        private Controls.UCStudentSearch ucStudentSearch1;
        private System.Windows.Forms.CheckBox chk任意一项;
        private System.Windows.Forms.CheckBox chk缓考;
        private System.Windows.Forms.CheckBox chk择考;
        private System.Windows.Forms.CheckBox chk正常考试;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RadioButton rdHasPhoto;
        private System.Windows.Forms.RadioButton rdNonePhoto;
        private System.Windows.Forms.RadioButton rdPhotoAll;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel lnk考试科目;
        private LJH.GeneralLibrary.WinformControl.DBCTextBox txt考试科目;
    }
}