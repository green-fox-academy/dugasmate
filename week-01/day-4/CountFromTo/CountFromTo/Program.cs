using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a program that asks for two numbers
            // If the second number is not bigger than the first one it should print:
            // "The second number should be bigger"
            //
            // If it is bigger it should count from the first number to the second by one
            //
            // example:
            //
            // first number: 3, second number: 6, should print:
            //
            // 3
            // 4
            // 5
            Console.WriteLine("Gimme two numbers!");
            string input = Console.ReadLine();
            int number = Int32.Parse(input);
            string input2 = Console.ReadLine();
            int number2 = Int32.Parse(input2);
            if (number > number2)
            {
                Console.WriteLine("The second number should be bigger");
            }
            else
                Console.WriteLine(number);
             while (number < number2 - 1)
            {
                number = number + 1;
                Console.WriteLine(number);
            }            Console.ReadLine();
        }
    }
}