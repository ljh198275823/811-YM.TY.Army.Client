namespace HH.ZK.UI
{
    partial class Frm训练成绩管理
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm训练成绩管理));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnu设置学生类别 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu删除所选成绩 = new System.Windows.Forms.ToolStripMenuItem();
            this.rd未测试 = new System.Windows.Forms.RadioButton();
            this.rd没有完成测试 = new System.Windows.Forms.RadioButton();
            this.rd测试完成 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rd全部 = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbFacility = new HH.ZK.CommonUI.Controls.FacilityComboBox(this.components);
            this.txtProject = new HH.ZK.CommonUI.Controls.PhysicalProjectComboBox(this.components);
            this.ucStudentSearch1 = new HH.ZK.CommonUI.Controls.UCStudentSearch();
            this.label1 = new System.Windows.Forms.Label();
            this.dt开始训练日期 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dt结束训练日期 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.colFacility = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col训练日期 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col训练大纲 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col状态 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col总分 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnColumn
            // 
            resources.ApplyResources(this.btnColumn, "btnColumn");
            // 
            // btnSaveAs
            // 
            resources.ApplyResources(this.btnSaveAs, "btnSaveAs");
            // 
            // btnSearch
            // 
            resources.ApplyResources(this.btnSearch, "btnSearch");
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu设置学生类别,
            this.toolStripSeparator1,
            this.mnu删除所选成绩});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // mnu设置学生类别
            // 
            this.mnu设置学生类别.Name = "mnu设置学生类别";
            resources.ApplyResources(this.mnu设置学生类别, "mnu设置学生类别");
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // mnu删除所选成绩
            // 
            this.mnu删除所选成绩.Name = "mnu删除所选成绩";
            resources.ApplyResources(this.mnu删除所选成绩, "mnu删除所选成绩");
            this.mnu删除所选成绩.Click += new System.EventHandler(this.mnu删除所选成绩_Click);
            // 
            // rd未测试
            // 
            resources.ApplyResources(this.rd未测试, "rd未测试");
            this.rd未测试.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rd未测试.Name = "rd未测试";
            this.rd未测试.UseVisualStyleBackColor = true;
            // 
            // rd没有完成测试
            // 
            resources.ApplyResources(this.rd没有完成测试, "rd没有完成测试");
            this.rd没有完成测试.Name = "rd没有完成测试";
            this.rd没有完成测试.UseVisualStyleBackColor = true;
            // 
            // rd测试完成
            // 
            resources.ApplyResources(this.rd测试完成, "rd测试完成");
            this.rd测试完成.Name = "rd测试完成";
            this.rd测试完成.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rd全部);
            this.panel1.Controls.Add(this.rd测试完成);
            this.panel1.Controls.Add(this.rd未测试);
            this.panel1.Controls.Add(this.rd没有完成测试);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // rd全部
            // 
            resources.ApplyResources(this.rd全部, "rd全部");
            this.rd全部.Checked = true;
            this.rd全部.Name = "rd全部";
            this.rd全部.TabStop = true;
            this.rd全部.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Controls.Add(this.cmbFacility);
            this.panel4.Name = "panel4";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFacility,
            this.colID,
            this.colName,
            this.colSex,
            this.col训练日期,
            this.col训练大纲,
            this.col状态,
            this.col总分});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("宋体", 10.5F);
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // cmbFacility
            // 
            this.cmbFacility.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cmbFacility, "cmbFacility");
            this.cmbFacility.FormattingEnabled = true;
            this.cmbFacility.Name = "cmbFacility";
            // 
            // txtProject
            // 
            resources.ApplyResources(this.txtProject, "txtProject");
            this.txtProject.FormattingEnabled = true;
            this.txtProject.Name = "txtProject";
            this.txtProject.SelectedIndexChanged += new System.EventHandler(this.txtProject_SelectedIndexChanged);
            // 
            // ucStudentSearch1
            // 
            this.ucStudentSearch1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.ucStudentSearch1, "ucStudentSearch1");
            this.ucStudentSearch1.Name = "ucStudentSearch1";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // dt开始训练日期
            // 
            resources.ApplyResources(this.dt开始训练日期, "dt开始训练日期");
            this.dt开始训练日期.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt开始训练日期.Name = "dt开始训练日期";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // dt结束训练日期
            // 
            resources.ApplyResources(this.dt结束训练日期, "dt结束训练日期");
            this.dt结束训练日期.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt结束训练日期.Name = "dt结束训练日期";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
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
            this.colID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
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
            // 
            // col训练日期
            // 
            resources.ApplyResources(this.col训练日期, "col训练日期");
            this.col训练日期.Name = "col训练日期";
            this.col训练日期.ReadOnly = true;
            this.col训练日期.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // col训练大纲
            // 
            resources.ApplyResources(this.col训练大纲, "col训练大纲");
            this.col训练大纲.Name = "col训练大纲";
            this.col训练大纲.ReadOnly = true;
            // 
            // col状态
            // 
            resources.ApplyResources(this.col状态, "col状态");
            this.col状态.Name = "col状态";
            this.col状态.ReadOnly = true;
            // 
            // col总分
            // 
            resources.ApplyResources(this.col总分, "col总分");
            this.col总分.Name = "col总分";
            this.col总分.ReadOnly = true;
            // 
            // Frm训练成绩管理
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dt结束训练日期);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dt开始训练日期);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProject);
            this.Controls.Add(this.ucStudentSearch1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "Frm训练成绩管理";
            this.Controls.SetChildIndex(this.btnSearch, 0);
            this.Controls.SetChildIndex(this.btnSaveAs, 0);
            this.Controls.SetChildIndex(this.btnColumn, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.ucStudentSearch1, 0);
            this.Controls.SetChildIndex(this.txtProject, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.dt开始训练日期, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.dt结束训练日期, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rd未测试;
        private System.Windows.Forms.RadioButton rd没有完成测试;
        private System.Windows.Forms.RadioButton rd测试完成;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnu删除所选成绩;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CommonUI.Controls.FacilityComboBox cmbFacility;
        private System.Windows.Forms.ToolStripMenuItem mnu设置学生类别;
        private System.Windows.Forms.RadioButton rd全部;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private CommonUI.Controls.UCStudentSearch ucStudentSearch1;
        private CommonUI.Controls.PhysicalProjectComboBox txtProject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dt开始训练日期;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dt结束训练日期;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFacility;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn col训练日期;
        private System.Windows.Forms.DataGridViewTextBoxColumn col训练大纲;
        private System.Windows.Forms.DataGridViewTextBoxColumn col状态;
        private System.Windows.Forms.DataGridViewTextBoxColumn col总分;
    }
}