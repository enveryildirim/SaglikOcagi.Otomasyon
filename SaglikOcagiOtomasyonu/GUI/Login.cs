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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_KullaniciAdi.Text!=""||txt_Sifre.Text!="")
            {
                if (KullaniciProvider.Login(txt_KullaniciAdi.Text,txt_Sifre.Text))
                {
                    AnaForm a = new AnaForm();
                    a.Show();
                    this.Hide();
                }

            }
            else 
            {
                MessageBox.Show("Lütfen alanları boş borakmayınız");
                txt_Sifre.Text = "";
            }
        }
    }
}
