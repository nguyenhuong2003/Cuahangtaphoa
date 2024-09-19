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
    public  class BUS_HoaDonBan
    {
        DAL_HoaDonBan  dalhdb  = new DAL_HoaDonBan();
        public DataTable getData()
        {
            return dalhdb.getData();
        }

        public DataTable StatisticalSaleBill(string startDate,string endDate)
        {
            return dalhdb.StatisticalSaleBill(startDate,endDate);
        }

        public int kiemtramatrung(string ma)
        {
            return dalhdb.kiemtramatrung(ma);
        }
        public bool ThemHDB(HoaDonBan hdb)
        {
            return dalhdb.ThemHDB(hdb);
        }
        //public bool ThemHDBTHU(HoaDonBan hdb)
        //{
        //    return dalhdb.ThemHDBTHU(hdb);
        //}


        public bool SuaHDB(HoaDonBan hdb)
        {
            return dalhdb.SuaHDB(hdb );
        }
        public bool XoaHDB(string ma)
        {
            return dalhdb.XoaHDB(ma);
        }
       
    }
}
