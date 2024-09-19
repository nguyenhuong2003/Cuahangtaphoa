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
    public  class BUS_ChiTietHoaDonNhap
    {
        DAL_ChiTietHoaDonNhap  dal_CTHDN = new DAL_ChiTietHoaDonNhap();
        public DataTable getDataCTHDN(string ma)
        {
            return dal_CTHDN.getDataCTHDN(ma);
        }

        public int kiemtramatrung2(string ma, string ma2)
        {
            return dal_CTHDN.kiemtramatrung2(ma, ma2);
        }
        public bool ThemCTHDN(ChiTietHoaDonNhap  CTHDN)
        {
            return dal_CTHDN.ThemCTHDN(CTHDN );
        }
        public bool SuaCTHDN(ChiTietHoaDonNhap  CTHDN )
        {
            return dal_CTHDN.SuaCTHDN(CTHDN);
        }
        public bool XoaCTHDN(string ma, string ma2)
        {
            return dal_CTHDN.XoaCTHDN(ma, ma2);
        }

    }
}
