namespace HH.ZK.CommonUI
{
    partial class Frm删除学生成绩
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm删除学生成绩));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colFacility = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhysicalItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col成绩来源 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMemo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnu删除所选成绩 = new System.Windows.Forms.ToolStripMenuItem();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdSexAll = new System.Windows.Forms.RadioButton();
            this.rdFemale = new System.Windows.Forms.RadioButton();
            this.rdMale = new System.Windows.Forms.RadioButton();
            this.txtStudentID1 = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.txtName = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.ucFacilitySearch1 = new HH.ZK.CommonUI.Controls.UCFacilitySearch();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb成绩来源 = new System.Windows.Forms.ComboBox();
            this.btn删除成绩 = new System.Windows.Forms.Button();
            this.cmbPhysicalItem = new HH.ZK.CommonUI.Controls.PhysicalItemComboBox(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rd特殊成绩 = new System.Windows.Forms.RadioButton();
            this.rd正常成绩 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHostSN = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFacility,
            this.colID,
            this.colName,
            this.colSex,
            this.colGrade,
            this.colPhysicalItem,
            this.colScore,
            this.colResult,
            this.colDate,
            this.col成绩来源,
            this.colMemo,
            this.colFill});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
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
            // colGrade
            // 
            resources.ApplyResources(this.colGrade, "colGrade");
            this.colGrade.Name = "colGrade";
            this.colGrade.ReadOnly = true;
            // 
            // colPhysicalItem
            // 
            resources.ApplyResources(this.colPhysicalItem, "colPhysicalItem");
            this.colPhysicalItem.Name = "colPhysicalItem";
            this.colPhysicalItem.ReadOnly = true;
            // 
            // colScore
            // 
            resources.ApplyResources(this.colScore, "colScore");
            this.colScore.Name = "colScore";
            this.colScore.ReadOnly = true;
            // 
            // colResult
            // 
            resources.ApplyResources(this.colResult, "colResult");
            this.colResult.Name = "colResult";
            this.colResult.ReadOnly = true;
            // 
            // colDate
            // 
            resources.ApplyResources(this.colDate, "colDate");
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            // 
            // col成绩来源
            // 
            resources.ApplyResources(this.col成绩来源, "col成绩来源");
            this.col成绩来源.Name = "col成绩来源";
            this.col成绩来源.ReadOnly = true;
            // 
            // colMemo
            // 
            resources.ApplyResources(this.colMemo, "colMemo");
            this.colMemo.Name = "colMemo";
            this.colMemo.ReadOnly = true;
            // 
            // colFill
            // 
            this.colFill.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.colFill, "colFill");
            this.colFill.Name = "colFill";
            this.colFill.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu删除所选成绩});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // mnu删除所选成绩
            // 
            this.mnu删除所选成绩.Name = "mnu删除所选成绩";
            resources.ApplyResources(this.mnu删除所选成绩, "mnu删除所选成绩");
            this.mnu删除所选成绩.Click += new System.EventHandler(this.mnu删除所选成绩_Click);
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdSexAll);
            this.panel2.Controls.Add(this.rdFemale);
            this.panel2.Controls.Add(this.rdMale);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // rdSexAll
            // 
            resources.ApplyResources(this.rdSexAll, "rdSexAll");
            this.rdSexAll.Checked = true;
            this.rdSexAll.Name = "rdSexAll";
            this.rdSexAll.TabStop = true;
            this.rdSexAll.UseVisualStyleBackColor = true;
            // 
            // rdFemale
            // 
            resources.ApplyResources(this.rdFemale, "rdFemale");
            this.rdFemale.Name = "rdFemale";
            this.rdFemale.UseVisualStyleBackColor = true;
            // 
            // rdMale
            // 
            resources.ApplyResources(this.rdMale, "rdMale");
            this.rdMale.Name = "rdMale";
            this.rdMale.UseVisualStyleBackColor = true;
            // 
            // txtStudentID1
            // 
            resources.ApplyResources(this.txtStudentID1, "txtStudentID1");
            this.txtStudentID1.Name = "txtStudentID1";
            // 
            // txtName
            // 
            resources.ApplyResources(this.txtName, "txtName");
            this.txtName.Name = "txtName";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // ucFacilitySearch1
            // 
            resources.ApplyResources(this.ucFacilitySearch1, "ucFacilitySearch1");
            this.ucFacilitySearch1.Name = "ucFacilitySearch1";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // cmb成绩来源
            // 
            this.cmb成绩来源.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb成绩来源.FormattingEnabled = true;
            resources.ApplyResources(this.cmb成绩来源, "cmb成绩来源");
            this.cmb成绩来源.Name = "cmb成绩来源";
            // 
            // btn删除成绩
            // 
            resources.ApplyResources(this.btn删除成绩, "btn删除成绩");
            this.btn删除成绩.Name = "btn删除成绩";
            this.btn删除成绩.UseVisualStyleBackColor = true;
            this.btn删除成绩.Click += new System.EventHandler(this.mnu删除所选成绩_Click);
            // 
            // cmbPhysicalItem
            // 
            this.cmbPhysicalItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPhysicalItem.FormattingEnabled = true;
            resources.ApplyResources(this.cmbPhysicalItem, "cmbPhysicalItem");
            this.cmbPhysicalItem.Name = "cmbPhysicalItem";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.rd特殊成绩);
            this.panel1.Controls.Add(this.rd正常成绩);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // radioButton1
            // 
            resources.ApplyResources(this.radioButton1, "radioButton1");
            this.radioButton1.Checked = true;
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // rd特殊成绩
            // 
            resources.ApplyResources(this.rd特殊成绩, "rd特殊成绩");
            this.rd特殊成绩.Name = "rd特殊成绩";
            this.rd特殊成绩.UseVisualStyleBackColor = true;
            // 
            // rd正常成绩
            // 
            resources.ApplyResources(this.rd正常成绩, "rd正常成绩");
            this.rd正常成绩.Name = "rd正常成绩";
            this.rd正常成绩.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // txtHostSN
            // 
            resources.ApplyResources(this.txtHostSN, "txtHostSN");
            this.txtHostSN.Name = "txtHostSN";
            // 
            // Frm删除学生成绩
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtHostSN);
            this.Controls.Add(this.cmbPhysicalItem);
            this.Controls.Add(this.btn删除成绩);
            this.Controls.Add(this.cmb成绩来源);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ucFacilitySearch1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtStudentID1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Frm删除学生成绩";
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.txtName, 0);
            this.Controls.SetChildIndex(this.txtStudentID1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.ucFacilitySearch1, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.cmb成绩来源, 0);
            this.Controls.SetChildIndex(this.btnSearch, 0);
            this.Controls.SetChildIndex(this.btnSaveAs, 0);
            this.Controls.SetChildIndex(this.btnColumn, 0);
            this.Controls.SetChildIndex(this.btn删除成绩, 0);
            this.Controls.SetChildIndex(this.cmbPhysicalItem, 0);
            this.Controls.SetChildIndex(this.txtHostSN, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdSexAll;
        private System.Windows.Forms.RadioButton rdFemale;
        private System.Windows.Forms.RadioButton rdMale;
        private LJH.GeneralLibrary.WinformControl.DBCTextBox txtStudentID1;
        private LJH.GeneralLibrary.WinformControl.DBCTextBox txtName;
        private System.Windows.Forms.Label label2;
        private Controls.UCFacilitySearch ucFacilitySearch1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb成绩来源;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnu删除所选成绩;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFacility;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGrade;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhysicalItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn colResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn col成绩来源;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMemo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFill;
        private System.Windows.Forms.Button btn删除成绩;
        private Controls.PhysicalItemComboBox cmbPhysicalItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton rd特殊成绩;
        private System.Windows.Forms.RadioButton rd正常成绩;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private LJH.GeneralLibrary.WinformControl.DBCTextBox txtHostSN;
    }
}