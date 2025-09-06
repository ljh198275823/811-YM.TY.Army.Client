namespace HH.ZK.UI
{
    partial class FrmStudentGroupImport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStudentGroupImport));
            this.panel1 = new System.Windows.Forms.Panel();
            this.第一步 = new System.Windows.Forms.GroupBox();
            this.lblSource = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.viewSource = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmb性别 = new System.Windows.Forms.ComboBox();
            this.cmb考试时间 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.cmbGroupID = new System.Windows.Forms.ComboBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.cmbChanel = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.cmbPhysical = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbID = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblDesCount = new System.Windows.Forms.Label();
            this.btnImport = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.viewDestination = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGroupID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhysicalItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col考试时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChannel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chk不按学校分组 = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.第一步.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewDestination)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.第一步);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(436, 634);
            this.panel1.TabIndex = 0;
            // 
            // 第一步
            // 
            this.第一步.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.第一步.Controls.Add(this.lblSource);
            this.第一步.Controls.Add(this.btnBrowse);
            this.第一步.Controls.Add(this.txtPath);
            this.第一步.Controls.Add(this.label2);
            this.第一步.Controls.Add(this.viewSource);
            this.第一步.Controls.Add(this.label1);
            this.第一步.Location = new System.Drawing.Point(3, 12);
            this.第一步.Name = "第一步";
            this.第一步.Size = new System.Drawing.Size(427, 619);
            this.第一步.TabIndex = 0;
            this.第一步.TabStop = false;
            this.第一步.Text = "第一步  指定数据源";
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
            this.btnBrowse.Location = new System.Drawing.Point(345, 44);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(76, 23);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Text = "浏览...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtPath
            // 
            this.txtPath.Enabled = false;
            this.txtPath.Location = new System.Drawing.Point(11, 44);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(328, 21);
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
            this.viewSource.AllowUserToResizeColumns = false;
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
            this.viewSource.Size = new System.Drawing.Size(417, 510);
            this.viewSource.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "数据源文件";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(436, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(252, 634);
            this.panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cmb性别);
            this.groupBox1.Controls.Add(this.cmb考试时间);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.cmbGroupID);
            this.groupBox1.Controls.Add(this.label27);
            this.groupBox1.Controls.Add(this.label28);
            this.groupBox1.Controls.Add(this.cmbChanel);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.cmbPhysical);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbID);
            this.groupBox1.Location = new System.Drawing.Point(6, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 619);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "第二步  映射设置";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(169, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 59;
            this.label8.Text = "性    别";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(136, 174);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 12);
            this.label9.TabIndex = 58;
            this.label9.Text = "-->";
            // 
            // cmb性别
            // 
            this.cmb性别.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb性别.FormattingEnabled = true;
            this.cmb性别.Location = new System.Drawing.Point(7, 170);
            this.cmb性别.Name = "cmb性别";
            this.cmb性别.Size = new System.Drawing.Size(121, 20);
            this.cmb性别.TabIndex = 57;
            this.cmb性别.Tag = "colSex";
            this.cmb性别.SelectedIndexChanged += new System.EventHandler(this.cmb_SelectedIndexChanged);
            // 
            // cmb考试时间
            // 
            this.cmb考试时间.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb考试时间.FormattingEnabled = true;
            this.cmb考试时间.Location = new System.Drawing.Point(7, 231);
            this.cmb考试时间.Name = "cmb考试时间";
            this.cmb考试时间.Size = new System.Drawing.Size(121, 20);
            this.cmb考试时间.TabIndex = 56;
            this.cmb考试时间.Tag = "col考试时间";
            this.cmb考试时间.SelectedIndexChanged += new System.EventHandler(this.cmb_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(169, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 55;
            this.label6.Text = "考试时间";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(136, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 12);
            this.label7.TabIndex = 54;
            this.label7.Text = "-->";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(169, 204);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(53, 12);
            this.label21.TabIndex = 53;
            this.label21.Text = "考试科目";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(136, 204);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(23, 12);
            this.label22.TabIndex = 52;
            this.label22.Text = "-->";
            // 
            // cmbGroupID
            // 
            this.cmbGroupID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGroupID.FormattingEnabled = true;
            this.cmbGroupID.Location = new System.Drawing.Point(7, 138);
            this.cmbGroupID.Name = "cmbGroupID";
            this.cmbGroupID.Size = new System.Drawing.Size(121, 20);
            this.cmbGroupID.TabIndex = 51;
            this.cmbGroupID.Tag = "colGroupID";
            this.cmbGroupID.SelectedIndexChanged += new System.EventHandler(this.cmb_SelectedIndexChanged);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(169, 266);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(53, 12);
            this.label27.TabIndex = 50;
            this.label27.Text = "道    次";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(136, 266);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(23, 12);
            this.label28.TabIndex = 49;
            this.label28.Text = "-->";
            // 
            // cmbChanel
            // 
            this.cmbChanel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChanel.FormattingEnabled = true;
            this.cmbChanel.Location = new System.Drawing.Point(7, 263);
            this.cmbChanel.Name = "cmbChanel";
            this.cmbChanel.Size = new System.Drawing.Size(121, 20);
            this.cmbChanel.TabIndex = 48;
            this.cmbChanel.Tag = "colChannel";
            this.cmbChanel.SelectedIndexChanged += new System.EventHandler(this.cmb_SelectedIndexChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(169, 142);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(59, 12);
            this.label19.TabIndex = 25;
            this.label19.Text = "组    号*";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(136, 142);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(23, 12);
            this.label20.TabIndex = 24;
            this.label20.Text = "-->";
            // 
            // cmbPhysical
            // 
            this.cmbPhysical.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPhysical.FormattingEnabled = true;
            this.cmbPhysical.Location = new System.Drawing.Point(7, 200);
            this.cmbPhysical.Name = "cmbPhysical";
            this.cmbPhysical.Size = new System.Drawing.Size(121, 20);
            this.cmbPhysical.TabIndex = 23;
            this.cmbPhysical.Tag = "colPhysicalItem";
            this.cmbPhysical.SelectedIndexChanged += new System.EventHandler(this.cmb_SelectedIndexChanged);
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(109, 299);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 12);
            this.label10.TabIndex = 11;
            this.label10.Text = "带 * 的项表示必填项";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(169, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "准考证号 *";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "-->";
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
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(688, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(754, 634);
            this.panel3.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.chk不按学校分组);
            this.groupBox2.Controls.Add(this.lblDesCount);
            this.groupBox2.Controls.Add(this.btnImport);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.viewDestination);
            this.groupBox2.Location = new System.Drawing.Point(6, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(748, 619);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "第三步";
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
            this.btnImport.Location = new System.Drawing.Point(89, 20);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(183, 47);
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
            this.colGroupID,
            this.colSex,
            this.colPhysicalItem,
            this.col考试时间,
            this.colChannel,
            this.colReason});
            this.viewDestination.Location = new System.Drawing.Point(6, 103);
            this.viewDestination.Name = "viewDestination";
            this.viewDestination.ReadOnly = true;
            this.viewDestination.RowHeadersVisible = false;
            this.viewDestination.RowTemplate.Height = 23;
            this.viewDestination.Size = new System.Drawing.Size(736, 510);
            this.viewDestination.TabIndex = 2;
            // 
            // colID
            // 
            this.colID.HeaderText = "准考证号";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colGroupID
            // 
            this.colGroupID.HeaderText = "组号";
            this.colGroupID.Name = "colGroupID";
            this.colGroupID.ReadOnly = true;
            // 
            // colSex
            // 
            this.colSex.HeaderText = "性别";
            this.colSex.Name = "colSex";
            this.colSex.ReadOnly = true;
            this.colSex.Width = 80;
            // 
            // colPhysicalItem
            // 
            this.colPhysicalItem.HeaderText = "考试科目";
            this.colPhysicalItem.Name = "colPhysicalItem";
            this.colPhysicalItem.ReadOnly = true;
            // 
            // col考试时间
            // 
            this.col考试时间.HeaderText = "考试时间";
            this.col考试时间.Name = "col考试时间";
            this.col考试时间.ReadOnly = true;
            // 
            // colChannel
            // 
            this.colChannel.HeaderText = "道次";
            this.colChannel.Name = "colChannel";
            this.colChannel.ReadOnly = true;
            // 
            // colReason
            // 
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Red;
            this.colReason.DefaultCellStyle = dataGridViewCellStyle1;
            this.colReason.HeaderText = "原因";
            this.colReason.Name = "colReason";
            this.colReason.ReadOnly = true;
            this.colReason.Width = 150;
            // 
            // chk不按学校分组
            // 
            this.chk不按学校分组.AutoSize = true;
            this.chk不按学校分组.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chk不按学校分组.ForeColor = System.Drawing.Color.Red;
            this.chk不按学校分组.Location = new System.Drawing.Point(285, 81);
            this.chk不按学校分组.Name = "chk不按学校分组";
            this.chk不按学校分组.Size = new System.Drawing.Size(115, 16);
            this.chk不按学校分组.TabIndex = 18;
            this.chk不按学校分组.Text = "多学校混合分组";
            this.chk不按学校分组.UseVisualStyleBackColor = true;
            // 
            // FrmStudentGroupImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1442, 634);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmStudentGroupImport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生考试分组信息导入";
            this.Load += new System.EventHandler(this.FrmStudentImport_Load);
            this.panel1.ResumeLayout(false);
            this.第一步.ResumeLayout(false);
            this.第一步.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewDestination)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox 第一步;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView viewSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView viewDestination;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.Label lblDesCount;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cmbPhysical;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.ComboBox cmbChanel;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox cmbGroupID;
        private System.Windows.Forms.ComboBox cmb考试时间;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmb性别;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGroupID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhysicalItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn col考试时间;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChannel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReason;
        private System.Windows.Forms.CheckBox chk不按学校分组;
    }
}