using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kilometers to mile conversion! Give me an integer number!");
            string input = Console.ReadLine();
            int km = Int32.Parse(input);
            Console.WriteLine(input + " km is " + km * 0.621371 + " miles");
            Console.ReadLine();




        }
    }
}