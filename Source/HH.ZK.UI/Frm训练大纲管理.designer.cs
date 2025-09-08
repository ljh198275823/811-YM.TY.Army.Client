﻿namespace HH.ZK.UI
{
    partial class Frm训练大纲管理
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm训练大纲管理));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cMnu_Fresh = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.设置训练科目ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置评分标准ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置选项ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.btn_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Export = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Fresh = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_SelectColumns = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.txtKeyword = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.col序号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col简称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col类别 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col创建时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMemo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1.SuspendLayout();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cMnu_Fresh,
            this.toolStripSeparator3,
            this.设置训练科目ToolStripMenuItem,
            this.设置评分标准ToolStripMenuItem,
            this.设置选项ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(163, 98);
            // 
            // cMnu_Fresh
            // 
            this.cMnu_Fresh.Name = "cMnu_Fresh";
            this.cMnu_Fresh.Size = new System.Drawing.Size(162, 22);
            this.cMnu_Fresh.Text = "刷新";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(159, 6);
            // 
            // 设置训练科目ToolStripMenuItem
            // 
            this.设置训练科目ToolStripMenuItem.Name = "设置训练科目ToolStripMenuItem";
            this.设置训练科目ToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.设置训练科目ToolStripMenuItem.Text = "1. 设置训练科目";
            this.设置训练科目ToolStripMenuItem.Click += new System.EventHandler(this.设置训练科目ToolStripMenuItem_Click);
            // 
            // 设置评分标准ToolStripMenuItem
            // 
            this.设置评分标准ToolStripMenuItem.Name = "设置评分标准ToolStripMenuItem";
            this.设置评分标准ToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.设置评分标准ToolStripMenuItem.Text = "2. 设置评分标准";
            this.设置评分标准ToolStripMenuItem.Click += new System.EventHandler(this.设置评分标准ToolStripMenuItem_Click);
            // 
            // 设置选项ToolStripMenuItem
            // 
            this.设置选项ToolStripMenuItem.Name = "设置选项ToolStripMenuItem";
            this.设置选项ToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.设置选项ToolStripMenuItem.Text = "3. 设置选项";
            this.设置选项ToolStripMenuItem.Click += new System.EventHandler(this.设置选项ToolStripMenuItem_Click);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.menu.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Add,
            this.btn_Delete,
            this.btn_Export,
            this.btn_Fresh,
            this.btn_SelectColumns,
            this.toolStripSeparator1,
            this.txtKeyword,
            this.toolStripSeparator2});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(795, 50);
            this.menu.TabIndex = 60;
            // 
            // btn_Add
            // 
            this.btn_Add.Image = global::HH.ZK.UI.Properties.Resources.add;
            this.btn_Add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(62, 46);
            this.btn_Add.Text = "新建(&N)";
            this.btn_Add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Image = global::HH.ZK.UI.Properties.Resources.delete;
            this.btn_Delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(61, 46);
            this.btn_Delete.Text = "删除(&D)";
            this.btn_Delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btn_Export
            // 
            this.btn_Export.Image = global::HH.ZK.UI.Properties.Resources.export;
            this.btn_Export.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(59, 46);
            this.btn_Export.Text = "导出(&E)";
            this.btn_Export.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btn_Fresh
            // 
            this.btn_Fresh.Image = global::HH.ZK.UI.Properties.Resources.refresh;
            this.btn_Fresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Fresh.Name = "btn_Fresh";
            this.btn_Fresh.Size = new System.Drawing.Size(58, 46);
            this.btn_Fresh.Text = "刷新(&F)";
            this.btn_Fresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btn_SelectColumns
            // 
            this.btn_SelectColumns.Image = global::HH.ZK.UI.Properties.Resources.columns;
            this.btn_SelectColumns.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_SelectColumns.Name = "btn_SelectColumns";
            this.btn_SelectColumns.Size = new System.Drawing.Size(70, 46);
            this.btn_SelectColumns.Text = "选择列(&L)";
            this.btn_SelectColumns.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 46);
            // 
            // txtKeyword
            // 
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(200, 46);
            this.txtKeyword.TextChanged += new System.EventHandler(this.txtKeyword_TextChanged);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 46);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeight = 32;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col序号,
            this.colID,
            this.colName,
            this.col简称,
            this.col类别,
            this.col创建时间,
            this.colMemo});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(795, 378);
            this.dataGridView1.TabIndex = 61;
            // 
            // col序号
            // 
            this.col序号.HeaderText = "";
            this.col序号.Name = "col序号";
            this.col序号.ReadOnly = true;
            this.col序号.Width = 40;
            // 
            // colID
            // 
            this.colID.HeaderText = "编号";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            // 
            // colName
            // 
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colName.HeaderText = "名称";
            this.colName.MinimumWidth = 150;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Width = 150;
            // 
            // col简称
            // 
            this.col简称.HeaderText = "简称";
            this.col简称.Name = "col简称";
            this.col简称.ReadOnly = true;
            // 
            // col类别
            // 
            this.col类别.HeaderText = "类别";
            this.col类别.Name = "col类别";
            this.col类别.ReadOnly = true;
            // 
            // col创建时间
            // 
            this.col创建时间.HeaderText = "创建时间";
            this.col创建时间.Name = "col创建时间";
            this.col创建时间.ReadOnly = true;
            this.col创建时间.Width = 150;
            // 
            // colMemo
            // 
            this.colMemo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMemo.HeaderText = "";
            this.colMemo.Name = "colMemo";
            this.colMemo.ReadOnly = true;
            // 
            // Frm训练大纲管理
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm训练大纲管理";
            this.Text = "训练/考核大纲管理";
            this.Controls.SetChildIndex(this.menu, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cMnu_Fresh;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem btn_Add;
        private System.Windows.Forms.ToolStripMenuItem btn_Delete;
        private System.Windows.Forms.ToolStripMenuItem btn_Export;
        private System.Windows.Forms.ToolStripMenuItem btn_Fresh;
        private System.Windows.Forms.ToolStripMenuItem btn_SelectColumns;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox txtKeyword;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem 设置训练科目ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置评分标准ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置选项ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn col序号;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col简称;
        private System.Windows.Forms.DataGridViewTextBoxColumn col类别;
        private System.Windows.Forms.DataGridViewTextBoxColumn col创建时间;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMemo;
    }
}