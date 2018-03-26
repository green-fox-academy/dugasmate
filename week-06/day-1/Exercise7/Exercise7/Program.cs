using System;
using System.Linq;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };
            var theWord = cities.Where(x => x.StartsWith("A") && x.EndsWith("I"));
            foreach (var cha in theWord)
            {
                Console.WriteLine(cha);
            }
            Console.ReadLine();
        }
    }
}
