using System;

namespace GardenApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Garden johely = new Garden();
            johely.AddPlant(new Flower("yellow"));
            johely.AddPlant(new Flower("blue"));
            johely.AddPlant(new Tree("purple"));
            johely.AddPlant(new Tree("orange"));
            johely.StateOfGarden();
            johely.Water(40);
            johely.StateOfGarden();
            johely.Water(50);
            johely.StateOfGarden();
            Console.ReadLine();
        }
    }
}
