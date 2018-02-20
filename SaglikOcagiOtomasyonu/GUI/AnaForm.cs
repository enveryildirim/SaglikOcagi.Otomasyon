using SaglikOcagiOtomasyonu.Core.BLL;
using SaglikOcagiOtomasyonu.Core.Model;
using SaglikOcagiOtomasyonu.GUI;
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
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();

            AramaKriterleriYukle();
        }

        void AramaKriterleriYukle()
        {
            if (comboBox1.SelectedIndex == 0)
            {
                txt_sorgu.AutoCompleteCustomSource.AddRange(HastaProvider.GetAllDosyaNo().ToArray());

            }
            else
            {
                txt_sorgu.AutoCompleteCustomSource.AddRange(HastaProvider.GetAllTC().ToArray());
            }
            txt_sorgu.Text = "";
            txt_sorgu.Focus();
            comboBox1.SelectedIndex = 0;
            txt_sorgu.Focus();
            Dictionary<string,string> liste= SevkProvider.GetAllIslemler();
            foreach (var item in liste)
            {
                comboBox_Islem.Items.Add(item.Key);
            }
            comboBox_Islem.SelectedIndex = 0;

            comboBox_Doktor.DataSource = SevkProvider.GetAllDoktorNo();
            comboBox_Poliklink.DataSource = SevkProvider.GetAllPoliklink();
          
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           if(comboBox1.SelectedIndex==0)
           {
               txt_sorgu.AutoCompleteCustomSource.AddRange(HastaProvider.GetAllDosyaNo().ToArray());
              
           }
           else 
           {
               txt_sorgu.AutoCompleteCustomSource.AddRange(HastaProvider.GetAllTC().ToArray());
           }
           txt_sorgu.Text = "";
           txt_sorgu.Focus();
        }

        private void kullanıcıEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KullaniciIslemleri k = new KullaniciIslemleri();
            k.ShowDialog();
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PoliklinikIslemleri p = new PoliklinikIslemleri();
            p.ShowDialog();
        }

        private void ekleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            HastaIslemleri h = new HastaIslemleri();
            h.Anaform = this;
            h.ShowDialog();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void oturumuKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }
        static Hasta h = null;
        private void button1_Click(object sender, EventArgs e)
        {
            if(txt_sorgu.Text=="") return;
            if(txt_sorgu.AutoCompleteCustomSource.Contains(txt_sorgu.Text))
            {
                string sorgu="select * from Hasta where ";
                if (comboBox1.SelectedIndex == 0)
                    sorgu += "DosyaNo=" + txt_sorgu.Text;
                else
                    sorgu += "TC='"+txt_sorgu.Text+"'";
                try
                {
                    h = HastaProvider.Get(sorgu);
                    lbl_hasta_bilgileri.Text = string.Format("TC:{0} ,DosyaNo:{1},AdSoyad:{2} ", h.TC, h.DosyaNo, h.AdSoyad);
                    List<Sevk> liste = SevkProvider.GetAllSevkler(h.DosyaNo);
                    dataGridView1.DataSource = liste;
                    int toplam = liste.Sum(p => p.Miktar * p.BirimFiyat);
                    lbl_toplamtutar.Text += ": " + toplam.ToString();
                    button6.Enabled = true;
                    button7.Enabled = true;
                    button8.Enabled = true;
                }
                catch (Exception)
                {
                   
                }
              
            }
            else
            {
                MessageBox.Show("Bulanamadı!!!");
            }
        }

        private void comboBox_Islem_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dictionary<string, string> liste = SevkProvider.GetAllIslemler();
            if (liste.ContainsKey(comboBox_Islem.SelectedItem.ToString()))
                txt_fiyat.Text = liste[comboBox_Islem.SelectedItem.ToString()];
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Sevk s = new Sevk() 
            {
                DosyaNo=h.DosyaNo,
                Poliklinik=comboBox_Poliklink.SelectedItem.ToString(),
                Sira=Convert.ToInt32(txt_sirano.Text),
                Islem=comboBox_Islem.SelectedItem.ToString(),
                DoktorKod=Convert.ToInt32(comboBox_Doktor.SelectedItem.ToString()),
                Miktar=Convert.ToInt32(numericUpDown_Miktar.Value),
                BirimFiyat=Convert.ToInt32(txt_fiyat.Text),
                Saat=DateTime.Now.Hour.ToString(),
                SevkTarihi=DateTime.Now,
                Taburcu=false,
            };
            SevkProvider.Ekle(s);
            MessageBox.Show("Eklendi");
            h = HastaProvider.Get("select * from Hasta where DosyaNo="+h.DosyaNo.ToString());
            lbl_hasta_bilgileri.Text = string.Format("TC:{0} ,DosyaNo:{1},AdSoyad:{2} ", h.TC, h.DosyaNo, h.AdSoyad);
            List<Sevk> liste = SevkProvider.GetAllSevkler(h.DosyaNo);
            int toplam= liste.Sum(p => p.Miktar * p.BirimFiyat);
            lbl_toplamtutar.Text += ": " + toplam.ToString();
            dataGridView1.DataSource = liste;

        }

        private void comboBox_Poliklink_SelectedIndexChanged(object sender, EventArgs e)
        {
           txt_sirano.Text = SevkProvider.SiraNo(comboBox_Poliklink.SelectedItem.ToString()).ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            HastaIslemleri ha = new HastaIslemleri();
            ha.Hasta = h;
            ha.ShowDialog();
            AramaKriterleriYukle();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Hasta Silinsin mi", "Hasta Silme", MessageBoxButtons.YesNoCancel);
            if(r==DialogResult.Yes)
            {
                HastaProvider.Sil(h.DosyaNo);
                MessageBox.Show("Silindi!");
                AramaKriterleriYukle();
                txt_sorgu.Text = "";
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                lbl_hasta_bilgileri.Text = "";
                dataGridView1.DataSource = null;
                lbl_toplamtutar.Text = "Toplam Tutar";

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SevkProvider.TaburcuEt(h);
            MessageBox.Show("Taburcu Edildi !!!!");
            List<Sevk> liste = SevkProvider.GetAllSevkler(h.DosyaNo);
            int toplam = liste.Sum(p => p.Miktar * p.BirimFiyat);
            lbl_toplamtutar.Text += ": " + toplam.ToString();
            dataGridView1.DataSource = liste;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }
        int i = 0;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmap = new Bitmap(dataGridView1.Width, dataGridView1.Height);
            dataGridView1.DrawToBitmap(bmap, new Rectangle(0, 0,
                            dataGridView1.Width, dataGridView1.Height));
            e.Graphics.DrawImage(bmap, 0, 0);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Assign printPreviewDialog properties
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
           
        }
    }
}
