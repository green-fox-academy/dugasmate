using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a program that asks for a number and prints the multiplication table with that number
            //
            // Example:
            // The number 15 should print:
            //
            // 1 * 15 = 15
            // 2 * 15 = 30
            // 3 * 15 = 45
            // 4 * 15 = 60
            // 5 * 15 = 75
            // 6 * 15 = 90
            // 7 * 15 = 105
            // 8 * 15 = 120
            // 9 * 15 = 135
            // 10 * 15 = 150
            Console.WriteLine("Gimme a number!");
            string input = Console.ReadLine();
            int number = Int32.Parse(input);
            Console.WriteLine("Check this out!");
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(i + " * " + number + " = " + (i * number));
            }
            Console.ReadLine();
        }
    }
}