using System;
using System.Collections.Generic;
using System.Text;

namespace GoodGardenApp
{
    class Tree : Plant
    {
        public Tree(string color, double waterMax = 10, double waterIntake = 0.40) : base(color, waterMax, waterIntake)
        {

        }
        public override void WhatsUp()
        {
            if (waterAmount < waterMax)
            {
                Console.WriteLine(color + " tree needs water.");
            }
            else
            {
                Console.WriteLine(color + " tree doesnt need water.");
            }
        }
    }
}
