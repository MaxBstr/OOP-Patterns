namespace Patterns._2._Structural._2._Bridge
{
    public abstract class Program
    {
        protected readonly IDeveloper Developer;

        protected Program(IDeveloper dev)
        {
            Developer = dev;
        }

        public abstract void DevelopProgram();
    }
}