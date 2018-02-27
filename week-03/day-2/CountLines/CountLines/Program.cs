using System;
using System.IO;

namespace CountLines
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a function that takes a filename as string,
            // then returns the number of lines the file contains.
            // It should return zero if it can't open the file, and
            // should not raise any error.
            string fileName = @"C:\greenfox\dugasmate\week-03\day-2\CountLines\my-file.txt";
            Console.WriteLine(NumberOfLines(fileName));
            Console.ReadLine();
        }
        static int NumberOfLines(string fileName)
        {
            int output = -1;
            try
            {
                string[] content = File.ReadAllLines(fileName);
                for (int i = 0; i < content.Length; i++)
                {
                    output = (i+1);
                }
            }
            catch (Exception)
            {
                output = 0;
            }
            return output;
        }
    }
}
