using System;
using System.Collections.Generic;
using System.Text;

namespace GoodGardenApp
{
    class Tree : Plant
    {
        double waterIntake = 0.40;
        double maxWater = 10;
        public Tree(string color) : base(color)
        {
            
        }
        public override void WhatsUp()
        {
            if (waterAmount < maxWater)
            {
                Console.WriteLine(color + " tree needs water.");
            }
            else
            {
                Console.WriteLine(color + " tree doesnt need water.");
            }
        }
        public override void WaterPlants(double portion)
        {
            if (waterAmount < maxWater)
            {
                waterAmount = waterAmount + portion * waterIntake;
            }
            else
            {
                portion = 0;
            }
            
        }
    }
}
