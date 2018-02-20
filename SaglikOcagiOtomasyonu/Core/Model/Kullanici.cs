using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaglikOcagiOtomasyonu.Core
{
   public class Kullanici
    {
        public int Kodu { get; set; }
        public string TC { get; set; }
        public string AdSoyad { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public bool Yetki { get; set; }
        public string DogumYeri { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string AnneAdi { get; set; }
        public string BabaAdi { get; set; }
        public string Cinsiyet { get; set; }
        public string MedeniHal { get; set; }
        public string KanGrubu { get; set; }
        public double Maas { get; set; }
        public string Tel { get; set; }
        public string Unvan { get; set; }
        public DateTime IseBaslamaTarihi { get; set; }
        public string Adres { get; set; }
    }
}
