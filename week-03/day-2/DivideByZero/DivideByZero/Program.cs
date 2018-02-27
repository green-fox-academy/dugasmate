using System;

namespace DivideByZero
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            NumberPrint(input);
            Console.ReadLine();
        }
        static void NumberPrint(int input)
        {
            try
            {
                int output = 10 / input;
                Console.WriteLine(output);
            }
            catch (DivideByZeroException)
            {
                    Console.WriteLine("Can't divide by 0!");
            }
        }


    }
}
