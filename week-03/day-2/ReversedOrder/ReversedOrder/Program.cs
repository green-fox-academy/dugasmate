using System;
using System.IO;

namespace ReversedOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\greenfox\dugasmate\week-03\day-2\ReversedOrder\reverseorder.txt";
            string[] content = File.ReadAllLines(path);
            ReverseOrder(content);
            Console.ReadLine();
        }
        static void ReverseOrder(string[] content)
        {
            for (int i = content.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(content[i]);
            }

        }
    }
}
