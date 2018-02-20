using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gimme the range of numbers!");
            int guess = 0;
            Random rnd = new Random();
            int solutionFrom = Int32.Parse(Console.ReadLine());
            int solutionTo = Int32.Parse(Console.ReadLine());
            int solution = rnd.Next(solutionFrom, solutionTo);
            int elet = 5;
            Console.WriteLine("Guess the number!");
                while (guess != solution)
                {
                    guess = Int32.Parse(Console.ReadLine());
                    if (guess > solution)
                    {
                        Console.WriteLine("Stored number is lower");
                        elet--;
                    }

                    else if (guess < solution)
                    {
                        Console.WriteLine("Stored number is higher");
                        elet--;
                    }
                    Console.WriteLine("Lives: " + elet);
                if (elet == 0)
                {
                    Console.WriteLine("The End");
                    break;

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
