namespace HH.ZK.UI
{
    partial class FrmStatisticsTotal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStatisticsTotal));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dt结束训练日期 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dt开始训练日期 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProject = new HH.ZK.CommonUI.Controls.PhysicalProjectComboBox(this.components);
            this.ucStudentSearch1 = new HH.ZK.CommonUI.Controls.UCStudentSearch();
            this.txtStudentID1 = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.txtName = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.cmbDivision = new HH.ZK.CommonUI.Controls.DivisionComboBox(this.components);
            this.chkByDivision = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.chkByGender = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.colDivision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col性别 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col总人数 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.col未完成人数 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.col未测试人数 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.col完成人数 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colAverage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col平均分等级 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col标准差 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colManFen = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colManFenRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col优良人数 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.col优良率 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col合格人数 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.col合格率 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colYuxiu = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colYuxiuRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLianghao = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colLianghaoRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col中等人数 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.col中等率 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJige = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colJigeRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBujige = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colBujigeRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.ucStudentSearch1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnColumn
            // 
            resources.ApplyResources(this.btnColumn, "btnColumn");
            // 
            // btnSaveAs
            // 
            resources.ApplyResources(this.btnSaveAs, "btnSaveAs");
            // 
            // btnSearch
            // 
            resources.ApplyResources(this.btnSearch, "btnSearch");
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            resources.ApplyResources(this.toolStripStatusLabel1, "toolStripStatusLabel1");
            this.toolStripStatusLabel1.Spring = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDivision,
            this.col性别,
            this.col总人数,
            this.col未完成人数,
            this.col未测试人数,
            this.col完成人数,
            this.colAverage,
            this.col平均分等级,
            this.col标准差,
            this.colManFen,
            this.colManFenRate,
            this.col优良人数,
            this.col优良率,
            this.col合格人数,
            this.col合格率,
            this.colYuxiu,
            this.colYuxiuRate,
            this.colLianghao,
            this.colLianghaoRate,
            this.col中等人数,
            this.col中等率,
            this.colJige,
            this.colJigeRate,
            this.colBujige,
            this.colBujigeRate});
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("宋体", 10.5F);
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dt结束训练日期
            // 
            resources.ApplyResources(this.dt结束训练日期, "dt结束训练日期");
            this.dt结束训练日期.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt结束训练日期.Name = "dt结束训练日期";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // dt开始训练日期
            // 
            resources.ApplyResources(this.dt开始训练日期, "dt开始训练日期");
            this.dt开始训练日期.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt开始训练日期.Name = "dt开始训练日期";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // txtProject
            // 
            resources.ApplyResources(this.txtProject, "txtProject");
            this.txtProject.FormattingEnabled = true;
            this.txtProject.Name = "txtProject";
            // 
            // ucStudentSearch1
            // 
            this.ucStudentSearch1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucStudentSearch1.Controls.Add(this.txtStudentID1);
            this.ucStudentSearch1.Controls.Add(this.txtName);
            resources.ApplyResources(this.ucStudentSearch1, "ucStudentSearch1");
            this.ucStudentSearch1.Name = "ucStudentSearch1";
            // 
            // txtStudentID1
            // 
            resources.ApplyResources(this.txtStudentID1, "txtStudentID1");
            this.txtStudentID1.Name = "txtStudentID1";
            // 
            // txtName
            // 
            resources.ApplyResources(this.txtName, "txtName");
            this.txtName.Name = "txtName";
            // 
            // cmbDivision
            // 
            this.cmbDivision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cmbDivision, "cmbDivision");
            this.cmbDivision.FormattingEnabled = true;
            this.cmbDivision.Name = "cmbDivision";
            // 
            // chkByDivision
            // 
            resources.ApplyResources(this.chkByDivision, "chkByDivision");
            this.chkByDivision.Checked = true;
            this.chkByDivision.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkByDivision.Name = "chkByDivision";
            this.chkByDivision.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // chkByGender
            // 
            resources.ApplyResources(this.chkByGender, "chkByGender");
            this.chkByGender.Name = "chkByGender";
            this.chkByGender.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // colDivision
            // 
            this.colDivision.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            resources.ApplyResources(this.colDivision, "colDivision");
            this.colDivision.Name = "colDivision";
            this.colDivision.ReadOnly = true;
            // 
            // col性别
            // 
            resources.ApplyResources(this.col性别, "col性别");
            this.col性别.Name = "col性别";
            this.col性别.ReadOnly = true;
            // 
            // col总人数
            // 
            resources.ApplyResources(this.col总人数, "col总人数");
            this.col总人数.Name = "col总人数";
            this.col总人数.ReadOnly = true;
            this.col总人数.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col总人数.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // col未完成人数
            // 
            resources.ApplyResources(this.col未完成人数, "col未完成人数");
            this.col未完成人数.Name = "col未完成人数";
            this.col未完成人数.ReadOnly = true;
            this.col未完成人数.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col未完成人数.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // col未测试人数
            // 
            resources.ApplyResources(this.col未测试人数, "col未测试人数");
            this.col未测试人数.Name = "col未测试人数";
            this.col未测试人数.ReadOnly = true;
            this.col未测试人数.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col未测试人数.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // col完成人数
            // 
            resources.ApplyResources(this.col完成人数, "col完成人数");
            this.col完成人数.Name = "col完成人数";
            this.col完成人数.ReadOnly = true;
            this.col完成人数.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col完成人数.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colAverage
            // 
            dataGridViewCellStyle1.Format = "N2";
            this.colAverage.DefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(this.colAverage, "colAverage");
            this.colAverage.Name = "colAverage";
            this.colAverage.ReadOnly = true;
            // 
            // col平均分等级
            // 
            resources.ApplyResources(this.col平均分等级, "col平均分等级");
            this.col平均分等级.Name = "col平均分等级";
            this.col平均分等级.ReadOnly = true;
            // 
            // col标准差
            // 
            dataGridViewCellStyle2.Format = "N3";
            this.col标准差.DefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(this.col标准差, "col标准差");
            this.col标准差.Name = "col标准差";
            this.col标准差.ReadOnly = true;
            // 
            // colManFen
            // 
            resources.ApplyResources(this.colManFen, "colManFen");
            this.colManFen.Name = "colManFen";
            this.colManFen.ReadOnly = true;
            this.colManFen.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colManFen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colManFenRate
            // 
            dataGridViewCellStyle3.Format = "P2";
            this.colManFenRate.DefaultCellStyle = dataGridViewCellStyle3;
            resources.ApplyResources(this.colManFenRate, "colManFenRate");
            this.colManFenRate.Name = "colManFenRate";
            this.colManFenRate.ReadOnly = true;
            // 
            // col优良人数
            // 
            resources.ApplyResources(this.col优良人数, "col优良人数");
            this.col优良人数.Name = "col优良人数";
            this.col优良人数.ReadOnly = true;
            this.col优良人数.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // col优良率
            // 
            dataGridViewCellStyle4.Format = "P2";
            this.col优良率.DefaultCellStyle = dataGridViewCellStyle4;
            resources.ApplyResources(this.col优良率, "col优良率");
            this.col优良率.Name = "col优良率";
            this.col优良率.ReadOnly = true;
            this.col优良率.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // col合格人数
            // 
            resources.ApplyResources(this.col合格人数, "col合格人数");
            this.col合格人数.Name = "col合格人数";
            this.col合格人数.ReadOnly = true;
            this.col合格人数.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // col合格率
            // 
            dataGridViewCellStyle5.Format = "P2";
            this.col合格率.DefaultCellStyle = dataGridViewCellStyle5;
            resources.ApplyResources(this.col合格率, "col合格率");
            this.col合格率.Name = "col合格率";
            this.col合格率.ReadOnly = true;
            // 
            // colYuxiu
            // 
            resources.ApplyResources(this.colYuxiu, "colYuxiu");
            this.colYuxiu.Name = "colYuxiu";
            this.colYuxiu.ReadOnly = true;
            this.colYuxiu.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colYuxiu.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colYuxiuRate
            // 
            dataGridViewCellStyle6.Format = "P2";
            this.colYuxiuRate.DefaultCellStyle = dataGridViewCellStyle6;
            resources.ApplyResources(this.colYuxiuRate, "colYuxiuRate");
            this.colYuxiuRate.Name = "colYuxiuRate";
            this.colYuxiuRate.ReadOnly = true;
            // 
            // colLianghao
            // 
            resources.ApplyResources(this.colLianghao, "colLianghao");
            this.colLianghao.Name = "colLianghao";
            this.colLianghao.ReadOnly = true;
            this.colLianghao.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colLianghao.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colLianghaoRate
            // 
            dataGridViewCellStyle7.Format = "P2";
            this.colLianghaoRate.DefaultCellStyle = dataGridViewCellStyle7;
            resources.ApplyResources(this.colLianghaoRate, "colLianghaoRate");
            this.colLianghaoRate.Name = "colLianghaoRate";
            this.colLianghaoRate.ReadOnly = true;
            // 
            // col中等人数
            // 
            resources.ApplyResources(this.col中等人数, "col中等人数");
            this.col中等人数.Name = "col中等人数";
            this.col中等人数.ReadOnly = true;
            this.col中等人数.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // col中等率
            // 
            dataGridViewCellStyle8.Format = "P2";
            this.col中等率.DefaultCellStyle = dataGridViewCellStyle8;
            resources.ApplyResources(this.col中等率, "col中等率");
            this.col中等率.Name = "col中等率";
            this.col中等率.ReadOnly = true;
            // 
            // colJige
            // 
            resources.ApplyResources(this.colJige, "colJige");
            this.colJige.Name = "colJige";
            this.colJige.ReadOnly = true;
            this.colJige.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colJige.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colJigeRate
            // 
            dataGridViewCellStyle9.Format = "P2";
            this.colJigeRate.DefaultCellStyle = dataGridViewCellStyle9;
            resources.ApplyResources(this.colJigeRate, "colJigeRate");
            this.colJigeRate.Name = "colJigeRate";
            this.colJigeRate.ReadOnly = true;
            // 
            // colBujige
            // 
            resources.ApplyResources(this.colBujige, "colBujige");
            this.colBujige.Name = "colBujige";
            this.colBujige.ReadOnly = true;
            this.colBujige.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colBujige.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colBujigeRate
            // 
            dataGridViewCellStyle10.Format = "P2";
            this.colBujigeRate.DefaultCellStyle = dataGridViewCellStyle10;
            resources.ApplyResources(this.colBujigeRate, "colBujigeRate");
            this.colBujigeRate.Name = "colBujigeRate";
            this.colBujigeRate.ReadOnly = true;
            // 
            // FrmStatisticsTotal
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chkByDivision);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.chkByGender);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dt结束训练日期);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dt开始训练日期);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProject);
            this.Controls.Add(this.ucStudentSearch1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbDivision);
            this.Name = "FrmStatisticsTotal";
            this.Controls.SetChildIndex(this.btnSearch, 0);
            this.Controls.SetChildIndex(this.btnSaveAs, 0);
            this.Controls.SetChildIndex(this.cmbDivision, 0);
            this.Controls.SetChildIndex(this.btnColumn, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.ucStudentSearch1, 0);
            this.Controls.SetChildIndex(this.txtProject, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.dt开始训练日期, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.dt结束训练日期, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.chkByGender, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.chkByDivision, 0);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ucStudentSearch1.ResumeLayout(false);
            this.ucStudentSearch1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dt结束训练日期;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dt开始训练日期;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CommonUI.Controls.PhysicalProjectComboBox txtProject;
        private CommonUI.Controls.UCStudentSearch ucStudentSearch1;
        private LJH.GeneralLibrary.WinformControl.DBCTextBox txtStudentID1;
        private LJH.GeneralLibrary.WinformControl.DBCTextBox txtName;
        private CommonUI.Controls.DivisionComboBox cmbDivision;
        private System.Windows.Forms.CheckBox chkByDivision;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chkByGender;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDivision;
        private System.Windows.Forms.DataGridViewTextBoxColumn col性别;
        private System.Windows.Forms.DataGridViewLinkColumn col总人数;
        private System.Windows.Forms.DataGridViewLinkColumn col未完成人数;
        private System.Windows.Forms.DataGridViewLinkColumn col未测试人数;
        private System.Windows.Forms.DataGridViewLinkColumn col完成人数;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAverage;
        private System.Windows.Forms.DataGridViewTextBoxColumn col平均分等级;
        private System.Windows.Forms.DataGridViewTextBoxColumn col标准差;
        private System.Windows.Forms.DataGridViewLinkColumn colManFen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colManFenRate;
        private System.Windows.Forms.DataGridViewLinkColumn col优良人数;
        private System.Windows.Forms.DataGridViewTextBoxColumn col优良率;
        private System.Windows.Forms.DataGridViewLinkColumn col合格人数;
        private System.Windows.Forms.DataGridViewTextBoxColumn col合格率;
        private System.Windows.Forms.DataGridViewLinkColumn colYuxiu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colYuxiuRate;
        private System.Windows.Forms.DataGridViewLinkColumn colLianghao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLianghaoRate;
        private System.Windows.Forms.DataGridViewLinkColumn col中等人数;
        private System.Windows.Forms.DataGridViewTextBoxColumn col中等率;
        private System.Windows.Forms.DataGridViewLinkColumn colJige;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJigeRate;
        private System.Windows.Forms.DataGridViewLinkColumn colBujige;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBujigeRate;
    }
}