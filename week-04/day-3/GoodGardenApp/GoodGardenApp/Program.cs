using System;
using System.Collections.Generic;

namespace GoodGardenApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TheGarden garden = new TheGarden();
            garden.AddPlant( new Flower("Yellow"));
            garden.AddPlant(new Flower("Blue"));
            garden.AddPlant(new Tree("Purple"));
            garden.AddPlant(new Tree("Orange"));
            garden.StateOfGarden();
            garden.PlantWaterer(40);
            garden.StateOfGarden();
            garden.PlantWaterer(50);
            garden.StateOfGarden();
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
