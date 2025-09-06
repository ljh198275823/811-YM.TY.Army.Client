namespace HH.ZK.CommonUI
{
    partial class FrmScoreCollect_Wifi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmScoreCollect_Wifi));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnu_Clear = new System.Windows.Forms.ToolStripMenuItem();
            this.保存所有记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看统计信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.colSN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhysicalItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRecordDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col犯规次数 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMemo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSN,
            this.colStudentID,
            this.colName,
            this.colSex,
            this.colPhysicalItem,
            this.colScore,
            this.colRecordDate,
            this.col犯规次数,
            this.colMemo});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_Clear,
            this.保存所有记录ToolStripMenuItem,
            this.查看统计信息ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // mnu_Clear
            // 
            this.mnu_Clear.Name = "mnu_Clear";
            resources.ApplyResources(this.mnu_Clear, "mnu_Clear");
            this.mnu_Clear.Click += new System.EventHandler(this.mnu_Clear_Click);
            // 
            // 保存所有记录ToolStripMenuItem
            // 
            this.保存所有记录ToolStripMenuItem.Name = "保存所有记录ToolStripMenuItem";
            resources.ApplyResources(this.保存所有记录ToolStripMenuItem, "保存所有记录ToolStripMenuItem");
            this.保存所有记录ToolStripMenuItem.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // 查看统计信息ToolStripMenuItem
            // 
            this.查看统计信息ToolStripMenuItem.Name = "查看统计信息ToolStripMenuItem";
            resources.ApplyResources(this.查看统计信息ToolStripMenuItem, "查看统计信息ToolStripMenuItem");
            this.查看统计信息ToolStripMenuItem.Click += new System.EventHandler(this.查看统计信息ToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblCount});
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            // 
            // lblCount
            // 
            this.lblCount.Name = "lblCount";
            resources.ApplyResources(this.lblCount, "lblCount");
            this.lblCount.Spring = true;
            // 
            // colSN
            // 
            resources.ApplyResources(this.colSN, "colSN");
            this.colSN.Name = "colSN";
            this.colSN.ReadOnly = true;
            // 
            // colStudentID
            // 
            this.colStudentID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            resources.ApplyResources(this.colStudentID, "colStudentID");
            this.colStudentID.Name = "colStudentID";
            this.colStudentID.ReadOnly = true;
            // 
            // colName
            // 
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
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
            // colRecordDate
            // 
            resources.ApplyResources(this.colRecordDate, "colRecordDate");
            this.colRecordDate.Name = "colRecordDate";
            this.colRecordDate.ReadOnly = true;
            // 
            // col犯规次数
            // 
            resources.ApplyResources(this.col犯规次数, "col犯规次数");
            this.col犯规次数.Name = "col犯规次数";
            this.col犯规次数.ReadOnly = true;
            this.col犯规次数.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colMemo
            // 
            this.colMemo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.colMemo, "colMemo");
            this.colMemo.Name = "colMemo";
            this.colMemo.ReadOnly = true;
            // 
            // FrmScoreCollect_Wifi
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dataGridView1);
            this.MinimizeBox = false;
            this.Name = "FrmScoreCollect_Wifi";
            this.Load += new System.EventHandler(this.FrmScoreCollect_Wifi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnu_Clear;
        private System.Windows.Forms.ToolStripMenuItem 保存所有记录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看统计信息ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhysicalItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecordDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn col犯规次数;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMemo;
    }
}

