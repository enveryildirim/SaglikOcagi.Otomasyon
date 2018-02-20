using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaglikOcagiOtomasyonu.Core.Model
{
    public class Sevk
    {
        public int No { get; set; }
        public DateTime SevkTarihi { get; set; }
        public int DosyaNo { get; set; }
        public string Poliklinik { get; set; }
        public string Saat { get; set; }
        public string Islem { get; set; }
        public int DoktorKod { get; set; }
        public int Miktar { get; set; }
        public int BirimFiyat { get; set; }
        public int Sira { get; set; }
        public bool Taburcu { get; set; }
    }
}
