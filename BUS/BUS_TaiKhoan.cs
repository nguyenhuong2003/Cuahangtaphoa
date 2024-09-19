using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;
namespace BUS
{
    public class BUS_TaiKhoan
    {
        DAL_TaiKhoan daltk = new DAL_TaiKhoan();
        
        public bool ValidateLogin(string username, string password)
        {
            // Kiểm tra dữ liệu đầu vào nếu cần thiết

            // Gọi phương thức ValidateLogin từ lớp DAL
            bool isValid = daltk.ValidateLogin(username, password);

            return isValid;
        }


    }
  
}
