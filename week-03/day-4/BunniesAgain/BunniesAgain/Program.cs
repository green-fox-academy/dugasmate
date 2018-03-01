using System;

namespace BunniesAgain
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
            if (n % 2 == 0)
            {
                return 3 + EarCount(n - 1);
            }
            else
            {

                return 2 + EarCount(n - 1);
            }
        }
    }
}

