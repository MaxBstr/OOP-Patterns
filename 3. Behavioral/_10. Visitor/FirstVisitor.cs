using System;

namespace Patterns._3._Behavioral._10._Visitor
{
    public class FirstVisitor : IVisitor
    {
        public void visit(BodyElement body)
        {
            Console.WriteLine("First visitor checked body");
        }

        public void visit(EngineElement engineElement)
        {
            Console.WriteLine("First visitor run engine");
        }
    }
}