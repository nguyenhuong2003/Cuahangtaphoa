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
    public  class DAL_KhachHang:DBConnect 
    {
        DBConnect connect = new DBConnect();
        public DataTable getData()
        {
            string sql = "Select * from KhachHang  ";
            return connect.getData(sql);
        }

        public int kiemtramatrung(string ma)
        {
            string sql = "Select count(*) from KhachHang where KhachHangID= '" + ma.Trim() + "'";
            return connect.kiemtramatrung(ma, sql);
        }
        public bool themKH(KhachHang kh )
        {
            string sql = "Insert into KhachHang values('" + kh.KhachHangID + "',N'" + kh.HotenKH + "',N'"+kh.DiachiKH+"','"+kh.EmailKH+"','"+kh.SdtKH+"')";
            thucthisql(sql);
            return true;
        }
        public bool suaKH(KhachHang kh)
        {
            string sql = "Update KhachHang  set HotenKH =N'" + kh.HotenKH + "',DiachiKH=N'"+kh.DiachiKH+"',Emailkh='"+kh.EmailKH+"',SdtKH='"+kh.SdtKH+"' where KhachHangID='" + kh.KhachHangID + "'";
            thucthisql(sql);
            return true;
        }
        public bool xoaKH (string ma)
        {
            string sql = "Delete from KhachHang  where KhachHangID='" + ma + "'";
            thucthisql(sql);
            return true;
        }
       
       
        public DataTable getkhtimkiem(String name)
        {
            string sql = " Select * from KhachHang where HotenKH   like N'%" + name + "%'";
            return connect.getData(sql);

        }


        public int TimKiemKH(string name)
        {
            string sql = " Select count(*) from KhachHang  where HotenKH  like N'%" + name + "%'";//N'%bánh%'
            //thucthisql(sql);
            return connect.timkiem(name, sql);
        }

    }
}
