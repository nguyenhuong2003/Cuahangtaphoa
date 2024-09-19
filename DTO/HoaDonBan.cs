using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public  class HoaDonBan
    {
       
            public string HoaDonBanID { get; set; }
            public string NhanvienID  { get; set; }
            public string KhachhangID  { get; set; }
            public DateTime NgayBan  { get; set; }
          public int  TongTien { get; set; }

            public HoaDonBan()
            {

            }
    }
}
