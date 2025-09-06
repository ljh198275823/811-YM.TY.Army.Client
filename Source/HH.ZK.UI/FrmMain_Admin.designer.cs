namespace HH.ZK.UI
{
    partial class FrmMain_Admin
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain_Admin));
            this.mainToolBar = new System.Windows.Forms.ToolStrip();
            this.btn_PhysicalItemSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Standard = new System.Windows.Forms.ToolStripMenuItem();
            this.btn特殊评分标准 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu特殊情况设置 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator19 = new System.Windows.Forms.ToolStripSeparator();
            this.btn考点管理 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn账号管理 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btn系统参数 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btn小程序参数 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu_Logout = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblOperator = new System.Windows.Forms.ToolStripStatusLabel();
            this.lnk当前学校 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblShool = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblState = new System.Windows.Forms.ToolStripStatusLabel();
            this.ucFormViewMain = new LJH.GeneralLibrary.WinformControl.UCFormViewEx();
            this.mainToolBar.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainToolBar
            // 
            this.mainToolBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.mainToolBar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mainToolBar.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.mainToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_PhysicalItemSelect,
            this.btn_Standard,
            this.btn特殊评分标准,
            this.toolStripSeparator2,
            this.mnu特殊情况设置,
            this.toolStripSeparator19,
            this.btn考点管理,
            this.toolStripSeparator1,
            this.btn账号管理,
            this.toolStripSeparator3,
            this.btn系统参数,
            this.toolStripSeparator4,
            this.btn小程序参数,
            this.toolStripSeparator5,
            this.mnu_Logout});
            this.mainToolBar.Location = new System.Drawing.Point(0, 0);
            this.mainToolBar.Name = "mainToolBar";
            this.mainToolBar.ShowItemToolTips = false;
            this.mainToolBar.Size = new System.Drawing.Size(1024, 25);
            this.mainToolBar.TabIndex = 1;
            this.mainToolBar.Text = "学生管理";
            // 
            // btn_PhysicalItemSelect
            // 
            this.btn_PhysicalItemSelect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_PhysicalItemSelect.Name = "btn_PhysicalItemSelect";
            this.btn_PhysicalItemSelect.Size = new System.Drawing.Size(71, 25);
            this.btn_PhysicalItemSelect.Text = "考试科目";
            this.btn_PhysicalItemSelect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_PhysicalItemSelect.Click += new System.EventHandler(this.btn_PhysicalItemSelect_Click);
            // 
            // btn_Standard
            // 
            this.btn_Standard.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Standard.Name = "btn_Standard";
            this.btn_Standard.Size = new System.Drawing.Size(71, 25);
            this.btn_Standard.Text = "评分标准";
            this.btn_Standard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Standard.Click += new System.EventHandler(this.btn_Standard_Click);
            // 
            // btn特殊评分标准
            // 
            this.btn特殊评分标准.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn特殊评分标准.Name = "btn特殊评分标准";
            this.btn特殊评分标准.Size = new System.Drawing.Size(71, 25);
            this.btn特殊评分标准.Text = "特殊评分";
            this.btn特殊评分标准.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn特殊评分标准.Click += new System.EventHandler(this.btn特殊评分标准_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // mnu特殊情况设置
            // 
            this.mnu特殊情况设置.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnu特殊情况设置.Name = "mnu特殊情况设置";
            this.mnu特殊情况设置.Size = new System.Drawing.Size(97, 25);
            this.mnu特殊情况设置.Text = "特殊情况设置";
            this.mnu特殊情况设置.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.mnu特殊情况设置.Click += new System.EventHandler(this.mnu特殊情况设置_Click);
            // 
            // toolStripSeparator19
            // 
            this.toolStripSeparator19.Name = "toolStripSeparator19";
            this.toolStripSeparator19.Size = new System.Drawing.Size(6, 25);
            // 
            // btn考点管理
            // 
            this.btn考点管理.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn考点管理.Name = "btn考点管理";
            this.btn考点管理.Size = new System.Drawing.Size(71, 25);
            this.btn考点管理.Text = "考点管理";
            this.btn考点管理.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn考点管理.Click += new System.EventHandler(this.btn考点管理_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btn账号管理
            // 
            this.btn账号管理.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn账号管理.Name = "btn账号管理";
            this.btn账号管理.Size = new System.Drawing.Size(71, 25);
            this.btn账号管理.Text = "账号管理";
            this.btn账号管理.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn账号管理.Click += new System.EventHandler(this.btn账号管理_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btn系统参数
            // 
            this.btn系统参数.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn系统参数.Name = "btn系统参数";
            this.btn系统参数.Size = new System.Drawing.Size(71, 25);
            this.btn系统参数.Text = "系统参数";
            this.btn系统参数.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn系统参数.Click += new System.EventHandler(this.btn系统参数_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // btn小程序参数
            // 
            this.btn小程序参数.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn小程序参数.Name = "btn小程序参数";
            this.btn小程序参数.Size = new System.Drawing.Size(84, 25);
            this.btn小程序参数.Text = "小程序参数";
            this.btn小程序参数.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn小程序参数.Click += new System.EventHandler(this.btn小程序参数_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // mnu_Logout
            // 
            this.mnu_Logout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnu_Logout.Name = "mnu_Logout";
            this.mnu_Logout.Size = new System.Drawing.Size(45, 25);
            this.mnu_Logout.Text = "注销";
            this.mnu_Logout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.mnu_Logout.Click += new System.EventHandler(this.mnu_Logout_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel1,
            this.lblOperator,
            this.lnk当前学校,
            this.lblShool,
            this.lblState});
            this.statusStrip1.Location = new System.Drawing.Point(0, 464);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1024, 23);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 18);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.ForeColor = System.Drawing.Color.Blue;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(0, 18);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(56, 18);
            this.toolStripStatusLabel1.Text = "操作员：";
            // 
            // lblOperator
            // 
            this.lblOperator.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblOperator.Name = "lblOperator";
            this.lblOperator.Size = new System.Drawing.Size(4, 18);
            this.lblOperator.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lnk当前学校
            // 
            this.lnk当前学校.AutoSize = false;
            this.lnk当前学校.ForeColor = System.Drawing.Color.Black;
            this.lnk当前学校.IsLink = true;
            this.lnk当前学校.Name = "lnk当前学校";
            this.lnk当前学校.Size = new System.Drawing.Size(100, 18);
            this.lnk当前学校.Text = "当前客户：";
            this.lnk当前学校.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lnk当前学校.Click += new System.EventHandler(this.lnk当前学校_Click);
            // 
            // lblShool
            // 
            this.lblShool.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblShool.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblShool.ForeColor = System.Drawing.Color.Black;
            this.lblShool.Name = "lblShool";
            this.lblShool.Size = new System.Drawing.Size(4, 18);
            // 
            // lblState
            // 
            this.lblState.AutoSize = false;
            this.lblState.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.lblState.ForeColor = System.Drawing.Color.Blue;
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(814, 18);
            this.lblState.Spring = true;
            this.lblState.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ucFormViewMain
            // 
            this.ucFormViewMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucFormViewMain.FormHeaderLength = 135;
            this.ucFormViewMain.Location = new System.Drawing.Point(0, 25);
            this.ucFormViewMain.Name = "ucFormViewMain";
            this.ucFormViewMain.Size = new System.Drawing.Size(1024, 32);
            this.ucFormViewMain.TabIndex = 35;
            // 
            // FrmMain_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 487);
            this.Controls.Add(this.ucFormViewMain);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.mainToolBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "FrmMain_Admin";
            this.Text = "部队软件客户端";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_Admin_FormClosed);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.mainToolBar.ResumeLayout(false);
            this.mainToolBar.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip mainToolBar;
        private System.Windows.Forms.ToolStripMenuItem btn_PhysicalItemSelect;
        private System.Windows.Forms.ToolStripMenuItem btn_Standard;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator19;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblOperator;
        private System.Windows.Forms.ToolStripStatusLabel lnk当前学校;
        private System.Windows.Forms.ToolStripStatusLabel lblShool;
        private System.Windows.Forms.ToolStripStatusLabel lblState;
        private LJH.GeneralLibrary.WinformControl.UCFormViewEx ucFormViewMain;
        private System.Windows.Forms.ToolStripMenuItem btn考点管理;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem btn账号管理;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem btn系统参数;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem mnu_Logout;
        private System.Windows.Forms.ToolStripMenuItem btn特殊评分标准;
        private System.Windows.Forms.ToolStripMenuItem mnu特殊情况设置;
        private System.Windows.Forms.ToolStripMenuItem btn小程序参数;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    }
}

