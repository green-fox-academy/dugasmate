using System;
using System.Collections.Generic;
using System.Text;

namespace GoodGardenApp
{
    class Flower : Plant
    {
        double waterIntake = 0.75;
        double maxWater = 5;

        public Flower(string color) : base(color)
        {
  
        }
        public override void WhatsUp()
        {

            if (waterAmount < maxWater)
            {
                Console.WriteLine(color + " flower needs water.");
            }
            else
            {
                Console.WriteLine(color + " flower doesnt need water.");
            }
        }
        public override void WaterPlants(double portion)
        {
            if (waterAmount < maxWater)
            {
                waterAmount = waterAmount +  portion * waterIntake;
            }
            else
            {
                portion = 0;
            }

        }
    }
}
