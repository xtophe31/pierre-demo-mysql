using System.Data.SqlTypes;

namespace DemoMySql.Modeles
{
    public class ModeleBase
    {
        private int _id;

        public int Id
        {
            get => _id;

            set
            {
                _id = value;
                IsModified = true;
            }
        }

        public bool IsModified { get; set; }

    }
}