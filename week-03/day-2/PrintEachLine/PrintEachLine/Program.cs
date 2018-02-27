using System;
using System.IO;

namespace PrintEachLine
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that opens a file called "my-file.txt", then prints
            // each of lines form the file.
            // If the program is unable to read the file (for example it does not exists),
            // then it should print an error message like: "Unable to read file: my-file.txt"
            string path = @"C:\greenfox\dugasmate\week-03\day-2\PrintEachLine\my-file.txt";
            try
            {
                string[] content = File.ReadAllLines(path);
                for (int i = 0; i < content.Length; i++)
                {
                    Console.WriteLine(content[i]);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Unable to read file: my-file.txt");
            }

            Console.ReadLine();
        }
    }
}
