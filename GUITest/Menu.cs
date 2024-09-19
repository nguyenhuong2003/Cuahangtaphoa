using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void quảnLýLoạiHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void quảnLýMặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            GUI_MatHang  frm = new GUI_MatHang();
            frm.ShowDialog();
            
        }

        private void quảnLýNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_NhaCC  frm = new GUI_NhaCC();
            frm.ShowDialog();
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_KhachHang  frm = new GUI_KhachHang();
            frm.ShowDialog();
        }

        

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void quảnLýLoạiHàngToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            this.Hide();
            GUI_LoaiHang  frm = new GUI_LoaiHang();
            frm.ShowDialog();

        }

        private void quảnLýHàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            GUI_MatHang frm = new GUI_MatHang();
            frm.ShowDialog();
        }

        private void quảnLýNhàCungCấpToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            this.Hide();
            GUI_NhaCC  frm = new GUI_NhaCC ();
            frm.ShowDialog();
        }

        private void quảnLýNhânViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            this.Hide();
            GUI_NhanVien  frm = new GUI_NhanVien();
            frm.ShowDialog();
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            GUI_KhachHang  frm = new GUI_KhachHang ();
            frm.ShowDialog();
        }

        private void hóaĐơnNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            GUI_HoaDonNhap  frm = new GUI_HoaDonNhap ();
            frm.ShowDialog();
        }

        private void hóaĐơnBánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            GUI_HoaDonBan  frm = new GUI_HoaDonBan ();
            frm.ShowDialog();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Hide();
            GUI_DangNhap  frm = new GUI_DangNhap ();
            frm.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát ứng dụng không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();


            }
        }
    }
}
