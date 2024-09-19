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
    public  class BUS_ChiTietHoaDonBan
    {
        DAL_ChiTietHoaDonBan  dal_CTHDB = new DAL_ChiTietHoaDonBan();
        public DataTable getDataCTHDB(string ma)
        {
            return dal_CTHDB.getDataCTHDB(ma);
        }
        public DataTable getDatamh(string ma2 )
        {
            return dal_CTHDB.getDatamh( ma2 );
        }

        public int kiemtramatrung2(string ma ,string ma2)
        {
            return dal_CTHDB.kiemtramatrung2(ma,ma2);
        }
        public bool ThemCTHDB(ChiTietHoaDonBan CTHDB)
        {
            return dal_CTHDB.ThemCTHDB(CTHDB);
        }
        public bool IsStockEnough(string  productId, int quantity)
        {
            return dal_CTHDB.IsStockEnough(productId, quantity);
        }

        public bool SuaCTHDB(ChiTietHoaDonBan CTHDB)
        {
            return dal_CTHDB.SuaCTHDB(CTHDB);
        }
        public bool XoaCTHDB(string ma,string ma2 )
        {
            return dal_CTHDB.XoaCTHDB(ma,ma2 );
        }
        //public double ThongKeDoanhThuTheoThang(string thang, string nam)
        //{
        //    return dal_CTHDB.ThongKeDoanhThuTheoThang(thang, nam);
        //}
        //public DataTable ThongKeHoaDonTheoThang(string thang, string nam)
        //{
        //    return dal_CTHDB.ThongKeHoaDonTheoThang(thang, nam);
        //}
    }
}
