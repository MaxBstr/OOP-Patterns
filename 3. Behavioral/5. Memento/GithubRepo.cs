namespace Patterns._3._Behavioral._5._Memento
{
    public class GithubRepo
    {
        private Save _save;

        public Save GetSave()
        {
            return _save;
        }

        public void SetSave(Save save)
        {
            _save = save;
        }
    }
}