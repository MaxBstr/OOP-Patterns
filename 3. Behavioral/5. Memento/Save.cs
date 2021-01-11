namespace Patterns._3._Behavioral._5._Memento
{
    public class Save
    {
        private readonly string _version;

        public Save(string ver)
        {
            _version = ver;
        }

        public string GetVersion()
        {
            return _version;
        }
}
}