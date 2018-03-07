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
            Console.WriteLine("Used sharpie");
            return inkAmount -= usage;
            
        }


    }

}

