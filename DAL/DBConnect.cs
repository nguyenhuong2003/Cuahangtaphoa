using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class DBConnect
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataTable dt;
        string chuoikn= @"Data Source=DESKTOP-QRSGEFC\SQLEXPRESS;Initial Catalog=CuaHangTapHoa;Integrated Security=True";
        public string GetConnectionString()
        {
            return chuoikn;
        }
        public void ketnoi()
        {

            con = new SqlConnection(chuoikn);
            if (con.State == ConnectionState.Closed)
                con.Open();
        }
        public void dongkn()
        {
            con = new SqlConnection(chuoikn);
            if (con.State == ConnectionState.Open)
                con.Close();
        }
        public DataTable getData(string sql)
        {
            ketnoi();
            da = new SqlDataAdapter(sql, con);
            dt = new DataTable();
            da.Fill(dt);
            dongkn();
            return dt;
        }
       
        public int kiemtramatrung(string ma, string sql)
        {
            ketnoi();
            int i;
            cmd = new SqlCommand(sql, con);
            i = (int)cmd.ExecuteScalar();
            dongkn();
            return i;
        }
        public int kiemtramatrung2(string ma,string ma2,  string sql)
        {
            ketnoi();
            int i;
            cmd = new SqlCommand(sql, con);
            i = (int)cmd.ExecuteScalar();
            dongkn();
            return i;
        }
        public void thucthisql(string sql)
        {
            ketnoi();
            cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            dongkn();
        }
        public int timkiem(string ten, string sql)
        {
            ketnoi();
            int i;
            cmd = new SqlCommand(sql, con);
            i = (int)cmd.ExecuteScalar();
            dongkn();
            return i;
        }
        public bool IsValidPhoneNumber(string phoneNumber)
        {
            int n;
            bool isNumeric = int.TryParse(phoneNumber, out n);
            return !string.IsNullOrEmpty(phoneNumber) && isNumeric && phoneNumber.Length == 10;

        }
        public bool Kiemtraemail(string email)
        {
            if (email.Contains('@'))
            {

                return true;
            }
            else
                return false;
        }
    }
}
