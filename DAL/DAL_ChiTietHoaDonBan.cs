using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public  class DAL_ChiTietHoaDonBan : DBConnect 
    {
        DBConnect connect = new DBConnect();
        public DataTable getDataCTHDB(string ma)
        {
            string sql = "SELECT cthdb.MathangID,cthdb.Slban,cthdb.DGban,cthdb.GiamGia,cthdb.ThanhTien FROM ChitietHDB AS cthdb WHERE cthdb.HoaDonbanID = '" + ma.Trim() + "'";
            return connect.getData(sql);
        }
        public DataTable  getDatamh(string ma)
        {
            string sql = "SELECT cthdb.DGban FROM ChitietHDB AS cthdb WHERE cthdb.MatHangID = '" + ma.Trim() + "'";
            return connect.getData(sql);
        }

        public int kiemtramatrung2(string ma,string ma2)
        {
            string sql = "Select count(*) from ChiTietHDB where HoaDonBanID ='"+ma.Trim()+ "' AND MatHangID='"+ma2.Trim()+"'";
            return connect.kiemtramatrung2(ma,ma2,sql);
        }
       
        public bool ThemCTHDB(ChiTietHoaDonBan CT)
        {
           
            string sql = string.Format("INSERT INTO ChitietHDB (HoaDonbanID,MathangID,DGban,SLBAN,GiamGia,ThanhTien) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}')", CT.HoaDonBanID.Trim(), CT.MatHangID.Trim() ,CT.DGban,CT.SLBan, CT.GiamGia, CT.ThanhTien);
            string mh = string.Format("Update MatHang Set slTon = slTon-(SELECT SUM(SLBan) FROM ChiTietHDB WHERE MatHangID = '" + CT.MatHangID + "' AND HoaDonBanID='"+CT.HoaDonBanID+"')  Where MatHangID = '" + CT.MatHangID + "'");
            thucthisql(sql);
            thucthisql(mh);
            return true;
        }
       
        public bool IsStockEnough(string productId, int quantity)
        {
            string queryString = "SELECT slTon FROM MatHang WHERE MatHangId = @matHangId";
            int currentQuantity = 0;

            using (SqlConnection connection = new SqlConnection(connect.GetConnectionString()))
            {
                SqlCommand command = new SqlCommand(queryString, connection);//chuỗi truy vấn và kết nối.
                command.Parameters.AddWithValue("@MatHangId", productId);//thêm tham số @ với giá trị

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();//lấy số lượng hàng trong bảng mặt hàng

                    if (reader.Read())
                    {
                        currentQuantity = (int)reader["slTon"];//Nếu có một hàng được trả về bởi truy vấn,
                                                               //nó sẽ gán giá trị của slToncột cho currentQuantity.
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            if (currentQuantity >= quantity)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool SuaCTHDB(ChiTietHoaDonBan CT)
        {
            string sql = string.Format("Update ChiTietHDB Set SLBan ='{2}', DGban ='{3}',GiamGia='{4}',ThanhTien='{5}' WHERE HoaDonBanID='{0}' and MatHangID='{1}'", CT.HoaDonBanID, CT.MatHangID, CT.SLBan, CT.DGban, CT.GiamGia, CT.ThanhTien);
            thucthisql(sql);
            return true;
        }
        public bool XoaCTHDB(string ma, string ma2)
        {
            ChiTietHoaDonBan CT = new ChiTietHoaDonBan();
            string sql = "Delete from ChiTietHDB where MathangID = '" + ma.Trim() + "' AND HoaDonbanID='"+ma2.Trim()+"'";
            thucthisql(sql);
            return true;
        }
       


    }
}
