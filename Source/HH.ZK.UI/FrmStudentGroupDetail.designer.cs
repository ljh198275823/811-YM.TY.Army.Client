namespace HH.ZK.UI
{
    partial class FrmStudentGroupDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStudentGroupDetail));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colChannel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIDNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnu_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lnk考试科目 = new System.Windows.Forms.LinkLabel();
            this.txt考试科目 = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.txtFacility = new HH.ZK.CommonUI.Controls.FacilityComboBox(this.components);
            this.rdFemale = new System.Windows.Forms.RadioButton();
            this.rdMale = new System.Windows.Forms.RadioButton();
            this.txtNumber = new LJH.GeneralLibrary.WinformControl.IntergerTextBox(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.btn增加学生 = new System.Windows.Forms.Button();
            this.btn删除所选学生 = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.txt考试时间 = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(557, 600);
            this.btnClose.Size = new System.Drawing.Size(114, 39);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(409, 600);
            this.btnOk.Size = new System.Drawing.Size(114, 39);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(383, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "学校";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colChannel,
            this.colID,
            this.colName,
            this.colSex,
            this.colClassName,
            this.colIDNumber,
            this.colFill});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(0, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(680, 510);
            this.dataGridView1.TabIndex = 157;
            // 
            // colChannel
            // 
            this.colChannel.HeaderText = "序号";
            this.colChannel.Name = "colChannel";
            this.colChannel.ReadOnly = true;
            this.colChannel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colID
            // 
            this.colID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colID.HeaderText = "准考证号";
            this.colID.MinimumWidth = 100;
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colName
            // 
            this.colName.HeaderText = "姓名";
            this.colName.MinimumWidth = 80;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            this.colClassName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colClassName.HeaderText = "班级";
            this.colClassName.MinimumWidth = 60;
            this.colClassName.Name = "colClassName";
            this.colClassName.ReadOnly = true;
            this.colClassName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colClassName.Width = 60;
            // 
            // colIDNumber
            // 
            this.colIDNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colIDNumber.HeaderText = "身份证号";
            this.colIDNumber.Name = "colIDNumber";
            this.colIDNumber.ReadOnly = true;
            this.colIDNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colIDNumber.Width = 59;
            // 
            // colFill
            // 
            this.colFill.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colFill.HeaderText = "";
            this.colFill.Name = "colFill";
            this.colFill.ReadOnly = true;
            this.colFill.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_Add,
            this.mnu_Delete});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(140, 48);
            // 
            // mnu_Add
            // 
            this.mnu_Add.Name = "mnu_Add";
            this.mnu_Add.Size = new System.Drawing.Size(139, 22);
            this.mnu_Add.Text = "增加学生";
            this.mnu_Add.Click += new System.EventHandler(this.mnu_Add_Click);
            // 
            // mnu_Delete
            // 
            this.mnu_Delete.Name = "mnu_Delete";
            this.mnu_Delete.Size = new System.Drawing.Size(139, 22);
            this.mnu_Delete.Text = "删除所选项";
            this.mnu_Delete.Click += new System.EventHandler(this.mnu_Delete_Click);
            // 
            // lblCount
            // 
            this.lblCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCount.ForeColor = System.Drawing.Color.Blue;
            this.lblCount.Location = new System.Drawing.Point(6, 607);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(69, 16);
            this.lblCount.TabIndex = 158;
            this.lblCount.Text = "共 0 项";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(359, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 161;
            this.label3.Text = "考试时间";
            // 
            // lnk考试科目
            // 
            this.lnk考试科目.AutoSize = true;
            this.lnk考试科目.Location = new System.Drawing.Point(15, 49);
            this.lnk考试科目.Name = "lnk考试科目";
            this.lnk考试科目.Size = new System.Drawing.Size(53, 12);
            this.lnk考试科目.TabIndex = 4;
            this.lnk考试科目.TabStop = true;
            this.lnk考试科目.Text = "考试科目";
            this.lnk考试科目.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk考试科目_LinkClicked);
            // 
            // txt考试科目
            // 
            this.txt考试科目.Enabled = false;
            this.txt考试科目.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt考试科目.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txt考试科目.Location = new System.Drawing.Point(74, 42);
            this.txt考试科目.MaxLength = 20;
            this.txt考试科目.Name = "txt考试科目";
            this.txt考试科目.Size = new System.Drawing.Size(261, 26);
            this.txt考试科目.TabIndex = 163;
            // 
            // txtFacility
            // 
            this.txtFacility.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtFacility.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtFacility.FormattingEnabled = true;
            this.txtFacility.Location = new System.Drawing.Point(415, 8);
            this.txtFacility.Name = "txtFacility";
            this.txtFacility.Size = new System.Drawing.Size(246, 24);
            this.txtFacility.TabIndex = 3;
            // 
            // rdFemale
            // 
            this.rdFemale.AutoSize = true;
            this.rdFemale.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdFemale.Location = new System.Drawing.Point(254, 10);
            this.rdFemale.Name = "rdFemale";
            this.rdFemale.Size = new System.Drawing.Size(74, 20);
            this.rdFemale.TabIndex = 2;
            this.rdFemale.Text = "女子组";
            this.rdFemale.UseVisualStyleBackColor = true;
            // 
            // rdMale
            // 
            this.rdMale.AutoSize = true;
            this.rdMale.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdMale.Location = new System.Drawing.Point(159, 10);
            this.rdMale.Name = "rdMale";
            this.rdMale.Size = new System.Drawing.Size(74, 20);
            this.rdMale.TabIndex = 1;
            this.rdMale.Text = "男子组";
            this.rdMale.UseVisualStyleBackColor = true;
            // 
            // txtNumber
            // 
            this.txtNumber.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtNumber.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtNumber.Location = new System.Drawing.Point(74, 7);
            this.txtNumber.MaxValue = 32767;
            this.txtNumber.MinValue = 0;
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(54, 26);
            this.txtNumber.TabIndex = 0;
            this.txtNumber.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(39, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 169;
            this.label10.Text = "组号";
            // 
            // btn增加学生
            // 
            this.btn增加学生.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn增加学生.Location = new System.Drawing.Point(220, 604);
            this.btn增加学生.Name = "btn增加学生";
            this.btn增加学生.Size = new System.Drawing.Size(74, 30);
            this.btn增加学生.TabIndex = 170;
            this.btn增加学生.Text = "增加学生";
            this.btn增加学生.UseVisualStyleBackColor = true;
            this.btn增加学生.Click += new System.EventHandler(this.mnu_Add_Click);
            // 
            // btn删除所选学生
            // 
            this.btn删除所选学生.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn删除所选学生.Location = new System.Drawing.Point(300, 604);
            this.btn删除所选学生.Name = "btn删除所选学生";
            this.btn删除所选学生.Size = new System.Drawing.Size(85, 30);
            this.btn删除所选学生.TabIndex = 171;
            this.btn删除所选学生.Text = "删除所选学生";
            this.btn删除所选学生.UseVisualStyleBackColor = true;
            this.btn删除所选学生.Click += new System.EventHandler(this.mnu_Delete_Click);
            // 
            // btnDown
            // 
            this.btnDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDown.BackgroundImage = global::HH.ZK.UI.Properties.Resources.down;
            this.btnDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDown.Location = new System.Drawing.Point(159, 597);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(33, 45);
            this.btnDown.TabIndex = 173;
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnUp
            // 
            this.btnUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUp.BackgroundImage = global::HH.ZK.UI.Properties.Resources.up;
            this.btnUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUp.Location = new System.Drawing.Point(106, 597);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(33, 45);
            this.btnUp.TabIndex = 172;
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // txt考试时间
            // 
            this.txt考试时间.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt考试时间.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txt考试时间.Location = new System.Drawing.Point(418, 42);
            this.txt考试时间.MaxLength = 20;
            this.txt考试时间.Name = "txt考试时间";
            this.txt考试时间.Size = new System.Drawing.Size(243, 26);
            this.txt考试时间.TabIndex = 174;
            // 
            // FrmStudentGroupDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 651);
            this.Controls.Add(this.txt考试时间);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btn删除所选学生);
            this.Controls.Add(this.btn增加学生);
            this.Controls.Add(this.rdMale);
            this.Controls.Add(this.rdFemale);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtFacility);
            this.Controls.Add(this.lnk考试科目);
            this.Controls.Add(this.txt考试科目);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmStudentGroupDetail";
            this.Text = "学生分组";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.lblCount, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txt考试科目, 0);
            this.Controls.SetChildIndex(this.lnk考试科目, 0);
            this.Controls.SetChildIndex(this.txtFacility, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.txtNumber, 0);
            this.Controls.SetChildIndex(this.rdFemale, 0);
            this.Controls.SetChildIndex(this.rdMale, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btn增加学生, 0);
            this.Controls.SetChildIndex(this.btn删除所选学生, 0);
            this.Controls.SetChildIndex(this.btnUp, 0);
            this.Controls.SetChildIndex(this.btnDown, 0);
            this.Controls.SetChildIndex(this.txt考试时间, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnu_Add;
        private System.Windows.Forms.ToolStripMenuItem mnu_Delete;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel lnk考试科目;
        private LJH.GeneralLibrary.WinformControl.DBCTextBox txt考试科目;
        private HH.ZK.CommonUI.Controls.FacilityComboBox txtFacility;
        private System.Windows.Forms.RadioButton rdFemale;
        private System.Windows.Forms.RadioButton rdMale;
        private LJH.GeneralLibrary.WinformControl.IntergerTextBox txtNumber;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn增加学生;
        private System.Windows.Forms.Button btn删除所选学生;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChannel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFill;
        private LJH.GeneralLibrary.WinformControl.DBCTextBox txt考试时间;
    }
}