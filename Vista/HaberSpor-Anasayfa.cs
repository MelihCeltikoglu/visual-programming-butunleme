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
    public partial class HaberSpor_Anasayfa : Form
    {
        public HaberSpor_Anasayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            YoneticiGirisi yoneticiGirisi = new YoneticiGirisi();
            yoneticiGirisi.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            KullaniciGirisi kullaniciGirisi = new KullaniciGirisi();
            kullaniciGirisi.Show();
        }
    }
}
