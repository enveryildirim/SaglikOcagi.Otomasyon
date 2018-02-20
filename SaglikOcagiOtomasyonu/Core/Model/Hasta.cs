using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaglikOcagiOtomasyonu.Core.Model
{
    public class Hasta
    {
        public int DosyaNo { get; set; }
        public string TC { get; set; }
        public string AdSoyad { get; set; }
        public string DogumYeri { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string AnneAdi { get; set; }
        public string BabaAdi { get; set; }
        public string Cinsiyet { get; set; }
        public string MedeniHal { get; set; }
        public string Tel { get; set; }
        public string KurumSicilNo { get; set; }
        public string KurumAdi { get; set; }
        public string YakiniTelNo { get; set; }
        public string YakiniKurumSicilNo { get; set; }
        public string YakiniKurumAdi { get; set; }
        public string Adres { get; set; }
    }
}
