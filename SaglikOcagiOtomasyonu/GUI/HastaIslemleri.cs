using SaglikOcagiOtomasyonu.Core.BLL;
using SaglikOcagiOtomasyonu.Core.Model;
using SaglikOcagiOtomasyonu.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaglikOcagiOtomasyonu.GUI
{
    public partial class HastaIslemleri : Form
    {
        public HastaIslemleri()
        {
            InitializeComponent();
            comboBox_cinsiyet.SelectedIndex = comboBox_medenihal.SelectedIndex = 0;
            
        }
        public Hasta Hasta { get; set; }
        public AnaForm Anaform { get; set; }
        private void HastaIslemleri_Load(object sender, EventArgs e)
        {
            if (Hasta != null)
            {
                     txt_tc.Text=Hasta.TC;
                     txt_adsoyad.Text=Hasta.AdSoyad;
                     txt_dogumyeri.Text=Hasta.DogumYeri;
                     dateTimePicker_dogumtarihi.Value=Hasta.DogumTarihi;
                     txt_anneadi.Text=Hasta.AnneAdi;
                     txt_babaadi.Text=Hasta.BabaAdi;
                     comboBox_cinsiyet.SelectedItem=Hasta.Cinsiyet;
                     comboBox_medenihal.SelectedItem=Hasta.MedeniHal;
                     txt_tel.Text=Hasta.Tel;
                     txt_kurumadi.Text=Hasta.KurumAdi;
                     txt_kurumsicilno.Text=Hasta.KurumSicilNo;
                     txt_ytel.Text=Hasta.YakiniTelNo;
                     txt_ykurumsicilno.Text=Hasta.YakiniKurumSicilNo;
                     txt_ykurumadi.Text=Hasta.YakiniKurumAdi;
                     txt_Adres.Text = Hasta.Adres;
                     txt_dosyano.Text = Hasta.DosyaNo.ToString();
            }
            else 
            { 
                string a;
                try
                {
                    a= HastaProvider.GetLastDosyaNo().ToString();
                }
                catch (Exception)
                {
                  a="1";  
                }
               txt_dosyano.Text=a;
            }
        }
        bool Kontrol()
        {
            //gerekli kontroller burada yapılır
            int durum=1;
            foreach (var item in Controls)
            {
                if(item is TextBox)

                    if (((TextBox)item).Text == "")
                    {
                        durum *= 0;
                        MessageBox.Show("Boş alan Bırakmayınız");
                        break;
                    }
                
            }

            if (dateTimePicker_dogumtarihi.Value > DateTime.Now)
            {
                durum *= 0;
                MessageBox.Show("Tarihi düzün giriniz");
            }

       
            return Convert.ToBoolean(durum);
        }
        void Temizle()
        {
                    txt_tc.Text="";
                    txt_adsoyad.Text="";
                    txt_dogumyeri.Text="";
                    dateTimePicker_dogumtarihi.Value=DateTime.Now;
                    txt_anneadi.Text="";
                    txt_babaadi.Text="";
                    txt_tel.Text="";
                    txt_kurumadi.Text="";
                    txt_kurumsicilno.Text="";
                    txt_ytel.Text="";
                    txt_ykurumsicilno.Text="";
                    txt_ykurumadi.Text="";
                    txt_Adres.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            if(Kontrol())
            {
                Hasta h = new Hasta()
                {
                    TC = txt_tc.Text,
                    AdSoyad = txt_adsoyad.Text,
                    DogumYeri = txt_dogumyeri.Text,
                    DogumTarihi = dateTimePicker_dogumtarihi.Value,
                    AnneAdi = txt_anneadi.Text,
                    BabaAdi = txt_babaadi.Text,
                    Cinsiyet = comboBox_cinsiyet.SelectedItem.ToString(),
                    MedeniHal = comboBox_medenihal.SelectedItem.ToString(),
                    Tel = txt_tel.Text,
                    KurumAdi=txt_kurumadi.Text,
                    KurumSicilNo=txt_kurumsicilno.Text,
                    YakiniTelNo=txt_ytel.Text,
                    YakiniKurumSicilNo=txt_ykurumsicilno.Text,
                    YakiniKurumAdi=txt_ykurumadi.Text,
                    Adres = txt_Adres.Text,
                    
                };
                if (Hasta == null)
                {
                    HastaProvider.Ekle(h);
                    MessageBox.Show("Eklendi");
                }

                else
                {
                    HastaProvider.Guncelle(h);
                    MessageBox.Show("Guncellendi");
                    this.Hide();
                } 
                Temizle();
               // this.Hide();
            }
        }
    }
}
