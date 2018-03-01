using System;

namespace Bunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            Console.WriteLine(EarCount(n));
            Console.ReadLine();
        }
        public static int EarCount(int n)
        {
            if (n == 1)
            {
                return 2;
            }
            else
            {

                return 2 + EarCount(n - 1);
            }
        }
    }
}
