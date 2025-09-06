
namespace HH.ZK.UI
{
    partial class FrmDiscussionDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDiscussionDetail));
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.txtStudentID = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txtScore = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.txtTestTime = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDescription = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.txtNewScore = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.txtApprover = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btn生成仲裁报告 = new System.Windows.Forms.Button();
            this.txtPhysicalItem = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.txtResolveType = new HH.ZK.CommonUI.Controls.ResolveTypeComboBox(this.components);
            this.btn确定 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn录相回放 = new System.Windows.Forms.Button();
            this.colStudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFileSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCamera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhysicalItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col测试时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLocalPath = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colFill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(528, 525);
            this.btnClose.Size = new System.Drawing.Size(94, 54);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(22, 525);
            this.btnOk.Size = new System.Drawing.Size(34, 54);
            this.btnOk.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(358, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 13;
            this.label3.Text = "姓名";
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtName.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtName.Location = new System.Drawing.Point(393, 15);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(222, 30);
            this.txtName.TabIndex = 1;
            // 
            // txtStudentID
            // 
            this.txtStudentID.Enabled = false;
            this.txtStudentID.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtStudentID.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtStudentID.Location = new System.Drawing.Point(79, 16);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(222, 30);
            this.txtStudentID.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "准考证号";
            // 
            // txtScore
            // 
            this.txtScore.Enabled = false;
            this.txtScore.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtScore.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtScore.Location = new System.Drawing.Point(393, 59);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(222, 30);
            this.txtScore.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(358, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 17;
            this.label4.Text = "成绩";
            // 
            // txtTestTime
            // 
            this.txtTestTime.Enabled = false;
            this.txtTestTime.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTestTime.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtTestTime.Location = new System.Drawing.Point(79, 105);
            this.txtTestTime.Name = "txtTestTime";
            this.txtTestTime.Size = new System.Drawing.Size(222, 30);
            this.txtTestTime.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 19;
            this.label5.Text = "测试时间";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 353);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 20;
            this.label6.Text = "仲裁说明";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDescription.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtDescription.Location = new System.Drawing.Point(79, 308);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(536, 102);
            this.txtDescription.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 435);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 22;
            this.label7.Text = "仲裁结果";
            // 
            // txtNewScore
            // 
            this.txtNewScore.Enabled = false;
            this.txtNewScore.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtNewScore.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtNewScore.Location = new System.Drawing.Point(393, 426);
            this.txtNewScore.Name = "txtNewScore";
            this.txtNewScore.Size = new System.Drawing.Size(222, 30);
            this.txtNewScore.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(346, 435);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 24;
            this.label8.Text = "新成绩";
            // 
            // txtApprover
            // 
            this.txtApprover.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtApprover.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtApprover.Location = new System.Drawing.Point(79, 473);
            this.txtApprover.Name = "txtApprover";
            this.txtApprover.Size = new System.Drawing.Size(222, 30);
            this.txtApprover.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 482);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 28;
            this.label10.Text = "仲裁老师";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 203);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 162;
            this.label11.Text = "考试视频";
            // 
            // btn生成仲裁报告
            // 
            this.btn生成仲裁报告.Location = new System.Drawing.Point(79, 525);
            this.btn生成仲裁报告.Name = "btn生成仲裁报告";
            this.btn生成仲裁报告.Size = new System.Drawing.Size(142, 54);
            this.btn生成仲裁报告.TabIndex = 163;
            this.btn生成仲裁报告.Text = "生成仲裁报告";
            this.btn生成仲裁报告.UseVisualStyleBackColor = true;
            this.btn生成仲裁报告.Click += new System.EventHandler(this.btn生成仲裁报告_Click);
            // 
            // txtPhysicalItem
            // 
            this.txtPhysicalItem.Enabled = false;
            this.txtPhysicalItem.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPhysicalItem.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtPhysicalItem.Location = new System.Drawing.Point(79, 60);
            this.txtPhysicalItem.Name = "txtPhysicalItem";
            this.txtPhysicalItem.Size = new System.Drawing.Size(222, 30);
            this.txtPhysicalItem.TabIndex = 164;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 69);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 165;
            this.label12.Text = "考试科目";
            // 
            // txtResolveType
            // 
            this.txtResolveType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtResolveType.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtResolveType.FormattingEnabled = true;
            this.txtResolveType.Location = new System.Drawing.Point(79, 427);
            this.txtResolveType.Name = "txtResolveType";
            this.txtResolveType.Size = new System.Drawing.Size(222, 28);
            this.txtResolveType.TabIndex = 1;
            this.txtResolveType.SelectedIndexChanged += new System.EventHandler(this.txtResolveType_SelectedIndexChanged);
            // 
            // btn确定
            // 
            this.btn确定.Location = new System.Drawing.Point(360, 525);
            this.btn确定.Name = "btn确定";
            this.btn确定.Size = new System.Drawing.Size(142, 54);
            this.btn确定.TabIndex = 166;
            this.btn确定.Text = "确定";
            this.btn确定.UseVisualStyleBackColor = true;
            this.btn确定.Click += new System.EventHandler(this.btn确定_Click);
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
            this.colStudentID,
            this.colFile,
            this.colFileSize,
            this.colState,
            this.colCamera,
            this.colPhysicalItem,
            this.col测试时间,
            this.colLocalPath,
            this.colFill});
            this.dataGridView1.Location = new System.Drawing.Point(79, 151);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(536, 139);
            this.dataGridView1.TabIndex = 167;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // btn录相回放
            // 
            this.btn录相回放.Location = new System.Drawing.Point(393, 470);
            this.btn录相回放.Name = "btn录相回放";
            this.btn录相回放.Size = new System.Drawing.Size(222, 38);
            this.btn录相回放.TabIndex = 168;
            this.btn录相回放.Text = "查看NVR录相回放";
            this.btn录相回放.UseVisualStyleBackColor = true;
            this.btn录相回放.Visible = false;
            this.btn录相回放.Click += new System.EventHandler(this.btn录相回放_Click);
            // 
            // colStudentID
            // 
            this.colStudentID.HeaderText = "准考证号";
            this.colStudentID.Name = "colStudentID";
            this.colStudentID.ReadOnly = true;
            this.colStudentID.Visible = false;
            this.colStudentID.Width = 120;
            // 
            // colFile
            // 
            this.colFile.HeaderText = "视频文件名称";
            this.colFile.Name = "colFile";
            this.colFile.ReadOnly = true;
            this.colFile.Width = 250;
            // 
            // colFileSize
            // 
            this.colFileSize.HeaderText = "文件大小";
            this.colFileSize.Name = "colFileSize";
            this.colFileSize.ReadOnly = true;
            this.colFileSize.Width = 80;
            // 
            // colState
            // 
            this.colState.HeaderText = "上传状态";
            this.colState.Name = "colState";
            this.colState.ReadOnly = true;
            this.colState.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colState.Width = 80;
            // 
            // colCamera
            // 
            this.colCamera.HeaderText = "相机";
            this.colCamera.Name = "colCamera";
            this.colCamera.ReadOnly = true;
            this.colCamera.Width = 80;
            // 
            // colPhysicalItem
            // 
            this.colPhysicalItem.HeaderText = "测试项目";
            this.colPhysicalItem.Name = "colPhysicalItem";
            this.colPhysicalItem.ReadOnly = true;
            this.colPhysicalItem.Visible = false;
            // 
            // col测试时间
            // 
            this.col测试时间.HeaderText = "录像时间";
            this.col测试时间.Name = "col测试时间";
            this.col测试时间.ReadOnly = true;
            this.col测试时间.Width = 130;
            // 
            // colLocalPath
            // 
            this.colLocalPath.HeaderText = "本地路径";
            this.colLocalPath.Name = "colLocalPath";
            this.colLocalPath.ReadOnly = true;
            this.colLocalPath.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colLocalPath.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colFill
            // 
            this.colFill.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colFill.HeaderText = "";
            this.colFill.Name = "colFill";
            this.colFill.ReadOnly = true;
            // 
            // FrmDiscussionDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 600);
            this.Controls.Add(this.btn录相回放);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn确定);
            this.Controls.Add(this.txtPhysicalItem);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtResolveType);
            this.Controls.Add(this.btn生成仲裁报告);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtApprover);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtNewScore);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTestTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmDiscussionDetail";
            this.Text = "成绩仲裁明细";
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtName, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtStudentID, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtScore, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtTestTime, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.txtDescription, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.txtNewScore, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.txtApprover, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.btn生成仲裁报告, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.txtResolveType, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.txtPhysicalItem, 0);
            this.Controls.SetChildIndex(this.btn确定, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.btn录相回放, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private LJH.GeneralLibrary.WinformControl.DBCTextBox txtName;
        private LJH.GeneralLibrary.WinformControl.DBCTextBox txtStudentID;
        private System.Windows.Forms.Label label2;
        private LJH.GeneralLibrary.WinformControl.DBCTextBox txtScore;
        private System.Windows.Forms.Label label4;
        private LJH.GeneralLibrary.WinformControl.DBCTextBox txtTestTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private LJH.GeneralLibrary.WinformControl.DBCTextBox txtDescription;
        private System.Windows.Forms.Label label7;
        private LJH.GeneralLibrary.WinformControl.DBCTextBox txtNewScore;
        private System.Windows.Forms.Label label8;
        private LJH.GeneralLibrary.WinformControl.DBCTextBox txtApprover;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn生成仲裁报告;
        private HH.ZK.CommonUI.Controls.ResolveTypeComboBox txtResolveType;
        private LJH.GeneralLibrary.WinformControl.DBCTextBox txtPhysicalItem;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn确定;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn录相回放;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFileSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn colState;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCamera;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhysicalItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn col测试时间;
        private System.Windows.Forms.DataGridViewLinkColumn colLocalPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFill;
    }
}