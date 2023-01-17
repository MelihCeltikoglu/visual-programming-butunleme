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
    public partial class HaberKategorileri : Form
    {
        private Kategori kategori;
        public HaberKategorileri()
        {
            InitializeComponent();
            KategoriBL kategoriBL = new KategoriBL();
            kategoriBL.veritabaniniBaslat();
        }

        private void TumunuYukle()
        {
            KategoriBL kategoriBL = new KategoriBL();
            BindingList<Kategori> kategoriler = new BindingList<Kategori>();
            kategoriler = kategoriBL.tumListeyiGetir();
            kategoriGridListesi.DataSource = kategoriler;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String silinecekId = txtSil.Text;

            if (String.IsNullOrEmpty(silinecekId))
            {
                MessageBox.Show("Lütfen silinecek ID'yi doğru yazınız.");
                return;
            }
            KategoriBL kategoriBL = new KategoriBL();
            kategoriBL.kategoriSilme(Convert.ToInt32(silinecekId));
            TumunuYukle();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            KategoriBL kategoriBL = new KategoriBL();
            kategoriBL.veritabaniniBaslat();
            TumunuYukle();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            String adi = txtNombre.Text;

            if (String.IsNullOrEmpty(adi))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.");
                return;
            }
            KategoriBL kategoriBL = new KategoriBL();
            kategoriBL.kategoriEkle(adi);
            TumunuYukle();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String adi = txtNombre.Text;
            String guncellenecekId = txtGuncelle.Text;

            if (String.IsNullOrEmpty(adi) || String.IsNullOrEmpty(guncellenecekId))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.");
                return;
            }
            KategoriBL kategoriBL = new KategoriBL();
            kategoriBL.kategoriGuncelle(adi, Convert.ToInt32(guncellenecekId));
            TumunuYukle();
        }

        private void HaberKategorileri_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
            YoneticiPaneli yoneticiPaneli = new YoneticiPaneli();
            yoneticiPaneli.Show();
        }
    }
}
