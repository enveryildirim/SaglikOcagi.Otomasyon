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
    public static class HastaProvider
    {
        private static Hasta DataReaderToObject(SqlDataReader read)
        {
            read.Read();
            Hasta h = new Hasta()
            {
                DosyaNo = read.GetInt32(0),
                TC = read.GetString(1),
                AdSoyad = read.GetString(2),
                DogumYeri = read.GetString(3),
                DogumTarihi = read.GetDateTime(4),
                AnneAdi = read.GetString(5),
                BabaAdi = read.GetString(6),
                Cinsiyet = read.GetString(7),
                MedeniHal = read.GetString(8),
                Tel = read.GetString(9),
                KurumSicilNo=read.GetString(10),
                KurumAdi=read.GetString(11),
                YakiniTelNo=read.GetString(12),
                YakiniKurumSicilNo=read.GetString(13),
                YakiniKurumAdi=read.GetString(14),
                Adres = read.GetString(15),
            };
            read.Close();
            return h;
        }
        public static Hasta Get(string sorgu)
        {
            return DataReaderToObject(SQLDB.ExecuteReader(sorgu));
        }
        public static void Ekle(Hasta h)
        {
            string sorgu = "insert into Hasta (TC,AdSoyad,DogumYeri,DogumTarihi,AnneAdi,BabaAdi," +
              "Cinsiyet,MedeniHal,TelNo,KurumSicilNo,KurumAdi,YakiniTelNo,YKurumSicil,YkurumAdi,Adres) values" +
            "(@tc,@ad,@dyeri,@dtarihi,@aadi,@badi,@cinsiyet,@medenihal,@tel,@kurumsicil,@kurumadi,@ytel,@ykurumsicil,@ykurumadi,@adres)";

            SqlCommand cmd = new SqlCommand(sorgu);
            cmd.Parameters.AddWithValue("@tc", h.TC);
            cmd.Parameters.AddWithValue("@ad", h.AdSoyad);
            cmd.Parameters.AddWithValue("@dyeri", h.DogumYeri);
            cmd.Parameters.AddWithValue("@dtarihi", h.DogumTarihi);
            cmd.Parameters.AddWithValue("@aadi", h.AnneAdi);
            cmd.Parameters.AddWithValue("@badi", h.BabaAdi);
            cmd.Parameters.AddWithValue("@cinsiyet", h.Cinsiyet);
            cmd.Parameters.AddWithValue("@medenihal", h.MedeniHal);
            cmd.Parameters.AddWithValue("@tel", h.Tel);
            cmd.Parameters.AddWithValue("@kurumsicil", h.KurumSicilNo);
            cmd.Parameters.AddWithValue("@kurumadi", h.KurumAdi);
            cmd.Parameters.AddWithValue("@ytel", h.YakiniTelNo);
            cmd.Parameters.AddWithValue("@ykurumsicil", h.YakiniKurumSicilNo);
            cmd.Parameters.AddWithValue("@ykurumadi", h.YakiniKurumAdi);
            cmd.Parameters.AddWithValue("@adres", h.Adres);
            SQLDB.Execute(cmd);
        }
        public static void Guncelle(Hasta h)
        {
            string sorgu = "update Hasta set TC=@tc,AdSoyad=@ad,DogumYeri=@dyeri,DogumTarihi=dtarihi,AnneAdi=@aadi,BabaAdi=@badi," +
              "Cinsiyet=@cinsiyet,MedeniHal=@medenihal,TelNo=@tel,KurumSicilNo=@kurumsicil,KurumAdi=@kurumadi,YakiniTelNo=@ytel,YKurumSicil=@kurumsicil,YkurumAdi=@ykurumadi,Adres=@adres where DosyaNo=@no";

            SqlCommand cmd = new SqlCommand(sorgu);
            cmd.Parameters.AddWithValue("@tc", h.TC);
            cmd.Parameters.AddWithValue("@ad", h.AdSoyad);
            cmd.Parameters.AddWithValue("@dyeri", h.DogumYeri);
            cmd.Parameters.AddWithValue("@dtarihi", h.DogumTarihi);
            cmd.Parameters.AddWithValue("@aadi", h.AnneAdi);
            cmd.Parameters.AddWithValue("@badi", h.BabaAdi);
            cmd.Parameters.AddWithValue("@cinsiyet", h.Cinsiyet);
            cmd.Parameters.AddWithValue("@medenihal", h.MedeniHal);
            cmd.Parameters.AddWithValue("@tel", h.Tel);
            cmd.Parameters.AddWithValue("@kurumsicil", h.KurumSicilNo);
            cmd.Parameters.AddWithValue("@kurumadi", h.KurumAdi);
            cmd.Parameters.AddWithValue("@ytel", h.YakiniTelNo);
            cmd.Parameters.AddWithValue("@ykurumsicilno", h.YakiniKurumSicilNo);
            cmd.Parameters.AddWithValue("@ykurumadi", h.YakiniKurumAdi);
            cmd.Parameters.AddWithValue("@adres", h.Adres);
            cmd.Parameters.AddWithValue("@no", h.DosyaNo);
            SQLDB.Execute(cmd);
        }
        public static void Sil(int no)
        {
            string sorgu = "delete Hasta where DosyaNo=@no";
            SqlCommand cmd = new SqlCommand(sorgu);
            cmd.Parameters.AddWithValue("@no", no);
            SQLDB.Execute(cmd);
        }
        public static int GetLastDosyaNo()
        {
            string sorgu = "select top 1 DosyaNo from Hasta order by DosyaNo DESC ";
            SqlDataReader read= SQLDB.ExecuteReader(sorgu);
            read.Read();
            int no=read.GetInt32(0);
            read.Close();
            return no+1;
        }
        public static List<string> GetAllTC()
        {
            string sorgu = "select TC from Hasta";
            SqlDataReader read = SQLDB.ExecuteReader(sorgu);
            List<string> liste=new List<string>();
            while(read.Read())
            {
                liste.Add(read.GetString(0));
            }
            read.Close();
            return liste;
        }
        public static List<string> GetAllDosyaNo()
        {
            string sorgu = "select DosyaNo from Hasta";
            SqlDataReader read = SQLDB.ExecuteReader(sorgu);
            List<string> liste = new List<string>();
            while (read.Read())
            {
                liste.Add(read.GetInt32(0).ToString());
            }
            read.Close();
            return liste;
        }
    }
}
