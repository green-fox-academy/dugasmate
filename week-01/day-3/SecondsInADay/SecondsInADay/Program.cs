using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentHours = 14;
            int currentMinutes = 34;
            int currentSeconds = 42;

            // Write a program that prints the remaining seconds (as an integer) from a
            // day if the current time is represented by the variables
            Console.WriteLine("Seconds left in the day: " + ((24 * 60 * 60) - (14 * 60 * 60 + 34 * 60 + 42)));
            Console.ReadLine();
        }
    }
}
