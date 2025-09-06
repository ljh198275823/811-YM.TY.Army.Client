namespace HH.ZK.UI
{
    partial class Frm学生单项成绩查看
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm学生单项成绩查看));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnu导出 = new System.Windows.Forms.ToolStripMenuItem();
            this.colFacility = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhysicalItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCurrentScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCurrentResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colScore1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colScore2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colScore3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colScore4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colScore5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colScore6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colScores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 365);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(873, 22);
            this.statusStrip1.TabIndex = 160;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(858, 17);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = "总共 0 项";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeight = 32;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFacility,
            this.colID,
            this.colName,
            this.colSex,
            this.colClassName,
            this.colPhysicalItem,
            this.colCurrentScore,
            this.colCurrentResult,
            this.colScore1,
            this.colScore2,
            this.colScore3,
            this.colScore4,
            this.colScore5,
            this.colScore6,
            this.colScores});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(873, 365);
            this.dataGridView1.TabIndex = 161;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu导出});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 26);
            // 
            // mnu导出
            // 
            this.mnu导出.Name = "mnu导出";
            this.mnu导出.Size = new System.Drawing.Size(100, 22);
            this.mnu导出.Text = "导出";
            this.mnu导出.Click += new System.EventHandler(this.mnu导出_Click);
            // 
            // colFacility
            // 
            this.colFacility.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colFacility.HeaderText = "学校";
            this.colFacility.MinimumWidth = 120;
            this.colFacility.Name = "colFacility";
            this.colFacility.ReadOnly = true;
            this.colFacility.Width = 120;
            // 
            // colID
            // 
            this.colID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colID.HeaderText = "准考证号";
            this.colID.MinimumWidth = 100;
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            // 
            // colName
            // 
            this.colName.HeaderText = "姓名";
            this.colName.MinimumWidth = 80;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Width = 80;
            // 
            // colSex
            // 
            this.colSex.HeaderText = "性别";
            this.colSex.Name = "colSex";
            this.colSex.ReadOnly = true;
            this.colSex.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colSex.Width = 60;
            // 
            // colClassName
            // 
            this.colClassName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colClassName.HeaderText = "班级";
            this.colClassName.MinimumWidth = 100;
            this.colClassName.Name = "colClassName";
            this.colClassName.ReadOnly = true;
            // 
            // colPhysicalItem
            // 
            this.colPhysicalItem.HeaderText = "考试科目";
            this.colPhysicalItem.Name = "colPhysicalItem";
            this.colPhysicalItem.ReadOnly = true;
            // 
            // colCurrentScore
            // 
            this.colCurrentScore.HeaderText = "成绩";
            this.colCurrentScore.Name = "colCurrentScore";
            this.colCurrentScore.ReadOnly = true;
            this.colCurrentScore.Width = 80;
            // 
            // colCurrentResult
            // 
            this.colCurrentResult.HeaderText = "得分";
            this.colCurrentResult.Name = "colCurrentResult";
            this.colCurrentResult.ReadOnly = true;
            this.colCurrentResult.Width = 80;
            // 
            // colScore1
            // 
            this.colScore1.HeaderText = "成绩一";
            this.colScore1.Name = "colScore1";
            this.colScore1.ReadOnly = true;
            this.colScore1.Visible = false;
            this.colScore1.Width = 80;
            // 
            // colScore2
            // 
            this.colScore2.HeaderText = "成绩二";
            this.colScore2.Name = "colScore2";
            this.colScore2.ReadOnly = true;
            this.colScore2.Visible = false;
            this.colScore2.Width = 80;
            // 
            // colScore3
            // 
            this.colScore3.HeaderText = "成绩三";
            this.colScore3.Name = "colScore3";
            this.colScore3.ReadOnly = true;
            this.colScore3.Visible = false;
            this.colScore3.Width = 80;
            // 
            // colScore4
            // 
            this.colScore4.HeaderText = "成绩四";
            this.colScore4.Name = "colScore4";
            this.colScore4.ReadOnly = true;
            this.colScore4.Visible = false;
            this.colScore4.Width = 80;
            // 
            // colScore5
            // 
            this.colScore5.HeaderText = "成绩五";
            this.colScore5.Name = "colScore5";
            this.colScore5.ReadOnly = true;
            this.colScore5.Visible = false;
            this.colScore5.Width = 80;
            // 
            // colScore6
            // 
            this.colScore6.HeaderText = "成绩六";
            this.colScore6.Name = "colScore6";
            this.colScore6.ReadOnly = true;
            this.colScore6.Visible = false;
            this.colScore6.Width = 80;
            // 
            // colScores
            // 
            this.colScores.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colScores.HeaderText = "";
            this.colScores.Name = "colScores";
            this.colScores.ReadOnly = true;
            // 
            // Frm学生单项成绩查看
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 387);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm学生单项成绩查看";
            this.Text = "学生单项成绩查看";
            this.Load += new System.EventHandler(this.Frm学生单项成绩查看_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnu导出;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFacility;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhysicalItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCurrentScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCurrentResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn colScore1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colScore2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colScore3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colScore4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colScore5;
        private System.Windows.Forms.DataGridViewTextBoxColumn colScore6;
        private System.Windows.Forms.DataGridViewTextBoxColumn colScores;
    }
}