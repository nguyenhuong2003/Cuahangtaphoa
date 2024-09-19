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
    public class DAL_LoaiHang:DBConnect
    {
        DBConnect connect = new DBConnect();
        public DataTable getData()
        {
            string sql = "Select * from LoaiHang";
            return connect.getData(sql);
        }

        public int kiemtramatrung(string ma)
        {
            string sql = "Select count(*) from LoaiHang where LoaiHangID= '" + ma.Trim() + "'";
            return connect.kiemtramatrung(ma, sql);
        }
        public bool themLH(LoaiHang lh)
        {
            string sql = "Insert into LoaiHang values('" + lh.LoaiHangID + "',N'" + lh.TenLH + "')";
            thucthisql(sql);
            return true;
        }
        public bool suaLH(LoaiHang lh)
        {
            string sql = "Update LoaiHang set TenLH=N'" + lh.TenLH + "' where LoaiHangID='" + lh.LoaiHangID + "'";
            thucthisql(sql);
            return true;
        }
        public bool xoaLH(string ma)
        {
            string sql = "Delete from LoaiHang where LoaiHangID='" + ma + "'";
            thucthisql(sql);
            return true;
        }
        public DataTable getlhtimkiem(String name)
        {
            string sql = " Select * from LoaiHang where TenLH  like N'%" + name + "%'";
            return connect.getData(sql);

        }
        public int TimKiemLH(string name)
        {
            string sql = " Select count(*) from LoaiHang where TenLH like N'%" + name + "%'";//N'%bánh%'
            //thucthisql(sql);
            return connect.timkiem(name, sql);
        }

    }
}
