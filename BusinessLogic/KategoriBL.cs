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
    public class KategoriBL
    {
        public KategoriBL() { }

        public void veritabaniniBaslat()
        {
            KategoriDA kategoriDA = new KategoriDA();
            kategoriDA.InitializeDB();
        }

        public BindingList<Kategori> tumListeyiGetir()
        {
            KategoriDA kategoriDA = new KategoriDA();
            return kategoriDA.GetKategoriler();
        }

        public void kategoriEkle(String adi)
        {
            KategoriDA kategoriDA = new KategoriDA();
            kategoriDA.Ekle(adi);
        }

        public void kategoriGuncelle(String adi, int id)
        {
            KategoriDA kategoriDA = new KategoriDA();
            kategoriDA.Guncelle(adi, id);
        }

        public void kategoriSilme(int id)
        {
            KategoriDA kategoriDA = new KategoriDA();
            kategoriDA.Sil(id);
        }
    }
}
