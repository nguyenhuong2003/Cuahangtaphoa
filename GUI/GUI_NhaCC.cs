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
    public partial class GUI_NhaCC : Form
    {
        public GUI_NhaCC()
        {
            InitializeComponent();
        }
        BUS_NhaCC  busncc= new BUS_NhaCC();
        private void GUI_LoaiHang_Load(object sender, EventArgs e)
        {
            dgvDSNCC.DataSource = busncc.getData();
            loaddgv();
        }
        void loaddgv()
        {
            dgvDSNCC.DataSource = busncc.getData();
            dgvDSNCC.Columns[0].HeaderText = "Mã nhà cung cấp ";
            dgvDSNCC.Columns[1].HeaderText = "Tên nhà cung cấp ";
            dgvDSNCC.Columns[2].HeaderText = "Địa chỉ nhà cung cấp ";
            dgvDSNCC.Columns[3].HeaderText = "SDT Nhà cung cấp ";

            dgvDSNCC.Columns[3].DefaultCellStyle.Format = "#,###";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ma = txtMaNCC .Text;
            string ten = txtTenNCC.Text;
            string diachi  = txtDiaChiNCC.Text;
            string sdt  = txtSDTNCC.Text;

            NhaCC cc  = new NhaCC(ma,ten,diachi,sdt);
            if (string.IsNullOrEmpty(txtTenNCC.Text))
            {
                MessageBox.Show("Cảnh báo: Tên nhà cung cấp không không được trống và không nhập kí tự số!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtDiaChiNCC.Text))
            {
                MessageBox.Show("Cảnh báo: Địa chỉ không không được trống!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (busncc.IsValidPhoneNumber(sdt) == true)
            //buskh.suaKH(kh);
            {
                if (busncc.kiemtramatrung(ma) == 1)
                {
                    MessageBox.Show("Mã đã tồn tại, vui lòng nhập lại mã!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (busncc.themNCC(cc) == true)
                    {
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        dgvDSNCC.DataSource = busncc.getData();
                    }
                }
            }
            else
                MessageBox.Show("Số điện thoại phải có đúng 10 chữ số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }

        private void GUI_NhaCC_Load(object sender, EventArgs e)
        {

            dgvDSNCC.DataSource = busncc.getData();
            loaddgv();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string ma = txtMaNCC.Text;
            string ten = txtTenNCC.Text;
            string diachi = txtDiaChiNCC.Text;
            string sdt = txtSDTNCC.Text;

            NhaCC cc = new NhaCC(ma, ten, diachi, sdt);
            if (string.IsNullOrEmpty(txtTenNCC.Text))
            {
                MessageBox.Show("Cảnh báo: Tên nhà cung cấp không không được trống và không nhập kí tự số!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtDiaChiNCC.Text))
            {
                MessageBox.Show("Cảnh báo: Địa chỉ không không được trống!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (busncc.IsValidPhoneNumber(sdt) == true)
            //buskh.suaKH(kh);
            {
                if (busncc.suaNCC(cc) == true)
                {
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dgvDSNCC.DataSource = busncc.getData();

                }
            }
            else
                MessageBox.Show("Số điện thoại phải có đúng 10 chữ số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

           
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ma = txtMaNCC.Text;

            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                if (busncc .xoaNCC (ma) == true)
                {
                    MessageBox.Show("Xoá thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dgvDSNCC.DataSource = busncc.getData();

                }
            }
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in grpNhapTTNCC.Controls)
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
            txtMaNCC.Enabled = true;
            txtMaNCC. Focus();
            dgvDSNCC.DataSource = busncc.getData();
            loaddgv();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát ứng dụng không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
                Menu frm = new Menu();
                frm.ShowDialog();
                Application.Exit();
            }
        }

        private void dgvDSNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            txtMaNCC.Text = dgvDSNCC [0, hang].Value.ToString();
            txtTenNCC.Text = dgvDSNCC[1, hang].Value.ToString();
            txtDiaChiNCC .Text= dgvDSNCC[2, hang].Value.ToString();
            txtSDTNCC .Text = dgvDSNCC[3 , hang].Value.ToString();

            txtMaNCC.Enabled = false;

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string ten = txtTimKiem.Text;
            if (busncc.TimKiemNCC (ten) > 0)
            {
                dgvDSNCC .DataSource = busncc.getncctimkiem(ten);
            }
            else
                MessageBox.Show("Không tìm thấy tên hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void txtTenNCC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                // Nếu là số, hủy sự kiện và không cho phép nhập
                e.Handled = true;
                lblten.Text = "Bạn phải nhập chữ";
                lblten.Visible = true;
            }
        }

        private void txtSDTNCC_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsLetter(e.KeyChar))
            {
                // Nếu là chữ, hủy sự kiện và không cho phép nhập
                e.Handled = true;
                lblsdt.Text = "Bạn phải nhập số";
                lblsdt.Visible = true;
            }
        }
    }
}
