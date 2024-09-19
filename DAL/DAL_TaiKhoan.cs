using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_TaiKhoan : DBConnect
    {
        DBConnect connect = new DBConnect();
        public bool ValidateLogin(string username, string password)
        {
            bool isValid = false;

            using (SqlConnection connection = new SqlConnection(connect.GetConnectionString()))// Chuỗi kết nối 
            {
                string query = string.Format("SELECT COUNT(*) FROM TaiKhoan  WHERE Username = '{0}' AND Password = '{1}'", username, password);
                // chuỗi để kiểm tra sự tồn tại của một bản ghi phù hợp trong bảng

                using (SqlCommand command = new SqlCommand(query, connection))//Chuỗi truy vấn và đối tượng kết nối
                {
                    command.Parameters.AddWithValue("@username", username);//Hai tham số @ được thêm vào 
                    command.Parameters.AddWithValue("@password", password);

                    connection.Open();
                    int count = (int)command.ExecuteScalar(); // Trả về số lượng bản ghi phù hợp

                    isValid = (count > 0); // Nếu có bản ghi phù hợp, đăng nhập thành công
                }
            }
            return isValid;
        }
    }
}
