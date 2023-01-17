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
    public partial class KullaniciGirisi : Form
    {
        public KullaniciGirisi()
        {
            InitializeComponent();
            KullaniciBL kullaniciBL = new KullaniciBL();
            kullaniciBL.veritabaniniBaslat();
        }

        private void KullaniciGirisi_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
            HaberSpor_Anasayfa anasayfa = new HaberSpor_Anasayfa();
            anasayfa.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                KullaniciBL kullaniciBL = new KullaniciBL();

                bool sonuc = kullaniciBL.kullaniciGiris(textBox1.Text, textBox2.Text);

                if (sonuc)
                {
                    this.Visible = false;
                    KullaniciPaneli kullanici = new KullaniciPaneli();
                    kullanici.Show();
                }
                else
                {
                    MessageBox.Show("Lütfen girdiğiniz bilgileri kontrol ediniz. Girilen bilgiler ile kullanıcı bulunamadı.");
                }

            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.");
            }
        }
    }
}
