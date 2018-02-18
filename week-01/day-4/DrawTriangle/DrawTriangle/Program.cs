using System;

namespace DrawTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gimme a number!");
            string input = Console.ReadLine();
            int lines = Int32.Parse(input);
            string star = "*";
            for (int i = 1; i <= lines; i++)
            {
                Console.WriteLine(star);
                star = star + "*";
                
             
            }
            Console.ReadLine();
        }
    }
}
