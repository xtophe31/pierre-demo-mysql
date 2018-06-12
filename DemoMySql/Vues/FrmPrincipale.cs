using System.ComponentModel;
using System.Windows.Forms;

using Prana.Tools;

using DemoMySql.Bdd;
using DemoMySql.Modeles;
using NLog;

namespace DemoMySql.Vues
{
    public partial class FrmPrincipale : Form
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();
        private readonly DbContexte _contexte = new DbContexte("localhost", "pierredemo", "pierre", "pierre");

        public FrmPrincipale()
        {
            InitializeComponent();

            var list = new BindingList<Personne>(_contexte.DalPersonne.GetAll());

            dgvPersonne.DataSource = list;
            dgvPersonne.Refresh();

        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            Logger.Trace("Form1_Load");

        }

        private void BtnPopulate_Click(object sender, System.EventArgs e)
        {
            Logger.Trace("BtnPopulate_Click");

            Random random = new Random();

            DalPersonne dal = _contexte.DalPersonne;

            for (int i = 0; i < 100; i++)
            {
                Random.Person person = random.NextPerson(Random.AllowedLanguage.FRENCH);

                Personne item = new Personne
                {
                    Nom = person.FirstName,
                    Prenom = person.LastName
                };

                dal.Create(item);
            }

        }

        private void BtnQuit_Click(object sender, System.EventArgs e)
        {
            Logger.Trace("BtnQuit_Click");

            Application.Exit();
        }

        private void BtnSave_Click(object sender, System.EventArgs e)
        {
            foreach (Personne personne in (BindingList<Personne>)dgvPersonne.DataSource)
            {
                if (personne.IsModified)
                    _contexte.DalPersonne.Update(personne);
            }

            dgvPersonne.Refresh();
        }
    }
}
