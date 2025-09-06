namespace HH.ZK.UI
{
    partial class FrmCertificatePrinter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCertificatePrinter));
            this.dataGridview1 = new System.Windows.Forms.DataGridView();
            this.colFacility = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col考试科目 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGroupID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMemo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblMSG = new System.Windows.Forms.Label();
            this.btnExportPdf = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            this.ucStudentSearch1 = new HH.ZK.CommonUI.Controls.UCStudentSearch();
            this.lnk考试科目 = new System.Windows.Forms.LinkLabel();
            this.txt考试科目 = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.rdHasPhoto = new System.Windows.Forms.RadioButton();
            this.rdNonePhoto = new System.Windows.Forms.RadioButton();
            this.rdPhotoAll = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.chk缓考 = new System.Windows.Forms.CheckBox();
            this.chk择考 = new System.Windows.Forms.CheckBox();
            this.chk正常考试 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chk任意一项 = new System.Windows.Forms.CheckBox();
            this.btnAll = new System.Windows.Forms.Button();
            this.lbl选择数量 = new System.Windows.Forms.Label();
            this.btnNone = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridview1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridview1
            // 
            this.dataGridview1.AllowUserToAddRows = false;
            this.dataGridview1.AllowUserToDeleteRows = false;
            this.dataGridview1.AllowUserToResizeRows = false;
            resources.ApplyResources(this.dataGridview1, "dataGridview1");
            this.dataGridview1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridview1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridview1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFacility,
            this.colID,
            this.colName,
            this.colSex,
            this.col考试科目,
            this.colClassName,
            this.colGroupID,
            this.colMemo});
            this.dataGridview1.Name = "dataGridview1";
            this.dataGridview1.RowHeadersVisible = false;
            this.dataGridview1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("宋体", 10.5F);
            this.dataGridview1.RowTemplate.Height = 30;
            this.dataGridview1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridview1.SelectionChanged += new System.EventHandler(this.dataGridview1_SelectionChanged);
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
            // col考试科目
            // 
            this.col考试科目.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            resources.ApplyResources(this.col考试科目, "col考试科目");
            this.col考试科目.Name = "col考试科目";
            this.col考试科目.ReadOnly = true;
            // 
            // colClassName
            // 
            this.colClassName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            resources.ApplyResources(this.colClassName, "colClassName");
            this.colClassName.Name = "colClassName";
            this.colClassName.ReadOnly = true;
            // 
            // colGroupID
            // 
            this.colGroupID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            resources.ApplyResources(this.colGroupID, "colGroupID");
            this.colGroupID.Name = "colGroupID";
            this.colGroupID.ReadOnly = true;
            // 
            // colMemo
            // 
            this.colMemo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.colMemo, "colMemo");
            this.colMemo.Name = "colMemo";
            this.colMemo.ReadOnly = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            resources.ApplyResources(this.toolStripStatusLabel1, "toolStripStatusLabel1");
            this.toolStripStatusLabel1.Spring = true;
            // 
            // lblMSG
            // 
            resources.ApplyResources(this.lblMSG, "lblMSG");
            this.lblMSG.ForeColor = System.Drawing.Color.Blue;
            this.lblMSG.Name = "lblMSG";
            // 
            // btnExportPdf
            // 
            resources.ApplyResources(this.btnExportPdf, "btnExportPdf");
            this.btnExportPdf.Name = "btnExportPdf";
            this.btnExportPdf.UseVisualStyleBackColor = true;
            this.btnExportPdf.Click += new System.EventHandler(this.btnExportPdf_Click);
            // 
            // btnQuery
            // 
            resources.ApplyResources(this.btnQuery, "btnQuery");
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // ucStudentSearch1
            // 
            resources.ApplyResources(this.ucStudentSearch1, "ucStudentSearch1");
            this.ucStudentSearch1.Name = "ucStudentSearch1";
            // 
            // lnk考试科目
            // 
            resources.ApplyResources(this.lnk考试科目, "lnk考试科目");
            this.lnk考试科目.Name = "lnk考试科目";
            this.lnk考试科目.TabStop = true;
            this.lnk考试科目.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk考试科目_LinkClicked);
            // 
            // txt考试科目
            // 
            this.txt考试科目.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.txt考试科目, "txt考试科目");
            this.txt考试科目.Name = "txt考试科目";
            this.txt考试科目.ReadOnly = true;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.rdHasPhoto);
            this.panel5.Controls.Add(this.rdNonePhoto);
            this.panel5.Controls.Add(this.rdPhotoAll);
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.Name = "panel5";
            // 
            // rdHasPhoto
            // 
            resources.ApplyResources(this.rdHasPhoto, "rdHasPhoto");
            this.rdHasPhoto.Name = "rdHasPhoto";
            this.rdHasPhoto.UseVisualStyleBackColor = true;
            // 
            // rdNonePhoto
            // 
            resources.ApplyResources(this.rdNonePhoto, "rdNonePhoto");
            this.rdNonePhoto.Name = "rdNonePhoto";
            this.rdNonePhoto.UseVisualStyleBackColor = true;
            // 
            // rdPhotoAll
            // 
            resources.ApplyResources(this.rdPhotoAll, "rdPhotoAll");
            this.rdPhotoAll.Checked = true;
            this.rdPhotoAll.Name = "rdPhotoAll";
            this.rdPhotoAll.TabStop = true;
            this.rdPhotoAll.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // chk缓考
            // 
            resources.ApplyResources(this.chk缓考, "chk缓考");
            this.chk缓考.Name = "chk缓考";
            this.chk缓考.UseVisualStyleBackColor = true;
            // 
            // chk择考
            // 
            resources.ApplyResources(this.chk择考, "chk择考");
            this.chk择考.Checked = true;
            this.chk择考.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk择考.Name = "chk择考";
            this.chk择考.UseVisualStyleBackColor = true;
            // 
            // chk正常考试
            // 
            resources.ApplyResources(this.chk正常考试, "chk正常考试");
            this.chk正常考试.Checked = true;
            this.chk正常考试.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk正常考试.Name = "chk正常考试";
            this.chk正常考试.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // chk任意一项
            // 
            resources.ApplyResources(this.chk任意一项, "chk任意一项");
            this.chk任意一项.Name = "chk任意一项";
            this.chk任意一项.UseVisualStyleBackColor = true;
            // 
            // btnAll
            // 
            resources.ApplyResources(this.btnAll, "btnAll");
            this.btnAll.Name = "btnAll";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // lbl选择数量
            // 
            resources.ApplyResources(this.lbl选择数量, "lbl选择数量");
            this.lbl选择数量.ForeColor = System.Drawing.Color.Blue;
            this.lbl选择数量.Name = "lbl选择数量";
            // 
            // btnNone
            // 
            resources.ApplyResources(this.btnNone, "btnNone");
            this.btnNone.Name = "btnNone";
            this.btnNone.UseVisualStyleBackColor = true;
            this.btnNone.Click += new System.EventHandler(this.btnNone_Click);
            // 
            // FrmCertificatePrinter
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.lbl选择数量);
            this.Controls.Add(this.btnNone);
            this.Controls.Add(this.chk任意一项);
            this.Controls.Add(this.chk缓考);
            this.Controls.Add(this.chk择考);
            this.Controls.Add(this.chk正常考试);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lnk考试科目);
            this.Controls.Add(this.txt考试科目);
            this.Controls.Add(this.ucStudentSearch1);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.btnExportPdf);
            this.Controls.Add(this.lblMSG);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dataGridview1);
            this.Name = "FrmCertificatePrinter";
            this.Load += new System.EventHandler(this.FrmCertificatePrinter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridview1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridview1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label lblMSG;
        private System.Windows.Forms.Button btnExportPdf;
        private System.Windows.Forms.Button btnQuery;
        private CommonUI.Controls.UCStudentSearch ucStudentSearch1;
        private System.Windows.Forms.LinkLabel lnk考试科目;
        private LJH.GeneralLibrary.WinformControl.DBCTextBox txt考试科目;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RadioButton rdHasPhoto;
        private System.Windows.Forms.RadioButton rdNonePhoto;
        private System.Windows.Forms.RadioButton rdPhotoAll;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chk缓考;
        private System.Windows.Forms.CheckBox chk择考;
        private System.Windows.Forms.CheckBox chk正常考试;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chk任意一项;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFacility;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn col考试科目;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGroupID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMemo;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Label lbl选择数量;
        private System.Windows.Forms.Button btnNone;
    }
}