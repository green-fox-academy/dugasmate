using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a program that prints all the even numbers between 0 and 500
            for (int i = 1; i < 501; i++)
            {
                if (i % 2 == 0)
                Console.WriteLine(i);
            }
            Console.WriteLine("Now we're even!");
            Console.ReadLine();

        }
    }
}