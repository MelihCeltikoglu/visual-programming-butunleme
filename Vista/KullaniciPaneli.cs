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
    public partial class KullaniciPaneli : Form
    {
        private BasketbolHaberi basketbolHaberi;
        private FutbolHaberi futbolHaberi;
        private VoleybolHaberi voleybolHaberi;
        public KullaniciPaneli()
        {
            InitializeComponent();
            BasketbolBL basketbolBL = new BasketbolBL();
            basketbolBL.veritabaniniBaslat();
            FutbolBL futbolBL = new FutbolBL();
            futbolBL.veritabaniniBaslat();
            VoleybolBL voleybolBL = new VoleybolBL();
            voleybolBL.veritabaniniBaslat();
        }

        private void KullaniciPaneli_Load(object sender, EventArgs e)
        {
            TumunuYukle();
        }

        private void TumunuYukle()
        {
            BasketbolBL basketbolBL = new BasketbolBL();
            BindingList<BasketbolHaberi> basketbolHaberleri = new BindingList<BasketbolHaberi>();
            basketbolHaberleri = basketbolBL.tumListeyiGetir();
            basketbolHaberleriListesi.DataSource = basketbolHaberleri;

            FutbolBL futbolBL = new FutbolBL();
            BindingList<FutbolHaberi> futbolHablerleri = new BindingList<FutbolHaberi>();
            futbolHablerleri = futbolBL.tumListeyiGetir();
            futbolHaberleriListesi.DataSource = futbolHablerleri;

            VoleybolBL voleybolBL = new VoleybolBL();
            BindingList<VoleybolHaberi> voleybolHaberleri = new BindingList<VoleybolHaberi>();
            voleybolHaberleri = voleybolBL.tumListeyiGetir();
            voleybolHaberleriListesi.DataSource = voleybolHaberleri;
        }

        private void KullaniciPaneli_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
            KullaniciGirisi girisSayfasi = new KullaniciGirisi();
            girisSayfasi.Show();
        }
    }
}
