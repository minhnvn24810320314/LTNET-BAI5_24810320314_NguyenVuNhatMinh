namespace BaiTap5_2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblCourse = new System.Windows.Forms.Label();
            this.lblSkills = new System.Windows.Forms.Label();
            this.mtxtPhone = new System.Windows.Forms.MaskedTextBox();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.rdoNam = new System.Windows.Forms.RadioButton();
            this.rdoNu = new System.Windows.Forms.RadioButton();
            this.cboCourse = new System.Windows.Forms.ComboBox();
            this.chkTiengAnh = new System.Windows.Forms.CheckBox();
            this.chkTinHoc = new System.Windows.Forms.CheckBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTitle.Location = new System.Drawing.Point(80, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(320, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "ĐĂNG KÝ THÔNG TIN HỌC VIÊN";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(40, 80);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(100, 20);
            this.lblPhone.TabIndex = 1;
            this.lblPhone.Text = "Số điện thoại:";
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(40, 125);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(77, 20);
            this.lblBirthDate.TabIndex = 2;
            this.lblBirthDate.Text = "Ngày sinh:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(40, 170);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(68, 20);
            this.lblGender.TabIndex = 3;
            this.lblGender.Text = "Giới tính:";
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Location = new System.Drawing.Point(40, 215);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(73, 20);
            this.lblCourse.TabIndex = 4;
            this.lblCourse.Text = "Khóa học:";
            // 
            // lblSkills
            // 
            this.lblSkills.AutoSize = true;
            this.lblSkills.Location = new System.Drawing.Point(40, 260);
            this.lblSkills.Name = "lblSkills";
            this.lblSkills.Size = new System.Drawing.Size(66, 20);
            this.lblSkills.TabIndex = 5;
            this.lblSkills.Text = "Kỹ năng:";
            // 
            // mtxtPhone
            // 
            this.mtxtPhone.Location = new System.Drawing.Point(160, 77);
            this.mtxtPhone.Name = "mtxtPhone";
            this.mtxtPhone.Size = new System.Drawing.Size(250, 27);
            this.mtxtPhone.TabIndex = 6;
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthDate.Location = new System.Drawing.Point(160, 120);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(250, 27);
            this.dtpBirthDate.TabIndex = 7;
            // 
            // rdoNam
            // 
            this.rdoNam.AutoSize = true;
            this.rdoNam.Checked = true;
            this.rdoNam.Location = new System.Drawing.Point(160, 168);
            this.rdoNam.Name = "rdoNam";
            this.rdoNam.Size = new System.Drawing.Size(62, 24);
            this.rdoNam.TabIndex = 8;
            this.rdoNam.TabStop = true;
            this.rdoNam.Text = "Nam";
            this.rdoNam.UseVisualStyleBackColor = true;
            // 
            // rdoNu
            // 
            this.rdoNu.AutoSize = true;
            this.rdoNu.Location = new System.Drawing.Point(250, 168);
            this.rdoNu.Name = "rdoNu";
            this.rdoNu.Size = new System.Drawing.Size(50, 24);
            this.rdoNu.TabIndex = 9;
            this.rdoNu.Text = "Nữ";
            this.rdoNu.UseVisualStyleBackColor = true;
            // 
            // cboCourse
            // 
            this.cboCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCourse.FormattingEnabled = true;
            this.cboCourse.Location = new System.Drawing.Point(160, 212);
            this.cboCourse.Name = "cboCourse";
            this.cboCourse.Size = new System.Drawing.Size(250, 28);
            this.cboCourse.TabIndex = 10;
            // 
            // chkTiengAnh
            // 
            this.chkTiengAnh.AutoSize = true;
            this.chkTiengAnh.Location = new System.Drawing.Point(160, 259);
            this.chkTiengAnh.Name = "chkTiengAnh";
            this.chkTiengAnh.Size = new System.Drawing.Size(98, 24);
            this.chkTiengAnh.TabIndex = 11;
            this.chkTiengAnh.Text = "Tiếng Anh";
            this.chkTiengAnh.UseVisualStyleBackColor = true;
            // 
            // chkTinHoc
            // 
            this.chkTinHoc.AutoSize = true;
            this.chkTinHoc.Location = new System.Drawing.Point(280, 259);
            this.chkTinHoc.Name = "chkTinHoc";
            this.chkTinHoc.Size = new System.Drawing.Size(80, 24);
            this.chkTinHoc.TabIndex = 12;
            this.chkTinHoc.Text = "Tin học";
            this.chkTinHoc.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRegister.Location = new System.Drawing.Point(160, 310);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(180, 40);
            this.btnRegister.TabIndex = 13;
            this.btnRegister.Text = "Đăng ký CSDL";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 400);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.chkTinHoc);
            this.Controls.Add(this.chkTiengAnh);
            this.Controls.Add(this.cboCourse);
            this.Controls.Add(this.rdoNu);
            this.Controls.Add(this.rdoNam);
            this.Controls.Add(this.dtpBirthDate);
            this.Controls.Add(this.mtxtPhone);
            this.Controls.Add(this.lblSkills);
            this.Controls.Add(this.lblCourse);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblBirthDate);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Ký Học Viên CSDL - Bài 5.2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Label lblSkills;
        private System.Windows.Forms.MaskedTextBox mtxtPhone;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.RadioButton rdoNam;
        private System.Windows.Forms.RadioButton rdoNu;
        private System.Windows.Forms.ComboBox cboCourse;
        private System.Windows.Forms.CheckBox chkTiengAnh;
        private System.Windows.Forms.CheckBox chkTinHoc;
        private System.Windows.Forms.Button btnRegister;
    }
}