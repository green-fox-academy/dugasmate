using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 13;
            int B = 22;
            float AFl = 13;
            float BFl = 22;
            Console.WriteLine(A + B);
            Console.WriteLine(B - A);
            Console.WriteLine(B * A);
            Console.WriteLine(BFl / AFl);
            Console.WriteLine(B / A);
            Console.WriteLine(BFl % AFl);
            Console.Read();
        }
    }
}