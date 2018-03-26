using System;
using System.Linq;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };
            var oddNumbers = n.Where(x => x % 2 != 0).Average();

                Console.WriteLine(oddNumbers);

            Console.ReadLine();
        }
    }
}
