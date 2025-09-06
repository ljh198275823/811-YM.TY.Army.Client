namespace HH.ZK.CommonUI
{
    partial class Frm主机采集成绩查询
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm主机采集成绩查询));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnu重新上传所选成绩 = new System.Windows.Forms.ToolStripMenuItem();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStudentID1 = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.ucDateTimeInterval1 = new LJH.GeneralLibrary.WinformControl.UCDateTimeInterval();
            this.txtName = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHostSN = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.rd同步失败 = new System.Windows.Forms.RadioButton();
            this.rd同步成功 = new System.Windows.Forms.RadioButton();
            this.rd未上传 = new System.Windows.Forms.RadioButton();
            this.rdSexAll = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbPhysicalItem = new HH.ZK.CommonUI.Controls.PhysicalItemComboBox(this.components);
            this.colHostSN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHostID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colScoreSer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhysicalItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col犯规次数 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col成绩来源 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSyncTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSyncError = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel4.SuspendLayout();
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
            this.colHostSN,
            this.colHostID,
            this.colScoreSer,
            this.colID,
            this.colName,
            this.colSex,
            this.colPhysicalItem,
            this.colScore,
            this.col犯规次数,
            this.colDate,
            this.col成绩来源,
            this.colSyncTime,
            this.colSyncError,
            this.colFill});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("宋体", 10.5F);
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu重新上传所选成绩});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // mnu重新上传所选成绩
            // 
            this.mnu重新上传所选成绩.Name = "mnu重新上传所选成绩";
            resources.ApplyResources(this.mnu重新上传所选成绩, "mnu重新上传所选成绩");
            this.mnu重新上传所选成绩.Click += new System.EventHandler(this.mnu重新上传所选成绩_Click);
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
            // txtStudentID1
            // 
            resources.ApplyResources(this.txtStudentID1, "txtStudentID1");
            this.txtStudentID1.Name = "txtStudentID1";
            // 
            // ucDateTimeInterval1
            // 
            this.ucDateTimeInterval1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucDateTimeInterval1.EndDateTime = new System.DateTime(2014, 12, 22, 10, 49, 55, 545);
            resources.ApplyResources(this.ucDateTimeInterval1, "ucDateTimeInterval1");
            this.ucDateTimeInterval1.Name = "ucDateTimeInterval1";
            this.ucDateTimeInterval1.ShowTime = true;
            this.ucDateTimeInterval1.StartDateTime = new System.DateTime(2014, 12, 22, 10, 49, 55, 591);
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
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // txtHostSN
            // 
            resources.ApplyResources(this.txtHostSN, "txtHostSN");
            this.txtHostSN.Name = "txtHostSN";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.rd同步失败);
            this.panel4.Controls.Add(this.rd同步成功);
            this.panel4.Controls.Add(this.rd未上传);
            this.panel4.Controls.Add(this.rdSexAll);
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // rd同步失败
            // 
            resources.ApplyResources(this.rd同步失败, "rd同步失败");
            this.rd同步失败.Name = "rd同步失败";
            this.rd同步失败.UseVisualStyleBackColor = true;
            // 
            // rd同步成功
            // 
            resources.ApplyResources(this.rd同步成功, "rd同步成功");
            this.rd同步成功.Name = "rd同步成功";
            this.rd同步成功.UseVisualStyleBackColor = true;
            // 
            // rd未上传
            // 
            resources.ApplyResources(this.rd未上传, "rd未上传");
            this.rd未上传.Name = "rd未上传";
            this.rd未上传.UseVisualStyleBackColor = true;
            // 
            // rdSexAll
            // 
            resources.ApplyResources(this.rdSexAll, "rdSexAll");
            this.rdSexAll.Checked = true;
            this.rdSexAll.Name = "rdSexAll";
            this.rdSexAll.TabStop = true;
            this.rdSexAll.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // cmbPhysicalItem
            // 
            this.cmbPhysicalItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPhysicalItem.FormattingEnabled = true;
            resources.ApplyResources(this.cmbPhysicalItem, "cmbPhysicalItem");
            this.cmbPhysicalItem.Name = "cmbPhysicalItem";
            // 
            // colHostSN
            // 
            resources.ApplyResources(this.colHostSN, "colHostSN");
            this.colHostSN.Name = "colHostSN";
            this.colHostSN.ReadOnly = true;
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
            // col犯规次数
            // 
            resources.ApplyResources(this.col犯规次数, "col犯规次数");
            this.col犯规次数.Name = "col犯规次数";
            this.col犯规次数.ReadOnly = true;
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
            // colSyncTime
            // 
            resources.ApplyResources(this.colSyncTime, "colSyncTime");
            this.colSyncTime.Name = "colSyncTime";
            this.colSyncTime.ReadOnly = true;
            // 
            // colSyncError
            // 
            resources.ApplyResources(this.colSyncError, "colSyncError");
            this.colSyncError.Name = "colSyncError";
            this.colSyncError.ReadOnly = true;
            // 
            // colFill
            // 
            this.colFill.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.colFill, "colFill");
            this.colFill.Name = "colFill";
            this.colFill.ReadOnly = true;
            // 
            // Frm主机采集成绩查询
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbPhysicalItem);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHostSN);
            this.Controls.Add(this.ucDateTimeInterval1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtStudentID1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Frm主机采集成绩查询";
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.txtName, 0);
            this.Controls.SetChildIndex(this.txtStudentID1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.ucDateTimeInterval1, 0);
            this.Controls.SetChildIndex(this.btnSearch, 0);
            this.Controls.SetChildIndex(this.btnSaveAs, 0);
            this.Controls.SetChildIndex(this.btnColumn, 0);
            this.Controls.SetChildIndex(this.txtHostSN, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.cmbPhysicalItem, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private LJH.GeneralLibrary.WinformControl.DBCTextBox txtStudentID1;
        private LJH.GeneralLibrary.WinformControl.UCDateTimeInterval ucDateTimeInterval1;
        private LJH.GeneralLibrary.WinformControl.DBCTextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private LJH.GeneralLibrary.WinformControl.DBCTextBox txtHostSN;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton rd同步成功;
        private System.Windows.Forms.RadioButton rd未上传;
        private System.Windows.Forms.RadioButton rdSexAll;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnu重新上传所选成绩;
        private System.Windows.Forms.RadioButton rd同步失败;
        private Controls.PhysicalItemComboBox cmbPhysicalItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHostSN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHostID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colScoreSer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhysicalItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn col犯规次数;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn col成绩来源;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSyncTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSyncError;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFill;
    }
}