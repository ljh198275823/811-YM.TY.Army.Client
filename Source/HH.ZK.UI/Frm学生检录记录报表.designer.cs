namespace HH.ZK.UI
{
    partial class Frm学生检录记录报表
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnu取消检录 = new System.Windows.Forms.ToolStripMenuItem();
            this.ucDateTimeInterval1 = new LJH.GeneralLibrary.WinformControl.UCDateTimeInterval();
            this.ucStudentSearch1 = new HH.ZK.CommonUI.Controls.UCStudentSearch();
            this.colCheckTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFacility = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGroupID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChannel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOperator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnColumn
            // 
            this.btnColumn.Location = new System.Drawing.Point(1120, 21);
            this.btnColumn.Size = new System.Drawing.Size(111, 55);
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.Location = new System.Drawing.Point(981, 21);
            this.btnSaveAs.Size = new System.Drawing.Size(111, 55);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(829, 21);
            this.btnSearch.Size = new System.Drawing.Size(111, 55);
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
            this.colCheckTime,
            this.colFacility,
            this.colStudentID,
            this.colName,
            this.colSex,
            this.colGroupID,
            this.colChannel,
            this.colResult,
            this.colOperator,
            this.colFill});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(0, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1269, 386);
            this.dataGridView1.TabIndex = 20;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu取消检录});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(149, 26);
            // 
            // mnu取消检录
            // 
            this.mnu取消检录.Name = "mnu取消检录";
            this.mnu取消检录.Size = new System.Drawing.Size(148, 22);
            this.mnu取消检录.Text = "删除所选记录";
            this.mnu取消检录.Click += new System.EventHandler(this.mnu取消检录_Click);
            // 
            // ucDateTimeInterval1
            // 
            this.ucDateTimeInterval1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucDateTimeInterval1.EndDateTime = new System.DateTime(2014, 12, 22, 10, 49, 55, 545);
            this.ucDateTimeInterval1.Location = new System.Drawing.Point(12, 8);
            this.ucDateTimeInterval1.Name = "ucDateTimeInterval1";
            this.ucDateTimeInterval1.ShowTime = true;
            this.ucDateTimeInterval1.Size = new System.Drawing.Size(221, 87);
            this.ucDateTimeInterval1.StartDateTime = new System.DateTime(2014, 12, 22, 10, 49, 55, 591);
            this.ucDateTimeInterval1.TabIndex = 21;
            // 
            // ucStudentSearch1
            // 
            this.ucStudentSearch1.Location = new System.Drawing.Point(242, -1);
            this.ucStudentSearch1.Name = "ucStudentSearch1";
            this.ucStudentSearch1.Size = new System.Drawing.Size(562, 96);
            this.ucStudentSearch1.TabIndex = 22;
            // 
            // colCheckTime
            // 
            dataGridViewCellStyle1.Format = "yyyy-MM-dd HH:mm:ss";
            this.colCheckTime.DefaultCellStyle = dataGridViewCellStyle1;
            this.colCheckTime.HeaderText = "检录时间";
            this.colCheckTime.Name = "colCheckTime";
            this.colCheckTime.ReadOnly = true;
            this.colCheckTime.Width = 150;
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
            // colStudentID
            // 
            this.colStudentID.HeaderText = "准考证号";
            this.colStudentID.Name = "colStudentID";
            this.colStudentID.ReadOnly = true;
            this.colStudentID.Width = 150;
            // 
            // colName
            // 
            this.colName.HeaderText = "姓名";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Width = 80;
            // 
            // colSex
            // 
            this.colSex.HeaderText = "性别";
            this.colSex.Name = "colSex";
            this.colSex.ReadOnly = true;
            this.colSex.Width = 60;
            // 
            // colGroupID
            // 
            this.colGroupID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colGroupID.HeaderText = "组别";
            this.colGroupID.MinimumWidth = 120;
            this.colGroupID.Name = "colGroupID";
            this.colGroupID.ReadOnly = true;
            this.colGroupID.Width = 120;
            // 
            // colChannel
            // 
            this.colChannel.HeaderText = "道次";
            this.colChannel.Name = "colChannel";
            this.colChannel.ReadOnly = true;
            this.colChannel.Width = 60;
            // 
            // colResult
            // 
            this.colResult.HeaderText = "检录结果";
            this.colResult.Name = "colResult";
            this.colResult.ReadOnly = true;
            // 
            // colOperator
            // 
            this.colOperator.HeaderText = "操作员";
            this.colOperator.Name = "colOperator";
            this.colOperator.ReadOnly = true;
            this.colOperator.Width = 80;
            // 
            // colFill
            // 
            this.colFill.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colFill.HeaderText = "";
            this.colFill.Name = "colFill";
            this.colFill.ReadOnly = true;
            // 
            // Frm学生检录记录报表
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 518);
            this.Controls.Add(this.ucStudentSearch1);
            this.Controls.Add(this.ucDateTimeInterval1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Frm学生检录记录报表";
            this.Text = "学生检录记录报表";
            this.Controls.SetChildIndex(this.btnSearch, 0);
            this.Controls.SetChildIndex(this.btnSaveAs, 0);
            this.Controls.SetChildIndex(this.btnColumn, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.ucDateTimeInterval1, 0);
            this.Controls.SetChildIndex(this.ucStudentSearch1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private LJH.GeneralLibrary.WinformControl.UCDateTimeInterval ucDateTimeInterval1;
        private CommonUI.Controls.UCStudentSearch ucStudentSearch1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnu取消检录;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCheckTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFacility;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGroupID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChannel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOperator;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFill;
    }
}