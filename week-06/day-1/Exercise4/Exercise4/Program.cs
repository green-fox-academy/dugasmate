using System;
using System.Linq;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new[] { 3, 9, 2, 8, 6, 5 };
            var squaredMore20 = n.Select(x => x * x).Where(x => x > 20);
            foreach (var number in squaredMore20)
            {
                Console.WriteLine(number);
            }
            Console.ReadLine();
        }
    }
}
