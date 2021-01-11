using System;

namespace Patterns._2._Structural._1._Adapter
{
    public class Application
    {
        public void saveObject()
        {
            Console.WriteLine("Saving...");
        }

        public void deleteObject()
        {
            Console.WriteLine("Deleting...");
        }

        public void loadObject()
        {
            Console.WriteLine("Loading...");
        }

        public void updateObject()
        {
            Console.WriteLine("Updating...");
        }
    }
}