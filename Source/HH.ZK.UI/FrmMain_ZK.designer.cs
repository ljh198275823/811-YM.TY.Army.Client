namespace HH.ZK.UI
{
    partial class FrmMain_ZK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain_ZK));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_ChangPwd = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu切换用户 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Logout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.账号管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.训练考核大ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Main_报表 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu学生原始成绩查询 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator20 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu重复成绩 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu人工修改成绩查询报表 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu学生成绩仲裁记录报表 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator18 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu总成绩统计报表 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu单项成绩统计报表 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu_Log = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用户手册ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu软件更新日志 = new System.Windows.Forms.ToolStripMenuItem();
            this.mainToolBar = new System.Windows.Forms.ToolStrip();
            this.btn学生信息 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu导入学生 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.btn成绩管理 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Collect = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu导出成绩 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn考场进度 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn考试视频 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn自动打印成绩 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn学生成绩单 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.btn单项成绩 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu仲裁报表 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn总成绩统计报表 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn单项统计报表 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblOperator = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblState = new System.Windows.Forms.ToolStripStatusLabel();
            this.ucFormViewMain = new LJH.GeneralLibrary.WinformControl.UCFormViewEx();
            this.mainMenu.SuspendLayout();
            this.mainToolBar.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统ToolStripMenuItem,
            this.账号管理ToolStripMenuItem,
            this.训练考核大ToolStripMenuItem,
            this.Main_报表,
            this.帮助ToolStripMenuItem});
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
            this.mnu_Exit});
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
            // 账号管理ToolStripMenuItem
            // 
            this.账号管理ToolStripMenuItem.Name = "账号管理ToolStripMenuItem";
            this.账号管理ToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.账号管理ToolStripMenuItem.Text = "账号管理";
            // 
            // 训练考核大ToolStripMenuItem
            // 
            this.训练考核大ToolStripMenuItem.Name = "训练考核大ToolStripMenuItem";
            this.训练考核大ToolStripMenuItem.Size = new System.Drawing.Size(128, 20);
            this.训练考核大ToolStripMenuItem.Text = "训练/考核大纲管理";
            this.训练考核大ToolStripMenuItem.Click += new System.EventHandler(this.训练考核大ToolStripMenuItem_Click);
            // 
            // Main_报表
            // 
            this.Main_报表.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu学生原始成绩查询,
            this.toolStripSeparator20,
            this.mnu重复成绩,
            this.mnu人工修改成绩查询报表,
            this.mnu学生成绩仲裁记录报表,
            this.toolStripSeparator18,
            this.mnu总成绩统计报表,
            this.mnu单项成绩统计报表,
            this.toolStripSeparator4,
            this.mnu_Log});
            this.Main_报表.Name = "Main_报表";
            this.Main_报表.Size = new System.Drawing.Size(45, 20);
            this.Main_报表.Text = "报表";
            // 
            // mnu学生原始成绩查询
            // 
            this.mnu学生原始成绩查询.Name = "mnu学生原始成绩查询";
            this.mnu学生原始成绩查询.Size = new System.Drawing.Size(204, 22);
            this.mnu学生原始成绩查询.Text = "学生成绩查询报表";
            this.mnu学生原始成绩查询.Click += new System.EventHandler(this.mnu学生原始成绩查询_Click);
            // 
            // toolStripSeparator20
            // 
            this.toolStripSeparator20.Name = "toolStripSeparator20";
            this.toolStripSeparator20.Size = new System.Drawing.Size(201, 6);
            // 
            // mnu重复成绩
            // 
            this.mnu重复成绩.Name = "mnu重复成绩";
            this.mnu重复成绩.Size = new System.Drawing.Size(204, 22);
            this.mnu重复成绩.Text = "违规考试查询报表";
            this.mnu重复成绩.Click += new System.EventHandler(this.mnu重复成绩_Click);
            // 
            // mnu人工修改成绩查询报表
            // 
            this.mnu人工修改成绩查询报表.Name = "mnu人工修改成绩查询报表";
            this.mnu人工修改成绩查询报表.Size = new System.Drawing.Size(204, 22);
            this.mnu人工修改成绩查询报表.Text = "人工修改成绩查询报表";
            this.mnu人工修改成绩查询报表.Click += new System.EventHandler(this.mnu人工修改成绩查询报表_Click);
            // 
            // mnu学生成绩仲裁记录报表
            // 
            this.mnu学生成绩仲裁记录报表.Name = "mnu学生成绩仲裁记录报表";
            this.mnu学生成绩仲裁记录报表.Size = new System.Drawing.Size(204, 22);
            this.mnu学生成绩仲裁记录报表.Text = "成绩仲裁查询报表";
            this.mnu学生成绩仲裁记录报表.Click += new System.EventHandler(this.mnu学生成绩仲裁记录报表_Click);
            // 
            // toolStripSeparator18
            // 
            this.toolStripSeparator18.Name = "toolStripSeparator18";
            this.toolStripSeparator18.Size = new System.Drawing.Size(201, 6);
            // 
            // mnu总成绩统计报表
            // 
            this.mnu总成绩统计报表.Name = "mnu总成绩统计报表";
            this.mnu总成绩统计报表.Size = new System.Drawing.Size(204, 22);
            this.mnu总成绩统计报表.Text = "总分统计报表";
            this.mnu总成绩统计报表.Click += new System.EventHandler(this.mnu总成绩统计报表_Click);
            // 
            // mnu单项成绩统计报表
            // 
            this.mnu单项成绩统计报表.Name = "mnu单项成绩统计报表";
            this.mnu单项成绩统计报表.Size = new System.Drawing.Size(204, 22);
            this.mnu单项成绩统计报表.Text = "单项成绩统计报表";
            this.mnu单项成绩统计报表.Click += new System.EventHandler(this.mnu单项成绩统计报表_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(201, 6);
            this.toolStripSeparator4.Visible = false;
            // 
            // mnu_Log
            // 
            this.mnu_Log.Name = "mnu_Log";
            this.mnu_Log.Size = new System.Drawing.Size(204, 22);
            this.mnu_Log.Text = "系统日志查询报表";
            this.mnu_Log.Visible = false;
            this.mnu_Log.Click += new System.EventHandler(this.mnu系统日志_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.用户手册ToolStripMenuItem,
            this.mnu软件更新日志});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 用户手册ToolStripMenuItem
            // 
            this.用户手册ToolStripMenuItem.Name = "用户手册ToolStripMenuItem";
            this.用户手册ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.用户手册ToolStripMenuItem.Text = "用户手册";
            this.用户手册ToolStripMenuItem.Click += new System.EventHandler(this.用户手册ToolStripMenuItem_Click);
            // 
            // mnu软件更新日志
            // 
            this.mnu软件更新日志.Name = "mnu软件更新日志";
            this.mnu软件更新日志.Size = new System.Drawing.Size(152, 22);
            this.mnu软件更新日志.Text = "软件更新日志";
            this.mnu软件更新日志.Click += new System.EventHandler(this.mnu软件更新日志_Click);
            // 
            // mainToolBar
            // 
            this.mainToolBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.mainToolBar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mainToolBar.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.mainToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn学生信息,
            this.mnu导入学生,
            this.toolStripSeparator8,
            this.btn成绩管理,
            this.btn_Collect,
            this.mnu导出成绩,
            this.btn考场进度,
            this.btn考试视频,
            this.btn自动打印成绩,
            this.btn学生成绩单,
            this.toolStripSeparator13,
            this.btn单项成绩,
            this.mnu仲裁报表,
            this.btn总成绩统计报表,
            this.btn单项统计报表,
            this.toolStripSeparator14});
            this.mainToolBar.Location = new System.Drawing.Point(0, 24);
            this.mainToolBar.Name = "mainToolBar";
            this.mainToolBar.ShowItemToolTips = false;
            this.mainToolBar.Size = new System.Drawing.Size(1316, 51);
            this.mainToolBar.TabIndex = 1;
            this.mainToolBar.Text = "学生管理";
            // 
            // btn学生信息
            // 
            this.btn学生信息.Image = global::HH.ZK.UI.Properties.Resources.Operator;
            this.btn学生信息.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn学生信息.Name = "btn学生信息";
            this.btn学生信息.Size = new System.Drawing.Size(97, 51);
            this.btn学生信息.Text = "人员部门信息";
            this.btn学生信息.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn学生信息.Click += new System.EventHandler(this.btn学生信息_Click);
            // 
            // mnu导入学生
            // 
            this.mnu导入学生.Image = global::HH.ZK.UI.Properties.Resources.import;
            this.mnu导入学生.Name = "mnu导入学生";
            this.mnu导入学生.Size = new System.Drawing.Size(71, 51);
            this.mnu导入学生.Text = "导入人员";
            this.mnu导入学生.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.mnu导入学生.Click += new System.EventHandler(this.mnu导入学生_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 51);
            // 
            // btn成绩管理
            // 
            this.btn成绩管理.Image = global::HH.ZK.UI.Properties.Resources.statistics;
            this.btn成绩管理.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn成绩管理.Name = "btn成绩管理";
            this.btn成绩管理.Size = new System.Drawing.Size(71, 51);
            this.btn成绩管理.Text = "成绩管理";
            this.btn成绩管理.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btn_Collect
            // 
            this.btn_Collect.Image = global::HH.ZK.UI.Properties.Resources.wireless;
            this.btn_Collect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Collect.Name = "btn_Collect";
            this.btn_Collect.Size = new System.Drawing.Size(71, 51);
            this.btn_Collect.Text = "成绩采集";
            this.btn_Collect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // mnu导出成绩
            // 
            this.mnu导出成绩.Image = global::HH.ZK.UI.Properties.Resources.columns;
            this.mnu导出成绩.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnu导出成绩.Name = "mnu导出成绩";
            this.mnu导出成绩.Size = new System.Drawing.Size(71, 51);
            this.mnu导出成绩.Text = "导出成绩";
            this.mnu导出成绩.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.mnu导出成绩.Click += new System.EventHandler(this.mnu导出成绩_Click);
            // 
            // btn考场进度
            // 
            this.btn考场进度.Image = global::HH.ZK.UI.Properties.Resources.monitor;
            this.btn考场进度.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn考场进度.Name = "btn考场进度";
            this.btn考场进度.Size = new System.Drawing.Size(71, 51);
            this.btn考场进度.Text = "考场进度";
            this.btn考场进度.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn考场进度.Visible = false;
            // 
            // btn考试视频
            // 
            this.btn考试视频.Image = global::HH.ZK.UI.Properties.Resources.video;
            this.btn考试视频.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn考试视频.Name = "btn考试视频";
            this.btn考试视频.Size = new System.Drawing.Size(71, 51);
            this.btn考试视频.Text = "考试视频";
            this.btn考试视频.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn考试视频.Click += new System.EventHandler(this.btn考试视频_Click);
            // 
            // btn自动打印成绩
            // 
            this.btn自动打印成绩.Image = global::HH.ZK.UI.Properties.Resources.Print;
            this.btn自动打印成绩.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn自动打印成绩.Name = "btn自动打印成绩";
            this.btn自动打印成绩.Size = new System.Drawing.Size(71, 51);
            this.btn自动打印成绩.Text = "实时打印";
            this.btn自动打印成绩.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btn学生成绩单
            // 
            this.btn学生成绩单.Image = global::HH.ZK.UI.Properties.Resources.columns;
            this.btn学生成绩单.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn学生成绩单.Name = "btn学生成绩单";
            this.btn学生成绩单.Size = new System.Drawing.Size(58, 51);
            this.btn学生成绩单.Text = "成绩单";
            this.btn学生成绩单.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn学生成绩单.Click += new System.EventHandler(this.btn学生成绩单_Click);
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(6, 51);
            // 
            // btn单项成绩
            // 
            this.btn单项成绩.Image = global::HH.ZK.UI.Properties.Resources.statistics;
            this.btn单项成绩.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn单项成绩.Name = "btn单项成绩";
            this.btn单项成绩.Size = new System.Drawing.Size(71, 51);
            this.btn单项成绩.Text = "单项成绩";
            this.btn单项成绩.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn单项成绩.Click += new System.EventHandler(this.btn单项成绩_Click);
            // 
            // mnu仲裁报表
            // 
            this.mnu仲裁报表.Image = global::HH.ZK.UI.Properties.Resources.discussion;
            this.mnu仲裁报表.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnu仲裁报表.Name = "mnu仲裁报表";
            this.mnu仲裁报表.Size = new System.Drawing.Size(71, 51);
            this.mnu仲裁报表.Text = "仲裁报表";
            this.mnu仲裁报表.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.mnu仲裁报表.Click += new System.EventHandler(this.mnu仲裁报表_Click);
            // 
            // btn总成绩统计报表
            // 
            this.btn总成绩统计报表.Image = global::HH.ZK.UI.Properties.Resources.statistics;
            this.btn总成绩统计报表.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn总成绩统计报表.Name = "btn总成绩统计报表";
            this.btn总成绩统计报表.Size = new System.Drawing.Size(71, 51);
            this.btn总成绩统计报表.Text = "总分统计";
            this.btn总成绩统计报表.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn总成绩统计报表.Click += new System.EventHandler(this.总分统计toolStripMenuItem1_Click);
            // 
            // btn单项统计报表
            // 
            this.btn单项统计报表.Image = global::HH.ZK.UI.Properties.Resources.statistics;
            this.btn单项统计报表.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn单项统计报表.Name = "btn单项统计报表";
            this.btn单项统计报表.Size = new System.Drawing.Size(71, 51);
            this.btn单项统计报表.Text = "单项统计";
            this.btn单项统计报表.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn单项统计报表.Click += new System.EventHandler(this.mnu_Statistics_Click);
            // 
            // toolStripSeparator14
            // 
            this.toolStripSeparator14.Name = "toolStripSeparator14";
            this.toolStripSeparator14.Size = new System.Drawing.Size(6, 51);
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
            this.ucFormViewMain.Location = new System.Drawing.Point(0, 75);
            this.ucFormViewMain.Name = "ucFormViewMain";
            this.ucFormViewMain.Size = new System.Drawing.Size(1316, 32);
            this.ucFormViewMain.TabIndex = 35;
            // 
            // FrmMain_ZK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1316, 621);
            this.Controls.Add(this.ucFormViewMain);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.mainToolBar);
            this.Controls.Add(this.mainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mainMenu;
            this.Name = "FrmMain_ZK";
            this.Text = "AI 军事体能考核总系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.mainToolBar.ResumeLayout(false);
            this.mainToolBar.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStrip mainToolBar;
        private System.Windows.Forms.ToolStripMenuItem 系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnu_ChangPwd;
        private System.Windows.Forms.ToolStripMenuItem mnu_Logout;
        private System.Windows.Forms.ToolStripMenuItem mnu_Exit;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用户手册ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btn学生信息;
        private System.Windows.Forms.ToolStripMenuItem btn_Collect;
        private System.Windows.Forms.ToolStripMenuItem btn自动打印成绩;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
        private System.Windows.Forms.ToolStripMenuItem btn成绩管理;
        private System.Windows.Forms.ToolStripMenuItem btn单项统计报表;
        private System.Windows.Forms.ToolStripMenuItem btn总成绩统计报表;
        private System.Windows.Forms.ToolStripMenuItem btn考场进度;
        private System.Windows.Forms.ToolStripMenuItem btn考试视频;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator14;
        private System.Windows.Forms.ToolStripMenuItem Main_报表;
        private System.Windows.Forms.ToolStripMenuItem mnu重复成绩;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator18;
        private System.Windows.Forms.ToolStripMenuItem mnu_Log;
        private System.Windows.Forms.ToolStripMenuItem mnu总成绩统计报表;
        private System.Windows.Forms.ToolStripMenuItem mnu单项成绩统计报表;
        private System.Windows.Forms.ToolStripMenuItem btn单项成绩;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator20;
        private System.Windows.Forms.ToolStripMenuItem mnu学生原始成绩查询;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblOperator;
        private System.Windows.Forms.ToolStripStatusLabel lblState;
        private System.Windows.Forms.ToolStripMenuItem mnu软件更新日志;
        private LJH.GeneralLibrary.WinformControl.UCFormViewEx ucFormViewMain;
        private System.Windows.Forms.ToolStripMenuItem mnu导入学生;
        private System.Windows.Forms.ToolStripMenuItem mnu仲裁报表;
        private System.Windows.Forms.ToolStripMenuItem mnu学生成绩仲裁记录报表;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem mnu导出成绩;
        private System.Windows.Forms.ToolStripMenuItem mnu切换用户;
        private System.Windows.Forms.ToolStripMenuItem mnu人工修改成绩查询报表;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem btn学生成绩单;
        private System.Windows.Forms.ToolStripMenuItem 账号管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 训练考核大ToolStripMenuItem;
    }
}

