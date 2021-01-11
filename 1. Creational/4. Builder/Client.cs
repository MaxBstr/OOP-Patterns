namespace Patterns._1._Creational._4._Builder
{
    public class Client
    {
        public static void Main()
        {
            IBuilder builder = new BankBuilder();
            builder.SetName("Name").SetCount(35);
            var bank = builder.Create();
        }
    }
}