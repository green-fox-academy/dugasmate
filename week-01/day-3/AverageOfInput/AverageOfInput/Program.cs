using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for 5 integers in a row,
            // then it should print the sum and the average of these numbers like:
            //
            // Sum: 22, Average: 4.4
            Console.WriteLine("Gimme 5 integer numbers and I tell you the sum and the average.");
            string input = Console.ReadLine();
            int number = Int32.Parse(input);
            string input2 = Console.ReadLine();
            int number2 = Int32.Parse(input2);
            string input3 = Console.ReadLine();
            int number3 = Int32.Parse(input3);
            string input4 = Console.ReadLine();
            int number4 = Int32.Parse(input4);
            string input5 = Console.ReadLine();
            int number5 = Int32.Parse(input5);
            Console.WriteLine("Sum: " + (number + number2 + number3 + number4 + number5) + " Average: " + ((number + number2 + number3 + number4 + number5) / 5));
            Console.ReadLine();
        }
    }
}