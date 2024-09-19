using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
using System.ComponentModel.Design;
using System.Xml.Linq;

namespace DAL
{
    public  class DAL_MatHang:DBConnect 
    {
        DBConnect connect = new DBConnect();
        public DataTable getData()
        {
            string sql = "Select * from MatHang";
            return connect.getData(sql);
        }
        public DataTable getmhtimkiem(String name)
        {
            string sql = " Select * from MatHang where TenHang  like N'%" + name + "%'";
            return connect.getData(sql);

        }

        public int kiemtramatrung(string ma)
        {
            string sql = "Select count(*) from MatHang where MatHangID= '" + ma.Trim() + "'";
            return connect.kiemtramatrung(ma, sql);
        }
        public bool themMH(MatHang mh)
        {
            string sql = "Insert into MatHang  values('" + mh.LoaiHangID + "','" + mh.MatHangID + "',N'"+mh.Tenhang+"','"+mh.slTon+"')";
            thucthisql(sql);
            return true;
        }
        public bool suaMH(MatHang mh)
        {
            string sql = "Update MatHang set Tenhang=N'" + mh.Tenhang + "',LoaiHangID='"+mh.LoaiHangID+ "',slTon = '"+mh.slTon+"'where MatHangID='" + mh.MatHangID + "'";
            thucthisql(sql);
            return true;
        }
        public bool xoaMH(string ma)
        {
            string sql = "Delete from MatHang  where MatHangID='" + ma + "'";
            thucthisql(sql);
            return true;
        }
        public int  TimKiemMH(string name)
        {
            string sql = " Select count(*) from MatHang where TenHang  like N'%" + name +"%'";//N'%bánh%'
            //thucthisql(sql);
            return connect.timkiem(name, sql);
        }
        
    }
}
