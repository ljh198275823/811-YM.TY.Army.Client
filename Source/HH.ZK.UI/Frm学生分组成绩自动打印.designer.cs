namespace HH.ZK.UI
{
    partial class Frm学生分组成绩自动打印
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm学生分组成绩自动打印));
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.printedView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colComplted1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrint1 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.printingView = new System.Windows.Forms.DataGridView();
            this.colGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhysicalItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col已完成 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCompleted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrint = new System.Windows.Forms.DataGridViewLinkColumn();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTitle = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnModalBrowser = new System.Windows.Forms.Button();
            this.txtModelFile = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.chkAutoPrint = new System.Windows.Forms.CheckBox();
            this.chk语音提示打印完成的组 = new System.Windows.Forms.CheckBox();
            this.pnlFill = new System.Windows.Forms.Panel();
            this.studentView = new System.Windows.Forms.DataGridView();
            this.colFacility = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChannel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhysicalItem1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFirstScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSecondScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThirdScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.printedView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingView)).BeginInit();
            this.pnlRight.SuspendLayout();
            this.pnlFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentView)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.printedView);
            this.pnlLeft.Controls.Add(this.splitter2);
            this.pnlLeft.Controls.Add(this.printingView);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(646, 663);
            this.pnlLeft.TabIndex = 34;
            // 
            // printedView
            // 
            this.printedView.AllowUserToAddRows = false;
            this.printedView.AllowUserToDeleteRows = false;
            this.printedView.AllowUserToResizeRows = false;
            this.printedView.BackgroundColor = System.Drawing.Color.White;
            this.printedView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.printedView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.colComplted1,
            this.colPrint1});
            this.printedView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.printedView.Location = new System.Drawing.Point(0, 411);
            this.printedView.Name = "printedView";
            this.printedView.RowHeadersVisible = false;
            this.printedView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("宋体", 10F);
            this.printedView.RowTemplate.Height = 30;
            this.printedView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.printedView.Size = new System.Drawing.Size(646, 252);
            this.printedView.TabIndex = 157;
            this.printedView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.groupView_CellContentClick);
            this.printedView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.groupView_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "组别";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 100;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn2.HeaderText = "考试科目";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn2.Width = 59;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "人数";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn3.Width = 70;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "已经测试";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn4.Width = 70;
            // 
            // colComplted1
            // 
            this.colComplted1.HeaderText = "完成测试";
            this.colComplted1.Name = "colComplted1";
            this.colComplted1.ReadOnly = true;
            this.colComplted1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colComplted1.Width = 70;
            // 
            // colPrint1
            // 
            this.colPrint1.HeaderText = "打印";
            this.colPrint1.Name = "colPrint1";
            this.colPrint1.ReadOnly = true;
            this.colPrint1.Width = 80;
            // 
            // splitter2
            // 
            this.splitter2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter2.Location = new System.Drawing.Point(0, 405);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(646, 6);
            this.splitter2.TabIndex = 156;
            this.splitter2.TabStop = false;
            // 
            // printingView
            // 
            this.printingView.AllowUserToAddRows = false;
            this.printingView.AllowUserToDeleteRows = false;
            this.printingView.AllowUserToResizeRows = false;
            this.printingView.BackgroundColor = System.Drawing.Color.White;
            this.printingView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.printingView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colGroup,
            this.colPhysicalItem,
            this.colCount,
            this.col已完成,
            this.colCompleted,
            this.colPrint});
            this.printingView.Dock = System.Windows.Forms.DockStyle.Top;
            this.printingView.Location = new System.Drawing.Point(0, 0);
            this.printingView.Name = "printingView";
            this.printingView.RowHeadersVisible = false;
            this.printingView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("宋体", 10F);
            this.printingView.RowTemplate.Height = 30;
            this.printingView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.printingView.Size = new System.Drawing.Size(646, 405);
            this.printingView.TabIndex = 155;
            this.printingView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.groupView_CellContentClick);
            this.printingView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.groupView_CellDoubleClick);
            // 
            // colGroup
            // 
            this.colGroup.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colGroup.HeaderText = "组别";
            this.colGroup.MinimumWidth = 100;
            this.colGroup.Name = "colGroup";
            this.colGroup.ReadOnly = true;
            this.colGroup.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colPhysicalItem
            // 
            this.colPhysicalItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colPhysicalItem.HeaderText = "考试科目";
            this.colPhysicalItem.Name = "colPhysicalItem";
            this.colPhysicalItem.ReadOnly = true;
            this.colPhysicalItem.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colPhysicalItem.Width = 59;
            // 
            // colCount
            // 
            this.colCount.HeaderText = "人数";
            this.colCount.Name = "colCount";
            this.colCount.ReadOnly = true;
            this.colCount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colCount.Width = 70;
            // 
            // col已完成
            // 
            this.col已完成.HeaderText = "已经测试";
            this.col已完成.Name = "col已完成";
            this.col已完成.ReadOnly = true;
            this.col已完成.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.col已完成.Width = 70;
            // 
            // colCompleted
            // 
            this.colCompleted.HeaderText = "完成测试";
            this.colCompleted.Name = "colCompleted";
            this.colCompleted.ReadOnly = true;
            this.colCompleted.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colCompleted.Width = 70;
            // 
            // colPrint
            // 
            this.colPrint.HeaderText = "打印";
            this.colPrint.Name = "colPrint";
            this.colPrint.ReadOnly = true;
            this.colPrint.Width = 80;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.splitter1.Location = new System.Drawing.Point(646, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(6, 663);
            this.splitter1.TabIndex = 35;
            this.splitter1.TabStop = false;
            // 
            // pnlRight
            // 
            this.pnlRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRight.Controls.Add(this.label3);
            this.pnlRight.Controls.Add(this.txtTitle);
            this.pnlRight.Controls.Add(this.label2);
            this.pnlRight.Controls.Add(this.label1);
            this.pnlRight.Controls.Add(this.btnModalBrowser);
            this.pnlRight.Controls.Add(this.txtModelFile);
            this.pnlRight.Controls.Add(this.chkAutoPrint);
            this.pnlRight.Controls.Add(this.chk语音提示打印完成的组);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRight.Location = new System.Drawing.Point(652, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(824, 152);
            this.pnlRight.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 172;
            this.label3.Text = "成绩确认表标题";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTitle
            // 
            this.txtTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTitle.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTitle.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtTitle.Location = new System.Drawing.Point(117, 105);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(624, 30);
            this.txtTitle.TabIndex = 171;
            this.txtTitle.TextChanged += new System.EventHandler(this.txtTitle_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(328, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(417, 16);
            this.label2.TabIndex = 170;
            this.label2.Text = "(注意：自动打印需要设置好每一个科目的测试次数!）";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 169;
            this.label1.Text = "成绩确认表模板";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnModalBrowser
            // 
            this.btnModalBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModalBrowser.Location = new System.Drawing.Point(747, 71);
            this.btnModalBrowser.Name = "btnModalBrowser";
            this.btnModalBrowser.Size = new System.Drawing.Size(45, 25);
            this.btnModalBrowser.TabIndex = 168;
            this.btnModalBrowser.Text = "...";
            this.btnModalBrowser.UseVisualStyleBackColor = true;
            this.btnModalBrowser.Click += new System.EventHandler(this.btnModalBrowser_Click);
            // 
            // txtModelFile
            // 
            this.txtModelFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtModelFile.Enabled = false;
            this.txtModelFile.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtModelFile.Location = new System.Drawing.Point(117, 74);
            this.txtModelFile.Name = "txtModelFile";
            this.txtModelFile.Size = new System.Drawing.Size(624, 21);
            this.txtModelFile.TabIndex = 167;
            // 
            // chkAutoPrint
            // 
            this.chkAutoPrint.AutoSize = true;
            this.chkAutoPrint.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkAutoPrint.ForeColor = System.Drawing.Color.Blue;
            this.chkAutoPrint.Location = new System.Drawing.Point(24, 46);
            this.chkAutoPrint.Name = "chkAutoPrint";
            this.chkAutoPrint.Size = new System.Drawing.Size(297, 16);
            this.chkAutoPrint.TabIndex = 166;
            this.chkAutoPrint.Text = "当该组学生全部测试完成后自动打印本组成绩单";
            this.chkAutoPrint.UseVisualStyleBackColor = true;
            this.chkAutoPrint.CheckedChanged += new System.EventHandler(this.chkAutoPrint_CheckedChanged);
            // 
            // chk语音提示打印完成的组
            // 
            this.chk语音提示打印完成的组.AutoSize = true;
            this.chk语音提示打印完成的组.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chk语音提示打印完成的组.ForeColor = System.Drawing.Color.Blue;
            this.chk语音提示打印完成的组.Location = new System.Drawing.Point(24, 16);
            this.chk语音提示打印完成的组.Name = "chk语音提示打印完成的组";
            this.chk语音提示打印完成的组.Size = new System.Drawing.Size(154, 16);
            this.chk语音提示打印完成的组.TabIndex = 164;
            this.chk语音提示打印完成的组.Text = "语音提示打印完成的组";
            this.chk语音提示打印完成的组.UseVisualStyleBackColor = true;
            this.chk语音提示打印完成的组.CheckedChanged += new System.EventHandler(this.chk语音提示打印完成的组_CheckedChanged);
            // 
            // pnlFill
            // 
            this.pnlFill.Controls.Add(this.studentView);
            this.pnlFill.Controls.Add(this.statusStrip1);
            this.pnlFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFill.Location = new System.Drawing.Point(652, 152);
            this.pnlFill.Name = "pnlFill";
            this.pnlFill.Size = new System.Drawing.Size(824, 511);
            this.pnlFill.TabIndex = 39;
            // 
            // studentView
            // 
            this.studentView.AllowUserToAddRows = false;
            this.studentView.AllowUserToDeleteRows = false;
            this.studentView.AllowUserToResizeRows = false;
            this.studentView.BackgroundColor = System.Drawing.Color.White;
            this.studentView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFacility,
            this.colID,
            this.colName,
            this.colSex,
            this.colChannel,
            this.colPhysicalItem1,
            this.colFirstScore,
            this.colSecondScore,
            this.colThirdScore,
            this.colScore,
            this.colResult});
            this.studentView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentView.Location = new System.Drawing.Point(0, 0);
            this.studentView.Name = "studentView";
            this.studentView.RowHeadersVisible = false;
            this.studentView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.studentView.RowTemplate.Height = 23;
            this.studentView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.studentView.Size = new System.Drawing.Size(824, 489);
            this.studentView.TabIndex = 154;
            // 
            // colFacility
            // 
            this.colFacility.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colFacility.HeaderText = "学校";
            this.colFacility.MinimumWidth = 100;
            this.colFacility.Name = "colFacility";
            this.colFacility.ReadOnly = true;
            this.colFacility.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colID
            // 
            this.colID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colID.HeaderText = "准考证号";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colID.Width = 59;
            // 
            // colName
            // 
            this.colName.HeaderText = "姓名";
            this.colName.MinimumWidth = 80;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colName.Width = 80;
            // 
            // colSex
            // 
            this.colSex.HeaderText = "性别";
            this.colSex.Name = "colSex";
            this.colSex.ReadOnly = true;
            this.colSex.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colSex.Width = 40;
            // 
            // colChannel
            // 
            this.colChannel.HeaderText = "道次";
            this.colChannel.Name = "colChannel";
            this.colChannel.ReadOnly = true;
            this.colChannel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colChannel.Width = 40;
            // 
            // colPhysicalItem1
            // 
            this.colPhysicalItem1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colPhysicalItem1.HeaderText = "考试科目";
            this.colPhysicalItem1.Name = "colPhysicalItem1";
            this.colPhysicalItem1.ReadOnly = true;
            this.colPhysicalItem1.Width = 78;
            // 
            // colFirstScore
            // 
            this.colFirstScore.HeaderText = "第一次";
            this.colFirstScore.Name = "colFirstScore";
            this.colFirstScore.ReadOnly = true;
            this.colFirstScore.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colFirstScore.Width = 60;
            // 
            // colSecondScore
            // 
            this.colSecondScore.HeaderText = "第二次";
            this.colSecondScore.Name = "colSecondScore";
            this.colSecondScore.ReadOnly = true;
            this.colSecondScore.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colSecondScore.Width = 60;
            // 
            // colThirdScore
            // 
            this.colThirdScore.HeaderText = "第三次";
            this.colThirdScore.Name = "colThirdScore";
            this.colThirdScore.ReadOnly = true;
            this.colThirdScore.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colThirdScore.Width = 60;
            // 
            // colScore
            // 
            this.colScore.HeaderText = "最终成绩";
            this.colScore.Name = "colScore";
            this.colScore.ReadOnly = true;
            this.colScore.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colScore.Width = 60;
            // 
            // colResult
            // 
            this.colResult.HeaderText = "最终得分";
            this.colResult.Name = "colResult";
            this.colResult.ReadOnly = true;
            this.colResult.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colResult.Width = 60;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblCount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 489);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(824, 22);
            this.statusStrip1.TabIndex = 153;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblCount
            // 
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(809, 17);
            this.lblCount.Spring = true;
            this.lblCount.Text = "总共 0 项";
            // 
            // Frm学生分组成绩自动打印
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1476, 663);
            this.Controls.Add(this.pnlFill);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.pnlLeft);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Frm学生分组成绩自动打印";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "考场成绩实时打印";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm学生分组成绩自动打印_FormClosed);
            this.Load += new System.EventHandler(this.Frm学生分组成绩自动打印_Load);
            this.pnlLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.printedView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingView)).EndInit();
            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();
            this.pnlFill.ResumeLayout(false);
            this.pnlFill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentView)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel pnlFill;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblCount;
        private System.Windows.Forms.DataGridView printingView;
        private System.Windows.Forms.DataGridView studentView;
        private System.Windows.Forms.CheckBox chk语音提示打印完成的组;
        private System.Windows.Forms.CheckBox chkAutoPrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFacility;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChannel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhysicalItem1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFirstScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSecondScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThirdScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn colScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn colResult;
        private System.Windows.Forms.DataGridView printedView;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Button btnModalBrowser;
        private LJH.GeneralLibrary.WinformControl.DBCTextBox txtModelFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private LJH.GeneralLibrary.WinformControl.DBCTextBox txtTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colComplted1;
        private System.Windows.Forms.DataGridViewLinkColumn colPrint1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhysicalItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn col已完成;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompleted;
        private System.Windows.Forms.DataGridViewLinkColumn colPrint;
    }
}

