namespace HH.ZK.UI
{
    partial class FrmOperatorParaDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOperatorParaDetail));
            this.txtOperator = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.txt考点 = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.lnk考点 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.txtFacilities = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.lnkFacilities = new System.Windows.Forms.LinkLabel();
            this.chk使用加密狗验证 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtExpireDate = new System.Windows.Forms.DateTimePicker();
            this.txtRole = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(763, 497);
            this.btnClose.Size = new System.Drawing.Size(101, 42);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(578, 497);
            this.btnOk.Size = new System.Drawing.Size(151, 42);
            // 
            // txtOperator
            // 
            this.txtOperator.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtOperator.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtOperator.Location = new System.Drawing.Point(62, 17);
            this.txtOperator.Name = "txtOperator";
            this.txtOperator.Size = new System.Drawing.Size(174, 30);
            this.txtOperator.TabIndex = 8;
            this.txtOperator.Leave += new System.EventHandler(this.txtMobile_Leave);
            // 
            // txt考点
            // 
            this.txt考点.BackColor = System.Drawing.Color.White;
            this.txt考点.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt考点.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txt考点.Location = new System.Drawing.Point(62, 119);
            this.txt考点.Multiline = true;
            this.txt考点.Name = "txt考点";
            this.txt考点.ReadOnly = true;
            this.txt考点.Size = new System.Drawing.Size(332, 341);
            this.txt考点.TabIndex = 10;
            // 
            // lnk考点
            // 
            this.lnk考点.AutoSize = true;
            this.lnk考点.Location = new System.Drawing.Point(27, 126);
            this.lnk考点.Name = "lnk考点";
            this.lnk考点.Size = new System.Drawing.Size(29, 12);
            this.lnk考点.TabIndex = 9;
            this.lnk考点.TabStop = true;
            this.lnk考点.Text = "考点";
            this.lnk考点.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk考点_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "手机号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "姓名";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtName.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtName.Location = new System.Drawing.Point(289, 17);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(173, 30);
            this.txtName.TabIndex = 14;
            // 
            // txtFacilities
            // 
            this.txtFacilities.BackColor = System.Drawing.Color.White;
            this.txtFacilities.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtFacilities.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtFacilities.Location = new System.Drawing.Point(530, 119);
            this.txtFacilities.Multiline = true;
            this.txtFacilities.Name = "txtFacilities";
            this.txtFacilities.ReadOnly = true;
            this.txtFacilities.Size = new System.Drawing.Size(334, 344);
            this.txtFacilities.TabIndex = 16;
            // 
            // lnkFacilities
            // 
            this.lnkFacilities.AutoSize = true;
            this.lnkFacilities.Location = new System.Drawing.Point(495, 126);
            this.lnkFacilities.Name = "lnkFacilities";
            this.lnkFacilities.Size = new System.Drawing.Size(29, 12);
            this.lnkFacilities.TabIndex = 15;
            this.lnkFacilities.TabStop = true;
            this.lnkFacilities.Text = "学校";
            this.lnkFacilities.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkFacilities_LinkClicked);
            // 
            // chk使用加密狗验证
            // 
            this.chk使用加密狗验证.AutoSize = true;
            this.chk使用加密狗验证.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chk使用加密狗验证.ForeColor = System.Drawing.Color.Red;
            this.chk使用加密狗验证.Location = new System.Drawing.Point(735, 24);
            this.chk使用加密狗验证.Name = "chk使用加密狗验证";
            this.chk使用加密狗验证.Size = new System.Drawing.Size(63, 16);
            this.chk使用加密狗验证.TabIndex = 109;
            this.chk使用加密狗验证.Text = "加密狗";
            this.chk使用加密狗验证.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(483, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 110;
            this.label4.Text = "有效期";
            // 
            // dtExpireDate
            // 
            this.dtExpireDate.CustomFormat = "yyyy年MM月dd日";
            this.dtExpireDate.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtExpireDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtExpireDate.Location = new System.Drawing.Point(530, 17);
            this.dtExpireDate.Name = "dtExpireDate";
            this.dtExpireDate.Size = new System.Drawing.Size(182, 30);
            this.dtExpireDate.TabIndex = 111;
            // 
            // txtRole
            // 
            this.txtRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtRole.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRole.FormattingEnabled = true;
            this.txtRole.Items.AddRange(new object[] {
            "所有权限",
            "区域管理员",
            "学校管理员",
            "报表查看员",
            "照片采集员",
            "成绩采集员"});
            this.txtRole.Location = new System.Drawing.Point(62, 68);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(400, 28);
            this.txtRole.TabIndex = 113;
            this.txtRole.SelectedIndexChanged += new System.EventHandler(this.txtRole_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 112;
            this.label3.Text = "操作权限";
            // 
            // FrmOperatorParaDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 557);
            this.Controls.Add(this.txtRole);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtExpireDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chk使用加密狗验证);
            this.Controls.Add(this.txtFacilities);
            this.Controls.Add(this.lnkFacilities);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt考点);
            this.Controls.Add(this.lnk考点);
            this.Controls.Add(this.txtOperator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmOperatorParaDetail";
            this.Text = "账号明细";
            this.Controls.SetChildIndex(this.txtOperator, 0);
            this.Controls.SetChildIndex(this.lnk考点, 0);
            this.Controls.SetChildIndex(this.txt考点, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtName, 0);
            this.Controls.SetChildIndex(this.lnkFacilities, 0);
            this.Controls.SetChildIndex(this.txtFacilities, 0);
            this.Controls.SetChildIndex(this.chk使用加密狗验证, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.dtExpireDate, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtRole, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private LJH.GeneralLibrary.WinformControl.DBCTextBox txtOperator;
        private LJH.GeneralLibrary.WinformControl.DBCTextBox txt考点;
        private System.Windows.Forms.LinkLabel lnk考点;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private LJH.GeneralLibrary.WinformControl.DBCTextBox txtName;
        private LJH.GeneralLibrary.WinformControl.DBCTextBox txtFacilities;
        private System.Windows.Forms.LinkLabel lnkFacilities;
        private System.Windows.Forms.CheckBox chk使用加密狗验证;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtExpireDate;
        private System.Windows.Forms.ComboBox txtRole;
        private System.Windows.Forms.Label label3;
    }
}