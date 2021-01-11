namespace Patterns._2._Structural._1._Adapter
{
    public class Client
    {
        public static void Main()
        {
            IDatabase database = new AdapterAppToDataBase();
            database.insert();
            database.update();
            database.select();
            database.remove();
        }
    }
}