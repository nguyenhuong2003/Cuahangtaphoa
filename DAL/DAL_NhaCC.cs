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
    public  class DAL_NhaCC:DBConnect 
    {
        DBConnect connect = new DBConnect();
        public DataTable getData()
        {
            string sql = "Select * from NhaCC";
            return connect.getData(sql);
        }

        public int kiemtramatrung(string ma)
        {
            string sql = "Select count(*) from NhaCC where NhaCCID= '" + ma.Trim() + "'";
            return connect.kiemtramatrung(ma, sql);
        }
        public bool themNCC (NhaCC cc )
        {
            string sql = "Insert into NhaCC values('" + cc.NhaCCID + "',N'" + cc.TenNCC + "',N'"+cc.diachiNCC+"','"+cc.sdtNCC+"')";
            thucthisql(sql);
            return true;
        }
        public bool suaNCC(NhaCC cc )
        {
            string sql = "Update NhaCC set TenNCC=N'" + cc.TenNCC+ "',diachiNCC=N'"+cc.diachiNCC+"',sdtNCC='"+cc.sdtNCC+"' where NhaCCID='" + cc.NhaCCID + "'";
            thucthisql(sql);
            return true;
        }
        public bool xoaNCC(string ma)
        {
            string sql = "Delete from NhaCC  where NhaCCID ='" + ma + "'";
            thucthisql(sql);
            return true;
        }
        public DataTable getncctimkiem(String name)
        {
            string sql = " Select * from NhaCC where TenNCC   like N'%" + name + "%'";
            return connect.getData(sql);

        }


        public int TimKiemNCC(string name)
        {
            string sql = " Select count(*) from  NhaCC where TenNCC  like N'%" + name + "%'";//N'%bánh%'
            //thucthisql(sql);
            return connect.timkiem(name, sql);
        }
    }
}
