using System;
namespace Patterns._3._Behavioral._10._Visitor
{
    public class SecondVisitor : IVisitor
    {
        public void visit(BodyElement body)
        {
            Console.WriteLine("Second visitor checked body");
        }

        public void visit(EngineElement engineElement)
        {
            Console.WriteLine("Second visitor run engine");
        }
    }
}