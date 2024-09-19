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
    public partial class GUI_MatHang : Form
    {
        public GUI_MatHang()
        {
            InitializeComponent();
        }
        BUS_MatHang   busmh  = new BUS_MatHang();
        BUS_LoaiHang  buslh  = new BUS_LoaiHang();
        void loaddgv()
        {
            dgvDSMH.DataSource = busmh .getData();
            dgvDSMH.Columns[0].HeaderText = "Mã loại";
            dgvDSMH.Columns[1].HeaderText = "Mã hàng ";
            dgvDSMH.Columns[2].HeaderText = "Tên hàng ";
            dgvDSMH.Columns[3].HeaderText = "Số lượng tồn ";
            


        }
        void loadcbb()
        {
            cbbMaLoai.DataSource = buslh .getData();
            cbbMaLoai .DisplayMember = "TenLH";
            cbbMaLoai.ValueMember = "LoaiHangID";


        }

        private void GUI_MatHang_Load(object sender, EventArgs e)
        {
            dgvDSMH.DataSource = busmh.getData();
            loaddgv();
            loadcbb();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string mahang  = txtMaHang.Text;
            string tenhang = txtTenHang.Text;
            string maloai = cbbMaLoai.SelectedValue.ToString();
            int slt = int.Parse(txtSLT.Text);
            MatHang  mh  = new MatHang (maloai,mahang,tenhang,slt );

            if (slt > 0)
            {
                MessageBox.Show("Cảnh báo: Số lượng không hợp lệ! Nhập số lượng tồn bằng 0", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
           
            if (string.IsNullOrEmpty(txtTenHang.Text))
            {
                MessageBox.Show("Cảnh báo: Tên hàng không không được trống và không nhập kí tự số!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (busmh.kiemtramatrung(mahang) == 1)
            {
                MessageBox.Show("Mã đã tồn tại, vui lòng nhập lại mã!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (busmh.themMH(mh) == true)
                {
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dgvDSMH .DataSource = busmh.getData();
                    
                }
            }
        }

        private void dgvDSMH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSLT.Enabled = false;
            int hang = e.RowIndex;
            cbbMaLoai.Text = dgvDSMH[0, hang].Value.ToString();
            txtMaHang.Text = dgvDSMH[1, hang].Value.ToString();
            txtTenHang.Text = dgvDSMH[2 , hang].Value.ToString();
            txtSLT.Text = dgvDSMH[3 , hang].Value.ToString();
            txtMaHang.Enabled = false;

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string mahang = txtMaHang.Text;
            string tenhang = txtTenHang.Text;
            string maloai = cbbMaLoai.SelectedValue.ToString();
            int slt = int.Parse(txtSLT.Text);
            MatHang mh = new MatHang(maloai, mahang, tenhang, slt);
            if (string.IsNullOrEmpty(txtTenHang.Text))
            {
                MessageBox.Show("Cảnh báo: Tên hàng không không được trống và không phải kí tự số!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (busmh .suaMH (mh ) == true)
            {
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dgvDSMH.DataSource = busmh.getData();
                
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string mahang = txtMaHang.Text;

            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                if (busmh.xoaMH(mahang ) == true)
                {
                    MessageBox.Show("Xoá thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dgvDSMH.DataSource = busmh.getData();
                    
                }
            }
        }
        private void btnMoi_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in grpNhapTTMH.Controls)
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
            txtSLT.Enabled = true;
            txtMaHang.Enabled = true;
            dgvDSMH.DataSource = busmh.getData();
            txtMaHang.Focus();
            loaddgv();

        }

        private void btnThoat_Click(object sender, EventArgs e)
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

        private void dgvDSMH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string ten=txtTimKiem.Text;
            if (busmh.TimKiemMH(ten)>0)
            {
                dgvDSMH.DataSource = busmh.getmhtimkiem(ten);
            }
            else
                MessageBox.Show("Không tìm thấy tên hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void txtMaHang_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txtTenHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                // Nếu là số, hủy sự kiện và không cho phép nhập
                e.Handled = true;
                lbl2.Text = "Bạn phải nhập chữ";
                lbl2.Visible = true;
            }
        }

        private void txtSLT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                // Nếu là chữ, hủy sự kiện và không cho phép nhập
                e.Handled = true;
            }
        }
    }
}
