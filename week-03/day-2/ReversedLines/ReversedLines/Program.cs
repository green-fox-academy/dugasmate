using System;
using System.IO;

namespace ReversedLines
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\greenfox\dugasmate\week-03\day-2\ReversedLines\reversed.txt";
            string[] content = File.ReadAllLines(path);
            LineReverse(content);
            Console.ReadLine();
        }
        static void LineReverse(string[] content)
        {
            for (int i = 0; i < content.Length; i++)
            {
                for (int j = content[i].Length - 1; j >= 0; j--)
                {
                    Console.Write(content[i][j]);
                    if (j == 0)
                    {
                        Console.WriteLine();
                    }
                }
            }

        }
    }
}
