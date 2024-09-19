using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting.Contexts;

namespace DAL
{
    public  class DAL_ChiTietHoaDonNhap:DBConnect 
    {
        DBConnect connect = new DBConnect();
        public DataTable getDataCTHDN(string ma)
        {
            string sql = "SELECT cthdn.MathangID,cthdn.Slnhap,cthdn.DGnhap,cthdn.ThanhTien FROM ChitietHDN AS cthdn WHERE cthdn.HoaDonnhapID = '" + ma.Trim() + "'";
            return connect.getData(sql);
        }

        public int kiemtramatrung2(string ma, string ma2)
        {
            string sql = "Select count(*) from ChiTietHDN where HoaDonnhapID ='" + ma.Trim() + "' AND MatHangID='" + ma2.Trim() + "'";
            return connect.kiemtramatrung2(ma, ma2, sql);
        }
        public bool ThemCTHDN(ChiTietHoaDonNhap  CT)
        {
            string sql = string.Format("INSERT INTO ChitietHDN (HoaDonnhapID,MathangID,Slnhap,DGnhap,ThanhTien) VALUES ('{0}','{1}','{2}','{3}','{4}')", CT.HoaDonNhapID.Trim(), CT.MatHangID.Trim(), CT.SLnhap, CT.DGnhap, CT.ThanhTien);
            string mh = string.Format("Update MatHang Set slTon = slTon+(SELECT SUM(SLnhap) FROM ChiTietHDN WHERE MatHangID = '" + CT.MatHangID + "' AND HoaDonNhapID='" + CT.HoaDonNhapID + "')  Where MatHangID = '" + CT.MatHangID + "'");
            thucthisql(sql);
            thucthisql(mh);
            return true;
        }
        public bool SuaCTHDN(ChiTietHoaDonNhap CT)
        {
            string sql = string.Format("Update ChiTietHDN Set SLNhap ='{2}', DGnhap ='{3}',ThanhTien='{4}' WHERE HoaDonNhapID='{0}' and MatHangID='{1}'", CT.HoaDonNhapID, CT.MatHangID, CT.SLnhap, CT.DGnhap, CT.ThanhTien);
            thucthisql(sql);
            return true;
        }
        public bool XoaCTHDN(string ma, string ma2)
        {
            ChiTietHoaDonNhap CT = new ChiTietHoaDonNhap();
            string sql = "Delete from ChiTietHDN where MatHangID = '" + ma.Trim() + "' AND HoaDonNhapID='" + ma2.Trim() + "'";
            thucthisql(sql);
            return true;
        }


    }
}
