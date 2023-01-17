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
    public partial class VoleybolHaberleri : Form
    {
        VoleybolHaberi voleybolHaberi;
        public VoleybolHaberleri()
        {
            InitializeComponent();
            VoleybolBL voleybolBL = new VoleybolBL();
            voleybolBL.veritabaniniBaslat();
        }


        private void TumunuYukle()
        {
            VoleybolBL voleybolBL = new VoleybolBL();
            BindingList<VoleybolHaberi> voleybolHaberleri = new BindingList<VoleybolHaberi>();
            voleybolHaberleri = voleybolBL.tumListeyiGetir();
            futbolHaberleriListesi.DataSource = voleybolHaberleri;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String silinecekId = txtSil.Text;

            if (String.IsNullOrEmpty(silinecekId))
            {
                MessageBox.Show("Lütfen silinecek ID'yi doğru yazınız.");
                return;
            }
            VoleybolBL voleybolBL = new VoleybolBL();
            voleybolBL.haberSilme(Convert.ToInt32(silinecekId));
            TumunuYukle();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            VoleybolBL voleybolBL = new VoleybolBL();
            voleybolBL.veritabaniniBaslat();
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
            VoleybolBL voleybolBL = new VoleybolBL();
            voleybolBL.haberEkle(haberBaslik, icerik, yazan);
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
            VoleybolBL voleybolBL = new VoleybolBL();
            voleybolBL.haberGuncelle(haberBaslik, icerik, yazan, Convert.ToInt32(guncellenecekId));
            TumunuYukle();
        }

        private void VoleybolHaberleri_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
            YoneticiPaneli yoneticiPaneli = new YoneticiPaneli();
            yoneticiPaneli.Show();
        }
    }
}
