using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public  class ChiTietHoaDonNhap
    {
       

        public string HoaDonNhapID { get; set; }
        public string MatHangID { get; set; }
        public int SLnhap  { get; set; }
        public float DGnhap { get; set; }
        
        public float ThanhTien { get; set; }
        public ChiTietHoaDonNhap()
        {

        }
    }

}
