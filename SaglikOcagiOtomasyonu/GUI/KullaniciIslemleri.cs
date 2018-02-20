using SaglikOcagiOtomasyonu.Core;
using SaglikOcagiOtomasyonu.Core.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaglikOcagiOtomasyonu
{
    public partial class KullaniciIslemleri : Form
    {
        public KullaniciIslemleri()
        {
            InitializeComponent();
            txt_Sorgu.AutoCompleteCustomSource.AddRange(KullaniciProvider.GetAllTC().ToArray());
            comboBox_cinsiyet.SelectedIndex = comboBox_kangrubu.SelectedIndex = comboBox_Kriter.SelectedIndex = comboBox_medenihal.SelectedIndex = comboBox_Unvan.SelectedIndex = 0;
        }
        void AramaKriterleriYukle()
        {
            comboBox_Kriter.Items.Add("Kodu");
            comboBox_Kriter.Items.Add("TC No");
            comboBox_Kriter.Items.Add("Ad Soyad");
            comboBox_Kriter.SelectedIndex = 0;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(KontrolEt())
            {
                Kullanici k = new Kullanici()
                {
                    TC = txt_TC.Text,
                    AdSoyad = txt_adsoyad.Text,
                    KullaniciAdi = txt_kullaniciadi.Text,
                    Sifre = txt_sifre.Text,
                    Yetki = checkBox_yetki.Checked,
                    DogumYeri = txt_dogumyeri.Text,
                    DogumTarihi = dateTimePicker_dogumtarihi.Value,
                    AnneAdi = txt_anneadi.Text,
                    BabaAdi = txt_baba.Text,
                    Cinsiyet = comboBox_cinsiyet.SelectedItem.ToString(),
                    MedeniHal = comboBox_medenihal.SelectedItem.ToString(),
                    KanGrubu = comboBox_kangrubu.SelectedItem.ToString(),
                    Maas = Convert.ToDouble(txt_maas.Text),
                    Tel = txt_telno.Text,
                    Adres = txt_adres.Text,
                    Unvan = comboBox_Unvan.SelectedItem.ToString(),
                    IseBaslamaTarihi=dateTimePicker_isebaslama.Value
                };
                KullaniciProvider.Ekle(k);
                button3.Enabled = false;
                MessageBox.Show("Eklendi!");
                SorguDoldur();
            }
        }

        bool KontrolEt()
        {
            int durum = 1;
            //textbox lar bos 
            GroupBox grup = (GroupBox)Controls.Find("groupBox3", true)[0];
            foreach (var item in grup.Controls)
            {
               if(item is TextBox)
               {
                   if (((TextBox)item).Text == "")
                   {
                       MessageBox.Show("Boş alan bırakmayınız");
                       durum = durum*0;
                       return Convert.ToBoolean(durum);
                   }
               }
            }

           //tarihlerin kontrolü
            if (dateTimePicker_dogumtarihi.Value > DateTime.Now || dateTimePicker_isebaslama.Value > DateTime.Now)
            {
                MessageBox.Show("Tarihleri düzgüngiriniz");
                durum = durum * 0;
            }
            try
            {
                double maas = Convert.ToDouble(txt_maas.Text);
            }
            catch (Exception)
            {

                durum = durum * 0;
                MessageBox.Show("Duzgun Maas giriniz");
            }

            return Convert.ToBoolean(durum);

        }
        void Temizle()
        {
            txt_adres.Text = "";
            txt_adsoyad.Text = "";
            txt_anneadi.Text = "";
            txt_baba.Text = "";
            txt_dogumyeri.Text = "";
            txt_kullaniciadi.Text = "";
            txt_maas.Text = "";
            txt_sifre.Text = "";
            txt_Sorgu.Text = "";
            txt_TC.Text = "";
            txt_telno.Text = "";
            comboBox_cinsiyet.SelectedIndex = comboBox_kangrubu.SelectedIndex = comboBox_Kriter.SelectedIndex = comboBox_medenihal.SelectedIndex = 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Temizle();
            button3.Enabled = true;
        }

        private void comboBox_Kriter_SelectedIndexChanged(object sender, EventArgs e)
        {
            SorguDoldur();
        }

        void SorguDoldur()
        {
            txt_Sorgu.AutoCompleteCustomSource.Clear();
            if (comboBox_Kriter.SelectedIndex == 0)
            {
                txt_Sorgu.AutoCompleteCustomSource.AddRange(KullaniciProvider.GetAllTC().ToArray());
            }
            else
            {
                txt_Sorgu.AutoCompleteCustomSource.AddRange(KullaniciProvider.GetAllDosyaNo().ToArray());
            }
            txt_Sorgu.Text = "";
            txt_Sorgu.Focus();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Kullanici k=null;
            try
            {
                if (comboBox_Kriter.SelectedIndex == 0)
                    k = KullaniciProvider.GetKullanici("select * from Kullanici where Tc=" + txt_Sorgu.Text);
                else
                    k = KullaniciProvider.GetKullanici("select * from Kullanici where Kodu=" + txt_Sorgu.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Bulunamadı !!!!!!");
                return;
            }
            txt_Sorgu.Focus();
            lbl_kod.Text =k.Kodu.ToString();
            txt_adres.Text = k.Adres;
            txt_adsoyad.Text = k.AdSoyad;
            txt_anneadi.Text = k.AnneAdi;
            txt_baba.Text = k.BabaAdi;
            txt_dogumyeri.Text = k.DogumYeri;
            dateTimePicker_dogumtarihi.Value = k.DogumTarihi;
            txt_kullaniciadi.Text = k.KullaniciAdi;
            txt_maas.Text = k.Maas.ToString();
            txt_sifre.Text = k.Sifre;
            txt_TC.Text = k.TC;
            txt_telno.Text = k.Tel;
            comboBox_Unvan.SelectedItem = k.Unvan;
            checkBox_yetki.Checked = k.Yetki;
            comboBox_medenihal.SelectedItem = k.MedeniHal;
            comboBox_kangrubu.SelectedItem = k.KanGrubu;
            comboBox_cinsiyet.SelectedItem = k.Cinsiyet;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Kullanici k = new Kullanici()
            {
                TC = txt_TC.Text,
                AdSoyad = txt_adsoyad.Text,
                KullaniciAdi = txt_kullaniciadi.Text,
                Sifre = txt_sifre.Text,
                Yetki = checkBox_yetki.Checked,
                DogumYeri = txt_dogumyeri.Text,
                DogumTarihi = dateTimePicker_dogumtarihi.Value,
                AnneAdi = txt_anneadi.Text,
                BabaAdi = txt_baba.Text,
                Cinsiyet = comboBox_cinsiyet.SelectedItem.ToString(),
                MedeniHal = comboBox_medenihal.SelectedItem.ToString(),
                KanGrubu = comboBox_kangrubu.SelectedItem.ToString(),
                Maas = Convert.ToDouble(txt_maas.Text),
                Tel = txt_telno.Text,
                Adres = txt_adres.Text,
                Unvan = comboBox_Unvan.SelectedItem.ToString(),
                IseBaslamaTarihi = dateTimePicker_isebaslama.Value,
                Kodu=Convert.ToInt32( lbl_kod.Text)
            };

            KullaniciProvider.Guncelle(k);
            MessageBox.Show("Guncellendi !!!!!");
            SorguDoldur();
        }

        private void button5_Click(object sender, EventArgs e)
        {
          DialogResult result=  MessageBox.Show("Hastayı Silmek istiyormusunuz ?", "Hasta Silme", MessageBoxButtons.YesNoCancel);
            if(result==DialogResult.Yes)
            {
                KullaniciProvider.Sil(Convert.ToInt32(lbl_kod.Text));
                MessageBox.Show("Hasta Silindi !!!!");
                Temizle();
                SorguDoldur();
            }
        }

    }
}
