using BUS;
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
    public partial class GUI_ThongKe : Form
    {
        public GUI_ThongKe()
        {
            InitializeComponent();
        }

        BUS_HoaDonBan hdbBUS = new BUS_HoaDonBan();
        
        
        private void GUI_ThongKe_Load(object sender, EventArgs e)
        {
            dgvThongKe.DataSource = hdbBUS.StatisticalSaleBill("","");
            
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string startDate = txtStartDate.Value.ToString("yyyy-MM-dd");
            string endDate = txtEndDate.Value.ToString("yyyy-MM-dd");
            DataTable dt = new DataTable();
            dt = hdbBUS.StatisticalSaleBill(startDate, endDate);//Chuyển chuỗi start end thành tham số
            decimal tongTien = 0;
            foreach (DataRow row in dt.Rows)//vòng lặp được thực hiện cho mỗi hàng
            {
                if (row.ItemArray.Length > 4 && row.ItemArray[4] != DBNull.Value)//kiểm tra datarow có nhiều
                                                                                 //hơn 4 cột và cột chỉ mục 4 có rỗng?
                {
                    decimal giaTri = Convert.ToDecimal(row.ItemArray[4]);//chuyển đổi giá trị của cột 5 thành
                                                                         //thập phân và thêm nó vào biến tổng 
                    tongTien += giaTri;
                }
            }
            lblTotal.Text = tongTien.ToString(); 
            dgvThongKe.DataSource = hdbBUS.StatisticalSaleBill(startDate, endDate);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

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
    }
}
