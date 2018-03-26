using System;
using System.Linq;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to find the uppercase characters in a string!
            string daSTring = "NAMIVaaaaAanN?";
            var upper = daSTring.Where(x => char.IsUpper(x));
            foreach (var letters in upper)
            {
                Console.WriteLine(letters);
            }
            Console.ReadLine();
        }
    }
}
