using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class MongoDataAccess : IDataAccess
    {
        public void LoadData()
        {
            Console.WriteLine("I am reading data from mongo data access");
        }
        public void SaveData()
        {
            Console.WriteLine("I am savin data to a mongo data access");
        }
    }
}
