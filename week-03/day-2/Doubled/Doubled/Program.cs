using System;
using System.IO;

namespace Doubled
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\greenfox\dugasmate\week-03\day-2\Doubled\doubled.txt";
            string[] content = File.ReadAllLines(path);
            DoubleFokker(content);
            Console.ReadLine();
        }
        static void DoubleFokker(string[] content)
        {
            for (int i = 0; i < content.Length; i++)
            {
                
                for (int j = 0; j < content[i].Length; j++)
                {
                    if (j % 2 == 0)
                    {
                        Console.Write(content[i][j]);
                    }
                    else if (j == content[i].Length - 1)
                    {
                        Console.WriteLine();
                    }
                }
        }

        }
    }
}
