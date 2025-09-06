namespace HH.ZK.CommonUI
{
    partial class FrmScoreCollect_Com
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmScoreCollect_Com));
            this.btnBegin = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cmbCommport = new LJH.GeneralLibrary.WinformControl.ComPortComboBox(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.rdRealTime = new System.Windows.Forms.RadioButton();
            this.rdBatch = new System.Windows.Forms.RadioButton();
            this.chkOldHost = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chkLog = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colHost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhysicalItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRecordDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCurCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblToal = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblPic = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnExport = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdHost = new System.Windows.Forms.RadioButton();
            this.rdPhysicalItem = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.myTree1 = new LJH.GeneralLibrary.WinformControl.MyTree(this.components);
            this.cmbBaud = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBegin
            // 
            resources.ApplyResources(this.btnBegin, "btnBegin");
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.UseVisualStyleBackColor = true;
            this.btnBegin.Click += new System.EventHandler(this.btnBegin_Click);
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cmbCommport
            // 
            this.cmbCommport.FormattingEnabled = true;
            resources.ApplyResources(this.cmbCommport, "cmbCommport");
            this.cmbCommport.Name = "cmbCommport";
            this.cmbCommport.SelectedIndexChanged += new System.EventHandler(this.cmbCommport_SelectedIndexChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // rdRealTime
            // 
            resources.ApplyResources(this.rdRealTime, "rdRealTime");
            this.rdRealTime.Name = "rdRealTime";
            this.rdRealTime.UseVisualStyleBackColor = true;
            // 
            // rdBatch
            // 
            resources.ApplyResources(this.rdBatch, "rdBatch");
            this.rdBatch.Checked = true;
            this.rdBatch.Name = "rdBatch";
            this.rdBatch.TabStop = true;
            this.rdBatch.UseVisualStyleBackColor = true;
            // 
            // chkOldHost
            // 
            resources.ApplyResources(this.chkOldHost, "chkOldHost");
            this.chkOldHost.Name = "chkOldHost";
            this.chkOldHost.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // chkLog
            // 
            resources.ApplyResources(this.chkLog, "chkLog");
            this.chkLog.Name = "chkLog";
            this.chkLog.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colHost,
            this.colStudentID,
            this.colName,
            this.colSex,
            this.colPhysicalItem,
            this.colScore,
            this.colRecordDate,
            this.colFill});
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            // 
            // colHost
            // 
            resources.ApplyResources(this.colHost, "colHost");
            this.colHost.Name = "colHost";
            this.colHost.ReadOnly = true;
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
            // colFill
            // 
            this.colFill.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.colFill, "colFill");
            this.colFill.Name = "colFill";
            this.colFill.ReadOnly = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblCount,
            this.toolStripStatusLabel1,
            this.lblCurCount,
            this.toolStripStatusLabel2,
            this.lblToal,
            this.lblPic});
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            // 
            // lblCount
            // 
            this.lblCount.Name = "lblCount";
            resources.ApplyResources(this.lblCount, "lblCount");
            this.lblCount.Spring = true;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            resources.ApplyResources(this.toolStripStatusLabel1, "toolStripStatusLabel1");
            // 
            // lblCurCount
            // 
            this.lblCurCount.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.lblCurCount.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedInner;
            resources.ApplyResources(this.lblCurCount, "lblCurCount");
            this.lblCurCount.ForeColor = System.Drawing.Color.Blue;
            this.lblCurCount.Name = "lblCurCount";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            resources.ApplyResources(this.toolStripStatusLabel2, "toolStripStatusLabel2");
            // 
            // lblToal
            // 
            this.lblToal.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.lblToal.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedInner;
            resources.ApplyResources(this.lblToal, "lblToal");
            this.lblToal.ForeColor = System.Drawing.Color.Blue;
            this.lblToal.Name = "lblToal";
            // 
            // lblPic
            // 
            this.lblPic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lblPic.Image = global::HH.ZK.CommonUI.Properties.Resources.greydot;
            this.lblPic.Name = "lblPic";
            resources.ApplyResources(this.lblPic, "lblPic");
            // 
            // btnExport
            // 
            resources.ApplyResources(this.btnExport, "btnExport");
            this.btnExport.Name = "btnExport";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rdHost);
            this.panel1.Controls.Add(this.rdPhysicalItem);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // rdHost
            // 
            resources.ApplyResources(this.rdHost, "rdHost");
            this.rdHost.Checked = true;
            this.rdHost.Name = "rdHost";
            this.rdHost.TabStop = true;
            this.rdHost.UseVisualStyleBackColor = true;
            this.rdHost.CheckedChanged += new System.EventHandler(this.rdHost_CheckedChanged);
            // 
            // rdPhysicalItem
            // 
            resources.ApplyResources(this.rdPhysicalItem, "rdPhysicalItem");
            this.rdPhysicalItem.Name = "rdPhysicalItem";
            this.rdPhysicalItem.UseVisualStyleBackColor = true;
            this.rdPhysicalItem.CheckedChanged += new System.EventHandler(this.rdPhysicalItem_CheckedChanged);
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.splitter1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Name = "panel2";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridView1);
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.splitter1, "splitter1");
            this.splitter1.Name = "splitter1";
            this.splitter1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.myTree1);
            this.panel3.Controls.Add(this.panel1);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // myTree1
            // 
            resources.ApplyResources(this.myTree1, "myTree1");
            this.myTree1.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawText;
            this.myTree1.HideSelection = false;
            this.myTree1.ItemHeight = 20;
            this.myTree1.Name = "myTree1";
            this.myTree1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.myTree1_NodeMouseClick);
            // 
            // cmbBaud
            // 
            this.cmbBaud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBaud.FormattingEnabled = true;
            this.cmbBaud.Items.AddRange(new object[] {
            resources.GetString("cmbBaud.Items"),
            resources.GetString("cmbBaud.Items1"),
            resources.GetString("cmbBaud.Items2"),
            resources.GetString("cmbBaud.Items3"),
            resources.GetString("cmbBaud.Items4")});
            resources.ApplyResources(this.cmbBaud, "cmbBaud");
            this.cmbBaud.Name = "cmbBaud";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // FrmScoreCollect_Com
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbBaud);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.chkLog);
            this.Controls.Add(this.chkOldHost);
            this.Controls.Add(this.rdBatch);
            this.Controls.Add(this.rdRealTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCommport);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnBegin);
            this.Name = "FrmScoreCollect_Com";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmScoreCollect_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBegin;
        private System.Windows.Forms.Button btnCancel;
        private LJH.GeneralLibrary.WinformControl.ComPortComboBox cmbCommport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdRealTime;
        private System.Windows.Forms.RadioButton rdBatch;
        private System.Windows.Forms.CheckBox chkOldHost;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox chkLog;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdHost;
        private System.Windows.Forms.RadioButton rdPhysicalItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel3;
        private LJH.GeneralLibrary.WinformControl.MyTree myTree1;
        private System.Windows.Forms.ToolStripStatusLabel lblCount;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblCurCount;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel lblToal;
        private System.Windows.Forms.ToolStripStatusLabel lblPic;
        private System.Windows.Forms.ComboBox cmbBaud;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHost;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhysicalItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecordDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFill;
    }
}

