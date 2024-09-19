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
    public  class BUS_NhaCC
    {
        DAL_NhaCC  dalncc  = new DAL_NhaCC();
        public DataTable getData()
        {
            return dalncc.getData();
        }
       
        public int kiemtramatrung(string ma)
        {
            return dalncc.kiemtramatrung(ma);
        }
        public bool themNCC (NhaCC cc )
        {
            return dalncc.themNCC(cc);
        }
        public bool suaNCC (NhaCC cc)
        {
            return dalncc.suaNCC (cc );
        }
        public bool xoaNCC (string ma)
        {
            return dalncc.xoaNCC (ma);
        }
        public bool IsValidPhoneNumber(string phoneNumber)
        {
            return dalncc.IsValidPhoneNumber(phoneNumber);
        }
        public int TimKiemNCC(string name)
        {
            return dalncc.TimKiemNCC(name);
        }
        public DataTable getncctimkiem(String name)
        {
            return dalncc.getncctimkiem(name);
        }
    }
}
