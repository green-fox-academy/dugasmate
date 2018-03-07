using System;
using System.Collections.Generic;
using System.Text;

namespace GoodGardenApp
{
    abstract class Plant
    {
        public string color;
        public double waterAmount;
        public double maxWater;

        public Plant(string color = "brown")
        {
            this.color = color;
            waterAmount = 0;
        }
        public abstract void WhatsUp();
        public abstract void WaterPlants(double portion);
    }
}
