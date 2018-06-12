using NLog;

namespace DemoMySql.Bdd
{
    public abstract class DalBase
    {
        protected static Logger Logger = LogManager.GetCurrentClassLogger();

        protected DbContexte Contexte { get; }

        protected DalBase(DbContexte dbContexte)
        {
            this.Contexte = dbContexte;
        }
    }
}