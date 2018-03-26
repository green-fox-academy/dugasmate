using System;
using System.Linq;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            string daString = "It is what it is";
            var frequency = daString.ToLower().GroupBy(x => x).Select(x => x.Count());
            foreach (var cha in frequency)
            {
                Console.WriteLine(cha);
            }
            Console.ReadLine();
        }
    }
}
