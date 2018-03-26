using System;
using System.Linq;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };
            var squaredPositives = n.Where(x => x > 0).Select(x => x * x);
            foreach (var squared in squaredPositives)
            {
                Console.WriteLine(squared);
            }
            Console.ReadLine();
        }
    }
}
