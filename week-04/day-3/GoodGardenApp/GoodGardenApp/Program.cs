using System;
using System.Collections.Generic;

namespace GoodGardenApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TheGarden garden = new TheGarden();
            var yellowF = new Flower("yellow");
            var blueF = new Flower("blue");
            var purpleF = new Tree("purple");
            var orangeF = new Tree("orange");
            garden.AddPlant(blueF);
            garden.AddPlant(yellowF);
            garden.AddPlant(purpleF);
            garden.AddPlant(orangeF);
            garden.StateOfGarden();
            garden.PlantWaterer(40);
            garden.StateOfGarden();
            garden.PlantWaterer(70);
            garden.StateOfGarden();
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
