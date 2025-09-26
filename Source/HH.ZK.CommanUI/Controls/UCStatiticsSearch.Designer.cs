namespace HH.ZK.CommonUI.Controls
{
    partial class UCStatiticsSearch
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chkByDivision = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.chkBySex = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdSexAll = new System.Windows.Forms.RadioButton();
            this.rdFemale = new System.Windows.Forms.RadioButton();
            this.rdMale = new System.Windows.Forms.RadioButton();
            this.cmbFacility = new HH.ZK.CommonUI.Controls.FacilityComboBox(this.components);
            this.cmbDivision = new HH.ZK.CommonUI.Controls.DivisionComboBox(this.components);
            this.txtClassName = new HH.ZK.CommonUI.Controls.ClassNameCombox(this.components);
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(7, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 303;
            this.label2.Text = "区域";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(7, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 301;
            this.label5.Text = "学校";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chkByDivision
            // 
            this.chkByDivision.AutoSize = true;
            this.chkByDivision.Checked = true;
            this.chkByDivision.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkByDivision.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkByDivision.Location = new System.Drawing.Point(360, 70);
            this.chkByDivision.Name = "chkByDivision";
            this.chkByDivision.Size = new System.Drawing.Size(60, 16);
            this.chkByDivision.TabIndex = 299;
            this.chkByDivision.Text = "分部门";
            this.chkByDivision.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(425, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 12);
            this.label8.TabIndex = 298;
            this.label8.Text = "+";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkBySex
            // 
            this.chkBySex.AutoSize = true;
            this.chkBySex.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkBySex.Location = new System.Drawing.Point(440, 70);
            this.chkBySex.Name = "chkBySex";
            this.chkBySex.Size = new System.Drawing.Size(60, 16);
            this.chkBySex.TabIndex = 291;
            this.chkBySex.Text = "分性别";
            this.chkBySex.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(304, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 289;
            this.label11.Text = "统计方式";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(7, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 288;
            this.label6.Text = "班级";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(328, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 281;
            this.label10.Text = "性别";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdSexAll);
            this.panel2.Controls.Add(this.rdFemale);
            this.panel2.Controls.Add(this.rdMale);
            this.panel2.Location = new System.Drawing.Point(360, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(135, 21);
            this.panel2.TabIndex = 282;
            // 
            // rdSexAll
            // 
            this.rdSexAll.AutoSize = true;
            this.rdSexAll.Checked = true;
            this.rdSexAll.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rdSexAll.Location = new System.Drawing.Point(3, 3);
            this.rdSexAll.Name = "rdSexAll";
            this.rdSexAll.Size = new System.Drawing.Size(47, 16);
            this.rdSexAll.TabIndex = 7;
            this.rdSexAll.TabStop = true;
            this.rdSexAll.Text = "全部";
            this.rdSexAll.UseVisualStyleBackColor = true;
            // 
            // rdFemale
            // 
            this.rdFemale.AutoSize = true;
            this.rdFemale.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rdFemale.Location = new System.Drawing.Point(95, 3);
            this.rdFemale.Name = "rdFemale";
            this.rdFemale.Size = new System.Drawing.Size(35, 16);
            this.rdFemale.TabIndex = 6;
            this.rdFemale.Text = "女";
            this.rdFemale.UseVisualStyleBackColor = true;
            // 
            // rdMale
            // 
            this.rdMale.AutoSize = true;
            this.rdMale.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rdMale.Location = new System.Drawing.Point(52, 3);
            this.rdMale.Name = "rdMale";
            this.rdMale.Size = new System.Drawing.Size(35, 16);
            this.rdMale.TabIndex = 5;
            this.rdMale.Text = "男";
            this.rdMale.UseVisualStyleBackColor = true;
            // 
            // cmbFacility
            // 
            this.cmbFacility.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFacility.Enabled = false;
            this.cmbFacility.Font = new System.Drawing.Font("宋体", 9F);
            this.cmbFacility.FormattingEnabled = true;
            this.cmbFacility.Location = new System.Drawing.Point(39, 36);
            this.cmbFacility.Name = "cmbFacility";
            this.cmbFacility.Size = new System.Drawing.Size(249, 20);
            this.cmbFacility.TabIndex = 304;
            // 
            // cmbDivision
            // 
            this.cmbDivision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDivision.Enabled = false;
            this.cmbDivision.Font = new System.Drawing.Font("宋体", 9F);
            this.cmbDivision.FormattingEnabled = true;
            this.cmbDivision.Location = new System.Drawing.Point(39, 5);
            this.cmbDivision.Name = "cmbDivision";
            this.cmbDivision.Size = new System.Drawing.Size(249, 20);
            this.cmbDivision.TabIndex = 302;
            // 
            // txtClassName
            // 
            this.txtClassName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtClassName.Enabled = false;
            this.txtClassName.FormattingEnabled = true;
            this.txtClassName.Location = new System.Drawing.Point(39, 67);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(249, 20);
            this.txtClassName.TabIndex = 287;
            // 
            // UCStatiticsSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbFacility);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbDivision);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chkByDivision);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.chkBySex);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtClassName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel2);
            this.Name = "UCStatiticsSearch";
            this.Size = new System.Drawing.Size(512, 94);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FacilityComboBox cmbFacility;
        private System.Windows.Forms.Label label2;
        private DivisionComboBox cmbDivision;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkByDivision;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chkBySex;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private ClassNameCombox txtClassName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdSexAll;
        private System.Windows.Forms.RadioButton rdFemale;
        private System.Windows.Forms.RadioButton rdMale;
    }
}
