using System;

namespace CompareLength
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `p1`
            //   with the following content: `[1, 2, 3]`
            // - Create an array variable named `p2`
            //   with the following content: `[4, 5]`
            // - Print if `p2` has more elements than `p1`
            int[] p1 = { 1, 2, 3 };
            int[] p2 = { 4, 5 };
            if (p1.Length < p2.Length)
            {
                Console.WriteLine("P2 has more elements");
            }
            else
            {
                Console.WriteLine("P1 has more elements");
            }
            Console.ReadLine();
        }
    }
}