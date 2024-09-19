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
    public class BUS_HoaDonNhap
    {
        DAL_HoaDonNhap dalhdn=new DAL_HoaDonNhap();
        public DataTable getData()
        {
            return dalhdn.getData();
        }


        public int kiemtramatrung(string ma)
        {
            return dalhdn.kiemtramatrung(ma);
        }
        public bool ThemHDN(HoaDonNhap  hdn )
        {
            return dalhdn.ThemHDN(hdn);
        }
        public bool SuaHDN(HoaDonNhap hdn)
        {
            return dalhdn.SuaHDN(hdn);
        }
        public bool XoaHDN(string ma)
        {
            return dalhdn.XoaHDN(ma);
        }
    }
}
