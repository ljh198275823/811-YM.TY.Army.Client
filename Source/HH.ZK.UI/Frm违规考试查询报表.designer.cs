namespace HH.ZK.UI
{
    partial class Frm违规考试查询报表
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm违规考试查询报表));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ucStudentSearch1 = new HH.ZK.CommonUI.Controls.UCStudentSearch();
            this.cmbPhysicalItem = new HH.ZK.CommonUI.Controls.PhysicalItemComboBox(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.rdHandled = new System.Windows.Forms.RadioButton();
            this.rdNotHandled = new System.Windows.Forms.RadioButton();
            this.rdHanldedAll = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.colFacility = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhysicalItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col重考次数 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colScore1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colScore2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colScore3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colScore4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colScore5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colScore6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCurrentScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCurrentResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHandled = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colScores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnColumn
            // 
            this.btnColumn.Location = new System.Drawing.Point(1071, 18);
            this.btnColumn.Size = new System.Drawing.Size(111, 82);
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.Location = new System.Drawing.Point(944, 18);
            this.btnSaveAs.Size = new System.Drawing.Size(111, 82);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(817, 18);
            this.btnSearch.Size = new System.Drawing.Size(111, 82);
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
            this.dataGridView1.ColumnHeadersHeight = 32;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFacility,
            this.colID,
            this.colName,
            this.colSex,
            this.colClassName,
            this.colPhysicalItem,
            this.col重考次数,
            this.colScore1,
            this.colScore2,
            this.colScore3,
            this.colScore4,
            this.colScore5,
            this.colScore6,
            this.colCurrentScore,
            this.colCurrentResult,
            this.colHandled,
            this.colScores});
            this.dataGridView1.Location = new System.Drawing.Point(0, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1281, 511);
            this.dataGridView1.TabIndex = 140;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // ucStudentSearch1
            // 
            this.ucStudentSearch1.Location = new System.Drawing.Point(8, 9);
            this.ucStudentSearch1.Name = "ucStudentSearch1";
            this.ucStudentSearch1.Size = new System.Drawing.Size(562, 100);
            this.ucStudentSearch1.TabIndex = 175;
            // 
            // cmbPhysicalItem
            // 
            this.cmbPhysicalItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPhysicalItem.FormattingEnabled = true;
            this.cmbPhysicalItem.Location = new System.Drawing.Point(629, 16);
            this.cmbPhysicalItem.Name = "cmbPhysicalItem";
            this.cmbPhysicalItem.Size = new System.Drawing.Size(172, 20);
            this.cmbPhysicalItem.TabIndex = 177;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(573, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 176;
            this.label10.Text = "考试科目";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.rdHandled);
            this.panel5.Controls.Add(this.rdNotHandled);
            this.panel5.Controls.Add(this.rdHanldedAll);
            this.panel5.Location = new System.Drawing.Point(629, 46);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(172, 25);
            this.panel5.TabIndex = 282;
            // 
            // rdHandled
            // 
            this.rdHandled.AutoSize = true;
            this.rdHandled.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdHandled.Location = new System.Drawing.Point(51, 4);
            this.rdHandled.Name = "rdHandled";
            this.rdHandled.Size = new System.Drawing.Size(59, 16);
            this.rdHandled.TabIndex = 177;
            this.rdHandled.Text = "已处理";
            this.rdHandled.UseVisualStyleBackColor = true;
            // 
            // rdNotHandled
            // 
            this.rdNotHandled.AutoSize = true;
            this.rdNotHandled.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdNotHandled.Location = new System.Drawing.Point(113, 4);
            this.rdNotHandled.Name = "rdNotHandled";
            this.rdNotHandled.Size = new System.Drawing.Size(59, 16);
            this.rdNotHandled.TabIndex = 179;
            this.rdNotHandled.Text = "未处理";
            this.rdNotHandled.UseVisualStyleBackColor = true;
            // 
            // rdHanldedAll
            // 
            this.rdHanldedAll.AutoSize = true;
            this.rdHanldedAll.Checked = true;
            this.rdHanldedAll.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdHanldedAll.Location = new System.Drawing.Point(2, 4);
            this.rdHanldedAll.Name = "rdHanldedAll";
            this.rdHanldedAll.Size = new System.Drawing.Size(47, 16);
            this.rdHanldedAll.TabIndex = 181;
            this.rdHanldedAll.TabStop = true;
            this.rdHanldedAll.Text = "全部";
            this.rdHanldedAll.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(573, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 281;
            this.label6.Text = "处理情况";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.colName.MinimumWidth = 80;
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
            // colClassName
            // 
            this.colClassName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colClassName.HeaderText = "班级";
            this.colClassName.MinimumWidth = 100;
            this.colClassName.Name = "colClassName";
            this.colClassName.ReadOnly = true;
            // 
            // colPhysicalItem
            // 
            this.colPhysicalItem.HeaderText = "考试科目";
            this.colPhysicalItem.Name = "colPhysicalItem";
            this.colPhysicalItem.ReadOnly = true;
            this.colPhysicalItem.Width = 120;
            // 
            // col重考次数
            // 
            dataGridViewCellStyle1.Format = "G";
            dataGridViewCellStyle1.NullValue = null;
            this.col重考次数.DefaultCellStyle = dataGridViewCellStyle1;
            this.col重考次数.HeaderText = "违考次数";
            this.col重考次数.Name = "col重考次数";
            this.col重考次数.ReadOnly = true;
            this.col重考次数.Width = 80;
            // 
            // colScore1
            // 
            this.colScore1.HeaderText = "成绩一";
            this.colScore1.Name = "colScore1";
            this.colScore1.ReadOnly = true;
            this.colScore1.Width = 80;
            // 
            // colScore2
            // 
            this.colScore2.HeaderText = "成绩二";
            this.colScore2.Name = "colScore2";
            this.colScore2.ReadOnly = true;
            this.colScore2.Width = 80;
            // 
            // colScore3
            // 
            this.colScore3.HeaderText = "成绩三";
            this.colScore3.Name = "colScore3";
            this.colScore3.ReadOnly = true;
            this.colScore3.Width = 80;
            // 
            // colScore4
            // 
            this.colScore4.HeaderText = "成绩四";
            this.colScore4.Name = "colScore4";
            this.colScore4.ReadOnly = true;
            this.colScore4.Width = 80;
            // 
            // colScore5
            // 
            this.colScore5.HeaderText = "成绩五";
            this.colScore5.Name = "colScore5";
            this.colScore5.ReadOnly = true;
            this.colScore5.Width = 80;
            // 
            // colScore6
            // 
            this.colScore6.HeaderText = "成绩六";
            this.colScore6.Name = "colScore6";
            this.colScore6.ReadOnly = true;
            this.colScore6.Width = 80;
            // 
            // colCurrentScore
            // 
            this.colCurrentScore.HeaderText = "当前成绩";
            this.colCurrentScore.Name = "colCurrentScore";
            this.colCurrentScore.ReadOnly = true;
            this.colCurrentScore.Width = 80;
            // 
            // colCurrentResult
            // 
            this.colCurrentResult.HeaderText = "当前得分";
            this.colCurrentResult.Name = "colCurrentResult";
            this.colCurrentResult.ReadOnly = true;
            this.colCurrentResult.Width = 80;
            // 
            // colHandled
            // 
            this.colHandled.HeaderText = "处理情况";
            this.colHandled.Name = "colHandled";
            this.colHandled.ReadOnly = true;
            this.colHandled.Width = 80;
            // 
            // colScores
            // 
            this.colScores.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colScores.HeaderText = "";
            this.colScores.MinimumWidth = 200;
            this.colScores.Name = "colScores";
            this.colScores.ReadOnly = true;
            // 
            // Frm违规考试查询报表
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 657);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbPhysicalItem);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ucStudentSearch1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm违规考试查询报表";
            this.Text = "违规考试查询报表";
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
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private CommonUI.Controls.UCStudentSearch ucStudentSearch1;
        private CommonUI.Controls.PhysicalItemComboBox cmbPhysicalItem;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RadioButton rdHandled;
        private System.Windows.Forms.RadioButton rdNotHandled;
        private System.Windows.Forms.RadioButton rdHanldedAll;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFacility;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhysicalItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn col重考次数;
        private System.Windows.Forms.DataGridViewTextBoxColumn colScore1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colScore2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colScore3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colScore4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colScore5;
        private System.Windows.Forms.DataGridViewTextBoxColumn colScore6;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCurrentScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCurrentResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHandled;
        private System.Windows.Forms.DataGridViewTextBoxColumn colScores;
    }
}