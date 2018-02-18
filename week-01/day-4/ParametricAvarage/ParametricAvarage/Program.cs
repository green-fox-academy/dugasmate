using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for a number.
            // It would ask this many times to enter an integer,
            // if all the integers are entered, it should print the sum and average of these
            // integers like:
            //
            // Sum: 22, Average: 4.4
            double answerForInteger = 0;
            Console.WriteLine("Gimme a number!");
            int askForInteger = Int32.Parse(Console.ReadLine());
            for (int i = 1; i <= askForInteger; i++)
            {
                Console.WriteLine("Gimme an integer number!");
                answerForInteger += Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine(answerForInteger);
            Console.WriteLine(answerForInteger / askForInteger);
            Console.ReadLine();

        }
    }
}