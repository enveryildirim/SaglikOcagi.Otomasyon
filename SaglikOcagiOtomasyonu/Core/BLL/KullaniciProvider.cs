using SaglikOcagiOtomasyonu.Utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaglikOcagiOtomasyonu.Core.BLL
{
    public class KullaniciProvider
    {
        

       private static Kullanici DataReaderToObject(SqlDataReader read)
       {
           read.Read();
           Kullanici k = new Kullanici()
           {
               Kodu = read.GetInt32(0),
               TC = read.GetString(1),
               AdSoyad = read.GetString(2),
               KullaniciAdi = read.GetString(3),
               Sifre = read.GetString(4),
               Yetki = read.GetBoolean(5),
               DogumYeri = read.GetString(6),
               DogumTarihi = read.GetDateTime(7),
               AnneAdi = read.GetString(8),
               BabaAdi = read.GetString(9),
               Cinsiyet = read.GetString(10),
               MedeniHal = read.GetString(11),
               KanGrubu = read.GetString(12),
               Maas = Convert.ToDouble(read.GetString(13)),
               Tel = read.GetString(14),
               Adres = read.GetString(15),
               Unvan = read.GetString(16),
               IseBaslamaTarihi = read.GetDateTime(17)

           };
           read.Close();
           return k;
       }
       public static Kullanici GetKullanici(string sorgu)
        {
            return DataReaderToObject(SQLDB.ExecuteReader(sorgu));
        }

        public static void Sil(int kodu)
       {
           string sorgu = "delete from Kullanici where kodu=@kod";
           SqlCommand cmd = new SqlCommand(sorgu);
           cmd.Parameters.AddWithValue("@kod", kodu);
           SQLDB.Execute(cmd);
       }
       public static void Guncelle(Kullanici k)
       {
           string sorgu = "update Kullanici set TC=@tc,AdSoyad=@ad,KullaniciAdi=@kadi,Sifre=@sifre,Yetki=@yetki,DogumYeri=@dyeri,DogumTarihi=@dtarihi,AnneAdi=@aadi,BabaAdi=@badi," +
             "Cinsiyet=@cinsiyet,MedeniHal=@medenihal,KanGrubu=@kan,Maas=@maas,Tel=@tel,Adres=@adres,Unvan=@unvan,IseBaslamaTarihi=@isebaslama where Kodu=@kod";
           SqlCommand cmd = new SqlCommand(sorgu);
           cmd.Parameters.AddWithValue("@tc", k.TC);
           cmd.Parameters.AddWithValue("@ad", k.AdSoyad);
           cmd.Parameters.AddWithValue("@kadi", k.KullaniciAdi);
           cmd.Parameters.AddWithValue("@sifre", k.Sifre);
           cmd.Parameters.AddWithValue("@yetki", k.Yetki);
           cmd.Parameters.AddWithValue("@dyeri", k.DogumYeri);
           cmd.Parameters.AddWithValue("@dtarihi", k.DogumTarihi);
           cmd.Parameters.AddWithValue("@aadi", k.AnneAdi);
           cmd.Parameters.AddWithValue("@badi", k.BabaAdi);
           cmd.Parameters.AddWithValue("@cinsiyet", k.Cinsiyet);
           cmd.Parameters.AddWithValue("@medenihal", k.MedeniHal);
           cmd.Parameters.AddWithValue("@kan", k.KanGrubu);
           cmd.Parameters.AddWithValue("@maas", k.Maas);
           cmd.Parameters.AddWithValue("@tel", k.Tel);
           cmd.Parameters.AddWithValue("@adres", k.Adres);
           cmd.Parameters.AddWithValue("@unvan", k.Unvan);
           cmd.Parameters.AddWithValue("@isebaslama", k.IseBaslamaTarihi);
           cmd.Parameters.AddWithValue("@kod", k.Kodu);
           SQLDB.Execute(cmd);
       }
       public static void Ekle(Kullanici k )
       {
          string sorgu= "insert into Kullanici (TC,AdSoyad,KullaniciAdi,Sifre,Yetki,DogumYeri,DogumTarihi,AnneAdi,BabaAdi,"+
             "Cinsiyet,MedeniHal,KanGrubu,Maas,Tel,Adres,Unvan,IseBaslamaTarihi) values" +
           "(@tc,@ad,@kadi,@sifre,@yetki,@dyeri,@dtarihi,@aadi,@badi,@cinsiyet,@medenihal,@kan,@maas,@tel,@adres,@unvan,@isebaslama)";

          SqlCommand cmd = new SqlCommand(sorgu);
          cmd.Parameters.AddWithValue("@tc", k.TC);
          cmd.Parameters.AddWithValue("@ad", k.AdSoyad);
          cmd.Parameters.AddWithValue("@kadi", k.KullaniciAdi);
          cmd.Parameters.AddWithValue("@sifre", k.Sifre);
          cmd.Parameters.AddWithValue("@yetki", k.Yetki);
          cmd.Parameters.AddWithValue("@dyeri", k.DogumYeri);
          cmd.Parameters.AddWithValue("@dtarihi", k.DogumTarihi);
          cmd.Parameters.AddWithValue("@aadi", k.AnneAdi);
          cmd.Parameters.AddWithValue("@badi", k.BabaAdi);
          cmd.Parameters.AddWithValue("@cinsiyet", k.Cinsiyet);
          cmd.Parameters.AddWithValue("@medenihal", k.MedeniHal);
          cmd.Parameters.AddWithValue("@kan", k.KanGrubu);
          cmd.Parameters.AddWithValue("@maas", k.Maas);
          cmd.Parameters.AddWithValue("@tel", k.Tel);
          cmd.Parameters.AddWithValue("@adres", k.Adres);
          cmd.Parameters.AddWithValue("@unvan", k.Unvan);
          cmd.Parameters.AddWithValue("@isebaslama", k.IseBaslamaTarihi);
          SQLDB.Execute(cmd);
       }
       public static List<string> GetAllTC()
       {
          SqlDataReader read= SQLDB.ExecuteReader("select TC from Kullanici");
          List<string> list = new List<string>(); 
           while(read.Read())
            {
                list.Add(read.GetString(0));
            }
           read.Close();
           return list;
       }
       public static List<string> GetAllDosyaNo()
       {
           SqlDataReader read = SQLDB.ExecuteReader("select Kodu from Kullanici");
           List<string> list = new List<string>();
           while (read.Read())
           {
               list.Add(read.GetInt32(0).ToString());
           }
           read.Close();
          
           return list;
       }
       public static bool Login(string ad,string sifre)
       {
           string sorgu = "select Count(Kodu) from Kullanici where KullaniciAdi='"+ad+"' and Sifre='"+sifre+"'";
          SqlDataReader read= SQLDB.ExecuteReader(sorgu);
          read.Read();
          if (read.GetInt32(0) == 1)
              return true;
          else
              return false;
       }
    
    }
}
