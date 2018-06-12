using System;
using MySql.Data;
using MySql.Data.MySqlClient;
using NLog;

namespace DemoMySql.Bdd
{
    public class DbContexte
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        public MySqlConnection MySqlConnection { get; }

        private DalPersonne _dalPersonne;

        public DalPersonne DalPersonne => _dalPersonne ?? (_dalPersonne = new DalPersonne(this));

        public DbContexte(string serveur, string modele, string utilisateur, string motDePasse)
        {
            string connexionString = $"SERVER = {serveur}; DATABASE = {modele}; UID = {utilisateur}; PASSWORD = {motDePasse}";
            MySqlConnection = new MySqlConnection(connexionString);
        }

        //public bool Open()
        //{
        //    try
        //    {
        //        MySqlConnection.Open();

        //        return true;
        //    }
        //    catch (MySqlException ex)
        //    {
        //        Logger.Trace($"Erreur ouverture bdd : {ex.Number} {ex.Message}");

        //        return false;
        //    }
        //}

        //public bool Close()
        //{
        //    try
        //    {
        //        MySqlConnection.Close();

        //        return true;
        //    }
        //    catch (MySqlException ex)
        //    {
        //        Logger.Trace($"Erreur fermeture bdd : {ex.Number} {ex.Message}");

        //        return false;
        //    }
        //}
    }
}