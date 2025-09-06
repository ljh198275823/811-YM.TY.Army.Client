namespace HH.ZK.CommonUI
{
    partial class FrmHosts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHosts));
            this.chkLog = new System.Windows.Forms.CheckBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCount = new System.Windows.Forms.Label();
            this.btnRevert = new System.Windows.Forms.Button();
            this.btnNone = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.colIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHostID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhysicalItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colOperation = new System.Windows.Forms.DataGridViewLinkColumn();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.增加主机USBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu_开始实时采集 = new System.Windows.Forms.ToolStripMenuItem();
            this.结束实时采集ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.集中采集ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.集中采集指定时间段的数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_集中采集所有数据 = new System.Windows.Forms.ToolStripMenuItem();
            this.集中采集剩余数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.指定学号的数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.指定序列号段的数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu下载学生名单 = new System.Windows.Forms.ToolStripMenuItem();
            this.清空学生名单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu参数设置 = new System.Windows.Forms.ToolStripMenuItem();
            this.同步时间ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.通讯质量检测ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关机ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkLog
            // 
            resources.ApplyResources(this.chkLog, "chkLog");
            this.chkLog.Name = "chkLog";
            this.chkLog.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            resources.ApplyResources(this.btnSearch, "btnSearch");
            this.btnSearch.BackColor = System.Drawing.Color.Blue;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblCount);
            this.panel1.Controls.Add(this.btnRevert);
            this.panel1.Controls.Add(this.btnNone);
            this.panel1.Controls.Add(this.btnAll);
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.chkLog);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // lblCount
            // 
            resources.ApplyResources(this.lblCount, "lblCount");
            this.lblCount.Name = "lblCount";
            // 
            // btnRevert
            // 
            resources.ApplyResources(this.btnRevert, "btnRevert");
            this.btnRevert.Name = "btnRevert";
            this.btnRevert.UseVisualStyleBackColor = true;
            this.btnRevert.Click += new System.EventHandler(this.btnRevert_Click);
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
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            resources.ApplyResources(this.dataGridView2, "dataGridView2");
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIP,
            this.colHostID,
            this.colSer,
            this.colPhysicalItem,
            this.colCheck,
            this.colOperation});
            this.dataGridView2.ContextMenuStrip = this.contextMenuStrip2;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // colIP
            // 
            this.colIP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            resources.ApplyResources(this.colIP, "colIP");
            this.colIP.Name = "colIP";
            this.colIP.ReadOnly = true;
            // 
            // colHostID
            // 
            this.colHostID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            resources.ApplyResources(this.colHostID, "colHostID");
            this.colHostID.Name = "colHostID";
            this.colHostID.ReadOnly = true;
            // 
            // colSer
            // 
            this.colSer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            resources.ApplyResources(this.colSer, "colSer");
            this.colSer.Name = "colSer";
            this.colSer.ReadOnly = true;
            this.colSer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colPhysicalItem
            // 
            this.colPhysicalItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.colPhysicalItem, "colPhysicalItem");
            this.colPhysicalItem.Name = "colPhysicalItem";
            this.colPhysicalItem.ReadOnly = true;
            // 
            // colCheck
            // 
            resources.ApplyResources(this.colCheck, "colCheck");
            this.colCheck.Name = "colCheck";
            this.colCheck.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colOperation
            // 
            resources.ApplyResources(this.colOperation, "colOperation");
            this.colOperation.Name = "colOperation";
            this.colOperation.ReadOnly = true;
            this.colOperation.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colOperation.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.增加主机USBToolStripMenuItem,
            this.toolStripSeparator3,
            this.mnu_开始实时采集,
            this.结束实时采集ToolStripMenuItem,
            this.集中采集ToolStripMenuItem,
            this.toolStripSeparator1,
            this.mnu下载学生名单,
            this.清空学生名单ToolStripMenuItem,
            this.toolStripSeparator2,
            this.mnu参数设置,
            this.同步时间ToolStripMenuItem,
            this.通讯质量检测ToolStripMenuItem,
            this.关机ToolStripMenuItem,
            this.toolStripSeparator4});
            this.contextMenuStrip2.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip2, "contextMenuStrip2");
            // 
            // 增加主机USBToolStripMenuItem
            // 
            this.增加主机USBToolStripMenuItem.Name = "增加主机USBToolStripMenuItem";
            resources.ApplyResources(this.增加主机USBToolStripMenuItem, "增加主机USBToolStripMenuItem");
            this.增加主机USBToolStripMenuItem.Click += new System.EventHandler(this.增加主机USBToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            // 
            // mnu_开始实时采集
            // 
            this.mnu_开始实时采集.Name = "mnu_开始实时采集";
            resources.ApplyResources(this.mnu_开始实时采集, "mnu_开始实时采集");
            this.mnu_开始实时采集.Click += new System.EventHandler(this.mnu_开始实时采集_Click);
            // 
            // 结束实时采集ToolStripMenuItem
            // 
            this.结束实时采集ToolStripMenuItem.Name = "结束实时采集ToolStripMenuItem";
            resources.ApplyResources(this.结束实时采集ToolStripMenuItem, "结束实时采集ToolStripMenuItem");
            this.结束实时采集ToolStripMenuItem.Click += new System.EventHandler(this.结束实时采集ToolStripMenuItem_Click);
            // 
            // 集中采集ToolStripMenuItem
            // 
            this.集中采集ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.集中采集指定时间段的数据ToolStripMenuItem,
            this.mnu_集中采集所有数据,
            this.集中采集剩余数据ToolStripMenuItem,
            this.指定学号的数据ToolStripMenuItem,
            this.指定序列号段的数据ToolStripMenuItem});
            this.集中采集ToolStripMenuItem.Name = "集中采集ToolStripMenuItem";
            resources.ApplyResources(this.集中采集ToolStripMenuItem, "集中采集ToolStripMenuItem");
            // 
            // 集中采集指定时间段的数据ToolStripMenuItem
            // 
            this.集中采集指定时间段的数据ToolStripMenuItem.Name = "集中采集指定时间段的数据ToolStripMenuItem";
            resources.ApplyResources(this.集中采集指定时间段的数据ToolStripMenuItem, "集中采集指定时间段的数据ToolStripMenuItem");
            this.集中采集指定时间段的数据ToolStripMenuItem.Click += new System.EventHandler(this.集中采集指定时间段的数据ToolStripMenuItem_Click);
            // 
            // mnu_集中采集所有数据
            // 
            this.mnu_集中采集所有数据.Name = "mnu_集中采集所有数据";
            resources.ApplyResources(this.mnu_集中采集所有数据, "mnu_集中采集所有数据");
            this.mnu_集中采集所有数据.Click += new System.EventHandler(this.mnu_开始集中采集_Click);
            // 
            // 集中采集剩余数据ToolStripMenuItem
            // 
            this.集中采集剩余数据ToolStripMenuItem.Name = "集中采集剩余数据ToolStripMenuItem";
            resources.ApplyResources(this.集中采集剩余数据ToolStripMenuItem, "集中采集剩余数据ToolStripMenuItem");
            this.集中采集剩余数据ToolStripMenuItem.Click += new System.EventHandler(this.集中采集剩余数据ToolStripMenuItem_Click);
            // 
            // 指定学号的数据ToolStripMenuItem
            // 
            this.指定学号的数据ToolStripMenuItem.Name = "指定学号的数据ToolStripMenuItem";
            resources.ApplyResources(this.指定学号的数据ToolStripMenuItem, "指定学号的数据ToolStripMenuItem");
            this.指定学号的数据ToolStripMenuItem.Click += new System.EventHandler(this.指定学号的数据ToolStripMenuItem_Click);
            // 
            // 指定序列号段的数据ToolStripMenuItem
            // 
            this.指定序列号段的数据ToolStripMenuItem.Name = "指定序列号段的数据ToolStripMenuItem";
            resources.ApplyResources(this.指定序列号段的数据ToolStripMenuItem, "指定序列号段的数据ToolStripMenuItem");
            this.指定序列号段的数据ToolStripMenuItem.Click += new System.EventHandler(this.指定序列号段的数据ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // mnu下载学生名单
            // 
            this.mnu下载学生名单.Name = "mnu下载学生名单";
            resources.ApplyResources(this.mnu下载学生名单, "mnu下载学生名单");
            this.mnu下载学生名单.Click += new System.EventHandler(this.下载学生名单ToolStripMenuItem_Click);
            // 
            // 清空学生名单ToolStripMenuItem
            // 
            this.清空学生名单ToolStripMenuItem.Name = "清空学生名单ToolStripMenuItem";
            resources.ApplyResources(this.清空学生名单ToolStripMenuItem, "清空学生名单ToolStripMenuItem");
            this.清空学生名单ToolStripMenuItem.Click += new System.EventHandler(this.清空学生名单ToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // mnu参数设置
            // 
            this.mnu参数设置.Name = "mnu参数设置";
            resources.ApplyResources(this.mnu参数设置, "mnu参数设置");
            this.mnu参数设置.Click += new System.EventHandler(this.参数设置ToolStripMenuItem_Click);
            // 
            // 同步时间ToolStripMenuItem
            // 
            this.同步时间ToolStripMenuItem.Name = "同步时间ToolStripMenuItem";
            resources.ApplyResources(this.同步时间ToolStripMenuItem, "同步时间ToolStripMenuItem");
            this.同步时间ToolStripMenuItem.Click += new System.EventHandler(this.同步时间ToolStripMenuItem_Click);
            // 
            // 通讯质量检测ToolStripMenuItem
            // 
            this.通讯质量检测ToolStripMenuItem.Name = "通讯质量检测ToolStripMenuItem";
            resources.ApplyResources(this.通讯质量检测ToolStripMenuItem, "通讯质量检测ToolStripMenuItem");
            this.通讯质量检测ToolStripMenuItem.Click += new System.EventHandler(this.通讯质量测试ToolStripMenuItem_Click);
            // 
            // 关机ToolStripMenuItem
            // 
            this.关机ToolStripMenuItem.Name = "关机ToolStripMenuItem";
            resources.ApplyResources(this.关机ToolStripMenuItem, "关机ToolStripMenuItem");
            this.关机ToolStripMenuItem.Click += new System.EventHandler(this.关机ToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            // 
            // FrmHosts
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "FrmHosts";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmHosts_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox chkLog;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem mnu_开始实时采集;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnu下载学生名单;
        private System.Windows.Forms.ToolStripMenuItem 清空学生名单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 同步时间ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关机ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 集中采集ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 指定学号的数据ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 集中采集指定时间段的数据ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 集中采集剩余数据ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 指定序列号段的数据ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnu参数设置;
        private System.Windows.Forms.Button btnRevert;
        private System.Windows.Forms.Button btnNone;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem 通讯质量检测ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem 增加主机USBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 结束实时采集ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHostID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhysicalItem;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colCheck;
        private System.Windows.Forms.DataGridViewLinkColumn colOperation;
        private System.Windows.Forms.ToolStripMenuItem mnu_集中采集所有数据;
    }
}