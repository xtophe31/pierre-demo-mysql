using System.Collections.Generic;
using DemoMySql.Modeles;
using MySql.Data.MySqlClient;

namespace DemoMySql.Bdd
{
    public class DalPersonne : DalBase, IDal<Personne>
    {
        internal DalPersonne(DbContexte dbContexte) : base(dbContexte)
        {
        }

        public void Create(Personne personne)
        {
            string query = $@"
                INSERT INTO personne (nom,prenom)
                VALUES ('{personne.Nom}','{personne.Prenom}')
            ";

            try
            {
                Contexte.MySqlConnection.Open();

                MySqlCommand cmd = new MySqlCommand(query, Contexte.MySqlConnection);
                cmd.ExecuteNonQuery();
                personne.Id = (int) cmd.LastInsertedId;
                personne.IsModified = false;

                Contexte.MySqlConnection.Close();
            }
            catch (MySqlException ex)
            {
                Logger.Trace($"Erreur Create bdd : {ex.Number} {ex.Message}");
            }
        }

        public Personne Read(int id)
        {
            string query = $@"SELECT * FROM personne where id={id}";

            try
            {
                Contexte.MySqlConnection.Open();

                MySqlCommand cmd = new MySqlCommand(query, Contexte.MySqlConnection);
                MySqlDataReader reader = cmd.ExecuteReader();

                Personne p = null;
                if (reader.Read())
                {
                    p = FromRow(reader);
                }

                Contexte.MySqlConnection.Close();

                return p;


            }
            catch (MySqlException ex)
            {
                Logger.Trace($"Erreur Read bdd : {ex.Number} {ex.Message}");

                return null;
            }
        }

        public void Update(Personne t)
        {
            string query = $@"
                UPDATE personne
                SET nom='{t.Nom}', prenom='{t.Prenom}'
                WHERE id={t.Id}
                ";
            try
            {
                Contexte.MySqlConnection.Open();


                MySqlCommand cmd = new MySqlCommand(query, Contexte.MySqlConnection);
                cmd.ExecuteNonQuery();
                t.IsModified = false;

                Contexte.MySqlConnection.Close();

            }
            catch (MySqlException ex)
            {
                Logger.Trace($"Erreur Update bdd : {ex.Number} {ex.Message}");
            }
        }

        public void Delete(Personne t)
        {
            string query = $@"
                DELETE FROM personne
                WHERE id={t.Id}
                ";
            try
            {
                Contexte.MySqlConnection.Open();

                MySqlCommand cmd = new MySqlCommand(query, Contexte.MySqlConnection);
                cmd.ExecuteNonQuery();

                Contexte.MySqlConnection.Close();
            }
            catch (MySqlException ex)
            {
                Logger.Trace($"Erreur Delete bdd : {ex.Number} {ex.Message}");
            }
        }

        public List<Personne> GetAll()
        {
            string query = $@"SELECT * FROM personne";

            List<Personne> liste = new List<Personne>();

            try
            {
                Contexte.MySqlConnection.Open();

                MySqlCommand cmd = new MySqlCommand(query, Contexte.MySqlConnection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    liste.Add(FromRow(reader));
                }

                Contexte.MySqlConnection.Close();

                return liste;
            }
            catch (MySqlException ex)
            {
                Logger.Trace($"Erreur Update bdd : {ex.Number} {ex.Message}");

                return null;
            }
        }

        /// <summary>
        /// transforme une ligne en objet Personne
        /// </summary>
        /// <param name="reader">un DataReader actif</param>
        /// <returns>une nouvelle entité Personne</returns>
        public Personne FromRow(MySqlDataReader reader)
        {
            Personne personne = new Personne()
            {
                Id = int.Parse(reader["id"].ToString()),
                Nom = reader["nom"].ToString(),
                Prenom = reader["prenom"].ToString(),
                IsModified = false
            };

            return personne;
        }
    }
}