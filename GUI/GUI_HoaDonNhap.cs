using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
using System.Xml.Linq;


namespace GUI
{
    public partial class GUI_HoaDonNhap : Form
    {
        public GUI_HoaDonNhap()
        {
            InitializeComponent();
        }
        BUS_HoaDonNhap bus_hd = new BUS_HoaDonNhap();
        BUS_ChiTietHoaDonNhap bus_cthdn = new BUS_ChiTietHoaDonNhap();
        BUS_NhanVien bus_nv = new BUS_NhanVien();
        BUS_NhaCC bus_ncc = new BUS_NhaCC();
        BUS_MatHang bus_ch = new BUS_MatHang();
        void loaddgvHoaDonNhap()
        {
            dgvHoaDonNhap.DataSource = bus_hd.getData();

            dgvHoaDonNhap.Columns[0].HeaderText = "Mã hoá đơn";
            dgvHoaDonNhap.Columns[1].HeaderText = "Mã nhân viên";
            dgvHoaDonNhap.Columns[2].HeaderText = "Mã nhà cung cấp";
            dgvHoaDonNhap.Columns[3].HeaderText = "Ngày nhập";
            dgvHoaDonNhap.Columns[4].HeaderText = "Tổng tiền";

        }
        void loaddgvChiTietHDN(string ma)
        {
            dgvcthdn.DataSource = bus_cthdn.getDataCTHDN(ma);
        }
        void loadcbbNV()
        {
            cbbNV.DataSource = bus_nv.getData();
            cbbNV.DisplayMember = "HotenNV";
            cbbNV.ValueMember = "NhanVienID";
        }
        void loadcbbNCC()
        {
            cbbNCC.DataSource = bus_ncc.getData();
            cbbNCC.DisplayMember = "TenNCC";
            cbbNCC.ValueMember = "NhaCCID";
        }
        void loadcbbMH()
        {
            cbbMaMatHang.DataSource = bus_ch.getData();
            cbbMaMatHang.DisplayMember = "Tenhang";
            cbbMaMatHang.ValueMember = "MatHangID";
        }
        private void GUI_HoaDonNhap_Load(object sender, EventArgs e)
        {
            loaddgvHoaDonNhap();
            loadcbbNV();
            loadcbbNCC();
            loadcbbMH();
        }

        private void dgvHoaDonNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaHDN.Enabled = false;
            int i = e.RowIndex;
            txtMaHDN.Text = dgvHoaDonNhap[0, i].Value.ToString();
            loaddgvChiTietHDN(dgvHoaDonNhap[0, i].Value.ToString());
            cbbNV.Text = dgvHoaDonNhap[1, i].Value.ToString();
            cbbNCC.Text = dgvHoaDonNhap[2, i].Value.ToString();
            dtNgayNhap.Text = dgvHoaDonNhap[3, i].Value.ToString();
            lblTongTien.Text = dgvHoaDonNhap[4, i].Value.ToString();
        }

