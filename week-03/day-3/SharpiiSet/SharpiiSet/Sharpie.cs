using System;
using System.Collections.Generic;
using System.Text;

namespace SharpiiSet
{
    public class Sharpie
    {
        public string color;
        public double width, inkAmount;

        public Sharpie(string color, double width, double inkAmount = 100)
        {
            this.color = color;
            this.width = width;
            this.inkAmount = inkAmount;
        }
        public double Use(double usage)
        {
            return inkAmount -= 1.5;
        }
        bool CountUsable(double inkAmount)
        {
            if (inkAmount >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }

}

