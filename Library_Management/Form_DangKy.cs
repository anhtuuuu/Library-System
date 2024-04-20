using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Library_Management
{
    public partial class Form_DangKy : Form
    {
        public Form_DangKy()
        {
            InitializeComponent();
        }

        public bool kiemTraTenTaiKhoan(string s)
        {
            return Regex.IsMatch(s, "^[a-zA-Z0-9]{8,25}$");
        }
        
        public bool kiemTraEmail(string e)
        {
            return Regex.IsMatch(e, @"^[a-zA-Z0-9]{5,20}@gmail.com$");
        }
        private void Form_DangKy_Load(object sender, EventArgs e)
        {

        }
        Modify modify = new Modify();
        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            string hoTen = txt_HoTen.Text.Trim();
            string sdt = txt_SDT.Text.Trim();
            string email = txt_Email.Text.Trim();
            string tenTaiKhoan = txt_TenTaiKhoan.Text.Trim();
            string matKhau = txt_MatKhau.Text.Trim();
            string xacNhanMK = txt_XacNhanMK.Text.Trim();

            if (hoTen == "" || sdt == "" || email == "" || tenTaiKhoan == "" || matKhau == "" || xacNhanMK == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            if (!kiemTraTenTaiKhoan(tenTaiKhoan))
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản từ 8-25 ký tự bao gồm chữ hoa, chữ thường và số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(matKhau != xacNhanMK)
            {
                MessageBox.Show("Mật khẩu không trùng khớp. Vui lòng xác nhận lại mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!kiemTraEmail(email))
            {
                MessageBox.Show("Email không đúng định dạng. Vui lòng kiểm tra lại email.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (modify.TaiKhoans("SELECT * FROM TaiKhoan WHERE Email = '"+email+"'").Count != 0)
            {
                MessageBox.Show("Email này đã được đăng ký. Vui lòng đăng ký với email khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(modify.TaiKhoans("SELECT * FROM TaiKhoan WHERE Username = '" + tenTaiKhoan + "'").Count != 0)
            {
                MessageBox.Show("Tên tài khoản này đã được đăng ký. Vui lòng nhập tên tài khoản khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                int id = modify.TaiKhoans("SELECT * FROM TaiKhoan").Count + 1;
                string query = "INSERT INTO TaiKhoan VALUES ("+ id + ", N'" + hoTen +"','" + sdt + "','" + email + "','" + tenTaiKhoan + "','" + matKhau + "', 1)";
                modify.Command(query);
                DialogResult dlg;
                dlg = MessageBox.Show("Đăng ký tài khoản thành công.", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if(dlg == DialogResult.Yes)
                {
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi không đăng ký được tài khoản. Chi tiết: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void link_DangNhap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }
    }
}
