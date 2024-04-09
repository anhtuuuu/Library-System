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

        private void Form_DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void link_QuenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_QuenMatKhau quenMatKhau = new Form_QuenMatKhau();
            quenMatKhau.ShowDialog();
        }
    }
}
