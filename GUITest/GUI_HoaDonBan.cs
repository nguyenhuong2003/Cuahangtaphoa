using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GUI
{
    public partial class GUI_HoaDonBan : Form
    {
        public GUI_HoaDonBan()
        {
            InitializeComponent();
        }
        BUS_HoaDonBan  bus_hd = new BUS_HoaDonBan();
        BUS_ChiTietHoaDonBan  bus_cthdb = new BUS_ChiTietHoaDonBan();
        BUS_NhanVien bus_nv = new BUS_NhanVien();
        BUS_KhachHang bus_kh = new BUS_KhachHang();
        BUS_MatHang  bus_ch = new BUS_MatHang();
        void loaddgvHoaDonBan()
        {
            dgvHoaDonBan.DataSource = bus_hd.getData();
            dgvHoaDonBan.Columns[0].HeaderText = "Mã hoá đơn";
            dgvHoaDonBan.Columns[1].HeaderText = "Mã nhân viên";
            dgvHoaDonBan.Columns[2].HeaderText = "Mã khách hàng";
            dgvHoaDonBan.Columns[3].HeaderText = "Ngày bán";
            dgvHoaDonBan.Columns[4].HeaderText = "Tổng tiền";

        }
        //string ma;

        //void loaddgvChiTietHDB()
        //{

        //    dgvcthdb.DataSource = bus_cthdb.getData();

        //    dgvcthdb.Columns[0].HeaderText = "Mã hóa đơn ";
        //    dgvcthdb.Columns[1].HeaderText = "Mã mặt hàng";
        //    dgvcthdb.Columns[2].HeaderText = "Đơn giá bán ";
        //    dgvcthdb.Columns[3].HeaderText = "Giảm giá";
        //    dgvcthdb.Columns[4].HeaderText = "Thành tiền";
        //}
        void loadcbbNV()
        {
            cbbNV.DataSource = bus_nv.getData();
            cbbNV.DisplayMember = "HotenNV ";
            cbbNV.ValueMember = "NhanVienID";
        }
        void loadcbbKH()
        {
            cbbKH.DataSource = bus_kh.getData();
            cbbKH.DisplayMember = "HotenKH";
            cbbKH.ValueMember = "KhachHangID";
        }
        private void GUI_HoaDonBan_Load(object sender, EventArgs e)
        {
            //loaddgvChiTietHDB();
            loaddgvHoaDonBan();
            loadcbbNV();
            loadcbbKH();
        }
        private void dgvHoaDonBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtMaHDB.Text = dgvHoaDonBan[0, i].Value.ToString();
            cbbNV.Text =dgvHoaDonBan[1, i].Value.ToString();
            cbbKH.Text =dgvHoaDonBan[2, i].Value.ToString();
            dtNgayBan.Text = dgvHoaDonBan[3, i].Value.ToString();
            txtTongTien.Text = dgvHoaDonBan[4, i].Value.ToString();

        }

        private void btnThemHD_Click(object sender, EventArgs e)
        {
            HoaDonBan  hd = new HoaDonBan();
            hd.HoaDonBanID  = txtMaHDB.Text;
            hd.NhanvienID  = cbbNV.SelectedValue.ToString();
            hd.KhachhangID  = cbbKH.SelectedValue.ToString();
            DateTime ns = DateTime.Parse(dtNgayBan.Value.ToShortDateString());
            hd.NgayBan = ns;
            if (bus_hd.kiemtramatrung(txtMaHDB.Text)==1)
            {
                MessageBox.Show("Mã hoá đơn đã tồn tại! Vui lòng nhập mã khác!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (bus_hd.ThemHDB(hd))
                {
                    MessageBox.Show("Thêm thành công!!!");
                    loaddgvHoaDonBan();
                }
            }
        }

        private void btnSuaHD_Click(object sender, EventArgs e)
        {
            HoaDonBan  hd = new HoaDonBan();
            hd.HoaDonBanID = txtMaHDB.Text;
            hd.NhanvienID = cbbNV.SelectedValue.ToString();
            hd.KhachhangID = cbbKH.SelectedValue.ToString();
            DateTime ns = DateTime.Parse(dtNgayBan.Value.ToShortDateString());
            hd.NgayBan = ns;

            if (bus_hd.SuaHDB (hd))
            {
                MessageBox.Show("Sửa thành công!!!");
                loaddgvHoaDonBan();
            }
        }

        private void btnXoaHD_Click(object sender, EventArgs e)
        {
            string ma = txtMaHDB.Text;
            DialogResult kq = MessageBox.Show("Bạn có chắc chắn muốn xóa hóa đơn này !", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (kq == System.Windows.Forms.DialogResult.Yes)
            {
                if (bus_hd.XoaHDB (ma))
                {
                    MessageBox.Show("Xóa thành công ");
                    loaddgvHoaDonBan();
                }
            }
        }

        private void btnThemCT_Click(object sender, EventArgs e)
        {
            ChiTietHoaDonBan hd = new ChiTietHoaDonBan();
            HoaDonBan  hdb = new HoaDonBan ();
            hd.HoaDonBanID  = txtMaHDB.Text;
            hd.MatHangID  = txtMatHang.Text;
            hd.DGban  = float.Parse(txtdongia.Text);
            hd.GiamGia = int .Parse(txtgiamgia.Text);
            hd.ThanhTien = float.Parse(txtthanhtien.Text);
            if (bus_cthdb.kiemtramatrung(txtMatHang .Text) ==1)
            {
                MessageBox.Show("Sản phẩm có mã " + txtMatHang.Text + " đã được bán! Vui lòng nhập số nhà khác!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (bus_cthdb.ThemCTHDB(hd))
                {
                    MessageBox.Show("Thêm thành công!!!");
                    //loaddgvChiTietHDB();
                }
            }
        }

        private void btnSuaCT_Click(object sender, EventArgs e)
        {
            ChiTietHoaDonBan hd = new ChiTietHoaDonBan();
            hd.HoaDonBanID = txtMaHDB.Text;
            hd.MatHangID = txtMatHang.Text;
            hd.DGban = float.Parse(txtdongia.Text);
            hd.GiamGia = int.Parse(txtgiamgia.Text);
            hd.ThanhTien = float.Parse(txtthanhtien.Text);
            if (bus_cthdb.SuaCTHDB(hd))
            {
                MessageBox.Show("Sửa thành công!!!");
                //loaddgvChiTietHDB();
            }
        }

        private void btnXoaCT_Click(object sender, EventArgs e)
        {
            string ma = txtMatHang .Text;
            DialogResult kq = MessageBox.Show("Bạn có chắc chắn muốn xóa hóa đơn này !", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (kq == System.Windows.Forms.DialogResult.Yes)
            {
                if (bus_cthdb.XoaCTHDB(ma))
                {
                    MessageBox.Show("Xóa thành công ");
                    loaddgvHoaDonBan();
                }
            }
        }

        private void dgvcthdb_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtMatHang .Text = dgvHoaDonBan[0, i].Value.ToString();
            txtdongia.Text = dgvHoaDonBan[1, i].Value.ToString();
            txtgiamgia.Text = dgvHoaDonBan[2, i].Value.ToString();
            txtthanhtien.Text = dgvHoaDonBan[3, i].Value.ToString();
        }

        private void txtgiamgia_TextChanged(object sender, EventArgs e)
        {
            string giamgia = txtgiamgia.Text;
            float dongia = float.Parse(txtdongia.Text);
            if (giamgia != "")
            {
                txtthanhtien.Text = (dongia - (float.Parse(giamgia) * dongia)).ToString();
            }
        }

        private void dgvHoaDonBan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
