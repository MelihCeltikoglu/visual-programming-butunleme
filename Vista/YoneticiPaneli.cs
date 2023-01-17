using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class YoneticiPaneli : Form
    {
        public YoneticiPaneli()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FutbolHaberleri futbolHaberleri = new FutbolHaberleri();
            futbolHaberleri.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            VoleybolHaberleri voleybolHaberleri = new VoleybolHaberleri();
            voleybolHaberleri.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            BasketbolHaberleri basketbolHaberleri = new BasketbolHaberleri();
            basketbolHaberleri.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            HaberKategorileri kategoriler = new HaberKategorileri();
            kategoriler.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            YoneticiYonetimi yoneticiYonetimi = new YoneticiYonetimi();
            yoneticiYonetimi.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            KullaniciYonetimi kullaniciYonetimi = new KullaniciYonetimi();
            kullaniciYonetimi.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            HaberYorumlari yorumlar = new HaberYorumlari();
            yorumlar.Show();
        }
    }
}
