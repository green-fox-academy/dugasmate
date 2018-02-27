using System;
using System.IO;

namespace CopyFile
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a function that reads all lines of a file and writes the read lines to an other file (a.k.a copies the file)
            // It should take the filenames as parameters
            // It should return a boolean that shows if the copy was successful
            string pathFrom = @"C:\greenfox\dugasmate\week-03\day-2\CopyFile\file1.txt";
            string pathTo = @"C:\greenfox\dugasmate\week-03\day-2\CopyFile\file2.txt";
            Console.WriteLine(CopyPlz(pathFrom, pathTo));
            Console.ReadLine();

        }
        static bool CopyPlz(string pathFrom, string pathTo)
        {
            string[] content = File.ReadAllLines(pathFrom);
            if (true)
            {
                using (StreamWriter writer = new StreamWriter(pathTo))
                {

                    for (int i = 0; i < content.Length; i++)
                    {
                        writer.WriteLine(content[i]);
                    }
                }
                return true;
            }
        }
    }
}
