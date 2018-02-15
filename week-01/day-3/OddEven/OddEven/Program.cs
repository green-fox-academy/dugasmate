using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input,
            // Then prints "Odd" if the number is odd, or "Even" if it is even.
            Console.WriteLine("I will tell you if a number is odd or even");
            string input = Console.ReadLine();
            int number = Int32.Parse(input);
            if (number % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");

            }
            Console.ReadLine();

        }
            
    }
}