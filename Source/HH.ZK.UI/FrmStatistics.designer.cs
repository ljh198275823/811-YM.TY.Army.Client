namespace HH.ZK.UI
{
    partial class FrmStatistics
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStatistics));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cMnu_SelectColumns = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.ucStatiticsSearch1 = new HH.ZK.CommonUI.Controls.UCStatiticsSearch();
            this.cmbPhysicalItem = new HH.ZK.CommonUI.Controls.PhysicalItemComboBox(this.components);
            this.colDivision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFacility = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhysicalItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col总人数 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.col完成人数 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.col未测试人数 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.col总成绩 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAverage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col标准差 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col最高成绩 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col最低成绩 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col平均得分 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colManFen = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colManFenRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colYouxiu = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colYouxiuRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLianghao = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colLianghaoRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col优良人数 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.col优良率 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col合格人数 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.col合格率 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col中等人数 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.col中等率 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJige = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colJigeRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBujige = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colBujigeRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnColumn
            // 
            this.btnColumn.Location = new System.Drawing.Point(1194, 18);
            this.btnColumn.Size = new System.Drawing.Size(111, 66);
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.Location = new System.Drawing.Point(1072, 18);
            this.btnSaveAs.Size = new System.Drawing.Size(111, 66);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(934, 18);
            this.btnSearch.Size = new System.Drawing.Size(111, 66);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeight = 32;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDivision,
            this.colFacility,
            this.colPhysicalItem,
            this.colClassName,
            this.colSex,
            this.col总人数,
            this.col完成人数,
            this.col未测试人数,
            this.col总成绩,
            this.colAverage,
            this.col标准差,
            this.col最高成绩,
            this.col最低成绩,
            this.col平均得分,
            this.colManFen,
            this.colManFenRate,
            this.colYouxiu,
            this.colYouxiuRate,
            this.colLianghao,
            this.colLianghaoRate,
            this.col优良人数,
            this.col优良率,
            this.col合格人数,
            this.col合格率,
            this.col中等人数,
            this.col中等率,
            this.colJige,
            this.colJigeRate,
            this.colBujige,
            this.colBujigeRate});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(0, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("宋体", 10.5F);
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1362, 506);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cMnu_SelectColumns});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(122, 26);
            // 
            // cMnu_SelectColumns
            // 
            this.cMnu_SelectColumns.Name = "cMnu_SelectColumns";
            this.cMnu_SelectColumns.Size = new System.Drawing.Size(121, 22);
            this.cMnu_SelectColumns.Text = "选择列...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(672, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 18;
            this.label1.Text = "考试科目";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ucStatiticsSearch1
            // 
            this.ucStatiticsSearch1.Location = new System.Drawing.Point(4, 3);
            this.ucStatiticsSearch1.Name = "ucStatiticsSearch1";
            this.ucStatiticsSearch1.Size = new System.Drawing.Size(668, 94);
            this.ucStatiticsSearch1.TabIndex = 191;
            // 
            // cmbPhysicalItem
            // 
            this.cmbPhysicalItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPhysicalItem.FormattingEnabled = true;
            this.cmbPhysicalItem.Location = new System.Drawing.Point(727, 12);
            this.cmbPhysicalItem.Name = "cmbPhysicalItem";
            this.cmbPhysicalItem.Size = new System.Drawing.Size(151, 20);
            this.cmbPhysicalItem.TabIndex = 192;
            // 
            // colDivision
            // 
            this.colDivision.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colDivision.HeaderText = "区域";
            this.colDivision.MinimumWidth = 100;
            this.colDivision.Name = "colDivision";
            this.colDivision.ReadOnly = true;
            // 
            // colFacility
            // 
            this.colFacility.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colFacility.HeaderText = "学校";
            this.colFacility.MinimumWidth = 100;
            this.colFacility.Name = "colFacility";
            this.colFacility.ReadOnly = true;
            // 
            // colPhysicalItem
            // 
            this.colPhysicalItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colPhysicalItem.HeaderText = "考试科目";
            this.colPhysicalItem.MinimumWidth = 100;
            this.colPhysicalItem.Name = "colPhysicalItem";
            this.colPhysicalItem.ReadOnly = true;
            // 
            // colClassName
            // 
            this.colClassName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colClassName.HeaderText = "班级";
            this.colClassName.MinimumWidth = 100;
            this.colClassName.Name = "colClassName";
            this.colClassName.ReadOnly = true;
            // 
            // colSex
            // 
            this.colSex.HeaderText = "性别";
            this.colSex.Name = "colSex";
            this.colSex.ReadOnly = true;
            this.colSex.Width = 60;
            // 
            // col总人数
            // 
            this.col总人数.HeaderText = "总人数";
            this.col总人数.Name = "col总人数";
            this.col总人数.ReadOnly = true;
            this.col总人数.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col总人数.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col总人数.Width = 80;
            // 
            // col完成人数
            // 
            this.col完成人数.HeaderText = "已考人数";
            this.col完成人数.Name = "col完成人数";
            this.col完成人数.ReadOnly = true;
            this.col完成人数.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col完成人数.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col完成人数.Width = 80;
            // 
            // col未测试人数
            // 
            this.col未测试人数.HeaderText = "未测人数";
            this.col未测试人数.Name = "col未测试人数";
            this.col未测试人数.ReadOnly = true;
            this.col未测试人数.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col未测试人数.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col未测试人数.Width = 80;
            // 
            // col总成绩
            // 
            this.col总成绩.HeaderText = "总成绩";
            this.col总成绩.Name = "col总成绩";
            this.col总成绩.ReadOnly = true;
            this.col总成绩.Width = 80;
            // 
            // colAverage
            // 
            this.colAverage.HeaderText = "平均成绩";
            this.colAverage.Name = "colAverage";
            this.colAverage.ReadOnly = true;
            this.colAverage.Width = 80;
            // 
            // col标准差
            // 
            this.col标准差.HeaderText = "标准差";
            this.col标准差.Name = "col标准差";
            this.col标准差.ReadOnly = true;
            this.col标准差.Visible = false;
            this.col标准差.Width = 80;
            // 
            // col最高成绩
            // 
            this.col最高成绩.HeaderText = "最高成绩";
            this.col最高成绩.Name = "col最高成绩";
            this.col最高成绩.ReadOnly = true;
            this.col最高成绩.Width = 80;
            // 
            // col最低成绩
            // 
            this.col最低成绩.HeaderText = "最低成绩";
            this.col最低成绩.Name = "col最低成绩";
            this.col最低成绩.ReadOnly = true;
            this.col最低成绩.Width = 80;
            // 
            // col平均得分
            // 
            dataGridViewCellStyle1.Format = "N2";
            this.col平均得分.DefaultCellStyle = dataGridViewCellStyle1;
            this.col平均得分.HeaderText = "平均得分";
            this.col平均得分.Name = "col平均得分";
            this.col平均得分.ReadOnly = true;
            this.col平均得分.Width = 80;
            // 
            // colManFen
            // 
            this.colManFen.HeaderText = "满分人数";
            this.colManFen.Name = "colManFen";
            this.colManFen.ReadOnly = true;
            this.colManFen.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colManFen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colManFen.Width = 80;
            // 
            // colManFenRate
            // 
            dataGridViewCellStyle2.Format = "P2";
            this.colManFenRate.DefaultCellStyle = dataGridViewCellStyle2;
            this.colManFenRate.HeaderText = "满分率";
            this.colManFenRate.Name = "colManFenRate";
            this.colManFenRate.ReadOnly = true;
            this.colManFenRate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colManFenRate.Width = 80;
            // 
            // colYouxiu
            // 
            this.colYouxiu.HeaderText = "优秀人数";
            this.colYouxiu.Name = "colYouxiu";
            this.colYouxiu.ReadOnly = true;
            this.colYouxiu.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colYouxiu.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colYouxiu.Width = 80;
            // 
            // colYouxiuRate
            // 
            dataGridViewCellStyle3.Format = "P2";
            this.colYouxiuRate.DefaultCellStyle = dataGridViewCellStyle3;
            this.colYouxiuRate.HeaderText = "优秀率";
            this.colYouxiuRate.Name = "colYouxiuRate";
            this.colYouxiuRate.ReadOnly = true;
            this.colYouxiuRate.Width = 80;
            // 
            // colLianghao
            // 
            this.colLianghao.HeaderText = "良好人数";
            this.colLianghao.Name = "colLianghao";
            this.colLianghao.ReadOnly = true;
            this.colLianghao.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colLianghao.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colLianghao.Width = 80;
            // 
            // colLianghaoRate
            // 
            dataGridViewCellStyle4.Format = "P2";
            this.colLianghaoRate.DefaultCellStyle = dataGridViewCellStyle4;
            this.colLianghaoRate.HeaderText = "良好率";
            this.colLianghaoRate.Name = "colLianghaoRate";
            this.colLianghaoRate.ReadOnly = true;
            this.colLianghaoRate.Width = 80;
            // 
            // col优良人数
            // 
            this.col优良人数.HeaderText = "优良人数";
            this.col优良人数.Name = "col优良人数";
            this.col优良人数.ReadOnly = true;
            this.col优良人数.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col优良人数.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col优良人数.Width = 80;
            // 
            // col优良率
            // 
            dataGridViewCellStyle5.Format = "P2";
            this.col优良率.DefaultCellStyle = dataGridViewCellStyle5;
            this.col优良率.HeaderText = "优良率";
            this.col优良率.Name = "col优良率";
            this.col优良率.ReadOnly = true;
            this.col优良率.Width = 80;
            // 
            // col合格人数
            // 
            this.col合格人数.HeaderText = "合格人数";
            this.col合格人数.Name = "col合格人数";
            this.col合格人数.ReadOnly = true;
            this.col合格人数.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col合格人数.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col合格人数.Width = 80;
            // 
            // col合格率
            // 
            dataGridViewCellStyle6.Format = "P2";
            this.col合格率.DefaultCellStyle = dataGridViewCellStyle6;
            this.col合格率.HeaderText = "合格率";
            this.col合格率.Name = "col合格率";
            this.col合格率.ReadOnly = true;
            this.col合格率.Width = 80;
            // 
            // col中等人数
            // 
            this.col中等人数.HeaderText = "中等人数";
            this.col中等人数.Name = "col中等人数";
            this.col中等人数.ReadOnly = true;
            this.col中等人数.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col中等人数.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col中等人数.Width = 80;
            // 
            // col中等率
            // 
            dataGridViewCellStyle7.Format = "P2";
            this.col中等率.DefaultCellStyle = dataGridViewCellStyle7;
            this.col中等率.HeaderText = "中等率";
            this.col中等率.Name = "col中等率";
            this.col中等率.ReadOnly = true;
            this.col中等率.Width = 80;
            // 
            // colJige
            // 
            this.colJige.HeaderText = "及格人数";
            this.colJige.Name = "colJige";
            this.colJige.ReadOnly = true;
            this.colJige.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colJige.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colJige.Width = 80;
            // 
            // colJigeRate
            // 
            dataGridViewCellStyle8.Format = "P2";
            this.colJigeRate.DefaultCellStyle = dataGridViewCellStyle8;
            this.colJigeRate.HeaderText = "及格率";
            this.colJigeRate.Name = "colJigeRate";
            this.colJigeRate.ReadOnly = true;
            this.colJigeRate.Width = 80;
            // 
            // colBujige
            // 
            this.colBujige.HeaderText = "不及格人数";
            this.colBujige.Name = "colBujige";
            this.colBujige.ReadOnly = true;
            this.colBujige.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colBujige.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colBujige.Width = 90;
            // 
            // colBujigeRate
            // 
            dataGridViewCellStyle9.Format = "P2";
            this.colBujigeRate.DefaultCellStyle = dataGridViewCellStyle9;
            this.colBujigeRate.HeaderText = "不及格率";
            this.colBujigeRate.Name = "colBujigeRate";
            this.colBujigeRate.ReadOnly = true;
            this.colBujigeRate.Width = 80;
            // 
            // FrmStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 639);
            this.Controls.Add(this.cmbPhysicalItem);
            this.Controls.Add(this.ucStatiticsSearch1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmStatistics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "单项成绩统计报表";
            this.Controls.SetChildIndex(this.btnSearch, 0);
            this.Controls.SetChildIndex(this.btnSaveAs, 0);
            this.Controls.SetChildIndex(this.btnColumn, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.ucStatiticsSearch1, 0);
            this.Controls.SetChildIndex(this.cmbPhysicalItem, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cMnu_SelectColumns;
        private CommonUI.Controls.UCStatiticsSearch ucStatiticsSearch1;
        private CommonUI.Controls.PhysicalItemComboBox cmbPhysicalItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDivision;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFacility;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhysicalItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSex;
        private System.Windows.Forms.DataGridViewLinkColumn col总人数;
        private System.Windows.Forms.DataGridViewLinkColumn col完成人数;
        private System.Windows.Forms.DataGridViewLinkColumn col未测试人数;
        private System.Windows.Forms.DataGridViewTextBoxColumn col总成绩;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAverage;
        private System.Windows.Forms.DataGridViewTextBoxColumn col标准差;
        private System.Windows.Forms.DataGridViewTextBoxColumn col最高成绩;
        private System.Windows.Forms.DataGridViewTextBoxColumn col最低成绩;
        private System.Windows.Forms.DataGridViewTextBoxColumn col平均得分;
        private System.Windows.Forms.DataGridViewLinkColumn colManFen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colManFenRate;
        private System.Windows.Forms.DataGridViewLinkColumn colYouxiu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colYouxiuRate;
        private System.Windows.Forms.DataGridViewLinkColumn colLianghao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLianghaoRate;
        private System.Windows.Forms.DataGridViewLinkColumn col优良人数;
        private System.Windows.Forms.DataGridViewTextBoxColumn col优良率;
        private System.Windows.Forms.DataGridViewLinkColumn col合格人数;
        private System.Windows.Forms.DataGridViewTextBoxColumn col合格率;
        private System.Windows.Forms.DataGridViewLinkColumn col中等人数;
        private System.Windows.Forms.DataGridViewTextBoxColumn col中等率;
        private System.Windows.Forms.DataGridViewLinkColumn colJige;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJigeRate;
        private System.Windows.Forms.DataGridViewLinkColumn colBujige;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBujigeRate;
    }
}