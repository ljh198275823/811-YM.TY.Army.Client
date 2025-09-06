namespace HH.ZK.UI
{
    partial class Frm考试科目设置
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm考试科目设置));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnu增加考试科目 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu增加自定义科目 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu删除考试科目 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btn删除项 = new System.Windows.Forms.Button();
            this.btn增加项 = new System.Windows.Forms.Button();
            this.btn增加自定义科目 = new System.Windows.Forms.Button();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colShortName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col必考 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.col性别 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPointCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSortMode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col舍入类型 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTestCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col成绩来源 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(1115, 506);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(112, 41);
            this.btnClose.TabIndex = 91;
            this.btnClose.Text = "关闭(&C)";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(953, 506);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(112, 41);
            this.btnOk.TabIndex = 90;
            this.btnOk.Text = "确定(&O)";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
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
            this.dataGridView1.ColumnHeadersHeight = 32;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colName,
            this.colShortName,
            this.col必考,
            this.col性别,
            this.colUnit,
            this.colPointCount,
            this.colMin,
            this.colMax,
            this.colSortMode,
            this.col舍入类型,
            this.colTestCount,
            this.col成绩来源,
            this.colFill});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1236, 482);
            this.dataGridView1.TabIndex = 92;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu增加考试科目,
            this.mnu增加自定义科目,
            this.mnu删除考试科目});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(185, 70);
            // 
            // mnu增加考试科目
            // 
            this.mnu增加考试科目.Name = "mnu增加考试科目";
            this.mnu增加考试科目.Size = new System.Drawing.Size(184, 22);
            this.mnu增加考试科目.Text = "增加考试科目";
            this.mnu增加考试科目.Click += new System.EventHandler(this.mnu增加考试科目_Click);
            // 
            // mnu增加自定义科目
            // 
            this.mnu增加自定义科目.Name = "mnu增加自定义科目";
            this.mnu增加自定义科目.Size = new System.Drawing.Size(184, 22);
            this.mnu增加自定义科目.Text = "增加自定义考试科目";
            this.mnu增加自定义科目.Click += new System.EventHandler(this.mnu增加自定义科目_Click);
            // 
            // mnu删除考试科目
            // 
            this.mnu删除考试科目.Name = "mnu删除考试科目";
            this.mnu删除考试科目.Size = new System.Drawing.Size(184, 22);
            this.mnu删除考试科目.Text = "删除考试科目";
            this.mnu删除考试科目.Click += new System.EventHandler(this.mnu删除考试科目_Click);
            // 
            // btnDown
            // 
            this.btnDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDown.BackgroundImage = global::HH.ZK.UI.Properties.Resources.down;
            this.btnDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDown.Location = new System.Drawing.Point(110, 504);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(33, 45);
            this.btnDown.TabIndex = 94;
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnUp
            // 
            this.btnUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUp.BackgroundImage = global::HH.ZK.UI.Properties.Resources.up;
            this.btnUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUp.Location = new System.Drawing.Point(57, 504);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(33, 45);
            this.btnUp.TabIndex = 93;
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btn删除项
            // 
            this.btn删除项.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn删除项.Location = new System.Drawing.Point(549, 506);
            this.btn删除项.Name = "btn删除项";
            this.btn删除项.Size = new System.Drawing.Size(112, 41);
            this.btn删除项.TabIndex = 98;
            this.btn删除项.Text = "删除项";
            this.btn删除项.UseVisualStyleBackColor = true;
            this.btn删除项.Click += new System.EventHandler(this.mnu删除考试科目_Click);
            // 
            // btn增加项
            // 
            this.btn增加项.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn增加项.Location = new System.Drawing.Point(409, 506);
            this.btn增加项.Name = "btn增加项";
            this.btn增加项.Size = new System.Drawing.Size(112, 41);
            this.btn增加项.TabIndex = 97;
            this.btn增加项.Text = "增加项";
            this.btn增加项.UseVisualStyleBackColor = true;
            this.btn增加项.Click += new System.EventHandler(this.mnu增加考试科目_Click);
            // 
            // btn增加自定义科目
            // 
            this.btn增加自定义科目.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn增加自定义科目.Location = new System.Drawing.Point(686, 506);
            this.btn增加自定义科目.Name = "btn增加自定义科目";
            this.btn增加自定义科目.Size = new System.Drawing.Size(156, 41);
            this.btn增加自定义科目.TabIndex = 99;
            this.btn增加自定义科目.Text = "增加自定义科目";
            this.btn增加自定义科目.UseVisualStyleBackColor = true;
            this.btn增加自定义科目.Click += new System.EventHandler(this.mnu增加自定义科目_Click);
            // 
            // colID
            // 
            this.colID.HeaderText = "编号";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colID.Width = 60;
            // 
            // colName
            // 
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colName.HeaderText = "名称";
            this.colName.MinimumWidth = 100;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colShortName
            // 
            this.colShortName.HeaderText = "简称";
            this.colShortName.Name = "colShortName";
            this.colShortName.ReadOnly = true;
            this.colShortName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // col必考
            // 
            this.col必考.HeaderText = "必考项";
            this.col必考.Name = "col必考";
            this.col必考.ReadOnly = true;
            this.col必考.Width = 60;
            // 
            // col性别
            // 
            this.col性别.HeaderText = "性别";
            this.col性别.Name = "col性别";
            this.col性别.ReadOnly = true;
            this.col性别.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col性别.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.col性别.Width = 80;
            // 
            // colUnit
            // 
            this.colUnit.HeaderText = "单位";
            this.colUnit.Name = "colUnit";
            this.colUnit.ReadOnly = true;
            this.colUnit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colUnit.Width = 80;
            // 
            // colPointCount
            // 
            this.colPointCount.HeaderText = "小数位数";
            this.colPointCount.Name = "colPointCount";
            this.colPointCount.ReadOnly = true;
            this.colPointCount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colPointCount.Width = 80;
            // 
            // colMin
            // 
            this.colMin.HeaderText = "最小值";
            this.colMin.Name = "colMin";
            this.colMin.ReadOnly = true;
            this.colMin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colMin.Width = 80;
            // 
            // colMax
            // 
            this.colMax.HeaderText = "最大值";
            this.colMax.Name = "colMax";
            this.colMax.ReadOnly = true;
            this.colMax.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colMax.Width = 80;
            // 
            // colSortMode
            // 
            this.colSortMode.HeaderText = "排序模式";
            this.colSortMode.Name = "colSortMode";
            this.colSortMode.ReadOnly = true;
            // 
            // col舍入类型
            // 
            this.col舍入类型.HeaderText = "舍入方式";
            this.col舍入类型.Name = "col舍入类型";
            this.col舍入类型.ReadOnly = true;
            this.col舍入类型.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.col舍入类型.Width = 80;
            // 
            // colTestCount
            // 
            this.colTestCount.HeaderText = "测试次数";
            this.colTestCount.Name = "colTestCount";
            this.colTestCount.ReadOnly = true;
            this.colTestCount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colTestCount.Width = 80;
            // 
            // col成绩来源
            // 
            this.col成绩来源.HeaderText = "成绩来源";
            this.col成绩来源.Name = "col成绩来源";
            this.col成绩来源.ReadOnly = true;
            this.col成绩来源.Width = 120;
            // 
            // colFill
            // 
            this.colFill.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colFill.HeaderText = "";
            this.colFill.Name = "colFill";
            this.colFill.ReadOnly = true;
            this.colFill.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Frm考试科目设置
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1239, 570);
            this.Controls.Add(this.btn增加自定义科目);
            this.Controls.Add(this.btn删除项);
            this.Controls.Add(this.btn增加项);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOk);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm考试科目设置";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "考试科目设置";
            this.Load += new System.EventHandler(this.Frm考试科目设置_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Button btnClose;
        protected System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnu增加考试科目;
        private System.Windows.Forms.ToolStripMenuItem mnu增加自定义科目;
        private System.Windows.Forms.ToolStripMenuItem mnu删除考试科目;
        protected System.Windows.Forms.Button btn删除项;
        protected System.Windows.Forms.Button btn增加项;
        protected System.Windows.Forms.Button btn增加自定义科目;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShortName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn col必考;
        private System.Windows.Forms.DataGridViewTextBoxColumn col性别;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPointCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMax;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSortMode;
        private System.Windows.Forms.DataGridViewTextBoxColumn col舍入类型;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTestCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn col成绩来源;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFill;
    }
}