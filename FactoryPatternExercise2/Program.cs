namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What database would you like to use? List, SQL, or Mongo?");
            var typeList = Console.ReadLine();

            IDataAccess list = DataAccessFactory.GetDataAccess(typeList);

            list.LoadData();
            list.SaveData();
        }
    }
}
