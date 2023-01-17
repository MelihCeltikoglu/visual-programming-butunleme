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
    public partial class KullaniciYonetimi : Form
    {
        private Kullanici kullanici;
        public KullaniciYonetimi()
        {
            InitializeComponent();
            KullaniciBL kullaniciBL = new KullaniciBL();
            kullaniciBL.veritabaniniBaslat();
        }

        private void TumunuYukle()
        {
            KullaniciBL kullaniciBL = new KullaniciBL();
            BindingList<Kullanici> basketbolHaberleri = new BindingList<Kullanici>();
            basketbolHaberleri = kullaniciBL.tumListeyiGetir();
            kullaniciGridListesi.DataSource = basketbolHaberleri;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String silinecekId = txtSil.Text;

            if (String.IsNullOrEmpty(silinecekId))
            {
                MessageBox.Show("Lütfen silinecek Kullanıcı Adını doğru yazınız.");
                return;
            }
            KullaniciBL kullaniciBL = new KullaniciBL();
            kullaniciBL.kullaniciSilme(silinecekId);
            TumunuYukle();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            KullaniciBL kullaniciBL = new KullaniciBL();
            kullaniciBL.veritabaniniBaslat();
            TumunuYukle();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            String ad = txtNombre.Text;
            String soyad = txtEdad.Text;
            String email = txtCraest.Text;
            String kullaniciAdi = textBox1.Text;
            String sifre = textBox2.Text;

            if (String.IsNullOrEmpty(ad) || String.IsNullOrEmpty(soyad) || String.IsNullOrEmpty(email) || String.IsNullOrEmpty(kullaniciAdi) || String.IsNullOrEmpty(sifre))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.");
                return;
            }
            KullaniciBL kullaniciBL = new KullaniciBL();
            kullaniciBL.kullaniciEkle(ad, soyad, email, kullaniciAdi,sifre);
            TumunuYukle();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String ad = txtNombre.Text;
            String soyad = txtEdad.Text;
            String email = txtCraest.Text;
            String kullaniciAdi = textBox1.Text;
            String sifre = textBox2.Text;
            String guncellenecekId = txtGuncelle.Text;

            if (String.IsNullOrEmpty(ad) || String.IsNullOrEmpty(soyad) || String.IsNullOrEmpty(email) || String.IsNullOrEmpty(kullaniciAdi) || String.IsNullOrEmpty(sifre))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.");
                return;
            }
            KullaniciBL kullaniciBL = new KullaniciBL();
            kullaniciBL.kullaniciGuncelle(ad, soyad, email, kullaniciAdi, sifre);
            TumunuYukle();
        }

        private void KullaniciYonetimi_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
            YoneticiPaneli yoneticiPaneli = new YoneticiPaneli();
            yoneticiPaneli.Show();
        }
    }
}
