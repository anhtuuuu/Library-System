namespace Library_Management
{
    partial class Form_QuanLySach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_QuanLySach));
            this.button1 = new System.Windows.Forms.Button();
            this.imgHinhAnh = new System.Windows.Forms.ImageList(this.components);
            this.lvw_DanhSachDocGia = new System.Windows.Forms.ListView();
            this.col_DG = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_TenKH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_DiaChi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_SDT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_NgayTao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_TrangThai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbl_DanhSachDocGia = new System.Windows.Forms.Label();
            this.lbl_Tim = new System.Windows.Forms.Label();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.lbl_TenSach = new System.Windows.Forms.Label();
            this.lbl_MaSanPham = new System.Windows.Forms.Label();
            this.btn_TroLai = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_LamMoi = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.cbo_MaSach = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbl_MaLoaiSach = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.ImageIndex = 6;
            this.button1.ImageList = this.imgHinhAnh;
            this.button1.Location = new System.Drawing.Point(875, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 26);
            this.button1.TabIndex = 61;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // imgHinhAnh
            // 
            this.imgHinhAnh.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgHinhAnh.ImageStream")));
            this.imgHinhAnh.TransparentColor = System.Drawing.Color.Transparent;
            this.imgHinhAnh.Images.SetKeyName(0, "addimage.png");
            this.imgHinhAnh.Images.SetKeyName(1, "refresh.png");
            this.imgHinhAnh.Images.SetKeyName(2, "delete-181.png");
            this.imgHinhAnh.Images.SetKeyName(3, "Exit.png");
            this.imgHinhAnh.Images.SetKeyName(4, "back.jpg");
            this.imgHinhAnh.Images.SetKeyName(5, "sua1.png");
            this.imgHinhAnh.Images.SetKeyName(6, "search.png");
            this.imgHinhAnh.Images.SetKeyName(7, "save.png");
            this.imgHinhAnh.Images.SetKeyName(8, "DocGia.png");
            this.imgHinhAnh.Images.SetKeyName(9, "OIP.jpg");
            // 
            // lvw_DanhSachDocGia
            // 
            this.lvw_DanhSachDocGia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvw_DanhSachDocGia.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_DG,
            this.col_TenKH,
            this.col_DiaChi,
            this.col_Email,
            this.col_SDT,
            this.col_NgayTao,
            this.col_TrangThai,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvw_DanhSachDocGia.FullRowSelect = true;
            this.lvw_DanhSachDocGia.GridLines = true;
            this.lvw_DanhSachDocGia.HideSelection = false;
            this.lvw_DanhSachDocGia.Location = new System.Drawing.Point(-1, 335);
            this.lvw_DanhSachDocGia.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lvw_DanhSachDocGia.Name = "lvw_DanhSachDocGia";
            this.lvw_DanhSachDocGia.Size = new System.Drawing.Size(942, 358);
            this.lvw_DanhSachDocGia.TabIndex = 54;
            this.lvw_DanhSachDocGia.UseCompatibleStateImageBehavior = false;
            this.lvw_DanhSachDocGia.View = System.Windows.Forms.View.Details;
            this.lvw_DanhSachDocGia.VirtualMode = true;
            // 
            // col_DG
            // 
            this.col_DG.Text = "Mã sách";
            this.col_DG.Width = 100;
            // 
            // col_TenKH
            // 
            this.col_TenKH.Text = "Tên sách";
            this.col_TenKH.Width = 100;
            // 
            // col_DiaChi
            // 
            this.col_DiaChi.Text = "Xuất xứ";
            this.col_DiaChi.Width = 100;
            // 
            // col_Email
            // 
            this.col_Email.Text = "Giá nhập";
            this.col_Email.Width = 100;
            // 
            // col_SDT
            // 
            this.col_SDT.Text = "Giá cho thuê";
            this.col_SDT.Width = 100;
            // 
            // col_NgayTao
            // 
            this.col_NgayTao.Text = "Đơn vị tính";
            this.col_NgayTao.Width = 100;
            // 
            // col_TrangThai
            // 
            this.col_TrangThai.Text = "Mã nhà cung cấp";
            this.col_TrangThai.Width = 100;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Số lượng";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Trạng thái";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Khuyến mãi";
            this.columnHeader3.Width = 100;
            // 
            // lbl_DanhSachDocGia
            // 
            this.lbl_DanhSachDocGia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_DanhSachDocGia.AutoSize = true;
            this.lbl_DanhSachDocGia.Location = new System.Drawing.Point(11, 307);
            this.lbl_DanhSachDocGia.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_DanhSachDocGia.Name = "lbl_DanhSachDocGia";
            this.lbl_DanhSachDocGia.Size = new System.Drawing.Size(110, 16);
            this.lbl_DanhSachDocGia.TabIndex = 53;
            this.lbl_DanhSachDocGia.Text = "Danh Sách Sách:";
            // 
            // lbl_Tim
            // 
            this.lbl_Tim.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_Tim.AutoSize = true;
            this.lbl_Tim.Location = new System.Drawing.Point(672, 306);
            this.lbl_Tim.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_Tim.Name = "lbl_Tim";
            this.lbl_Tim.Size = new System.Drawing.Size(33, 16);
            this.lbl_Tim.TabIndex = 52;
            this.lbl_Tim.Text = "Tìm:";
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txt_TimKiem.Location = new System.Drawing.Point(711, 299);
            this.txt_TimKiem.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txt_TimKiem.MaximumSize = new System.Drawing.Size(156, 22);
            this.txt_TimKiem.MinimumSize = new System.Drawing.Size(156, 22);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(156, 22);
            this.txt_TimKiem.TabIndex = 51;
            // 
            // lbl_TenSach
            // 
            this.lbl_TenSach.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_TenSach.AutoSize = true;
            this.lbl_TenSach.Font = new System.Drawing.Font("Times New Roman", 9.25F);
            this.lbl_TenSach.Location = new System.Drawing.Point(36, 65);
            this.lbl_TenSach.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_TenSach.Name = "lbl_TenSach";
            this.lbl_TenSach.Size = new System.Drawing.Size(66, 19);
            this.lbl_TenSach.TabIndex = 38;
            this.lbl_TenSach.Text = "Tên Sách";
            // 
            // lbl_MaSanPham
            // 
            this.lbl_MaSanPham.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_MaSanPham.AutoSize = true;
            this.lbl_MaSanPham.Font = new System.Drawing.Font("Times New Roman", 9.25F);
            this.lbl_MaSanPham.Location = new System.Drawing.Point(10, 19);
            this.lbl_MaSanPham.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_MaSanPham.Name = "lbl_MaSanPham";
            this.lbl_MaSanPham.Size = new System.Drawing.Size(64, 19);
            this.lbl_MaSanPham.TabIndex = 37;
            this.lbl_MaSanPham.Text = "Mã Sách";
            // 
            // btn_TroLai
            // 
            this.btn_TroLai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_TroLai.ImageIndex = 9;
            this.btn_TroLai.ImageList = this.imgHinhAnh;
            this.btn_TroLai.Location = new System.Drawing.Point(344, 235);
            this.btn_TroLai.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btn_TroLai.MaximumSize = new System.Drawing.Size(50, 34);
            this.btn_TroLai.MinimumSize = new System.Drawing.Size(50, 34);
            this.btn_TroLai.Name = "btn_TroLai";
            this.btn_TroLai.Size = new System.Drawing.Size(50, 34);
            this.btn_TroLai.TabIndex = 36;
            this.btn_TroLai.UseVisualStyleBackColor = true;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Thoat.ImageIndex = 3;
            this.btn_Thoat.ImageList = this.imgHinhAnh;
            this.btn_Thoat.Location = new System.Drawing.Point(424, 235);
            this.btn_Thoat.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btn_Thoat.MaximumSize = new System.Drawing.Size(50, 34);
            this.btn_Thoat.MinimumSize = new System.Drawing.Size(50, 34);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(50, 34);
            this.btn_Thoat.TabIndex = 35;
            this.btn_Thoat.UseVisualStyleBackColor = true;
            // 
            // btn_LamMoi
            // 
            this.btn_LamMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_LamMoi.ImageIndex = 1;
            this.btn_LamMoi.ImageList = this.imgHinhAnh;
            this.btn_LamMoi.Location = new System.Drawing.Point(255, 235);
            this.btn_LamMoi.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btn_LamMoi.MaximumSize = new System.Drawing.Size(50, 34);
            this.btn_LamMoi.MinimumSize = new System.Drawing.Size(50, 34);
            this.btn_LamMoi.Name = "btn_LamMoi";
            this.btn_LamMoi.Size = new System.Drawing.Size(50, 34);
            this.btn_LamMoi.TabIndex = 34;
            this.btn_LamMoi.UseVisualStyleBackColor = true;
            // 
            // btn_Sua
            // 
            this.btn_Sua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Sua.ImageIndex = 5;
            this.btn_Sua.ImageList = this.imgHinhAnh;
            this.btn_Sua.Location = new System.Drawing.Point(176, 235);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btn_Sua.MaximumSize = new System.Drawing.Size(50, 34);
            this.btn_Sua.MinimumSize = new System.Drawing.Size(50, 34);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(50, 34);
            this.btn_Sua.TabIndex = 33;
            this.btn_Sua.UseVisualStyleBackColor = true;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Xoa.ImageIndex = 2;
            this.btn_Xoa.ImageList = this.imgHinhAnh;
            this.btn_Xoa.Location = new System.Drawing.Point(98, 235);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btn_Xoa.MaximumSize = new System.Drawing.Size(50, 34);
            this.btn_Xoa.MinimumSize = new System.Drawing.Size(50, 34);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(50, 34);
            this.btn_Xoa.TabIndex = 32;
            this.btn_Xoa.UseVisualStyleBackColor = true;
            // 
            // btn_Them
            // 
            this.btn_Them.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Them.ImageIndex = 0;
            this.btn_Them.ImageList = this.imgHinhAnh;
            this.btn_Them.Location = new System.Drawing.Point(22, 235);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btn_Them.MaximumSize = new System.Drawing.Size(50, 34);
            this.btn_Them.MinimumSize = new System.Drawing.Size(50, 34);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(50, 34);
            this.btn_Them.TabIndex = 31;
            this.btn_Them.UseVisualStyleBackColor = true;
            // 
            // cbo_MaSach
            // 
            this.cbo_MaSach.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbo_MaSach.FormattingEnabled = true;
            this.cbo_MaSach.Location = new System.Drawing.Point(82, 16);
            this.cbo_MaSach.Name = "cbo_MaSach";
            this.cbo_MaSach.Size = new System.Drawing.Size(105, 24);
            this.cbo_MaSach.TabIndex = 62;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(321, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(105, 24);
            this.comboBox1.TabIndex = 64;
            // 
            // lbl_MaLoaiSach
            // 
            this.lbl_MaLoaiSach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_MaLoaiSach.AutoSize = true;
            this.lbl_MaLoaiSach.Font = new System.Drawing.Font("Times New Roman", 9.25F);
            this.lbl_MaLoaiSach.Location = new System.Drawing.Point(218, 19);
            this.lbl_MaLoaiSach.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_MaLoaiSach.Name = "lbl_MaLoaiSach";
            this.lbl_MaLoaiSach.Size = new System.Drawing.Size(95, 19);
            this.lbl_MaLoaiSach.TabIndex = 63;
            this.lbl_MaLoaiSach.Text = "Mã Loại Sách";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(116, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 22);
            this.textBox1.TabIndex = 65;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(434, 59);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(105, 22);
            this.textBox2.TabIndex = 67;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.25F);
            this.label1.Location = new System.Drawing.Point(364, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 19);
            this.label1.TabIndex = 66;
            this.label1.Text = "Xuất Xứ";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Location = new System.Drawing.Point(116, 106);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(170, 22);
            this.textBox3.TabIndex = 69;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.25F);
            this.label2.Location = new System.Drawing.Point(36, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 68;
            this.label2.Text = "Giá Nhập";
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.Location = new System.Drawing.Point(116, 149);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(170, 22);
            this.textBox4.TabIndex = 73;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.25F);
            this.label3.Location = new System.Drawing.Point(10, 149);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 19);
            this.label3.TabIndex = 72;
            this.label3.Text = "Giá Cho Thuê";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.25F);
            this.label4.Location = new System.Drawing.Point(340, 112);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 19);
            this.label4.TabIndex = 74;
            this.label4.Text = "Đơn Vị Tính:";
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(586, 16);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(105, 24);
            this.comboBox2.TabIndex = 77;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.25F);
            this.label6.Location = new System.Drawing.Point(449, 19);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 19);
            this.label6.TabIndex = 76;
            this.label6.Text = "Mã Nhà Cung Cấp:";
            // 
            // comboBox3
            // 
            this.comboBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(434, 109);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(105, 24);
            this.comboBox3.TabIndex = 78;
            // 
            // textBox5
            // 
            this.textBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox5.Location = new System.Drawing.Point(434, 149);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(105, 22);
            this.textBox5.TabIndex = 80;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.25F);
            this.label5.Location = new System.Drawing.Point(356, 149);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 19);
            this.label5.TabIndex = 79;
            this.label5.Text = "Số Lượng";
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(14, 197);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(95, 20);
            this.checkBox1.TabIndex = 81;
            this.checkBox1.Text = "Trạng Thái";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(148, 197);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(98, 20);
            this.checkBox2.TabIndex = 82;
            this.checkBox2.Text = "Khuyến Mãi";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Library_Management.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(606, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 83;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.25F);
            this.label7.Location = new System.Drawing.Point(660, 220);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 19);
            this.label7.TabIndex = 86;
            this.label7.Text = "Hình Ảnh";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9.25F);
            this.label8.Location = new System.Drawing.Point(29, 272);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 19);
            this.label8.TabIndex = 87;
            this.label8.Text = "Thêm";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 9.25F);
            this.label9.Location = new System.Drawing.Point(104, 272);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 19);
            this.label9.TabIndex = 88;
            this.label9.Text = "Xóa";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 9.25F);
            this.label10.Location = new System.Drawing.Point(180, 272);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 19);
            this.label10.TabIndex = 89;
            this.label10.Text = "Sửa";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 9.25F);
            this.label11.Location = new System.Drawing.Point(251, 272);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 19);
            this.label11.TabIndex = 90;
            this.label11.Text = "Làm mới";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 9.25F);
            this.label14.Location = new System.Drawing.Point(337, 272);
            this.label14.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 19);
            this.label14.TabIndex = 93;
            this.label14.Text = "In hóa đơn";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 9.25F);
            this.label15.Location = new System.Drawing.Point(430, 272);
            this.label15.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 19);
            this.label15.TabIndex = 94;
            this.label15.Text = "Thoát";
            // 
            // Form_QuanLySach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(938, 568);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbl_MaLoaiSach);
            this.Controls.Add(this.cbo_MaSach);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lvw_DanhSachDocGia);
            this.Controls.Add(this.lbl_DanhSachDocGia);
            this.Controls.Add(this.lbl_Tim);
            this.Controls.Add(this.txt_TimKiem);
            this.Controls.Add(this.lbl_TenSach);
            this.Controls.Add(this.lbl_MaSanPham);
            this.Controls.Add(this.btn_TroLai);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_LamMoi);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Them);
            this.MinimumSize = new System.Drawing.Size(956, 615);
            this.Name = "Form_QuanLySach";
            this.Text = "Quản lý sách";
            this.Load += new System.EventHandler(this.Form_QuanLySach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView lvw_DanhSachDocGia;
        private System.Windows.Forms.ColumnHeader col_DG;
        private System.Windows.Forms.ColumnHeader col_TenKH;
        private System.Windows.Forms.ColumnHeader col_DiaChi;
        private System.Windows.Forms.ColumnHeader col_Email;
        private System.Windows.Forms.ColumnHeader col_SDT;
        private System.Windows.Forms.ColumnHeader col_NgayTao;
        private System.Windows.Forms.ColumnHeader col_TrangThai;
        private System.Windows.Forms.Label lbl_DanhSachDocGia;
        private System.Windows.Forms.Label lbl_Tim;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.Label lbl_TenSach;
        private System.Windows.Forms.Label lbl_MaSanPham;
        private System.Windows.Forms.Button btn_TroLai;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_LamMoi;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.ImageList imgHinhAnh;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ComboBox cbo_MaSach;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbl_MaLoaiSach;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
    }
}