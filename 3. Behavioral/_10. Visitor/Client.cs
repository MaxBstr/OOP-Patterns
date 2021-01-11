namespace Patterns._3._Behavioral._10._Visitor
{
    public class Client
    {
        public static void Main()
        {
            var first = new FirstVisitor();
            var second = new SecondVisitor();

            var body = new BodyElement();
            var engine = new EngineElement();
            
            body.accept(first);
            engine.accept(first);
            
            body.accept(second);
            engine.accept(second);
        }
    }
}