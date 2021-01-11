namespace Patterns._2._Structural._7._Proxy
{
    public class ProxyImage : Image
    {
        private string PATH;
        private RealImage _realImage;

        public ProxyImage(string file)
        {
            PATH = file;
        }
        
        public void Display()
        {
            if (_realImage == null)
                _realImage = new RealImage(PATH);
            
            _realImage.Display();
        }
    }
}