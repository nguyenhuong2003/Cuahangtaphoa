using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GUI
{
    public partial class GUI_DangNhap : Form
    {
        TaiKhoan TaiKhoan=new TaiKhoan();
        public GUI_DangNhap()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            BUS_TaiKhoan userBLL = new BUS_TaiKhoan();
            string username = txtTaiKhoan.Text;
            string password = txtMatKhau.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                // Nếu tên đăng nhập hoặc mật khẩu bị bỏ trống
                MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu.");
            }

            else
            {
                if (userBLL.ValidateLogin(username, password))
                {
                    MessageBox.Show("Đăng nhập thành công.");
                    this.Hide();
                    Menu mainMenu = new Menu();
                    mainMenu.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu.");
                }
            }



        }

        private void GUI_DangNhap_Load(object sender, EventArgs e)
        {

        }

        

        private void txtMatKhau_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtMatKhau.Text))
            {
                e.Cancel = true;
                txtMatKhau.Focus();
                errPass.SetError(txtMatKhau, "Bạn cần nhập Password!!!");

            }
            else
            {
                e.Cancel = false;
                errPass.SetError(txtMatKhau, "");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát ứng dụng không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();


            }
        }

        private void txtTaiKhoan_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtTaiKhoan .Text))
            {
                e.Cancel = true;
                txtTaiKhoan.Focus();
                errUser.SetError(txtTaiKhoan, "Ban cần nhập username!!!");
            }
            else
            {
                e.Cancel = false;
                errUser.SetError(txtTaiKhoan, "");
            }
        }

        private void chkShow_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShow.Checked)
                txtMatKhau .PasswordChar = (char)0;
            else
                txtMatKhau .PasswordChar = '*';
        }
    }
}
