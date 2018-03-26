using System;
using System.IO;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\greenfox\dugasmate\week-03\day-2\TicTacToe\TicTacToe\win-o.txt";
            string[] content = File.ReadAllLines(path);
            // Prints the first line of the file
            for (int i = 0; i < content.Length; i++)
            {
                for (int j = 0; j < content.Length; j++)
                {

                    if (content[i][j] == content[i + 1][j] && content[i + 1][j] == content[i + 2][j])
                    {
                        Console.WriteLine(content[i][j]);
                    }
                    if (content[i][j] == content[i][j + 1] && content[i][j + 1] == content[i][j + 2])
                    {
                        Console.WriteLine("NICE");
                    }
                   
                }
            }
            Console.ReadLine();
        }
    }
}
