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


        void loaddgvChiTietHDB(string ma)
        {

            dgvcthdb.DataSource = bus_cthdb.getDataCTHDB(ma);

        }
        void loadcbbNV()
        {
            cbbNV.DataSource = bus_nv.getData();
            cbbNV.DisplayMember = "HotenNV";
            cbbNV.ValueMember = "NhanVienID";
        }
        void loadcbbKH()
        {
            cbbKH.DataSource = bus_kh.getData();
            cbbKH.DisplayMember = "HotenKH";
            cbbKH.ValueMember = "KhachHangID";
        }
        void loadcbbMH()
        {
            cbbMaMatHang.DataSource = bus_ch.getData();
            //cbbMaMatHang.DisplayMember = "Tenhang";
            cbbMaMatHang.ValueMember = "MatHangID";
        }
        private void GUI_HoaDonBan_Load(object sender, EventArgs e)
        {
     
            loaddgvHoaDonBan();
            loadcbbNV();
            loadcbbKH();
            loadcbbMH();
        }
        private void dgvHoaDonBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            txtMaHDB.Enabled = false;
            int i = e.RowIndex;
            txtMaHDB.Text = dgvHoaDonBan[0, i].Value.ToString();
            loaddgvChiTietHDB(dgvHoaDonBan[0, i].Value.ToString());
            cbbNV.Text =dgvHoaDonBan[1, i].Value.ToString();
            cbbKH.Text =dgvHoaDonBan[2, i].Value.ToString();
            dtNgayBan.Text = dgvHoaDonBan[3, i].Value.ToString();
            lblTongTien.Text = dgvHoaDonBan[4, i].Value.ToString();


        }

        private void btnThemHD_Click(object sender, EventArgs e)
        {
            //if (txtthanhtien.Text != "")
            //{
            //    string TT = (float.Parse(txtthanhtien.Text) + float.Parse(lblTongTien.Text)).ToString();
            //    lblTongTien.Text = TT;
            //}
            HoaDonBan hd = new HoaDonBan();
            hd.HoaDonBanID  = txtMaHDB.Text;
            hd.NhanvienID  = cbbNV.SelectedValue.ToString();
            hd.KhachhangID = cbbKH.SelectedValue.ToString();
            DateTime ns = DateTime.Parse(dtNgayBan.Value.ToShortDateString());
            hd.NgayBan = ns;
            //hd.TongTien = float.Parse(txtTongTien.Text);
            if (bus_hd.kiemtramatrung(txtMaHDB.Text)==1)
            {
                MessageBox.Show("Mã hoá đơn đã tồn tại! Vui lòng nhập mã khác!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (bus_hd.ThemHDB(hd))
                {
                    MessageBox.Show("Thêm thành công!!!");
                    dgvHoaDonBan.DataSource = bus_hd.getData();
                  

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
                dgvHoaDonBan.DataSource = bus_hd.getData();
                loaddgvHoaDonBan();
            }
        }

        private void btnXoaHD_Click(object sender, EventArgs e)
        {
            string ma = txtMaHDB.Text;
            DialogResult kq = MessageBox.Show("Bạn có chắc chắn muốn xóa hóa đơn này !", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (kq == System.Windows.Forms.DialogResult.Yes)
            {
                if (bus_hd.XoaHDB(ma))
                {
                    MessageBox.Show("Xóa thành công ");
                    loaddgvHoaDonBan();
                    loaddgvChiTietHDB(txtMaHDB.Text);
                }
            }
        }

        private void btnThemCT_Click(object sender, EventArgs e)
        {
           
            ChiTietHoaDonBan hd = new ChiTietHoaDonBan();
            hd.HoaDonBanID  = txtMaHDB.Text;
            hd.MatHangID  = cbbMaMatHang.SelectedValue.ToString();
            hd.DGban  = float.Parse(txtdongia.Text);
            hd.GiamGia = int .Parse(txtgiamgia.Text);
            hd.ThanhTien = float.Parse(txtthanhtien.Text);
            //hd.SLBan = int.Parse(txtSLB.Text);
           
            if (bus_cthdb.IsStockEnough(hd.MatHangID, hd.SLBan) == true)   
            {
                if (bus_cthdb.kiemtramatrung2(hd.HoaDonBanID, hd.MatHangID) == 1)
                {
                    MessageBox.Show(" Chi tiết này đã được nhập!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                }
                else
                {
                    if (bus_cthdb.ThemCTHDB(hd))
                    {
                        MessageBox.Show("Thêm thành công!!!");
                       
                        loaddgvChiTietHDB(txtMaHDB.Text);
                        loaddgvHoaDonBan();
                    }
                }

            }
            else
            
                MessageBox.Show(" Hết hàng!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSuaCT_Click(object sender, EventArgs e)
        {
            ChiTietHoaDonBan hd = new ChiTietHoaDonBan();
            hd.HoaDonBanID = txtMaHDB.Text;
            hd.MatHangID = cbbMaMatHang.Text;
            hd.DGban = float.Parse(txtdongia.Text);
            hd.GiamGia = int.Parse(txtgiamgia.Text);
            hd.ThanhTien = float.Parse(txtthanhtien.Text);
            hd.SLBan = int.Parse(txtSLB.Text);
            if (bus_cthdb.SuaCTHDB(hd))
            {
                MessageBox.Show("Sửa thành công!!!");
                loaddgvChiTietHDB(txtMaHDB.Text);
                loaddgvHoaDonBan();
            }
        }

        
        private void dgvcthdb_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //cbbMaMatHang.Enabled = false;
            int i = e.RowIndex;
            cbbMaMatHang.Text = dgvcthdb[0 , i].Value.ToString();
            txtSLB.Text = dgvcthdb[1 , i].Value.ToString();
            txtdongia.Text = dgvcthdb[2 , i].Value.ToString();
            txtgiamgia.Text = dgvcthdb[3 , i].Value.ToString();
            txtthanhtien.Text = dgvcthdb[4 , i].Value.ToString();

          

        }

        private void txtgiamgia_TextChanged(object sender, EventArgs e)
        {
            string giamgia = txtgiamgia.Text;
            float dongia = float.Parse(txtdongia.Text);
            int sl = int.Parse(txtSLB.Text);
            if (giamgia != "")
            {
                txtthanhtien.Text = (dongia * sl - (float.Parse(giamgia))).ToString();

            }
        }

        private void dgvHoaDonBan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtthanhtien_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvcthdb_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnXoaCT_Click_1(object sender, EventArgs e)
        {
            ChiTietHoaDonBan hd = new ChiTietHoaDonBan();
            string ma = cbbMaMatHang.Text;
            string ma2 = txtMaHDB.Text;
            DialogResult kq = MessageBox.Show("Bạn có chắc chắn muốn xóa hóa đơn này !", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (kq == System.Windows.Forms.DialogResult.Yes)
            {
                if (bus_cthdb.XoaCTHDB(ma,ma2))
                {
                    MessageBox.Show("Xóa thành công ");
                    loaddgvChiTietHDB(txtMaHDB.Text);
                    loaddgvHoaDonBan();
                    
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in grpNhapHDB.Controls)
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
            txtMaHDB.Enabled = true;
            
            loaddgvHoaDonBan();
        }

        private void bTNThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát ứng dụng không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();


            }

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

        private void txtdongia_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtSLB_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtgiamgia_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtdongia_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                // Nếu là chữ, hủy sự kiện và không cho phép nhập
                e.Handled = true;
                lbl1.Text = "Bạn phải nhập số";
                lbl1.Visible = true;
            }
        }

        private void txtSLB_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                // Nếu là chữ, hủy sự kiện và không cho phép nhập
                e.Handled = true;
                lbl2.Text = "Bạn phải nhập số";
                lbl2.Visible = true;
            }
        }

        private void txtgiamgia_KeyPress_1(object sender, KeyPressEventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          

        }

        private void lblTongTien_Click(object sender, EventArgs e)
        {

        }

        private void cbbMaMatHang_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbbMaMatHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedMaMatHang = cbbMaMatHang.SelectedValue.ToString();
            DataTable data = bus_cthdb.getDatamh(selectedMaMatHang);
            if (data != null && data.Rows.Count > 0)
            {
                decimal donGia = Convert.ToDecimal(data.Rows[0]["DGban"]);
                txtdongia.Text = donGia.ToString();
            }
            //if(cbbMaMatHang.Text == "MH1")
            //{
            //    txtdongia.Text = "10000";
            //}
        }
    }
}
