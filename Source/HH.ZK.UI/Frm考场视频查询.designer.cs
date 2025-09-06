namespace HH.ZK.UI
{
    partial class Frm考场视频查询
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm考场视频查询));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStudentID1 = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.btn查询所有视频 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblVideoPath = new System.Windows.Forms.Label();
            this.lnkVideoPath = new System.Windows.Forms.LinkLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnu播放视频 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu打开视频所在位置 = new System.Windows.Forms.ToolStripMenuItem();
            this.colPlay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLocalPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "player1.png");
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblCount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 544);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1324, 22);
            this.statusStrip1.TabIndex = 121;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblCount
            // 
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(1309, 17);
            this.lblCount.Spring = true;
            this.lblCount.Text = "总共 0 项";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(15, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 141;
            this.label1.Text = "准考证号";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtStudentID1
            // 
            this.txtStudentID1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtStudentID1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtStudentID1.Location = new System.Drawing.Point(72, 36);
            this.txtStudentID1.Name = "txtStudentID1";
            this.txtStudentID1.Size = new System.Drawing.Size(256, 26);
            this.txtStudentID1.TabIndex = 142;
            // 
            // btn查询所有视频
            // 
            this.btn查询所有视频.Location = new System.Drawing.Point(353, 12);
            this.btn查询所有视频.Name = "btn查询所有视频";
            this.btn查询所有视频.Size = new System.Drawing.Size(166, 75);
            this.btn查询所有视频.TabIndex = 156;
            this.btn查询所有视频.Text = "查  询(&Q)";
            this.btn查询所有视频.UseVisualStyleBackColor = true;
            this.btn查询所有视频.Click += new System.EventHandler(this.btn查询所有视频_Click);
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
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPlay,
            this.colLocalPath});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(0, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1324, 449);
            this.dataGridView1.TabIndex = 160;
            // 
            // lblVideoPath
            // 
            this.lblVideoPath.AutoSize = true;
            this.lblVideoPath.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblVideoPath.Location = new System.Drawing.Point(668, 66);
            this.lblVideoPath.Name = "lblVideoPath";
            this.lblVideoPath.Size = new System.Drawing.Size(17, 12);
            this.lblVideoPath.TabIndex = 163;
            this.lblVideoPath.Text = "E:";
            this.lblVideoPath.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lnkVideoPath
            // 
            this.lnkVideoPath.AutoSize = true;
            this.lnkVideoPath.Location = new System.Drawing.Point(549, 66);
            this.lnkVideoPath.Name = "lnkVideoPath";
            this.lnkVideoPath.Size = new System.Drawing.Size(113, 12);
            this.lnkVideoPath.TabIndex = 166;
            this.lnkVideoPath.TabStop = true;
            this.lnkVideoPath.Text = "视频文件查找路径：";
            this.lnkVideoPath.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkVideoPath_LinkClicked);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu播放视频,
            this.mnu打开视频所在位置});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(173, 48);
            // 
            // mnu播放视频
            // 
            this.mnu播放视频.Name = "mnu播放视频";
            this.mnu播放视频.Size = new System.Drawing.Size(172, 22);
            this.mnu播放视频.Text = "播放视频";
            this.mnu播放视频.Click += new System.EventHandler(this.mnu播放视频_Click);
            // 
            // mnu打开视频所在位置
            // 
            this.mnu打开视频所在位置.Name = "mnu打开视频所在位置";
            this.mnu打开视频所在位置.Size = new System.Drawing.Size(172, 22);
            this.mnu打开视频所在位置.Text = "打开视频所在位置";
            this.mnu打开视频所在位置.Click += new System.EventHandler(this.mnu打开视频所在位置_Click);
            // 
            // colPlay
            // 
            this.colPlay.HeaderText = "播放";
            this.colPlay.Name = "colPlay";
            this.colPlay.ReadOnly = true;
            this.colPlay.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colPlay.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colPlay.Visible = false;
            // 
            // colLocalPath
            // 
            this.colLocalPath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colLocalPath.HeaderText = "本地路径";
            this.colLocalPath.Name = "colLocalPath";
            this.colLocalPath.ReadOnly = true;
            this.colLocalPath.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Frm考场视频查询
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 566);
            this.Controls.Add(this.lnkVideoPath);
            this.Controls.Add(this.lblVideoPath);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn查询所有视频);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStudentID1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm考场视频查询";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "考场视频查询";
            this.Load += new System.EventHandler(this.Frm考场视频_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblCount;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
        private LJH.GeneralLibrary.WinformControl.DBCTextBox txtStudentID1;
        private System.Windows.Forms.Button btn查询所有视频;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblVideoPath;
        private System.Windows.Forms.LinkLabel lnkVideoPath;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnu播放视频;
        private System.Windows.Forms.ToolStripMenuItem mnu打开视频所在位置;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLocalPath;
    }
}