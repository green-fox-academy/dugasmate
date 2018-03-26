using System;
using System.Linq;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };
            var evenNumbers = n.Where(x => x % 2 == 0);
            foreach (var evenNumber in evenNumbers)
            {
                Console.WriteLine(evenNumber);
            }
            Console.ReadLine();

        }
    }
}
