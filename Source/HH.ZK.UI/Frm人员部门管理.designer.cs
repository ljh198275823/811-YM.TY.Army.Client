namespace HH.ZK.UI
{
    partial class Frm人员部门管理
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm人员部门管理));
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.divisionTree = new HH.ZK.CommonUI.Controls.FacilityTree(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cMnu_Fresh = new System.Windows.Forms.ToolStripMenuItem();
            this.cMnu_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu_DeleteStudents = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu导入学生信息 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu导入学生照片 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cMnu_SelectColumns = new System.Windows.Forms.ToolStripMenuItem();
            this.cMnu_Export = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu导出人员照片 = new System.Windows.Forms.ToolStripMenuItem();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.DivisionMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mn刷新部门 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_AddDivision = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_DeleteDivision = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_DepartmentProperty = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.ucPaging1 = new LJH.GeneralLibrary.WinformControl.UCPaging();
            this.menu = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rd有人脸特征 = new System.Windows.Forms.RadioButton();
            this.rd无人脸特征 = new System.Windows.Forms.RadioButton();
            this.rd人脸特征全部 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
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
            this.txtStudentID1 = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.col序号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFacility = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIDNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCardID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col照片 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.col人脸识别 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colFill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlLeft.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.DivisionMenu.SuspendLayout();
            this.menu.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.divisionTree);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(234, 577);
            this.pnlLeft.TabIndex = 110;
            // 
            // divisionTree
            // 
            this.divisionTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.divisionTree.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawText;
            this.divisionTree.HideSelection = false;
            this.divisionTree.ItemHeight = 24;
            this.divisionTree.Location = new System.Drawing.Point(0, 0);
            this.divisionTree.Name = "divisionTree";
            this.divisionTree.Size = new System.Drawing.Size(234, 577);
            this.divisionTree.TabIndex = 119;
            this.divisionTree.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.facilityTree_MouseDown);
            this.divisionTree.MouseDown += new System.Windows.Forms.MouseEventHandler(this.facilityTree_NodeMouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cMnu_Fresh,
            this.cMnu_Add,
            this.Mnu_DeleteStudents,
            this.toolStripSeparator3,
            this.mnu导入学生信息,
            this.mnu导入学生照片,
            this.toolStripSeparator1,
            this.cMnu_SelectColumns,
            this.cMnu_Export,
            this.mnu导出人员照片});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 214);
            // 
            // cMnu_Fresh
            // 
            this.cMnu_Fresh.Name = "cMnu_Fresh";
            this.cMnu_Fresh.Size = new System.Drawing.Size(180, 22);
            this.cMnu_Fresh.Text = "刷新";
            // 
            // cMnu_Add
            // 
            this.cMnu_Add.Name = "cMnu_Add";
            this.cMnu_Add.Size = new System.Drawing.Size(180, 22);
            this.cMnu_Add.Text = "增加人员";
            // 
            // Mnu_DeleteStudents
            // 
            this.Mnu_DeleteStudents.Name = "Mnu_DeleteStudents";
            this.Mnu_DeleteStudents.Size = new System.Drawing.Size(180, 22);
            this.Mnu_DeleteStudents.Text = "删除所选人员";
            this.Mnu_DeleteStudents.Click += new System.EventHandler(this.Mnu_DeleteStudents_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // mnu导入学生信息
            // 
            this.mnu导入学生信息.Name = "mnu导入学生信息";
            this.mnu导入学生信息.Size = new System.Drawing.Size(180, 22);
            this.mnu导入学生信息.Text = "导入人员信息";
            this.mnu导入学生信息.Click += new System.EventHandler(this.mnu导入学生信息_Click);
            // 
            // mnu导入学生照片
            // 
            this.mnu导入学生照片.Name = "mnu导入学生照片";
            this.mnu导入学生照片.Size = new System.Drawing.Size(180, 22);
            this.mnu导入学生照片.Text = "导入人员照片";
            this.mnu导入学生照片.Click += new System.EventHandler(this.mnu导入学生照片_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // cMnu_SelectColumns
            // 
            this.cMnu_SelectColumns.Name = "cMnu_SelectColumns";
            this.cMnu_SelectColumns.Size = new System.Drawing.Size(180, 22);
            this.cMnu_SelectColumns.Text = "选择列...";
            // 
            // cMnu_Export
            // 
            this.cMnu_Export.Name = "cMnu_Export";
            this.cMnu_Export.Size = new System.Drawing.Size(180, 22);
            this.cMnu_Export.Text = "导出人员信息...";
            // 
            // mnu导出人员照片
            // 
            this.mnu导出人员照片.Name = "mnu导出人员照片";
            this.mnu导出人员照片.Size = new System.Drawing.Size(180, 22);
            this.mnu导出人员照片.Text = "导出人员照片";
            this.mnu导出人员照片.Click += new System.EventHandler(this.mnu导出人员照片_Click);
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
            this.mn刷新部门,
            this.mnu_AddDivision,
            this.mnu_DeleteDivision,
            this.mnu_DepartmentProperty,
            this.toolStripSeparator8});
            this.DivisionMenu.Name = "contextMenuStrip1";
            this.DivisionMenu.Size = new System.Drawing.Size(127, 98);
            // 
            // mn刷新部门
            // 
            this.mn刷新部门.Name = "mn刷新部门";
            this.mn刷新部门.Size = new System.Drawing.Size(126, 22);
            this.mn刷新部门.Text = "刷新";
            this.mn刷新部门.Click += new System.EventHandler(this.mn刷新学校_Click);
            // 
            // mnu_AddDivision
            // 
            this.mnu_AddDivision.Name = "mnu_AddDivision";
            this.mnu_AddDivision.Size = new System.Drawing.Size(126, 22);
            this.mnu_AddDivision.Text = "增加部门";
            this.mnu_AddDivision.Click += new System.EventHandler(this.mnu_AddDivision_Click);
            // 
            // mnu_DeleteDivision
            // 
            this.mnu_DeleteDivision.Name = "mnu_DeleteDivision";
            this.mnu_DeleteDivision.Size = new System.Drawing.Size(126, 22);
            this.mnu_DeleteDivision.Text = "删除部门";
            this.mnu_DeleteDivision.Click += new System.EventHandler(this.mnu_DeleteDivision_Click);
            // 
            // mnu_DepartmentProperty
            // 
            this.mnu_DepartmentProperty.Name = "mnu_DepartmentProperty";
            this.mnu_DepartmentProperty.Size = new System.Drawing.Size(126, 22);
            this.mnu_DepartmentProperty.Text = "属性";
            this.mnu_DepartmentProperty.Click += new System.EventHandler(this.mnu_DivisionProperty_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(123, 6);
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
            this.menu.Controls.Add(this.panel5);
            this.menu.Controls.Add(this.panel1);
            this.menu.Controls.Add(this.label6);
            this.menu.Controls.Add(this.label7);
            this.menu.Controls.Add(this.btnFresh);
            this.menu.Controls.Add(this.txtStudentID1);
            this.menu.Controls.Add(this.label1);
            this.menu.Controls.Add(this.txtName);
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
            // txtStudentID1
            // 
            this.txtStudentID1.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.txtStudentID1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtStudentID1.Location = new System.Drawing.Point(276, 10);
            this.txtStudentID1.Name = "txtStudentID1";
            this.txtStudentID1.Size = new System.Drawing.Size(396, 34);
            this.txtStudentID1.TabIndex = 6;
            this.txtStudentID1.TextChanged += new System.EventHandler(this.txField_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "人员编号";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.txtName.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtName.Location = new System.Drawing.Point(276, 53);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(396, 34);
            this.txtName.TabIndex = 9;
            this.txtName.TextChanged += new System.EventHandler(this.txField_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 63);
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
            this.colCardID,
            this.col照片,
            this.col人脸识别,
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
            this.colFacility.HeaderText = "部门";
            this.colFacility.MinimumWidth = 150;
            this.colFacility.Name = "colFacility";
            this.colFacility.ReadOnly = true;
            this.colFacility.Width = 150;
            // 
            // colID
            // 
            this.colID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colID.HeaderText = "人员编号";
            this.colID.MinimumWidth = 150;
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Width = 150;
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
            this.colIDNumber.Width = 180;
            // 
            // colCardID
            // 
            this.colCardID.HeaderText = "卡号";
            this.colCardID.Name = "colCardID";
            this.colCardID.ReadOnly = true;
            this.colCardID.Width = 150;
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
            // col人脸识别
            // 
            this.col人脸识别.HeaderText = "人脸识别";
            this.col人脸识别.Name = "col人脸识别";
            this.col人脸识别.ReadOnly = true;
            this.col人脸识别.Width = 60;
            // 
            // colFill
            // 
            this.colFill.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colFill.HeaderText = "";
            this.colFill.Name = "colFill";
            this.colFill.ReadOnly = true;
            // 
            // Frm人员部门管理
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
            this.Name = "Frm人员部门管理";
            this.Text = "人员部门管理";
            this.Controls.SetChildIndex(this.pnlLeft, 0);
            this.Controls.SetChildIndex(this.splitter1, 0);
            this.Controls.SetChildIndex(this.ucPaging1, 0);
            this.Controls.SetChildIndex(this.menu, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.pnlLeft.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.DivisionMenu.ResumeLayout(false);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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
        private HH.ZK.CommonUI.Controls.FacilityTree divisionTree;
        private System.Windows.Forms.ContextMenuStrip DivisionMenu;
        private System.Windows.Forms.ToolStripMenuItem mnu_AddDivision;
        private System.Windows.Forms.ToolStripMenuItem mnu_DeleteDivision;
        private System.Windows.Forms.ToolStripMenuItem mnu_DepartmentProperty;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem mnu导入学生信息;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
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
        private System.Windows.Forms.Button btnFresh;
        private LJH.GeneralLibrary.WinformControl.DBCTextBox txtStudentID1;
        private System.Windows.Forms.Label label1;
        private LJH.GeneralLibrary.WinformControl.DBCTextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem mn刷新部门;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rd有人脸特征;
        private System.Windows.Forms.RadioButton rd无人脸特征;
        private System.Windows.Forms.RadioButton rd人脸特征全部;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem mnu导入学生照片;
        private System.Windows.Forms.DataGridViewTextBoxColumn col序号;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFacility;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCardID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn col照片;
        private System.Windows.Forms.DataGridViewCheckBoxColumn col人脸识别;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFill;
        private System.Windows.Forms.ToolStripMenuItem mnu导出人员照片;
    }
}