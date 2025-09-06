namespace HH.ZK.CommonUI
{
    partial class FrmPhysicalItemMaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPhysicalItemMaster));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colShortName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPointCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTestCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHasMachine = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colSortMode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFormula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMemo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colName,
            this.colShortName,
            this.colUnit,
            this.colPointCount,
            this.colTestCount,
            this.colMin,
            this.colMax,
            this.colHasMachine,
            this.colSortMode,
            this.colFormula,
            this.colMemo});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1289, 627);
            this.dataGridView1.TabIndex = 63;
            // 
            // colID
            // 
            this.colID.HeaderText = "编号";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            // 
            // colName
            // 
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colName.HeaderText = "名称";
            this.colName.MinimumWidth = 100;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colShortName
            // 
            this.colShortName.HeaderText = "简称";
            this.colShortName.Name = "colShortName";
            this.colShortName.ReadOnly = true;
            // 
            // colUnit
            // 
            this.colUnit.HeaderText = "单位";
            this.colUnit.Name = "colUnit";
            this.colUnit.ReadOnly = true;
            // 
            // colPointCount
            // 
            this.colPointCount.HeaderText = "小数位数";
            this.colPointCount.Name = "colPointCount";
            this.colPointCount.ReadOnly = true;
            // 
            // colTestCount
            // 
            this.colTestCount.HeaderText = "测试次数";
            this.colTestCount.Name = "colTestCount";
            this.colTestCount.ReadOnly = true;
            // 
            // colMin
            // 
            this.colMin.HeaderText = "最小值";
            this.colMin.Name = "colMin";
            this.colMin.ReadOnly = true;
            // 
            // colMax
            // 
            this.colMax.HeaderText = "最大值";
            this.colMax.Name = "colMax";
            this.colMax.ReadOnly = true;
            // 
            // colHasMachine
            // 
            this.colHasMachine.HeaderText = "系统默认";
            this.colHasMachine.Name = "colHasMachine";
            this.colHasMachine.ReadOnly = true;
            // 
            // colSortMode
            // 
            this.colSortMode.HeaderText = "成绩模式";
            this.colSortMode.Name = "colSortMode";
            this.colSortMode.ReadOnly = true;
            this.colSortMode.Width = 80;
            // 
            // colFormula
            // 
            this.colFormula.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colFormula.HeaderText = "计算公式";
            this.colFormula.MinimumWidth = 200;
            this.colFormula.Name = "colFormula";
            this.colFormula.ReadOnly = true;
            this.colFormula.Width = 200;
            // 
            // colMemo
            // 
            this.colMemo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMemo.HeaderText = "备注";
            this.colMemo.Name = "colMemo";
            this.colMemo.ReadOnly = true;
            // 
            // FrmPhysicalItemMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 649);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPhysicalItemMaster";
            this.Text = "测试项目管理";
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShortName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPointCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTestCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMax;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colHasMachine;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSortMode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFormula;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMemo;

    }
}