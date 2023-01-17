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
    public class VoleybolBL
    {
        public VoleybolBL() { }

        public void veritabaniniBaslat()
        {
            VoleybolDA voleybolDA = new VoleybolDA();
            voleybolDA.InitializeDB();
        }

        public BindingList<VoleybolHaberi> tumListeyiGetir()
        {
            VoleybolDA voleybolDA = new VoleybolDA();
            return voleybolDA.GetVoleybolHaberleri();
        }

        public void haberEkle(String haberBaslik, String icerik, String yazan)
        {
            VoleybolDA voleybolDA = new VoleybolDA();
            voleybolDA.Ekle(haberBaslik, icerik, yazan);
        }

        public void haberGuncelle(String haberBaslik, String icerik, String yazan, int id)
        {
            VoleybolDA voleybolDA = new VoleybolDA();
            voleybolDA.Guncelle(haberBaslik, icerik, yazan, id);
        }

        public void haberSilme(int id)
        {
            VoleybolDA voleybolDA = new VoleybolDA();
            voleybolDA.Sil(id);
        }
    }
}
