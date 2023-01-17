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
    public partial class BasketbolHaberleri : Form
    {
        private BasketbolHaberi basketbolHaberi;

        public BasketbolHaberleri()
        {
            InitializeComponent();
            BasketbolBL basketbolBL = new BasketbolBL();
            basketbolBL.veritabaniniBaslat();
        }

        private void TumunuYukle()
        {
            BasketbolBL basketbolBL = new BasketbolBL();
            BindingList<BasketbolHaberi> basketbolHaberleri = new BindingList<BasketbolHaberi>();
            basketbolHaberleri = basketbolBL.tumListeyiGetir();
            futbolHaberleriListesi.DataSource = basketbolHaberleri;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String silinecekId = txtSil.Text;

            if (String.IsNullOrEmpty(silinecekId))
            {
                MessageBox.Show("Lütfen silinecek ID'yi doğru yazınız.");
                return;
            }
            BasketbolBL basketbolBL = new BasketbolBL();
            basketbolBL.haberSilme(Convert.ToInt32(silinecekId));
            TumunuYukle();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BasketbolBL basketbolBL = new BasketbolBL();
            basketbolBL.veritabaniniBaslat();
            TumunuYukle();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            String haberBaslik = txtNombre.Text;
            String icerik = txtEdad.Text;
            String yazan = txtCraest.Text;

            if (String.IsNullOrEmpty(haberBaslik) || String.IsNullOrEmpty(icerik) || String.IsNullOrEmpty(yazan))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.");
                return;
            }
            BasketbolBL basketbolBL = new BasketbolBL();
            basketbolBL.haberEkle(haberBaslik, icerik, yazan);
            TumunuYukle();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String haberBaslik = txtNombre.Text;
            String icerik = txtEdad.Text;
            String yazan = txtCraest.Text;
            String guncellenecekId = txtGuncelle.Text;

            if (String.IsNullOrEmpty(haberBaslik) || String.IsNullOrEmpty(icerik) || String.IsNullOrEmpty(yazan) || String.IsNullOrEmpty(guncellenecekId))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.");
                return;
            }
            BasketbolBL basketbolBL = new BasketbolBL();
            basketbolBL.haberGuncelle(haberBaslik, icerik, yazan, Convert.ToInt32(guncellenecekId));
            TumunuYukle();
        }

        private void BasketbolHaberleri_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
            YoneticiPaneli yoneticiPaneli = new YoneticiPaneli();
            yoneticiPaneli.Show();
        }
    }
}
