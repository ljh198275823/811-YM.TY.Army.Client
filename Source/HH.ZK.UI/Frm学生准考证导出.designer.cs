namespace HH.ZK.UI
{
    partial class Frm学生准考证导出
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm学生准考证导出));
            this.menu = new System.Windows.Forms.Panel();
            this.btn导出所选分组准考证 = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.lbl选择数量 = new System.Windows.Forms.Label();
            this.btnNone = new System.Windows.Forms.Button();
            this.cmbPhysicalItem = new HH.ZK.CommonUI.Controls.PhysicalItemComboBox(this.components);
            this.txt考试时间 = new System.Windows.Forms.ComboBox();
            this.cmbFacility = new HH.ZK.CommonUI.Controls.FacilityComboBox(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdSexAll = new System.Windows.Forms.RadioButton();
            this.rdFemale = new System.Windows.Forms.RadioButton();
            this.rdMale = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFresh = new System.Windows.Forms.Button();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.dataGridview1 = new System.Windows.Forms.DataGridView();
            this.col考试时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhysicalItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFacility = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col性别 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.lblGroupCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.menu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridview1)).BeginInit();
            this.statusStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.Control;
            this.menu.Controls.Add(this.btn导出所选分组准考证);
            this.menu.Controls.Add(this.btnAll);
            this.menu.Controls.Add(this.lbl选择数量);
            this.menu.Controls.Add(this.btnNone);
            this.menu.Controls.Add(this.cmbPhysicalItem);
            this.menu.Controls.Add(this.txt考试时间);
            this.menu.Controls.Add(this.cmbFacility);
            this.menu.Controls.Add(this.label8);
            this.menu.Controls.Add(this.label6);
            this.menu.Controls.Add(this.panel2);
            this.menu.Controls.Add(this.label2);
            this.menu.Controls.Add(this.label1);
            this.menu.Controls.Add(this.btnFresh);
            this.menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1243, 94);
            this.menu.TabIndex = 33;
            // 
            // btn导出所选分组准考证
            // 
            this.btn导出所选分组准考证.Location = new System.Drawing.Point(960, 18);
            this.btn导出所选分组准考证.Name = "btn导出所选分组准考证";
            this.btn导出所选分组准考证.Size = new System.Drawing.Size(169, 67);
            this.btn导出所选分组准考证.TabIndex = 191;
            this.btn导出所选分组准考证.Text = "导出所选分组准考证";
            this.btn导出所选分组准考证.UseVisualStyleBackColor = true;
            this.btn导出所选分组准考证.Click += new System.EventHandler(this.btn导出所选分组准考证_Click);
            // 
            // btnAll
            // 
            this.btnAll.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAll.Location = new System.Drawing.Point(724, 29);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(89, 25);
            this.btnAll.TabIndex = 190;
            this.btnAll.Text = "全选(&A)";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // lbl选择数量
            // 
            this.lbl选择数量.AutoSize = true;
            this.lbl选择数量.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Bold);
            this.lbl选择数量.ForeColor = System.Drawing.Color.Blue;
            this.lbl选择数量.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl选择数量.Location = new System.Drawing.Point(833, 41);
            this.lbl选择数量.Name = "lbl选择数量";
            this.lbl选择数量.Size = new System.Drawing.Size(27, 27);
            this.lbl选择数量.TabIndex = 189;
            this.lbl选择数量.Text = "0";
            this.lbl选择数量.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnNone
            // 
            this.btnNone.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnNone.Location = new System.Drawing.Point(724, 60);
            this.btnNone.Name = "btnNone";
            this.btnNone.Size = new System.Drawing.Size(89, 25);
            this.btnNone.TabIndex = 188;
            this.btnNone.Text = "全不选(&N)";
            this.btnNone.UseVisualStyleBackColor = true;
            this.btnNone.Click += new System.EventHandler(this.btnNone_Click);
            // 
            // cmbPhysicalItem
            // 
            this.cmbPhysicalItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPhysicalItem.FormattingEnabled = true;
            this.cmbPhysicalItem.Location = new System.Drawing.Point(383, 53);
            this.cmbPhysicalItem.Name = "cmbPhysicalItem";
            this.cmbPhysicalItem.Size = new System.Drawing.Size(150, 23);
            this.cmbPhysicalItem.TabIndex = 186;
            this.cmbPhysicalItem.SelectedIndexChanged += new System.EventHandler(this.FreshData_Clicked);
            // 
            // txt考试时间
            // 
            this.txt考试时间.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt考试时间.FormattingEnabled = true;
            this.txt考试时间.Location = new System.Drawing.Point(78, 53);
            this.txt考试时间.Name = "txt考试时间";
            this.txt考试时间.Size = new System.Drawing.Size(227, 23);
            this.txt考试时间.TabIndex = 185;
            this.txt考试时间.SelectedIndexChanged += new System.EventHandler(this.FreshData_Clicked);
            // 
            // cmbFacility
            // 
            this.cmbFacility.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFacility.FormattingEnabled = true;
            this.cmbFacility.Location = new System.Drawing.Point(78, 18);
            this.cmbFacility.Name = "cmbFacility";
            this.cmbFacility.Size = new System.Drawing.Size(227, 23);
            this.cmbFacility.TabIndex = 184;
            this.cmbFacility.SelectedIndexChanged += new System.EventHandler(this.FreshData_Clicked);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(43, 22);
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
            this.label6.Location = new System.Drawing.Point(347, 22);
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
            this.panel2.Location = new System.Drawing.Point(383, 19);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(321, 57);
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
            this.label1.Location = new System.Drawing.Point(16, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 156;
            this.label1.Text = "考试时间";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnFresh
            // 
            this.btnFresh.Location = new System.Drawing.Point(566, 18);
            this.btnFresh.Name = "btnFresh";
            this.btnFresh.Size = new System.Drawing.Size(143, 67);
            this.btnFresh.TabIndex = 163;
            this.btnFresh.Text = "刷新";
            this.btnFresh.UseVisualStyleBackColor = true;
            this.btnFresh.Click += new System.EventHandler(this.mnuFresh_Click);
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.dataGridview1);
            this.pnlLeft.Controls.Add(this.statusStrip2);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLeft.Location = new System.Drawing.Point(0, 94);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(1243, 595);
            this.pnlLeft.TabIndex = 34;
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
            this.dataGridview1.ColumnHeadersHeight = 30;
            this.dataGridview1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridview1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col考试时间,
            this.colPhysicalItem,
            this.colFacility,
            this.col性别,
            this.colNumber,
            this.colCount,
            this.colFill});
            this.dataGridview1.Location = new System.Drawing.Point(0, 0);
            this.dataGridview1.Name = "dataGridview1";
            this.dataGridview1.RowHeadersVisible = false;
            this.dataGridview1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("宋体", 10.5F);
            this.dataGridview1.RowTemplate.Height = 30;
            this.dataGridview1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridview1.Size = new System.Drawing.Size(1243, 573);
            this.dataGridview1.TabIndex = 155;
            this.dataGridview1.SelectionChanged += new System.EventHandler(this.dataGridview1_SelectionChanged);
            // 
            // col考试时间
            // 
            this.col考试时间.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.col考试时间.HeaderText = "考试时间";
            this.col考试时间.MinimumWidth = 120;
            this.col考试时间.Name = "col考试时间";
            this.col考试时间.ReadOnly = true;
            this.col考试时间.Width = 120;
            // 
            // colPhysicalItem
            // 
            this.colPhysicalItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colPhysicalItem.HeaderText = "考试科目";
            this.colPhysicalItem.MinimumWidth = 150;
            this.colPhysicalItem.Name = "colPhysicalItem";
            this.colPhysicalItem.ReadOnly = true;
            this.colPhysicalItem.Width = 150;
            // 
            // colFacility
            // 
            this.colFacility.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
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
            this.colNumber.Width = 80;
            // 
            // colCount
            // 
            this.colCount.HeaderText = "人数";
            this.colCount.Name = "colCount";
            this.colCount.ReadOnly = true;
            this.colCount.Width = 80;
            // 
            // colFill
            // 
            this.colFill.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colFill.HeaderText = "";
            this.colFill.Name = "colFill";
            this.colFill.ReadOnly = true;
            // 
            // statusStrip2
            // 
            this.statusStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblGroupCount});
            this.statusStrip2.Location = new System.Drawing.Point(0, 573);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(1243, 22);
            this.statusStrip2.TabIndex = 154;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // lblGroupCount
            // 
            this.lblGroupCount.Name = "lblGroupCount";
            this.lblGroupCount.Size = new System.Drawing.Size(1228, 17);
            this.lblGroupCount.Spring = true;
            this.lblGroupCount.Text = "总共 0 项";
            // 
            // Frm学生准考证导出
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 689);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Frm学生准考证导出";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生准考证导出";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridview1)).EndInit();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menu;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridview1;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel lblGroupCount;
        private System.Windows.Forms.Button btnFresh;
        private HH.ZK.CommonUI.Controls.FacilityComboBox cmbFacility;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdSexAll;
        private System.Windows.Forms.RadioButton rdFemale;
        private System.Windows.Forms.RadioButton rdMale;
        private System.Windows.Forms.ComboBox txt考试时间;
        private HH.ZK.CommonUI.Controls.PhysicalItemComboBox cmbPhysicalItem;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Label lbl选择数量;
        private System.Windows.Forms.Button btnNone;
        private System.Windows.Forms.Button btn导出所选分组准考证;
        private System.Windows.Forms.DataGridViewTextBoxColumn col考试时间;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhysicalItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFacility;
        private System.Windows.Forms.DataGridViewTextBoxColumn col性别;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFill;
    }
}

