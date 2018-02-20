using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace SaglikOcagiOtomasyonu.Utils
{
    public static class SQLDB
    {
        private static SqlConnection _baglan = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);
        private static Object o = new Object();

        static void  Open()
        {
            if (_baglan.State == ConnectionState.Closed)
                _baglan.Open();
        }
        static void Close()
        {
            if (_baglan.State == ConnectionState.Open)
                _baglan.Close();
        }
        public static void Execute(SqlCommand sorgu)
        {
            
                Open();
                sorgu.Connection = _baglan;
                int i= sorgu.ExecuteNonQuery();
                Close();
            
        }
        public static SqlDataReader ExecuteReader(string sorgu)
        {
            SqlDataReader read = null;
         
                Open();
                SqlCommand cmd = new SqlCommand(sorgu, _baglan);
                read = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            return read;
        }
    
    }
}
