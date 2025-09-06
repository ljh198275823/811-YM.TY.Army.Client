namespace HH.ZK.CommonUI
{
    partial class FrmScoreImport_SingleCol
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmScoreImport_SingleCol));
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpStep1 = new System.Windows.Forms.GroupBox();
            this.lblSource = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.viewSource = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grpStep2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbName = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmb测试时间 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbScore = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbPhysicalItem = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblDestination = new System.Windows.Forms.Label();
            this.lblArrow = new System.Windows.Forms.Label();
            this.cmbID = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.grpStep3 = new System.Windows.Forms.GroupBox();
            this.rdAppend = new System.Windows.Forms.RadioButton();
            this.rdOverride = new System.Windows.Forms.RadioButton();
            this.rdIgnore = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.lblDesCount = new System.Windows.Forms.Label();
            this.btnImport = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.viewDestination = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhysicalItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col测试时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.grpStep1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.grpStep2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.grpStep3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewDestination)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grpStep1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(436, 708);
            this.panel1.TabIndex = 0;
            // 
            // grpStep1
            // 
            this.grpStep1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpStep1.Controls.Add(this.lblSource);
            this.grpStep1.Controls.Add(this.btnBrowse);
            this.grpStep1.Controls.Add(this.txtPath);
            this.grpStep1.Controls.Add(this.label2);
            this.grpStep1.Controls.Add(this.viewSource);
            this.grpStep1.Controls.Add(this.label1);
            this.grpStep1.Location = new System.Drawing.Point(3, 12);
            this.grpStep1.Name = "grpStep1";
            this.grpStep1.Size = new System.Drawing.Size(427, 693);
            this.grpStep1.TabIndex = 0;
            this.grpStep1.TabStop = false;
            this.grpStep1.Text = "第一步  指定数据源";
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSource.ForeColor = System.Drawing.Color.Blue;
            this.lblSource.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSource.Location = new System.Drawing.Point(113, 86);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(58, 12);
            this.lblSource.TabIndex = 5;
            this.lblSource.Text = "  条数据";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(345, 40);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(76, 43);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Text = "浏览...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtPath
            // 
            this.txtPath.Enabled = false;
            this.txtPath.Location = new System.Drawing.Point(11, 38);
            this.txtPath.Multiline = true;
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(328, 45);
            this.txtPath.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "数据源预览";
            // 
            // viewSource
            // 
            this.viewSource.AllowUserToAddRows = false;
            this.viewSource.AllowUserToDeleteRows = false;
            this.viewSource.AllowUserToResizeRows = false;
            this.viewSource.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewSource.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewSource.Location = new System.Drawing.Point(4, 103);
            this.viewSource.Name = "viewSource";
            this.viewSource.ReadOnly = true;
            this.viewSource.RowHeadersVisible = false;
            this.viewSource.RowTemplate.Height = 23;
            this.viewSource.Size = new System.Drawing.Size(417, 584);
            this.viewSource.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "数据源文件";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.grpStep2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(436, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(252, 708);
            this.panel2.TabIndex = 1;
            // 
            // grpStep2
            // 
            this.grpStep2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpStep2.Controls.Add(this.label12);
            this.grpStep2.Controls.Add(this.label14);
            this.grpStep2.Controls.Add(this.cmbName);
            this.grpStep2.Controls.Add(this.label9);
            this.grpStep2.Controls.Add(this.label10);
            this.grpStep2.Controls.Add(this.cmb测试时间);
            this.grpStep2.Controls.Add(this.label6);
            this.grpStep2.Controls.Add(this.label7);
            this.grpStep2.Controls.Add(this.cmbScore);
            this.grpStep2.Controls.Add(this.label4);
            this.grpStep2.Controls.Add(this.label5);
            this.grpStep2.Controls.Add(this.cmbPhysicalItem);
            this.grpStep2.Controls.Add(this.label13);
            this.grpStep2.Controls.Add(this.label11);
            this.grpStep2.Controls.Add(this.lblDestination);
            this.grpStep2.Controls.Add(this.lblArrow);
            this.grpStep2.Controls.Add(this.cmbID);
            this.grpStep2.Location = new System.Drawing.Point(6, 12);
            this.grpStep2.Name = "grpStep2";
            this.grpStep2.Size = new System.Drawing.Size(240, 693);
            this.grpStep2.TabIndex = 1;
            this.grpStep2.TabStop = false;
            this.grpStep2.Text = "第二步  映射设置";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(176, 43);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 12);
            this.label12.TabIndex = 26;
            this.label12.Text = "姓名";
            this.label12.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(143, 43);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(23, 12);
            this.label14.TabIndex = 25;
            this.label14.Text = "-->";
            this.label14.Visible = false;
            // 
            // cmbName
            // 
            this.cmbName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbName.FormattingEnabled = true;
            this.cmbName.Location = new System.Drawing.Point(14, 40);
            this.cmbName.Name = "cmbName";
            this.cmbName.Size = new System.Drawing.Size(121, 20);
            this.cmbName.TabIndex = 24;
            this.cmbName.Tag = "colName";
            this.cmbName.Visible = false;
            this.cmbName.SelectedIndexChanged += new System.EventHandler(this.cmb_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(168, 221);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 23;
            this.label9.Text = "测试时间";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(135, 221);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 12);
            this.label10.TabIndex = 22;
            this.label10.Text = "-->";
            // 
            // cmb测试时间
            // 
            this.cmb测试时间.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb测试时间.FormattingEnabled = true;
            this.cmb测试时间.Location = new System.Drawing.Point(6, 218);
            this.cmb测试时间.Name = "cmb测试时间";
            this.cmb测试时间.Size = new System.Drawing.Size(121, 20);
            this.cmb测试时间.TabIndex = 21;
            this.cmb测试时间.Tag = "col测试时间";
            this.cmb测试时间.SelectedIndexChanged += new System.EventHandler(this.cmb_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(169, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 20;
            this.label6.Text = "成    绩 *";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(136, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 12);
            this.label7.TabIndex = 19;
            this.label7.Text = "-->";
            // 
            // cmbScore
            // 
            this.cmbScore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbScore.FormattingEnabled = true;
            this.cmbScore.Location = new System.Drawing.Point(7, 181);
            this.cmbScore.Name = "cmbScore";
            this.cmbScore.Size = new System.Drawing.Size(121, 20);
            this.cmbScore.TabIndex = 18;
            this.cmbScore.Tag = "colScore";
            this.cmbScore.SelectedIndexChanged += new System.EventHandler(this.cmb_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(169, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 17;
            this.label4.Text = "测试项   *";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(136, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 12);
            this.label5.TabIndex = 16;
            this.label5.Text = "-->";
            // 
            // cmbPhysicalItem
            // 
            this.cmbPhysicalItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPhysicalItem.FormattingEnabled = true;
            this.cmbPhysicalItem.Location = new System.Drawing.Point(7, 144);
            this.cmbPhysicalItem.Name = "cmbPhysicalItem";
            this.cmbPhysicalItem.Size = new System.Drawing.Size(121, 20);
            this.cmbPhysicalItem.TabIndex = 15;
            this.cmbPhysicalItem.Tag = "colPhysicalItem";
            this.cmbPhysicalItem.SelectedIndexChanged += new System.EventHandler(this.cmb_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(169, 86);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 14;
            this.label13.Text = "目标字段";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 86);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 12;
            this.label11.Text = "源数据列";
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Location = new System.Drawing.Point(169, 111);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(65, 12);
            this.lblDestination.TabIndex = 4;
            this.lblDestination.Text = "学    号 *";
            // 
            // lblArrow
            // 
            this.lblArrow.AutoSize = true;
            this.lblArrow.Location = new System.Drawing.Point(136, 111);
            this.lblArrow.Name = "lblArrow";
            this.lblArrow.Size = new System.Drawing.Size(23, 12);
            this.lblArrow.TabIndex = 3;
            this.lblArrow.Text = "-->";
            // 
            // cmbID
            // 
            this.cmbID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbID.FormattingEnabled = true;
            this.cmbID.Location = new System.Drawing.Point(7, 108);
            this.cmbID.Name = "cmbID";
            this.cmbID.Size = new System.Drawing.Size(121, 20);
            this.cmbID.TabIndex = 0;
            this.cmbID.Tag = "colID";
            this.cmbID.SelectedIndexChanged += new System.EventHandler(this.cmb_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.grpStep3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(688, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(737, 708);
            this.panel3.TabIndex = 2;
            // 
            // grpStep3
            // 
            this.grpStep3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpStep3.Controls.Add(this.rdAppend);
            this.grpStep3.Controls.Add(this.rdOverride);
            this.grpStep3.Controls.Add(this.rdIgnore);
            this.grpStep3.Controls.Add(this.label8);
            this.grpStep3.Controls.Add(this.lblDesCount);
            this.grpStep3.Controls.Add(this.btnImport);
            this.grpStep3.Controls.Add(this.label3);
            this.grpStep3.Controls.Add(this.viewDestination);
            this.grpStep3.Location = new System.Drawing.Point(6, 12);
            this.grpStep3.Name = "grpStep3";
            this.grpStep3.Size = new System.Drawing.Size(731, 693);
            this.grpStep3.TabIndex = 1;
            this.grpStep3.TabStop = false;
            this.grpStep3.Text = "第三步";
            // 
            // rdAppend
            // 
            this.rdAppend.AutoSize = true;
            this.rdAppend.Location = new System.Drawing.Point(249, 38);
            this.rdAppend.Name = "rdAppend";
            this.rdAppend.Size = new System.Drawing.Size(47, 16);
            this.rdAppend.TabIndex = 28;
            this.rdAppend.Text = "追加";
            this.rdAppend.UseVisualStyleBackColor = true;
            // 
            // rdOverride
            // 
            this.rdOverride.AutoSize = true;
            this.rdOverride.Location = new System.Drawing.Point(338, 38);
            this.rdOverride.Name = "rdOverride";
            this.rdOverride.Size = new System.Drawing.Size(95, 16);
            this.rdOverride.TabIndex = 27;
            this.rdOverride.Text = "覆盖现有成绩";
            this.rdOverride.UseVisualStyleBackColor = true;
            this.rdOverride.Visible = false;
            // 
            // rdIgnore
            // 
            this.rdIgnore.AutoSize = true;
            this.rdIgnore.Checked = true;
            this.rdIgnore.Location = new System.Drawing.Point(172, 38);
            this.rdIgnore.Name = "rdIgnore";
            this.rdIgnore.Size = new System.Drawing.Size(71, 16);
            this.rdIgnore.TabIndex = 26;
            this.rdIgnore.TabStop = true;
            this.rdIgnore.Text = "不再导入";
            this.rdIgnore.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 12);
            this.label8.TabIndex = 25;
            this.label8.Text = "当系统中已经存在学生成绩时";
            // 
            // lblDesCount
            // 
            this.lblDesCount.AutoSize = true;
            this.lblDesCount.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDesCount.ForeColor = System.Drawing.Color.Blue;
            this.lblDesCount.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDesCount.Location = new System.Drawing.Point(165, 86);
            this.lblDesCount.Name = "lblDesCount";
            this.lblDesCount.Size = new System.Drawing.Size(44, 12);
            this.lblDesCount.TabIndex = 17;
            this.lblDesCount.Text = "条数据";
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(266, 62);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(125, 35);
            this.btnImport.TabIndex = 13;
            this.btnImport.Text = "开始导入";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "待导入数据预览";
            // 
            // viewDestination
            // 
            this.viewDestination.AllowUserToAddRows = false;
            this.viewDestination.AllowUserToDeleteRows = false;
            this.viewDestination.AllowUserToResizeRows = false;
            this.viewDestination.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewDestination.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewDestination.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colName,
            this.colPhysicalItem,
            this.colScore,
            this.col测试时间,
            this.colReason});
            this.viewDestination.Location = new System.Drawing.Point(6, 103);
            this.viewDestination.Name = "viewDestination";
            this.viewDestination.ReadOnly = true;
            this.viewDestination.RowHeadersVisible = false;
            this.viewDestination.RowTemplate.Height = 23;
            this.viewDestination.Size = new System.Drawing.Size(719, 584);
            this.viewDestination.TabIndex = 2;
            // 
            // colID
            // 
            this.colID.HeaderText = "学号";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colID.Width = 120;
            // 
            // colName
            // 
            this.colName.HeaderText = "姓名";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colPhysicalItem
            // 
            this.colPhysicalItem.HeaderText = "测试项";
            this.colPhysicalItem.Name = "colPhysicalItem";
            this.colPhysicalItem.ReadOnly = true;
            this.colPhysicalItem.Width = 120;
            // 
            // colScore
            // 
            this.colScore.HeaderText = "成绩";
            this.colScore.Name = "colScore";
            this.colScore.ReadOnly = true;
            this.colScore.Width = 80;
            // 
            // col测试时间
            // 
            this.col测试时间.HeaderText = "测试时间";
            this.col测试时间.Name = "col测试时间";
            this.col测试时间.ReadOnly = true;
            this.col测试时间.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.col测试时间.Width = 130;
            // 
            // colReason
            // 
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Red;
            this.colReason.DefaultCellStyle = dataGridViewCellStyle1;
            this.colReason.HeaderText = "";
            this.colReason.MinimumWidth = 250;
            this.colReason.Name = "colReason";
            this.colReason.ReadOnly = true;
            this.colReason.Width = 250;
            // 
            // FrmScoreImport_SingleCol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1425, 708);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmScoreImport_SingleCol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生成绩导入";
            this.Load += new System.EventHandler(this.FrmStudentImport_Load);
            this.panel1.ResumeLayout(false);
            this.grpStep1.ResumeLayout(false);
            this.grpStep1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.grpStep2.ResumeLayout(false);
            this.grpStep2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.grpStep3.ResumeLayout(false);
            this.grpStep3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewDestination)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox grpStep1;
        private System.Windows.Forms.GroupBox grpStep2;
        private System.Windows.Forms.GroupBox grpStep3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView viewSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView viewDestination;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.Label lblArrow;
        private System.Windows.Forms.ComboBox cmbID;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.Label lblDesCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbScore;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbPhysicalItem;
        private System.Windows.Forms.RadioButton rdAppend;
        private System.Windows.Forms.RadioButton rdOverride;
        private System.Windows.Forms.RadioButton rdIgnore;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmb测试时间;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhysicalItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn col测试时间;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReason;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbName;
    }
}