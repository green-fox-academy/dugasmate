using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Fox> foxes = new List<Fox>
            {
                new Fox("Arno", "Palida", "Green"),
                new Fox("Dani", "Other", "Brown"),
                new Fox("Nope", "Other", "Green"),
                new Fox("Mate", "Other", "Black"),
                new Fox("Blanka", "Palida", "Green")
            };
            var greenfoxes = foxes.Where(y => y.color == "Green");
            foreach (var green in greenfoxes)
            {
                Console.WriteLine(green.name + " is a " + green.color + " fox");
            }
            var greenPalidas = foxes.Where(y => y.color == "Green" && y.type == "Palida");
            foreach (var palida in greenPalidas)
            {
                Console.WriteLine(palida.name + " is a " + palida.color + " fox");
            }
            Console.ReadLine();
        }
    }
}
