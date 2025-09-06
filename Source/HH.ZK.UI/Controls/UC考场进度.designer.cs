namespace HH.ZK.UI.Controls
{
    partial class UC考场进度
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label6 = new System.Windows.Forms.Label();
            this.pr学生完成进度 = new LJH.GeneralLibrary.WinformControl.PercentageProgressBar(this.components);
            this.pr学生检录进度 = new LJH.GeneralLibrary.WinformControl.PercentageProgressBar(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl考点 = new System.Windows.Forms.Label();
            this.lbl总人数 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl完成人数 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl已检录人数 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl缺免考人数 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(46, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "考点";
            // 
            // pr学生完成进度
            // 
            this.pr学生完成进度.Location = new System.Drawing.Point(91, 165);
            this.pr学生完成进度.Name = "pr学生完成进度";
            this.pr学生完成进度.Size = new System.Drawing.Size(480, 30);
            this.pr学生完成进度.TabIndex = 16;
            this.pr学生完成进度.TextColor = System.Drawing.Color.Black;
            this.pr学生完成进度.TextFont = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // pr学生检录进度
            // 
            this.pr学生检录进度.Location = new System.Drawing.Point(91, 112);
            this.pr学生检录进度.Name = "pr学生检录进度";
            this.pr学生检录进度.Size = new System.Drawing.Size(480, 30);
            this.pr学生检录进度.TabIndex = 15;
            this.pr学生检录进度.TextColor = System.Drawing.Color.Black;
            this.pr学生检录进度.TextFont = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(14, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "考试进度";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(14, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "检录进度";
            // 
            // lbl考点
            // 
            this.lbl考点.AutoSize = true;
            this.lbl考点.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl考点.ForeColor = System.Drawing.Color.Blue;
            this.lbl考点.Location = new System.Drawing.Point(89, 17);
            this.lbl考点.Name = "lbl考点";
            this.lbl考点.Size = new System.Drawing.Size(68, 27);
            this.lbl考点.TabIndex = 20;
            this.lbl考点.Text = "考点";
            // 
            // lbl总人数
            // 
            this.lbl总人数.AutoSize = true;
            this.lbl总人数.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl总人数.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl总人数.ForeColor = System.Drawing.Color.Blue;
            this.lbl总人数.Location = new System.Drawing.Point(89, 63);
            this.lbl总人数.Name = "lbl总人数";
            this.lbl总人数.Size = new System.Drawing.Size(27, 27);
            this.lbl总人数.TabIndex = 22;
            this.lbl总人数.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(30, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "总人数";
            // 
            // lbl完成人数
            // 
            this.lbl完成人数.AutoSize = true;
            this.lbl完成人数.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl完成人数.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl完成人数.ForeColor = System.Drawing.Color.Blue;
            this.lbl完成人数.Location = new System.Drawing.Point(241, 63);
            this.lbl完成人数.Name = "lbl完成人数";
            this.lbl完成人数.Size = new System.Drawing.Size(27, 27);
            this.lbl完成人数.TabIndex = 24;
            this.lbl完成人数.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(186, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 16);
            this.label7.TabIndex = 23;
            this.label7.Text = "已完成";
            // 
            // lbl已检录人数
            // 
            this.lbl已检录人数.AutoSize = true;
            this.lbl已检录人数.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl已检录人数.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl已检录人数.ForeColor = System.Drawing.Color.Blue;
            this.lbl已检录人数.Location = new System.Drawing.Point(386, 63);
            this.lbl已检录人数.Name = "lbl已检录人数";
            this.lbl已检录人数.Size = new System.Drawing.Size(27, 27);
            this.lbl已检录人数.TabIndex = 26;
            this.lbl已检录人数.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(332, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 16);
            this.label9.TabIndex = 25;
            this.label9.Text = "已检录";
            // 
            // lbl缺免考人数
            // 
            this.lbl缺免考人数.AutoSize = true;
            this.lbl缺免考人数.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl缺免考人数.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl缺免考人数.ForeColor = System.Drawing.Color.Red;
            this.lbl缺免考人数.Location = new System.Drawing.Point(530, 63);
            this.lbl缺免考人数.Name = "lbl缺免考人数";
            this.lbl缺免考人数.Size = new System.Drawing.Size(27, 27);
            this.lbl缺免考人数.TabIndex = 28;
            this.lbl缺免考人数.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(477, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 16);
            this.label11.TabIndex = 27;
            this.label11.Text = "缺免考";
            // 
            // UC考场进度
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lbl缺免考人数);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lbl已检录人数);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbl完成人数);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl总人数);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl考点);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pr学生完成进度);
            this.Controls.Add(this.pr学生检录进度);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "UC考场进度";
            this.Size = new System.Drawing.Size(593, 224);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private LJH.GeneralLibrary.WinformControl.PercentageProgressBar pr学生完成进度;
        private LJH.GeneralLibrary.WinformControl.PercentageProgressBar pr学生检录进度;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl考点;
        private System.Windows.Forms.Label lbl总人数;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl完成人数;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl已检录人数;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl缺免考人数;
        private System.Windows.Forms.Label label11;
    }
}
