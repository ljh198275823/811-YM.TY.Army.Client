namespace HH.ZK.UI
{
    partial class Frm考场视频
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm考场视频));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStudentID1 = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.btn查询所有视频 = new System.Windows.Forms.Button();
            this.chk考试日期 = new System.Windows.Forms.CheckBox();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnu请求上传视频 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblVideoUrl = new System.Windows.Forms.Label();
            this.lblVideoPath = new System.Windows.Forms.Label();
            this.lnkVideoUrl = new System.Windows.Forms.LinkLabel();
            this.lnkVideoPath = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.txt考点 = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.lnk同步录像本地数据 = new System.Windows.Forms.LinkLabel();
            this.txt同步录像本地数据 = new System.Windows.Forms.Label();
            this.cmbPhysicalItem = new HH.ZK.CommonUI.Controls.PhysicalItemComboBox(this.components);
            this.col考点 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFileSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhysicalItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCameraLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col测试时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLocalPath = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colFill = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.label1.Location = new System.Drawing.Point(15, 23);
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
            this.txtStudentID1.Location = new System.Drawing.Point(72, 16);
            this.txtStudentID1.Name = "txtStudentID1";
            this.txtStudentID1.Size = new System.Drawing.Size(256, 26);
            this.txtStudentID1.TabIndex = 142;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(370, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 154;
            this.label10.Text = "考试科目";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn查询所有视频
            // 
            this.btn查询所有视频.Location = new System.Drawing.Point(650, 10);
            this.btn查询所有视频.Name = "btn查询所有视频";
            this.btn查询所有视频.Size = new System.Drawing.Size(166, 75);
            this.btn查询所有视频.TabIndex = 156;
            this.btn查询所有视频.Text = "查  询(&Q)";
            this.btn查询所有视频.UseVisualStyleBackColor = true;
            this.btn查询所有视频.Click += new System.EventHandler(this.btn查询所有视频_Click);
            // 
            // chk考试日期
            // 
            this.chk考试日期.AutoSize = true;
            this.chk考试日期.Location = new System.Drawing.Point(349, 21);
            this.chk考试日期.Name = "chk考试日期";
            this.chk考试日期.Size = new System.Drawing.Size(72, 16);
            this.chk考试日期.TabIndex = 158;
            this.chk考试日期.Text = "测试时间";
            this.chk考试日期.UseVisualStyleBackColor = true;
            this.chk考试日期.CheckedChanged += new System.EventHandler(this.chk考试日期_CheckedChanged);
            // 
            // dtDate
            // 
            this.dtDate.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtDate.Location = new System.Drawing.Point(427, 16);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(190, 26);
            this.dtDate.TabIndex = 159;
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
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col考点,
            this.colStudentID,
            this.colFile,
            this.colFileSize,
            this.colPhysicalItem,
            this.colCameraLocation,
            this.col测试时间,
            this.colState,
            this.colPlay,
            this.colLocalPath,
            this.colFill});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(0, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("宋体", 10.5F);
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1324, 449);
            this.dataGridView1.TabIndex = 160;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu请求上传视频});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(149, 26);
            // 
            // mnu请求上传视频
            // 
            this.mnu请求上传视频.Name = "mnu请求上传视频";
            this.mnu请求上传视频.Size = new System.Drawing.Size(148, 22);
            this.mnu请求上传视频.Text = "请求上传视频";
            this.mnu请求上传视频.Click += new System.EventHandler(this.mnu请求上传视频_Click);
            // 
            // lblVideoUrl
            // 
            this.lblVideoUrl.AutoSize = true;
            this.lblVideoUrl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblVideoUrl.Location = new System.Drawing.Point(960, 14);
            this.lblVideoUrl.Name = "lblVideoUrl";
            this.lblVideoUrl.Size = new System.Drawing.Size(47, 12);
            this.lblVideoUrl.TabIndex = 162;
            this.lblVideoUrl.Text = "http://";
            this.lblVideoUrl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblVideoPath
            // 
            this.lblVideoPath.AutoSize = true;
            this.lblVideoPath.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblVideoPath.Location = new System.Drawing.Point(960, 67);
            this.lblVideoPath.Name = "lblVideoPath";
            this.lblVideoPath.Size = new System.Drawing.Size(17, 12);
            this.lblVideoPath.TabIndex = 163;
            this.lblVideoPath.Text = "E:";
            this.lblVideoPath.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lnkVideoUrl
            // 
            this.lnkVideoUrl.AutoSize = true;
            this.lnkVideoUrl.Enabled = false;
            this.lnkVideoUrl.Location = new System.Drawing.Point(841, 15);
            this.lnkVideoUrl.Name = "lnkVideoUrl";
            this.lnkVideoUrl.Size = new System.Drawing.Size(113, 12);
            this.lnkVideoUrl.TabIndex = 165;
            this.lnkVideoUrl.TabStop = true;
            this.lnkVideoUrl.Text = "同步录像机服务器：";
            this.lnkVideoUrl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkVideoUrl_LinkClicked);
            // 
            // lnkVideoPath
            // 
            this.lnkVideoPath.AutoSize = true;
            this.lnkVideoPath.Location = new System.Drawing.Point(841, 67);
            this.lnkVideoPath.Name = "lnkVideoPath";
            this.lnkVideoPath.Size = new System.Drawing.Size(113, 12);
            this.lnkVideoPath.TabIndex = 166;
            this.lnkVideoPath.TabStop = true;
            this.lnkVideoPath.Text = "同步录像本地视频：";
            this.lnkVideoPath.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkVideoPath_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(37, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 167;
            this.label2.Text = "考点";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt考点
            // 
            this.txt考点.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt考点.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txt考点.Location = new System.Drawing.Point(72, 56);
            this.txt考点.Name = "txt考点";
            this.txt考点.Size = new System.Drawing.Size(256, 26);
            this.txt考点.TabIndex = 168;
            // 
            // lnk同步录像本地数据
            // 
            this.lnk同步录像本地数据.AutoSize = true;
            this.lnk同步录像本地数据.Location = new System.Drawing.Point(841, 41);
            this.lnk同步录像本地数据.Name = "lnk同步录像本地数据";
            this.lnk同步录像本地数据.Size = new System.Drawing.Size(113, 12);
            this.lnk同步录像本地数据.TabIndex = 170;
            this.lnk同步录像本地数据.TabStop = true;
            this.lnk同步录像本地数据.Text = "同步录像本地数据：";
            this.lnk同步录像本地数据.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk同步录像本地数据_LinkClicked);
            // 
            // txt同步录像本地数据
            // 
            this.txt同步录像本地数据.AutoSize = true;
            this.txt同步录像本地数据.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt同步录像本地数据.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt同步录像本地数据.Location = new System.Drawing.Point(960, 41);
            this.txt同步录像本地数据.Name = "txt同步录像本地数据";
            this.txt同步录像本地数据.Size = new System.Drawing.Size(19, 14);
            this.txt同步录像本地数据.TabIndex = 169;
            this.txt同步录像本地数据.Text = "E:";
            this.txt同步录像本地数据.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.txt同步录像本地数据.DoubleClick += new System.EventHandler(this.txt同步录像本地数据_DoubleClick);
            // 
            // cmbPhysicalItem
            // 
            this.cmbPhysicalItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPhysicalItem.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbPhysicalItem.FormattingEnabled = true;
            this.cmbPhysicalItem.Location = new System.Drawing.Point(427, 57);
            this.cmbPhysicalItem.Name = "cmbPhysicalItem";
            this.cmbPhysicalItem.Size = new System.Drawing.Size(190, 24);
            this.cmbPhysicalItem.TabIndex = 161;
            // 
            // col考点
            // 
            this.col考点.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.col考点.HeaderText = "考点";
            this.col考点.Name = "col考点";
            this.col考点.ReadOnly = true;
            this.col考点.Width = 51;
            // 
            // colStudentID
            // 
            this.colStudentID.HeaderText = "准考证号";
            this.colStudentID.Name = "colStudentID";
            this.colStudentID.ReadOnly = true;
            this.colStudentID.Visible = false;
            this.colStudentID.Width = 150;
            // 
            // colFile
            // 
            this.colFile.HeaderText = "视频文件名称";
            this.colFile.Name = "colFile";
            this.colFile.ReadOnly = true;
            this.colFile.Width = 300;
            // 
            // colFileSize
            // 
            this.colFileSize.HeaderText = "文件大小";
            this.colFileSize.Name = "colFileSize";
            this.colFileSize.ReadOnly = true;
            // 
            // colPhysicalItem
            // 
            this.colPhysicalItem.HeaderText = "测试项目";
            this.colPhysicalItem.Name = "colPhysicalItem";
            this.colPhysicalItem.ReadOnly = true;
            this.colPhysicalItem.Width = 120;
            // 
            // colCameraLocation
            // 
            this.colCameraLocation.HeaderText = "相机位置";
            this.colCameraLocation.Name = "colCameraLocation";
            this.colCameraLocation.ReadOnly = true;
            // 
            // col测试时间
            // 
            this.col测试时间.HeaderText = "录像时间";
            this.col测试时间.Name = "col测试时间";
            this.col测试时间.ReadOnly = true;
            this.col测试时间.Width = 180;
            // 
            // colState
            // 
            this.colState.HeaderText = "上传状态";
            this.colState.Name = "colState";
            this.colState.ReadOnly = true;
            this.colState.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colState.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colPlay
            // 
            this.colPlay.HeaderText = "播放";
            this.colPlay.Name = "colPlay";
            this.colPlay.ReadOnly = true;
            this.colPlay.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colPlay.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colPlay.Width = 80;
            // 
            // colLocalPath
            // 
            this.colLocalPath.HeaderText = "本地路径";
            this.colLocalPath.Name = "colLocalPath";
            this.colLocalPath.ReadOnly = true;
            this.colLocalPath.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colLocalPath.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colLocalPath.Width = 150;
            // 
            // colFill
            // 
            this.colFill.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colFill.HeaderText = "";
            this.colFill.Name = "colFill";
            this.colFill.ReadOnly = true;
            // 
            // Frm考场视频
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 566);
            this.Controls.Add(this.lnk同步录像本地数据);
            this.Controls.Add(this.txt同步录像本地数据);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt考点);
            this.Controls.Add(this.lnkVideoPath);
            this.Controls.Add(this.lnkVideoUrl);
            this.Controls.Add(this.lblVideoPath);
            this.Controls.Add(this.lblVideoUrl);
            this.Controls.Add(this.cmbPhysicalItem);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dtDate);
            this.Controls.Add(this.chk考试日期);
            this.Controls.Add(this.btn查询所有视频);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStudentID1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm考场视频";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "考场视频";
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
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn查询所有视频;
        private System.Windows.Forms.CheckBox chk考试日期;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnu请求上传视频;
        private CommonUI.Controls.PhysicalItemComboBox cmbPhysicalItem;
        private System.Windows.Forms.Label lblVideoUrl;
        private System.Windows.Forms.Label lblVideoPath;
        private System.Windows.Forms.LinkLabel lnkVideoUrl;
        private System.Windows.Forms.LinkLabel lnkVideoPath;
        private System.Windows.Forms.Label label2;
        private LJH.GeneralLibrary.WinformControl.DBCTextBox txt考点;
        private System.Windows.Forms.LinkLabel lnk同步录像本地数据;
        private System.Windows.Forms.Label txt同步录像本地数据;
        private System.Windows.Forms.DataGridViewTextBoxColumn col考点;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFileSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhysicalItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCameraLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn col测试时间;
        private System.Windows.Forms.DataGridViewTextBoxColumn colState;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlay;
        private System.Windows.Forms.DataGridViewLinkColumn colLocalPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFill;
    }
}