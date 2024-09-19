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
    public  class BUS_NhanVien
    {
        DAL_NhanVien  dalnv  = new DAL_NhanVien();
        public DataTable getData()
        {
            return dalnv.getData();
        }
       
        public int kiemtramatrung(string ma)
        {
            return dalnv.kiemtramatrung(ma);
        }
        public bool themNV (NhanVien nv )
        {
            return dalnv.themNV (nv );
        }
        public bool suaNV (NhanVien nv)
        {
            return dalnv.suaNV (nv );
        }
        public bool xoaNV(string ma)
        {
            return dalnv.xoaNV (ma);
        }
        public bool Kiemtraemail(string email)
        {
            return dalnv .Kiemtraemail(email);
        }
        public bool IsValidPhoneNumber(string phoneNumber)
        {
            return dalnv .IsValidPhoneNumber(phoneNumber);
        }
        public int TimKiemNV (string name)
        {
            return dalnv .TimKiemNV (name);
        }
        public DataTable getnvtimkiem(String name)
        {
            return dalnv .getnvtimkiem(name);
        }
    }
}
