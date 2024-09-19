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
    public partial class GUI_LoaiHang : Form
    {
        public GUI_LoaiHang()
        {
            InitializeComponent();
        }
        BUS_LoaiHang  buslh  = new BUS_LoaiHang ();
        private void GUI_LoaiHang_Load(object sender, EventArgs e)
        {
            dgvDSLH.DataSource = buslh.getData();
            loaddgv();
        }
        void loaddgv()
        {
            dgvDSLH.DataSource = buslh.getData();
            dgvDSLH.Columns[0].HeaderText ="Mã loại hàng";
            dgvDSLH.Columns[1].HeaderText ="Tên loại hàng";
            dgvDSLH.Columns[1].DefaultCellStyle.Format = "#,###";          
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            
        }
        private void dgvDSLH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            txtMaLoai.Text = dgvDSLH[0, hang].Value.ToString();
            txtTenLoai.Text = dgvDSLH[1, hang].Value.ToString();
            txtMaLoai.Enabled = false;

        }
        private void btnThem_Click_1(object sender, EventArgs e)
        {
            string ma = txtMaLoai.Text;
            string ten = txtTenLoai.Text;
            LoaiHang lh = new LoaiHang(ma, ten);
            if (string.IsNullOrEmpty(txtTenLoai.Text))
            {
                MessageBox.Show("Cảnh báo: Tên loại hàng không không được trống!!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (buslh.kiemtramatrung(ma) == 1)
            {
                MessageBox.Show("Mã đã tồn tại, vui lòng nhập lại mã!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (buslh.themLH(lh) == true)
                {
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dgvDSLH.DataSource = buslh.getData();
                }
            }
        }
        private void btnSua_Click_1(object sender, EventArgs e)
        {
            string ma = txtMaLoai.Text;
            string ten = txtTenLoai.Text;
            LoaiHang lh = new LoaiHang(ma, ten);
            if (string.IsNullOrEmpty(txtTenLoai.Text))
            {
                MessageBox.Show("Cảnh báo: Tên loại hàng không không được trống!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (buslh.suaLH(lh) == true)
            {
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dgvDSLH.DataSource = buslh.getData();
            }
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            string ma = txtMaLoai.Text;
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (buslh.xoaLH(ma) == true)
                {
                    MessageBox.Show("Xoá thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dgvDSLH.DataSource = buslh.getData();
                }
            }
        }

        private void btnMoi_Click_1(object sender, EventArgs e)
        {
            foreach (Control ctrl in grpNhapTTLH.Controls)
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
            txtMaLoai.Enabled = true;
            txtMaLoai.Focus();
            loaddgv();
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát ứng dụng không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Hide();
                Menu frm = new Menu();
                frm.ShowDialog();
                Application.Exit();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string ten = txtTimKiem.Text;
            if (buslh.TimKiemLH(ten) > 0)
            {
                dgvDSLH.DataSource = buslh.getlhtimkiem(ten);
            }
            else
                MessageBox.Show("Không tìm thấy tên hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void txtTenLoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                // Nếu là số, hủy sự kiện và không cho phép nhập
                e.Handled = true;
                lbl1.Text = "Bạn phải nhập chữ";
                lbl1.Visible = true;
            }
        }
    }
}
