namespace HH.ZK.UI
{
    partial class FrmStudentDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStudentDetail));
            this.txtID = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdFemale = new System.Windows.Forms.RadioButton();
            this.rdMale = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCardID = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtClassName = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.picPhoto = new System.Windows.Forms.PictureBox();
            this.btnBrowserPhoto = new System.Windows.Forms.Button();
            this.btnDelPhoto = new System.Windows.Forms.Button();
            this.txtIDNumber = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.txtFacility = new HH.ZK.CommonUI.Controls.DivisionComboBox(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(339, 278);
            this.btnClose.Size = new System.Drawing.Size(95, 36);
            this.btnClose.TabIndex = 17;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(199, 278);
            this.btnOk.Size = new System.Drawing.Size(95, 36);
            this.btnOk.TabIndex = 16;
            // 
            // txtID
            // 
            this.txtID.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtID.Location = new System.Drawing.Point(80, 20);
            this.txtID.MaxLength = 20;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(159, 21);
            this.txtID.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(45, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 66;
            this.label2.Text = "编号";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdFemale);
            this.panel2.Controls.Add(this.rdMale);
            this.panel2.Location = new System.Drawing.Point(80, 92);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(123, 21);
            this.panel2.TabIndex = 2;
            // 
            // rdFemale
            // 
            this.rdFemale.AutoSize = true;
            this.rdFemale.Location = new System.Drawing.Point(55, 4);
            this.rdFemale.Name = "rdFemale";
            this.rdFemale.Size = new System.Drawing.Size(35, 16);
            this.rdFemale.TabIndex = 6;
            this.rdFemale.Text = "女";
            this.rdFemale.UseVisualStyleBackColor = true;
            // 
            // rdMale
            // 
            this.rdMale.AutoSize = true;
            this.rdMale.Checked = true;
            this.rdMale.Location = new System.Drawing.Point(4, 4);
            this.rdMale.Name = "rdMale";
            this.rdMale.Size = new System.Drawing.Size(35, 16);
            this.rdMale.TabIndex = 5;
            this.rdMale.TabStop = true;
            this.rdMale.Text = "男";
            this.rdMale.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(45, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 63;
            this.label8.Text = "性别";
            // 
            // txtCardID
            // 
            this.txtCardID.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtCardID.Location = new System.Drawing.Point(80, 164);
            this.txtCardID.MaxLength = 20;
            this.txtCardID.Name = "txtCardID";
            this.txtCardID.Size = new System.Drawing.Size(159, 21);
            this.txtCardID.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(45, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 62;
            this.label3.Text = "卡号";
            // 
            // txtName
            // 
            this.txtName.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtName.Location = new System.Drawing.Point(80, 56);
            this.txtName.MaxLength = 20;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(159, 21);
            this.txtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(45, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 61;
            this.label1.Text = "姓名";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(45, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 69;
            this.label6.Text = "班级";
            // 
            // txtClassName
            // 
            this.txtClassName.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtClassName.Location = new System.Drawing.Point(80, 200);
            this.txtClassName.MaxLength = 20;
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(159, 21);
            this.txtClassName.TabIndex = 6;
            // 
            // picPhoto
            // 
            this.picPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPhoto.Location = new System.Drawing.Point(268, 13);
            this.picPhoto.Name = "picPhoto";
            this.picPhoto.Size = new System.Drawing.Size(150, 180);
            this.picPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPhoto.TabIndex = 89;
            this.picPhoto.TabStop = false;
            // 
            // btnBrowserPhoto
            // 
            this.btnBrowserPhoto.Location = new System.Drawing.Point(257, 207);
            this.btnBrowserPhoto.Name = "btnBrowserPhoto";
            this.btnBrowserPhoto.Size = new System.Drawing.Size(75, 23);
            this.btnBrowserPhoto.TabIndex = 8;
            this.btnBrowserPhoto.Text = "增加相片";
            this.btnBrowserPhoto.UseVisualStyleBackColor = true;
            this.btnBrowserPhoto.Click += new System.EventHandler(this.btnBrowserPhoto_Click);
            // 
            // btnDelPhoto
            // 
            this.btnDelPhoto.Location = new System.Drawing.Point(352, 207);
            this.btnDelPhoto.Name = "btnDelPhoto";
            this.btnDelPhoto.Size = new System.Drawing.Size(75, 23);
            this.btnDelPhoto.TabIndex = 9;
            this.btnDelPhoto.Text = "删除相片";
            this.btnDelPhoto.UseVisualStyleBackColor = true;
            this.btnDelPhoto.Click += new System.EventHandler(this.btnDelPhoto_Click);
            // 
            // txtIDNumber
            // 
            this.txtIDNumber.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtIDNumber.Location = new System.Drawing.Point(80, 128);
            this.txtIDNumber.MaxLength = 20;
            this.txtIDNumber.Name = "txtIDNumber";
            this.txtIDNumber.Size = new System.Drawing.Size(159, 21);
            this.txtIDNumber.TabIndex = 93;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(21, 132);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 92;
            this.label10.Text = "身份证号";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFacility
            // 
            this.txtFacility.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtFacility.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtFacility.FormattingEnabled = true;
            this.txtFacility.Location = new System.Drawing.Point(80, 236);
            this.txtFacility.Name = "txtFacility";
            this.txtFacility.Size = new System.Drawing.Size(349, 21);
            this.txtFacility.TabIndex = 95;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label13.Location = new System.Drawing.Point(45, 240);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 12);
            this.label13.TabIndex = 94;
            this.label13.Text = "机构";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FrmStudentDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 323);
            this.Controls.Add(this.txtFacility);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtIDNumber);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnDelPhoto);
            this.Controls.Add(this.btnBrowserPhoto);
            this.Controls.Add(this.picPhoto);
            this.Controls.Add(this.txtClassName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCardID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmStudentDetail";
            this.Text = "人员信息";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtName, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtCardID, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtID, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.txtClassName, 0);
            this.Controls.SetChildIndex(this.picPhoto, 0);
            this.Controls.SetChildIndex(this.btnBrowserPhoto, 0);
            this.Controls.SetChildIndex(this.btnDelPhoto, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.txtIDNumber, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            this.Controls.SetChildIndex(this.txtFacility, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LJH.GeneralLibrary.WinformControl.DBCTextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdFemale;
        private System.Windows.Forms.RadioButton rdMale;
        private System.Windows.Forms.Label label8;
        private LJH.GeneralLibrary.WinformControl.DBCTextBox txtCardID;
        private System.Windows.Forms.Label label3;
        private LJH.GeneralLibrary.WinformControl.DBCTextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private LJH.GeneralLibrary.WinformControl.DBCTextBox txtClassName;
        private System.Windows.Forms.PictureBox picPhoto;
        private System.Windows.Forms.Button btnBrowserPhoto;
        private System.Windows.Forms.Button btnDelPhoto;
        private LJH.GeneralLibrary.WinformControl.DBCTextBox txtIDNumber;
        private System.Windows.Forms.Label label10;
        private HH.ZK.CommonUI.Controls.DivisionComboBox txtFacility;
        private System.Windows.Forms.Label label13;
    }
}