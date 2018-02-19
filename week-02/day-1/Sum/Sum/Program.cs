
using System;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Write a function called `sum` that sum all the numbers
            //   until the given parameter and returns with an integer
            Console.WriteLine("Give me 3 numbers!");
            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());
            int c = Int32.Parse(Console.ReadLine());
            Console.WriteLine("The sum is: " + Sum(a, b, c));
            Console.ReadLine();
        }
        static int Sum(int a, int b, int c)
        {
            return a + b + c;
        }
    }
}
