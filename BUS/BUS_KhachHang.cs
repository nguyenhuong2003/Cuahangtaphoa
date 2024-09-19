using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace BUS
{
    public  class BUS_KhachHang
    {
        DAL_KhachHang  dalkh  = new DAL_KhachHang();
        public DataTable getData()
        {
            return dalkh .getData();
        }
        
        public int kiemtramatrung(string ma)
        {
            return dalkh .kiemtramatrung(ma);
        }
        public bool themKH (KhachHang kh )
        {
            return dalkh .themKH (kh );
        }
        public bool suaKH (KhachHang kh)
        {
            return dalkh .suaKH (kh );
        }
        public bool xoaKH (string ma)
        {
            return dalkh .xoaKH (ma);
        }
        public bool Kiemtraemail(string email)
        {
            return dalkh.Kiemtraemail(email);
        }
        public bool IsValidPhoneNumber(string phoneNumber)
        {
            return dalkh.IsValidPhoneNumber(phoneNumber);
        }
        public int TimKiemKH(string name)
        {
            return dalkh.TimKiemKH(name);
        }
        public DataTable getkhtimkiem(String name)
        {
            return dalkh.getkhtimkiem(name);
        }
    }
}
