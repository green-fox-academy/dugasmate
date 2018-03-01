using System;

namespace Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            Counter(n);
            Console.ReadLine();
        }
        public static void Counter(int n)
        {
            if (n == 1)
            {
                Console.WriteLine(n);
            }
            else
            {
                Counter(n - 1);
                Console.WriteLine(n);
            }
        }
    }
}
