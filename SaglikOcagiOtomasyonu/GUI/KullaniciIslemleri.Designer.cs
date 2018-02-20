namespace SaglikOcagiOtomasyonu
{
    partial class KullaniciIslemleri
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox_Unvan = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_Sorgu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_Kriter = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.checkBox_yetki = new System.Windows.Forms.CheckBox();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.txt_kullaniciadi = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_adres = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBox_medenihal = new System.Windows.Forms.ComboBox();
            this.comboBox_kangrubu = new System.Windows.Forms.ComboBox();
            this.comboBox_cinsiyet = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker_isebaslama = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_dogumtarihi = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_TC = new System.Windows.Forms.TextBox();
            this.txt_maas = new System.Windows.Forms.TextBox();
            this.txt_telno = new System.Windows.Forms.TextBox();
            this.txt_baba = new System.Windows.Forms.TextBox();
            this.txt_anneadi = new System.Windows.Forms.TextBox();
            this.txt_dogumyeri = new System.Windows.Forms.TextBox();
            this.txt_adsoyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_kod = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox_Unvan
            // 
            this.comboBox_Unvan.FormattingEnabled = true;
            this.comboBox_Unvan.Items.AddRange(new object[] {
            "Doktor",
            "Personel",
            "Hemşire"});
            this.comboBox_Unvan.Location = new System.Drawing.Point(0, 19);
            this.comboBox_Unvan.Name = "comboBox_Unvan";
            this.comboBox_Unvan.Size = new System.Drawing.Size(122, 21);
            this.comboBox_Unvan.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(125, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Yeni Kayıt From Aç";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_Unvan);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(2, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 48);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Ekleme";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.txt_Sorgu);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.comboBox_Kriter);
            this.groupBox2.Location = new System.Drawing.Point(2, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(710, 48);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Arama";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(413, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Getir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_Sorgu
            // 
            this.txt_Sorgu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_Sorgu.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_Sorgu.Location = new System.Drawing.Point(211, 21);
            this.txt_Sorgu.Name = "txt_Sorgu";
            this.txt_Sorgu.Size = new System.Drawing.Size(195, 20);
            this.txt_Sorgu.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kriter";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sorgu";
            // 
            // comboBox_Kriter
            // 
            this.comboBox_Kriter.FormattingEnabled = true;
            this.comboBox_Kriter.Items.AddRange(new object[] {
            "TC",
            "KODU"});
            this.comboBox_Kriter.Location = new System.Drawing.Point(42, 21);
            this.comboBox_Kriter.Name = "comboBox_Kriter";
            this.comboBox_Kriter.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Kriter.TabIndex = 0;
            this.comboBox_Kriter.SelectedIndexChanged += new System.EventHandler(this.comboBox_Kriter_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbl_kod);
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.checkBox_yetki);
            this.groupBox3.Controls.Add(this.txt_sifre);
            this.groupBox3.Controls.Add(this.txt_kullaniciadi);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.txt_adres);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.comboBox_medenihal);
            this.groupBox3.Controls.Add(this.comboBox_kangrubu);
            this.groupBox3.Controls.Add(this.comboBox_cinsiyet);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.dateTimePicker_isebaslama);
            this.groupBox3.Controls.Add(this.dateTimePicker_dogumtarihi);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txt_TC);
            this.groupBox3.Controls.Add(this.txt_maas);
            this.groupBox3.Controls.Add(this.txt_telno);
            this.groupBox3.Controls.Add(this.txt_baba);
            this.groupBox3.Controls.Add(this.txt_anneadi);
            this.groupBox3.Controls.Add(this.txt_dogumyeri);
            this.groupBox3.Controls.Add(this.txt_adsoyad);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(2, 102);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(710, 472);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bilgiler";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(244, 433);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 12;
            this.button5.Text = "Sil";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(128, 433);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(109, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "Guncelle";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(13, 433);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Kaydet";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // checkBox_yetki
            // 
            this.checkBox_yetki.AutoSize = true;
            this.checkBox_yetki.Location = new System.Drawing.Point(11, 395);
            this.checkBox_yetki.Name = "checkBox_yetki";
            this.checkBox_yetki.Size = new System.Drawing.Size(77, 17);
            this.checkBox_yetki.TabIndex = 10;
            this.checkBox_yetki.Text = "Yetkili Mi ?";
            this.checkBox_yetki.UseVisualStyleBackColor = true;
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(348, 369);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(215, 20);
            this.txt_sifre.TabIndex = 9;
            // 
            // txt_kullaniciadi
            // 
            this.txt_kullaniciadi.Location = new System.Drawing.Point(78, 369);
            this.txt_kullaniciadi.Name = "txt_kullaniciadi";
            this.txt_kullaniciadi.Size = new System.Drawing.Size(215, 20);
            this.txt_kullaniciadi.TabIndex = 8;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(314, 372);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(28, 13);
            this.label17.TabIndex = 8;
            this.label17.Text = "Şifre";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(8, 372);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 13);
            this.label16.TabIndex = 8;
            this.label16.Text = "Kullanıcı Adı";
            // 
            // txt_adres
            // 
            this.txt_adres.Location = new System.Drawing.Point(8, 226);
            this.txt_adres.Multiline = true;
            this.txt_adres.Name = "txt_adres";
            this.txt_adres.Size = new System.Drawing.Size(605, 117);
            this.txt_adres.TabIndex = 7;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(5, 209);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 13);
            this.label15.TabIndex = 6;
            this.label15.Text = "Adres";
            // 
            // comboBox_medenihal
            // 
            this.comboBox_medenihal.FormattingEnabled = true;
            this.comboBox_medenihal.Items.AddRange(new object[] {
            "Evli",
            "Bekar"});
            this.comboBox_medenihal.Location = new System.Drawing.Point(531, 78);
            this.comboBox_medenihal.Name = "comboBox_medenihal";
            this.comboBox_medenihal.Size = new System.Drawing.Size(82, 21);
            this.comboBox_medenihal.TabIndex = 5;
            // 
            // comboBox_kangrubu
            // 
            this.comboBox_kangrubu.FormattingEnabled = true;
            this.comboBox_kangrubu.Items.AddRange(new object[] {
            "ARH+",
            "ARH-",
            "BRH+",
            "BRH-",
            "ABRH+",
            "ABRH-",
            "0RH+",
            "0Rh-"});
            this.comboBox_kangrubu.Location = new System.Drawing.Point(384, 107);
            this.comboBox_kangrubu.Name = "comboBox_kangrubu";
            this.comboBox_kangrubu.Size = new System.Drawing.Size(86, 21);
            this.comboBox_kangrubu.TabIndex = 5;
            // 
            // comboBox_cinsiyet
            // 
            this.comboBox_cinsiyet.FormattingEnabled = true;
            this.comboBox_cinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.comboBox_cinsiyet.Location = new System.Drawing.Point(369, 80);
            this.comboBox_cinsiyet.Name = "comboBox_cinsiyet";
            this.comboBox_cinsiyet.Size = new System.Drawing.Size(82, 21);
            this.comboBox_cinsiyet.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(466, 83);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Medeni Hal";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(320, 110);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "Kan Grubu";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(320, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Cinsiyet";
            // 
            // dateTimePicker_isebaslama
            // 
            this.dateTimePicker_isebaslama.Location = new System.Drawing.Point(413, 52);
            this.dateTimePicker_isebaslama.Name = "dateTimePicker_isebaslama";
            this.dateTimePicker_isebaslama.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_isebaslama.TabIndex = 3;
            // 
            // dateTimePicker_dogumtarihi
            // 
            this.dateTimePicker_dogumtarihi.Location = new System.Drawing.Point(413, 23);
            this.dateTimePicker_dogumtarihi.Name = "dateTimePicker_dogumtarihi";
            this.dateTimePicker_dogumtarihi.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_dogumtarihi.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(320, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "İşe Başlama Tarihi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(320, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Doğum Tarihi";
            // 
            // txt_TC
            // 
            this.txt_TC.Location = new System.Drawing.Point(64, 23);
            this.txt_TC.Name = "txt_TC";
            this.txt_TC.Size = new System.Drawing.Size(219, 20);
            this.txt_TC.TabIndex = 0;
            // 
            // txt_maas
            // 
            this.txt_maas.Location = new System.Drawing.Point(374, 137);
            this.txt_maas.Name = "txt_maas";
            this.txt_maas.Size = new System.Drawing.Size(143, 20);
            this.txt_maas.TabIndex = 6;
            // 
            // txt_telno
            // 
            this.txt_telno.Location = new System.Drawing.Point(66, 173);
            this.txt_telno.Name = "txt_telno";
            this.txt_telno.Size = new System.Drawing.Size(219, 20);
            this.txt_telno.TabIndex = 5;
            // 
            // txt_baba
            // 
            this.txt_baba.Location = new System.Drawing.Point(66, 137);
            this.txt_baba.Name = "txt_baba";
            this.txt_baba.Size = new System.Drawing.Size(219, 20);
            this.txt_baba.TabIndex = 4;
            // 
            // txt_anneadi
            // 
            this.txt_anneadi.Location = new System.Drawing.Point(66, 103);
            this.txt_anneadi.Name = "txt_anneadi";
            this.txt_anneadi.Size = new System.Drawing.Size(219, 20);
            this.txt_anneadi.TabIndex = 3;
            // 
            // txt_dogumyeri
            // 
            this.txt_dogumyeri.Location = new System.Drawing.Point(64, 76);
            this.txt_dogumyeri.Name = "txt_dogumyeri";
            this.txt_dogumyeri.Size = new System.Drawing.Size(219, 20);
            this.txt_dogumyeri.TabIndex = 2;
            // 
            // txt_adsoyad
            // 
            this.txt_adsoyad.Location = new System.Drawing.Point(64, 51);
            this.txt_adsoyad.Name = "txt_adsoyad";
            this.txt_adsoyad.Size = new System.Drawing.Size(219, 20);
            this.txt_adsoyad.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "TC";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(320, 140);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(33, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Maaş";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(2, 180);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Tel No";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(2, 144);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Baba Adı";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Anne Adı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Dogum Yeri";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ad Soyad";
            // 
            // lbl_kod
            // 
            this.lbl_kod.AutoSize = true;
            this.lbl_kod.Location = new System.Drawing.Point(323, 173);
            this.lbl_kod.Name = "lbl_kod";
            this.lbl_kod.Size = new System.Drawing.Size(0, 13);
            this.lbl_kod.TabIndex = 13;
            // 
            // KullaniciIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 632);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "KullaniciIslemleri";
            this.Text = "KullaniciIslemleri";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Unvan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_Sorgu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_Kriter;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_adsoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_TC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_telno;
        private System.Windows.Forms.TextBox txt_baba;
        private System.Windows.Forms.TextBox txt_anneadi;
        private System.Windows.Forms.TextBox txt_dogumyeri;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_medenihal;
        private System.Windows.Forms.ComboBox comboBox_kangrubu;
        private System.Windows.Forms.ComboBox comboBox_cinsiyet;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker_isebaslama;
        private System.Windows.Forms.DateTimePicker dateTimePicker_dogumtarihi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_maas;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox checkBox_yetki;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.TextBox txt_kullaniciadi;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_adres;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lbl_kod;
    }
}