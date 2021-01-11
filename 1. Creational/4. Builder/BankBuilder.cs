using System.Xml;

namespace Patterns._1._Creational._4._Builder
{
    public interface IBuilder
    {
        IBuilder SetName(string name);
        IBuilder SetCount(int cnt);
        Bank Create();
    }
    public class BankBuilder : IBuilder
    {
        private string _name;
        private int _cnt;
        
        public IBuilder SetName(string name)
        {
            _name = name;
            return this;
        }

        public IBuilder SetCount(int cnt)
        {
            _cnt = cnt;
            return this;
        }

        public Bank Create()
        {
            return new Bank(_name, _cnt);
        }
    }
}