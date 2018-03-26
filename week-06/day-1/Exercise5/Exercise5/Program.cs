using System;
using System.Linq;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };
            var frequency = n.GroupBy(z => z).Select(z => z.Count());
            foreach (var item in frequency)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
