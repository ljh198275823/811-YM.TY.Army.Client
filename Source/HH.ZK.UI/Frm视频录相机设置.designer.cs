namespace HH.ZK.UI
{
    partial class Frm视频录相机设置
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
            this.btnConnectTest1 = new System.Windows.Forms.Button();
            this.txtPasswd = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.txtUserID = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.txtUrl = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPort = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.rd海康威视 = new System.Windows.Forms.RadioButton();
            this.rd大华 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDelaySeconds = new LJH.GeneralLibrary.WinformControl.IntergerTextBox(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btn新建 = new System.Windows.Forms.Button();
            this.btn删除所选项 = new System.Windows.Forms.Button();
            this.colSer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChannels = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMemo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConnectTest1
            // 
            this.btnConnectTest1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnectTest1.Location = new System.Drawing.Point(725, 481);
            this.btnConnectTest1.Name = "btnConnectTest1";
            this.btnConnectTest1.Size = new System.Drawing.Size(174, 48);
            this.btnConnectTest1.TabIndex = 14;
            this.btnConnectTest1.Text = "保存参数";
            this.btnConnectTest1.UseVisualStyleBackColor = true;
            this.btnConnectTest1.Click += new System.EventHandler(this.btnConnectTest1_Click);
            // 
            // txtPasswd
            // 
            this.txtPasswd.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPasswd.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtPasswd.Location = new System.Drawing.Point(604, 59);
            this.txtPasswd.Name = "txtPasswd";
            this.txtPasswd.Size = new System.Drawing.Size(140, 30);
            this.txtPasswd.TabIndex = 5;
            this.txtPasswd.Text = "huihai888";
            // 
            // txtUserID
            // 
            this.txtUserID.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtUserID.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtUserID.Location = new System.Drawing.Point(454, 59);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(103, 30);
            this.txtUserID.TabIndex = 4;
            this.txtUserID.Text = "hh";
            // 
            // txtUrl
            // 
            this.txtUrl.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtUrl.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtUrl.Location = new System.Drawing.Point(81, 59);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(166, 30);
            this.txtUrl.TabIndex = 2;
            this.txtUrl.Text = "192.168.1.108";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(569, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "密码";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(406, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "用户名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "服务器";
            // 
            // txtPort
            // 
            this.txtPort.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPort.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtPort.Location = new System.Drawing.Point(308, 59);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(84, 30);
            this.txtPort.TabIndex = 3;
            this.txtPort.Text = "8000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(261, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 16;
            this.label1.Text = "端口号";
            // 
            // rd海康威视
            // 
            this.rd海康威视.AutoSize = true;
            this.rd海康威视.Checked = true;
            this.rd海康威视.Location = new System.Drawing.Point(84, 20);
            this.rd海康威视.Name = "rd海康威视";
            this.rd海康威视.Size = new System.Drawing.Size(71, 16);
            this.rd海康威视.TabIndex = 0;
            this.rd海康威视.TabStop = true;
            this.rd海康威视.Text = "海康威视";
            this.rd海康威视.UseVisualStyleBackColor = true;
            this.rd海康威视.CheckedChanged += new System.EventHandler(this.rd海康威视_CheckedChanged);
            // 
            // rd大华
            // 
            this.rd大华.AutoSize = true;
            this.rd大华.Location = new System.Drawing.Point(180, 20);
            this.rd大华.Name = "rd大华";
            this.rd大华.Size = new System.Drawing.Size(47, 16);
            this.rd大华.TabIndex = 1;
            this.rd大华.Text = "大华";
            this.rd大华.UseVisualStyleBackColor = true;
            this.rd大华.CheckedChanged += new System.EventHandler(this.rd大华_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 19;
            this.label2.Text = "录相机品牌";
            // 
            // txtDelaySeconds
            // 
            this.txtDelaySeconds.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDelaySeconds.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtDelaySeconds.Location = new System.Drawing.Point(812, 59);
            this.txtDelaySeconds.MaxValue = 100000000;
            this.txtDelaySeconds.MinValue = -10000000;
            this.txtDelaySeconds.Name = "txtDelaySeconds";
            this.txtDelaySeconds.Size = new System.Drawing.Size(72, 30);
            this.txtDelaySeconds.TabIndex = 6;
            this.txtDelaySeconds.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(753, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 21;
            this.label5.Text = "时间误差";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(890, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 12);
            this.label7.TabIndex = 22;
            this.label7.Text = "秒";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeight = 30;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSer,
            this.colChannels,
            this.colMemo});
            this.dataGridView2.Location = new System.Drawing.Point(35, 105);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dataGridView2.RowTemplate.Height = 30;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(872, 356);
            this.dataGridView2.TabIndex = 39;
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.Blue;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSearch.Location = new System.Drawing.Point(35, 472);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(212, 38);
            this.btnSearch.TabIndex = 43;
            this.btnSearch.Text = "搜索主机";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btn搜索主机_Click);
            // 
            // btn新建
            // 
            this.btn新建.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn新建.Location = new System.Drawing.Point(263, 472);
            this.btn新建.Name = "btn新建";
            this.btn新建.Size = new System.Drawing.Size(109, 38);
            this.btn新建.TabIndex = 44;
            this.btn新建.Text = "新建";
            this.btn新建.UseVisualStyleBackColor = true;
            this.btn新建.Click += new System.EventHandler(this.btn新建_Click);
            // 
            // btn删除所选项
            // 
            this.btn删除所选项.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn删除所选项.Location = new System.Drawing.Point(394, 472);
            this.btn删除所选项.Name = "btn删除所选项";
            this.btn删除所选项.Size = new System.Drawing.Size(109, 38);
            this.btn删除所选项.TabIndex = 45;
            this.btn删除所选项.Text = "删除所选项";
            this.btn删除所选项.UseVisualStyleBackColor = true;
            this.btn删除所选项.Click += new System.EventHandler(this.btn删除所选项_Click);
            // 
            // colSer
            // 
            this.colSer.HeaderText = "主机SN";
            this.colSer.Name = "colSer";
            this.colSer.ReadOnly = true;
            this.colSer.Width = 180;
            // 
            // colChannels
            // 
            this.colChannels.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colChannels.HeaderText = "视频通道";
            this.colChannels.Name = "colChannels";
            this.colChannels.ReadOnly = true;
            // 
            // colMemo
            // 
            this.colMemo.HeaderText = "备注信息";
            this.colMemo.Name = "colMemo";
            this.colMemo.ReadOnly = true;
            this.colMemo.Visible = false;
            this.colMemo.Width = 300;
            // 
            // Frm视频录相机设置
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 541);
            this.Controls.Add(this.btn删除所选项);
            this.Controls.Add(this.btn新建);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDelaySeconds);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rd大华);
            this.Controls.Add(this.rd海康威视);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConnectTest1);
            this.Controls.Add(this.txtPasswd);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "Frm视频录相机设置";
            this.Text = "视频录相机设置";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm视频录相机设置_FormClosing);
            this.Load += new System.EventHandler(this.FrmDHClientSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnectTest1;
        private LJH.GeneralLibrary.WinformControl.DBCTextBox txtPasswd;
        private LJH.GeneralLibrary.WinformControl.DBCTextBox txtUserID;
        private LJH.GeneralLibrary.WinformControl.DBCTextBox txtUrl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private LJH.GeneralLibrary.WinformControl.DBCTextBox txtPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rd海康威视;
        private System.Windows.Forms.RadioButton rd大华;
        private System.Windows.Forms.Label label2;
        private LJH.GeneralLibrary.WinformControl.IntergerTextBox txtDelaySeconds;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btn新建;
        private System.Windows.Forms.Button btn删除所选项;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChannels;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMemo;
    }
}