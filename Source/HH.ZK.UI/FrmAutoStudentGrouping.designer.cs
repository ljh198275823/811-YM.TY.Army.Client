namespace HH.ZK.UI
{
    partial class FrmAutoStudentGrouping
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAutoStudentGrouping));
            this.chk显示已分组学生 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chk缓考 = new System.Windows.Forms.CheckBox();
            this.chk择考 = new System.Windows.Forms.CheckBox();
            this.chk正常考试 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lnk考试科目 = new System.Windows.Forms.LinkLabel();
            this.txt考试科目 = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.btnQuery = new System.Windows.Forms.Button();
            this.dataGridview1 = new System.Windows.Forms.DataGridView();
            this.colHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFacility = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col考试科目 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.gpStudent = new System.Windows.Forms.GroupBox();
            this.chk分考试科目 = new System.Windows.Forms.CheckBox();
            this.chk分班级 = new System.Windows.Forms.CheckBox();
            this.chk最后两组平均 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt考试日期 = new System.Windows.Forms.TextBox();
            this.chk分学校 = new System.Windows.Forms.CheckBox();
            this.chk分性别 = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtInterval = new LJH.GeneralLibrary.WinformControl.IntergerTextBox(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnNone = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.ucStudentSearch1 = new HH.ZK.CommonUI.Controls.UCStudentSearch();
            this.txtStudentID1 = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.cmbDivision = new HH.ZK.CommonUI.Controls.DivisionComboBox(this.components);
            this.txtGroupID = new HH.ZK.CommonUI.Controls.StudentGroupComboBox(this.components);
            this.cmbFacility = new HH.ZK.CommonUI.Controls.FacilityComboBox(this.components);
            this.txtName = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridview1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.gpStudent.SuspendLayout();
            this.ucStudentSearch1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chk显示已分组学生
            // 
            resources.ApplyResources(this.chk显示已分组学生, "chk显示已分组学生");
            this.chk显示已分组学生.ForeColor = System.Drawing.Color.Red;
            this.chk显示已分组学生.Name = "chk显示已分组学生";
            this.chk显示已分组学生.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // chk缓考
            // 
            resources.ApplyResources(this.chk缓考, "chk缓考");
            this.chk缓考.Name = "chk缓考";
            this.chk缓考.UseVisualStyleBackColor = true;
            // 
            // chk择考
            // 
            resources.ApplyResources(this.chk择考, "chk择考");
            this.chk择考.Checked = true;
            this.chk择考.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk择考.Name = "chk择考";
            this.chk择考.UseVisualStyleBackColor = true;
            // 
            // chk正常考试
            // 
            resources.ApplyResources(this.chk正常考试, "chk正常考试");
            this.chk正常考试.Checked = true;
            this.chk正常考试.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk正常考试.Name = "chk正常考试";
            this.chk正常考试.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // lnk考试科目
            // 
            resources.ApplyResources(this.lnk考试科目, "lnk考试科目");
            this.lnk考试科目.Name = "lnk考试科目";
            this.lnk考试科目.TabStop = true;
            this.lnk考试科目.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk考试科目_LinkClicked);
            // 
            // txt考试科目
            // 
            this.txt考试科目.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.txt考试科目, "txt考试科目");
            this.txt考试科目.Name = "txt考试科目";
            this.txt考试科目.ReadOnly = true;
            // 
            // btnQuery
            // 
            resources.ApplyResources(this.btnQuery, "btnQuery");
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // dataGridview1
            // 
            this.dataGridview1.AllowUserToAddRows = false;
            this.dataGridview1.AllowUserToDeleteRows = false;
            this.dataGridview1.AllowUserToResizeRows = false;
            resources.ApplyResources(this.dataGridview1, "dataGridview1");
            this.dataGridview1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridview1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridview1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colHeader,
            this.colFacility,
            this.colID,
            this.colName,
            this.colSex,
            this.colClassName,
            this.col考试科目});
            this.dataGridview1.Name = "dataGridview1";
            this.dataGridview1.RowHeadersVisible = false;
            this.dataGridview1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dataGridview1.RowTemplate.Height = 23;
            this.dataGridview1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // colHeader
            // 
            resources.ApplyResources(this.colHeader, "colHeader");
            this.colHeader.Name = "colHeader";
            this.colHeader.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colFacility
            // 
            this.colFacility.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            resources.ApplyResources(this.colFacility, "colFacility");
            this.colFacility.Name = "colFacility";
            this.colFacility.ReadOnly = true;
            // 
            // colID
            // 
            resources.ApplyResources(this.colID, "colID");
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            // 
            // colName
            // 
            resources.ApplyResources(this.colName, "colName");
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colSex
            // 
            resources.ApplyResources(this.colSex, "colSex");
            this.colSex.Name = "colSex";
            this.colSex.ReadOnly = true;
            this.colSex.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colClassName
            // 
            resources.ApplyResources(this.colClassName, "colClassName");
            this.colClassName.Name = "colClassName";
            this.colClassName.ReadOnly = true;
            // 
            // col考试科目
            // 
            this.col考试科目.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.col考试科目, "col考试科目");
            this.col考试科目.Name = "col考试科目";
            this.col考试科目.ReadOnly = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            resources.ApplyResources(this.toolStripStatusLabel1, "toolStripStatusLabel1");
            this.toolStripStatusLabel1.Spring = true;
            // 
            // gpStudent
            // 
            resources.ApplyResources(this.gpStudent, "gpStudent");
            this.gpStudent.Controls.Add(this.chk分考试科目);
            this.gpStudent.Controls.Add(this.chk分班级);
            this.gpStudent.Controls.Add(this.chk最后两组平均);
            this.gpStudent.Controls.Add(this.label1);
            this.gpStudent.Controls.Add(this.txt考试日期);
            this.gpStudent.Controls.Add(this.chk分学校);
            this.gpStudent.Controls.Add(this.chk分性别);
            this.gpStudent.Controls.Add(this.label10);
            this.gpStudent.Controls.Add(this.txtInterval);
            this.gpStudent.Controls.Add(this.label4);
            this.gpStudent.Controls.Add(this.btnWrite);
            this.gpStudent.Name = "gpStudent";
            this.gpStudent.TabStop = false;
            // 
            // chk分考试科目
            // 
            resources.ApplyResources(this.chk分考试科目, "chk分考试科目");
            this.chk分考试科目.Checked = true;
            this.chk分考试科目.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk分考试科目.Name = "chk分考试科目";
            this.chk分考试科目.UseVisualStyleBackColor = true;
            // 
            // chk分班级
            // 
            resources.ApplyResources(this.chk分班级, "chk分班级");
            this.chk分班级.Name = "chk分班级";
            this.chk分班级.UseVisualStyleBackColor = true;
            // 
            // chk最后两组平均
            // 
            resources.ApplyResources(this.chk最后两组平均, "chk最后两组平均");
            this.chk最后两组平均.Checked = true;
            this.chk最后两组平均.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk最后两组平均.ForeColor = System.Drawing.Color.Red;
            this.chk最后两组平均.Name = "chk最后两组平均";
            this.chk最后两组平均.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // txt考试日期
            // 
            resources.ApplyResources(this.txt考试日期, "txt考试日期");
            this.txt考试日期.Name = "txt考试日期";
            // 
            // chk分学校
            // 
            resources.ApplyResources(this.chk分学校, "chk分学校");
            this.chk分学校.Checked = true;
            this.chk分学校.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk分学校.Name = "chk分学校";
            this.chk分学校.UseVisualStyleBackColor = true;
            // 
            // chk分性别
            // 
            resources.ApplyResources(this.chk分性别, "chk分性别");
            this.chk分性别.Checked = true;
            this.chk分性别.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk分性别.Name = "chk分性别";
            this.chk分性别.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // txtInterval
            // 
            resources.ApplyResources(this.txtInterval, "txtInterval");
            this.txtInterval.MaxValue = 65535;
            this.txtInterval.MinValue = 1;
            this.txtInterval.Name = "txtInterval";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // btnWrite
            // 
            resources.ApplyResources(this.btnWrite, "btnWrite");
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // btnNone
            // 
            resources.ApplyResources(this.btnNone, "btnNone");
            this.btnNone.Name = "btnNone";
            this.btnNone.UseVisualStyleBackColor = true;
            this.btnNone.Click += new System.EventHandler(this.btnNone_Click);
            // 
            // btnAll
            // 
            resources.ApplyResources(this.btnAll, "btnAll");
            this.btnAll.Name = "btnAll";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // ucStudentSearch1
            // 
            this.ucStudentSearch1.Controls.Add(this.txtStudentID1);
            this.ucStudentSearch1.Controls.Add(this.cmbDivision);
            this.ucStudentSearch1.Controls.Add(this.txtGroupID);
            this.ucStudentSearch1.Controls.Add(this.cmbFacility);
            this.ucStudentSearch1.Controls.Add(this.txtName);
            resources.ApplyResources(this.ucStudentSearch1, "ucStudentSearch1");
            this.ucStudentSearch1.Name = "ucStudentSearch1";
            // 
            // txtStudentID1
            // 
            resources.ApplyResources(this.txtStudentID1, "txtStudentID1");
            this.txtStudentID1.Name = "txtStudentID1";
            // 
            // cmbDivision
            // 
            this.cmbDivision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cmbDivision, "cmbDivision");
            this.cmbDivision.FormattingEnabled = true;
            this.cmbDivision.Name = "cmbDivision";
            // 
            // txtGroupID
            // 
            this.txtGroupID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.txtGroupID, "txtGroupID");
            this.txtGroupID.FormattingEnabled = true;
            this.txtGroupID.Name = "txtGroupID";
            // 
            // cmbFacility
            // 
            this.cmbFacility.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cmbFacility, "cmbFacility");
            this.cmbFacility.FormattingEnabled = true;
            this.cmbFacility.Name = "cmbFacility";
            // 
            // txtName
            // 
            resources.ApplyResources(this.txtName, "txtName");
            this.txtName.Name = "txtName";
            // 
            // FrmAutoStudentGrouping
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ucStudentSearch1);
            this.Controls.Add(this.chk择考);
            this.Controls.Add(this.chk缓考);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.chk显示已分组学生);
            this.Controls.Add(this.btnNone);
            this.Controls.Add(this.chk正常考试);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.gpStudent);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dataGridview1);
            this.Controls.Add(this.lnk考试科目);
            this.Controls.Add(this.txt考试科目);
            this.Name = "FrmAutoStudentGrouping";
            this.Load += new System.EventHandler(this.FrmScoreBillPrint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridview1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.gpStudent.ResumeLayout(false);
            this.gpStudent.PerformLayout();
            this.ucStudentSearch1.ResumeLayout(false);
            this.ucStudentSearch1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.DataGridView dataGridview1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.GroupBox gpStudent;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Button btnNone;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Label label10;
        private LJH.GeneralLibrary.WinformControl.IntergerTextBox txtInterval;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chk分学校;
        private System.Windows.Forms.CheckBox chk分性别;
        private System.Windows.Forms.LinkLabel lnk考试科目;
        private LJH.GeneralLibrary.WinformControl.DBCTextBox txt考试科目;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt考试日期;
        private System.Windows.Forms.CheckBox chk最后两组平均;
        private System.Windows.Forms.CheckBox chk分班级;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFacility;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col考试科目;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chk择考;
        private System.Windows.Forms.CheckBox chk正常考试;
        private System.Windows.Forms.CheckBox chk分考试科目;
        private System.Windows.Forms.CheckBox chk缓考;
        private System.Windows.Forms.CheckBox chk显示已分组学生;
        private System.Windows.Forms.Label label3;
        private CommonUI.Controls.UCStudentSearch ucStudentSearch1;
        private LJH.GeneralLibrary.WinformControl.DBCTextBox txtStudentID1;
        private CommonUI.Controls.DivisionComboBox cmbDivision;
        private CommonUI.Controls.StudentGroupComboBox txtGroupID;
        private CommonUI.Controls.FacilityComboBox cmbFacility;
        private LJH.GeneralLibrary.WinformControl.DBCTextBox txtName;
    }
}