using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public  class MatHang
    {
        public string LoaiHangID  { get; set; }
        public string MatHangID  { get; set; }
        public string Tenhang  { get; set; }

        public int slTon { get; set; }

        public MatHang ()
        {

        }
        public MatHang (string maloai , string mahang ,string tenhang, int slton )
        {
            this.LoaiHangID = maloai;
            this.MatHangID  = mahang ;
            this.Tenhang = tenhang;
            this.slTon = slton;

        }
    }
}
