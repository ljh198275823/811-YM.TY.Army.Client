namespace HH.ZK.CommonUI
{
    partial class FrmDivisionMaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDivisionMaster));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cMnu_Fresh = new System.Windows.Forms.ToolStripMenuItem();
            this.cMnu_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.cMnu_Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.cMnu_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.cMnu_Export = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn刷新 = new System.Windows.Forms.Button();
            this.btn新建 = new System.Windows.Forms.Button();
            this.txtKey = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.col序号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colParent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cMnu_Fresh,
            this.cMnu_Add,
            this.cMnu_Edit,
            this.cMnu_Delete,
            this.cMnu_Export});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(110, 114);
            // 
            // cMnu_Fresh
            // 
            this.cMnu_Fresh.Name = "cMnu_Fresh";
            this.cMnu_Fresh.Size = new System.Drawing.Size(109, 22);
            this.cMnu_Fresh.Text = "刷新";
            // 
            // cMnu_Add
            // 
            this.cMnu_Add.Name = "cMnu_Add";
            this.cMnu_Add.Size = new System.Drawing.Size(109, 22);
            this.cMnu_Add.Text = "新建";
            // 
            // cMnu_Edit
            // 
            this.cMnu_Edit.Name = "cMnu_Edit";
            this.cMnu_Edit.Size = new System.Drawing.Size(109, 22);
            this.cMnu_Edit.Text = "编辑";
            // 
            // cMnu_Delete
            // 
            this.cMnu_Delete.Name = "cMnu_Delete";
            this.cMnu_Delete.Size = new System.Drawing.Size(109, 22);
            this.cMnu_Delete.Text = "删除";
            // 
            // cMnu_Export
            // 
            this.cMnu_Export.Name = "cMnu_Export";
            this.cMnu_Export.Size = new System.Drawing.Size(109, 22);
            this.cMnu_Export.Text = "导出...";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn刷新);
            this.panel1.Controls.Add(this.btn新建);
            this.panel1.Controls.Add(this.txtKey);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 61);
            this.panel1.TabIndex = 66;
            // 
            // btn刷新
            // 
            this.btn刷新.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn刷新.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn刷新.Location = new System.Drawing.Point(483, 9);
            this.btn刷新.Name = "btn刷新";
            this.btn刷新.Size = new System.Drawing.Size(139, 43);
            this.btn刷新.TabIndex = 250;
            this.btn刷新.Text = "刷  新";
            this.btn刷新.UseVisualStyleBackColor = false;
            this.btn刷新.Click += new System.EventHandler(this.btn刷新_Click);
            // 
            // btn新建
            // 
            this.btn新建.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn新建.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn新建.Location = new System.Drawing.Point(638, 9);
            this.btn新建.Name = "btn新建";
            this.btn新建.Size = new System.Drawing.Size(139, 43);
            this.btn新建.TabIndex = 249;
            this.btn新建.Text = "新  建";
            this.btn新建.UseVisualStyleBackColor = false;
            this.btn新建.Click += new System.EventHandler(this.btn新建_Click);
            // 
            // txtKey
            // 
            this.txtKey.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtKey.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtKey.Location = new System.Drawing.Point(76, 14);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(270, 30);
            this.txtKey.TabIndex = 185;
            this.txtKey.TextChanged += new System.EventHandler(this.txtKey_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 183;
            this.label1.Text = "模糊查询";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col序号,
            this.colParent,
            this.colName});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(803, 296);
            this.dataGridView1.TabIndex = 67;
            // 
            // col序号
            // 
            this.col序号.HeaderText = "";
            this.col序号.Name = "col序号";
            this.col序号.ReadOnly = true;
            this.col序号.Width = 40;
            // 
            // colParent
            // 
            this.colParent.HeaderText = "上级区域";
            this.colParent.Name = "colParent";
            this.colParent.ReadOnly = true;
            this.colParent.Width = 200;
            // 
            // colName
            // 
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colName.HeaderText = "名称";
            this.colName.MinimumWidth = 100;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // FrmDivisionMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 379);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDivisionMaster";
            this.Text = "区域管理";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cMnu_Fresh;
        private System.Windows.Forms.ToolStripMenuItem cMnu_Add;
        private System.Windows.Forms.ToolStripMenuItem cMnu_Delete;
        private System.Windows.Forms.ToolStripMenuItem cMnu_Export;
        private System.Windows.Forms.ToolStripMenuItem cMnu_Edit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn刷新;
        private System.Windows.Forms.Button btn新建;
        private LJH.GeneralLibrary.WinformControl.DBCTextBox txtKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col序号;
        private System.Windows.Forms.DataGridViewTextBoxColumn colParent;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
    }
}