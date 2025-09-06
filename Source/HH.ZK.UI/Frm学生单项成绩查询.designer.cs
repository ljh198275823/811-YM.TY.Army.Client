namespace HH.ZK.UI
{
    partial class Frm学生单项成绩查询
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm学生单项成绩查询));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colFacility = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChannel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhysicalItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCheckTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colScore1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTestTime1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colScore2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTestTime2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colScore3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTestTime3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colScore4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTestTime4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.chkOnlyScore = new System.Windows.Forms.CheckBox();
            this.ucStudentSearch1 = new HH.ZK.CommonUI.Controls.UCStudentSearch();
            this.cmbPhysicalItem = new HH.ZK.CommonUI.Controls.PhysicalItemComboBox(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.colChannel,
            this.colPhysicalItem,
            this.colCheckTime,
            this.colScore1,
            this.colTestTime1,
            this.colScore2,
            this.colTestTime2,
            this.colScore3,
            this.colTestTime3,
            this.colScore4,
            this.colTestTime4,
            this.colScore,
            this.colResult,
            this.colFill});
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("宋体", 10.5F);
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
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
            this.colID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
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
            this.colSex.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colChannel
            // 
            resources.ApplyResources(this.colChannel, "colChannel");
            this.colChannel.Name = "colChannel";
            this.colChannel.ReadOnly = true;
            this.colChannel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colPhysicalItem
            // 
            this.colPhysicalItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            resources.ApplyResources(this.colPhysicalItem, "colPhysicalItem");
            this.colPhysicalItem.Name = "colPhysicalItem";
            this.colPhysicalItem.ReadOnly = true;
            // 
            // colCheckTime
            // 
            resources.ApplyResources(this.colCheckTime, "colCheckTime");
            this.colCheckTime.Name = "colCheckTime";
            this.colCheckTime.ReadOnly = true;
            // 
            // colScore1
            // 
            resources.ApplyResources(this.colScore1, "colScore1");
            this.colScore1.Name = "colScore1";
            this.colScore1.ReadOnly = true;
            // 
            // colTestTime1
            // 
            resources.ApplyResources(this.colTestTime1, "colTestTime1");
            this.colTestTime1.Name = "colTestTime1";
            this.colTestTime1.ReadOnly = true;
            // 
            // colScore2
            // 
            resources.ApplyResources(this.colScore2, "colScore2");
            this.colScore2.Name = "colScore2";
            this.colScore2.ReadOnly = true;
            // 
            // colTestTime2
            // 
            resources.ApplyResources(this.colTestTime2, "colTestTime2");
            this.colTestTime2.Name = "colTestTime2";
            this.colTestTime2.ReadOnly = true;
            // 
            // colScore3
            // 
            resources.ApplyResources(this.colScore3, "colScore3");
            this.colScore3.Name = "colScore3";
            this.colScore3.ReadOnly = true;
            // 
            // colTestTime3
            // 
            resources.ApplyResources(this.colTestTime3, "colTestTime3");
            this.colTestTime3.Name = "colTestTime3";
            this.colTestTime3.ReadOnly = true;
            // 
            // colScore4
            // 
            resources.ApplyResources(this.colScore4, "colScore4");
            this.colScore4.Name = "colScore4";
            this.colScore4.ReadOnly = true;
            // 
            // colTestTime4
            // 
            resources.ApplyResources(this.colTestTime4, "colTestTime4");
            this.colTestTime4.Name = "colTestTime4";
            this.colTestTime4.ReadOnly = true;
            // 
            // colScore
            // 
            resources.ApplyResources(this.colScore, "colScore");
            this.colScore.Name = "colScore";
            this.colScore.ReadOnly = true;
            // 
            // colResult
            // 
            resources.ApplyResources(this.colResult, "colResult");
            this.colResult.Name = "colResult";
            this.colResult.ReadOnly = true;
            // 
            // colFill
            // 
            this.colFill.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.colFill, "colFill");
            this.colFill.Name = "colFill";
            this.colFill.ReadOnly = true;
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // btnPrint
            // 
            resources.ApplyResources(this.btnPrint, "btnPrint");
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // chkOnlyScore
            // 
            resources.ApplyResources(this.chkOnlyScore, "chkOnlyScore");
            this.chkOnlyScore.ForeColor = System.Drawing.Color.Red;
            this.chkOnlyScore.Name = "chkOnlyScore";
            this.chkOnlyScore.UseVisualStyleBackColor = true;
            // 
            // ucStudentSearch1
            // 
            resources.ApplyResources(this.ucStudentSearch1, "ucStudentSearch1");
            this.ucStudentSearch1.Name = "ucStudentSearch1";
            // 
            // cmbPhysicalItem
            // 
            this.cmbPhysicalItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPhysicalItem.FormattingEnabled = true;
            resources.ApplyResources(this.cmbPhysicalItem, "cmbPhysicalItem");
            this.cmbPhysicalItem.Name = "cmbPhysicalItem";
            // 
            // Frm学生单项成绩查询
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbPhysicalItem);
            this.Controls.Add(this.ucStudentSearch1);
            this.Controls.Add(this.chkOnlyScore);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Frm学生单项成绩查询";
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.Controls.SetChildIndex(this.chkOnlyScore, 0);
            this.Controls.SetChildIndex(this.ucStudentSearch1, 0);
            this.Controls.SetChildIndex(this.cmbPhysicalItem, 0);
            this.Controls.SetChildIndex(this.btnSearch, 0);
            this.Controls.SetChildIndex(this.btnSaveAs, 0);
            this.Controls.SetChildIndex(this.btnColumn, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.CheckBox chkOnlyScore;
        private CommonUI.Controls.UCStudentSearch ucStudentSearch1;
        private CommonUI.Controls.PhysicalItemComboBox cmbPhysicalItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFacility;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChannel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhysicalItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCheckTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colScore1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTestTime1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colScore2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTestTime2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colScore3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTestTime3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colScore4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTestTime4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn colResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFill;
    }
}