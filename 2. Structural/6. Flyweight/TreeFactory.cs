using System.Collections.Generic;

namespace Patterns._2._Structural._6._Flyweight
{
    public static class TreeFactory
    {
        private static List<TreeType> _types = new List<TreeType>();

        public static TreeType GetTreeType(string name, string color, string texture)
        {
            var type = _types.Find(t => t.Color == color &&
                                        t.Name == name && t.Texture == texture);
            if (type != null) return type;
            
            type = new TreeType(name, color, texture);
            _types.Add(type);

            return type;
        }
    }
}