using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two integers
            // The first represents the number of chickens the farmer has
            // The second represents the number of pigs owned by the farmer
            // It should print how many legs all the animals have
            Console.WriteLine("How many chickens do you have?");
            string chickeninput = Console.ReadLine();
            int chickennumber = Int32.Parse(chickeninput);
            Console.WriteLine("How many pigs do you have?");
            string piginput = Console.ReadLine();
            int pignumber = Int32.Parse(piginput);
            Console.WriteLine((chickennumber * 2 + pignumber * 4) + " legs! Nice!");
            Console.ReadLine();


        }
    }
}
