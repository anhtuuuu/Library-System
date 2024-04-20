using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace Library_Management
{
    public partial class Form_QuenMatKhau : Form
    {
        public Form_QuenMatKhau()
        {
            InitializeComponent();
        }
        Random random = new Random();
        int otp;
        int counter;
        private void btn_GuiOTP_Click(object sender, EventArgs e)
        {
            if(txt_EmailDaDangKy.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập email");
            }
            else
            {
                counter = timer_OTP.Interval / 1000;
                btn_GuiOTP.Enabled = false;
                lbl_Counter.Text = counter.ToString();
                timer_Counter.Start();
                timer_OTP.Start();  

                try
                {
                    otp = random.Next(10000, 100000);
                    var fromAddress = new MailAddress("anhtu18042004@gmail.com");
                    var toAddress = new MailAddress(txt_EmailDaDangKy.Text.Trim());
                    const string frompass = "qntg tnio ktji lgqk";
                    const string subject = "OTP code";
                    string body = otp.ToString();

                    var smtp = new SmtpClient
                    {
                        Host = "smtp.gmail.com",
                        Port = 587,
                        EnableSsl = true,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        UseDefaultCredentials = false,
                        Credentials = new NetworkCredential(fromAddress.Address, frompass),
                        Timeout = 200000
                    };

                    using (var message = new MailMessage(fromAddress, toAddress)
                    {
                        Subject = subject,
                        Body = body
                    })
                    {
                        smtp.Send(message);
                    }
                    MessageBox.Show("OTP đã được gửi qua email");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btn_XacNhanOTP_Click(object sender, EventArgs e)
        {
            if(txt_MaXacNhan.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mã xác nhận");
            }
            else
            {
                if (otp.ToString().Equals(txt_MaXacNhan.Text))
                {
                    MessageBox.Show("Xác nhận thành công");
                }
                else
                {
                    MessageBox.Show("Xác nhận thất bại");
                }
            }

            
        }

        private void Form_QuenMatKhau_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là muốn thoát không?", "Quên mật khẩu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void link_DangNhap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }

        private void timer_OTP_Tick(object sender, EventArgs e)
        {
            btn_GuiOTP.Enabled = true;
            if (counter == 0)
            {
                timer_OTP.Stop();
            }
        }

        private void timer_Counter_Tick(object sender, EventArgs e)
        {
            counter--;
            lbl_Counter.Text = counter.ToString();
            if (counter == 0)
            {
                lbl_Counter.Text = "";
                timer_Counter.Stop();
            }
        }

        private void Form_QuenMatKhau_Load(object sender, EventArgs e)
        {

        }
    }
}
