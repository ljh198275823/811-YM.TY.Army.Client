namespace HH.ZK.UI
{
    partial class Frm考场实时状态
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm考场实时状态));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.col考点 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col总人数 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col已考人数 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col已检录人数 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col缺免考数 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col今日已考试人数 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col今日已检录数 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col完成进度 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col检录进度 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pnlView = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.dataGridView1);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1168, 362);
            this.pnlTop.TabIndex = 155;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col考点,
            this.col总人数,
            this.col已考人数,
            this.col已检录人数,
            this.col缺免考数,
            this.col今日已考试人数,
            this.col今日已检录数,
            this.col完成进度,
            this.col检录进度,
            this.colFill});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1168, 362);
            this.dataGridView1.TabIndex = 155;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentView_CellDoubleClick);
            // 
            // col考点
            // 
            this.col考点.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col考点.HeaderText = "考点";
            this.col考点.MinimumWidth = 200;
            this.col考点.Name = "col考点";
            this.col考点.ReadOnly = true;
            this.col考点.Width = 200;
            // 
            // col总人数
            // 
            this.col总人数.HeaderText = "总人数";
            this.col总人数.Name = "col总人数";
            this.col总人数.ReadOnly = true;
            // 
            // col已考人数
            // 
            this.col已考人数.HeaderText = "已考人数";
            this.col已考人数.Name = "col已考人数";
            this.col已考人数.ReadOnly = true;
            // 
            // col已检录人数
            // 
            this.col已检录人数.HeaderText = "已检录数";
            this.col已检录人数.Name = "col已检录人数";
            this.col已检录人数.ReadOnly = true;
            // 
            // col缺免考数
            // 
            this.col缺免考数.HeaderText = "缺免考数";
            this.col缺免考数.Name = "col缺免考数";
            this.col缺免考数.ReadOnly = true;
            // 
            // col今日已考试人数
            // 
            this.col今日已考试人数.HeaderText = "今日已考";
            this.col今日已考试人数.Name = "col今日已考试人数";
            this.col今日已考试人数.ReadOnly = true;
            // 
            // col今日已检录数
            // 
            this.col今日已检录数.HeaderText = "今日已检录";
            this.col今日已检录数.Name = "col今日已检录数";
            this.col今日已检录数.ReadOnly = true;
            // 
            // col完成进度
            // 
            this.col完成进度.HeaderText = "完成进度";
            this.col完成进度.Name = "col完成进度";
            this.col完成进度.ReadOnly = true;
            // 
            // col检录进度
            // 
            this.col检录进度.HeaderText = "检录进度";
            this.col检录进度.Name = "col检录进度";
            this.col检录进度.ReadOnly = true;
            // 
            // colFill
            // 
            this.colFill.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colFill.HeaderText = "";
            this.colFill.Name = "colFill";
            this.colFill.ReadOnly = true;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 362);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1168, 6);
            this.splitter1.TabIndex = 156;
            this.splitter1.TabStop = false;
            // 
            // pnlView
            // 
            this.pnlView.BackColor = System.Drawing.Color.White;
            this.pnlView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlView.Location = new System.Drawing.Point(0, 368);
            this.pnlView.Name = "pnlView";
            this.pnlView.Size = new System.Drawing.Size(1168, 301);
            this.pnlView.TabIndex = 158;
            // 
            // Frm考场实时状态
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 691);
            this.Controls.Add(this.pnlView);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.pnlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm考场实时状态";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "考场实时状态";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm考场实时状态_FormClosed);
            this.Load += new System.EventHandler(this.Frm考场实时状态_Load);
            this.Controls.SetChildIndex(this.pnlTop, 0);
            this.Controls.SetChildIndex(this.splitter1, 0);
            this.Controls.SetChildIndex(this.pnlView, 0);
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.FlowLayoutPanel pnlView;
        private System.Windows.Forms.DataGridViewTextBoxColumn col考点;
        private System.Windows.Forms.DataGridViewTextBoxColumn col总人数;
        private System.Windows.Forms.DataGridViewTextBoxColumn col已考人数;
        private System.Windows.Forms.DataGridViewTextBoxColumn col已检录人数;
        private System.Windows.Forms.DataGridViewTextBoxColumn col缺免考数;
        private System.Windows.Forms.DataGridViewTextBoxColumn col今日已考试人数;
        private System.Windows.Forms.DataGridViewTextBoxColumn col今日已检录数;
        private System.Windows.Forms.DataGridViewTextBoxColumn col完成进度;
        private System.Windows.Forms.DataGridViewTextBoxColumn col检录进度;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFill;

    }
}