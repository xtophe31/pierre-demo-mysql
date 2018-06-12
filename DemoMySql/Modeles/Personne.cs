using System.Data.SqlTypes;

namespace DemoMySql.Modeles
{
    public class Personne : ModeleBase
    {
        private string _prenom;

        public string Prenom
        {
            get { return _prenom; }

            set
            {
                _prenom = value;
                IsModified = true;

            }
        }

        private string _nom;

        public string Nom
        {
            get { return _nom; }

            set
            {
                _nom = value;
                IsModified = true;

            }
        }

    }
}