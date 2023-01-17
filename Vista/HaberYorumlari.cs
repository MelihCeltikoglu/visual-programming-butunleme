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
    public partial class HaberYorumlari : Form
    {
        private Yorum yorum;
        public HaberYorumlari()
        {
            InitializeComponent();
            YorumBL yorumBL = new YorumBL();
            yorumBL.veritabaniniBaslat();
        }

        private void HaberYorumlari_Load(object sender, EventArgs e)
        {
            TumunuYukle();
        }
        private void TumunuYukle()
        {
            YorumBL yorumBL = new YorumBL();
            BindingList<Yorum> yorumlar = new BindingList<Yorum>();
            yorumlar = yorumBL.tumListeyiGetir();
            haberYorumListesi.DataSource = yorumlar;
        }

        private void HaberYorumlari_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
            YoneticiPaneli girisSayfasi = new YoneticiPaneli();
            girisSayfasi.Show();
        }
    }
}
