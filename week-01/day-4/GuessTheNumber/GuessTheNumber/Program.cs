using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that stores a number, and the user has to figure it out.
            // The user can input guesses, after each guess the program would tell one
            // of the following:
            //
            // The stored number is higher
            // The stried number is lower
            // You found the number: 8

                Console.WriteLine("Guess the number!");
                int guess = 0;
                int solution = 8;
            
            while (guess != solution)
            {
                guess = Int32.Parse(Console.ReadLine());
                if (guess > solution)
                {
                    Console.WriteLine("Stored number is lower");
                }

                else if (guess < solution)
                {
                    Console.WriteLine("Stored number is higher");
                }
            

            }
            if (guess == solution)
            {
                Console.WriteLine("You found the number: " + solution);
            }
            Console.ReadLine();
        }
    }
}
