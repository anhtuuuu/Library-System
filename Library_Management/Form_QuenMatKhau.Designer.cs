﻿namespace Library_Management
{
    partial class Form_QuenMatKhau
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
            this.txt_MaXacNhan = new System.Windows.Forms.TextBox();
            this.txt_EmailDaDangKy = new System.Windows.Forms.TextBox();
            this.lbl_MatKhau = new System.Windows.Forms.Label();
            this.lbl_TaiKhoan = new System.Windows.Forms.Label();
            this.link_DangNhap = new System.Windows.Forms.LinkLabel();
            this.btn_GuiOTP = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_XacNhanOTP = new System.Windows.Forms.Button();
            this.timer_OTP = new System.Windows.Forms.Timer(this.components);
            this.lbl_Counter = new System.Windows.Forms.Label();
            this.timer_Counter = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_MaXacNhan
            // 
            this.txt_MaXacNhan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_MaXacNhan.Location = new System.Drawing.Point(280, 270);
            this.txt_MaXacNhan.MinimumSize = new System.Drawing.Size(129, 41);
            this.txt_MaXacNhan.Multiline = true;
            this.txt_MaXacNhan.Name = "txt_MaXacNhan";
            this.txt_MaXacNhan.Size = new System.Drawing.Size(129, 41);
            this.txt_MaXacNhan.TabIndex = 28;
            // 
            // txt_EmailDaDangKy
            // 
            this.txt_EmailDaDangKy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_EmailDaDangKy.Location = new System.Drawing.Point(280, 208);
            this.txt_EmailDaDangKy.MinimumSize = new System.Drawing.Size(246, 41);
            this.txt_EmailDaDangKy.Multiline = true;
            this.txt_EmailDaDangKy.Name = "txt_EmailDaDangKy";
            this.txt_EmailDaDangKy.Size = new System.Drawing.Size(246, 41);
            this.txt_EmailDaDangKy.TabIndex = 27;
            // 
            // lbl_MatKhau
            // 
            this.lbl_MatKhau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_MatKhau.AutoSize = true;
            this.lbl_MatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MatKhau.Location = new System.Drawing.Point(150, 279);
            this.lbl_MatKhau.Name = "lbl_MatKhau";
            this.lbl_MatKhau.Size = new System.Drawing.Size(109, 20);
            this.lbl_MatKhau.TabIndex = 26;
            this.lbl_MatKhau.Text = "Mã xác nhận:";
            // 
            // lbl_TaiKhoan
            // 
            this.lbl_TaiKhoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_TaiKhoan.AutoSize = true;
            this.lbl_TaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TaiKhoan.Location = new System.Drawing.Point(118, 217);
            this.lbl_TaiKhoan.Name = "lbl_TaiKhoan";
            this.lbl_TaiKhoan.Size = new System.Drawing.Size(141, 20);
            this.lbl_TaiKhoan.TabIndex = 25;
            this.lbl_TaiKhoan.Text = "Email đã đăng ký:";
            // 
            // link_DangNhap
            // 
            this.link_DangNhap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.link_DangNhap.AutoSize = true;
            this.link_DangNhap.Location = new System.Drawing.Point(454, 323);
            this.link_DangNhap.Name = "link_DangNhap";
            this.link_DangNhap.Size = new System.Drawing.Size(72, 16);
            this.link_DangNhap.TabIndex = 24;
            this.link_DangNhap.TabStop = true;
            this.link_DangNhap.Text = "Đăng nhập";
            this.link_DangNhap.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_DangNhap_LinkClicked);
            // 
            // btn_GuiOTP
            // 
            this.btn_GuiOTP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_GuiOTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GuiOTP.Location = new System.Drawing.Point(415, 270);
            this.btn_GuiOTP.MinimumSize = new System.Drawing.Size(81, 41);
            this.btn_GuiOTP.Name = "btn_GuiOTP";
            this.btn_GuiOTP.Size = new System.Drawing.Size(111, 41);
            this.btn_GuiOTP.TabIndex = 22;
            this.btn_GuiOTP.Text = "Gửi OTP";
            this.btn_GuiOTP.UseVisualStyleBackColor = true;
            this.btn_GuiOTP.Click += new System.EventHandler(this.btn_GuiOTP_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::Library_Management.Properties.Resources.logo1;
            this.pictureBox1.InitialImage = global::Library_Management.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(265, 2);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(276, 247);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(276, 247);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // btn_XacNhanOTP
            // 
            this.btn_XacNhanOTP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_XacNhanOTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XacNhanOTP.Location = new System.Drawing.Point(318, 359);
            this.btn_XacNhanOTP.MinimumSize = new System.Drawing.Size(168, 55);
            this.btn_XacNhanOTP.Name = "btn_XacNhanOTP";
            this.btn_XacNhanOTP.Size = new System.Drawing.Size(168, 55);
            this.btn_XacNhanOTP.TabIndex = 29;
            this.btn_XacNhanOTP.Text = "Xác nhận OTP";
            this.btn_XacNhanOTP.UseVisualStyleBackColor = true;
            this.btn_XacNhanOTP.Click += new System.EventHandler(this.btn_XacNhanOTP_Click);
            // 
            // timer_OTP
            // 
            this.timer_OTP.Interval = 6000;
            this.timer_OTP.Tick += new System.EventHandler(this.timer_OTP_Tick);
            // 
            // lbl_Counter
            // 
            this.lbl_Counter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Counter.AutoSize = true;
            this.lbl_Counter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Counter.Location = new System.Drawing.Point(541, 279);
            this.lbl_Counter.Name = "lbl_Counter";
            this.lbl_Counter.Size = new System.Drawing.Size(0, 20);
            this.lbl_Counter.TabIndex = 30;
            // 
            // timer_Counter
            // 
            this.timer_Counter.Interval = 1000;
            this.timer_Counter.Tick += new System.EventHandler(this.timer_Counter_Tick);
            // 
            // Form_QuenMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Counter);
            this.Controls.Add(this.btn_XacNhanOTP);
            this.Controls.Add(this.txt_MaXacNhan);
            this.Controls.Add(this.txt_EmailDaDangKy);
            this.Controls.Add(this.lbl_MatKhau);
            this.Controls.Add(this.lbl_TaiKhoan);
            this.Controls.Add(this.link_DangNhap);
            this.Controls.Add(this.btn_GuiOTP);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form_QuenMatKhau";
            this.Text = "Quên mật khẩu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_QuenMatKhau_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_MaXacNhan;
        private System.Windows.Forms.TextBox txt_EmailDaDangKy;
        private System.Windows.Forms.Label lbl_MatKhau;
        private System.Windows.Forms.Label lbl_TaiKhoan;
        private System.Windows.Forms.LinkLabel link_DangNhap;
        private System.Windows.Forms.Button btn_GuiOTP;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_XacNhanOTP;
        private System.Windows.Forms.Timer timer_OTP;
        private System.Windows.Forms.Label lbl_Counter;
        private System.Windows.Forms.Timer timer_Counter;
    }
}