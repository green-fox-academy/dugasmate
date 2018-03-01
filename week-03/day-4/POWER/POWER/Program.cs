using System;

namespace POWER
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            int powerOf = Int32.Parse(Console.ReadLine());
            Console.WriteLine(PowerUp(n, powerOf));
            Console.ReadLine();
        }
        public static int PowerUp(int n, int powerOf)
        {
            if (powerOf == 0)
            {
                return 1;
            }
            else
            {
                return n * PowerUp(n, powerOf - 1);
            }
        }
    }
}
