using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace DemoMySql.Bdd
{
    public interface IDal<T> where T : class
    {
        #region CRUD operation

        void Create(T personne);

        T Read(int id);

        void Update(T t);

        void Delete(T t);

        #endregion

        List<T> GetAll();

        T FromRow(MySqlDataReader reader);

    }
}