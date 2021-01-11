namespace Patterns._3._Behavioral._10._Visitor
{
    public class EngineElement : IElement
    {
        public void accept(IVisitor visitor)
        {
            visitor.visit(this);
        }
    }
}