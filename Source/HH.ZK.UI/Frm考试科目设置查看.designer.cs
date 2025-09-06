namespace HH.ZK.UI
{
    partial class Frm考试科目设置查看
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm考试科目设置查看));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.dataGridView1.Location = new System.Drawing.Point(2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1067, 568);
            this.dataGridView1.TabIndex = 92;
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
            // Frm考试科目设置查看
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 572);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm考试科目设置查看";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "考试科目设置";
            this.Load += new System.EventHandler(this.Frm考试科目设置_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
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