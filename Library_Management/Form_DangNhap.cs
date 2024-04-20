using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management
{
    public partial class Form_DangNhap : Form
    {
        public Form_DangNhap()
        {
            InitializeComponent();
        }
        Modify modify = new Modify();

        private void Form_DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void link_QuenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_QuenMatKhau quenMatKhau = new Form_QuenMatKhau();
            quenMatKhau.ShowDialog();
        }

        private void link_DangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_DangKy form_DangKy = new Form_DangKy();
            form_DangKy.ShowDialog();
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            string tenTK = txt_TaiKhoan.Text;
            string matKhau = txt_MatKhau.Text;

            if (tenTK.Trim() == "") MessageBox.Show("Vui lòng nhập tên tài khoản");
            else if(matKhau.Trim() == "") MessageBox.Show("Vui lòng nhập mật khẩu");
            else
            {
                string query = "SELECT * FROM TaiKhoan WHERE Username = '" + tenTK + "' AND Password = '" + matKhau + "'";
                if(modify.TaiKhoans(query).Count != 0)
                {
                    MessageBox.Show("Đăng nhập thành công.", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    Form_GiaoDienQuanLyThuVien form_GiaoDienQuanLyThuVien = new Form_GiaoDienQuanLyThuVien();
                    form_GiaoDienQuanLyThuVien.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại, tên tài khoản hoặc mật khẩu không chính xác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void chk_HienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_HienMatKhau.Checked)
            {               
                txt_MatKhau.PasswordChar = '\0';
            }
            else
            {
                txt_MatKhau.PasswordChar = '*';
            }
        }
    }
}
