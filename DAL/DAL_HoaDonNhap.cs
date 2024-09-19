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
    public  class DAL_HoaDonNhap:DBConnect 
    {
        DBConnect connect = new DBConnect();
        public DataTable getData()
        {
            string sql = "SELECT hdn.HoaDonnhapID,hdn.NhanvienID,hdn.NhaCCID,hdn.Ngaynhap,SUM(cthdn.Slnhap*cthdn.DGnhap) AS TongTien FROM HoaDonnhap AS hdn  LEFT JOIN ChitietHDN AS cthdn ON hdn.HoaDonnhapID = cthdn.HoaDonnhapID GROUP BY hdn.HoaDonnhapID,hdn.NhanvienID,hdn.NhaCCID,hdn.Ngaynhap";
            return connect.getData(sql);
        }

        public int kiemtramatrung(string ma)
        {
            string sql = "Select count(*) from HoaDonNhap where HoaDonNhapID='" + ma.Trim() + "'";
            return connect.kiemtramatrung(ma, sql);
        }
        public bool ThemHDN(HoaDonNhap  hdn )
        {
            string datebirthday = string.Format("{0}/{1}/{2}", hdn.Ngaynhap.Month, hdn.Ngaynhap.Day, hdn.Ngaynhap.Year);
            string sql = string.Format("Insert into HoaDonNhap values('{0}','{1}', '{2}', '{3}')", hdn.HoaDonNhapID, hdn.NhanvienID, hdn.NhaCCID , datebirthday);
            thucthisql(sql);
            return true;
        }

        public bool SuaHDN(HoaDonNhap hdn)
        {
            string datebirthday = string.Format("{0}/{1}/{2}", hdn.Ngaynhap.Month , hdn.Ngaynhap.Day , hdn.Ngaynhap.Year);

            string sql = string.Format("Update HoaDonNhap  Set  NhanvienID= '{0}', NhaCCID= '{1}', Ngaynhap = '{2}' Where  HoaDonNhapID= '{3}'", hdn.NhanvienID, hdn.NhaCCID, datebirthday, hdn.HoaDonNhapID);
            thucthisql(sql);
            return true;
        }
        public bool XoaHDN(string ma)
        {
            string sql = "Delete from HoaDonNhap where HoaDonNhapID  = '" + ma.Trim() + "'";
            thucthisql(sql);
            return true;
        }
    }
}
