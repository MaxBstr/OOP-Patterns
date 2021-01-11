namespace Patterns._2._Structural._1._Adapter
{
    public interface IDatabase
    {
        void select();
        void remove();
        void update();
        void insert();
    }
}