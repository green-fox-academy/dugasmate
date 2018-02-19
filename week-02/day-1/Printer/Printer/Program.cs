using System;

namespace Printer
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer("This", "was", "really", "hard!");
            Console.ReadLine();
        }

        static void Printer(params string[] input)
        {
            foreach (var output in input)
            {
                Console.WriteLine(output);
            }
        }
    }
}
