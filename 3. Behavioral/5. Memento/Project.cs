namespace Patterns._3._Behavioral._5._Memento
{
    public class Project
    {
        private string _version;

        public void setVersion(string ver)
        {
            _version = ver;
        }

        public override string ToString()
        {
            return $"Project version: {_version}";
        }

        public Save SaveProject()
        {
            return new Save(_version);
        }

        public void LoadProject(Save save)
        {
            _version = save.GetVersion();
        }
    }
}