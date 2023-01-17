using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using MySql.Data.MySqlClient;

namespace DataAccess
{
    public class KullaniciDA
    {
        public KullaniciDA() { }

        private const String SERVER = "127.0.0.1";
        private const String DATABASE = "spor";
        private const String UID = "root";
        private const String PASSWORD = "";
        private const String SSLM = "none";
        private const String PORT = "3306";
        private string connectionString;
        private static MySqlConnection dbConn;

        public void InitializeDB()
        {

            connectionString = String.Format("server={0};port={1};user id={2}; password={3}; database={4}; SslMode={5}", SERVER, PORT, UID, PASSWORD, DATABASE, SSLM);

            dbConn = new MySqlConnection(connectionString);
        }

        // Tümünü Listeleme
        public BindingList<Kullanici> GetKullanicilar ()
        {
            BindingList<Kullanici> kullaniciListesi = new BindingList<Kullanici>();

            String query = "select * from kullanicikayit";

            MySqlCommand cmd = new MySqlCommand(query, dbConn);

            dbConn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                // Yapılandırıcı
                Kullanici a = new Kullanici();
                
                String ad = reader.GetString("ad");
                String soyad = reader.GetString("soyad");
                String email = reader.GetString("email");
                String kadi = reader.GetString("kadi");
                String sifre = reader.GetString("sifre");
                int statu = int.Parse(reader.GetString("statu"));

                a.Ad = ad;
                a.Soyad = soyad;
                a.Email = email;
                a.Kadi = kadi;
                a.Sifre = sifre;
                a.Statu = statu;

                kullaniciListesi.Add(a);
            }

            dbConn.Close();

            return kullaniciListesi;
        }

        // Yeni Ekle
        public void Ekle (String ad, String soyad, String email, String kadi, String sifre)
        {
            String query = String.Format("insert into kullanicikayit (ad,soyad,email,kadi,sifre,statu) VALUES ('{0}','{1}','{2}','{3}','{4}',1)", ad, soyad, email,kadi,sifre);

            MySqlCommand cmd = new MySqlCommand(query, dbConn);

            dbConn.Open();
            cmd.ExecuteNonQuery();
            dbConn.Close();
        }

        // Güncelle
        public void Guncelle (String ad, String soyad, String email, String kadi, String sifre)
        {
            String query = String.Format("UPDATE kullanicikayit SET ad='{0}', soyad='{1}', email='{2}', kadi='{3}', sifre='{4}' where kadi='{5}'", ad, soyad, email, kadi, sifre, kadi);

            MySqlCommand cmd = new MySqlCommand(query, dbConn);

            dbConn.Open();
            cmd.ExecuteNonQuery();
            dbConn.Close();
        }

        // Silme
        public void Sil (String kadi)
        {
            String query = String.Format("DELETE FROM kullanicikayit WHERE kadi='{0}'", kadi);

            MySqlCommand cmd = new MySqlCommand(query, dbConn);

            dbConn.Open();
            cmd.ExecuteNonQuery();
            dbConn.Close();
        }
    }
}
