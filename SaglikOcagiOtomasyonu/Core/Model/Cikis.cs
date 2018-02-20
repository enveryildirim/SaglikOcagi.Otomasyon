using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaglikOcagiOtomasyonu.Core.Model
{
    public class Cikis
    {
        public int DosyaNo { get; set; }
        public DateTime SevkTarihi { get; set; }
        public DateTime CikisTarihi { get; set; }
        public string Odeme { get; set; }
        public string ToplamTutar { get; set; }
    }
}
