namespace HH.ZK.UI
{
    partial class Frm学生成绩速录
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm学生成绩速录));
            this.scoreView = new System.Windows.Forms.DataGridView();
            this.colPhysicalItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpStudent = new System.Windows.Forms.GroupBox();
            this._txtID = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this._rdFemale = new System.Windows.Forms.RadioButton();
            this._rdMale = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this._txtName = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.label15 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.scoreView)).BeginInit();
            this.gpStudent.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
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
            this.scoreView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scoreView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPhysicalItem,
            this.colAddScore,
            this.colScore,
            this.colResult,
            this.colFill});
            this.scoreView.Location = new System.Drawing.Point(3, 150);
            this.scoreView.Name = "scoreView";
            this.scoreView.RowHeadersVisible = false;
            this.scoreView.RowTemplate.Height = 30;
            this.scoreView.Size = new System.Drawing.Size(806, 526);
            this.scoreView.TabIndex = 110;
            this.scoreView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.scoreView_CellBeginEdit);
            this.scoreView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.scoreView_CellEndEdit);
            // 
            // colPhysicalItem
            // 
            this.colPhysicalItem.HeaderText = "测试项目";
            this.colPhysicalItem.Name = "colPhysicalItem";
            this.colPhysicalItem.ReadOnly = true;
            this.colPhysicalItem.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colPhysicalItem.Width = 250;
            // 
            // colAddScore
            // 
            this.colAddScore.HeaderText = "增加成绩";
            this.colAddScore.Name = "colAddScore";
            this.colAddScore.ReadOnly = true;
            this.colAddScore.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colAddScore.Width = 150;
            // 
            // colScore
            // 
            this.colScore.HeaderText = "当前成绩";
            this.colScore.Name = "colScore";
            this.colScore.ReadOnly = true;
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
            // colFill
            // 
            this.colFill.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colFill.HeaderText = "";
            this.colFill.Name = "colFill";
            this.colFill.ReadOnly = true;
            this.colFill.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // gpStudent
            // 
            this.gpStudent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpStudent.Controls.Add(this.btnSave);
            this.gpStudent.Controls.Add(this._txtID);
            this.gpStudent.Controls.Add(this.label12);
            this.gpStudent.Controls.Add(this.panel6);
            this.gpStudent.Controls.Add(this.label13);
            this.gpStudent.Controls.Add(this._txtName);
            this.gpStudent.Controls.Add(this.label15);
            this.gpStudent.Location = new System.Drawing.Point(3, 1);
            this.gpStudent.Name = "gpStudent";
            this.gpStudent.Size = new System.Drawing.Size(806, 130);
            this.gpStudent.TabIndex = 109;
            this.gpStudent.TabStop = false;
            // 
            // _txtID
            // 
            this._txtID.BackColor = System.Drawing.Color.White;
            this._txtID.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this._txtID.ImeMode = System.Windows.Forms.ImeMode.On;
            this._txtID.Location = new System.Drawing.Point(49, 21);
            this._txtID.MaxLength = 20;
            this._txtID.Name = "_txtID";
            this._txtID.Size = new System.Drawing.Size(367, 30);
            this._txtID.TabIndex = 106;
            this._txtID.TextChanged += new System.EventHandler(this.btnSearch_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label12.Location = new System.Drawing.Point(13, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 12);
            this.label12.TabIndex = 115;
            this.label12.Text = "考号";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this._rdFemale);
            this.panel6.Controls.Add(this._rdMale);
            this.panel6.Enabled = false;
            this.panel6.Location = new System.Drawing.Point(299, 83);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(116, 30);
            this.panel6.TabIndex = 114;
            // 
            // _rdFemale
            // 
            this._rdFemale.AutoSize = true;
            this._rdFemale.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this._rdFemale.Location = new System.Drawing.Point(65, 3);
            this._rdFemale.Name = "_rdFemale";
            this._rdFemale.Size = new System.Drawing.Size(47, 24);
            this._rdFemale.TabIndex = 6;
            this._rdFemale.Text = "女";
            this._rdFemale.UseVisualStyleBackColor = true;
            // 
            // _rdMale
            // 
            this._rdMale.AutoSize = true;
            this._rdMale.Checked = true;
            this._rdMale.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this._rdMale.Location = new System.Drawing.Point(3, 3);
            this._rdMale.Name = "_rdMale";
            this._rdMale.Size = new System.Drawing.Size(47, 24);
            this._rdMale.TabIndex = 5;
            this._rdMale.TabStop = true;
            this._rdMale.Text = "男";
            this._rdMale.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label13.Location = new System.Drawing.Point(264, 92);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 12);
            this.label13.TabIndex = 113;
            this.label13.Text = "性别";
            // 
            // _txtName
            // 
            this._txtName.BackColor = System.Drawing.Color.White;
            this._txtName.Enabled = false;
            this._txtName.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this._txtName.ImeMode = System.Windows.Forms.ImeMode.On;
            this._txtName.Location = new System.Drawing.Point(49, 83);
            this._txtName.MaxLength = 20;
            this._txtName.Name = "_txtName";
            this._txtName.Size = new System.Drawing.Size(178, 30);
            this._txtName.TabIndex = 107;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label15.Location = new System.Drawing.Point(13, 92);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 12);
            this.label15.TabIndex = 111;
            this.label15.Text = "姓名";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(497, 30);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(204, 80);
            this.btnSave.TabIndex = 116;
            this.btnSave.Text = "保存(&S)";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Frm学生成绩速录
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 679);
            this.Controls.Add(this.scoreView);
            this.Controls.Add(this.gpStudent);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm学生成绩速录";
            this.Text = "学生成绩速录";
            this.Load += new System.EventHandler(this.Frm学生成绩速录_Load);
            ((System.ComponentModel.ISupportInitialize)(this.scoreView)).EndInit();
            this.gpStudent.ResumeLayout(false);
            this.gpStudent.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView scoreView;
        private System.Windows.Forms.GroupBox gpStudent;
        private LJH.GeneralLibrary.WinformControl.DBCTextBox _txtID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.RadioButton _rdFemale;
        private System.Windows.Forms.RadioButton _rdMale;
        private System.Windows.Forms.Label label13;
        private LJH.GeneralLibrary.WinformControl.DBCTextBox _txtName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhysicalItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn colScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn colResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFill;
        private System.Windows.Forms.Button btnSave;
    }
}