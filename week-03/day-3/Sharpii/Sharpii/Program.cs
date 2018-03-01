using System;

namespace Sharpii
{
    class Program
    {
        static void Main(string[] args)
        {
            Sharpie sharpie1 = new Sharpie("black", 5 );
            Sharpie sharpie2 = new Sharpie("yellow", 2);
            Sharpie sharpie3 = new Sharpie("pink", 3);
            Console.WriteLine("{0}, {1}, {2}", sharpie1.color, sharpie1.width, sharpie1.inkAmount );
            sharpie1.Use(5.6);
            Console.WriteLine("{0}, {1}, {2}", sharpie1.color, sharpie1.width, sharpie1.inkAmount);
            Console.ReadLine();


        }
    }
}
