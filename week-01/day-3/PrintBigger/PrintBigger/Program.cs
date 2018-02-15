using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two numbers and prints the bigger one
            Console.WriteLine("Gimme two numbers!");
            string input = Console.ReadLine();
            int number = Int32.Parse(input);
            string input2 = Console.ReadLine();
            int number2 = Int32.Parse(input2);
            if (number > number2)
            {
                Console.WriteLine(number + " is bigger!");
            }
            else if (number < number2)
            {
                Console.WriteLine(number2 + " is bigger!");
            }
            else
            {
                Console.WriteLine("Same number!");
            }
            Console.ReadLine();
        }
    }
}