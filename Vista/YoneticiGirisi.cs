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
    public partial class YoneticiGirisi : Form
    {
        public YoneticiGirisi()
        {
            InitializeComponent();
            YoneticiBL yoneticiBL = new YoneticiBL();
            yoneticiBL.veritabaniniBaslat();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "" && textBox2.Text != "")
            {
                YoneticiBL yoneticiBL = new YoneticiBL();

                bool sonuc = yoneticiBL.yoneticiGiris(textBox1.Text, textBox2.Text);

                if (sonuc)
                {
                    this.Visible = false;
                    YoneticiPaneli yonetici = new YoneticiPaneli();
                    yonetici.Show();
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

        private void YoneticiGirisi_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
            HaberSpor_Anasayfa anasayfa = new HaberSpor_Anasayfa();
            anasayfa.Show();
        }
    }
}
