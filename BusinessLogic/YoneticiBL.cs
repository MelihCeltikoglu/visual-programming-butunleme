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
    public class YoneticiBL
    {
        public YoneticiBL() { }

        public void veritabaniniBaslat()
        {
            YoneticiDA yoneticiDA = new YoneticiDA();
            yoneticiDA.InitializeDB();
        }

        public BindingList<Yonetici> tumListeyiGetir()
        {
            YoneticiDA yoneticiDA = new YoneticiDA();
            return yoneticiDA.GetYoneticiler();
        }


        public bool yoneticiGiris(String kadi, String sifre)
        {
            YoneticiDA yoneticiDA = new YoneticiDA();
            BindingList<Yonetici> yoneticiler =  yoneticiDA.GetYoneticiler();

            var yonetici = yoneticiler.FirstOrDefault(x => x.Kadi == kadi && x.Sifre == sifre);

            if(yonetici != null)
            {
                return true;
            }

            return false;
        }

        public void yoneticiEkle(String kadi, String sifre, String isim)
        {
            YoneticiDA yoneticiDA = new YoneticiDA();
            yoneticiDA.Ekle(kadi,sifre,isim);
        }

        public void yoneticiGuncelle(String kadi, String sifre, String isim, int id)
        {
            YoneticiDA yoneticiDA = new YoneticiDA();
            yoneticiDA.Guncelle(kadi, sifre, isim, id);
        }

        public void yoneticiSilme(int id)
        {
            YoneticiDA yoneticiDA = new YoneticiDA();
            yoneticiDA.Sil(id);
        }
    }
}
