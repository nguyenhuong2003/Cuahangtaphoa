using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public  class NhaCC
    {
        public string NhaCCID  { get; set; }
        public string TenNCC { get; set; }
        public string diachiNCC  { get; set; }
        public string sdtNCC { get; set; }

        public NhaCC()
        {

        }
        public NhaCC(string ma, string ten, string diachiNCC, string sdtNCC)
        {
            this.NhaCCID = ma;
            this.TenNCC  = ten;
            this.diachiNCC = diachiNCC;
            this.sdtNCC = sdtNCC;
        }
    }
}
