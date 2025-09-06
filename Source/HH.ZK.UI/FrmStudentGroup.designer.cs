namespace HH.ZK.UI
{
    partial class FrmStudentGroup
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStudentGroup));
            this.menu = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbDivision = new HH.ZK.CommonUI.Controls.DivisionComboBox(this.components);
            this.btn导出秩序册 = new System.Windows.Forms.Button();
            this.btn导出所选分组准考证 = new System.Windows.Forms.Button();
            this.cmbPhysicalItem = new HH.ZK.CommonUI.Controls.PhysicalItemComboBox(this.components);
            this.txt考试时间 = new System.Windows.Forms.ComboBox();
            this.cmbFacility = new HH.ZK.CommonUI.Controls.FacilityComboBox(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdSexAll = new System.Windows.Forms.RadioButton();
            this.rdFemale = new System.Windows.Forms.RadioButton();
            this.rdMale = new System.Windows.Forms.RadioButton();
            this.btn导入分组 = new System.Windows.Forms.Button();
            this.btn自动分组 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFresh = new System.Windows.Forms.Button();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.groupView = new System.Windows.Forms.DataGridView();
            this.col考试时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhysicalItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFacility = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col性别 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuFresh = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu增加分组 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu修改分组 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu导入分组 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu设置考试时间 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu删除所选分组 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu导出准考证 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_导出秩序册 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.lblGroupCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pnlFill = new System.Windows.Forms.Panel();
            this.studentView = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.colChannel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col考试科目 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCheckTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupView)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            this.pnlFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentView)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.Control;
            this.menu.Controls.Add(this.label4);
            this.menu.Controls.Add(this.cmbDivision);
            this.menu.Controls.Add(this.btn导出秩序册);
            this.menu.Controls.Add(this.btn导出所选分组准考证);
            this.menu.Controls.Add(this.cmbPhysicalItem);
            this.menu.Controls.Add(this.txt考试时间);
            this.menu.Controls.Add(this.cmbFacility);
            this.menu.Controls.Add(this.label8);
            this.menu.Controls.Add(this.label6);
            this.menu.Controls.Add(this.panel2);
            this.menu.Controls.Add(this.btn导入分组);
            this.menu.Controls.Add(this.btn自动分组);
            this.menu.Controls.Add(this.label2);
            this.menu.Controls.Add(this.label1);
            this.menu.Controls.Add(this.btnFresh);
            this.menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1386, 99);
            this.menu.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(42, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 15);
            this.label4.TabIndex = 289;
            this.label4.Text = "区域";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbDivision
            // 
            this.cmbDivision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDivision.Enabled = false;
            this.cmbDivision.Font = new System.Drawing.Font("宋体", 9F);
            this.cmbDivision.FormattingEnabled = true;
            this.cmbDivision.Location = new System.Drawing.Point(78, 10);
            this.cmbDivision.Name = "cmbDivision";
            this.cmbDivision.Size = new System.Drawing.Size(227, 20);
            this.cmbDivision.TabIndex = 288;
            this.cmbDivision.SelectedIndexChanged += new System.EventHandler(this.cmbDivision_SelectedIndexChanged);
            // 
            // btn导出秩序册
            // 
            this.btn导出秩序册.Location = new System.Drawing.Point(1141, 23);
            this.btn导出秩序册.Name = "btn导出秩序册";
            this.btn导出秩序册.Size = new System.Drawing.Size(158, 44);
            this.btn导出秩序册.TabIndex = 189;
            this.btn导出秩序册.Text = "导出所选分组秩序册";
            this.btn导出秩序册.UseVisualStyleBackColor = true;
            this.btn导出秩序册.Click += new System.EventHandler(this.mnu_导出秩序册_Click);
            // 
            // btn导出所选分组准考证
            // 
            this.btn导出所选分组准考证.Location = new System.Drawing.Point(958, 23);
            this.btn导出所选分组准考证.Name = "btn导出所选分组准考证";
            this.btn导出所选分组准考证.Size = new System.Drawing.Size(158, 44);
            this.btn导出所选分组准考证.TabIndex = 188;
            this.btn导出所选分组准考证.Text = "导出所选分组准考证";
            this.btn导出所选分组准考证.UseVisualStyleBackColor = true;
            this.btn导出所选分组准考证.Click += new System.EventHandler(this.mnu导出准考证_Click);
            // 
            // cmbPhysicalItem
            // 
            this.cmbPhysicalItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPhysicalItem.FormattingEnabled = true;
            this.cmbPhysicalItem.Location = new System.Drawing.Point(383, 38);
            this.cmbPhysicalItem.Name = "cmbPhysicalItem";
            this.cmbPhysicalItem.Size = new System.Drawing.Size(150, 23);
            this.cmbPhysicalItem.TabIndex = 186;
            this.cmbPhysicalItem.SelectedIndexChanged += new System.EventHandler(this.FreshData_Clicked);
            // 
            // txt考试时间
            // 
            this.txt考试时间.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt考试时间.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt考试时间.FormattingEnabled = true;
            this.txt考试时间.Location = new System.Drawing.Point(78, 68);
            this.txt考试时间.Name = "txt考试时间";
            this.txt考试时间.Size = new System.Drawing.Size(227, 20);
            this.txt考试时间.TabIndex = 185;
            this.txt考试时间.SelectedIndexChanged += new System.EventHandler(this.FreshData_Clicked);
            // 
            // cmbFacility
            // 
            this.cmbFacility.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFacility.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFacility.FormattingEnabled = true;
            this.cmbFacility.Location = new System.Drawing.Point(78, 39);
            this.cmbFacility.Name = "cmbFacility";
            this.cmbFacility.Size = new System.Drawing.Size(227, 20);
            this.cmbFacility.TabIndex = 184;
            this.cmbFacility.SelectedIndexChanged += new System.EventHandler(this.cmbFacility_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(42, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 15);
            this.label8.TabIndex = 183;
            this.label8.Text = "学校";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(347, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 15);
            this.label6.TabIndex = 181;
            this.label6.Text = "性别";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdSexAll);
            this.panel2.Controls.Add(this.rdFemale);
            this.panel2.Controls.Add(this.rdMale);
            this.panel2.Location = new System.Drawing.Point(383, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 21);
            this.panel2.TabIndex = 182;
            // 
            // rdSexAll
            // 
            this.rdSexAll.AutoSize = true;
            this.rdSexAll.Checked = true;
            this.rdSexAll.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rdSexAll.Location = new System.Drawing.Point(3, 1);
            this.rdSexAll.Name = "rdSexAll";
            this.rdSexAll.Size = new System.Drawing.Size(51, 19);
            this.rdSexAll.TabIndex = 7;
            this.rdSexAll.TabStop = true;
            this.rdSexAll.Text = "全部";
            this.rdSexAll.UseVisualStyleBackColor = true;
            this.rdSexAll.Click += new System.EventHandler(this.FreshData_Clicked);
            // 
            // rdFemale
            // 
            this.rdFemale.AutoSize = true;
            this.rdFemale.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rdFemale.Location = new System.Drawing.Point(107, 1);
            this.rdFemale.Name = "rdFemale";
            this.rdFemale.Size = new System.Drawing.Size(38, 19);
            this.rdFemale.TabIndex = 6;
            this.rdFemale.Text = "女";
            this.rdFemale.UseVisualStyleBackColor = true;
            this.rdFemale.Click += new System.EventHandler(this.FreshData_Clicked);
            // 
            // rdMale
            // 
            this.rdMale.AutoSize = true;
            this.rdMale.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rdMale.Location = new System.Drawing.Point(60, 1);
            this.rdMale.Name = "rdMale";
            this.rdMale.Size = new System.Drawing.Size(38, 19);
            this.rdMale.TabIndex = 5;
            this.rdMale.Text = "男";
            this.rdMale.UseVisualStyleBackColor = true;
            this.rdMale.Click += new System.EventHandler(this.FreshData_Clicked);
            // 
            // btn导入分组
            // 
            this.btn导入分组.Location = new System.Drawing.Point(695, 23);
            this.btn导入分组.Name = "btn导入分组";
            this.btn导入分组.Size = new System.Drawing.Size(107, 44);
            this.btn导入分组.TabIndex = 165;
            this.btn导入分组.Text = "导入分组";
            this.btn导入分组.UseVisualStyleBackColor = true;
            this.btn导入分组.Click += new System.EventHandler(this.btn导入分组_Click);
            // 
            // btn自动分组
            // 
            this.btn自动分组.Location = new System.Drawing.Point(567, 23);
            this.btn自动分组.Name = "btn自动分组";
            this.btn自动分组.Size = new System.Drawing.Size(107, 44);
            this.btn自动分组.TabIndex = 164;
            this.btn自动分组.Text = "自动分组";
            this.btn自动分组.UseVisualStyleBackColor = true;
            this.btn自动分组.Click += new System.EventHandler(this.btn自动分组_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(321, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 154;
            this.label2.Text = "考试科目";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(16, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 156;
            this.label1.Text = "考试时间";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnFresh
            // 
            this.btnFresh.Location = new System.Drawing.Point(825, 23);
            this.btnFresh.Name = "btnFresh";
            this.btnFresh.Size = new System.Drawing.Size(107, 44);
            this.btnFresh.TabIndex = 163;
            this.btnFresh.Text = "刷新";
            this.btnFresh.UseVisualStyleBackColor = true;
            this.btnFresh.Click += new System.EventHandler(this.btnFresh_Click);
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.groupView);
            this.pnlLeft.Controls.Add(this.statusStrip2);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 99);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(653, 564);
            this.pnlLeft.TabIndex = 34;
            // 
            // groupView
            // 
            this.groupView.AllowUserToAddRows = false;
            this.groupView.AllowUserToDeleteRows = false;
            this.groupView.AllowUserToResizeRows = false;
            this.groupView.BackgroundColor = System.Drawing.Color.White;
            this.groupView.ColumnHeadersHeight = 30;
            this.groupView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.groupView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col考试时间,
            this.colPhysicalItem,
            this.colFacility,
            this.col性别,
            this.colNumber,
            this.colCount,
            this.colFill});
            this.groupView.ContextMenuStrip = this.contextMenuStrip2;
            this.groupView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupView.Location = new System.Drawing.Point(0, 0);
            this.groupView.Name = "groupView";
            this.groupView.RowHeadersVisible = false;
            this.groupView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("宋体", 10.5F);
            this.groupView.RowTemplate.Height = 30;
            this.groupView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.groupView.Size = new System.Drawing.Size(653, 542);
            this.groupView.TabIndex = 155;
            this.groupView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.groupView_CellClick);
            // 
            // col考试时间
            // 
            this.col考试时间.HeaderText = "考试时间";
            this.col考试时间.Name = "col考试时间";
            this.col考试时间.ReadOnly = true;
            this.col考试时间.Width = 120;
            // 
            // colPhysicalItem
            // 
            this.colPhysicalItem.HeaderText = "考试科目";
            this.colPhysicalItem.Name = "colPhysicalItem";
            this.colPhysicalItem.ReadOnly = true;
            // 
            // colFacility
            // 
            this.colFacility.HeaderText = "学校";
            this.colFacility.MinimumWidth = 150;
            this.colFacility.Name = "colFacility";
            this.colFacility.ReadOnly = true;
            this.colFacility.Width = 150;
            // 
            // col性别
            // 
            this.col性别.HeaderText = "性别";
            this.col性别.Name = "col性别";
            this.col性别.ReadOnly = true;
            this.col性别.Width = 60;
            // 
            // colNumber
            // 
            this.colNumber.HeaderText = "组号";
            this.colNumber.Name = "colNumber";
            this.colNumber.ReadOnly = true;
            this.colNumber.Width = 70;
            // 
            // colCount
            // 
            this.colCount.HeaderText = "人数";
            this.colCount.Name = "colCount";
            this.colCount.ReadOnly = true;
            this.colCount.Width = 70;
            // 
            // colFill
            // 
            this.colFill.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colFill.HeaderText = "";
            this.colFill.Name = "colFill";
            this.colFill.ReadOnly = true;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFresh,
            this.toolStripSeparator2,
            this.mnu增加分组,
            this.mnu修改分组,
            this.mnu导入分组,
            this.mnu设置考试时间,
            this.mnu删除所选分组,
            this.toolStripSeparator1,
            this.mnu导出准考证,
            this.mnu_导出秩序册});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(149, 192);
            // 
            // mnuFresh
            // 
            this.mnuFresh.Name = "mnuFresh";
            this.mnuFresh.Size = new System.Drawing.Size(148, 22);
            this.mnuFresh.Text = "刷新";
            this.mnuFresh.Click += new System.EventHandler(this.mnuFresh_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(145, 6);
            // 
            // mnu增加分组
            // 
            this.mnu增加分组.Name = "mnu增加分组";
            this.mnu增加分组.Size = new System.Drawing.Size(148, 22);
            this.mnu增加分组.Text = "增加分组";
            this.mnu增加分组.Click += new System.EventHandler(this.mnu增加分组_Click);
            // 
            // mnu修改分组
            // 
            this.mnu修改分组.Name = "mnu修改分组";
            this.mnu修改分组.Size = new System.Drawing.Size(148, 22);
            this.mnu修改分组.Text = "修改分组";
            this.mnu修改分组.Click += new System.EventHandler(this.mnu修改分组_Click);
            // 
            // mnu导入分组
            // 
            this.mnu导入分组.Name = "mnu导入分组";
            this.mnu导入分组.Size = new System.Drawing.Size(148, 22);
            this.mnu导入分组.Text = "导入分组";
            this.mnu导入分组.Click += new System.EventHandler(this.mnu导入分组_Click);
            // 
            // mnu设置考试时间
            // 
            this.mnu设置考试时间.Name = "mnu设置考试时间";
            this.mnu设置考试时间.Size = new System.Drawing.Size(148, 22);
            this.mnu设置考试时间.Text = "设置考试时间";
            this.mnu设置考试时间.Click += new System.EventHandler(this.mnu设置考试时间_Click);
            // 
            // mnu删除所选分组
            // 
            this.mnu删除所选分组.Name = "mnu删除所选分组";
            this.mnu删除所选分组.Size = new System.Drawing.Size(148, 22);
            this.mnu删除所选分组.Text = "删除所选分组";
            this.mnu删除所选分组.Click += new System.EventHandler(this.删除所选分组ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(145, 6);
            // 
            // mnu导出准考证
            // 
            this.mnu导出准考证.Name = "mnu导出准考证";
            this.mnu导出准考证.Size = new System.Drawing.Size(148, 22);
            this.mnu导出准考证.Text = "导出准考证";
            this.mnu导出准考证.Click += new System.EventHandler(this.mnu导出准考证_Click);
            // 
            // mnu_导出秩序册
            // 
            this.mnu_导出秩序册.Name = "mnu_导出秩序册";
            this.mnu_导出秩序册.Size = new System.Drawing.Size(148, 22);
            this.mnu_导出秩序册.Text = "导出秩序册";
            this.mnu_导出秩序册.Click += new System.EventHandler(this.mnu_导出秩序册_Click);
            // 
            // statusStrip2
            // 
            this.statusStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblGroupCount});
            this.statusStrip2.Location = new System.Drawing.Point(0, 542);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(653, 22);
            this.statusStrip2.TabIndex = 154;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // lblGroupCount
            // 
            this.lblGroupCount.Name = "lblGroupCount";
            this.lblGroupCount.Size = new System.Drawing.Size(638, 17);
            this.lblGroupCount.Spring = true;
            this.lblGroupCount.Text = "总共 0 项";
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.splitter1.Location = new System.Drawing.Point(653, 99);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(6, 564);
            this.splitter1.TabIndex = 35;
            this.splitter1.TabStop = false;
            // 
            // pnlFill
            // 
            this.pnlFill.Controls.Add(this.studentView);
            this.pnlFill.Controls.Add(this.statusStrip1);
            this.pnlFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFill.Location = new System.Drawing.Point(659, 99);
            this.pnlFill.Name = "pnlFill";
            this.pnlFill.Size = new System.Drawing.Size(727, 564);
            this.pnlFill.TabIndex = 39;
            // 
            // studentView
            // 
            this.studentView.AllowUserToAddRows = false;
            this.studentView.AllowUserToDeleteRows = false;
            this.studentView.AllowUserToResizeRows = false;
            this.studentView.BackgroundColor = System.Drawing.Color.White;
            this.studentView.ColumnHeadersHeight = 30;
            this.studentView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.studentView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colChannel,
            this.colID,
            this.colName,
            this.colSex,
            this.colClassName,
            this.col考试科目,
            this.colCheckTime});
            this.studentView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentView.Location = new System.Drawing.Point(0, 0);
            this.studentView.Name = "studentView";
            this.studentView.RowHeadersVisible = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.studentView.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.studentView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("宋体", 10.5F);
            this.studentView.RowTemplate.Height = 30;
            this.studentView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.studentView.Size = new System.Drawing.Size(727, 542);
            this.studentView.TabIndex = 154;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblCount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 542);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(727, 22);
            this.statusStrip1.TabIndex = 153;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblCount
            // 
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(712, 17);
            this.lblCount.Spring = true;
            this.lblCount.Text = "总共 0 项";
            // 
            // colChannel
            // 
            this.colChannel.HeaderText = "道次";
            this.colChannel.Name = "colChannel";
            this.colChannel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colChannel.Width = 60;
            // 
            // colID
            // 
            this.colID.HeaderText = "准考证号";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colID.Width = 150;
            // 
            // colName
            // 
            this.colName.HeaderText = "姓名";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colName.Width = 80;
            // 
            // colSex
            // 
            this.colSex.HeaderText = "性别";
            this.colSex.Name = "colSex";
            this.colSex.ReadOnly = true;
            this.colSex.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colSex.Width = 60;
            // 
            // colClassName
            // 
            this.colClassName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colClassName.HeaderText = "班级";
            this.colClassName.MinimumWidth = 100;
            this.colClassName.Name = "colClassName";
            this.colClassName.ReadOnly = true;
            this.colClassName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // col考试科目
            // 
            this.col考试科目.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.col考试科目.HeaderText = "考试科目";
            this.col考试科目.MinimumWidth = 100;
            this.col考试科目.Name = "col考试科目";
            this.col考试科目.ReadOnly = true;
            this.col考试科目.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colCheckTime
            // 
            this.colCheckTime.HeaderText = "检录时间";
            this.colCheckTime.Name = "colCheckTime";
            this.colCheckTime.ReadOnly = true;
            this.colCheckTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colCheckTime.Width = 150;
            // 
            // FrmStudentGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 663);
            this.Controls.Add(this.pnlFill);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmStudentGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "考试分组管理";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupView)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.pnlFill.ResumeLayout(false);
            this.pnlFill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentView)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menu;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel pnlFill;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView studentView;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView groupView;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel lblGroupCount;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem mnu删除所选分组;
        private System.Windows.Forms.ToolStripMenuItem mnu增加分组;
        private System.Windows.Forms.ToolStripMenuItem mnu修改分组;
        private System.Windows.Forms.ToolStripMenuItem mnu导出准考证;
        private System.Windows.Forms.ToolStripMenuItem mnu_导出秩序册;
        private System.Windows.Forms.Button btnFresh;
        private System.Windows.Forms.ToolStripMenuItem mnuFresh;
        private System.Windows.Forms.Button btn自动分组;
        private System.Windows.Forms.Button btn导入分组;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnu导入分组;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdSexAll;
        private System.Windows.Forms.RadioButton rdFemale;
        private System.Windows.Forms.RadioButton rdMale;
        private System.Windows.Forms.ToolStripMenuItem mnu设置考试时间;
        private System.Windows.Forms.ComboBox txt考试时间;
        private HH.ZK.CommonUI.Controls.PhysicalItemComboBox cmbPhysicalItem;
        private System.Windows.Forms.Button btn导出所选分组准考证;
        private System.Windows.Forms.Button btn导出秩序册;
        private CommonUI.Controls.FacilityComboBox cmbFacility;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private CommonUI.Controls.DivisionComboBox cmbDivision;
        private System.Windows.Forms.DataGridViewTextBoxColumn col考试时间;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhysicalItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFacility;
        private System.Windows.Forms.DataGridViewTextBoxColumn col性别;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFill;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChannel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col考试科目;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCheckTime;
    }
}

