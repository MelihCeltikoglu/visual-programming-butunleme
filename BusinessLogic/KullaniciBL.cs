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
    public class KullaniciBL
    {
        public KullaniciBL() { }
        public void veritabaniniBaslat()
        {
            KullaniciDA kullaniciDA = new KullaniciDA();
            kullaniciDA.InitializeDB();
        }

        public BindingList<Kullanici> tumListeyiGetir()
        {
            KullaniciDA kullaniciDA = new KullaniciDA();
            return kullaniciDA.GetKullanicilar();
        }


        public bool kullaniciGiris(String kadi, String sifre)
        {
            KullaniciDA kullaniciDA = new KullaniciDA();
            BindingList<Kullanici> kullanicilar = kullaniciDA.GetKullanicilar();

            var kullanici = kullanicilar.FirstOrDefault(x => x.Kadi == kadi && x.Sifre == sifre);

            if (kullanici != null)
            {
                return true;
            }

            return false;
        }

        public void kullaniciEkle(String ad, String soyad, String email, String kadi, String sifre)
        {
            KullaniciDA kullaniciDA = new KullaniciDA();
            kullaniciDA.Ekle(ad,soyad,email,kadi, sifre);
        }

        public void kullaniciGuncelle(String ad, String soyad, String email, String kadi, String sifre)
        {
            KullaniciDA kullaniciDA = new KullaniciDA();
            kullaniciDA.Guncelle(ad, soyad, email, kadi, sifre);
        }

        public void kullaniciSilme(string kadi)
        {
            KullaniciDA kullaniciDA = new KullaniciDA();
            kullaniciDA.Sil(kadi);
        }
    }
}
