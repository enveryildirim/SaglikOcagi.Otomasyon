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
    public class SevkProvider
    {
        private Sevk DataReaderToObject(SqlDataReader read)
        {
            read.Read();
            Sevk s = new Sevk() 
            {
                No=read.GetInt32(0),
                SevkTarihi=read.GetDateTime(1),
                DosyaNo=read.GetInt32(2),
                Poliklinik=read.GetString(3),
                Saat=read.GetString(4),
                Islem=read.GetString(5),
                DoktorKod=read.GetInt32(6),
                Miktar=read.GetInt32(7),
                BirimFiyat=read.GetInt32(8),
                Sira=read.GetInt32(9),
                Taburcu=read.GetBoolean(10)
            };
            read.Close();
            return s;
        }
        public static Dictionary<string, string> GetAllIslemler()
        {
            Dictionary<string, string> liste = new Dictionary<string, string>();
            SqlDataReader read =SQLDB.ExecuteReader("select * from Islemler");
            while(read.Read())
            {
                liste.Add(read.GetString(0), read.GetInt32(1).ToString());
            }
            read.Close();
            return liste;
        }
        public static List<string> GetAllDoktorNo()
        {
            List<string> liste = new List<string>();
            string sorgu = "select Kodu from Kullanici where Unvan='Doktor'";
            SqlDataReader read= SQLDB.ExecuteReader(sorgu);
            while (read.Read())
            {
                liste.Add(read.GetInt32(0).ToString());
            }
            read.Close();
            return liste;
        }
        public static List<string> GetAllPoliklink()
        {
            List<string> liste = new List<string>();
            string sorgu = "select Adi from Poliklinik";
            SqlDataReader read = SQLDB.ExecuteReader(sorgu);
            while (read.Read())
            {
                liste.Add(read.GetString(0));
            }
            read.Close();
            return liste;
        }
        public static List<Sevk>GetAllSevkler(int dosyano)
        {
            List<Sevk> liste = new List<Sevk>();
            string sorgu = "select * from Sevk where DosyaNo="+dosyano.ToString();
            SqlDataReader read = SQLDB.ExecuteReader(sorgu);
            Sevk s =null;
            while (read.Read())
            {
                s= new Sevk() 
                {
                    No=read.GetInt32(0),
                    SevkTarihi=read.GetDateTime(1),
                    DosyaNo=read.GetInt32(2),
                    Poliklinik=read.GetString(3),
                    Saat=read.GetString(4),
                    Islem=read.GetString(5),
                    DoktorKod=read.GetInt32(6),
                    Miktar=read.GetInt32(7),
                    BirimFiyat=read.GetInt32(8),
                    Sira=read.GetInt32(9),
                    Taburcu=read.GetBoolean(10)
                };
                liste.Add(s);
            }
            read.Close();

            return liste;
        }
        public static int SiraNo(string padi)
        {
            string sorgu = "select top 1 Sira from Sevk where Poliklinik='" + padi + "' order by Sira DESC";
            SqlDataReader read = SQLDB.ExecuteReader(sorgu);
            read.Read();
            int s = 0;
            if(read.HasRows)
            s = read.GetInt32(0);
            read.Close();
            return s + 1;
        }
        public static void Ekle(Sevk s)
        {
            string sorgu = "insert into Sevk (SevkTarihi,DosyaNo,Poliklinik,Saat,Islem,Doktor,Miktar,BirimFiyat,Sira,Taburcu) values("+
                "@sevktarihi,@dosyano,@poliklinik,@saat,@islem,@doktor,@miktar,@birimfiyat,@sira,@taburcu)";
            SqlCommand cmd = new SqlCommand(sorgu);
            cmd.Parameters.AddWithValue("@sevktarihi", s.SevkTarihi);
            cmd.Parameters.AddWithValue("@dosyano", s.DosyaNo);
            cmd.Parameters.AddWithValue("@poliklinik", s.Poliklinik);
            cmd.Parameters.AddWithValue("@saat", s.Saat);
            cmd.Parameters.AddWithValue("@islem", s.Islem);
            cmd.Parameters.AddWithValue("@doktor", s.DoktorKod);
            cmd.Parameters.AddWithValue("@miktar", s.Miktar);
            cmd.Parameters.AddWithValue("@birimfiyat",s.BirimFiyat);
            cmd.Parameters.AddWithValue("@sira", s.Sira);
            cmd.Parameters.AddWithValue("@taburcu", s.Taburcu);
            SQLDB.Execute(cmd);
        }
        public static void TaburcuEt(Hasta no)
        {
            string sorgu = "update Sevk set Taburcu=1 where DosyaNo=@no";
            SqlCommand cmd = new SqlCommand(sorgu);
            cmd.Parameters.AddWithValue("@no", no.DosyaNo);
            SQLDB.Execute(cmd);
            string sorgu2 = "insert into Cikis(DosyaNo,SevkTarihi,CikisTarihi,Odeme,ToplamTutar)values(" +
                "@no,@sevktarihi,@cikistarihi,@odeme,@toplamtutar";
            SqlCommand cmd2 = new SqlCommand(sorgu2);
            cmd2.Parameters.AddWithValue("@no",no.DosyaNo);
            cmd2.Parameters.AddWithValue("@sevktarihi", DateTime.Now);
            cmd2.Parameters.AddWithValue("@cikistarihi", DateTime.Now);
            cmd2.Parameters.AddWithValue("@odeme", 0);
            cmd2.Parameters.AddWithValue("@toplamtutar", 0);
        }
    }
}
