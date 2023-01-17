using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class VoleybolHaberi
    {
        private int id;
        private string haberBaslik;
        private string icerik;
        private string resimYolu;
        private string yazan;
        public VoleybolHaberi()
        {

        }
        public int Id { get; set; }
        public string HaberBaslik { get; set; }
        public string ResimYolu { get; set; }
        public string Yazan { get; set; }
        public string Icerik { get; set; }
    }
}
