namespace HH.ZK.UI
{
    partial class Frm评分标准
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm评分标准));
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.myTree1 = new LJH.GeneralLibrary.WinformControl.MyTree(this.components);
            this.btnImport = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.dataGridview1 = new System.Windows.Forms.DataGridView();
            this.colSer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnu删除评分标准 = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridview1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.myTree1);
            this.pnlLeft.Controls.Add(this.btnImport);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(291, 650);
            this.pnlLeft.TabIndex = 64;
            // 
            // myTree1
            // 
            this.myTree1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myTree1.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawText;
            this.myTree1.HideSelection = false;
            this.myTree1.Indent = 30;
            this.myTree1.ItemHeight = 25;
            this.myTree1.Location = new System.Drawing.Point(0, 49);
            this.myTree1.Name = "myTree1";
            this.myTree1.Size = new System.Drawing.Size(291, 601);
            this.myTree1.TabIndex = 2;
            this.myTree1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.myTree1_NodeMouseClick);
            // 
            // btnImport
            // 
            this.btnImport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnImport.Location = new System.Drawing.Point(0, 0);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(291, 49);
            this.btnImport.TabIndex = 1;
            this.btnImport.Text = "导入评分标准";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btn_Import_Click);
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.splitter1.Location = new System.Drawing.Point(291, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(7, 650);
            this.splitter1.TabIndex = 115;
            this.splitter1.TabStop = false;
            // 
            // dataGridview1
            // 
            this.dataGridview1.AllowUserToAddRows = false;
            this.dataGridview1.AllowUserToDeleteRows = false;
            this.dataGridview1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridview1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridview1.ColumnHeadersHeight = 32;
            this.dataGridview1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridview1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSer,
            this.colScore,
            this.colResult,
            this.colRank});
            this.dataGridview1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridview1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridview1.Location = new System.Drawing.Point(298, 0);
            this.dataGridview1.Name = "dataGridview1";
            this.dataGridview1.RowHeadersVisible = false;
            this.dataGridview1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dataGridview1.RowTemplate.Height = 30;
            this.dataGridview1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridview1.Size = new System.Drawing.Size(902, 650);
            this.dataGridview1.TabIndex = 116;
            this.dataGridview1.Visible = false;
            // 
            // colSer
            // 
            this.colSer.HeaderText = "";
            this.colSer.Name = "colSer";
            this.colSer.ReadOnly = true;
            this.colSer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colSer.Width = 60;
            // 
            // colScore
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colScore.DefaultCellStyle = dataGridViewCellStyle2;
            this.colScore.HeaderText = "成绩";
            this.colScore.Name = "colScore";
            this.colScore.ReadOnly = true;
            this.colScore.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colResult
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colResult.DefaultCellStyle = dataGridViewCellStyle3;
            this.colResult.HeaderText = "得分";
            this.colResult.Name = "colResult";
            this.colResult.ReadOnly = true;
            this.colResult.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colRank
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colRank.DefaultCellStyle = dataGridViewCellStyle4;
            this.colRank.HeaderText = "等级";
            this.colRank.Name = "colRank";
            this.colRank.ReadOnly = true;
            this.colRank.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu删除评分标准});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(149, 26);
            // 
            // mnu删除评分标准
            // 
            this.mnu删除评分标准.Name = "mnu删除评分标准";
            this.mnu删除评分标准.Size = new System.Drawing.Size(148, 22);
            this.mnu删除评分标准.Text = "删除评分标准";
            this.mnu删除评分标准.Click += new System.EventHandler(this.mnu删除评分标准_Click);
            // 
            // Frm评分标准
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.dataGridview1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.pnlLeft);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm评分标准";
            this.Text = "评分标准管理";
            this.Load += new System.EventHandler(this.Frm评分标准_Load);
            this.pnlLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridview1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.DataGridView dataGridview1;
        private LJH.GeneralLibrary.WinformControl.MyTree myTree1;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnu删除评分标准;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn colResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRank;
    }
}