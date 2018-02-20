using System;
using System.Collections.Generic;

using System;
using System.Collections.Generic;

namespace ElementFinder
{
    public class ElementFinder
    {
        public static void Main(string[] args)
        {
            var List = new List<int> { 1, 2, 3, 4, 5 };
            Console.WriteLine(ContainsSeven(List));
            // Write a method that checks if the arrayList contains "7" if it contains return "Hoorray" otherwise return "Noooooo"
            // The output should be: "Noooooo"
            // Do this again with a different solution using different list methods!
            Console.ReadLine();

        }
        static string ContainsSeven(List<int> List)
        {
            string input = Console.ReadLine();
            int number = Int32.Parse(input);
            string output = "Noooooo";
            foreach (var item in List)
            {
                if (item == number)
                {
                    output = "Hoorray";
                }
            }
            return output;

        }
    }
}