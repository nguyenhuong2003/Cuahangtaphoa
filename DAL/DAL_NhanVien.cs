using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
using System.Runtime.CompilerServices;

namespace DAL
{
    public  class DAL_NhanVien:DBConnect 
    {
        DBConnect connect = new DBConnect();
        public DataTable getData()
        {
            string sql = "Select * from NhanVien";
            return connect.getData(sql);
        }

        public int kiemtramatrung(string ma)
        {
            string sql = "Select count(*) from NhanVien where NhanVienID = '" + ma.Trim() + "'";
            return connect.kiemtramatrung(ma, sql);
        }
        public bool themNV (NhanVien nv )
        {
            string ngay = string.Format("{0}/{1}/{2}", nv.NgaysinhNV .Year, nv.NgaysinhNV.Month, nv.NgaysinhNV .Day);

            string sql = "Insert into NhanVien values('" + nv.NhanVienID  + "',N'" + nv.HotenNV  + "',N'"+nv.GioitinhNV+"','"+ngay+"',N'"+nv.diachiNV+"','"+nv.EmailNv+"','"+nv.SdtNV+"')";
            thucthisql(sql);
            return true;
        }
        public bool suaNV(NhanVien nv)
        {
            string ngay = string.Format("{0}/{1}/{2}", nv.NgaysinhNV.Year, nv.NgaysinhNV.Month, nv.NgaysinhNV.Day);

            string sql = "Update NhanVien set HotenNV=N'" + nv.HotenNV + "',GioitinhNV=N'"+nv.GioitinhNV+"',NgaysinhNV='"+ngay+"',diachiNV=N'"+nv.diachiNV+"',EmailNv='"+nv.EmailNv+"',SdtNV='"+nv.SdtNV+"' where NhanVienID ='" + nv.NhanVienID + "'";
            thucthisql(sql);
            return true;
        }
        public bool xoaNV(string ma)
        {

            string sql = "Delete from NhanVien where NhanVienID ='" + ma + "'";
            thucthisql(sql);
            return true;
        }
        public DataTable getnvtimkiem(String name)
        {
            string sql = " Select * from NhanVien  where HotenNV    like N'%" + name + "%'";
            return connect.getData(sql);

        }


        public int TimKiemNV (string name)
        {
            string sql = " Select count(*) from NhanVien  where HotenNV  like N'%" + name + "%'";//N'%bánh%'
            return connect.timkiem(name, sql);
        }


    }
}
