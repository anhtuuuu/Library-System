namespace Library_Management
{
    partial class Form_DangNhap
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.txt_MatKhau = new System.Windows.Forms.TextBox();
            this.txt_TaiKhoan = new System.Windows.Forms.TextBox();
            this.lbl_MatKhau = new System.Windows.Forms.Label();
            this.lbl_TaiKhoan = new System.Windows.Forms.Label();
            this.link_QuenMatKhau = new System.Windows.Forms.LinkLabel();
            this.chk_HienMatKhau = new System.Windows.Forms.CheckBox();
            this.btn_DangNhap = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_MatKhau
            // 
            this.txt_MatKhau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_MatKhau.Location = new System.Drawing.Point(292, 252);
            this.txt_MatKhau.MinimumSize = new System.Drawing.Size(246, 41);
            this.txt_MatKhau.Multiline = true;
            this.txt_MatKhau.Name = "txt_MatKhau";
            this.txt_MatKhau.Size = new System.Drawing.Size(246, 41);
            this.txt_MatKhau.TabIndex = 20;
            // 
            // txt_TaiKhoan
            // 
            this.txt_TaiKhoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_TaiKhoan.Location = new System.Drawing.Point(292, 190);
            this.txt_TaiKhoan.MinimumSize = new System.Drawing.Size(246, 41);
            this.txt_TaiKhoan.Multiline = true;
            this.txt_TaiKhoan.Name = "txt_TaiKhoan";
            this.txt_TaiKhoan.Size = new System.Drawing.Size(246, 41);
            this.txt_TaiKhoan.TabIndex = 19;
            // 
            // lbl_MatKhau
            // 
            this.lbl_MatKhau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_MatKhau.AutoSize = true;
            this.lbl_MatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MatKhau.Location = new System.Drawing.Point(194, 262);
            this.lbl_MatKhau.Name = "lbl_MatKhau";
            this.lbl_MatKhau.Size = new System.Drawing.Size(77, 20);
            this.lbl_MatKhau.TabIndex = 18;
            this.lbl_MatKhau.Text = "Mật khẩu";
            // 
            // lbl_TaiKhoan
            // 
            this.lbl_TaiKhoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_TaiKhoan.AutoSize = true;
            this.lbl_TaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TaiKhoan.Location = new System.Drawing.Point(190, 200);
            this.lbl_TaiKhoan.Name = "lbl_TaiKhoan";
            this.lbl_TaiKhoan.Size = new System.Drawing.Size(81, 20);
            this.lbl_TaiKhoan.TabIndex = 17;
            this.lbl_TaiKhoan.Text = "Tài khoản";
            // 
            // link_QuenMatKhau
            // 
            this.link_QuenMatKhau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.link_QuenMatKhau.AutoSize = true;
            this.link_QuenMatKhau.Location = new System.Drawing.Point(442, 312);
            this.link_QuenMatKhau.Name = "link_QuenMatKhau";
            this.link_QuenMatKhau.Size = new System.Drawing.Size(96, 16);
            this.link_QuenMatKhau.TabIndex = 16;
            this.link_QuenMatKhau.TabStop = true;
            this.link_QuenMatKhau.Text = "Quên mật khẩu";
            this.link_QuenMatKhau.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_QuenMatKhau_LinkClicked);
            // 
            // chk_HienMatKhau
            // 
            this.chk_HienMatKhau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chk_HienMatKhau.AutoSize = true;
            this.chk_HienMatKhau.Location = new System.Drawing.Point(292, 312);
            this.chk_HienMatKhau.Name = "chk_HienMatKhau";
            this.chk_HienMatKhau.Size = new System.Drawing.Size(130, 20);
            this.chk_HienMatKhau.TabIndex = 15;
            this.chk_HienMatKhau.Text = "Hiển thị mật khẩu";
            this.chk_HienMatKhau.UseVisualStyleBackColor = true;
            // 
            // btn_DangNhap
            // 
            this.btn_DangNhap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_DangNhap.Location = new System.Drawing.Point(343, 361);
            this.btn_DangNhap.MinimumSize = new System.Drawing.Size(140, 50);
            this.btn_DangNhap.Name = "btn_DangNhap";
            this.btn_DangNhap.Size = new System.Drawing.Size(140, 50);
            this.btn_DangNhap.TabIndex = 14;
            this.btn_DangNhap.Text = "Đăng nhập";
            this.btn_DangNhap.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::Library_Management.Properties.Resources.logo1;
            this.pictureBox1.InitialImage = global::Library_Management.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(277, -16);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(276, 247);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(276, 247);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Form_DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_MatKhau);
            this.Controls.Add(this.txt_TaiKhoan);
            this.Controls.Add(this.lbl_MatKhau);
            this.Controls.Add(this.lbl_TaiKhoan);
            this.Controls.Add(this.link_QuenMatKhau);
            this.Controls.Add(this.chk_HienMatKhau);
            this.Controls.Add(this.btn_DangNhap);
            this.Controls.Add(this.pictureBox1);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "Form_DangNhap";
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.Form_DangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox txt_MatKhau;
        private System.Windows.Forms.TextBox txt_TaiKhoan;
        private System.Windows.Forms.Label lbl_MatKhau;
        private System.Windows.Forms.Label lbl_TaiKhoan;
        private System.Windows.Forms.LinkLabel link_QuenMatKhau;
        private System.Windows.Forms.CheckBox chk_HienMatKhau;
        private System.Windows.Forms.Button btn_DangNhap;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

