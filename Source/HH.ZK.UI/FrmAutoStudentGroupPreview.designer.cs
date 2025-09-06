namespace HH.ZK.UI
{
    partial class FrmAutoStudentGroupPreview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAutoStudentGroupPreview));
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.groupView = new System.Windows.Forms.DataGridView();
            this.col考试时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhysicalItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFacilityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col性别 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.lblGroupCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbPhysicalItem = new HH.ZK.CommonUI.Controls.PhysicalItemComboBox(this.components);
            this.txtGroupID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlFill = new System.Windows.Forms.Panel();
            this.studentView = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.colChannel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFacility = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col考试科目 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIDNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupView)).BeginInit();
            this.statusStrip2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.pnlFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentView)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.groupView);
            this.pnlLeft.Controls.Add(this.statusStrip2);
            this.pnlLeft.Controls.Add(this.panel2);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(563, 663);
            this.pnlLeft.TabIndex = 34;
            // 
            // groupView
            // 
            this.groupView.AllowUserToAddRows = false;
            this.groupView.AllowUserToDeleteRows = false;
            this.groupView.AllowUserToResizeRows = false;
            this.groupView.BackgroundColor = System.Drawing.Color.White;
            this.groupView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.groupView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col考试时间,
            this.colPhysicalItem,
            this.colFacilityName,
            this.col性别,
            this.colNumber,
            this.colCount,
            this.colFill});
            this.groupView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupView.Location = new System.Drawing.Point(0, 77);
            this.groupView.Name = "groupView";
            this.groupView.RowHeadersVisible = false;
            this.groupView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupView.RowTemplate.Height = 23;
            this.groupView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.groupView.Size = new System.Drawing.Size(563, 564);
            this.groupView.TabIndex = 156;
            this.groupView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.groupView_CellClick);
            // 
            // col考试时间
            // 
            this.col考试时间.HeaderText = "考试时间";
            this.col考试时间.Name = "col考试时间";
            this.col考试时间.ReadOnly = true;
            // 
            // colPhysicalItem
            // 
            this.colPhysicalItem.HeaderText = "考试科目";
            this.colPhysicalItem.Name = "colPhysicalItem";
            this.colPhysicalItem.ReadOnly = true;
            this.colPhysicalItem.Width = 150;
            // 
            // colFacilityName
            // 
            this.colFacilityName.HeaderText = "学校";
            this.colFacilityName.Name = "colFacilityName";
            this.colFacilityName.ReadOnly = true;
            this.colFacilityName.Width = 120;
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
            // statusStrip2
            // 
            this.statusStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblGroupCount});
            this.statusStrip2.Location = new System.Drawing.Point(0, 641);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(563, 22);
            this.statusStrip2.TabIndex = 154;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // lblGroupCount
            // 
            this.lblGroupCount.Name = "lblGroupCount";
            this.lblGroupCount.Size = new System.Drawing.Size(548, 17);
            this.lblGroupCount.Spring = true;
            this.lblGroupCount.Text = "总共 0 项";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmbPhysicalItem);
            this.panel2.Controls.Add(this.txtGroupID);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(563, 77);
            this.panel2.TabIndex = 150;
            // 
            // cmbPhysicalItem
            // 
            this.cmbPhysicalItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPhysicalItem.FormattingEnabled = true;
            this.cmbPhysicalItem.Location = new System.Drawing.Point(66, 12);
            this.cmbPhysicalItem.Name = "cmbPhysicalItem";
            this.cmbPhysicalItem.Size = new System.Drawing.Size(491, 20);
            this.cmbPhysicalItem.TabIndex = 158;
            // 
            // txtGroupID
            // 
            this.txtGroupID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGroupID.Location = new System.Drawing.Point(66, 45);
            this.txtGroupID.Name = "txtGroupID";
            this.txtGroupID.Size = new System.Drawing.Size(491, 21);
            this.txtGroupID.TabIndex = 157;
            this.txtGroupID.TextChanged += new System.EventHandler(this.FreshData_Clicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 156;
            this.label1.Text = "考试组别";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 154;
            this.label2.Text = "考试科目";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.splitter1.Location = new System.Drawing.Point(563, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(6, 663);
            this.splitter1.TabIndex = 35;
            this.splitter1.TabStop = false;
            // 
            // pnlRight
            // 
            this.pnlRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRight.Controls.Add(this.btnSave);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRight.Location = new System.Drawing.Point(569, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(740, 77);
            this.pnlRight.TabIndex = 36;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.Blue;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(487, 11);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(240, 56);
            this.btnSave.TabIndex = 163;
            this.btnSave.Text = "保存所有分组(&S)";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlFill
            // 
            this.pnlFill.Controls.Add(this.studentView);
            this.pnlFill.Controls.Add(this.statusStrip1);
            this.pnlFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFill.Location = new System.Drawing.Point(569, 77);
            this.pnlFill.Name = "pnlFill";
            this.pnlFill.Size = new System.Drawing.Size(740, 586);
            this.pnlFill.TabIndex = 39;
            // 
            // studentView
            // 
            this.studentView.AllowUserToAddRows = false;
            this.studentView.AllowUserToDeleteRows = false;
            this.studentView.AllowUserToResizeRows = false;
            this.studentView.BackgroundColor = System.Drawing.Color.White;
            this.studentView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colChannel,
            this.colFacility,
            this.colID,
            this.colName,
            this.colSex,
            this.colClassName,
            this.col考试科目,
            this.colIDNumber});
            this.studentView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentView.Location = new System.Drawing.Point(0, 0);
            this.studentView.Name = "studentView";
            this.studentView.RowHeadersVisible = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.studentView.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.studentView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.studentView.RowTemplate.Height = 23;
            this.studentView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.studentView.Size = new System.Drawing.Size(740, 564);
            this.studentView.TabIndex = 154;
            this.studentView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentView_CellEndEdit);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblCount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 564);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(740, 22);
            this.statusStrip1.TabIndex = 153;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblCount
            // 
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(725, 17);
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
            // colFacility
            // 
            this.colFacility.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colFacility.HeaderText = "学校";
            this.colFacility.MinimumWidth = 100;
            this.colFacility.Name = "colFacility";
            this.colFacility.ReadOnly = true;
            this.colFacility.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colID
            // 
            this.colID.HeaderText = "准考证号";
            this.colID.MinimumWidth = 150;
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
            this.col考试科目.Name = "col考试科目";
            this.col考试科目.ReadOnly = true;
            this.col考试科目.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.col考试科目.Width = 59;
            // 
            // colIDNumber
            // 
            this.colIDNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colIDNumber.HeaderText = "身份证号";
            this.colIDNumber.MinimumWidth = 120;
            this.colIDNumber.Name = "colIDNumber";
            this.colIDNumber.ReadOnly = true;
            this.colIDNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colIDNumber.Visible = false;
            this.colIDNumber.Width = 120;
            // 
            // FrmAutoStudentGroupPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 663);
            this.Controls.Add(this.pnlFill);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.pnlLeft);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmAutoStudentGroupPreview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "考试分组预览";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupView)).EndInit();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlRight.ResumeLayout(false);
            this.pnlFill.ResumeLayout(false);
            this.pnlFill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentView)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel pnlFill;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView studentView;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblCount;
        private System.Windows.Forms.TextBox txtGroupID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel lblGroupCount;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView groupView;
        private System.Windows.Forms.DataGridViewTextBoxColumn col考试时间;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhysicalItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFacilityName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col性别;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFill;
        private CommonUI.Controls.PhysicalItemComboBox cmbPhysicalItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChannel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFacility;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col考试科目;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDNumber;
    }
}

