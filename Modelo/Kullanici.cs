using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Kullanici
    {
        private string ad;
        private string soyad;
        private string email;
        private string kadi;
        private string sifre;
        private int statu;
        public Kullanici()
        {

        }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Email { get; set; }
        public string Kadi { get; set; }
        public string Sifre { get; set; }
        public int Statu { get; set; }
    }
}
