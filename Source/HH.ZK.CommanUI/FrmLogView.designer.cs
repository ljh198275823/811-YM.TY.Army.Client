namespace HH.ZK.CommonUI
{
    partial class FrmLogView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogView));
            this.ucDateTimeInterval1 = new LJH.GeneralLibrary.WinformControl.UCDateTimeInterval();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colAlarmDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOperator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAlarmDescr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnColumn
            // 
            this.btnColumn.Location = new System.Drawing.Point(584, 12);
            this.btnColumn.Size = new System.Drawing.Size(110, 71);
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.Location = new System.Drawing.Point(439, 12);
            this.btnSaveAs.Size = new System.Drawing.Size(110, 71);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(294, 12);
            this.btnSearch.Size = new System.Drawing.Size(110, 71);
            // 
            // ucDateTimeInterval1
            // 
            this.ucDateTimeInterval1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucDateTimeInterval1.EndDateTime = new System.DateTime(2014, 12, 22, 23, 59, 59, 0);
            this.ucDateTimeInterval1.Location = new System.Drawing.Point(9, 9);
            this.ucDateTimeInterval1.Name = "ucDateTimeInterval1";
            this.ucDateTimeInterval1.ShowTime = false;
            this.ucDateTimeInterval1.Size = new System.Drawing.Size(221, 74);
            this.ucDateTimeInterval1.StartDateTime = new System.DateTime(2014, 12, 22, 0, 0, 0, 0);
            this.ucDateTimeInterval1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAlarmDateTime,
            this.colOperator,
            this.colAlarmDescr});
            this.dataGridView1.Location = new System.Drawing.Point(0, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1152, 504);
            this.dataGridView1.TabIndex = 19;
            // 
            // colAlarmDateTime
            // 
            dataGridViewCellStyle1.Format = "yyyy-MM-dd HH:mm:ss";
            this.colAlarmDateTime.DefaultCellStyle = dataGridViewCellStyle1;
            this.colAlarmDateTime.HeaderText = "日期";
            this.colAlarmDateTime.Name = "colAlarmDateTime";
            this.colAlarmDateTime.ReadOnly = true;
            this.colAlarmDateTime.Width = 130;
            // 
            // colOperator
            // 
            this.colOperator.HeaderText = "操作员";
            this.colOperator.Name = "colOperator";
            this.colOperator.ReadOnly = true;
            // 
            // colAlarmDescr
            // 
            this.colAlarmDescr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAlarmDescr.HeaderText = "内容";
            this.colAlarmDescr.MinimumWidth = 600;
            this.colAlarmDescr.Name = "colAlarmDescr";
            this.colAlarmDescr.ReadOnly = true;
            // 
            // FrmLogView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 624);
            this.Controls.Add(this.ucDateTimeInterval1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLogView";
            this.Text = "系统日志查询";
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.btnSearch, 0);
            this.Controls.SetChildIndex(this.btnSaveAs, 0);
            this.Controls.SetChildIndex(this.btnColumn, 0);
            this.Controls.SetChildIndex(this.ucDateTimeInterval1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private LJH.GeneralLibrary.WinformControl.UCDateTimeInterval ucDateTimeInterval1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAlarmDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOperator;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAlarmDescr;
    }
}