namespace Patterns._3._Behavioral._10._Visitor
{
    public interface IElement
    {
        void accept(IVisitor visitor);
    }
}