using System;
using System.Collections.Generic;
using System.Text;

namespace GoodGardenApp
{
    abstract class Plant
    {
        public string color;
        public double waterAmount, waterMax, waterIntake;

        public Plant(string color = "brown", double waterMax = 0, double waterIntake = 0)
        {
            this.color = color;
            this.waterMax = waterMax;
            this.waterIntake = waterIntake;
            waterAmount = 0;
        }
        public abstract void WhatsUp();
    }
}
