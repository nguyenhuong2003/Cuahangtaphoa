using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public  class LoaiHang
    {
        public string LoaiHangID { get; set; }
        public string TenLH { get; set; }
        public LoaiHang()
        {

        }
        public LoaiHang(string ma, string ten )
        {
            this.LoaiHangID = ma;
            this.TenLH = ten;
            
        }

    }
}
