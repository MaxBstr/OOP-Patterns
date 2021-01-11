using System;

namespace Patterns._2._Structural._6._Flyweight
{
    public class Tree
    {
        private TreeType _type;

        public Tree(TreeType type)
        {
            _type = type;
        }

        public void Draw()
        {
            _type.Draw();
        }
    }
}