using System;
using System.IO;

namespace WriteSingleLine
{
    class Program
    {
        static void Main(string[] args)
        {
            // Open a file called "my-file.txt"
            // Write your name in it as a single line
            // If the program is unable to write the file,
            // then it should print an error message like: "Unable to write file: my-file.txt"
            string path = @"C:\greenfox\dugasmate\week-03\day-2\WriteSingleLine\my-file.txt";
            try
            {
                File.ReadAllLines(path);
                using (StreamWriter writer = new StreamWriter(path))
                {

                    writer.WriteLine("Dugas Máté");

                }
            }
            catch (Exception)
            {
                Console.WriteLine("Unable to write file: my-file.txt");
            }
            
            Console.ReadLine();
        }
    }
}
