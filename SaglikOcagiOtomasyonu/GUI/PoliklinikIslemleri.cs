using SaglikOcagiOtomasyonu.Core.BLL;
using SaglikOcagiOtomasyonu.Core.Model;
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
    public partial class PoliklinikIslemleri : Form
    {
        public PoliklinikIslemleri()
        {
            InitializeComponent();
        }
        void yukle()
        {
           comboBox1.DataSource= PoliklinikProvider.GetAll();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(txt_Adi.Text==""||txt_Aciklama.Text=="")
            {
                MessageBox.Show("Boş alan bırakmayınız");
                return;
            }
            List<string> liste = PoliklinikProvider.GetAll();
            Poliklinik p=new Poliklinik()
            {Adi=txt_Adi.Text,Aciklama=txt_Aciklama.Text,Durum=checkBox_durum.Checked};
            if (liste.Contains(txt_Adi.Text))
            {
                PoliklinikProvider.Guncelle(p);
                MessageBox.Show("Guncellendi!!!");

            }
            else
            {
                PoliklinikProvider.Ekle(p);
                MessageBox.Show("Eklendi!!");
            }
            yukle();
        }

        private void PoliklinikIslemleri_Load(object sender, EventArgs e)
        {
            yukle();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Poliklinik p = PoliklinikProvider.Get("select * from Poliklinik where Adi='" + comboBox1.SelectedItem.ToString()+"'");
            txt_Aciklama.Text = p.Aciklama;
            txt_Adi.Text = p.Adi;
            checkBox_durum.Checked = p.Durum;

        }

        private void button2_Click(object sender, EventArgs e)
        {
          DialogResult r=   MessageBox.Show("Poliklinik silinecek ?", " Silme", MessageBoxButtons.YesNoCancel);
            if(r==DialogResult.Yes)
            {
                PoliklinikProvider.Sil(comboBox1.SelectedItem.ToString());
                MessageBox.Show("Silindi !!");
            }
        }
    }
}
