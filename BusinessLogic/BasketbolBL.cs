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
    public class BasketbolBL
    {
        public BasketbolBL() { }

        public void veritabaniniBaslat()
        {
            BasketbolDA basketbolDA = new BasketbolDA();
            basketbolDA.InitializeDB();
        }

        public BindingList<BasketbolHaberi> tumListeyiGetir()
        {
            BasketbolDA basketbolDA = new BasketbolDA();
            return basketbolDA.GetBasketbolHaberleri();
        }

        public void haberEkle(String haberBaslik, String icerik, String yazan)
        {
            BasketbolDA basketbolDA = new BasketbolDA();
            basketbolDA.Ekle(haberBaslik, icerik, yazan);
        }

        public void haberGuncelle(String haberBaslik, String icerik, String yazan, int id)
        {
            BasketbolDA basketbolDA = new BasketbolDA();
            basketbolDA.Guncelle(haberBaslik, icerik, yazan, id);
        }

        public void haberSilme(int id)
        {
            BasketbolDA basketbolDA = new BasketbolDA();
            basketbolDA.Sil(id);
        }
    }
}
