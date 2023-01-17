using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using DataAccess;
using System.ComponentModel;

namespace BusinessLogic
{
    public class YorumBL
    {
        public YorumBL() { }
        public void veritabaniniBaslat()
        {
            YorumDA yorumDA = new YorumDA();
            yorumDA.InitializeDB();
        }

        public BindingList<Yorum> tumListeyiGetir()
        {
            YorumDA yoneticiDA = new YorumDA();
            return yoneticiDA.GetYorumlar();
        }
    }
}
