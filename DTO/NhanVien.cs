using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public  class NhanVien
    {
        public string NhanVienID  { get; set; }
        public string HotenNV  { get; set; }
        public string GioitinhNV  { get; set; }

        public DateTime  NgaysinhNV  { get; set; }
        public string diachiNV  { get; set; }
        public string EmailNv  { get; set; }
        public string SdtNV  { get; set; }

        public NhanVien()
        {

        }
        public NhanVien(string ma, string ten,string gt,DateTime ns,string diachi,string email,string sdtnv )
        {
            this.NhanVienID = ma;
            this.HotenNV = ten;
            this.GioitinhNV = gt;
            this.NgaysinhNV=ns;
            this.diachiNV=diachi;
            this.EmailNv = email;
            this.SdtNV = sdtnv;

        }
    }
}
