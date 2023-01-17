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
    public class VoleybolDA
    {
        public VoleybolDA() {}

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

        // Tüm Haberleri Listeleme
        public BindingList<VoleybolHaberi> GetVoleybolHaberleri()
        {
            BindingList<VoleybolHaberi> alumnos = new BindingList<VoleybolHaberi>();

            String query = "select * from voleybol";

            MySqlCommand cmd = new MySqlCommand(query, dbConn);

            dbConn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                // Yapılandırıcı
                VoleybolHaberi a = new VoleybolHaberi();

                int id = int.Parse(reader.GetString("id"));
                String haberBaslik = reader.GetString("haberbaslik");
                String icerik = reader.GetString("icerik");
                String resimYolu = reader.GetString("resimyolu");
                String yazan = reader.GetString("yazan");

                a.Id = id;
                a.HaberBaslik = haberBaslik;
                a.Icerik = icerik;
                a.ResimYolu = resimYolu;
                a.Yazan = yazan;


                alumnos.Add(a);
            }

            dbConn.Close();

            return alumnos;
        }

        // Yeni Haber Ekle
        public void Ekle(String haberBaslik, String icerik, String yazan)
        {
            String query = String.Format("insert into voleybol (haberbaslik, icerik, yazan) VALUES ('{0}', '{1}', '{2}')", haberBaslik, icerik, yazan);

            MySqlCommand cmd = new MySqlCommand(query, dbConn);

            dbConn.Open();
            cmd.ExecuteNonQuery();
            dbConn.Close();
        }

        // Haber Güncelle
        public void Guncelle(String haberBaslik, String icerik, String yazan, int id)
        {
            String query = String.Format("UPDATE voleybol SET haberbaslik='{0}', icerik = '{1}', yazan = '{2}' where id='{3}'", haberBaslik, icerik, yazan, id);

            MySqlCommand cmd = new MySqlCommand(query, dbConn);

            dbConn.Open();
            cmd.ExecuteNonQuery();
            dbConn.Close();
        }

        // Haber Silme
        public void Sil(int id)
        {
            String query = String.Format("DELETE FROM voleybol WHERE id='{0}'", id);

            MySqlCommand cmd = new MySqlCommand(query, dbConn);

            dbConn.Open();
            cmd.ExecuteNonQuery();
            dbConn.Close();
        }
    }
}
