namespace HH.ZK.UI
{
    partial class Frm学生信息管理
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm学生信息管理));
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.facilityTree = new HH.ZK.CommonUI.Controls.FacilityTree(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cMnu_Fresh = new System.Windows.Forms.ToolStripMenuItem();
            this.cMnu_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu_DeleteStudents = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu批量修改考试科目 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu设置学生考试状态 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu导入学生信息 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu导入学生考试科目 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu导入学生特殊情况 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu导入平时成绩 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cMnu_SelectColumns = new System.Windows.Forms.ToolStripMenuItem();
            this.cMnu_Export = new System.Windows.Forms.ToolStripMenuItem();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.DivisionMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mn刷新学校 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_AddFacility = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_AddDivision = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_DeleteDivision = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_DepartmentProperty = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.FacilityMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnu_DelFacility = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_FacilityProperty = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.ucPaging1 = new LJH.GeneralLibrary.WinformControl.UCPaging();
            this.menu = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rd有人脸特征 = new System.Windows.Forms.RadioButton();
            this.rd无人脸特征 = new System.Windows.Forms.RadioButton();
            this.rd人脸特征全部 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.chk任意一项 = new System.Windows.Forms.CheckBox();
            this.lnk考试科目 = new System.Windows.Forms.LinkLabel();
            this.txt考试科目 = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.rd所有特殊状态 = new System.Windows.Forms.RadioButton();
            this.rd指定状态 = new System.Windows.Forms.RadioButton();
            this.rd不限状态 = new System.Windows.Forms.RadioButton();
            this.txt考试状态 = new HH.ZK.CommonUI.Controls.StudentStateComboBox(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.rdHasPhoto = new System.Windows.Forms.RadioButton();
            this.rdNonePhoto = new System.Windows.Forms.RadioButton();
            this.rdPhotoAll = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdMale = new System.Windows.Forms.RadioButton();
            this.rdFemale = new System.Windows.Forms.RadioButton();
            this.rdSexAll = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnFresh = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStudentID1 = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtClassName = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.txtName = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.col序号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFacility = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIDNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGroupID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCardID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col考试科目 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col学校代码 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col平时成绩 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col照片 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colFill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlLeft.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.DivisionMenu.SuspendLayout();
            this.FacilityMenu.SuspendLayout();
            this.menu.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.facilityTree);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(234, 577);
            this.pnlLeft.TabIndex = 110;
            // 
            // facilityTree
            // 
            this.facilityTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.facilityTree.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawText;
            this.facilityTree.HideSelection = false;
            this.facilityTree.ItemHeight = 24;
            this.facilityTree.Location = new System.Drawing.Point(0, 0);
            this.facilityTree.Name = "facilityTree";
            this.facilityTree.Size = new System.Drawing.Size(234, 577);
            this.facilityTree.TabIndex = 119;
            this.facilityTree.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.facilityTree_MouseDown);
            this.facilityTree.MouseDown += new System.Windows.Forms.MouseEventHandler(this.facilityTree_NodeMouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cMnu_Fresh,
            this.cMnu_Add,
            this.Mnu_DeleteStudents,
            this.toolStripSeparator3,
            this.mnu批量修改考试科目,
            this.mnu设置学生考试状态,
            this.toolStripSeparator5,
            this.mnu导入学生信息,
            this.mnu导入学生考试科目,
            this.mnu导入学生特殊情况,
            this.mnu导入平时成绩,
            this.toolStripSeparator1,
            this.cMnu_SelectColumns,
            this.cMnu_Export});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(179, 264);
            // 
            // cMnu_Fresh
            // 
            this.cMnu_Fresh.Name = "cMnu_Fresh";
            this.cMnu_Fresh.Size = new System.Drawing.Size(178, 22);
            this.cMnu_Fresh.Text = "刷新";
            // 
            // cMnu_Add
            // 
            this.cMnu_Add.Name = "cMnu_Add";
            this.cMnu_Add.Size = new System.Drawing.Size(178, 22);
            this.cMnu_Add.Text = "增加学生";
            // 
            // Mnu_DeleteStudents
            // 
            this.Mnu_DeleteStudents.Name = "Mnu_DeleteStudents";
            this.Mnu_DeleteStudents.Size = new System.Drawing.Size(178, 22);
            this.Mnu_DeleteStudents.Text = "删除所选学生";
            this.Mnu_DeleteStudents.Click += new System.EventHandler(this.Mnu_DeleteStudents_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(175, 6);
            // 
            // mnu批量修改考试科目
            // 
            this.mnu批量修改考试科目.Name = "mnu批量修改考试科目";
            this.mnu批量修改考试科目.Size = new System.Drawing.Size(178, 22);
            this.mnu批量修改考试科目.Text = "批量修改考试科目";
            this.mnu批量修改考试科目.Click += new System.EventHandler(this.mnu批量修改考试科目_Click);
            // 
            // mnu设置学生考试状态
            // 
            this.mnu设置学生考试状态.Name = "mnu设置学生考试状态";
            this.mnu设置学生考试状态.Size = new System.Drawing.Size(178, 22);
            this.mnu设置学生考试状态.Text = "设置学生考试状态";
            this.mnu设置学生考试状态.Click += new System.EventHandler(this.mnu设置学生考试状态_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(175, 6);
            // 
            // mnu导入学生信息
            // 
            this.mnu导入学生信息.Name = "mnu导入学生信息";
            this.mnu导入学生信息.Size = new System.Drawing.Size(178, 22);
            this.mnu导入学生信息.Text = "导入学生信息";
            this.mnu导入学生信息.Click += new System.EventHandler(this.mnu导入学生信息_Click);
            // 
            // mnu导入学生考试科目
            // 
            this.mnu导入学生考试科目.Name = "mnu导入学生考试科目";
            this.mnu导入学生考试科目.Size = new System.Drawing.Size(178, 22);
            this.mnu导入学生考试科目.Text = "导入学生考试科目";
            this.mnu导入学生考试科目.Click += new System.EventHandler(this.mnu导入学生考试科目_Click);
            // 
            // mnu导入学生特殊情况
            // 
            this.mnu导入学生特殊情况.Name = "mnu导入学生特殊情况";
            this.mnu导入学生特殊情况.Size = new System.Drawing.Size(178, 22);
            this.mnu导入学生特殊情况.Text = "导入学生特殊情况";
            this.mnu导入学生特殊情况.Click += new System.EventHandler(this.mnu导入学生特殊情况_Click);
            // 
            // mnu导入平时成绩
            // 
            this.mnu导入平时成绩.Name = "mnu导入平时成绩";
            this.mnu导入平时成绩.Size = new System.Drawing.Size(178, 22);
            this.mnu导入平时成绩.Text = "导入学生国标分";
            this.mnu导入平时成绩.Click += new System.EventHandler(this.mnu导入平时成绩_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(175, 6);
            // 
            // cMnu_SelectColumns
            // 
            this.cMnu_SelectColumns.Name = "cMnu_SelectColumns";
            this.cMnu_SelectColumns.Size = new System.Drawing.Size(178, 22);
            this.cMnu_SelectColumns.Text = "选择列...";
            // 
            // cMnu_Export
            // 
            this.cMnu_Export.Name = "cMnu_Export";
            this.cMnu_Export.Size = new System.Drawing.Size(178, 22);
            this.cMnu_Export.Text = "导出学生信息...";
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.splitter1.Location = new System.Drawing.Point(234, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(7, 577);
            this.splitter1.TabIndex = 114;
            this.splitter1.TabStop = false;
            // 
            // DivisionMenu
            // 
            this.DivisionMenu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DivisionMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mn刷新学校,
            this.mnu_AddFacility,
            this.mnu_AddDivision,
            this.mnu_DeleteDivision,
            this.mnu_DepartmentProperty,
            this.toolStripSeparator8});
            this.DivisionMenu.Name = "contextMenuStrip1";
            this.DivisionMenu.Size = new System.Drawing.Size(181, 142);
            // 
            // mn刷新学校
            // 
            this.mn刷新学校.Name = "mn刷新学校";
            this.mn刷新学校.Size = new System.Drawing.Size(180, 22);
            this.mn刷新学校.Text = "刷新";
            this.mn刷新学校.Click += new System.EventHandler(this.mn刷新学校_Click);
            // 
            // mnu_AddFacility
            // 
            this.mnu_AddFacility.Name = "mnu_AddFacility";
            this.mnu_AddFacility.Size = new System.Drawing.Size(180, 22);
            this.mnu_AddFacility.Text = "增加学校";
            this.mnu_AddFacility.Click += new System.EventHandler(this.mnu_AddFacility_Click);
            // 
            // mnu_AddDivision
            // 
            this.mnu_AddDivision.Name = "mnu_AddDivision";
            this.mnu_AddDivision.Size = new System.Drawing.Size(180, 22);
            this.mnu_AddDivision.Text = "增加区域";
            this.mnu_AddDivision.Click += new System.EventHandler(this.mnu_AddDivision_Click);
            // 
            // mnu_DeleteDivision
            // 
            this.mnu_DeleteDivision.Name = "mnu_DeleteDivision";
            this.mnu_DeleteDivision.Size = new System.Drawing.Size(180, 22);
            this.mnu_DeleteDivision.Text = "删除";
            this.mnu_DeleteDivision.Click += new System.EventHandler(this.mnu_DeleteDivision_Click);
            // 
            // mnu_DepartmentProperty
            // 
            this.mnu_DepartmentProperty.Name = "mnu_DepartmentProperty";
            this.mnu_DepartmentProperty.Size = new System.Drawing.Size(180, 22);
            this.mnu_DepartmentProperty.Text = "属性";
            this.mnu_DepartmentProperty.Click += new System.EventHandler(this.mnu_DivisionProperty_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(177, 6);
            // 
            // FacilityMenu
            // 
            this.FacilityMenu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FacilityMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_DelFacility,
            this.mnu_FacilityProperty,
            this.toolStripSeparator7});
            this.FacilityMenu.Name = "contextMenuStrip1";
            this.FacilityMenu.Size = new System.Drawing.Size(101, 54);
            // 
            // mnu_DelFacility
            // 
            this.mnu_DelFacility.Name = "mnu_DelFacility";
            this.mnu_DelFacility.Size = new System.Drawing.Size(100, 22);
            this.mnu_DelFacility.Text = "删除";
            this.mnu_DelFacility.Click += new System.EventHandler(this.mnu_DelFacility_Click);
            // 
            // mnu_FacilityProperty
            // 
            this.mnu_FacilityProperty.Name = "mnu_FacilityProperty";
            this.mnu_FacilityProperty.Size = new System.Drawing.Size(100, 22);
            this.mnu_FacilityProperty.Text = "属性";
            this.mnu_FacilityProperty.Click += new System.EventHandler(this.mnu_FacilityProperty_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(97, 6);
            // 
            // ucPaging1
            // 
            this.ucPaging1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucPaging1.Location = new System.Drawing.Point(241, 547);
            this.ucPaging1.Name = "ucPaging1";
            this.ucPaging1.Size = new System.Drawing.Size(1129, 30);
            this.ucPaging1.TabIndex = 128;
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.Control;
            this.menu.Controls.Add(this.panel3);
            this.menu.Controls.Add(this.label3);
            this.menu.Controls.Add(this.chk任意一项);
            this.menu.Controls.Add(this.lnk考试科目);
            this.menu.Controls.Add(this.txt考试科目);
            this.menu.Controls.Add(this.panel2);
            this.menu.Controls.Add(this.panel5);
            this.menu.Controls.Add(this.panel1);
            this.menu.Controls.Add(this.label6);
            this.menu.Controls.Add(this.label7);
            this.menu.Controls.Add(this.btnFresh);
            this.menu.Controls.Add(this.label4);
            this.menu.Controls.Add(this.txtStudentID1);
            this.menu.Controls.Add(this.label1);
            this.menu.Controls.Add(this.txtClassName);
            this.menu.Controls.Add(this.txtName);
            this.menu.Controls.Add(this.label5);
            this.menu.Controls.Add(this.label2);
            this.menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menu.Location = new System.Drawing.Point(241, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1129, 94);
            this.menu.TabIndex = 132;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.rd有人脸特征);
            this.panel3.Controls.Add(this.rd无人脸特征);
            this.panel3.Controls.Add(this.rd人脸特征全部);
            this.panel3.Location = new System.Drawing.Point(66, 66);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(139, 25);
            this.panel3.TabIndex = 295;
            // 
            // rd有人脸特征
            // 
            this.rd有人脸特征.AutoSize = true;
            this.rd有人脸特征.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rd有人脸特征.Location = new System.Drawing.Point(55, 4);
            this.rd有人脸特征.Name = "rd有人脸特征";
            this.rd有人脸特征.Size = new System.Drawing.Size(35, 16);
            this.rd有人脸特征.TabIndex = 177;
            this.rd有人脸特征.Text = "有";
            this.rd有人脸特征.UseVisualStyleBackColor = true;
            this.rd有人脸特征.Click += new System.EventHandler(this.txField_Click);
            // 
            // rd无人脸特征
            // 
            this.rd无人脸特征.AutoSize = true;
            this.rd无人脸特征.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rd无人脸特征.Location = new System.Drawing.Point(97, 4);
            this.rd无人脸特征.Name = "rd无人脸特征";
            this.rd无人脸特征.Size = new System.Drawing.Size(35, 16);
            this.rd无人脸特征.TabIndex = 179;
            this.rd无人脸特征.Text = "无";
            this.rd无人脸特征.UseVisualStyleBackColor = true;
            this.rd无人脸特征.Click += new System.EventHandler(this.txField_Click);
            // 
            // rd人脸特征全部
            // 
            this.rd人脸特征全部.AutoSize = true;
            this.rd人脸特征全部.Checked = true;
            this.rd人脸特征全部.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rd人脸特征全部.Location = new System.Drawing.Point(2, 4);
            this.rd人脸特征全部.Name = "rd人脸特征全部";
            this.rd人脸特征全部.Size = new System.Drawing.Size(47, 16);
            this.rd人脸特征全部.TabIndex = 181;
            this.rd人脸特征全部.TabStop = true;
            this.rd人脸特征全部.Text = "全部";
            this.rd人脸特征全部.UseVisualStyleBackColor = true;
            this.rd人脸特征全部.Click += new System.EventHandler(this.txField_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 294;
            this.label3.Text = "人脸特征";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chk任意一项
            // 
            this.chk任意一项.AutoSize = true;
            this.chk任意一项.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chk任意一项.Location = new System.Drawing.Point(835, 39);
            this.chk任意一项.Name = "chk任意一项";
            this.chk任意一项.Size = new System.Drawing.Size(78, 19);
            this.chk任意一项.TabIndex = 293;
            this.chk任意一项.Text = "任意一项";
            this.chk任意一项.UseVisualStyleBackColor = true;
            // 
            // lnk考试科目
            // 
            this.lnk考试科目.AutoSize = true;
            this.lnk考试科目.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lnk考试科目.Location = new System.Drawing.Point(453, 41);
            this.lnk考试科目.Name = "lnk考试科目";
            this.lnk考试科目.Size = new System.Drawing.Size(59, 15);
            this.lnk考试科目.TabIndex = 283;
            this.lnk考试科目.TabStop = true;
            this.lnk考试科目.Text = "考试科目";
            this.lnk考试科目.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk考试科目_LinkClicked);
            // 
            // txt考试科目
            // 
            this.txt考试科目.BackColor = System.Drawing.Color.White;
            this.txt考试科目.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txt考试科目.Location = new System.Drawing.Point(512, 37);
            this.txt考试科目.MaxLength = 20;
            this.txt考试科目.Name = "txt考试科目";
            this.txt考试科目.ReadOnly = true;
            this.txt考试科目.Size = new System.Drawing.Size(317, 23);
            this.txt考试科目.TabIndex = 282;
            this.txt考试科目.TextChanged += new System.EventHandler(this.txField_Click);
            this.txt考试科目.DoubleClick += new System.EventHandler(this.txt考试科目_DoubleClick);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.rd所有特殊状态);
            this.panel2.Controls.Add(this.rd指定状态);
            this.panel2.Controls.Add(this.rd不限状态);
            this.panel2.Controls.Add(this.txt考试状态);
            this.panel2.Location = new System.Drawing.Point(513, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(406, 25);
            this.panel2.TabIndex = 281;
            // 
            // rd所有特殊状态
            // 
            this.rd所有特殊状态.AutoSize = true;
            this.rd所有特殊状态.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rd所有特殊状态.Location = new System.Drawing.Point(61, 4);
            this.rd所有特殊状态.Name = "rd所有特殊状态";
            this.rd所有特殊状态.Size = new System.Drawing.Size(95, 16);
            this.rd所有特殊状态.TabIndex = 177;
            this.rd所有特殊状态.Text = "所有特殊学生";
            this.rd所有特殊状态.UseVisualStyleBackColor = true;
            this.rd所有特殊状态.Click += new System.EventHandler(this.txField_Click);
            // 
            // rd指定状态
            // 
            this.rd指定状态.AutoSize = true;
            this.rd指定状态.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rd指定状态.Location = new System.Drawing.Point(163, 4);
            this.rd指定状态.Name = "rd指定状态";
            this.rd指定状态.Size = new System.Drawing.Size(71, 16);
            this.rd指定状态.TabIndex = 179;
            this.rd指定状态.Text = "指定状态";
            this.rd指定状态.UseVisualStyleBackColor = true;
            this.rd指定状态.CheckedChanged += new System.EventHandler(this.rd指定状态_CheckedChanged);
            this.rd指定状态.Click += new System.EventHandler(this.txField_Click);
            // 
            // rd不限状态
            // 
            this.rd不限状态.AutoSize = true;
            this.rd不限状态.Checked = true;
            this.rd不限状态.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rd不限状态.Location = new System.Drawing.Point(2, 4);
            this.rd不限状态.Name = "rd不限状态";
            this.rd不限状态.Size = new System.Drawing.Size(47, 16);
            this.rd不限状态.TabIndex = 181;
            this.rd不限状态.TabStop = true;
            this.rd不限状态.Text = "不限";
            this.rd不限状态.UseVisualStyleBackColor = true;
            this.rd不限状态.CheckedChanged += new System.EventHandler(this.txField_Click);
            // 
            // txt考试状态
            // 
            this.txt考试状态.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt考试状态.Enabled = false;
            this.txt考试状态.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt考试状态.FormattingEnabled = true;
            this.txt考试状态.Location = new System.Drawing.Point(238, 1);
            this.txt考试状态.Name = "txt考试状态";
            this.txt考试状态.Size = new System.Drawing.Size(161, 20);
            this.txt考试状态.TabIndex = 175;
            this.txt考试状态.TextChanged += new System.EventHandler(this.txField_Click);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.rdHasPhoto);
            this.panel5.Controls.Add(this.rdNonePhoto);
            this.panel5.Controls.Add(this.rdPhotoAll);
            this.panel5.Location = new System.Drawing.Point(66, 36);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(139, 25);
            this.panel5.TabIndex = 280;
            // 
            // rdHasPhoto
            // 
            this.rdHasPhoto.AutoSize = true;
            this.rdHasPhoto.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdHasPhoto.Location = new System.Drawing.Point(55, 4);
            this.rdHasPhoto.Name = "rdHasPhoto";
            this.rdHasPhoto.Size = new System.Drawing.Size(35, 16);
            this.rdHasPhoto.TabIndex = 177;
            this.rdHasPhoto.Text = "有";
            this.rdHasPhoto.UseVisualStyleBackColor = true;
            this.rdHasPhoto.Click += new System.EventHandler(this.txField_Click);
            // 
            // rdNonePhoto
            // 
            this.rdNonePhoto.AutoSize = true;
            this.rdNonePhoto.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdNonePhoto.Location = new System.Drawing.Point(97, 4);
            this.rdNonePhoto.Name = "rdNonePhoto";
            this.rdNonePhoto.Size = new System.Drawing.Size(35, 16);
            this.rdNonePhoto.TabIndex = 179;
            this.rdNonePhoto.Text = "无";
            this.rdNonePhoto.UseVisualStyleBackColor = true;
            this.rdNonePhoto.Click += new System.EventHandler(this.txField_Click);
            // 
            // rdPhotoAll
            // 
            this.rdPhotoAll.AutoSize = true;
            this.rdPhotoAll.Checked = true;
            this.rdPhotoAll.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdPhotoAll.Location = new System.Drawing.Point(2, 4);
            this.rdPhotoAll.Name = "rdPhotoAll";
            this.rdPhotoAll.Size = new System.Drawing.Size(47, 16);
            this.rdPhotoAll.TabIndex = 181;
            this.rdPhotoAll.TabStop = true;
            this.rdPhotoAll.Text = "全部";
            this.rdPhotoAll.UseVisualStyleBackColor = true;
            this.rdPhotoAll.Click += new System.EventHandler(this.txField_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rdMale);
            this.panel1.Controls.Add(this.rdFemale);
            this.panel1.Controls.Add(this.rdSexAll);
            this.panel1.Location = new System.Drawing.Point(66, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(139, 25);
            this.panel1.TabIndex = 279;
            // 
            // rdMale
            // 
            this.rdMale.AutoSize = true;
            this.rdMale.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdMale.Location = new System.Drawing.Point(55, 4);
            this.rdMale.Name = "rdMale";
            this.rdMale.Size = new System.Drawing.Size(35, 16);
            this.rdMale.TabIndex = 177;
            this.rdMale.Text = "男";
            this.rdMale.UseVisualStyleBackColor = true;
            this.rdMale.Click += new System.EventHandler(this.txField_Click);
            // 
            // rdFemale
            // 
            this.rdFemale.AutoSize = true;
            this.rdFemale.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdFemale.Location = new System.Drawing.Point(97, 4);
            this.rdFemale.Name = "rdFemale";
            this.rdFemale.Size = new System.Drawing.Size(35, 16);
            this.rdFemale.TabIndex = 179;
            this.rdFemale.Text = "女";
            this.rdFemale.UseVisualStyleBackColor = true;
            this.rdFemale.Click += new System.EventHandler(this.txField_Click);
            // 
            // rdSexAll
            // 
            this.rdSexAll.AutoSize = true;
            this.rdSexAll.Checked = true;
            this.rdSexAll.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdSexAll.Location = new System.Drawing.Point(2, 4);
            this.rdSexAll.Name = "rdSexAll";
            this.rdSexAll.Size = new System.Drawing.Size(47, 16);
            this.rdSexAll.TabIndex = 181;
            this.rdSexAll.TabStop = true;
            this.rdSexAll.Text = "全部";
            this.rdSexAll.UseVisualStyleBackColor = true;
            this.rdSexAll.Click += new System.EventHandler(this.txField_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 15);
            this.label6.TabIndex = 278;
            this.label6.Text = "照片";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 15);
            this.label7.TabIndex = 277;
            this.label7.Text = "性别";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnFresh
            // 
            this.btnFresh.Location = new System.Drawing.Point(937, 16);
            this.btnFresh.Name = "btnFresh";
            this.btnFresh.Size = new System.Drawing.Size(115, 63);
            this.btnFresh.TabIndex = 164;
            this.btnFresh.Text = "刷新";
            this.btnFresh.UseVisualStyleBackColor = true;
            this.btnFresh.Click += new System.EventHandler(this.txField_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(453, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 162;
            this.label4.Text = "考试状态";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtStudentID1
            // 
            this.txtStudentID1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtStudentID1.Location = new System.Drawing.Point(276, 7);
            this.txtStudentID1.Name = "txtStudentID1";
            this.txtStudentID1.Size = new System.Drawing.Size(161, 23);
            this.txtStudentID1.TabIndex = 6;
            this.txtStudentID1.TextChanged += new System.EventHandler(this.txField_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "准考证号";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtClassName
            // 
            this.txtClassName.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtClassName.Location = new System.Drawing.Point(276, 67);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(161, 23);
            this.txtClassName.TabIndex = 12;
            this.txtClassName.TextChanged += new System.EventHandler(this.txField_Click);
            // 
            // txtName
            // 
            this.txtName.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtName.Location = new System.Drawing.Point(276, 37);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(161, 23);
            this.txtName.TabIndex = 9;
            this.txtName.TextChanged += new System.EventHandler(this.txField_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(214, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "班级名称";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "姓名";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col序号,
            this.colFacility,
            this.colID,
            this.colName,
            this.colSex,
            this.colIDNumber,
            this.colGroupID,
            this.colClassName,
            this.colCardID,
            this.colState,
            this.col考试科目,
            this.col学校代码,
            this.col平时成绩,
            this.col照片,
            this.colFill});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(241, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("宋体", 10.5F);
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1129, 453);
            this.dataGridView1.TabIndex = 133;
            // 
            // col序号
            // 
            this.col序号.HeaderText = "序号";
            this.col序号.Name = "col序号";
            this.col序号.ReadOnly = true;
            this.col序号.Width = 60;
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
            this.colName.MinimumWidth = 80;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Width = 80;
            // 
            // colSex
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colSex.DefaultCellStyle = dataGridViewCellStyle1;
            this.colSex.HeaderText = "性别";
            this.colSex.Name = "colSex";
            this.colSex.ReadOnly = true;
            this.colSex.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colSex.Width = 60;
            // 
            // colIDNumber
            // 
            this.colIDNumber.HeaderText = "身份证号";
            this.colIDNumber.Name = "colIDNumber";
            this.colIDNumber.ReadOnly = true;
            this.colIDNumber.Width = 160;
            // 
            // colGroupID
            // 
            this.colGroupID.HeaderText = "分组";
            this.colGroupID.MinimumWidth = 200;
            this.colGroupID.Name = "colGroupID";
            this.colGroupID.ReadOnly = true;
            this.colGroupID.Width = 200;
            // 
            // colClassName
            // 
            this.colClassName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colClassName.HeaderText = "班级";
            this.colClassName.MinimumWidth = 100;
            this.colClassName.Name = "colClassName";
            this.colClassName.ReadOnly = true;
            this.colClassName.Visible = false;
            // 
            // colCardID
            // 
            this.colCardID.HeaderText = "卡号";
            this.colCardID.Name = "colCardID";
            this.colCardID.ReadOnly = true;
            this.colCardID.Visible = false;
            // 
            // colState
            // 
            this.colState.HeaderText = "特殊情况";
            this.colState.Name = "colState";
            this.colState.ReadOnly = true;
            // 
            // col考试科目
            // 
            this.col考试科目.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.col考试科目.HeaderText = "考试科目";
            this.col考试科目.MinimumWidth = 100;
            this.col考试科目.Name = "col考试科目";
            this.col考试科目.ReadOnly = true;
            // 
            // col学校代码
            // 
            this.col学校代码.HeaderText = "学校代码";
            this.col学校代码.Name = "col学校代码";
            this.col学校代码.ReadOnly = true;
            this.col学校代码.Visible = false;
            // 
            // col平时成绩
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.col平时成绩.DefaultCellStyle = dataGridViewCellStyle2;
            this.col平时成绩.HeaderText = "国标分";
            this.col平时成绩.Name = "col平时成绩";
            this.col平时成绩.ReadOnly = true;
            this.col平时成绩.Width = 80;
            // 
            // col照片
            // 
            this.col照片.HeaderText = "照片";
            this.col照片.Name = "col照片";
            this.col照片.ReadOnly = true;
            this.col照片.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col照片.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col照片.Width = 60;
            // 
            // colFill
            // 
            this.colFill.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colFill.HeaderText = "";
            this.colFill.Name = "colFill";
            this.colFill.ReadOnly = true;
            // 
            // Frm学生信息管理
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 599);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.ucPaging1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.pnlLeft);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm学生信息管理";
            this.Text = "学生信息管理";
            this.Controls.SetChildIndex(this.pnlLeft, 0);
            this.Controls.SetChildIndex(this.splitter1, 0);
            this.Controls.SetChildIndex(this.ucPaging1, 0);
            this.Controls.SetChildIndex(this.menu, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.pnlLeft.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.DivisionMenu.ResumeLayout(false);
            this.FacilityMenu.ResumeLayout(false);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cMnu_Fresh;
        private System.Windows.Forms.ToolStripMenuItem cMnu_SelectColumns;
        private System.Windows.Forms.ToolStripMenuItem cMnu_Add;
        private System.Windows.Forms.ToolStripMenuItem Mnu_DeleteStudents;
        private System.Windows.Forms.ToolStripMenuItem cMnu_Export;
        private System.Windows.Forms.Splitter splitter1;
        private HH.ZK.CommonUI.Controls.FacilityTree facilityTree;
        private System.Windows.Forms.ContextMenuStrip DivisionMenu;
        private System.Windows.Forms.ToolStripMenuItem mnu_AddFacility;
        private System.Windows.Forms.ToolStripMenuItem mnu_AddDivision;
        private System.Windows.Forms.ToolStripMenuItem mnu_DeleteDivision;
        private System.Windows.Forms.ToolStripMenuItem mnu_DepartmentProperty;
        private System.Windows.Forms.ContextMenuStrip FacilityMenu;
        private System.Windows.Forms.ToolStripMenuItem mnu_DelFacility;
        private System.Windows.Forms.ToolStripMenuItem mnu_FacilityProperty;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem mnu导入学生信息;
        private System.Windows.Forms.ToolStripMenuItem mnu导入学生考试科目;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnu批量修改考试科目;
        private System.Windows.Forms.ToolStripMenuItem mnu设置学生考试状态;
        private System.Windows.Forms.ToolStripMenuItem mnu导入学生特殊情况;
        private LJH.GeneralLibrary.WinformControl.UCPaging ucPaging1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Panel menu;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RadioButton rdHasPhoto;
        private System.Windows.Forms.RadioButton rdNonePhoto;
        private System.Windows.Forms.RadioButton rdPhotoAll;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdMale;
        private System.Windows.Forms.RadioButton rdFemale;
        private System.Windows.Forms.RadioButton rdSexAll;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private CommonUI.Controls.StudentStateComboBox txt考试状态;
        private System.Windows.Forms.Button btnFresh;
        private System.Windows.Forms.Label label4;
        private LJH.GeneralLibrary.WinformControl.DBCTextBox txtStudentID1;
        private System.Windows.Forms.Label label1;
        private LJH.GeneralLibrary.WinformControl.DBCTextBox txtClassName;
        private LJH.GeneralLibrary.WinformControl.DBCTextBox txtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rd所有特殊状态;
        private System.Windows.Forms.RadioButton rd指定状态;
        private System.Windows.Forms.RadioButton rd不限状态;
        private System.Windows.Forms.ToolStripMenuItem mn刷新学校;
        private System.Windows.Forms.LinkLabel lnk考试科目;
        private LJH.GeneralLibrary.WinformControl.DBCTextBox txt考试科目;
        private System.Windows.Forms.CheckBox chk任意一项;
        private System.Windows.Forms.ToolStripMenuItem mnu导入平时成绩;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rd有人脸特征;
        private System.Windows.Forms.RadioButton rd无人脸特征;
        private System.Windows.Forms.RadioButton rd人脸特征全部;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn col序号;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFacility;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGroupID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCardID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colState;
        private System.Windows.Forms.DataGridViewTextBoxColumn col考试科目;
        private System.Windows.Forms.DataGridViewTextBoxColumn col学校代码;
        private System.Windows.Forms.DataGridViewTextBoxColumn col平时成绩;
        private System.Windows.Forms.DataGridViewCheckBoxColumn col照片;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFill;
    }
}