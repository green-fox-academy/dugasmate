using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crate a program that draws a chess table like this
            //
            // % % % %
            //  % % % %
            // % % % %
            //  % % % %
            // % % % %
            //  % % % %
            // % % % %
            //  % % % %
            //
            for (int i = 1; i <= 8; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine("% % % %");
                }
                else if (i % 2 == 0)
                {
                    Console.WriteLine(" % % % %");
                }
             
            }
            Console.ReadLine();
        }
    }
}