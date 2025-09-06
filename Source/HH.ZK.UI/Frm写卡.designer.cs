namespace HH.ZK.UI
{
    partial class Frm写卡
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm写卡));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataGridview1 = new System.Windows.Forms.DataGridView();
            this.colFacility = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnQuery = new System.Windows.Forms.Button();
            this.gpStep1 = new System.Windows.Forms.GroupBox();
            this.lblClear = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.chkOverride = new System.Windows.Forms.CheckBox();
            this.btnWrite = new System.Windows.Forms.Button();
            this.chkLog = new System.Windows.Forms.CheckBox();
            this.ucStudentSearch1 = new HH.ZK.CommonUI.Controls.UCStudentSearch();
            this.txtStudentID1 = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.cmbDivision = new HH.ZK.CommonUI.Controls.DivisionComboBox(this.components);
            this.txtGroupID = new HH.ZK.CommonUI.Controls.StudentGroupComboBox(this.components);
            this.cmbFacility = new HH.ZK.CommonUI.Controls.FacilityComboBox(this.components);
            this.txtName = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridview1)).BeginInit();
            this.gpStep1.SuspendLayout();
            this.ucStudentSearch1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 635);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1028, 22);
            this.statusStrip1.TabIndex = 118;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(1013, 17);
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
            this.colFacility,
            this.colClassName,
            this.colGroup,
            this.colID,
            this.colName,
            this.colSex,
            this.colFill});
            this.dataGridview1.Location = new System.Drawing.Point(1, 108);
            this.dataGridview1.Name = "dataGridview1";
            this.dataGridview1.RowHeadersVisible = false;
            this.dataGridview1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dataGridview1.RowTemplate.Height = 23;
            this.dataGridview1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridview1.Size = new System.Drawing.Size(751, 524);
            this.dataGridview1.TabIndex = 119;
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
            // colGroup
            // 
            this.colGroup.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colGroup.HeaderText = "组别";
            this.colGroup.Name = "colGroup";
            this.colGroup.ReadOnly = true;
            this.colGroup.Width = 54;
            // 
            // colID
            // 
            this.colID.HeaderText = "准考证号";
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
            // colFill
            // 
            this.colFill.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colFill.HeaderText = "";
            this.colFill.MinimumWidth = 100;
            this.colFill.Name = "colFill";
            this.colFill.ReadOnly = true;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(598, 12);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(154, 83);
            this.btnQuery.TabIndex = 133;
            this.btnQuery.Text = "查询(&Q)";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // gpStep1
            // 
            this.gpStep1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gpStep1.Controls.Add(this.lblClear);
            this.gpStep1.Controls.Add(this.btnClear);
            this.gpStep1.Controls.Add(this.chkOverride);
            this.gpStep1.Controls.Add(this.btnWrite);
            this.gpStep1.Controls.Add(this.chkLog);
            this.gpStep1.Location = new System.Drawing.Point(758, 108);
            this.gpStep1.Name = "gpStep1";
            this.gpStep1.Size = new System.Drawing.Size(270, 524);
            this.gpStep1.TabIndex = 134;
            this.gpStep1.TabStop = false;
            this.gpStep1.Text = "写卡";
            // 
            // lblClear
            // 
            this.lblClear.AutoSize = true;
            this.lblClear.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblClear.ForeColor = System.Drawing.Color.Red;
            this.lblClear.Location = new System.Drawing.Point(34, 212);
            this.lblClear.Name = "lblClear";
            this.lblClear.Size = new System.Drawing.Size(17, 16);
            this.lblClear.TabIndex = 145;
            this.lblClear.Text = "0";
            this.lblClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(34, 147);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(202, 41);
            this.btnClear.TabIndex = 144;
            this.btnClear.Text = "开始清除卡片";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // chkOverride
            // 
            this.chkOverride.AutoSize = true;
            this.chkOverride.ForeColor = System.Drawing.Color.Red;
            this.chkOverride.Location = new System.Drawing.Point(34, 59);
            this.chkOverride.Name = "chkOverride";
            this.chkOverride.Size = new System.Drawing.Size(168, 16);
            this.chkOverride.TabIndex = 142;
            this.chkOverride.Text = "覆盖卡片中已有的学生信息";
            this.chkOverride.UseVisualStyleBackColor = true;
            // 
            // btnWrite
            // 
            this.btnWrite.Enabled = false;
            this.btnWrite.Location = new System.Drawing.Point(34, 88);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(202, 41);
            this.btnWrite.TabIndex = 135;
            this.btnWrite.Text = "开始连续写卡(&W)";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // chkLog
            // 
            this.chkLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkLog.AutoSize = true;
            this.chkLog.Location = new System.Drawing.Point(34, 28);
            this.chkLog.Name = "chkLog";
            this.chkLog.Size = new System.Drawing.Size(72, 16);
            this.chkLog.TabIndex = 138;
            this.chkLog.Text = "记录日志";
            this.chkLog.UseVisualStyleBackColor = true;
            // 
            // ucStudentSearch1
            // 
            this.ucStudentSearch1.Controls.Add(this.txtStudentID1);
            this.ucStudentSearch1.Controls.Add(this.cmbDivision);
            this.ucStudentSearch1.Controls.Add(this.txtGroupID);
            this.ucStudentSearch1.Controls.Add(this.cmbFacility);
            this.ucStudentSearch1.Controls.Add(this.txtName);
            this.ucStudentSearch1.Location = new System.Drawing.Point(6, 3);
            this.ucStudentSearch1.Name = "ucStudentSearch1";
            this.ucStudentSearch1.Size = new System.Drawing.Size(562, 100);
            this.ucStudentSearch1.TabIndex = 179;
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
            // FrmWriteStudentToICCard_ZK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 657);
            this.Controls.Add(this.ucStudentSearch1);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.gpStep1);
            this.Controls.Add(this.dataGridview1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmWriteStudentToICCard_ZK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "学生信息写入IC卡";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmWriteStudentToICCard_FormClosed);
            this.Load += new System.EventHandler(this.FrmWriteStudentToICCard_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridview1)).EndInit();
            this.gpStep1.ResumeLayout(false);
            this.gpStep1.PerformLayout();
            this.ucStudentSearch1.ResumeLayout(false);
            this.ucStudentSearch1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.DataGridView dataGridview1;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.GroupBox gpStep1;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.CheckBox chkLog;
        private System.Windows.Forms.CheckBox chkOverride;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblClear;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFacility;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFill;
        private CommonUI.Controls.UCStudentSearch ucStudentSearch1;
        private LJH.GeneralLibrary.WinformControl.DBCTextBox txtStudentID1;
        private CommonUI.Controls.DivisionComboBox cmbDivision;
        private CommonUI.Controls.StudentGroupComboBox txtGroupID;
        private CommonUI.Controls.FacilityComboBox cmbFacility;
        private LJH.GeneralLibrary.WinformControl.DBCTextBox txtName;
    }
}