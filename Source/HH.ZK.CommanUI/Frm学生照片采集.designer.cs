namespace HH.ZK.CommonUI
{
    partial class Frm学生照片采集
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm学生照片采集));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnQuery = new System.Windows.Forms.Button();
            this.btnOpenCamera = new System.Windows.Forms.Button();
            this.chk使用另一个摄像头 = new System.Windows.Forms.CheckBox();
            this.videPlayer = new AForge.Controls.VideoSourcePlayer();
            this.btnWrite = new System.Windows.Forms.Button();
            this.lblClear = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ucStudentSearch1 = new HH.ZK.CommonUI.Controls.UCStudentSearch();
            this.panel6 = new System.Windows.Forms.Panel();
            this.rd有人脸特征 = new System.Windows.Forms.RadioButton();
            this.rd无人脸特征 = new System.Windows.Forms.RadioButton();
            this.rd人脸特征All = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.rdHasPhoto = new System.Windows.Forms.RadioButton();
            this.rdNonePhoto = new System.Windows.Forms.RadioButton();
            this.rdPhotoAll = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.colFacility = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col照片 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colFill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 616);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1501, 22);
            this.statusStrip1.TabIndex = 118;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(1486, 17);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = "总共 0 项";
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
            this.colFacility,
            this.colClassName,
            this.colID,
            this.colName,
            this.colSex,
            this.colGrade,
            this.col照片,
            this.colFill});
            this.dataGridView1.Location = new System.Drawing.Point(1, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("宋体", 10.5F);
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(846, 504);
            this.dataGridView1.TabIndex = 119;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.GridView_SelectionChanged);
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(791, 12);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(135, 77);
            this.btnQuery.TabIndex = 133;
            this.btnQuery.Text = "查询(&Q)";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // btnOpenCamera
            // 
            this.btnOpenCamera.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenCamera.Location = new System.Drawing.Point(987, 470);
            this.btnOpenCamera.Name = "btnOpenCamera";
            this.btnOpenCamera.Size = new System.Drawing.Size(82, 26);
            this.btnOpenCamera.TabIndex = 168;
            this.btnOpenCamera.Text = "打开摄像头";
            this.btnOpenCamera.UseVisualStyleBackColor = true;
            this.btnOpenCamera.Click += new System.EventHandler(this.btnOpenCamera_Click);
            // 
            // chk使用另一个摄像头
            // 
            this.chk使用另一个摄像头.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chk使用另一个摄像头.AutoSize = true;
            this.chk使用另一个摄像头.Location = new System.Drawing.Point(863, 476);
            this.chk使用另一个摄像头.Name = "chk使用另一个摄像头";
            this.chk使用另一个摄像头.Size = new System.Drawing.Size(120, 16);
            this.chk使用另一个摄像头.TabIndex = 167;
            this.chk使用另一个摄像头.Text = "使用另一个摄像头";
            this.chk使用另一个摄像头.UseVisualStyleBackColor = true;
            // 
            // videPlayer
            // 
            this.videPlayer.BackColor = System.Drawing.Color.White;
            this.videPlayer.Location = new System.Drawing.Point(1464, 96);
            this.videPlayer.Name = "videPlayer";
            this.videPlayer.Size = new System.Drawing.Size(22, 28);
            this.videPlayer.TabIndex = 166;
            this.videPlayer.Text = "videoSourcePlayer1";
            this.videPlayer.VideoSource = null;
            // 
            // btnWrite
            // 
            this.btnWrite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWrite.Enabled = false;
            this.btnWrite.Location = new System.Drawing.Point(855, 505);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(400, 62);
            this.btnWrite.TabIndex = 135;
            this.btnWrite.Text = "拍   照（&P)";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnSnapShot_Click);
            // 
            // lblClear
            // 
            this.lblClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClear.AutoSize = true;
            this.lblClear.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblClear.ForeColor = System.Drawing.Color.Red;
            this.lblClear.Location = new System.Drawing.Point(860, 585);
            this.lblClear.Name = "lblClear";
            this.lblClear.Size = new System.Drawing.Size(17, 16);
            this.lblClear.TabIndex = 177;
            this.lblClear.Text = "0";
            this.lblClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(1276, 505);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(210, 62);
            this.btnSave.TabIndex = 181;
            this.btnSave.Text = "保   存（&S)";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(860, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 16);
            this.label1.TabIndex = 183;
            this.label1.Text = "为提高识别率，请确保人脸部分几乎占满红框，示例照片请";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(1311, 112);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(41, 12);
            this.linkLabel1.TabIndex = 184;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "点这里";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(1276, 172);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(210, 280);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 180;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(855, 163);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 178;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(860, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 16);
            this.label2.TabIndex = 185;
            this.label2.Text = "在视频红框区按住鼠标可以拖动红框";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ucStudentSearch1
            // 
            this.ucStudentSearch1.Location = new System.Drawing.Point(5, 3);
            this.ucStudentSearch1.Name = "ucStudentSearch1";
            this.ucStudentSearch1.Size = new System.Drawing.Size(562, 100);
            this.ucStudentSearch1.TabIndex = 186;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.rd有人脸特征);
            this.panel6.Controls.Add(this.rd无人脸特征);
            this.panel6.Controls.Add(this.rd人脸特征All);
            this.panel6.Location = new System.Drawing.Point(635, 41);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(149, 24);
            this.panel6.TabIndex = 330;
            // 
            // rd有人脸特征
            // 
            this.rd有人脸特征.AutoSize = true;
            this.rd有人脸特征.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rd有人脸特征.Location = new System.Drawing.Point(61, 4);
            this.rd有人脸特征.Name = "rd有人脸特征";
            this.rd有人脸特征.Size = new System.Drawing.Size(35, 16);
            this.rd有人脸特征.TabIndex = 177;
            this.rd有人脸特征.Text = "有";
            this.rd有人脸特征.UseVisualStyleBackColor = true;
            // 
            // rd无人脸特征
            // 
            this.rd无人脸特征.AutoSize = true;
            this.rd无人脸特征.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rd无人脸特征.Location = new System.Drawing.Point(106, 4);
            this.rd无人脸特征.Name = "rd无人脸特征";
            this.rd无人脸特征.Size = new System.Drawing.Size(35, 16);
            this.rd无人脸特征.TabIndex = 179;
            this.rd无人脸特征.Text = "无";
            this.rd无人脸特征.UseVisualStyleBackColor = true;
            // 
            // rd人脸特征All
            // 
            this.rd人脸特征All.AutoSize = true;
            this.rd人脸特征All.Checked = true;
            this.rd人脸特征All.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rd人脸特征All.Location = new System.Drawing.Point(2, 4);
            this.rd人脸特征All.Name = "rd人脸特征All";
            this.rd人脸特征All.Size = new System.Drawing.Size(47, 16);
            this.rd人脸特征All.TabIndex = 181;
            this.rd人脸特征All.TabStop = true;
            this.rd人脸特征All.Text = "全部";
            this.rd人脸特征All.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(578, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 329;
            this.label10.Text = "人脸特征";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.rdHasPhoto);
            this.panel5.Controls.Add(this.rdNonePhoto);
            this.panel5.Controls.Add(this.rdPhotoAll);
            this.panel5.Location = new System.Drawing.Point(635, 8);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(149, 24);
            this.panel5.TabIndex = 328;
            // 
            // rdHasPhoto
            // 
            this.rdHasPhoto.AutoSize = true;
            this.rdHasPhoto.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdHasPhoto.Location = new System.Drawing.Point(61, 3);
            this.rdHasPhoto.Name = "rdHasPhoto";
            this.rdHasPhoto.Size = new System.Drawing.Size(35, 16);
            this.rdHasPhoto.TabIndex = 177;
            this.rdHasPhoto.Text = "有";
            this.rdHasPhoto.UseVisualStyleBackColor = true;
            // 
            // rdNonePhoto
            // 
            this.rdNonePhoto.AutoSize = true;
            this.rdNonePhoto.Checked = true;
            this.rdNonePhoto.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdNonePhoto.Location = new System.Drawing.Point(106, 3);
            this.rdNonePhoto.Name = "rdNonePhoto";
            this.rdNonePhoto.Size = new System.Drawing.Size(35, 16);
            this.rdNonePhoto.TabIndex = 179;
            this.rdNonePhoto.TabStop = true;
            this.rdNonePhoto.Text = "无";
            this.rdNonePhoto.UseVisualStyleBackColor = true;
            // 
            // rdPhotoAll
            // 
            this.rdPhotoAll.AutoSize = true;
            this.rdPhotoAll.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdPhotoAll.Location = new System.Drawing.Point(2, 3);
            this.rdPhotoAll.Name = "rdPhotoAll";
            this.rdPhotoAll.Size = new System.Drawing.Size(47, 16);
            this.rdPhotoAll.TabIndex = 181;
            this.rdPhotoAll.Text = "全部";
            this.rdPhotoAll.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(602, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 327;
            this.label3.Text = "照片";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // colFacility
            // 
            this.colFacility.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colFacility.HeaderText = "学校";
            this.colFacility.MinimumWidth = 100;
            this.colFacility.Name = "colFacility";
            this.colFacility.ReadOnly = true;
            // 
            // colClassName
            // 
            this.colClassName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colClassName.HeaderText = "班级";
            this.colClassName.MinimumWidth = 100;
            this.colClassName.Name = "colClassName";
            this.colClassName.ReadOnly = true;
            // 
            // colID
            // 
            this.colID.HeaderText = "准考证号";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Width = 150;
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
            this.colSex.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colSex.Width = 60;
            // 
            // colGrade
            // 
            this.colGrade.HeaderText = "年级";
            this.colGrade.Name = "colGrade";
            this.colGrade.ReadOnly = true;
            this.colGrade.Visible = false;
            // 
            // col照片
            // 
            this.col照片.HeaderText = "照片";
            this.col照片.Name = "col照片";
            this.col照片.ReadOnly = true;
            this.col照片.Width = 50;
            // 
            // colFill
            // 
            this.colFill.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colFill.HeaderText = "";
            this.colFill.MinimumWidth = 100;
            this.colFill.Name = "colFill";
            this.colFill.ReadOnly = true;
            // 
            // Frm学生照片采集
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1501, 638);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ucStudentSearch1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblClear);
            this.Controls.Add(this.videPlayer);
            this.Controls.Add(this.btnOpenCamera);
            this.Controls.Add(this.chk使用另一个摄像头);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm学生照片采集";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "学生照片采集";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmWriteStudentToICCard_FormClosed);
            this.Load += new System.EventHandler(this.FrmWriteStudentToICCard_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.CheckBox chk使用另一个摄像头;
        private AForge.Controls.VideoSourcePlayer videPlayer;
        private System.Windows.Forms.Button btnOpenCamera;
        private System.Windows.Forms.Label lblClear;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label2;
        private Controls.UCStudentSearch ucStudentSearch1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.RadioButton rd有人脸特征;
        private System.Windows.Forms.RadioButton rd无人脸特征;
        private System.Windows.Forms.RadioButton rd人脸特征All;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RadioButton rdHasPhoto;
        private System.Windows.Forms.RadioButton rdNonePhoto;
        private System.Windows.Forms.RadioButton rdPhotoAll;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFacility;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGrade;
        private System.Windows.Forms.DataGridViewCheckBoxColumn col照片;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFill;
    }
}