using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public  class ChiTietHoaDonBan
    {
       

        public string  HoaDonBanID  { get; set; }
        public string MatHangID { get; set; }
        public int  SLBan  { get; set; }
        public float DGban  { get; set; }
        public int   GiamGia  { get; set; }
        public float ThanhTien  { get; set; }
        public ChiTietHoaDonBan()
        {

        }

    }
   
}
