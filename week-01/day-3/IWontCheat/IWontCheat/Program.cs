using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a program that writes this line 100 times:
            // "I won't cheat on the exam!"
            int counter = 1;
            Console.WriteLine(counter + ". I won't cheat on the exam!");
            for (int i = 0; i < 99; i++)
            {
                counter = counter + 1;
                Console.WriteLine(counter + ". I won't cheat on the exam!");

            }
            if (counter == 101)
            {
                Console.WriteLine("101. Lie, Cheat, Steal!");
            }
            Console.ReadLine();
        }
    }
}