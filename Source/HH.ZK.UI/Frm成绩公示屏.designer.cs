namespace HH.ZK.UI
{
    partial class Frm成绩公示屏
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl = new System.Windows.Forms.Panel();
            this.txt学校 = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.picPhoto = new System.Windows.Forms.PictureBox();
            this.scoreView = new System.Windows.Forms.DataGridView();
            this.colPhysicalItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJiafen1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._txtID = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this._rdFemale = new System.Windows.Forms.RadioButton();
            this._rdMale = new System.Windows.Forms.RadioButton();
            this._txtName = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.pic = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtBarcode = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.picFPImg = new System.Windows.Forms.PictureBox();
            this.pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreView)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFPImg)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl
            // 
            this.pnl.BackColor = System.Drawing.Color.White;
            this.pnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl.Controls.Add(this.picFPImg);
            this.pnl.Controls.Add(this.txt学校);
            this.pnl.Controls.Add(this.picPhoto);
            this.pnl.Controls.Add(this.scoreView);
            this.pnl.Controls.Add(this._txtID);
            this.pnl.Controls.Add(this.label12);
            this.pnl.Controls.Add(this.label15);
            this.pnl.Controls.Add(this.panel6);
            this.pnl.Controls.Add(this._txtName);
            this.pnl.Controls.Add(this.label13);
            this.pnl.Location = new System.Drawing.Point(27, 52);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(974, 432);
            this.pnl.TabIndex = 110;
            // 
            // txt学校
            // 
            this.txt学校.BackColor = System.Drawing.Color.White;
            this.txt学校.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt学校.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt学校.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txt学校.Location = new System.Drawing.Point(13, 150);
            this.txt学校.MaxLength = 20;
            this.txt学校.Name = "txt学校";
            this.txt学校.Size = new System.Drawing.Size(312, 24);
            this.txt学校.TabIndex = 117;
            // 
            // picPhoto
            // 
            this.picPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPhoto.Location = new System.Drawing.Point(79, 205);
            this.picPhoto.Name = "picPhoto";
            this.picPhoto.Size = new System.Drawing.Size(150, 180);
            this.picPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPhoto.TabIndex = 116;
            this.picPhoto.TabStop = false;
            // 
            // scoreView
            // 
            this.scoreView.AllowUserToAddRows = false;
            this.scoreView.AllowUserToDeleteRows = false;
            this.scoreView.AllowUserToResizeRows = false;
            this.scoreView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scoreView.BackgroundColor = System.Drawing.Color.White;
            this.scoreView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.scoreView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.scoreView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scoreView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPhysicalItem,
            this.colScore,
            this.colResult,
            this.colJiafen1,
            this.colRank,
            this.colFill});
            this.scoreView.Location = new System.Drawing.Point(351, 8);
            this.scoreView.Name = "scoreView";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.scoreView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.scoreView.RowHeadersVisible = false;
            this.scoreView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.scoreView.RowTemplate.Height = 40;
            this.scoreView.Size = new System.Drawing.Size(615, 56);
            this.scoreView.TabIndex = 110;
            // 
            // colPhysicalItem
            // 
            this.colPhysicalItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPhysicalItem.HeaderText = "测试项目";
            this.colPhysicalItem.MinimumWidth = 150;
            this.colPhysicalItem.Name = "colPhysicalItem";
            this.colPhysicalItem.ReadOnly = true;
            this.colPhysicalItem.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colScore
            // 
            this.colScore.HeaderText = "成绩";
            this.colScore.Name = "colScore";
            this.colScore.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colScore.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colScore.Width = 150;
            // 
            // colResult
            // 
            this.colResult.HeaderText = "得分";
            this.colResult.Name = "colResult";
            this.colResult.ReadOnly = true;
            this.colResult.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colResult.Width = 150;
            // 
            // colJiafen1
            // 
            this.colJiafen1.HeaderText = "加分";
            this.colJiafen1.Name = "colJiafen1";
            this.colJiafen1.ReadOnly = true;
            this.colJiafen1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colJiafen1.Visible = false;
            this.colJiafen1.Width = 150;
            // 
            // colRank
            // 
            this.colRank.HeaderText = "等级";
            this.colRank.Name = "colRank";
            this.colRank.ReadOnly = true;
            this.colRank.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colRank.Visible = false;
            // 
            // colFill
            // 
            this.colFill.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colFill.HeaderText = "";
            this.colFill.Name = "colFill";
            this.colFill.ReadOnly = true;
            this.colFill.Visible = false;
            // 
            // _txtID
            // 
            this._txtID.BackColor = System.Drawing.Color.White;
            this._txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._txtID.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this._txtID.ImeMode = System.Windows.Forms.ImeMode.On;
            this._txtID.Location = new System.Drawing.Point(113, 9);
            this._txtID.MaxLength = 20;
            this._txtID.Name = "_txtID";
            this._txtID.Size = new System.Drawing.Size(212, 24);
            this._txtID.TabIndex = 106;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label12.Location = new System.Drawing.Point(9, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 21);
            this.label12.TabIndex = 115;
            this.label12.Text = "准考证号";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label15.Location = new System.Drawing.Point(19, 57);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 21);
            this.label15.TabIndex = 111;
            this.label15.Text = "姓名";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this._rdFemale);
            this.panel6.Controls.Add(this._rdMale);
            this.panel6.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel6.Location = new System.Drawing.Point(79, 99);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(110, 32);
            this.panel6.TabIndex = 114;
            // 
            // _rdFemale
            // 
            this._rdFemale.AutoSize = true;
            this._rdFemale.Location = new System.Drawing.Point(55, 4);
            this._rdFemale.Name = "_rdFemale";
            this._rdFemale.Size = new System.Drawing.Size(50, 25);
            this._rdFemale.TabIndex = 6;
            this._rdFemale.Text = "女";
            this._rdFemale.UseVisualStyleBackColor = true;
            // 
            // _rdMale
            // 
            this._rdMale.AutoSize = true;
            this._rdMale.Checked = true;
            this._rdMale.Location = new System.Drawing.Point(3, 6);
            this._rdMale.Name = "_rdMale";
            this._rdMale.Size = new System.Drawing.Size(50, 25);
            this._rdMale.TabIndex = 5;
            this._rdMale.TabStop = true;
            this._rdMale.Text = "男";
            this._rdMale.UseVisualStyleBackColor = true;
            // 
            // _txtName
            // 
            this._txtName.BackColor = System.Drawing.Color.White;
            this._txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._txtName.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this._txtName.ImeMode = System.Windows.Forms.ImeMode.On;
            this._txtName.Location = new System.Drawing.Point(79, 54);
            this._txtName.MaxLength = 20;
            this._txtName.Name = "_txtName";
            this._txtName.Size = new System.Drawing.Size(246, 24);
            this._txtName.TabIndex = 107;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label13.Location = new System.Drawing.Point(19, 104);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 21);
            this.label13.TabIndex = 113;
            this.label13.Text = "性别";
            // 
            // pic
            // 
            this.pic.Location = new System.Drawing.Point(844, 12);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(32, 30);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic.TabIndex = 109;
            this.pic.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClose.Location = new System.Drawing.Point(2, 493);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(99, 35);
            this.btnClose.TabIndex = 118;
            this.btnClose.Text = "退出";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtBarcode
            // 
            this.txtBarcode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBarcode.BackColor = System.Drawing.Color.White;
            this.txtBarcode.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBarcode.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtBarcode.Location = new System.Drawing.Point(200, 495);
            this.txtBarcode.MaxLength = 20;
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(367, 30);
            this.txtBarcode.TabIndex = 119;
            this.txtBarcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt准考证号_KeyDown);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(145, 504);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 120;
            this.label1.Text = "准考证号";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // picFPImg
            // 
            this.picFPImg.Location = new System.Drawing.Point(251, 205);
            this.picFPImg.Name = "picFPImg";
            this.picFPImg.Size = new System.Drawing.Size(39, 180);
            this.picFPImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFPImg.TabIndex = 118;
            this.picFPImg.TabStop = false;
            this.picFPImg.Visible = false;
            // 
            // Frm成绩公示屏
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 531);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pnl);
            this.Controls.Add(this.pic);
            this.Name = "Frm成绩公示屏";
            this.Text = "FrmScoreView";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm成绩公示屏_FormClosing);
            this.Load += new System.EventHandler(this.FrmScoreView_Load);
            this.Resize += new System.EventHandler(this.FrmScoreView_Resize);
            this.pnl.ResumeLayout(false);
            this.pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreView)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFPImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.DataGridView scoreView;
        private System.Windows.Forms.PictureBox picPhoto;
        private LJH.GeneralLibrary.WinformControl.DBCTextBox _txtID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.RadioButton _rdFemale;
        private System.Windows.Forms.RadioButton _rdMale;
        private System.Windows.Forms.Label label13;
        private LJH.GeneralLibrary.WinformControl.DBCTextBox _txtName;
        private System.Windows.Forms.Label label15;
        private LJH.GeneralLibrary.WinformControl.DBCTextBox txt学校;
        private System.Windows.Forms.Button btnClose;
        private LJH.GeneralLibrary.WinformControl.DBCTextBox txtBarcode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhysicalItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn colResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJiafen1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRank;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFill;
        private System.Windows.Forms.PictureBox picFPImg;
    }
}