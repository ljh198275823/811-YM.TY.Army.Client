namespace HH.ZK.UI
{
    partial class Frm学生成绩管理
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm学生成绩管理));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnu设置学生类别 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu设置学生考试科目 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu删除所选学生 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu删除所选成绩 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu取消检录 = new System.Windows.Forms.ToolStripMenuItem();
            this.rd未测试 = new System.Windows.Forms.RadioButton();
            this.rd没有完成测试 = new System.Windows.Forms.RadioButton();
            this.rd测试完成 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rd全部 = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colFacility = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col检录 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col考试科目 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col加分 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col总分 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col打印 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cmbFacility = new HH.ZK.CommonUI.Controls.FacilityComboBox(this.components);
            this.ucStudentSearch1 = new HH.ZK.CommonUI.Controls.UCStudentSearch();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rd所有特殊状态 = new System.Windows.Forms.RadioButton();
            this.rd指定状态 = new System.Windows.Forms.RadioButton();
            this.rd不限状态 = new System.Windows.Forms.RadioButton();
            this.txt考试状态 = new HH.ZK.CommonUI.Controls.StudentStateComboBox(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.rd检录All = new System.Windows.Forms.RadioButton();
            this.rd已检录 = new System.Windows.Forms.RadioButton();
            this.rd未检录 = new System.Windows.Forms.RadioButton();
            this.txtClassName = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.mnu设置学生考试科目,
            this.toolStripSeparator1,
            this.mnu删除所选学生,
            this.mnu删除所选成绩,
            this.mnu取消检录});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // mnu设置学生类别
            // 
            this.mnu设置学生类别.Name = "mnu设置学生类别";
            resources.ApplyResources(this.mnu设置学生类别, "mnu设置学生类别");
            this.mnu设置学生类别.Click += new System.EventHandler(this.mnu设置学生类别_Click);
            // 
            // mnu设置学生考试科目
            // 
            this.mnu设置学生考试科目.Name = "mnu设置学生考试科目";
            resources.ApplyResources(this.mnu设置学生考试科目, "mnu设置学生考试科目");
            this.mnu设置学生考试科目.Click += new System.EventHandler(this.mnu设置学生考试科目_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // mnu删除所选学生
            // 
            this.mnu删除所选学生.Name = "mnu删除所选学生";
            resources.ApplyResources(this.mnu删除所选学生, "mnu删除所选学生");
            this.mnu删除所选学生.Click += new System.EventHandler(this.mnu删除所选学生_Click);
            // 
            // mnu删除所选成绩
            // 
            this.mnu删除所选成绩.Name = "mnu删除所选成绩";
            resources.ApplyResources(this.mnu删除所选成绩, "mnu删除所选成绩");
            this.mnu删除所选成绩.Click += new System.EventHandler(this.mnu删除所选成绩_Click);
            // 
            // mnu取消检录
            // 
            this.mnu取消检录.Name = "mnu取消检录";
            resources.ApplyResources(this.mnu取消检录, "mnu取消检录");
            this.mnu取消检录.Click += new System.EventHandler(this.mnu取消检录_Click);
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
            this.colClassName,
            this.col检录,
            this.colGroup,
            this.col考试科目,
            this.colState,
            this.col加分,
            this.col总分,
            this.col打印});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("宋体", 10.5F);
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
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
            // colClassName
            // 
            resources.ApplyResources(this.colClassName, "colClassName");
            this.colClassName.Name = "colClassName";
            this.colClassName.ReadOnly = true;
            // 
            // col检录
            // 
            resources.ApplyResources(this.col检录, "col检录");
            this.col检录.Name = "col检录";
            this.col检录.ReadOnly = true;
            this.col检录.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colGroup
            // 
            this.colGroup.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            resources.ApplyResources(this.colGroup, "colGroup");
            this.colGroup.Name = "colGroup";
            this.colGroup.ReadOnly = true;
            // 
            // col考试科目
            // 
            this.col考试科目.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            resources.ApplyResources(this.col考试科目, "col考试科目");
            this.col考试科目.Name = "col考试科目";
            this.col考试科目.ReadOnly = true;
            // 
            // colState
            // 
            resources.ApplyResources(this.colState, "colState");
            this.colState.Name = "colState";
            this.colState.ReadOnly = true;
            // 
            // col加分
            // 
            resources.ApplyResources(this.col加分, "col加分");
            this.col加分.Name = "col加分";
            this.col加分.ReadOnly = true;
            // 
            // col总分
            // 
            resources.ApplyResources(this.col总分, "col总分");
            this.col总分.Name = "col总分";
            this.col总分.ReadOnly = true;
            // 
            // col打印
            // 
            resources.ApplyResources(this.col打印, "col打印");
            this.col打印.Name = "col打印";
            this.col打印.ReadOnly = true;
            // 
            // cmbFacility
            // 
            this.cmbFacility.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cmbFacility, "cmbFacility");
            this.cmbFacility.FormattingEnabled = true;
            this.cmbFacility.Name = "cmbFacility";
            // 
            // ucStudentSearch1
            // 
            resources.ApplyResources(this.ucStudentSearch1, "ucStudentSearch1");
            this.ucStudentSearch1.Name = "ucStudentSearch1";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.rd所有特殊状态);
            this.panel2.Controls.Add(this.rd指定状态);
            this.panel2.Controls.Add(this.rd不限状态);
            this.panel2.Controls.Add(this.txt考试状态);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // rd所有特殊状态
            // 
            resources.ApplyResources(this.rd所有特殊状态, "rd所有特殊状态");
            this.rd所有特殊状态.Name = "rd所有特殊状态";
            this.rd所有特殊状态.UseVisualStyleBackColor = true;
            // 
            // rd指定状态
            // 
            resources.ApplyResources(this.rd指定状态, "rd指定状态");
            this.rd指定状态.Name = "rd指定状态";
            this.rd指定状态.UseVisualStyleBackColor = true;
            this.rd指定状态.CheckedChanged += new System.EventHandler(this.rd指定状态_CheckedChanged);
            // 
            // rd不限状态
            // 
            resources.ApplyResources(this.rd不限状态, "rd不限状态");
            this.rd不限状态.Checked = true;
            this.rd不限状态.Name = "rd不限状态";
            this.rd不限状态.TabStop = true;
            this.rd不限状态.UseVisualStyleBackColor = true;
            // 
            // txt考试状态
            // 
            this.txt考试状态.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.txt考试状态, "txt考试状态");
            this.txt考试状态.FormattingEnabled = true;
            this.txt考试状态.Name = "txt考试状态";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.rd检录All);
            this.panel3.Controls.Add(this.rd已检录);
            this.panel3.Controls.Add(this.rd未检录);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // rd检录All
            // 
            resources.ApplyResources(this.rd检录All, "rd检录All");
            this.rd检录All.Checked = true;
            this.rd检录All.Name = "rd检录All";
            this.rd检录All.TabStop = true;
            this.rd检录All.UseVisualStyleBackColor = true;
            // 
            // rd已检录
            // 
            resources.ApplyResources(this.rd已检录, "rd已检录");
            this.rd已检录.Name = "rd已检录";
            this.rd已检录.UseVisualStyleBackColor = true;
            // 
            // rd未检录
            // 
            resources.ApplyResources(this.rd未检录, "rd未检录");
            this.rd未检录.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rd未检录.Name = "rd未检录";
            this.rd未检录.UseVisualStyleBackColor = true;
            // 
            // txtClassName
            // 
            resources.ApplyResources(this.txtClassName, "txtClassName");
            this.txtClassName.Name = "txtClassName";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // Frm学生成绩管理
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtClassName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ucStudentSearch1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "Frm学生成绩管理";
            this.Controls.SetChildIndex(this.btnSearch, 0);
            this.Controls.SetChildIndex(this.btnSaveAs, 0);
            this.Controls.SetChildIndex(this.btnColumn, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.ucStudentSearch1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtClassName, 0);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem mnu删除所选学生;
        private System.Windows.Forms.ToolStripMenuItem mnu设置学生类别;
        private System.Windows.Forms.RadioButton rd全部;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private CommonUI.Controls.UCStudentSearch ucStudentSearch1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rd所有特殊状态;
        private System.Windows.Forms.RadioButton rd指定状态;
        private System.Windows.Forms.RadioButton rd不限状态;
        private CommonUI.Controls.StudentStateComboBox txt考试状态;
        private System.Windows.Forms.ToolStripMenuItem mnu设置学生考试科目;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rd检录All;
        private System.Windows.Forms.RadioButton rd已检录;
        private System.Windows.Forms.RadioButton rd未检录;
        private LJH.GeneralLibrary.WinformControl.DBCTextBox txtClassName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem mnu取消检录;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFacility;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col检录;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn col考试科目;
        private System.Windows.Forms.DataGridViewTextBoxColumn colState;
        private System.Windows.Forms.DataGridViewTextBoxColumn col加分;
        private System.Windows.Forms.DataGridViewTextBoxColumn col总分;
        private System.Windows.Forms.DataGridViewCheckBoxColumn col打印;
    }
}