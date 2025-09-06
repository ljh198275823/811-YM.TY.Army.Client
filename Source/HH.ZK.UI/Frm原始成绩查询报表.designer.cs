namespace HH.ZK.UI
{
    partial class Frm原始成绩查询报表
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm原始成绩查询报表));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colFacility = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhysicalItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col成绩来源 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDevice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colScoreSer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col开始时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVideoChannels = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col视频回放 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colMemo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnu删除所选成绩 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu犯规 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu未完成 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu弃考 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu残疾 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu作废所选成绩 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu成绩仲裁 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu设置视频通道 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu视频回放 = new System.Windows.Forms.ToolStripMenuItem();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb成绩来源 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHostSN = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.ucStudentSearch1 = new HH.ZK.CommonUI.Controls.UCStudentSearch();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdSexAll = new System.Windows.Forms.RadioButton();
            this.rd特殊成绩 = new System.Windows.Forms.RadioButton();
            this.rd正常成绩 = new System.Windows.Forms.RadioButton();
            this.cmbPhysicalItem = new HH.ZK.CommonUI.Controls.PhysicalItemComboBox(this.components);
            this.txt测试日期 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHostID = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.mnu伤病 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.colFacility,
            this.colID,
            this.colName,
            this.colSex,
            this.colPhysicalItem,
            this.colScore,
            this.colResult,
            this.colDate,
            this.col成绩来源,
            this.colDevice,
            this.colHost,
            this.colScoreSer,
            this.col开始时间,
            this.colVideoChannels,
            this.col视频回放,
            this.colMemo,
            this.colFill});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("宋体", 10.5F);
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // colDevice
            // 
            resources.ApplyResources(this.colDevice, "colDevice");
            this.colDevice.Name = "colDevice";
            this.colDevice.ReadOnly = true;
            // 
            // colHost
            // 
            resources.ApplyResources(this.colHost, "colHost");
            this.colHost.Name = "colHost";
            this.colHost.ReadOnly = true;
            // 
            // colScoreSer
            // 
            resources.ApplyResources(this.colScoreSer, "colScoreSer");
            this.colScoreSer.Name = "colScoreSer";
            this.colScoreSer.ReadOnly = true;
            // 
            // col开始时间
            // 
            resources.ApplyResources(this.col开始时间, "col开始时间");
            this.col开始时间.Name = "col开始时间";
            this.col开始时间.ReadOnly = true;
            // 
            // colVideoChannels
            // 
            resources.ApplyResources(this.colVideoChannels, "colVideoChannels");
            this.colVideoChannels.Name = "colVideoChannels";
            this.colVideoChannels.ReadOnly = true;
            // 
            // col视频回放
            // 
            resources.ApplyResources(this.col视频回放, "col视频回放");
            this.col视频回放.Name = "col视频回放";
            this.col视频回放.ReadOnly = true;
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
            this.mnu删除所选成绩,
            this.mnu犯规,
            this.mnu未完成,
            this.mnu弃考,
            this.mnu伤病,
            this.mnu残疾,
            this.mnu作废所选成绩,
            this.toolStripSeparator1,
            this.mnu成绩仲裁,
            this.toolStripSeparator2,
            this.mnu设置视频通道,
            this.mnu视频回放});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // mnu删除所选成绩
            // 
            this.mnu删除所选成绩.Name = "mnu删除所选成绩";
            resources.ApplyResources(this.mnu删除所选成绩, "mnu删除所选成绩");
            this.mnu删除所选成绩.Click += new System.EventHandler(this.mnu删除所选成绩_Click);
            // 
            // mnu犯规
            // 
            this.mnu犯规.Name = "mnu犯规";
            resources.ApplyResources(this.mnu犯规, "mnu犯规");
            this.mnu犯规.Click += new System.EventHandler(this.mnu犯规_Click);
            // 
            // mnu未完成
            // 
            this.mnu未完成.Name = "mnu未完成";
            resources.ApplyResources(this.mnu未完成, "mnu未完成");
            this.mnu未完成.Click += new System.EventHandler(this.mnu未完成_Click);
            // 
            // mnu弃考
            // 
            this.mnu弃考.Name = "mnu弃考";
            resources.ApplyResources(this.mnu弃考, "mnu弃考");
            this.mnu弃考.Click += new System.EventHandler(this.mnu弃权_Click);
            // 
            // mnu残疾
            // 
            this.mnu残疾.Name = "mnu残疾";
            resources.ApplyResources(this.mnu残疾, "mnu残疾");
            this.mnu残疾.Click += new System.EventHandler(this.mnu残疾_Click);
            // 
            // mnu作废所选成绩
            // 
            this.mnu作废所选成绩.Name = "mnu作废所选成绩";
            resources.ApplyResources(this.mnu作废所选成绩, "mnu作废所选成绩");
            this.mnu作废所选成绩.Click += new System.EventHandler(this.mnu作废所选成绩_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // mnu成绩仲裁
            // 
            this.mnu成绩仲裁.Name = "mnu成绩仲裁";
            resources.ApplyResources(this.mnu成绩仲裁, "mnu成绩仲裁");
            this.mnu成绩仲裁.Click += new System.EventHandler(this.mnu成绩仲裁_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // mnu设置视频通道
            // 
            this.mnu设置视频通道.Name = "mnu设置视频通道";
            resources.ApplyResources(this.mnu设置视频通道, "mnu设置视频通道");
            this.mnu设置视频通道.Click += new System.EventHandler(this.mnu设置视频通道_Click);
            // 
            // mnu视频回放
            // 
            this.mnu视频回放.Name = "mnu视频回放";
            resources.ApplyResources(this.mnu视频回放, "mnu视频回放");
            this.mnu视频回放.Click += new System.EventHandler(this.mnu视频回放_Click);
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
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
            // ucStudentSearch1
            // 
            resources.ApplyResources(this.ucStudentSearch1, "ucStudentSearch1");
            this.ucStudentSearch1.Name = "ucStudentSearch1";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdSexAll);
            this.panel2.Controls.Add(this.rd特殊成绩);
            this.panel2.Controls.Add(this.rd正常成绩);
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
            // cmbPhysicalItem
            // 
            this.cmbPhysicalItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPhysicalItem.FormattingEnabled = true;
            resources.ApplyResources(this.cmbPhysicalItem, "cmbPhysicalItem");
            this.cmbPhysicalItem.Name = "cmbPhysicalItem";
            // 
            // txt测试日期
            // 
            this.txt测试日期.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt测试日期.FormattingEnabled = true;
            resources.ApplyResources(this.txt测试日期, "txt测试日期");
            this.txt测试日期.Name = "txt测试日期";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // txtHostID
            // 
            resources.ApplyResources(this.txtHostID, "txtHostID");
            this.txtHostID.Name = "txtHostID";
            // 
            // mnu伤病
            // 
            this.mnu伤病.Name = "mnu伤病";
            resources.ApplyResources(this.mnu伤病, "mnu伤病");
            this.mnu伤病.Click += new System.EventHandler(this.mnu伤病_Click);
            // 
            // Frm原始成绩查询报表
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtHostID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt测试日期);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbPhysicalItem);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ucStudentSearch1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHostSN);
            this.Controls.Add(this.cmb成绩来源);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Frm原始成绩查询报表";
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.cmb成绩来源, 0);
            this.Controls.SetChildIndex(this.btnSearch, 0);
            this.Controls.SetChildIndex(this.btnSaveAs, 0);
            this.Controls.SetChildIndex(this.btnColumn, 0);
            this.Controls.SetChildIndex(this.txtHostSN, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.ucStudentSearch1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.cmbPhysicalItem, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txt测试日期, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtHostID, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb成绩来源;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnu删除所选成绩;
        private System.Windows.Forms.Label label3;
        private LJH.GeneralLibrary.WinformControl.DBCTextBox txtHostSN;
        private System.Windows.Forms.ToolStripMenuItem mnu作废所选成绩;
        private HH.ZK.CommonUI.Controls.UCStudentSearch ucStudentSearch1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdSexAll;
        private System.Windows.Forms.RadioButton rd特殊成绩;
        private System.Windows.Forms.RadioButton rd正常成绩;
        private HH.ZK.CommonUI.Controls.PhysicalItemComboBox cmbPhysicalItem;
        private System.Windows.Forms.ToolStripMenuItem mnu犯规;
        private System.Windows.Forms.ToolStripMenuItem mnu未完成;
        private System.Windows.Forms.ToolStripMenuItem mnu弃考;
        private System.Windows.Forms.ToolStripMenuItem mnu残疾;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnu成绩仲裁;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnu设置视频通道;
        private System.Windows.Forms.ToolStripMenuItem mnu视频回放;
        private System.Windows.Forms.ComboBox txt测试日期;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private LJH.GeneralLibrary.WinformControl.DBCTextBox txtHostID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFacility;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhysicalItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn colResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn col成绩来源;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDevice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHost;
        private System.Windows.Forms.DataGridViewTextBoxColumn colScoreSer;
        private System.Windows.Forms.DataGridViewTextBoxColumn col开始时间;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVideoChannels;
        private System.Windows.Forms.DataGridViewLinkColumn col视频回放;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMemo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFill;
        private System.Windows.Forms.ToolStripMenuItem mnu伤病;
    }
}