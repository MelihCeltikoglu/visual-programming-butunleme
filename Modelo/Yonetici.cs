using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Yonetici
    {
        private int id;
        private string isim;
        private string kadi;
        private string sifre;
        public Yonetici()
        {

        }
        public int Id { get; set; }
        public string Isim { get; set; }
        public string Kadi { get; set; }
        public string Sifre { get; set; }
    }
}
