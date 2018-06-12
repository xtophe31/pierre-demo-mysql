using System.Data.SqlTypes;

namespace DemoMySql.Modeles
{
    public interface IModele
    {
        int Id { get; set; }

        bool IsModified { get; }
    }
}