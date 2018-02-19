using System;

namespace Factorio
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create a function called `factorio`
            //   that returns it's input's factorial
            int input = Int32.Parse(Console.ReadLine());
            Factorio(input);
            Console.WriteLine(Factorio(input));
            Console.ReadLine();
        }
        static int Factorio(int input)
        {
            int result = input;
            for (int i = 1; i < input; i++)
            {
                result = result * i;
            }
            return result;
        }
    }
}