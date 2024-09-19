using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAL
{
    public  class DAL_HoaDonBan:DBConnect 
    {
        DBConnect connect = new DBConnect();
        public DataTable getData()
        {
            string sql = "SELECT hdb.HoaDonbanID,hdb.NhanvienID,hdb.KhachhangID,hdb.Ngayban,SUM(cthdb.Slban*cthdb.DGban - cthdb.GiamGia) AS TongTien FROM HoaDonban AS hdb LEFT JOIN ChitietHDB AS cthdb ON hdb.HoaDonbanID = cthdb.HoaDonbanID GROUP BY hdb.HoaDonbanID,hdb.NhanvienID,hdb.KhachhangID,hdb.Ngayban";
            return connect.getData(sql);
        }
        public int kiemtramatrung(string ma)
        {
            string sql = "Select count(*) from HoaDonBan where HoaDonBanID='" + ma.Trim() + "'";
            return connect.kiemtramatrung(ma, sql);
        }
        public bool ThemHDB(HoaDonBan hdb)
        {
            string datebirthday = string.Format("{0}/{1}/{2}", hdb.NgayBan.Month  , hdb.NgayBan.Day, hdb.NgayBan.Year );
            string sql = string.Format("Insert into HoaDonBan values('{0}','{1}', '{2}', '{3}')", hdb.HoaDonBanID, hdb.NhanvienID, hdb.KhachhangID, datebirthday);
            thucthisql(sql);
            return true;
        }
      
        public bool SuaHDB(HoaDonBan hdb)
        {
            string datebirthday = string.Format("{0}/{1}/{2}", hdb.NgayBan.Month , hdb.NgayBan.Day , hdb.NgayBan.Year );

            string sql = string.Format("Update HoaDonBan Set  NhanvienID= '{0}', KhachhangID= '{1}', NgayBan = '{2}' Where  HoaDonBanID= '{3}'", hdb.NhanvienID, hdb.KhachhangID, datebirthday, hdb.HoaDonBanID);
            thucthisql(sql);
            return true;
        }
        public bool XoaHDB(string ma)
        {
            string sql = "Delete from HoaDonBan where HoaDonBanID  = '" + ma.Trim() + "'";
            thucthisql(sql);
            return true;
        }
        // Thong ke hoa don
        public DataTable StatisticalSaleBill(string startDate,string endDate)
        {
            string sql = String.Format(@"SELECT H.HoaDonBanId, H.KhachhangID, H.NhanvienID, H.NgayBan, SUM(C.ThanhTien) AS TongTien FROM HoaDonBan AS H INNER JOIN ChiTietHDB C ON H.HoaDonBanId = C.HoaDonBanId WHERE ('"+startDate+"' IS NULL OR '"+startDate+"'= '' OR H.NgayBan >= CAST('"+startDate+"' AS datetime)) AND ('"+endDate+"' IS NULL OR '"+endDate+"' = '' OR H.NgayBan <= CAST('"+endDate+"' AS datetime)) GROUP BY H.HoaDonBanId, H.NgayBan, H.NhanvienID, H.KhachhangID ");
            return connect.getData(sql);
        }
    }
}
