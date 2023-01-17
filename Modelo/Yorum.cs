using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Yorum
    {
        private int id;
        private int haberId;
        private string haberTipi;
        private string kuladi;
        private string yorumMetni;
        public Yorum()
        {

        }
        public int Id { get; set; }
        public string HaberId { get; set; }
        public string HaberTipi { get; set; }
        public string Kuladi { get; set; }
        public string YorumMetni { get; set; }
    }
}
