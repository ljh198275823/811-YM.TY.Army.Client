namespace HH.ZK.UI
{
    partial class Frm第三方平台成绩上传状态查询
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm第三方平台成绩上传状态查询));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colFacility = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col项目名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col项目编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col上传成绩 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col测试时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUploadTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col上传状态 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnu重新上传 = new System.Windows.Forms.ToolStripMenuItem();
            this.ucStudentSearch1 = new HH.ZK.CommonUI.Controls.UCStudentSearch();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbPhysicalItem = new HH.ZK.CommonUI.Controls.PhysicalItemComboBox(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.rd上传失败 = new System.Windows.Forms.RadioButton();
            this.rd成功上传 = new System.Windows.Forms.RadioButton();
            this.rd未上传 = new System.Windows.Forms.RadioButton();
            this.rdPhotoAll = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel5.SuspendLayout();
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFacility,
            this.colID,
            this.colName,
            this.colSex,
            this.col项目名称,
            this.col项目编号,
            this.col上传成绩,
            this.col测试时间,
            this.colUploadTime,
            this.col上传状态});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("宋体", 10.5F);
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            // 
            // colFacility
            // 
            this.colFacility.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            resources.ApplyResources(this.colFacility, "colFacility");
            this.colFacility.Name = "colFacility";
            this.colFacility.ReadOnly = true;
            // 
            // colID
            // 
            resources.ApplyResources(this.colID, "colID");
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            // 
            // colName
            // 
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
            // col项目名称
            // 
            resources.ApplyResources(this.col项目名称, "col项目名称");
            this.col项目名称.Name = "col项目名称";
            this.col项目名称.ReadOnly = true;
            // 
            // col项目编号
            // 
            resources.ApplyResources(this.col项目编号, "col项目编号");
            this.col项目编号.Name = "col项目编号";
            this.col项目编号.ReadOnly = true;
            // 
            // col上传成绩
            // 
            resources.ApplyResources(this.col上传成绩, "col上传成绩");
            this.col上传成绩.Name = "col上传成绩";
            this.col上传成绩.ReadOnly = true;
            // 
            // col测试时间
            // 
            resources.ApplyResources(this.col测试时间, "col测试时间");
            this.col测试时间.Name = "col测试时间";
            this.col测试时间.ReadOnly = true;
            // 
            // colUploadTime
            // 
            resources.ApplyResources(this.colUploadTime, "colUploadTime");
            this.colUploadTime.Name = "colUploadTime";
            this.colUploadTime.ReadOnly = true;
            // 
            // col上传状态
            // 
            this.col上传状态.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.col上传状态, "col上传状态");
            this.col上传状态.Name = "col上传状态";
            this.col上传状态.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu重新上传});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // mnu重新上传
            // 
            this.mnu重新上传.Name = "mnu重新上传";
            resources.ApplyResources(this.mnu重新上传, "mnu重新上传");
            this.mnu重新上传.Click += new System.EventHandler(this.mnu重新上传_Click);
            // 
            // ucStudentSearch1
            // 
            resources.ApplyResources(this.ucStudentSearch1, "ucStudentSearch1");
            this.ucStudentSearch1.Name = "ucStudentSearch1";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // cmbPhysicalItem
            // 
            this.cmbPhysicalItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPhysicalItem.FormattingEnabled = true;
            resources.ApplyResources(this.cmbPhysicalItem, "cmbPhysicalItem");
            this.cmbPhysicalItem.Name = "cmbPhysicalItem";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.rd上传失败);
            this.panel5.Controls.Add(this.rd成功上传);
            this.panel5.Controls.Add(this.rd未上传);
            this.panel5.Controls.Add(this.rdPhotoAll);
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.Name = "panel5";
            // 
            // rd上传失败
            // 
            resources.ApplyResources(this.rd上传失败, "rd上传失败");
            this.rd上传失败.ForeColor = System.Drawing.Color.Red;
            this.rd上传失败.Name = "rd上传失败";
            this.rd上传失败.UseVisualStyleBackColor = true;
            // 
            // rd成功上传
            // 
            resources.ApplyResources(this.rd成功上传, "rd成功上传");
            this.rd成功上传.ForeColor = System.Drawing.Color.Blue;
            this.rd成功上传.Name = "rd成功上传";
            this.rd成功上传.UseVisualStyleBackColor = true;
            // 
            // rd未上传
            // 
            resources.ApplyResources(this.rd未上传, "rd未上传");
            this.rd未上传.Name = "rd未上传";
            this.rd未上传.UseVisualStyleBackColor = true;
            // 
            // rdPhotoAll
            // 
            resources.ApplyResources(this.rdPhotoAll, "rdPhotoAll");
            this.rdPhotoAll.Checked = true;
            this.rdPhotoAll.Name = "rdPhotoAll";
            this.rdPhotoAll.TabStop = true;
            this.rdPhotoAll.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // Frm第三方平台成绩上传状态查询
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbPhysicalItem);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ucStudentSearch1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Frm第三方平台成绩上传状态查询";
            this.ShowInTaskbar = false;
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.btnSearch, 0);
            this.Controls.SetChildIndex(this.btnSaveAs, 0);
            this.Controls.SetChildIndex(this.btnColumn, 0);
            this.Controls.SetChildIndex(this.ucStudentSearch1, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.cmbPhysicalItem, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.panel5, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnu重新上传;
        private CommonUI.Controls.UCStudentSearch ucStudentSearch1;
        private System.Windows.Forms.Label label10;
        private HH.ZK.CommonUI.Controls.PhysicalItemComboBox cmbPhysicalItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFacility;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn col项目名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn col项目编号;
        private System.Windows.Forms.DataGridViewTextBoxColumn col上传成绩;
        private System.Windows.Forms.DataGridViewTextBoxColumn col测试时间;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUploadTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn col上传状态;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RadioButton rd上传失败;
        private System.Windows.Forms.RadioButton rd成功上传;
        private System.Windows.Forms.RadioButton rd未上传;
        private System.Windows.Forms.RadioButton rdPhotoAll;
        private System.Windows.Forms.Label label6;
    }
}