namespace HH.ZK.UI
{
    partial class Frm评分标准导入
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm评分标准导入));
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnImport = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.viewDestination = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grpStep2 = new System.Windows.Forms.GroupBox();
            this.pnlMap = new System.Windows.Forms.Panel();
            this.lblDestination = new System.Windows.Forms.Label();
            this.cmbResult = new System.Windows.Forms.ComboBox();
            this.lblArrow = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.第一步 = new System.Windows.Forms.GroupBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.viewSource = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.colSer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbRank = new System.Windows.Forms.ComboBox();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewDestination)).BeginInit();
            this.panel2.SuspendLayout();
            this.grpStep2.SuspendLayout();
            this.pnlMap.SuspendLayout();
            this.panel1.SuspendLayout();
            this.第一步.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(768, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(400, 708);
            this.panel3.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnImport);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.viewDestination);
            this.groupBox2.Location = new System.Drawing.Point(6, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(394, 693);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "第三步";
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(151, 42);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(125, 23);
            this.btnImport.TabIndex = 13;
            this.btnImport.Text = "开始导入";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "待导入数据预览";
            // 
            // viewDestination
            // 
            this.viewDestination.AllowUserToAddRows = false;
            this.viewDestination.AllowUserToDeleteRows = false;
            this.viewDestination.AllowUserToResizeColumns = false;
            this.viewDestination.AllowUserToResizeRows = false;
            this.viewDestination.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewDestination.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewDestination.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSer,
            this.colRank,
            this.colResult});
            this.viewDestination.Location = new System.Drawing.Point(6, 103);
            this.viewDestination.Name = "viewDestination";
            this.viewDestination.ReadOnly = true;
            this.viewDestination.RowHeadersVisible = false;
            this.viewDestination.RowTemplate.Height = 23;
            this.viewDestination.Size = new System.Drawing.Size(382, 584);
            this.viewDestination.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.grpStep2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(485, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(283, 708);
            this.panel2.TabIndex = 4;
            // 
            // grpStep2
            // 
            this.grpStep2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpStep2.Controls.Add(this.pnlMap);
            this.grpStep2.Controls.Add(this.label13);
            this.grpStep2.Controls.Add(this.label11);
            this.grpStep2.Location = new System.Drawing.Point(6, 12);
            this.grpStep2.Name = "grpStep2";
            this.grpStep2.Size = new System.Drawing.Size(274, 693);
            this.grpStep2.TabIndex = 1;
            this.grpStep2.TabStop = false;
            this.grpStep2.Text = "第二步  映射设置";
            // 
            // pnlMap
            // 
            this.pnlMap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMap.AutoScroll = true;
            this.pnlMap.Controls.Add(this.label5);
            this.pnlMap.Controls.Add(this.label4);
            this.pnlMap.Controls.Add(this.cmbRank);
            this.pnlMap.Controls.Add(this.lblDestination);
            this.pnlMap.Controls.Add(this.cmbResult);
            this.pnlMap.Controls.Add(this.lblArrow);
            this.pnlMap.Location = new System.Drawing.Point(7, 103);
            this.pnlMap.Name = "pnlMap";
            this.pnlMap.Size = new System.Drawing.Size(264, 581);
            this.pnlMap.TabIndex = 15;
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Location = new System.Drawing.Point(165, 37);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(59, 12);
            this.lblDestination.TabIndex = 7;
            this.lblDestination.Text = "得    分*";
            // 
            // cmbResult
            // 
            this.cmbResult.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbResult.FormattingEnabled = true;
            this.cmbResult.Location = new System.Drawing.Point(3, 34);
            this.cmbResult.Name = "cmbResult";
            this.cmbResult.Size = new System.Drawing.Size(121, 20);
            this.cmbResult.TabIndex = 5;
            this.cmbResult.Tag = "";
            this.cmbResult.SelectedIndexChanged += new System.EventHandler(this.cmb_SelectedIndexChanged);
            // 
            // lblArrow
            // 
            this.lblArrow.AutoSize = true;
            this.lblArrow.Location = new System.Drawing.Point(132, 37);
            this.lblArrow.Name = "lblArrow";
            this.lblArrow.Size = new System.Drawing.Size(23, 12);
            this.lblArrow.TabIndex = 6;
            this.lblArrow.Text = "-->";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(169, 86);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 14;
            this.label13.Text = "目标字段";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 86);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 12;
            this.label11.Text = "源数据列";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.第一步);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(485, 708);
            this.panel1.TabIndex = 3;
            // 
            // 第一步
            // 
            this.第一步.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.第一步.Controls.Add(this.btnBrowse);
            this.第一步.Controls.Add(this.txtPath);
            this.第一步.Controls.Add(this.label2);
            this.第一步.Controls.Add(this.viewSource);
            this.第一步.Controls.Add(this.label1);
            this.第一步.Location = new System.Drawing.Point(3, 12);
            this.第一步.Name = "第一步";
            this.第一步.Size = new System.Drawing.Size(476, 693);
            this.第一步.TabIndex = 0;
            this.第一步.TabStop = false;
            this.第一步.Text = "第一步  指定数据源";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(385, 43);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(76, 23);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Text = "浏览...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtPath
            // 
            this.txtPath.Enabled = false;
            this.txtPath.Location = new System.Drawing.Point(11, 44);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(368, 21);
            this.txtPath.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "数据源预览";
            // 
            // viewSource
            // 
            this.viewSource.AllowUserToAddRows = false;
            this.viewSource.AllowUserToDeleteRows = false;
            this.viewSource.AllowUserToResizeColumns = false;
            this.viewSource.AllowUserToResizeRows = false;
            this.viewSource.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewSource.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewSource.Location = new System.Drawing.Point(4, 103);
            this.viewSource.Name = "viewSource";
            this.viewSource.ReadOnly = true;
            this.viewSource.RowHeadersVisible = false;
            this.viewSource.RowTemplate.Height = 23;
            this.viewSource.Size = new System.Drawing.Size(466, 584);
            this.viewSource.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "数据源文件";
            // 
            // colSer
            // 
            this.colSer.HeaderText = "";
            this.colSer.Name = "colSer";
            this.colSer.ReadOnly = true;
            this.colSer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colSer.Width = 40;
            // 
            // colRank
            // 
            this.colRank.HeaderText = "等级";
            this.colRank.Name = "colRank";
            this.colRank.ReadOnly = true;
            // 
            // colResult
            // 
            this.colResult.HeaderText = "得分";
            this.colResult.Name = "colResult";
            this.colResult.ReadOnly = true;
            this.colResult.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colResult.Width = 60;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(165, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "等    级";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(132, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "-->";
            // 
            // cmbRank
            // 
            this.cmbRank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRank.FormattingEnabled = true;
            this.cmbRank.Location = new System.Drawing.Point(3, 5);
            this.cmbRank.Name = "cmbRank";
            this.cmbRank.Size = new System.Drawing.Size(121, 20);
            this.cmbRank.TabIndex = 8;
            this.cmbRank.Tag = "colRank";
            this.cmbRank.SelectedIndexChanged += new System.EventHandler(this.cmb_SelectedIndexChanged);
            // 
            // Frm评分标准导入
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 708);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm评分标准导入";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "评分标准导入";
            this.Load += new System.EventHandler(this.FrmStandardImport_Load);
            this.panel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewDestination)).EndInit();
            this.panel2.ResumeLayout(false);
            this.grpStep2.ResumeLayout(false);
            this.grpStep2.PerformLayout();
            this.pnlMap.ResumeLayout(false);
            this.pnlMap.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.第一步.ResumeLayout(false);
            this.第一步.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView viewDestination;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox grpStep2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.Label lblArrow;
        private System.Windows.Forms.ComboBox cmbResult;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox 第一步;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView viewSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlMap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRank;
        private System.Windows.Forms.DataGridViewTextBoxColumn colResult;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbRank;
    }
}