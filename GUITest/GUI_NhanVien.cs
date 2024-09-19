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
    public partial class GUI_NhanVien : Form
    {
        public GUI_NhanVien()
        {
            InitializeComponent();
        }
        BUS_NhanVien  busnv  = new BUS_NhanVien();
        private void GUI_LoaiHang_Load(object sender, EventArgs e)
        {
            dgvDSNV .DataSource = busnv .getData();
            loaddgv();
        }
        void loaddgv()
        {
            dgvDSNV .DataSource = busnv .getData();
            dgvDSNV .Columns[0].HeaderText = "Mã nhân viên ";
            dgvDSNV .Columns[1].HeaderText = "Tên nhân viên ";
            dgvDSNV.Columns[2].HeaderText = "Giới tính nhân viên  ";
            dgvDSNV.Columns[3 ].HeaderText = "Ngày sinh  ";
            dgvDSNV.Columns[4].HeaderText = "Địa chỉ  ";
            dgvDSNV.Columns[5 ].HeaderText = "Email ";
            dgvDSNV.Columns[6].HeaderText = "Số điện thoại  ";

            dgvDSNV.Columns[6].DefaultCellStyle.Format = "#,###";
        }

        private void dgvDSLH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GUI_NhanVien_Load(object sender, EventArgs e)
        {
            dgvDSNV .DataSource = busnv .getData();
            loaddgv();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ma = txtMaNV .Text;
            string ten = txtTenNV .Text;
            string gt  = cbbGt.Text;
            DateTime ns = DateTime.Parse(dtpBir.Value.ToShortDateString());
            string diachi  = txtDiaChi.Text;
            string email  = txtEmail .Text;
            string sdt = txtSDT.Text.Trim();
            NhanVien nv  = new NhanVien (ma, ten,gt,ns,diachi,email,sdt );
            if (string.IsNullOrEmpty(txtTenNV.Text))
            {
                MessageBox.Show("Cảnh báo: Tên nhà cung cấp không không được trống!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtDiaChi.Text))
            {
                MessageBox.Show("Cảnh báo: Địa chỉ không không được trống!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (busnv .Kiemtraemail(email) == true)
            {
                if (busnv .IsValidPhoneNumber(sdt) == true)
                //buskh.suaKH(kh);
                {
                    if (busnv.kiemtramatrung(ma) == 1)
                    {
                        MessageBox.Show("Mã đã tồn tại, vui lòng nhập lại mã!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (busnv.themNV(nv) == true)
                        {
                            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            dgvDSNV.DataSource = busnv.getData();
                        }
                    }
                }
                else
                    MessageBox.Show("Số điện thoại phải có đúng 10 chữ số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
                MessageBox.Show("Email sai định dạng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            
        }
    

        private void dgvDSNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            txtMaNV .Text = dgvDSNV [0, hang].Value.ToString();
            txtTenNV .Text = dgvDSNV [1, hang].Value.ToString();
            cbbGt.Text = dgvDSNV[2, hang].Value.ToString();
            dtpBir.Text = dgvDSNV[3, hang].Value.ToString();
            txtDiaChi.Text = dgvDSNV[4, hang].Value.ToString();
            txtEmail .Text = dgvDSNV[5, hang].Value.ToString();
            txtSDT .Text = dgvDSNV[6, hang].Value.ToString();

            txtMaNV.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string ma = txtMaNV.Text;
            string ten = txtTenNV.Text;
            string gt = cbbGt.Text;
            DateTime ns = DateTime.Parse(dtpBir.Value.ToShortDateString());
            string diachi = txtDiaChi.Text;
            string email = txtEmail.Text;
            string sdt = txtSDT.Text;


            NhanVien nv = new NhanVien(ma, ten, gt, ns, diachi, email, sdt);
            if (busnv.Kiemtraemail(email) == true)
            {
                if (busnv.IsValidPhoneNumber(sdt) == true)
                //buskh.suaKH(kh);
                {
                    if (busnv.suaNV(nv) == true)
                    {
                        MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        dgvDSNV.DataSource = busnv.getData();
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
            string ma = txtMaNV.Text;

            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                if (busnv .xoaNV(ma) == true)
                {
                    MessageBox.Show("Xoá thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dgvDSNV .DataSource = busnv.getData();
                }
            }
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in grpNhapTTNV.Controls)
            {
                if (ctrl is TextBox)
                {
                    (ctrl as TextBox).Text = "";
                }
                if (ctrl is ComboBox)
                {
                    (ctrl as ComboBox).Text = "";
                }
            }
            txtMaNV.Enabled = true;
            dgvDSNV.DataSource = busnv.getData();
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

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string ten = txtTimKiem.Text;
            if (busnv .TimKiemNV(ten) > 0)
            {
                dgvDSNV .DataSource = busnv .getnvtimkiem(ten);
            }
            else
                MessageBox.Show("Không tìm thấy tên hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
