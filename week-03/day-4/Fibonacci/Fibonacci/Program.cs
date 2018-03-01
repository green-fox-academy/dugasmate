using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int p = Int32.Parse(Console.ReadLine());
            for (int i = 0; i <= p; i++)
            {
                Console.WriteLine(Fibonacci(i));
            }
            Console.ReadLine();
        }
        public static int Fibonacci(int n)
        {
            int a = 0;
            int b = 1;
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }
    }
}
