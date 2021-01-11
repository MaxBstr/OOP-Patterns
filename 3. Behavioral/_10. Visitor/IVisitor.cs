namespace Patterns._3._Behavioral._10._Visitor
{
    public interface IVisitor
    {
        void visit(BodyElement body);
        void visit(EngineElement engine);
    }
}