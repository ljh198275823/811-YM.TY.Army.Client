namespace HH.ZK.CommonUI
{
    partial class Frm人工修改成绩查询报表
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm人工修改成绩查询报表));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.ucStudentSearch1 = new HH.ZK.CommonUI.Controls.UCStudentSearch();
            this.cmbPhysicalItem = new HH.ZK.CommonUI.Controls.PhysicalItemComboBox(this.components);
            this.colOptTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOptType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhysicalItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNewScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colScoreFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeviceSn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHostID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colScoreSer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFacility = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOperator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMemo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFill = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colOptTime,
            this.colOptType,
            this.colID,
            this.colName,
            this.colSex,
            this.colPhysicalItem,
            this.colScore,
            this.colNewScore,
            this.colDate,
            this.colScoreFrom,
            this.colDeviceSn,
            this.colHostID,
            this.colScoreSer,
            this.colFacility,
            this.colOperator,
            this.colMemo,
            this.colFill});
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("宋体", 10.5F);
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // ucStudentSearch1
            // 
            resources.ApplyResources(this.ucStudentSearch1, "ucStudentSearch1");
            this.ucStudentSearch1.Name = "ucStudentSearch1";
            // 
            // cmbPhysicalItem
            // 
            this.cmbPhysicalItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPhysicalItem.FormattingEnabled = true;
            resources.ApplyResources(this.cmbPhysicalItem, "cmbPhysicalItem");
            this.cmbPhysicalItem.Name = "cmbPhysicalItem";
            // 
            // colOptTime
            // 
            resources.ApplyResources(this.colOptTime, "colOptTime");
            this.colOptTime.Name = "colOptTime";
            this.colOptTime.ReadOnly = true;
            // 
            // colOptType
            // 
            resources.ApplyResources(this.colOptType, "colOptType");
            this.colOptType.Name = "colOptType";
            this.colOptType.ReadOnly = true;
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
            // colNewScore
            // 
            resources.ApplyResources(this.colNewScore, "colNewScore");
            this.colNewScore.Name = "colNewScore";
            this.colNewScore.ReadOnly = true;
            // 
            // colDate
            // 
            resources.ApplyResources(this.colDate, "colDate");
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            // 
            // colScoreFrom
            // 
            resources.ApplyResources(this.colScoreFrom, "colScoreFrom");
            this.colScoreFrom.Name = "colScoreFrom";
            this.colScoreFrom.ReadOnly = true;
            // 
            // colDeviceSn
            // 
            resources.ApplyResources(this.colDeviceSn, "colDeviceSn");
            this.colDeviceSn.Name = "colDeviceSn";
            this.colDeviceSn.ReadOnly = true;
            // 
            // colHostID
            // 
            resources.ApplyResources(this.colHostID, "colHostID");
            this.colHostID.Name = "colHostID";
            this.colHostID.ReadOnly = true;
            // 
            // colScoreSer
            // 
            resources.ApplyResources(this.colScoreSer, "colScoreSer");
            this.colScoreSer.Name = "colScoreSer";
            this.colScoreSer.ReadOnly = true;
            // 
            // colFacility
            // 
            this.colFacility.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            resources.ApplyResources(this.colFacility, "colFacility");
            this.colFacility.Name = "colFacility";
            this.colFacility.ReadOnly = true;
            // 
            // colOperator
            // 
            resources.ApplyResources(this.colOperator, "colOperator");
            this.colOperator.Name = "colOperator";
            this.colOperator.ReadOnly = true;
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
            // Frm人工修改成绩查询报表
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbPhysicalItem);
            this.Controls.Add(this.ucStudentSearch1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Frm人工修改成绩查询报表";
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.btnSearch, 0);
            this.Controls.SetChildIndex(this.btnSaveAs, 0);
            this.Controls.SetChildIndex(this.btnColumn, 0);
            this.Controls.SetChildIndex(this.ucStudentSearch1, 0);
            this.Controls.SetChildIndex(this.cmbPhysicalItem, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label10;
        private Controls.UCStudentSearch ucStudentSearch1;
        private Controls.PhysicalItemComboBox cmbPhysicalItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOptTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOptType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhysicalItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNewScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colScoreFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeviceSn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHostID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colScoreSer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFacility;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOperator;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMemo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFill;
    }
}