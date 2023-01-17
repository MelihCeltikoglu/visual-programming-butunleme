using System;
using System.ComponentModel;
using Modelo;
using MySql.Data.MySqlClient;

namespace DataAccess
{
    public class YorumDA
    {
        public YorumDA() { }

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
        public BindingList<Yorum> GetYorumlar()
        {
            BindingList<Yorum> yorumListesi = new BindingList<Yorum>();

            String query = "select * from yorumlar";

            MySqlCommand cmd = new MySqlCommand(query, dbConn);

            dbConn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                // Yapılandırıcı
                Yorum a = new Yorum();

                int id = int.Parse(reader.GetString("id"));
                int haberId = int.Parse(reader.GetString("haberid"));
                String habertipi = reader.GetString("habertipi");
                String kuladi = reader.GetString("kuladi");
                String yorum = reader.GetString("yorum");

                a.Id = id;
                a.HaberId = haberId.ToString();
                a.HaberTipi = habertipi;
                a.Kuladi = kuladi;
                a.YorumMetni = yorum;

                yorumListesi.Add(a);
            }

            dbConn.Close();

            return yorumListesi;
        }
    }
}
