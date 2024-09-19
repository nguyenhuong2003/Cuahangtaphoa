using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public  class KhachHang
    {
        public string KhachHangID { get; set; }
        public string HotenKH { get; set; }
        public string DiachiKH  { get; set; }
        public string EmailKH  { get; set; }
        public string SdtKH  { get; set; }


        public KhachHang ()
        {

        }
        public KhachHang (string ma, string ten,string diachi,string email,string sdt )
        {
            this.KhachHangID  = ma;
            this.HotenKH = ten;
            this.DiachiKH=diachi;
            this.EmailKH = email;
            this.SdtKH = sdt;
        }
    }
}
