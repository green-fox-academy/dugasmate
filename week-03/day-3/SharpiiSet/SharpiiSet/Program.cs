using System;

namespace SharpiiSet
{
    class Program
    {
        static void Main(string[] args)
        {
            SharpieSet.AddSharpieToList(new Sharpie("black", 5));
            SharpieSet.AddSharpieToList(new Sharpie("yellow", 2));
            SharpieSet.AddSharpieToList(new Sharpie("pink", 3));
            for (int i = 0; i < SharpieSet.Sharpies.Count; i++)
            {
                Console.WriteLine("{0}, {1}, {2}", SharpieSet.Sharpies[i].color, SharpieSet.Sharpies[i].width, SharpieSet.Sharpies[i].inkAmount);
            }
            Console.WriteLine("Usable: " + SharpieSet.CountUsable());
            SharpieSet.Sharpies[0].Use(100);
            SharpieSet.RemoveTrash();
            for (int i = 0; i < SharpieSet.SharpiesUsable.Count; i++)
            {
                Console.WriteLine("{0}, {1}, {2}", SharpieSet.SharpiesUsable[i].color, SharpieSet.SharpiesUsable[i].width, SharpieSet.SharpiesUsable[i].inkAmount);
            }
            Console.WriteLine("Usable: " + SharpieSet.CountUsable());
            Console.ReadLine();

            


        }


    }
}
