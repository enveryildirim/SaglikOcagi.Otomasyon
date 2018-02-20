using SaglikOcagiOtomasyonu.Core.Model;
using SaglikOcagiOtomasyonu.Utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaglikOcagiOtomasyonu.Core.BLL
{
    public static class PoliklinikProvider
    {
        private static Poliklinik DataReaderToObject(SqlDataReader read)
        {
            read.Read();
            Poliklinik p = new Poliklinik() 
            {
                Adi=read.GetString(0),
                Aciklama=read.GetString(1),
                Durum=read.GetBoolean(2)
            };
            read.Close();
            return p;
        }
        public static Poliklinik Get(string sorgu)
        {
            return DataReaderToObject(SQLDB.ExecuteReader(sorgu));
        }
        public static List<string> GetAll()
        {
            List<string> list = new List<string>();
     
            SqlDataReader read = SQLDB.ExecuteReader("select Adi from Poliklinik");
            while(read.Read())
            {
                list.Add(read.GetString(0));
            }
            read.Close();
            return list;
        }
        public static void Ekle(Poliklinik p)
        {
            string sorgu = "insert into Poliklinik(Adi,Aciklama,Durum)values(@ad,@aciklama,@durum)";
            SqlCommand cmd = new SqlCommand(sorgu);
            cmd.Parameters.AddWithValue("@ad", p.Adi);
            cmd.Parameters.AddWithValue("@aciklama", p.Aciklama);
            cmd.Parameters.AddWithValue("@durum", p.Durum);
            SQLDB.Execute(cmd);
        }
        public static void Guncelle(Poliklinik p)
        {
            string sorgu = "update Poliklinik set Adi=@ad,Aciklama=@aciklama,Durum=@durum where Adi=@ad";
            SqlCommand cmd = new SqlCommand(sorgu);
            cmd.Parameters.AddWithValue("@ad", p.Adi);
            cmd.Parameters.AddWithValue("@aciklama", p.Aciklama);
            cmd.Parameters.AddWithValue("@durum", p.Durum);
            SQLDB.Execute(cmd);
        }
        public static void Sil(string ad)
        {
            SqlCommand cmd = new SqlCommand("delete Poliklinik where Adi=@adi");
            cmd.Parameters.AddWithValue("@ad", ad);
            SQLDB.Execute(cmd);
        }
    }
}
