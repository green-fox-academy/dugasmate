using System;
using System.Collections.Generic;
using System.Text;

namespace GoodGardenApp
{
    class Flower : Plant
    {
        public Flower(string color, double waterMax = 5, double waterIntake = 0.75) : base(color, waterMax, waterIntake)
        {

        }
        public override void WhatsUp()
        {
            if (waterAmount < waterMax)
            {
                Console.WriteLine(color + " flower needs water.");
            }
            else
            {
                Console.WriteLine(color + " flower doesnt need water.");
            }
        }
    }
}
