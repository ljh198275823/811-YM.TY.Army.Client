namespace HH.ZK.UI
{
    partial class FrmStudentScoreDetailView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStudentScoreDetailView));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRecordDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDevice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colScoreSer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colScoreFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col备注 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCurrent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnu_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Update = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_DelScore = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu犯规 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu未完成 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu弃考 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu伤病 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu作废 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu成绩仲裁 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu残疾 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIndex,
            this.colScore,
            this.colResult,
            this.colRecordDate,
            this.colDevice,
            this.colHost,
            this.colScoreSer,
            this.colScoreFrom,
            this.col备注,
            this.colCurrent});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(1, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(903, 355);
            this.dataGridView1.TabIndex = 141;
            // 
            // colIndex
            // 
            this.colIndex.HeaderText = "";
            this.colIndex.Name = "colIndex";
            this.colIndex.ReadOnly = true;
            this.colIndex.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colIndex.Width = 40;
            // 
            // colScore
            // 
            this.colScore.HeaderText = "成绩";
            this.colScore.Name = "colScore";
            this.colScore.ReadOnly = true;
            this.colScore.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colScore.Width = 80;
            // 
            // colResult
            // 
            this.colResult.HeaderText = "得分";
            this.colResult.Name = "colResult";
            this.colResult.ReadOnly = true;
            this.colResult.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colResult.Width = 80;
            // 
            // colRecordDate
            // 
            dataGridViewCellStyle1.Format = "G";
            dataGridViewCellStyle1.NullValue = null;
            this.colRecordDate.DefaultCellStyle = dataGridViewCellStyle1;
            this.colRecordDate.HeaderText = "测试时间";
            this.colRecordDate.Name = "colRecordDate";
            this.colRecordDate.ReadOnly = true;
            this.colRecordDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colRecordDate.Width = 150;
            // 
            // colDevice
            // 
            this.colDevice.HeaderText = "设备号";
            this.colDevice.Name = "colDevice";
            this.colDevice.ReadOnly = true;
            this.colDevice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colDevice.Width = 80;
            // 
            // colHost
            // 
            this.colHost.HeaderText = "主机";
            this.colHost.Name = "colHost";
            this.colHost.ReadOnly = true;
            this.colHost.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colHost.Width = 60;
            // 
            // colScoreSer
            // 
            this.colScoreSer.HeaderText = "成绩序号";
            this.colScoreSer.Name = "colScoreSer";
            this.colScoreSer.ReadOnly = true;
            this.colScoreSer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colScoreFrom
            // 
            this.colScoreFrom.HeaderText = "成绩来源";
            this.colScoreFrom.Name = "colScoreFrom";
            this.colScoreFrom.ReadOnly = true;
            this.colScoreFrom.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // col备注
            // 
            this.col备注.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col备注.HeaderText = "备注";
            this.col备注.Name = "col备注";
            this.col备注.ReadOnly = true;
            this.col备注.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colCurrent
            // 
            this.colCurrent.HeaderText = "";
            this.colCurrent.Name = "colCurrent";
            this.colCurrent.ReadOnly = true;
            this.colCurrent.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_Add,
            this.mnu_Update,
            this.mnu_DelScore,
            this.toolStripSeparator1,
            this.mnu犯规,
            this.mnu未完成,
            this.mnu弃考,
            this.mnu伤病,
            this.mnu残疾,
            this.toolStripSeparator3,
            this.mnu作废,
            this.toolStripSeparator2,
            this.mnu成绩仲裁});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(208, 264);
            // 
            // mnu_Add
            // 
            this.mnu_Add.Name = "mnu_Add";
            this.mnu_Add.Size = new System.Drawing.Size(207, 22);
            this.mnu_Add.Text = "增加成绩";
            this.mnu_Add.Click += new System.EventHandler(this.mnu_Add_Click);
            // 
            // mnu_Update
            // 
            this.mnu_Update.Name = "mnu_Update";
            this.mnu_Update.Size = new System.Drawing.Size(207, 22);
            this.mnu_Update.Text = "修改成绩";
            this.mnu_Update.Click += new System.EventHandler(this.mnu_Update_Click);
            // 
            // mnu_DelScore
            // 
            this.mnu_DelScore.Name = "mnu_DelScore";
            this.mnu_DelScore.Size = new System.Drawing.Size(207, 22);
            this.mnu_DelScore.Text = "删除所选成绩";
            this.mnu_DelScore.Visible = false;
            this.mnu_DelScore.Click += new System.EventHandler(this.mnu_DelScore_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(204, 6);
            this.toolStripSeparator1.Visible = false;
            // 
            // mnu犯规
            // 
            this.mnu犯规.Name = "mnu犯规";
            this.mnu犯规.Size = new System.Drawing.Size(207, 22);
            this.mnu犯规.Text = "设置所选成绩为 犯规";
            this.mnu犯规.Click += new System.EventHandler(this.mnu犯规_Click);
            // 
            // mnu未完成
            // 
            this.mnu未完成.Name = "mnu未完成";
            this.mnu未完成.Size = new System.Drawing.Size(207, 22);
            this.mnu未完成.Text = "设置所选成绩为 未完成";
            this.mnu未完成.Click += new System.EventHandler(this.mnu未完成_Click);
            // 
            // mnu弃考
            // 
            this.mnu弃考.Name = "mnu弃考";
            this.mnu弃考.Size = new System.Drawing.Size(207, 22);
            this.mnu弃考.Text = "设置所选成绩为 弃考";
            this.mnu弃考.Click += new System.EventHandler(this.mnu弃权_Click);
            // 
            // mnu伤病
            // 
            this.mnu伤病.Name = "mnu伤病";
            this.mnu伤病.Size = new System.Drawing.Size(207, 22);
            this.mnu伤病.Text = "设置所选成绩为 伤病";
            this.mnu伤病.Click += new System.EventHandler(this.mnu伤病_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(204, 6);
            // 
            // mnu作废
            // 
            this.mnu作废.Name = "mnu作废";
            this.mnu作废.Size = new System.Drawing.Size(207, 22);
            this.mnu作废.Text = "作废所选成绩";
            this.mnu作废.Click += new System.EventHandler(this.mnu作废_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(204, 6);
            // 
            // mnu成绩仲裁
            // 
            this.mnu成绩仲裁.Name = "mnu成绩仲裁";
            this.mnu成绩仲裁.Size = new System.Drawing.Size(207, 22);
            this.mnu成绩仲裁.Text = "成绩仲裁";
            this.mnu成绩仲裁.Click += new System.EventHandler(this.mnu成绩仲裁_Click);
            // 
            // mnu残疾
            // 
            this.mnu残疾.Name = "mnu残疾";
            this.mnu残疾.Size = new System.Drawing.Size(207, 22);
            this.mnu残疾.Text = "设置所选成绩为 残疾";
            this.mnu残疾.Click += new System.EventHandler(this.mnu残疾_Click);
            // 
            // FrmStudentScoreDetailView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 356);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmStudentScoreDetailView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "学生成绩";
            this.Load += new System.EventHandler(this.FrmStudentScoreDetailView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnu_Add;
        private System.Windows.Forms.ToolStripMenuItem mnu_Update;
        private System.Windows.Forms.ToolStripMenuItem mnu_DelScore;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnu犯规;
        private System.Windows.Forms.ToolStripMenuItem mnu未完成;
        private System.Windows.Forms.ToolStripMenuItem mnu作废;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnu弃考;
        private System.Windows.Forms.ToolStripMenuItem mnu伤病;
        private System.Windows.Forms.ToolStripMenuItem mnu成绩仲裁;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn colScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn colResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecordDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDevice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHost;
        private System.Windows.Forms.DataGridViewTextBoxColumn colScoreSer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colScoreFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn col备注;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCurrent;
        private System.Windows.Forms.ToolStripMenuItem mnu残疾;
    }
}