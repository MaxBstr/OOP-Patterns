namespace Patterns._2._Structural._6._Flyweight
{
    public class Client
    {
        public static void Main()
        {
            var forest = new Forest();
            forest.PlantTree("bereza", "white", "beautiful");
            forest.PlantTree("bereza", "white", "beautiful");
            forest.PlantTree("bereza", "white", "beautiful");
            forest.PlantTree("bereza", "white", "beautiful");
            forest.PlantTree("oak", "brown", "old");
            forest.PlantTree("oak", "brown", "old");
            forest.PlantTree("oak", "brown", "old");
            forest.Draw();
        }
    }
}