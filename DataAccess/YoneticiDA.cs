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
    public class YoneticiDA
    {
        public YoneticiDA() { }

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
        public BindingList<Yonetici> GetYoneticiler()
        {
            BindingList<Yonetici> yoneticiListesi = new BindingList<Yonetici>();

            String query = "select * from admin";

            MySqlCommand cmd = new MySqlCommand(query, dbConn);

            dbConn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                // Yapılandırıcı
                Yonetici a = new Yonetici();

                int id = int.Parse(reader.GetString("id"));
                String isim = reader.GetString("isim");
                String kadi = reader.GetString("kadi");
                String sifre = reader.GetString("sifre");

                a.Id = id;
                a.Isim = isim;
                a.Kadi = kadi;
                a.Sifre = sifre;

                yoneticiListesi.Add(a);
            }

            dbConn.Close();

            return yoneticiListesi;
        }

        // Yeni Ekle
        public void Ekle(String kadi, String sifre, String isim)
        {
            String query = String.Format("insert into admin (kadi,sifre,isim) VALUES ('{0}','{1}','{2}')", kadi,sifre,isim);

            MySqlCommand cmd = new MySqlCommand(query, dbConn);

            dbConn.Open();
            cmd.ExecuteNonQuery();
            dbConn.Close();
        }

        // Güncelle
        public void Guncelle(String kadi, String sifre, String isim, int id)
        {
            String query = String.Format("UPDATE admin SET kadi='{0}',isim='{1}',sifre='{2}' where id='{3}'", kadi,isim,sifre,id);

            MySqlCommand cmd = new MySqlCommand(query, dbConn);

            dbConn.Open();
            cmd.ExecuteNonQuery();
            dbConn.Close();
        }

        // Silme
        public void Sil(int id)
        {
            String query = String.Format("DELETE FROM admin WHERE id='{0}'", id);

            MySqlCommand cmd = new MySqlCommand(query, dbConn);

            dbConn.Open();
            cmd.ExecuteNonQuery();
            dbConn.Close();
        }
    }
}
