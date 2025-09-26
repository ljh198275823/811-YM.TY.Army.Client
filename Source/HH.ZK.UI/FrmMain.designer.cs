namespace HH.ZK.UI
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_ChangPwd = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu切换用户 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Logout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu账号管理 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu基础数据 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu人员部门管理 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu训练考核大纲管理 = new System.Windows.Forms.ToolStripMenuItem();
            this.训练计划ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu训练考核计划管理 = new System.Windows.Forms.ToolStripMenuItem();
            this.训练结果ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu训练成绩管理 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu导入成绩 = new System.Windows.Forms.ToolStripMenuItem();
            this.Main_报表 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu总成绩统计报表 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu单项成绩统计报表 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu原始成绩查询 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu_Log = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblOperator = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblState = new System.Windows.Forms.ToolStripStatusLabel();
            this.ucFormViewMain = new LJH.GeneralLibrary.WinformControl.UCFormViewEx();
            this.mainMenu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统ToolStripMenuItem,
            this.mnu基础数据,
            this.训练计划ToolStripMenuItem,
            this.训练结果ToolStripMenuItem,
            this.Main_报表});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(1316, 24);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // 系统ToolStripMenuItem
            // 
            this.系统ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_ChangPwd,
            this.mnu切换用户,
            this.mnu_Logout,
            this.mnu_Exit,
            this.toolStripSeparator1,
            this.mnu账号管理});
            this.系统ToolStripMenuItem.Name = "系统ToolStripMenuItem";
            this.系统ToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.系统ToolStripMenuItem.Text = "系统";
            // 
            // mnu_ChangPwd
            // 
            this.mnu_ChangPwd.Name = "mnu_ChangPwd";
            this.mnu_ChangPwd.Size = new System.Drawing.Size(126, 22);
            this.mnu_ChangPwd.Text = "修改密码";
            this.mnu_ChangPwd.Click += new System.EventHandler(this.mnu_ChangPwd_Click);
            // 
            // mnu切换用户
            // 
            this.mnu切换用户.Name = "mnu切换用户";
            this.mnu切换用户.Size = new System.Drawing.Size(126, 22);
            this.mnu切换用户.Text = "切换用户";
            this.mnu切换用户.Click += new System.EventHandler(this.mnu切换用户_Click);
            // 
            // mnu_Logout
            // 
            this.mnu_Logout.Name = "mnu_Logout";
            this.mnu_Logout.Size = new System.Drawing.Size(126, 22);
            this.mnu_Logout.Text = "注销";
            this.mnu_Logout.Click += new System.EventHandler(this.mnu_Logout_Click);
            // 
            // mnu_Exit
            // 
            this.mnu_Exit.Name = "mnu_Exit";
            this.mnu_Exit.Size = new System.Drawing.Size(126, 22);
            this.mnu_Exit.Text = "退出";
            this.mnu_Exit.Click += new System.EventHandler(this.mnu_Exit_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(123, 6);
            // 
            // mnu账号管理
            // 
            this.mnu账号管理.Name = "mnu账号管理";
            this.mnu账号管理.Size = new System.Drawing.Size(126, 22);
            this.mnu账号管理.Text = "账号管理";
            this.mnu账号管理.Click += new System.EventHandler(this.mnu账号管理_Click);
            // 
            // mnu基础数据
            // 
            this.mnu基础数据.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu人员部门管理,
            this.mnu训练考核大纲管理});
            this.mnu基础数据.Name = "mnu基础数据";
            this.mnu基础数据.Size = new System.Drawing.Size(71, 20);
            this.mnu基础数据.Text = "基础数据";
            // 
            // mnu人员部门管理
            // 
            this.mnu人员部门管理.Name = "mnu人员部门管理";
            this.mnu人员部门管理.Size = new System.Drawing.Size(178, 22);
            this.mnu人员部门管理.Text = "人员部门管理";
            this.mnu人员部门管理.Click += new System.EventHandler(this.mnu人员部门管理_Click);
            // 
            // mnu训练考核大纲管理
            // 
            this.mnu训练考核大纲管理.Name = "mnu训练考核大纲管理";
            this.mnu训练考核大纲管理.Size = new System.Drawing.Size(178, 22);
            this.mnu训练考核大纲管理.Text = "训练考核大纲管理";
            this.mnu训练考核大纲管理.Click += new System.EventHandler(this.mnu训练考核大纲管理_Click);
            // 
            // 训练计划ToolStripMenuItem
            // 
            this.训练计划ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu训练考核计划管理});
            this.训练计划ToolStripMenuItem.Name = "训练计划ToolStripMenuItem";
            this.训练计划ToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.训练计划ToolStripMenuItem.Text = "训练计划";
            // 
            // mnu训练考核计划管理
            // 
            this.mnu训练考核计划管理.Name = "mnu训练考核计划管理";
            this.mnu训练考核计划管理.Size = new System.Drawing.Size(178, 22);
            this.mnu训练考核计划管理.Text = "训练考核计划管理";
            this.mnu训练考核计划管理.Click += new System.EventHandler(this.mnu训练考核计划管理_Click);
            // 
            // 训练结果ToolStripMenuItem
            // 
            this.训练结果ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu训练成绩管理,
            this.mnu导入成绩});
            this.训练结果ToolStripMenuItem.Name = "训练结果ToolStripMenuItem";
            this.训练结果ToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.训练结果ToolStripMenuItem.Text = "训练结果";
            // 
            // mnu训练成绩管理
            // 
            this.mnu训练成绩管理.Name = "mnu训练成绩管理";
            this.mnu训练成绩管理.Size = new System.Drawing.Size(152, 22);
            this.mnu训练成绩管理.Text = "训练成绩管理";
            this.mnu训练成绩管理.Click += new System.EventHandler(this.mmu训练成绩管理_Click);
            // 
            // mnu导入成绩
            // 
            this.mnu导入成绩.Name = "mnu导入成绩";
            this.mnu导入成绩.Size = new System.Drawing.Size(152, 22);
            this.mnu导入成绩.Text = "导入成绩";
            this.mnu导入成绩.Click += new System.EventHandler(this.mnu导入成绩_Click);
            // 
            // Main_报表
            // 
            this.Main_报表.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu总成绩统计报表,
            this.mnu单项成绩统计报表,
            this.mnu原始成绩查询,
            this.toolStripSeparator4,
            this.mnu_Log});
            this.Main_报表.Name = "Main_报表";
            this.Main_报表.Size = new System.Drawing.Size(71, 20);
            this.Main_报表.Text = "统计报表";
            // 
            // mnu总成绩统计报表
            // 
            this.mnu总成绩统计报表.Name = "mnu总成绩统计报表";
            this.mnu总成绩统计报表.Size = new System.Drawing.Size(178, 22);
            this.mnu总成绩统计报表.Text = "总分统计报表";
            this.mnu总成绩统计报表.Click += new System.EventHandler(this.mnu总成绩统计报表_Click);
            // 
            // mnu单项成绩统计报表
            // 
            this.mnu单项成绩统计报表.Name = "mnu单项成绩统计报表";
            this.mnu单项成绩统计报表.Size = new System.Drawing.Size(178, 22);
            this.mnu单项成绩统计报表.Text = "单项成绩统计报表";
            this.mnu单项成绩统计报表.Click += new System.EventHandler(this.mnu单项成绩统计报表_Click);
            // 
            // mnu原始成绩查询
            // 
            this.mnu原始成绩查询.Name = "mnu原始成绩查询";
            this.mnu原始成绩查询.Size = new System.Drawing.Size(178, 22);
            this.mnu原始成绩查询.Text = "人员成绩查询报表";
            this.mnu原始成绩查询.Click += new System.EventHandler(this.mnu学生原始成绩查询_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(175, 6);
            this.toolStripSeparator4.Visible = false;
            // 
            // mnu_Log
            // 
            this.mnu_Log.Name = "mnu_Log";
            this.mnu_Log.Size = new System.Drawing.Size(178, 22);
            this.mnu_Log.Text = "系统日志查询报表";
            this.mnu_Log.Visible = false;
            this.mnu_Log.Click += new System.EventHandler(this.mnu系统日志_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel1,
            this.lblOperator,
            this.lblState});
            this.statusStrip1.Location = new System.Drawing.Point(0, 594);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1316, 27);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 22);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.ForeColor = System.Drawing.Color.Blue;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(0, 22);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(56, 22);
            this.toolStripStatusLabel1.Text = "操作员：";
            // 
            // lblOperator
            // 
            this.lblOperator.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblOperator.Name = "lblOperator";
            this.lblOperator.Size = new System.Drawing.Size(4, 22);
            this.lblOperator.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblState
            // 
            this.lblState.AutoSize = false;
            this.lblState.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.lblState.ForeColor = System.Drawing.Color.Blue;
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(1241, 22);
            this.lblState.Spring = true;
            this.lblState.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ucFormViewMain
            // 
            this.ucFormViewMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucFormViewMain.FormHeaderLength = 135;
            this.ucFormViewMain.Location = new System.Drawing.Point(0, 24);
            this.ucFormViewMain.Name = "ucFormViewMain";
            this.ucFormViewMain.Size = new System.Drawing.Size(1316, 32);
            this.ucFormViewMain.TabIndex = 35;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1316, 621);
            this.Controls.Add(this.ucFormViewMain);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.mainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mainMenu;
            this.Name = "FrmMain";
            this.Text = "AI 军事体能考核总系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem 系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnu_ChangPwd;
        private System.Windows.Forms.ToolStripMenuItem mnu_Logout;
        private System.Windows.Forms.ToolStripMenuItem mnu_Exit;
        private System.Windows.Forms.ToolStripMenuItem Main_报表;
        private System.Windows.Forms.ToolStripMenuItem mnu_Log;
        private System.Windows.Forms.ToolStripMenuItem mnu总成绩统计报表;
        private System.Windows.Forms.ToolStripMenuItem mnu单项成绩统计报表;
        private System.Windows.Forms.ToolStripMenuItem mnu原始成绩查询;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblOperator;
        private System.Windows.Forms.ToolStripStatusLabel lblState;
        private LJH.GeneralLibrary.WinformControl.UCFormViewEx ucFormViewMain;
        private System.Windows.Forms.ToolStripMenuItem mnu切换用户;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem mnu基础数据;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnu账号管理;
        private System.Windows.Forms.ToolStripMenuItem mnu人员部门管理;
        private System.Windows.Forms.ToolStripMenuItem mnu训练考核大纲管理;
        private System.Windows.Forms.ToolStripMenuItem 训练计划ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 训练结果ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnu训练成绩管理;
        private System.Windows.Forms.ToolStripMenuItem mnu导入成绩;
        private System.Windows.Forms.ToolStripMenuItem mnu训练考核计划管理;
    }
}

