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
    public partial class FutbolHaberleri : Form
    {
        private FutbolHaberi futbolHaberi;
        public FutbolHaberleri()
        {
            InitializeComponent();
            FutbolBL futbolBL = new FutbolBL();
            futbolBL.veritabaniniBaslat();
        }

        private void TumunuYukle()
        {
            FutbolBL futbolBL = new FutbolBL();
            BindingList<FutbolHaberi> futbolHaberleri = new BindingList<FutbolHaberi>();
            futbolHaberleri = futbolBL.tumListeyiGetir();
            futbolHaberleriListesi.DataSource = futbolHaberleri;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String silinecekId = txtSil.Text;

            if ( String.IsNullOrEmpty(silinecekId))
            {
                MessageBox.Show("Lütfen silinecek ID'yi doğru yazınız.");
                return;
            }
            FutbolBL futbolBL = new FutbolBL();
            futbolBL.haberSilme(Convert.ToInt32(silinecekId));
            TumunuYukle();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FutbolBL futbolBL = new FutbolBL();
            futbolBL.veritabaniniBaslat();
            TumunuYukle();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            String haberBaslik = txtNombre.Text;
            String icerik = txtEdad.Text;
            String yazan = txtCraest.Text;

            if(String.IsNullOrEmpty(haberBaslik) || String.IsNullOrEmpty(icerik) || String.IsNullOrEmpty(yazan))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.");
                return;
            }
            FutbolBL futbolBL = new FutbolBL();
            futbolBL.haberEkle(haberBaslik, icerik, yazan);
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
            FutbolBL futbolBL = new FutbolBL();
            futbolBL.haberGuncelle(haberBaslik, icerik, yazan, Convert.ToInt32(guncellenecekId));
            TumunuYukle();
        }

        private void FutbolHaberleri_Load(object sender, EventArgs e)
        {

        }

        private void futbolHaberleriListesi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEdad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCraest_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtSil_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGuncelle_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void alumnoBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void FutbolHaberleri_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
            YoneticiPaneli yoneticiPaneli = new YoneticiPaneli();
            yoneticiPaneli.Show();
        }
    }
}
