namespace Patterns._2._Structural._1._Adapter
{
    public class AdapterAppToDataBase : Application, IDatabase
    {
        public void select()
        {
            loadObject();
        }

        public void remove()
        {
            deleteObject();
        }

        public void update()
        {
            updateObject();
        }

        public void insert()
        {
            saveObject();
        }
    }
}