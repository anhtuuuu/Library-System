﻿namespace Library_Management
{
    partial class Form_DangKy
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
            this.txt_MatKhau = new System.Windows.Forms.TextBox();
            this.txt_HoTen = new System.Windows.Forms.TextBox();
            this.lbl_MatKhau = new System.Windows.Forms.Label();
            this.lbl_HoTen = new System.Windows.Forms.Label();
            this.link_DangNhap = new System.Windows.Forms.LinkLabel();
            this.btn_DangKy = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.lbl_SDT = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.txt_TenTaiKhoan = new System.Windows.Forms.TextBox();
            this.lbl_TenTaiKhoan = new System.Windows.Forms.Label();
            this.txt_XacNhanMK = new System.Windows.Forms.TextBox();
            this.lbl_XacNhanMK = new System.Windows.Forms.Label();
            this.lbl_Question = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_MatKhau
            // 
            this.txt_MatKhau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_MatKhau.Location = new System.Drawing.Point(219, 353);
            this.txt_MatKhau.MinimumSize = new System.Drawing.Size(299, 41);
            this.txt_MatKhau.Multiline = true;
            this.txt_MatKhau.Name = "txt_MatKhau";
            this.txt_MatKhau.Size = new System.Drawing.Size(299, 41);
            this.txt_MatKhau.TabIndex = 28;
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_HoTen.Location = new System.Drawing.Point(219, 165);
            this.txt_HoTen.MinimumSize = new System.Drawing.Size(299, 41);
            this.txt_HoTen.Multiline = true;
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.Size = new System.Drawing.Size(299, 41);
            this.txt_HoTen.TabIndex = 27;
            // 
            // lbl_MatKhau
            // 
            this.lbl_MatKhau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_MatKhau.AutoSize = true;
            this.lbl_MatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MatKhau.Location = new System.Drawing.Point(116, 361);
            this.lbl_MatKhau.Name = "lbl_MatKhau";
            this.lbl_MatKhau.Size = new System.Drawing.Size(77, 20);
            this.lbl_MatKhau.TabIndex = 26;
            this.lbl_MatKhau.Text = "Mật khẩu";
            // 
            // lbl_HoTen
            // 
            this.lbl_HoTen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_HoTen.AutoSize = true;
            this.lbl_HoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HoTen.Location = new System.Drawing.Point(134, 173);
            this.lbl_HoTen.Name = "lbl_HoTen";
            this.lbl_HoTen.Size = new System.Drawing.Size(59, 20);
            this.lbl_HoTen.TabIndex = 25;
            this.lbl_HoTen.Text = "Họ tên";
            // 
            // link_DangNhap
            // 
            this.link_DangNhap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.link_DangNhap.AutoSize = true;
            this.link_DangNhap.Location = new System.Drawing.Point(421, 458);
            this.link_DangNhap.Name = "link_DangNhap";
            this.link_DangNhap.Size = new System.Drawing.Size(72, 16);
            this.link_DangNhap.TabIndex = 24;
            this.link_DangNhap.TabStop = true;
            this.link_DangNhap.Text = "Đăng nhập";
            this.link_DangNhap.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_DangNhap_LinkClicked);
            // 
            // btn_DangKy
            // 
            this.btn_DangKy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_DangKy.Location = new System.Drawing.Point(289, 495);
            this.btn_DangKy.MinimumSize = new System.Drawing.Size(165, 50);
            this.btn_DangKy.Name = "btn_DangKy";
            this.btn_DangKy.Size = new System.Drawing.Size(165, 50);
            this.btn_DangKy.TabIndex = 22;
            this.btn_DangKy.Text = "Đăng ký";
            this.btn_DangKy.UseVisualStyleBackColor = true;
            this.btn_DangKy.Click += new System.EventHandler(this.btn_DangNhap_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::Library_Management.Properties.Resources.logo1;
            this.pictureBox1.InitialImage = global::Library_Management.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(266, -23);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(150, 135);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // txt_SDT
            // 
            this.txt_SDT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_SDT.Location = new System.Drawing.Point(219, 212);
            this.txt_SDT.MinimumSize = new System.Drawing.Size(299, 41);
            this.txt_SDT.Multiline = true;
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(299, 41);
            this.txt_SDT.TabIndex = 30;
            // 
            // lbl_SDT
            // 
            this.lbl_SDT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_SDT.AutoSize = true;
            this.lbl_SDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SDT.Location = new System.Drawing.Point(91, 221);
            this.lbl_SDT.Name = "lbl_SDT";
            this.lbl_SDT.Size = new System.Drawing.Size(106, 20);
            this.lbl_SDT.TabIndex = 29;
            this.lbl_SDT.Text = "Số điện thoại";
            // 
            // txt_Email
            // 
            this.txt_Email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Email.Location = new System.Drawing.Point(219, 259);
            this.txt_Email.MinimumSize = new System.Drawing.Size(299, 41);
            this.txt_Email.Multiline = true;
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(299, 41);
            this.txt_Email.TabIndex = 32;
            // 
            // lbl_Email
            // 
            this.lbl_Email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.Location = new System.Drawing.Point(142, 267);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(51, 20);
            this.lbl_Email.TabIndex = 31;
            this.lbl_Email.Text = "Email";
            // 
            // txt_TenTaiKhoan
            // 
            this.txt_TenTaiKhoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_TenTaiKhoan.Location = new System.Drawing.Point(219, 306);
            this.txt_TenTaiKhoan.MinimumSize = new System.Drawing.Size(299, 41);
            this.txt_TenTaiKhoan.Multiline = true;
            this.txt_TenTaiKhoan.Name = "txt_TenTaiKhoan";
            this.txt_TenTaiKhoan.Size = new System.Drawing.Size(299, 41);
            this.txt_TenTaiKhoan.TabIndex = 34;
            // 
            // lbl_TenTaiKhoan
            // 
            this.lbl_TenTaiKhoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_TenTaiKhoan.AutoSize = true;
            this.lbl_TenTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenTaiKhoan.Location = new System.Drawing.Point(84, 314);
            this.lbl_TenTaiKhoan.Name = "lbl_TenTaiKhoan";
            this.lbl_TenTaiKhoan.Size = new System.Drawing.Size(109, 20);
            this.lbl_TenTaiKhoan.TabIndex = 33;
            this.lbl_TenTaiKhoan.Text = "Tên tài khoản";
            // 
            // txt_XacNhanMK
            // 
            this.txt_XacNhanMK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_XacNhanMK.Location = new System.Drawing.Point(219, 400);
            this.txt_XacNhanMK.MinimumSize = new System.Drawing.Size(299, 41);
            this.txt_XacNhanMK.Multiline = true;
            this.txt_XacNhanMK.Name = "txt_XacNhanMK";
            this.txt_XacNhanMK.Size = new System.Drawing.Size(299, 41);
            this.txt_XacNhanMK.TabIndex = 36;
            // 
            // lbl_XacNhanMK
            // 
            this.lbl_XacNhanMK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_XacNhanMK.AutoSize = true;
            this.lbl_XacNhanMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_XacNhanMK.Location = new System.Drawing.Point(54, 409);
            this.lbl_XacNhanMK.Name = "lbl_XacNhanMK";
            this.lbl_XacNhanMK.Size = new System.Drawing.Size(152, 20);
            this.lbl_XacNhanMK.TabIndex = 35;
            this.lbl_XacNhanMK.Text = "Xác nhận mật khẩu";
            // 
            // lbl_Question
            // 
            this.lbl_Question.AutoSize = true;
            this.lbl_Question.Location = new System.Drawing.Point(276, 458);
            this.lbl_Question.Name = "lbl_Question";
            this.lbl_Question.Size = new System.Drawing.Size(132, 16);
            this.lbl_Question.TabIndex = 37;
            this.lbl_Question.Text = "Bạn đã có tài khoản?";
            // 
            // Form_DangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(722, 557);
            this.Controls.Add(this.lbl_Question);
            this.Controls.Add(this.txt_XacNhanMK);
            this.Controls.Add(this.lbl_XacNhanMK);
            this.Controls.Add(this.txt_TenTaiKhoan);
            this.Controls.Add(this.lbl_TenTaiKhoan);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.txt_SDT);
            this.Controls.Add(this.lbl_SDT);
            this.Controls.Add(this.txt_MatKhau);
            this.Controls.Add(this.txt_HoTen);
            this.Controls.Add(this.lbl_MatKhau);
            this.Controls.Add(this.lbl_HoTen);
            this.Controls.Add(this.link_DangNhap);
            this.Controls.Add(this.btn_DangKy);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form_DangKy";
            this.Text = "Đăng ký";
            this.Load += new System.EventHandler(this.Form_DangKy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_MatKhau;
        private System.Windows.Forms.TextBox txt_HoTen;
        private System.Windows.Forms.Label lbl_MatKhau;
        private System.Windows.Forms.Label lbl_HoTen;
        private System.Windows.Forms.LinkLabel link_DangNhap;
        private System.Windows.Forms.Button btn_DangKy;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.Label lbl_SDT;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.TextBox txt_TenTaiKhoan;
        private System.Windows.Forms.Label lbl_TenTaiKhoan;
        private System.Windows.Forms.TextBox txt_XacNhanMK;
        private System.Windows.Forms.Label lbl_XacNhanMK;
        private System.Windows.Forms.Label lbl_Question;
    }
}