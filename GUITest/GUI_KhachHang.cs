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

namespace GUI
{
    public partial class GUI_KhachHang : Form
    {
        public GUI_KhachHang()
        {
            InitializeComponent();
        }
        BUS_KhachHang  buskh  = new BUS_KhachHang();


        private void GUI_KhachHang_Load(object sender, EventArgs e)
        {
            dgvDSKH .DataSource = buskh.getData();
            loaddgv();
        }
        void loaddgv()
        {
            dgvDSKH .DataSource = buskh.getData();
            dgvDSKH.Columns[0].HeaderText = "Mã khách hàng ";
            dgvDSKH .Columns[1].HeaderText = "Tên khách hàng ";
            dgvDSKH.Columns[2].HeaderText = "Địa chỉ khách hàng ";
            dgvDSKH.Columns[3].HeaderText = "Email khách hàng ";
            dgvDSKH.Columns[4].HeaderText = "Số điện thoại khách hàng";

            dgvDSKH.Columns[4].DefaultCellStyle.Format = "#,###";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ma = txtMaKH.Text;
            string ten = txtTenKH.Text;
            string diachi  = txtDiaChiKH .Text;

            string email  = txtEmailKH .Text;
            string sdt = txtSDTKH .Text;

            KhachHang kh=new KhachHang(ma,ten,diachi,email,sdt );
            if (string.IsNullOrEmpty(txtTenKH.Text))
            {
                MessageBox.Show("Cảnh báo: Tên khách hàng không không được trống!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtDiaChiKH.Text))
            {
                MessageBox.Show("Cảnh báo: Địa chỉ không được trống!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (buskh.Kiemtraemail(email) == true)
            {
                if (buskh.IsValidPhoneNumber(sdt) == true)
                //buskh.suaKH(kh);
                {
                    if (buskh.kiemtramatrung(ma) == 1)
                    {
                        MessageBox.Show("Mã đã tồn tại, vui lòng nhập lại mã!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (buskh.themKH(kh) == true)
                        {
                            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            dgvDSKH.DataSource = buskh.getData();
                        }
                    }
                }
                else
                    MessageBox.Show("Số điện thoại phải có đúng 10 chữ số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
                MessageBox.Show("Email sai định dạng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void dgvDSKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            txtMaKH .Text = dgvDSKH [0, hang].Value.ToString();
            txtTenKH.Text = dgvDSKH[1, hang].Value.ToString();
            txtDiaChiKH.Text = dgvDSKH[2, hang].Value.ToString();
            txtEmailKH .Text = dgvDSKH[3, hang].Value.ToString();
            txtSDTKH .Text = dgvDSKH[4, hang].Value.ToString();

            txtMaKH .Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string ma = txtMaKH.Text;
            string ten = txtTenKH.Text;
            string diachi = txtDiaChiKH.Text;
            string email = txtEmailKH.Text;
            string sdt = txtSDTKH.Text;

            KhachHang kh = new KhachHang(ma, ten, diachi, email, sdt);
            if (string.IsNullOrEmpty(txtTenKH.Text))
            {
                MessageBox.Show("Cảnh báo: Tên khách hàng không không được trống!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtDiaChiKH.Text))
            {
                MessageBox.Show("Cảnh báo: Địa chỉ không được trống!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (buskh.Kiemtraemail(email)==true)
            { 
                if(buskh.IsValidPhoneNumber(sdt) == true)
                //buskh.suaKH(kh);
                {
                    if (buskh.suaKH(kh) == true)
                    {
                        MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        dgvDSKH.DataSource = buskh.getData();
                    }
                }
                else
                    MessageBox.Show("Số điện thoại phải có đúng 10 chữ số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
                MessageBox.Show("Email sai định dạng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ma = txtMaKH.Text;

            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                if (buskh .xoaKH(ma) == true)
                {
                    MessageBox.Show("Xoá thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dgvDSKH .DataSource = buskh.getData();
                }
            }
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in grpNhapTTKH.Controls)
            {
                if (ctrl is TextBox)
                {
                    (ctrl as TextBox).Text = "";
                }
                
            }
            txtMaKH.Enabled = true;
            dgvDSKH.DataSource = buskh.getData();
            loaddgv();


        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát ứng dụng không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();


            }
        }

        private void txtSDTKH_TextChanged(object sender, EventArgs e)
        {
            //if (txtSDTKH.Text.Length != 10)
            //{
            //    MessageBox.Show("Số điện thoại phải có 10 chữ số.");
            //}
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string ten = txtTimKiem.Text;
            if (buskh.TimKiemKH(ten) > 0)
            {
                dgvDSKH.DataSource = buskh.getkhtimkiem(ten);
            }
            else
                MessageBox.Show("Không tìm thấy tên hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }
    }
}
