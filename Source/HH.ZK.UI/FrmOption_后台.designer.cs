namespace HH.ZK.UI
{
    partial class FrmOption_后台
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
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chkCnanotModifyScore = new System.Windows.Forms.CheckBox();
            this.txt总分满分 = new LJH.GeneralLibrary.WinformControl.DecimalTextBox(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFormula = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.chk保留小数位 = new System.Windows.Forms.CheckBox();
            this.txtPointCount = new LJH.GeneralLibrary.WinformControl.IntergerTextBox(this.components);
            this.pnl舍入方式 = new System.Windows.Forms.Panel();
            this.rd直接舍弃 = new System.Windows.Forms.RadioButton();
            this.rd四舍五入 = new System.Windows.Forms.RadioButton();
            this.rd非零进一 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rdBest = new System.Windows.Forms.RadioButton();
            this.rdLast = new System.Windows.Forms.RadioButton();
            this.txt总分计算方式 = new HH.ZK.CommonUI.Controls.TotalCalTypeComboBox(this.components);
            this.txt自定义标题 = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.pnl舍入方式.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(396, 471);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(119, 34);
            this.btnOk.TabIndex = 85;
            this.btnOk.Text = "确定(&O)";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(542, 471);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(119, 34);
            this.btnCancel.TabIndex = 86;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(670, 444);
            this.tabControl1.TabIndex = 173;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.chkCnanotModifyScore);
            this.tabPage1.Controls.Add(this.txt总分满分);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtFormula);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.chk保留小数位);
            this.tabPage1.Controls.Add(this.txtPointCount);
            this.tabPage1.Controls.Add(this.pnl舍入方式);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.rdBest);
            this.tabPage1.Controls.Add(this.rdLast);
            this.tabPage1.Controls.Add(this.txt总分计算方式);
            this.tabPage1.Controls.Add(this.txt自定义标题);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(662, 418);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "常规";
            // 
            // chkCnanotModifyScore
            // 
            this.chkCnanotModifyScore.AutoSize = true;
            this.chkCnanotModifyScore.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkCnanotModifyScore.ForeColor = System.Drawing.Color.Red;
            this.chkCnanotModifyScore.Location = new System.Drawing.Point(112, 97);
            this.chkCnanotModifyScore.Name = "chkCnanotModifyScore";
            this.chkCnanotModifyScore.Size = new System.Drawing.Size(193, 16);
            this.chkCnanotModifyScore.TabIndex = 221;
            this.chkCnanotModifyScore.Text = "不允许直接修改学生现有成绩";
            this.chkCnanotModifyScore.UseVisualStyleBackColor = true;
            // 
            // txt总分满分
            // 
            this.txt总分满分.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.txt总分满分.ForeColor = System.Drawing.Color.Red;
            this.txt总分满分.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txt总分满分.Location = new System.Drawing.Point(112, 128);
            this.txt总分满分.MaxValue = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txt总分满分.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txt总分满分.Name = "txt总分满分";
            this.txt总分满分.PointCount = -1;
            this.txt总分满分.Size = new System.Drawing.Size(96, 26);
            this.txt总分满分.TabIndex = 218;
            this.txt总分满分.Text = "100";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(55, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 217;
            this.label8.Text = "总分满分";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(43, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 216;
            this.label4.Text = "自定义公式";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFormula
            // 
            this.txtFormula.Enabled = false;
            this.txtFormula.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtFormula.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtFormula.Location = new System.Drawing.Point(112, 206);
            this.txtFormula.MaxLength = 100;
            this.txtFormula.Multiline = true;
            this.txtFormula.Name = "txtFormula";
            this.txtFormula.Size = new System.Drawing.Size(516, 53);
            this.txtFormula.TabIndex = 215;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(318, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 214;
            this.label1.Text = "舍入方式";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chk保留小数位
            // 
            this.chk保留小数位.AutoSize = true;
            this.chk保留小数位.Location = new System.Drawing.Point(112, 277);
            this.chk保留小数位.Name = "chk保留小数位";
            this.chk保留小数位.Size = new System.Drawing.Size(84, 16);
            this.chk保留小数位.TabIndex = 213;
            this.chk保留小数位.Text = "保留小数位";
            this.chk保留小数位.UseVisualStyleBackColor = true;
            this.chk保留小数位.CheckedChanged += new System.EventHandler(this.chk保留小数位_CheckedChanged);
            // 
            // txtPointCount
            // 
            this.txtPointCount.Enabled = false;
            this.txtPointCount.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPointCount.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtPointCount.Location = new System.Drawing.Point(198, 270);
            this.txtPointCount.MaxValue = 5;
            this.txtPointCount.MinValue = 0;
            this.txtPointCount.Name = "txtPointCount";
            this.txtPointCount.Size = new System.Drawing.Size(73, 30);
            this.txtPointCount.TabIndex = 212;
            this.txtPointCount.Text = "0";
            // 
            // pnl舍入方式
            // 
            this.pnl舍入方式.Controls.Add(this.rd直接舍弃);
            this.pnl舍入方式.Controls.Add(this.rd四舍五入);
            this.pnl舍入方式.Controls.Add(this.rd非零进一);
            this.pnl舍入方式.Enabled = false;
            this.pnl舍入方式.Location = new System.Drawing.Point(380, 273);
            this.pnl舍入方式.Name = "pnl舍入方式";
            this.pnl舍入方式.Size = new System.Drawing.Size(247, 24);
            this.pnl舍入方式.TabIndex = 210;
            // 
            // rd直接舍弃
            // 
            this.rd直接舍弃.AutoSize = true;
            this.rd直接舍弃.Location = new System.Drawing.Point(170, 4);
            this.rd直接舍弃.Name = "rd直接舍弃";
            this.rd直接舍弃.Size = new System.Drawing.Size(71, 16);
            this.rd直接舍弃.TabIndex = 93;
            this.rd直接舍弃.Text = "直接舍弃";
            this.rd直接舍弃.UseVisualStyleBackColor = true;
            // 
            // rd四舍五入
            // 
            this.rd四舍五入.AutoSize = true;
            this.rd四舍五入.Checked = true;
            this.rd四舍五入.Location = new System.Drawing.Point(4, 4);
            this.rd四舍五入.Name = "rd四舍五入";
            this.rd四舍五入.Size = new System.Drawing.Size(71, 16);
            this.rd四舍五入.TabIndex = 92;
            this.rd四舍五入.TabStop = true;
            this.rd四舍五入.Text = "四舍五入";
            this.rd四舍五入.UseVisualStyleBackColor = true;
            // 
            // rd非零进一
            // 
            this.rd非零进一.AutoSize = true;
            this.rd非零进一.Location = new System.Drawing.Point(87, 4);
            this.rd非零进一.Name = "rd非零进一";
            this.rd非零进一.Size = new System.Drawing.Size(71, 16);
            this.rd非零进一.TabIndex = 91;
            this.rd非零进一.Text = "非零进一";
            this.rd非零进一.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(55, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 199;
            this.label6.Text = "总分计算";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 195;
            this.label2.Text = "最终成绩";
            // 
            // rdBest
            // 
            this.rdBest.AutoSize = true;
            this.rdBest.Location = new System.Drawing.Point(112, 68);
            this.rdBest.Name = "rdBest";
            this.rdBest.Size = new System.Drawing.Size(191, 16);
            this.rdBest.TabIndex = 196;
            this.rdBest.Text = "以得分最高的成绩作为中考成绩";
            this.rdBest.UseVisualStyleBackColor = true;
            // 
            // rdLast
            // 
            this.rdLast.AutoSize = true;
            this.rdLast.Location = new System.Drawing.Point(332, 68);
            this.rdLast.Name = "rdLast";
            this.rdLast.Size = new System.Drawing.Size(215, 16);
            this.rdLast.TabIndex = 197;
            this.rdLast.Text = "以最后一次测试的成绩作为中考成绩";
            this.rdLast.UseVisualStyleBackColor = true;
            // 
            // txt总分计算方式
            // 
            this.txt总分计算方式.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt总分计算方式.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt总分计算方式.FormattingEnabled = true;
            this.txt总分计算方式.Location = new System.Drawing.Point(112, 165);
            this.txt总分计算方式.Name = "txt总分计算方式";
            this.txt总分计算方式.Size = new System.Drawing.Size(515, 28);
            this.txt总分计算方式.TabIndex = 206;
            this.txt总分计算方式.SelectedIndexChanged += new System.EventHandler(this.txt总分计算方式_SelectedIndexChanged);
            // 
            // txt自定义标题
            // 
            this.txt自定义标题.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt自定义标题.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txt自定义标题.Location = new System.Drawing.Point(112, 20);
            this.txt自定义标题.MaxLength = 20;
            this.txt自定义标题.Name = "txt自定义标题";
            this.txt自定义标题.Size = new System.Drawing.Size(521, 30);
            this.txt自定义标题.TabIndex = 169;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(43, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 168;
            this.label3.Text = "准考证标题";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FrmOption_后台
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(679, 517);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Name = "FrmOption_后台";
            this.Text = "系统选项";
            this.Load += new System.EventHandler(this.FrmOption_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.pnl舍入方式.ResumeLayout(false);
            this.pnl舍入方式.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private LJH.GeneralLibrary.WinformControl.DBCTextBox txt自定义标题;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnl舍入方式;
        private System.Windows.Forms.RadioButton rd直接舍弃;
        private System.Windows.Forms.RadioButton rd四舍五入;
        private System.Windows.Forms.RadioButton rd非零进一;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdBest;
        private System.Windows.Forms.RadioButton rdLast;
        private HH.ZK.CommonUI.Controls.TotalCalTypeComboBox txt总分计算方式;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chk保留小数位;
        private LJH.GeneralLibrary.WinformControl.IntergerTextBox txtPointCount;
        private LJH.GeneralLibrary.WinformControl.DBCTextBox txtFormula;
        private System.Windows.Forms.Label label4;
        private LJH.GeneralLibrary.WinformControl.DecimalTextBox txt总分满分;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chkCnanotModifyScore;
    }
}