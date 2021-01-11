using System;

namespace Patterns._2._Structural._7._Proxy
{
    public class RealImage : Image
    {
        private string _file;

        public RealImage(string file)
        {
            _file = file;
            Load();
        }
        public void Display()
        {
            Console.WriteLine($"Viewing {_file}");   
        }

        private void Load()
        {
            Console.WriteLine($"Loading {_file}");
        }
        
    }
}