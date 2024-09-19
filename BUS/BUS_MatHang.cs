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
    public class BUS_MatHang
    {
        DAL_MatHang  dalmh = new DAL_MatHang ();
        public DataTable getData()
        {
            return dalmh.getData();
        }
        public int kiemtramatrung(string ma)
        {
            return dalmh.kiemtramatrung(ma);
        }
        public bool themMH(MatHang mh )
        {
            return dalmh.themMH (mh );
        }
        public bool suaMH(MatHang mh)
        {
            return dalmh.suaMH (mh );
        }
        public bool xoaMH(string ma)
        {
            return dalmh.xoaMH (ma);
        }
        public int TimKiemMH(string name)
        {
            return dalmh.TimKiemMH(name);
        }
        public DataTable getmhtimkiem(String name)
        {
            return dalmh.getmhtimkiem (name);
        }
    }
}