        private void btnThemHD_Click(object sender, EventArgs e)
        {
            //if (txtthanhtien.Text != "")
            //{
            //    string TT = (float.Parse(txtthanhtien.Text) + float.Parse(lblTongTien.Text)).ToString();
            //    lblTongTien.Text = TT;
            //}
            HoaDonNhap hd = new HoaDonNhap();
            hd.HoaDonNhapID = txtMaHDN.Text;
            hd.NhanvienID = cbbNV.SelectedValue.ToString();
            hd.NhaCCID = cbbNCC.SelectedValue.ToString();
            DateTime ns = DateTime.Parse(dtNgayNhap.Value.ToShortDateString());
            hd.Ngaynhap = ns;
            
            if (bus_hd.kiemtramatrung(txtMaHDN.Text) == 1)
            {
                MessageBox.Show("Mã hoá đơn đã tồn tại! Vui lòng nhập mã khác!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (bus_hd.ThemHDN(hd))
                {
                    MessageBox.Show("Thêm thành công!!!");
                    dgvHoaDonNhap.DataSource = bus_hd.getData();


                }
            }
        }

        private void btnSuaHD_Click(object sender, EventArgs e)
        {
            HoaDonNhap hd = new HoaDonNhap();
            hd.HoaDonNhapID = txtMaHDN.Text;
            hd.NhanvienID = cbbNV.SelectedValue.ToString();
            hd.NhaCCID = cbbNCC.SelectedValue.ToString();
            DateTime ns = DateTime.Parse(dtNgayNhap.Value.ToShortDateString());
            hd.Ngaynhap = ns;
            if (bus_hd.SuaHDN(hd))
            {
                MessageBox.Show("Sửa thành công!!!");
                dgvHoaDonNhap.DataSource = bus_hd.getData();
                loaddgvHoaDonNhap();
            }
        }

        private void btnXoaHD_Click(object sender, EventArgs e)
        {
            string ma = txtMaHDN.Text;
            DialogResult kq = MessageBox.Show("Bạn có chắc chắn muốn xóa hóa đơn này !", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (kq == System.Windows.Forms.DialogResult.Yes)
            {
                if (bus_hd.XoaHDN(ma))
                {
                    MessageBox.Show("Xóa thành công ");
                    loaddgvHoaDonNhap();
                }
            }
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in grbHDN.Controls)
            {

                if (ctrl is TextBox)
                {
                    (ctrl as TextBox).Text ="";
                }
                if (ctrl is ComboBox)
                {
                    (ctrl as ComboBox).Text ="";
                }
            }
            txtMaHDN.Enabled = true;
            loaddgvHoaDonNhap();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MatHang mh = new MatHang();
            ChiTietHoaDonNhap hd = new ChiTietHoaDonNhap();
            hd.HoaDonNhapID = txtMaHDN.Text;
            hd.MatHangID = cbbMaMatHang.SelectedValue.ToString();
            hd.DGnhap = float.Parse(textBox2.Text);
            hd.ThanhTien = float.Parse(txtthanhtien.Text);
            hd.SLnhap = int.Parse(textBox5.Text);

            if (bus_cthdn.kiemtramatrung2(hd.HoaDonNhapID, hd.MatHangID) == 1)
            {
                MessageBox.Show(" Chi tiết này đã được nhập!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                if (bus_cthdn.ThemCTHDN(hd))
                {
                    MessageBox.Show("Thêm thành công!!!");
                    loaddgvChiTietHDN(txtMaHDN.Text);
                    loaddgvHoaDonNhap();
                    
                }
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ChiTietHoaDonNhap hd = new ChiTietHoaDonNhap();
            hd.HoaDonNhapID = txtMaHDN.Text;
            hd.MatHangID = cbbMaMatHang.SelectedValue.ToString();
            hd.DGnhap = float.Parse(textBox2.Text);
            hd.ThanhTien = float.Parse(txtthanhtien.Text);
            hd.SLnhap = int.Parse(textBox5.Text);
            if (bus_cthdn.SuaCTHDN(hd))
            {
                MessageBox.Show("Sửa thành công!!!");
                loaddgvChiTietHDN(txtMaHDN.Text);
                loaddgvHoaDonNhap();
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            ChiTietHoaDonNhap hd = new ChiTietHoaDonNhap();
            string ma = cbbMaMatHang.Text;
            string ma2 = txtMaHDN.Text;
            DialogResult kq = MessageBox.Show("Bạn có chắc chắn muốn xóa hóa đơn này !", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (kq == System.Windows.Forms.DialogResult.Yes)
            {
                if (bus_cthdn.XoaCTHDN(ma, ma2))
                {
                    MessageBox.Show("Xóa thành công ");
                    loaddgvChiTietHDN(txtMaHDN.Text);
                    loaddgvHoaDonNhap();

                }
            }
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

        private void dgvcthdn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //cbbMaMatHang.Enabled = false;
            int i = e.RowIndex;
            cbbMaMatHang.Text = dgvcthdn[0, i].Value.ToString();
            textBox2 .Text = dgvcthdn[2 , i].Value.ToString();
            textBox5 .Text = dgvcthdn[1 , i].Value.ToString();
            txtthanhtien.Text = dgvcthdn[3, i].Value.ToString();

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            float  dongia = float.Parse(textBox2.Text);
            string sl = textBox5.Text;
            if (sl != "" )
            {
                  txtthanhtien.Text = (dongia * (int.Parse(sl))).ToString();

            }
        }

        private void dgvcthdn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dgvcthdn_CellBorderStyleChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            


        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                // Nếu là chữ, hủy sự kiện và không cho phép nhập
                e.Handled = true;
                lbl1.Text = "Bạn phải nhập số";
                lbl1.Visible = true; 
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

      
    }
}
