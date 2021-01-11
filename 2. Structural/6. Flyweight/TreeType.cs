using System;

namespace Patterns._2._Structural._6._Flyweight
{
    public class TreeType
    {
        public string Name { get; }
        public string Color { get; }
        public string Texture { get; }

        public TreeType(string name, string color, string texture)
        {
            Name = name;
            Color = color;
            Texture = texture;
            Console.WriteLine("Create new type");
        }

        public void Draw()
        {
            Console.WriteLine($"Drawing tree: {Name}, {Color}, {Texture}");
        }
    }
}