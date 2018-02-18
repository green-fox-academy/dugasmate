using System;

namespace DrawTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gimme a number!");
            string input = Console.ReadLine();
            int row = Int32.Parse(input);
            int col = row;
            string star = "*";
            for (int i = 1; i <= row; i++)
            {
                for (int i = 0; i < length; i++)
                {

                }
                Console.WriteLine(star);
                star = star + "*";
                
             
            }
            Console.ReadLine();
        }
    }
}
