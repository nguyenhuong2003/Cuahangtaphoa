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
    public  class BUS_LoaiHang
    {
        DAL_LoaiHang  dallh  = new DAL_LoaiHang ();
        public DataTable getData()
        {
            return dallh.getData();
        }
      
        public int kiemtramatrung(string ma)
        {
            return dallh.kiemtramatrung(ma);
        }
        public bool themLH(LoaiHang lh )
        {
            return dallh.themLH(lh);
        }
        public bool suaLH (LoaiHang lh)
        {
            return dallh.suaLH(lh);
        }
        public bool xoaLH(string ma)
        {
            return dallh.xoaLH(ma);
        }
        public int TimKiemLH (string name)
        {
            return dallh.TimKiemLH (name);
        }
        public DataTable getlhtimkiem(String name)
        {
            return dallh.getlhtimkiem(name);
        }

    }
}
