using System;

namespace Numberadder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            Console.WriteLine(Adder(n));
            Console.ReadLine();
        }
        public static int Adder(int n)
        {
            if (n == 1)
            {
                return n;
            }
            else
            {
                return n + Adder(n -1);
                
            }
        }
    }
}
