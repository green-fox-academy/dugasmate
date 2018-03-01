using System;

namespace Refactorio
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Int32.Parse(Console.ReadLine());
            Console.WriteLine(FactorialR(num));
            Console.ReadLine();
        }
        public static int FactorialR(int num)
        {
            if (num == 1)
            {
                return 1;
            }
            else
            {
                return num * FactorialR(num - 1);
            }
        }
    }
}
