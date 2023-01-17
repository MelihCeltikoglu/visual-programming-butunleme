using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;
using Modelo;

namespace Vista
{
    public partial class YoneticiYonetimi : Form
    {
        private Yonetici yonetici;
        public YoneticiYonetimi()
        {
            InitializeComponent();
            YoneticiBL yoneticiBL = new YoneticiBL();
            yoneticiBL.veritabaniniBaslat();
        }

        private void TumunuYukle()
        {
            YoneticiBL yoneticiBL = new YoneticiBL();
            BindingList<Yonetici> yoneticiListeleri = new BindingList<Yonetici>();
            yoneticiListeleri = yoneticiBL.tumListeyiGetir();
            kullaniciGridListesi.DataSource = yoneticiListeleri;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String silinecekId = txtSil.Text;

            if (String.IsNullOrEmpty(silinecekId))
            {
                MessageBox.Show("Lütfen silinecek Yönetici ID'sini doğru yazınız.");
                return;
            }
            YoneticiBL yoneticiBL = new YoneticiBL();
            yoneticiBL.yoneticiSilme(Convert.ToInt32(silinecekId));
            TumunuYukle();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            YoneticiBL yoneticiBL = new YoneticiBL();
            yoneticiBL.veritabaniniBaslat();
            TumunuYukle();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            String ad = txtNombre.Text;
            String kullaniciAdi = textBox1.Text;
            String sifre = textBox2.Text;

            if (String.IsNullOrEmpty(ad) ||  String.IsNullOrEmpty(kullaniciAdi) || String.IsNullOrEmpty(sifre))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.");
                return;
            }
            YoneticiBL yoneticiBL = new YoneticiBL();
            yoneticiBL.yoneticiEkle(kullaniciAdi, sifre, ad);
            TumunuYukle();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String ad = txtNombre.Text;
            String kullaniciAdi = textBox1.Text;
            String sifre = textBox2.Text;
            String guncellenecekId = txtGuncelle.Text;

            if (String.IsNullOrEmpty(ad)  || String.IsNullOrEmpty(kullaniciAdi) || String.IsNullOrEmpty(sifre))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.");
                return;
            }
            YoneticiBL yoneticiBL = new YoneticiBL();
            yoneticiBL.yoneticiGuncelle(kullaniciAdi, sifre, ad, Convert.ToInt32(guncellenecekId));
            TumunuYukle();
        }

        private void YoneticiYonetimi_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
            YoneticiPaneli yoneticiPaneli = new YoneticiPaneli();
            yoneticiPaneli.Show();
        }
    }
}
