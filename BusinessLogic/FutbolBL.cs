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
    public class FutbolBL
    {

        public FutbolBL() { }

        public void veritabaniniBaslat()
        {
            FutbolDA futbolDA = new FutbolDA();
            futbolDA.InitializeDB();
        }

        public BindingList<FutbolHaberi> tumListeyiGetir()
        {
            FutbolDA futbolDA = new FutbolDA();
            return futbolDA.GetFutbolHaberleri();
        }

        public void haberEkle(String haberBaslik, String icerik, String yazan)
        {
            FutbolDA futbolDA = new FutbolDA();
            futbolDA.Ekle(haberBaslik, icerik, yazan);
        }

        public void haberGuncelle(String haberBaslik, String icerik, String yazan, int id)
        {
            FutbolDA futbolDA = new FutbolDA();
            futbolDA.Guncelle(haberBaslik, icerik, yazan, id);
        }

        public void haberSilme(int id)
        {
            FutbolDA alumnoDA = new FutbolDA();
            alumnoDA.Sil(id);
        }
    }
}
