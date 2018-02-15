using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two numbers
            // Thw first number represents the number of girls that comes to a party, the
            // second the boys
            // It should print: The party is exellent!
            // If the the number of girls and boys are equal and there are more people coming than 20
            //
            // It should print: Quite cool party!
            // It there are more than 20 people coming but the girl - boy ratio is not 1-1
            //
            // It should print: Average party...
            // If there are less people coming than 20
            //
            // It should print: Sausage party
            // If no girls are coming, regardless the count of the people
            Console.WriteLine("Gimme the number of girls coming to the party!");
            string input = Console.ReadLine();
            int girls = Int32.Parse(input);
            Console.WriteLine("Gimme the number of boys coming to the party!");
            string input2 = Console.ReadLine();
            int boys = Int32.Parse(input2);
            if (boys == girls && boys + girls > 20)
            {
                Console.WriteLine("The party is exellent!");
            }
            else if (boys != girls && boys + girls > 20)
            {
                Console.WriteLine("Quite cool party!");
            }
            else if (boys + girls < 20 && girls > 0)
            {
                Console.WriteLine("Average party...");
            }
            else if (girls == 0 && boys > 0)
            {
                Console.WriteLine("Sausage party!");
            }
            else if (girls + boys == 20)
            {
                Console.WriteLine("Needs more people!");
            }
            else if (girls == 0 && boys == 0)
            {
                Console.WriteLine("Nobody here!");
            }
            Console.ReadLine();
        }
    }
}
