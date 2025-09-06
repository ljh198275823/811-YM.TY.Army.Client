namespace HH.ZK.CommonUI
{
    partial class FrmScoreCollect_澳亚特
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmScoreCollect_澳亚特));
            this.btnBegin = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.rdRealTime = new System.Windows.Forms.RadioButton();
            this.rdBatch = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chkLog = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colSer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhysicalItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRecordDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFacility = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCurCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblToal = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblPic = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnExport = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtPort = new LJH.GeneralLibrary.WinformControl.IntergerTextBox(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txtIP = new LJH.GeneralLibrary.WinformControl.UCIPTextBox();
            this.ip2 = new LJH.GeneralLibrary.WinformControl.IntergerTextBox(this.components);
            this.ip4 = new LJH.GeneralLibrary.WinformControl.IntergerTextBox(this.components);
            this.ip3 = new LJH.GeneralLibrary.WinformControl.IntergerTextBox(this.components);
            this.ip1 = new LJH.GeneralLibrary.WinformControl.IntergerTextBox(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.txtIP.SuspendLayout();
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
            this.colSer,
            this.colStudentID,
            this.colName,
            this.colSex,
            this.colPhysicalItem,
            this.colUnit,
            this.colScore,
            this.colResult,
            this.colRecordDate,
            this.colFacility});
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            // 
            // colSer
            // 
            resources.ApplyResources(this.colSer, "colSer");
            this.colSer.Name = "colSer";
            this.colSer.ReadOnly = true;
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
            // colUnit
            // 
            this.colUnit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            resources.ApplyResources(this.colUnit, "colUnit");
            this.colUnit.Name = "colUnit";
            this.colUnit.ReadOnly = true;
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
            // colRecordDate
            // 
            resources.ApplyResources(this.colRecordDate, "colRecordDate");
            this.colRecordDate.Name = "colRecordDate";
            this.colRecordDate.ReadOnly = true;
            // 
            // colFacility
            // 
            this.colFacility.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.colFacility, "colFacility");
            this.colFacility.Name = "colFacility";
            this.colFacility.ReadOnly = true;
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
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Name = "panel2";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridView1);
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // txtPort
            // 
            resources.ApplyResources(this.txtPort, "txtPort");
            this.txtPort.MaxValue = 65535;
            this.txtPort.MinValue = 1;
            this.txtPort.Name = "txtPort";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // txtIP
            // 
            this.txtIP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIP.Controls.Add(this.ip2);
            this.txtIP.Controls.Add(this.ip4);
            this.txtIP.Controls.Add(this.ip3);
            this.txtIP.Controls.Add(this.ip1);
            resources.ApplyResources(this.txtIP, "txtIP");
            this.txtIP.Name = "txtIP";
            // 
            // ip2
            // 
            resources.ApplyResources(this.ip2, "ip2");
            this.ip2.MaxValue = 255;
            this.ip2.MinValue = 0;
            this.ip2.Name = "ip2";
            // 
            // ip4
            // 
            resources.ApplyResources(this.ip4, "ip4");
            this.ip4.MaxValue = 255;
            this.ip4.MinValue = 0;
            this.ip4.Name = "ip4";
            // 
            // ip3
            // 
            resources.ApplyResources(this.ip3, "ip3");
            this.ip3.MaxValue = 255;
            this.ip3.MinValue = 0;
            this.ip3.Name = "ip3";
            // 
            // ip1
            // 
            resources.ApplyResources(this.ip1, "ip1");
            this.ip1.MaxValue = 255;
            this.ip1.MinValue = 0;
            this.ip1.Name = "ip1";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // FrmScoreCollect_澳亚特
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.chkLog);
            this.Controls.Add(this.rdBatch);
            this.Controls.Add(this.rdRealTime);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnBegin);
            this.Name = "FrmScoreCollect_澳亚特";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmScoreCollect_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.txtIP.ResumeLayout(false);
            this.txtIP.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBegin;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.RadioButton rdRealTime;
        private System.Windows.Forms.RadioButton rdBatch;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox chkLog;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ToolStripStatusLabel lblCount;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblCurCount;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel lblToal;
        private System.Windows.Forms.ToolStripStatusLabel lblPic;
        private LJH.GeneralLibrary.WinformControl.IntergerTextBox txtPort;
        private System.Windows.Forms.Label label2;
        private LJH.GeneralLibrary.WinformControl.UCIPTextBox txtIP;
        private LJH.GeneralLibrary.WinformControl.IntergerTextBox ip2;
        private LJH.GeneralLibrary.WinformControl.IntergerTextBox ip4;
        private LJH.GeneralLibrary.WinformControl.IntergerTextBox ip3;
        private LJH.GeneralLibrary.WinformControl.IntergerTextBox ip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhysicalItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn colResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecordDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFacility;
    }
}

