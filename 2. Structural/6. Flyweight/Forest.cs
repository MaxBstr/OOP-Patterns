using System.Collections.Generic;

namespace Patterns._2._Structural._6._Flyweight
{
    public class Forest
    {
        private List<Tree> _forest = new List<Tree>();

        public void PlantTree(string name, string color, string texture)
        {
            var type = TreeFactory.GetTreeType(name, color, texture);
            var tree = new Tree(type);
            _forest.Add(tree);
        }

        public void Draw()
        {
            foreach (var tree in _forest)
            {
                tree.Draw();
            }
        }
    }
}